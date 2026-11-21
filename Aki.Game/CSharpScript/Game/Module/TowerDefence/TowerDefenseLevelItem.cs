using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AFA RID: 15098
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseLevelItem : GridProxyAbstract<TowerDefenseGroupData>
	{
		// Token: 0x06026C67 RID: 158823 RVA: 0x00AD91EC File Offset: 0x00AD73EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIExtendToggleTextureTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIExtendToggleTextTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIExtendToggleTextTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIExtendToggleTextureTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026C68 RID: 158824 RVA: 0x00AD94AC File Offset: 0x00AD76AC
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			}
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnUndeterminedClicked.Add(new Action(this.OnUndeterminedClicked));
		}

		// Token: 0x06026C69 RID: 158825 RVA: 0x00AD94F8 File Offset: 0x00AD76F8
		public override void Refresh(TowerDefenseGroupData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshGroupInfo(data);
			if (this.IsBossRush)
			{
				this.SetSubLayoutActive(false);
				this.RefreshSelectionVisual();
				return;
			}
			if (this.SubLayout == null)
			{
				this.SubLayout = new GenericLayout<TowerDefenseSubLevelItem, TowerDefenseSubLevelData>(base.GetVerticalLayout(11), () => new TowerDefenseSubLevelItem(), base.GetItem(12).GetOwner() as AUIBaseActor, false, true);
			}
			this.SubLayout.RefreshByData(this.BuildSubDataList(data), null, false);
			this.Expanded = this.IsGroupSelected();
			this.RefreshSelectionVisual();
		}

		// Token: 0x06026C6A RID: 158826 RVA: 0x00AD95A0 File Offset: 0x00AD77A0
		public void RefreshSelectionVisual()
		{
			bool flag = this.IsGroupLocked();
			bool flag2 = this.IsGroupSelected();
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (this.IsBossRush)
			{
				if (flag)
				{
					if (extendToggle != null)
					{
						extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
						return;
					}
				}
				else if (extendToggle != null)
				{
					extendToggle.SetToggleStateForce(flag2 ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
				}
				return;
			}
			if (!flag2)
			{
				this.Expanded = false;
			}
			if (flag)
			{
				if (extendToggle != null)
				{
					extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
				}
			}
			else if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce((flag2 && this.Expanded) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			this.SetSubLayoutActive(flag2 && this.Expanded);
			if (this.SubLayout != null)
			{
				foreach (TowerDefenseSubLevelItem towerDefenseSubLevelItem in this.SubLayout.GetLayoutItemList())
				{
					towerDefenseSubLevelItem.RefreshSelectionVisual();
				}
			}
		}

		// Token: 0x06026C6B RID: 158827 RVA: 0x00AD968C File Offset: 0x00AD788C
		public void RefreshRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			bool uiactive = false;
			foreach (int id in this.Data.SubStageIds)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id);
				int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
				if (TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId))
				{
					uiactive = true;
					break;
				}
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			if (this.SubLayout != null)
			{
				foreach (TowerDefenseSubLevelItem towerDefenseSubLevelItem in this.SubLayout.GetLayoutItemList())
				{
					towerDefenseSubLevelItem.RefreshRedDot();
				}
			}
		}

		// Token: 0x06026C6C RID: 158828 RVA: 0x00AD9788 File Offset: 0x00AD7988
		private bool IsGroupLocked()
		{
			if (this.Data == null)
			{
				return true;
			}
			bool flag = false;
			foreach (int id in this.Data.SubStageIds)
			{
				if (TowerDefenseController.Instance.CheckStageUnlockById(id))
				{
					flag = true;
					break;
				}
			}
			return !flag;
		}

		// Token: 0x06026C6D RID: 158829 RVA: 0x00AD97FC File Offset: 0x00AD79FC
		private bool IsGroupSelected()
		{
			if (this.Data == null)
			{
				return false;
			}
			bool result = false;
			foreach (int arg in this.Data.SubStageIds)
			{
				if (this.Data.IsSelectedGetter(arg))
				{
					result = true;
					break;
				}
			}
			return result;
		}

		// Token: 0x06026C6E RID: 158830 RVA: 0x00AD9874 File Offset: 0x00AD7A74
		public void RefreshOnTick()
		{
			if (this.Data == null || this.IsBossRush)
			{
				return;
			}
			List<int> subStageIds = this.Data.SubStageIds;
			bool flag = false;
			foreach (int id in subStageIds)
			{
				if (TowerDefenseController.Instance.CheckStageUnlockById(id))
				{
					flag = true;
					break;
				}
			}
			if (flag != this.CanExpand)
			{
				this.Refresh(this.Data, false, 0);
				return;
			}
			if (!flag)
			{
				this.RefreshDescText(subStageIds, false);
			}
		}

		// Token: 0x06026C6F RID: 158831 RVA: 0x00AD9910 File Offset: 0x00AD7B10
		private void RefreshGroupInfo(TowerDefenseGroupData data)
		{
			List<int> subStageIds = data.SubStageIds;
			this.IsBossRush = (subStageIds.Count > 0 && InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(subStageIds[0]).Value.BossRush);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!this.IsBossRush);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(this.IsBossRush);
			}
			InstanceDungeonTitle? titleConfig = InstanceDungeonConfig.Instance.GetTitleConfig(data.GroupId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), (titleConfig != null) ? titleConfig.Value.CommonText : "", Array.Empty<object>());
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(TowerDefenseLevelItem.BuildRomeTextureName(base.DisplayIndex + 1));
			UUITexture texture = base.GetTexture(4);
			UUITexture texture2 = base.GetTexture(16);
			if (texture != null)
			{
				texture.SetUIActive(!this.IsBossRush);
			}
			if (texture2 != null)
			{
				texture2.SetUIActive(this.IsBossRush);
			}
			base.TrySetTextureByPath(resourcePath, this.IsBossRush ? texture2 : texture, null, null);
			this.RefreshTransitionColors();
			if (this.IsBossRush)
			{
				this.RefreshBossRushGroupInfo(subStageIds[0]);
				return;
			}
			this.RefreshNormalGroupInfo(subStageIds);
		}

		// Token: 0x06026C70 RID: 158832 RVA: 0x00AD9A64 File Offset: 0x00AD7C64
		private void RefreshTransitionColors()
		{
			bool isBossRush = this.IsBossRush;
			UUIExtendToggleTextureTransition uiExtendToggleTextureTransition = base.GetUiExtendToggleTextureTransition(isBossRush ? 17 : 13);
			if (uiExtendToggleTextureTransition != null)
			{
				this.SetTextureTransitionColor(uiExtendToggleTextureTransition, isBossRush ? "e9d7da" : "a6bdca", isBossRush ? "e9d7da" : "182b34");
			}
			UUIExtendToggleTextTransition uiExtendToggleTextTransition = base.GetUiExtendToggleTextTransition(14);
			if (uiExtendToggleTextTransition != null)
			{
				this.SetTextTransitionColor(uiExtendToggleTextTransition, isBossRush ? "ddc7cb" : "adc2cd", isBossRush ? "ffffff" : "182b34");
			}
			UUIExtendToggleTextTransition uiExtendToggleTextTransition2 = base.GetUiExtendToggleTextTransition(15);
			if (uiExtendToggleTextTransition2 != null)
			{
				this.SetTextTransitionColor(uiExtendToggleTextTransition2, isBossRush ? "dfe8ec66" : "5d6e77", isBossRush ? "ffffff7f" : "6a7b84");
			}
		}

		// Token: 0x06026C71 RID: 158833 RVA: 0x00AD9B14 File Offset: 0x00AD7D14
		private void SetTextureTransitionColor(UUIExtendToggleTextureTransition transition, string uncheckedHex, string checkedHex)
		{
			FExtendToggleColorTransition transitionColors = transition.TransitionColors;
			FColor fcolor = FColor.FromHex(uncheckedHex);
			FColor fcolor2 = FColor.FromHex(checkedHex);
			transitionColors.UnCheckedUnHoverColor = fcolor;
			transitionColors.UnCheckedHoverColor = fcolor;
			transitionColors.UnCheckedPressedColor = fcolor;
			transitionColors.CheckedUnHoverColor = fcolor2;
			transitionColors.CheckedHoverColor = fcolor2;
			transitionColors.CheckedPressedColor = fcolor2;
			transition.TransitionColors = transitionColors;
		}

		// Token: 0x06026C72 RID: 158834 RVA: 0x00AD9B68 File Offset: 0x00AD7D68
		private void SetTextTransitionColor(UUIExtendToggleTextTransition transition, string uncheckedHex, string checkedHex)
		{
			FExtendToggleTextTransitionState transitionState = transition.TransitionState;
			transitionState.UnCheckUnHoverState = this.BuildTextStateColor(transitionState.UnCheckUnHoverState, uncheckedHex);
			transitionState.UnCheckHoverState = this.BuildTextStateColor(transitionState.UnCheckHoverState, uncheckedHex);
			transitionState.UnCheckPressedState = this.BuildTextStateColor(transitionState.UnCheckPressedState, uncheckedHex);
			transitionState.CheckUnHoverState = this.BuildTextStateColor(transitionState.CheckUnHoverState, checkedHex);
			transitionState.CheckHoverState = this.BuildTextStateColor(transitionState.CheckHoverState, checkedHex);
			transitionState.CheckPressedState = this.BuildTextStateColor(transitionState.CheckPressedState, checkedHex);
			transition.TransitionState = transitionState;
		}

		// Token: 0x06026C73 RID: 158835 RVA: 0x00AD9BF5 File Offset: 0x00AD7DF5
		private FTextTransitionInfoOfState BuildTextStateColor(FTextTransitionInfoOfState state, string hex)
		{
			state.bSetFontColor = true;
			state.FontColor = FColor.FromHex(hex);
			return state;
		}

		// Token: 0x06026C74 RID: 158836 RVA: 0x00AD9C0C File Offset: 0x00AD7E0C
		private void RefreshNormalGroupInfo(List<int> ids)
		{
			bool flag = false;
			foreach (int id in ids)
			{
				if (TowerDefenseController.Instance.CheckStageUnlockById(id))
				{
					flag = true;
					break;
				}
			}
			bool uiactive = false;
			foreach (int id2 in ids)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id2);
				int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
				if (TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId))
				{
					uiactive = true;
					break;
				}
			}
			this.CanExpand = flag;
			bool flag2 = !flag;
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(flag2);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(!flag2);
			}
			UUIItem item4 = base.GetItem(10);
			if (item4 != null)
			{
				item4.SetUIActive(uiactive);
			}
			this.RefreshDescText(ids, flag);
		}

		// Token: 0x06026C75 RID: 158837 RVA: 0x00AD9D44 File Offset: 0x00AD7F44
		private void RefreshBossRushGroupInfo(int stageId)
		{
			this.CanExpand = false;
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(stageId);
			int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
			bool flag = TowerDefenseController.Instance.CheckStageUnlockById(stageId);
			bool uiactive = TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId);
			UUIItem item = base.GetItem(8);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(7);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(10);
			if (item4 != null)
			{
				item4.SetUIActive(uiactive);
			}
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			if (flag)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "TowerDefence_GPint", new <>z__ReadOnlySingleElementList<object>(TowerDefenseController.Instance.GetRecordByStageId(stageId)));
				return;
			}
			ITowerDefenseLockedHint towerDefenseLockedHint = TowerDefenseController.Instance.BuildStageLockedHintById(stageId);
			if (towerDefenseLockedHint == null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, "TowerDefence_Lcok_TipsText", Array.Empty<object>());
				return;
			}
			if (towerDefenseLockedHint.Args != null)
			{
				LguiUtil.Instance.SetLocalTextNew(text, towerDefenseLockedHint.TextId, towerDefenseLockedHint.Args);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, towerDefenseLockedHint.TextId, Array.Empty<object>());
		}

		// Token: 0x06026C76 RID: 158838 RVA: 0x00AD9E88 File Offset: 0x00AD8088
		private void RefreshDescText(List<int> ids, bool anyUnlock)
		{
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			if (anyUnlock)
			{
				int num = 0;
				foreach (int id in ids)
				{
					if (TowerDefenseController.Instance.CheckStagePassedById(id))
					{
						num++;
					}
				}
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ids.Count);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			int num2 = 0;
			if (ids.Count > 0)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(ids[0]);
				num2 = ((towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0);
			}
			string text2 = (num2 > 0) ? TowerDefenseController.Instance.BuildInstanceCountDownText(num2) : null;
			text.SetText(text2 ?? "", true);
		}

		// Token: 0x06026C77 RID: 158839 RVA: 0x00AD9F90 File Offset: 0x00AD8190
		private static string BuildRomeTextureName(int index)
		{
			int num = Math.Max(1, index);
			string text;
			if (num >= 10)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			string str = text;
			return "T_ComRomeText_" + str;
		}

		// Token: 0x06026C78 RID: 158840 RVA: 0x00AD9FF4 File Offset: 0x00AD81F4
		private List<TowerDefenseSubLevelData> BuildSubDataList(TowerDefenseGroupData group)
		{
			List<TowerDefenseSubLevelData> list = new List<TowerDefenseSubLevelData>();
			foreach (int stageId in group.SubStageIds)
			{
				list.Add(new TowerDefenseSubLevelData
				{
					StageId = stageId,
					OnClickCb = group.OnClickSubLevel,
					IsSelectedGetter = group.IsSelectedGetter
				});
			}
			return list;
		}

		// Token: 0x06026C79 RID: 158841 RVA: 0x00ADA074 File Offset: 0x00AD8274
		private void OnClickToggle(EToggleState state)
		{
			if (this.IsGroupLocked())
			{
				this.RefreshSelectionVisual();
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (this.IsBossRush)
			{
				if (this.IsGroupSelected())
				{
					if (extendToggle != null)
					{
						extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
						return;
					}
				}
				else
				{
					int num = (this.Data != null && this.Data.SubStageIds.Count > 0) ? this.Data.SubStageIds[0] : 0;
					if (num > 0)
					{
						this.Data.OnClickSubLevel(num);
					}
				}
				return;
			}
			if (this.IsGroupSelected())
			{
				this.Expanded = !this.Expanded;
				if (extendToggle != null)
				{
					extendToggle.SetToggleStateForce(this.Expanded ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
				}
				this.SetSubLayoutActive(this.Expanded);
				return;
			}
			this.Expanded = true;
			int num2 = this.PickDefaultSubInstance();
			if (num2 > 0)
			{
				this.Data.OnClickSubLevel(num2);
			}
		}

		// Token: 0x06026C7A RID: 158842 RVA: 0x00ADA15C File Offset: 0x00AD835C
		private int PickDefaultSubInstance()
		{
			if (this.Data == null)
			{
				return 0;
			}
			List<int> subStageIds = this.Data.SubStageIds;
			foreach (int num in subStageIds)
			{
				if (InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(num).Value.Difficulty == 1)
				{
					return num;
				}
			}
			if (subStageIds.Count <= 0)
			{
				return 0;
			}
			return subStageIds[0];
		}

		// Token: 0x06026C7B RID: 158843 RVA: 0x00ADA1F4 File Offset: 0x00AD83F4
		private bool OnCanExecuteChange()
		{
			return !this.IsGroupLocked();
		}

		// Token: 0x06026C7C RID: 158844 RVA: 0x00ADA200 File Offset: 0x00AD8400
		private void OnUndeterminedClicked()
		{
			if (this.IsGroupLocked())
			{
				string textId = this.IsBossRush ? "TowerDefence_Lcok_TipsText" : "TowerDefence_LevelLocked";
				ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
			}
		}

		// Token: 0x06026C7D RID: 158845 RVA: 0x00ADA23C File Offset: 0x00AD843C
		private void SetSubLayoutActive(bool active)
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(11);
			if (verticalLayout == null)
			{
				return;
			}
			UUIItem uuiitem = verticalLayout.RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(active);
		}

		// Token: 0x04015356 RID: 86870
		private const string NormalIndexUncheckedColor = "a6bdca";

		// Token: 0x04015357 RID: 86871
		private const string NormalIndexCheckedColor = "182b34";

		// Token: 0x04015358 RID: 86872
		private const string NormalTitleUncheckedColor = "adc2cd";

		// Token: 0x04015359 RID: 86873
		private const string NormalTitleCheckedColor = "182b34";

		// Token: 0x0401535A RID: 86874
		private const string NormalDescUncheckedColor = "5d6e77";

		// Token: 0x0401535B RID: 86875
		private const string NormalDescCheckedColor = "6a7b84";

		// Token: 0x0401535C RID: 86876
		private const string HardIndexUncheckedColor = "e9d7da";

		// Token: 0x0401535D RID: 86877
		private const string HardIndexCheckedColor = "e9d7da";

		// Token: 0x0401535E RID: 86878
		private const string HardTitleUncheckedColor = "ddc7cb";

		// Token: 0x0401535F RID: 86879
		private const string HardTitleCheckedColor = "ffffff";

		// Token: 0x04015360 RID: 86880
		private const string HardDescUncheckedColor = "dfe8ec66";

		// Token: 0x04015361 RID: 86881
		private const string HardDescCheckedColor = "ffffff7f";

		// Token: 0x04015362 RID: 86882
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TowerDefenseSubLevelItem, TowerDefenseSubLevelData> SubLayout;

		// Token: 0x04015363 RID: 86883
		private bool CanExpand;

		// Token: 0x04015364 RID: 86884
		private bool IsBossRush;

		// Token: 0x04015365 RID: 86885
		private bool Expanded;

		// Token: 0x04015366 RID: 86886
		[Nullable(2)]
		private TowerDefenseGroupData Data;

		// Token: 0x020096F4 RID: 38644
		[NullableContext(0)]
		private class ELevelItemComponent
		{
			// Token: 0x0402F1D6 RID: 192982
			public const int Toggle = 0;

			// Token: 0x0402F1D7 RID: 192983
			public const int NormalPnl = 1;

			// Token: 0x0402F1D8 RID: 192984
			public const int DifficultPnl = 2;

			// Token: 0x0402F1D9 RID: 192985
			public const int IndexIconPnl = 3;

			// Token: 0x0402F1DA RID: 192986
			public const int IndexIconTex = 4;

			// Token: 0x0402F1DB RID: 192987
			public const int TitleTxt = 5;

			// Token: 0x0402F1DC RID: 192988
			public const int DescTxt = 6;

			// Token: 0x0402F1DD RID: 192989
			public const int DropdownPnl = 7;

			// Token: 0x0402F1DE RID: 192990
			public const int LockPnl = 8;

			// Token: 0x0402F1DF RID: 192991
			public const int FinishPnl = 9;

			// Token: 0x0402F1E0 RID: 192992
			public const int RedDotItem = 10;

			// Token: 0x0402F1E1 RID: 192993
			public const int SubLevelLayout = 11;

			// Token: 0x0402F1E2 RID: 192994
			public const int SubLevelItem = 12;

			// Token: 0x0402F1E3 RID: 192995
			public const int IndexIconTransition = 13;

			// Token: 0x0402F1E4 RID: 192996
			public const int TitleTransition = 14;

			// Token: 0x0402F1E5 RID: 192997
			public const int DescTransition = 15;

			// Token: 0x0402F1E6 RID: 192998
			public const int BossIndexTex = 16;

			// Token: 0x0402F1E7 RID: 192999
			public const int BossIndexIconTransition = 17;
		}
	}
}
