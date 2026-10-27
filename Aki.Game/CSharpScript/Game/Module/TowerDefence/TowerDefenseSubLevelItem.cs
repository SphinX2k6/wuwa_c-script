using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B53 RID: 19283
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseSubLevelItem : GridProxyAbstract<TowerDefenseSubLevelData>
	{
		// Token: 0x06031EF0 RID: 204528 RVA: 0x00B9603C File Offset: 0x00B9423C
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

		// Token: 0x06031EF1 RID: 204529 RVA: 0x00B961EC File Offset: 0x00B943EC
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

		// Token: 0x06031EF2 RID: 204530 RVA: 0x00B96238 File Offset: 0x00B94438
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

		// Token: 0x06031EF3 RID: 204531 RVA: 0x00B96414 File Offset: 0x00B94614
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

		// Token: 0x06031EF4 RID: 204532 RVA: 0x00B96468 File Offset: 0x00B94668
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

		// Token: 0x06031EF5 RID: 204533 RVA: 0x00B964D8 File Offset: 0x00B946D8
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

		// Token: 0x06031EF6 RID: 204534 RVA: 0x00B96565 File Offset: 0x00B94765
		private FTextTransitionInfoOfState BuildTextStateColor(FTextTransitionInfoOfState state, string hex)
		{
			state.bSetFontColor = true;
			state.FontColor = FColor.FromHex(hex);
			return state;
		}

		// Token: 0x06031EF7 RID: 204535 RVA: 0x00B9657C File Offset: 0x00B9477C
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

		// Token: 0x06031EF8 RID: 204536 RVA: 0x00B965F0 File Offset: 0x00B947F0
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

		// Token: 0x06031EF9 RID: 204537 RVA: 0x00B96654 File Offset: 0x00B94854
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

		// Token: 0x06031EFA RID: 204538 RVA: 0x00B966D6 File Offset: 0x00B948D6
		private bool OnCanExecuteChange()
		{
			return this.Data != null && TowerDefenseController.Instance.CheckStageSelectableById(this.Data.StageId);
		}

		// Token: 0x06031EFB RID: 204539 RVA: 0x00B966F7 File Offset: 0x00B948F7
		private void OnUndeterminedClicked()
		{
			if (this.Data != null && !TowerDefenseController.Instance.CheckStageSelectableById(this.Data.StageId))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("TowerDefence_LevelLocked", Array.Empty<object>());
			}
		}

		// Token: 0x0401AA15 RID: 109077
		private const string SubNormalTitleUncheckedColor = "adc2cd";

		// Token: 0x0401AA16 RID: 109078
		private const string SubNormalTitleCheckedColor = "182b34";

		// Token: 0x0401AA17 RID: 109079
		private const string SubNormalDescUncheckedColor = "5d6e77";

		// Token: 0x0401AA18 RID: 109080
		private const string SubNormalDescCheckedColor = "182b34";

		// Token: 0x0401AA19 RID: 109081
		private const string SubHardTitleUncheckedColor = "dad1cc";

		// Token: 0x0401AA1A RID: 109082
		private const string SubHardTitleCheckedColor = "dad1cc";

		// Token: 0x0401AA1B RID: 109083
		private const string SubHardDescUncheckedColor = "dad1cc7f";

		// Token: 0x0401AA1C RID: 109084
		private const string SubHardDescCheckedColor = "dad1cc7f";

		// Token: 0x0401AA1D RID: 109085
		[Nullable(2)]
		private TowerDefenseSubLevelData Data;

		// Token: 0x0200ACD7 RID: 44247
		[NullableContext(0)]
		private class ESubLevelItemComponent
		{
			// Token: 0x04034841 RID: 215105
			public const int Toggle = 0;

			// Token: 0x04034842 RID: 215106
			public const int NormalPnl = 1;

			// Token: 0x04034843 RID: 215107
			public const int DifficultPnl = 2;

			// Token: 0x04034844 RID: 215108
			public const int TitleTxt = 3;

			// Token: 0x04034845 RID: 215109
			public const int DescTxt = 4;

			// Token: 0x04034846 RID: 215110
			public const int LockPnl = 5;

			// Token: 0x04034847 RID: 215111
			public const int FinishPnl = 6;

			// Token: 0x04034848 RID: 215112
			public const int RedDotItem = 7;

			// Token: 0x04034849 RID: 215113
			public const int TitleTransition = 8;

			// Token: 0x0403484A RID: 215114
			public const int DescTransition = 9;
		}
	}
}
