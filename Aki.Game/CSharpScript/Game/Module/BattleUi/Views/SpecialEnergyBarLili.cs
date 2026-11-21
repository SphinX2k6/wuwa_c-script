using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DCD RID: 19917
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarLili : SpecialEnergyBarBase
	{
		// Token: 0x06032145 RID: 205125 RVA: 0x00E07254 File Offset: 0x00E05454
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032146 RID: 205126 RVA: 0x00E073C7 File Offset: 0x00E055C7
		protected override void OnInitData()
		{
			this.ConfigLight = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(151201);
		}

		// Token: 0x06032147 RID: 205127 RVA: 0x00E073E4 File Offset: 0x00E055E4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarLili.FormLightTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnFormTagChanged));
			foreach (int tagId in SpecialEnergyBarLili.StateEnhancedTagIdList)
			{
				base.ListenForTagAddOrRemoveChanged(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateEnhancedTagChanged));
			}
		}

		// Token: 0x06032148 RID: 205128 RVA: 0x00E07439 File Offset: 0x00E05639
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
		}

		// Token: 0x06032149 RID: 205129 RVA: 0x00E07444 File Offset: 0x00E05644
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarLili.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarLili.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603214A RID: 205130 RVA: 0x00E07488 File Offset: 0x00E05688
		private UniTask InitBarItemLight()
		{
			SpecialEnergyBarLili.<InitBarItemLight>d__18 <InitBarItemLight>d__;
			<InitBarItemLight>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItemLight>d__.<>4__this = this;
			<InitBarItemLight>d__.<>1__state = -1;
			<InitBarItemLight>d__.<>t__builder.Start<SpecialEnergyBarLili.<InitBarItemLight>d__18>(ref <InitBarItemLight>d__);
			return <InitBarItemLight>d__.<>t__builder.Task;
		}

		// Token: 0x0603214B RID: 205131 RVA: 0x00E074CC File Offset: 0x00E056CC
		private UniTask InitBarItemDark()
		{
			SpecialEnergyBarLili.<InitBarItemDark>d__19 <InitBarItemDark>d__;
			<InitBarItemDark>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItemDark>d__.<>4__this = this;
			<InitBarItemDark>d__.<>1__state = -1;
			<InitBarItemDark>d__.<>t__builder.Start<SpecialEnergyBarLili.<InitBarItemDark>d__19>(ref <InitBarItemDark>d__);
			return <InitBarItemDark>d__.<>t__builder.Task;
		}

		// Token: 0x0603214C RID: 205132 RVA: 0x00E0750F File Offset: 0x00E0570F
		protected override void OnStart()
		{
			base.InitTweenAnim(2);
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			this.RefreshForm(true);
		}

		// Token: 0x0603214D RID: 205133 RVA: 0x00E07543 File Offset: 0x00E05743
		protected override void ClearAllTweenAnim()
		{
			base.ClearAllTweenAnim();
		}

		// Token: 0x0603214E RID: 205134 RVA: 0x00E0754B File Offset: 0x00E0574B
		protected override void OnBeforeDestroy()
		{
			this.CancelStateRefresh();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603214F RID: 205135 RVA: 0x00E07559 File Offset: 0x00E05759
		protected override void OnBarPercentChanged()
		{
			base.OnBarPercentChanged();
			this.RequestRefreshState();
		}

		// Token: 0x06032150 RID: 205136 RVA: 0x00E07567 File Offset: 0x00E05767
		private void OnFormTagChanged(int tagId, bool tagExist)
		{
			this.SetForm(tagExist ? SpecialEnergyBarLili.EForm.Light : SpecialEnergyBarLili.EForm.Dark, false);
		}

		// Token: 0x06032151 RID: 205137 RVA: 0x00E07577 File Offset: 0x00E05777
		private void OnStateEnhancedTagChanged(int tagId, bool tagExist)
		{
			this.RequestRefreshState();
		}

		// Token: 0x06032152 RID: 205138 RVA: 0x00E07580 File Offset: 0x00E05780
		private void RefreshForm(bool isForced = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetForm((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarLili.FormLightTagId)) ? SpecialEnergyBarLili.EForm.Light : SpecialEnergyBarLili.EForm.Dark, isForced);
		}

		// Token: 0x06032153 RID: 205139 RVA: 0x00E075B4 File Offset: 0x00E057B4
		private void SetForm(SpecialEnergyBarLili.EForm form, bool isForced = false)
		{
			if (this.CurForm == form && !isForced)
			{
				return;
			}
			this.CurForm = form;
			if (this.CurForm == SpecialEnergyBarLili.EForm.Light)
			{
				base.StopTweenAnim(5);
				base.PlayTweenAnim(2);
			}
			else
			{
				base.StopTweenAnim(2);
				base.PlayTweenAnim(5);
			}
			this.CancelStateRefresh();
			this.RefreshStateImmediately(true);
		}

		// Token: 0x06032154 RID: 205140 RVA: 0x00E0760B File Offset: 0x00E0580B
		private void RequestRefreshState()
		{
			if (this.StateRefreshTimer != null && TimerSystem.GameplayTimeInstance.Has(this.StateRefreshTimer))
			{
				return;
			}
			this.StateRefreshTimer = TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				this.StateRefreshTimer = null;
				this.RefreshStateImmediately(false);
			}, null, null);
		}

		// Token: 0x06032155 RID: 205141 RVA: 0x00E07646 File Offset: 0x00E05846
		private void CancelStateRefresh()
		{
			if (this.StateRefreshTimer != null && TimerSystem.GameplayTimeInstance.Has(this.StateRefreshTimer))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.StateRefreshTimer);
			}
			this.StateRefreshTimer = null;
		}

		// Token: 0x06032156 RID: 205142 RVA: 0x00E0767C File Offset: 0x00E0587C
		private void RefreshStateImmediately(bool isForced = false)
		{
			bool isEnergyFull = this.PercentMachine.GetCurPercent() >= 1f;
			BaseTagComponent tagComponent = this.TagComponent;
			bool enhancedTagExist = tagComponent != null && tagComponent.HasAnyTag(SpecialEnergyBarLili.StateEnhancedTagIdList);
			this.SetState(this.CalcCurState(isEnergyFull, enhancedTagExist), isForced);
		}

		// Token: 0x06032157 RID: 205143 RVA: 0x00E076C8 File Offset: 0x00E058C8
		private void SetState(SpecialEnergyBarLili.EState state, bool isForced = false)
		{
			if (this.CurState == state && !isForced)
			{
				return;
			}
			SpecialEnergyBarLili.EState curState = this.CurState;
			this.CurState = state;
			bool flag = curState - SpecialEnergyBarLili.EState.Active <= 1;
			bool flag2 = flag;
			SpecialEnergyBarLili.EState curState2 = this.CurState;
			flag = (curState2 - SpecialEnergyBarLili.EState.Active <= 1);
			bool flag3 = flag;
			if (flag2 != flag3 || isForced)
			{
				if (flag3)
				{
					base.StopTweenAnim(7);
					base.PlayTweenAnim(6);
				}
				else
				{
					base.StopTweenAnim(6);
					base.PlayTweenAnim(7);
				}
			}
			bool flag4 = curState == SpecialEnergyBarLili.EState.Enhanced;
			bool flag5 = this.CurState == SpecialEnergyBarLili.EState.Enhanced;
			if (flag4 != flag5 || isForced)
			{
				if (flag5)
				{
					base.StopTweenAnim(9);
					base.PlayTweenAnim(8);
				}
				else
				{
					base.StopTweenAnim(8);
					base.PlayTweenAnim(9);
				}
				SpecialEnergyBarSlot barItemLight = this.BarItemLight;
				if (barItemLight != null)
				{
					UUIItem keyItem = barItemLight.GetKeyItem();
					if (keyItem != null)
					{
						keyItem.SetUIActive(!flag5);
					}
				}
				SpecialEnergyBarSlot barItemDark = this.BarItemDark;
				if (barItemDark == null)
				{
					return;
				}
				UUIItem keyItem2 = barItemDark.GetKeyItem();
				if (keyItem2 == null)
				{
					return;
				}
				keyItem2.SetUIActive(!flag5);
			}
		}

		// Token: 0x06032158 RID: 205144 RVA: 0x00E077C0 File Offset: 0x00E059C0
		private SpecialEnergyBarLili.EState CalcCurState(bool isEnergyFull, bool enhancedTagExist)
		{
			if (enhancedTagExist)
			{
				return SpecialEnergyBarLili.EState.Enhanced;
			}
			if (!isEnergyFull)
			{
				return SpecialEnergyBarLili.EState.Normal;
			}
			return SpecialEnergyBarLili.EState.Active;
		}

		// Token: 0x06032159 RID: 205145 RVA: 0x00E077CD File Offset: 0x00E059CD
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItemLight = this.BarItemLight;
			if (barItemLight != null)
			{
				barItemLight.Tick(delta);
			}
			SpecialEnergyBarSlot barItemDark = this.BarItemDark;
			if (barItemDark == null)
			{
				return;
			}
			barItemDark.Tick(delta);
		}

		// Token: 0x0401A862 RID: 108642
		private const int FORM_LIGHT_CONFIG_ID = 151201;

		// Token: 0x0401A863 RID: 108643
		[StaticVariableRuleIgnore]
		private static readonly int FormLightTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.逻辑标识.美梦标识"];

		// Token: 0x0401A864 RID: 108644
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] StateEnhancedTagIdList = new int[]
		{
			GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.技能标识.莉莉重击引导标识"],
			GameplayTagDefine.EGameplayTagId["角色.R2T1LiliMd10011.技能标识.莉莉重击释放标识"]
		};

		// Token: 0x0401A865 RID: 108645
		private SpecialEnergyBarInfo ConfigLight;

		// Token: 0x0401A866 RID: 108646
		private SpecialEnergyBarInfo ConfigDark;

		// Token: 0x0401A867 RID: 108647
		private SpecialEnergyBarSlot BarItemLight;

		// Token: 0x0401A868 RID: 108648
		private SpecialEnergyBarSlot BarItemDark;

		// Token: 0x0401A869 RID: 108649
		private SpecialEnergyBarLili.EForm CurForm = SpecialEnergyBarLili.EForm.Max;

		// Token: 0x0401A86A RID: 108650
		private SpecialEnergyBarLili.EState CurState = SpecialEnergyBarLili.EState.Max;

		// Token: 0x0401A86B RID: 108651
		private TimerHandle StateRefreshTimer;

		// Token: 0x0200AB1F RID: 43807
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034EA8 RID: 216744
			PnlStateA,
			// Token: 0x04034EA9 RID: 216745
			BarSlotA,
			// Token: 0x04034EAA RID: 216746
			AnimUnicorn,
			// Token: 0x04034EAB RID: 216747
			PnlStateB,
			// Token: 0x04034EAC RID: 216748
			BarSlotB,
			// Token: 0x04034EAD RID: 216749
			AnimNightmare,
			// Token: 0x04034EAE RID: 216750
			AnimActiveIn,
			// Token: 0x04034EAF RID: 216751
			AnimActiveOut,
			// Token: 0x04034EB0 RID: 216752
			AnimExchantIn,
			// Token: 0x04034EB1 RID: 216753
			AnimExchantOut
		}

		// Token: 0x0200AB20 RID: 43808
		[NullableContext(0)]
		private enum EForm
		{
			// Token: 0x04034EB3 RID: 216755
			Light,
			// Token: 0x04034EB4 RID: 216756
			Dark,
			// Token: 0x04034EB5 RID: 216757
			Max
		}

		// Token: 0x0200AB21 RID: 43809
		[NullableContext(0)]
		private enum EState
		{
			// Token: 0x04034EB7 RID: 216759
			Normal,
			// Token: 0x04034EB8 RID: 216760
			Active,
			// Token: 0x04034EB9 RID: 216761
			Enhanced,
			// Token: 0x04034EBA RID: 216762
			Max
		}
	}
}
