using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B52 RID: 19282
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseLevelItem : GridProxyAbstract<TowerDefenseGroupData>
	{
		// Token: 0x06031ED7 RID: 204503 RVA: 0x00B95180 File Offset: 0x00B93380
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

		// Token: 0x06031ED8 RID: 204504 RVA: 0x00B95440 File Offset: 0x00B93640
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

		// Token: 0x06031ED9 RID: 204505 RVA: 0x00B9548C File Offset: 0x00B9368C
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

		// Token: 0x06031EDA RID: 204506 RVA: 0x00B95534 File Offset: 0x00B93734
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

		// Token: 0x06031EDB RID: 204507 RVA: 0x00B95620 File Offset: 0x00B93820
		public void RefreshRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			bool uiactive = this.Data.SubStageIds.Any(delegate(int id)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id);
				int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
				return TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId);
			});
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

		// Token: 0x06031EDC RID: 204508 RVA: 0x00B956CC File Offset: 0x00B938CC
		private bool IsGroupLocked()
		{
			if (this.Data == null)
			{
				return true;
			}
			return !this.Data.SubStageIds.Any((int id) => TowerDefenseController.Instance.CheckStageUnlockById(id));
		}

		// Token: 0x06031EDD RID: 204509 RVA: 0x00B9570A File Offset: 0x00B9390A
		private bool IsGroupSelected()
		{
			return this.Data != null && this.Data.SubStageIds.Any((int id) => this.Data.IsSelectedGetter(id));
		}

		// Token: 0x06031EDE RID: 204510 RVA: 0x00B95734 File Offset: 0x00B93934
		public void RefreshOnTick()
		{
			if (this.Data == null || this.IsBossRush)
			{
				return;
			}
			List<int> subStageIds = this.Data.SubStageIds;
			bool flag = subStageIds.Any((int id) => TowerDefenseController.Instance.CheckStageUnlockById(id));
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

		// Token: 0x06031EDF RID: 204511 RVA: 0x00B957A8 File Offset: 0x00B939A8
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

		// Token: 0x06031EE0 RID: 204512 RVA: 0x00B958FC File Offset: 0x00B93AFC
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

		// Token: 0x06031EE1 RID: 204513 RVA: 0x00B959AC File Offset: 0x00B93BAC
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

		// Token: 0x06031EE2 RID: 204514 RVA: 0x00B95A00 File Offset: 0x00B93C00
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

		// Token: 0x06031EE3 RID: 204515 RVA: 0x00B95A8D File Offset: 0x00B93C8D
		private FTextTransitionInfoOfState BuildTextStateColor(FTextTransitionInfoOfState state, string hex)
		{
			state.bSetFontColor = true;
			state.FontColor = FColor.FromHex(hex);
			return state;
		}

		// Token: 0x06031EE4 RID: 204516 RVA: 0x00B95AA4 File Offset: 0x00B93CA4
		private void RefreshNormalGroupInfo(List<int> ids)
		{
			bool flag = ids.Any((int id) => TowerDefenseController.Instance.CheckStageUnlockById(id));
			bool uiactive = ids.Any(delegate(int id)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(id);
				int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
				return TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId);
			});
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

		// Token: 0x06031EE5 RID: 204517 RVA: 0x00B95B64 File Offset: 0x00B93D64
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

		// Token: 0x06031EE6 RID: 204518 RVA: 0x00B95CA8 File Offset: 0x00B93EA8
		private void RefreshDescText(List<int> ids, bool anyUnlock)
		{
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			if (anyUnlock)
			{
				int value = ids.Count((int id) => TowerDefenseController.Instance.CheckStagePassedById(id));
				UUIText uuitext = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(value);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(ids.Count);
				uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				return;
			}
			int num = 0;
			if (ids.Count > 0)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(ids[0]);
				num = ((towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0);
			}
			string text2 = (num > 0) ? TowerDefenseController.Instance.BuildInstanceCountDownText(num) : null;
			text.SetText(text2 ?? "", true);
		}

		// Token: 0x06031EE7 RID: 204519 RVA: 0x00B95D84 File Offset: 0x00B93F84
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

		// Token: 0x06031EE8 RID: 204520 RVA: 0x00B95DE8 File Offset: 0x00B93FE8
		private List<TowerDefenseSubLevelData> BuildSubDataList(TowerDefenseGroupData group)
		{
			return (from id in @group.SubStageIds
			select new TowerDefenseSubLevelData
			{
				StageId = id,
				OnClickCb = @group.OnClickSubLevel,
				IsSelectedGetter = @group.IsSelectedGetter
			}).ToList<TowerDefenseSubLevelData>();
		}

		// Token: 0x06031EE9 RID: 204521 RVA: 0x00B95E24 File Offset: 0x00B94024
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

		// Token: 0x06031EEA RID: 204522 RVA: 0x00B95F0C File Offset: 0x00B9410C
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

		// Token: 0x06031EEB RID: 204523 RVA: 0x00B95FA4 File Offset: 0x00B941A4
		private bool OnCanExecuteChange()
		{
			return !this.IsGroupLocked();
		}

		// Token: 0x06031EEC RID: 204524 RVA: 0x00B95FB0 File Offset: 0x00B941B0
		private void OnUndeterminedClicked()
		{
			if (this.IsGroupLocked())
			{
				string textId = this.IsBossRush ? "TowerDefence_Lcok_TipsText" : "TowerDefence_LevelLocked";
				ScrollingTipsController.Instance.ShowTipsByTextId(textId, Array.Empty<object>());
			}
		}

		// Token: 0x06031EED RID: 204525 RVA: 0x00B95FEC File Offset: 0x00B941EC
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

		// Token: 0x0401AA04 RID: 109060
		private const string NormalIndexUncheckedColor = "a6bdca";

		// Token: 0x0401AA05 RID: 109061
		private const string NormalIndexCheckedColor = "182b34";

		// Token: 0x0401AA06 RID: 109062
		private const string NormalTitleUncheckedColor = "adc2cd";

		// Token: 0x0401AA07 RID: 109063
		private const string NormalTitleCheckedColor = "182b34";

		// Token: 0x0401AA08 RID: 109064
		private const string NormalDescUncheckedColor = "5d6e77";

		// Token: 0x0401AA09 RID: 109065
		private const string NormalDescCheckedColor = "6a7b84";

		// Token: 0x0401AA0A RID: 109066
		private const string HardIndexUncheckedColor = "e9d7da";

		// Token: 0x0401AA0B RID: 109067
		private const string HardIndexCheckedColor = "e9d7da";

		// Token: 0x0401AA0C RID: 109068
		private const string HardTitleUncheckedColor = "ddc7cb";

		// Token: 0x0401AA0D RID: 109069
		private const string HardTitleCheckedColor = "ffffff";

		// Token: 0x0401AA0E RID: 109070
		private const string HardDescUncheckedColor = "dfe8ec66";

		// Token: 0x0401AA0F RID: 109071
		private const string HardDescCheckedColor = "ffffff7f";

		// Token: 0x0401AA10 RID: 109072
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TowerDefenseSubLevelItem, TowerDefenseSubLevelData> SubLayout;

		// Token: 0x0401AA11 RID: 109073
		private bool CanExpand;

		// Token: 0x0401AA12 RID: 109074
		private bool IsBossRush;

		// Token: 0x0401AA13 RID: 109075
		private bool Expanded;

		// Token: 0x0401AA14 RID: 109076
		[Nullable(2)]
		private TowerDefenseGroupData Data;

		// Token: 0x0200ACD4 RID: 44244
		[NullableContext(0)]
		private class ELevelItemComponent
		{
			// Token: 0x04034826 RID: 215078
			public const int Toggle = 0;

			// Token: 0x04034827 RID: 215079
			public const int NormalPnl = 1;

			// Token: 0x04034828 RID: 215080
			public const int DifficultPnl = 2;

			// Token: 0x04034829 RID: 215081
			public const int IndexIconPnl = 3;

			// Token: 0x0403482A RID: 215082
			public const int IndexIconTex = 4;

			// Token: 0x0403482B RID: 215083
			public const int TitleTxt = 5;

			// Token: 0x0403482C RID: 215084
			public const int DescTxt = 6;

			// Token: 0x0403482D RID: 215085
			public const int DropdownPnl = 7;

			// Token: 0x0403482E RID: 215086
			public const int LockPnl = 8;

			// Token: 0x0403482F RID: 215087
			public const int FinishPnl = 9;

			// Token: 0x04034830 RID: 215088
			public const int RedDotItem = 10;

			// Token: 0x04034831 RID: 215089
			public const int SubLevelLayout = 11;

			// Token: 0x04034832 RID: 215090
			public const int SubLevelItem = 12;

			// Token: 0x04034833 RID: 215091
			public const int IndexIconTransition = 13;

			// Token: 0x04034834 RID: 215092
			public const int TitleTransition = 14;

			// Token: 0x04034835 RID: 215093
			public const int DescTransition = 15;

			// Token: 0x04034836 RID: 215094
			public const int BossIndexTex = 16;

			// Token: 0x04034837 RID: 215095
			public const int BossIndexIconTransition = 17;
		}
	}
}
