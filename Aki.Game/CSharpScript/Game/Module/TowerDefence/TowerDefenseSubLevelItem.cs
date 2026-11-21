using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AFB RID: 15099
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseSubLevelItem : GridProxyAbstract<TowerDefenseSubLevelData>
	{
		// Token: 0x06026C7F RID: 158847 RVA: 0x00ADA278 File Offset: 0x00AD8478
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIExtendToggleTextTransition));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggleTextTransition));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026C80 RID: 158848 RVA: 0x00ADA428 File Offset: 0x00AD8628
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

		// Token: 0x06026C81 RID: 158849 RVA: 0x00ADA474 File Offset: 0x00AD8674
		public override void Refresh(TowerDefenseSubLevelData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(data.StageId);
			bool flag = towerDefenseConfigById.Value.Difficulty == 1;
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), flag ? "TowerDefence_DifficultyNormal" : "TowerDefence_DifficultyHard", Array.Empty<object>());
			bool flag2 = TowerDefenseController.Instance.CheckStageUnlockById(data.StageId);
			bool flag3 = TowerDefenseController.Instance.CheckStagePassedById(data.StageId);
			UUIItem item3 = base.GetItem(5);
			if (item3 != null)
			{
				item3.SetUIActive(!flag2);
			}
			UUIItem item4 = base.GetItem(6);
			if (item4 != null)
			{
				item4.SetUIActive(flag2 && flag3);
			}
			int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
			UUIItem item5 = base.GetItem(7);
			if (item5 != null)
			{
				item5.SetUIActive(TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId));
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				if (!flag)
				{
					this.RefreshHardSubDescText(text, flag2, flag3);
				}
				else if (flag2)
				{
					LguiUtil.Instance.SetLocalTextNew(text, "TowerDefence_GPint", new <>z__ReadOnlySingleElementList<object>(TowerDefenseController.Instance.GetRecordByStageId(data.StageId)));
				}
				else
				{
					ITowerDefenseLockedHint towerDefenseLockedHint = TowerDefenseController.Instance.BuildStageLockedHintById(data.StageId);
					if (towerDefenseLockedHint != null)
					{
						if (towerDefenseLockedHint.Args != null)
						{
							LguiUtil.Instance.SetLocalTextNew(text, towerDefenseLockedHint.TextId, towerDefenseLockedHint.Args);
						}
						else
						{
							LguiUtil.Instance.SetLocalTextNew(text, towerDefenseLockedHint.TextId, Array.Empty<object>());
						}
					}
					else
					{
						LguiUtil.Instance.SetLocalTextNew(text, "TowerDefence_SubLevelLocked", Array.Empty<object>());
					}
				}
			}
			this.RefreshTransitionColors(flag);
			this.RefreshSelectionVisual();
		}

		// Token: 0x06026C82 RID: 158850 RVA: 0x00ADA650 File Offset: 0x00AD8850
		private void RefreshHardSubDescText(UUIText descTxt, bool unlocked, bool passed)
		{
			if (!unlocked)
			{
				LguiUtil.Instance.SetLocalTextNew(descTxt, "TowerDefence_SubLevelLocked", Array.Empty<object>());
				return;
			}
			if (passed)
			{
				LguiUtil.Instance.SetLocalTextNew(descTxt, "TowerDefence_SubLevelPassed", Array.Empty<object>());
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(descTxt, "TowerDefence_SubLevelUnpassed", Array.Empty<object>());
		}

		// Token: 0x06026C83 RID: 158851 RVA: 0x00ADA6A4 File Offset: 0x00AD88A4
		private void RefreshTransitionColors(bool isNormal)
		{
			UUIExtendToggleTextTransition uiExtendToggleTextTransition = base.GetUiExtendToggleTextTransition(8);
			if (uiExtendToggleTextTransition != null)
			{
				this.SetTextTransitionColor(uiExtendToggleTextTransition, isNormal ? "adc2cd" : "dad1cc", isNormal ? "182b34" : "dad1cc");
			}
			UUIExtendToggleTextTransition uiExtendToggleTextTransition2 = base.GetUiExtendToggleTextTransition(9);
			if (uiExtendToggleTextTransition2 != null)
			{
				this.SetTextTransitionColor(uiExtendToggleTextTransition2, isNormal ? "5d6e77" : "dad1cc7f", isNormal ? "182b34" : "dad1cc7f");
			}
		}

		// Token: 0x06026C84 RID: 158852 RVA: 0x00ADA714 File Offset: 0x00AD8914
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

		// Token: 0x06026C85 RID: 158853 RVA: 0x00ADA7A1 File Offset: 0x00AD89A1
		private FTextTransitionInfoOfState BuildTextStateColor(FTextTransitionInfoOfState state, string hex)
		{
			state.bSetFontColor = true;
			state.FontColor = FColor.FromHex(hex);
			return state;
		}

		// Token: 0x06026C86 RID: 158854 RVA: 0x00ADA7B8 File Offset: 0x00AD89B8
		public void RefreshSelectionVisual()
		{
			if (this.Data == null)
			{
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (!TowerDefenseController.Instance.CheckStageSelectableById(this.Data.StageId))
			{
				if (extendToggle != null)
				{
					extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
				}
				return;
			}
			bool flag = this.Data.IsSelectedGetter(this.Data.StageId);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06026C87 RID: 158855 RVA: 0x00ADA82C File Offset: 0x00AD8A2C
		public void RefreshRedDot()
		{
			if (this.Data == null)
			{
				return;
			}
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(this.Data.StageId);
			int instanceId = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(TowerDefenseModel.Instance.CheckTowerDefenseInstanceHasRedDot(instanceId));
		}

		// Token: 0x06026C88 RID: 158856 RVA: 0x00ADA890 File Offset: 0x00AD8A90
		private void OnClickToggle(EToggleState state)
		{
			if (this.Data == null)
			{
				return;
			}
			if (!TowerDefenseController.Instance.CheckStageSelectableById(this.Data.StageId))
			{
				this.RefreshSelectionVisual();
				return;
			}
			if (!this.Data.IsSelectedGetter(this.Data.StageId))
			{
				this.Data.OnClickCb(this.Data.StageId);
				return;
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06026C89 RID: 158857 RVA: 0x00ADA912 File Offset: 0x00AD8B12
		private bool OnCanExecuteChange()
		{
			return this.Data != null && TowerDefenseController.Instance.CheckStageSelectableById(this.Data.StageId);
		}

		// Token: 0x06026C8A RID: 158858 RVA: 0x00ADA933 File Offset: 0x00AD8B33
		private void OnUndeterminedClicked()
		{
			if (this.Data != null && !TowerDefenseController.Instance.CheckStageSelectableById(this.Data.StageId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefence_LevelLocked", Array.Empty<object>());
			}
		}

		// Token: 0x04015367 RID: 86887
		private const string SubNormalTitleUncheckedColor = "adc2cd";

		// Token: 0x04015368 RID: 86888
		private const string SubNormalTitleCheckedColor = "182b34";

		// Token: 0x04015369 RID: 86889
		private const string SubNormalDescUncheckedColor = "5d6e77";

		// Token: 0x0401536A RID: 86890
		private const string SubNormalDescCheckedColor = "182b34";

		// Token: 0x0401536B RID: 86891
		private const string SubHardTitleUncheckedColor = "dad1cc";

		// Token: 0x0401536C RID: 86892
		private const string SubHardTitleCheckedColor = "dad1cc";

		// Token: 0x0401536D RID: 86893
		private const string SubHardDescUncheckedColor = "dad1cc7f";

		// Token: 0x0401536E RID: 86894
		private const string SubHardDescCheckedColor = "dad1cc7f";

		// Token: 0x0401536F RID: 86895
		[Nullable(2)]
		private TowerDefenseSubLevelData Data;

		// Token: 0x020096F6 RID: 38646
		[NullableContext(0)]
		private class ESubLevelItemComponent
		{
			// Token: 0x0402F1EA RID: 193002
			public const int Toggle = 0;

			// Token: 0x0402F1EB RID: 193003
			public const int NormalPnl = 1;

			// Token: 0x0402F1EC RID: 193004
			public const int DifficultPnl = 2;

			// Token: 0x0402F1ED RID: 193005
			public const int TitleTxt = 3;

			// Token: 0x0402F1EE RID: 193006
			public const int DescTxt = 4;

			// Token: 0x0402F1EF RID: 193007
			public const int LockPnl = 5;

			// Token: 0x0402F1F0 RID: 193008
			public const int FinishPnl = 6;

			// Token: 0x0402F1F1 RID: 193009
			public const int RedDotItem = 7;

			// Token: 0x0402F1F2 RID: 193010
			public const int TitleTransition = 8;

			// Token: 0x0402F1F3 RID: 193011
			public const int DescTransition = 9;
		}
	}
}
