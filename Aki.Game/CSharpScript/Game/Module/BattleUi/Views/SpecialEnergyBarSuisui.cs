using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE5 RID: 19941
	public class SpecialEnergyBarSuisui : SpecialEnergyBarBase
	{
		// Token: 0x0603227B RID: 205435 RVA: 0x00E0E0E0 File Offset: 0x00E0C2E0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603227C RID: 205436 RVA: 0x00E0E363 File Offset: 0x00E0C563
		protected override void OnInitData()
		{
			this.EnhancedStateConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(111002);
		}

		// Token: 0x0603227D RID: 205437 RVA: 0x00E0E380 File Offset: 0x00E0C580
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuisui.EnhancedStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnEnhancedStateTagChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuisui.UltStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnUltStateTagChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnEnhancedEnergyChanged));
		}

		// Token: 0x0603227E RID: 205438 RVA: 0x00E0E3D5 File Offset: 0x00E0C5D5
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.OnEnhancedEnergyChanged));
		}

		// Token: 0x0603227F RID: 205439 RVA: 0x00E0E3F4 File Offset: 0x00E0C5F4
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSuisui.<OnBeforeStartAsync>d__22 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSuisui.<OnBeforeStartAsync>d__22>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032280 RID: 205440 RVA: 0x00E0E438 File Offset: 0x00E0C638
		private UniTask InitBarItem()
		{
			SpecialEnergyBarSuisui.<InitBarItem>d__23 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuisui.<InitBarItem>d__23>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032281 RID: 205441 RVA: 0x00E0E47C File Offset: 0x00E0C67C
		private UniTask InitEnhancedStateBarItem()
		{
			SpecialEnergyBarSuisui.<InitEnhancedStateBarItem>d__24 <InitEnhancedStateBarItem>d__;
			<InitEnhancedStateBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitEnhancedStateBarItem>d__.<>4__this = this;
			<InitEnhancedStateBarItem>d__.<>1__state = -1;
			<InitEnhancedStateBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuisui.<InitEnhancedStateBarItem>d__24>(ref <InitEnhancedStateBarItem>d__);
			return <InitEnhancedStateBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032282 RID: 205442 RVA: 0x00E0E4C0 File Offset: 0x00E0C6C0
		protected override void OnStart()
		{
			base.InitTweenAnim(4);
			base.InitTweenAnim(5);
			base.InitTweenAnim(6);
			base.InitTweenAnim(7);
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.InitTweenAnim(15);
			base.InitTweenAnim(16);
			base.InitTweenAnim(17);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetAlpha(1f);
			}
			this.RefreshState(true);
		}

		// Token: 0x06032283 RID: 205443 RVA: 0x00E0E556 File Offset: 0x00E0C756
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(17);
			base.ClearAllTweenAnim();
		}

		// Token: 0x06032284 RID: 205444 RVA: 0x00E0E566 File Offset: 0x00E0C766
		private void OnEnhancedStateTagChanged(int tagId, bool tagExist)
		{
			this.SetState(tagExist ? SpecialEnergyBarSuisui.EState.Enhanced : SpecialEnergyBarSuisui.EState.Normal, false);
		}

		// Token: 0x06032285 RID: 205445 RVA: 0x00E0E576 File Offset: 0x00E0C776
		protected override void OnBarPercentChanged()
		{
			this.SetFullState(false);
		}

		// Token: 0x06032286 RID: 205446 RVA: 0x00E0E57F File Offset: 0x00E0C77F
		private void OnEnhancedEnergyChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SetEnhancedEnergyState(this.CalcEnhancedEnergyState(newValue), false);
		}

		// Token: 0x06032287 RID: 205447 RVA: 0x00E0E58F File Offset: 0x00E0C78F
		private void OnUltStateTagChanged(int tagId, bool tagExist)
		{
			this.SetUltState(tagExist, false);
		}

		// Token: 0x06032288 RID: 205448 RVA: 0x00E0E59C File Offset: 0x00E0C79C
		private void RefreshState(bool isForced = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			this.SetState((tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuisui.EnhancedStateTagId)) ? SpecialEnergyBarSuisui.EState.Enhanced : SpecialEnergyBarSuisui.EState.Normal, isForced);
		}

		// Token: 0x06032289 RID: 205449 RVA: 0x00E0E5CF File Offset: 0x00E0C7CF
		private void RefreshEnergy(bool isForced = false)
		{
			if (this.CurState == SpecialEnergyBarSuisui.EState.Enhanced)
			{
				this.RefreshEnhancedEnergyState(isForced);
				return;
			}
			this.SetFullState(isForced);
		}

		// Token: 0x0603228A RID: 205450 RVA: 0x00E0E5EC File Offset: 0x00E0C7EC
		private void RefreshEnhancedEnergyState(bool isForced = false)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float enhancedEnergy = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2) : 0f;
			this.SetEnhancedEnergyState(this.CalcEnhancedEnergyState(enhancedEnergy), isForced);
		}

		// Token: 0x0603228B RID: 205451 RVA: 0x00E0E620 File Offset: 0x00E0C820
		private void RefreshUltState(bool isForced = false)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			bool isInUltState = tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuisui.UltStateTagId);
			this.SetUltState(isInUltState, isForced);
		}

		// Token: 0x0603228C RID: 205452 RVA: 0x00E0E650 File Offset: 0x00E0C850
		private SpecialEnergyBarSuisui.EEnhancedEnergyState CalcEnhancedEnergyState(float enhancedEnergy)
		{
			BaseAttributeComponent attributeComponent = this.AttributeComponent;
			float num = (attributeComponent != null) ? attributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max) : 0f;
			if (num <= 0f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.ZeroToOneThird;
			}
			float num2 = enhancedEnergy / num;
			if (num2 >= 1f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.Full;
			}
			if (num2 >= 0.6666667f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.TwoThirdToFull;
			}
			if (num2 >= 0.33333334f)
			{
				return SpecialEnergyBarSuisui.EEnhancedEnergyState.OneThirdToTwoThird;
			}
			return SpecialEnergyBarSuisui.EEnhancedEnergyState.ZeroToOneThird;
		}

		// Token: 0x0603228D RID: 205453 RVA: 0x00E0E6A4 File Offset: 0x00E0C8A4
		private void SetState(SpecialEnergyBarSuisui.EState state, bool isForced = false)
		{
			if (this.CurState == state && !isForced)
			{
				return;
			}
			this.CurState = state;
			if (this.CurState == SpecialEnergyBarSuisui.EState.Enhanced)
			{
				base.StopTweenAnim(5);
				base.PlayTweenAnim(4);
			}
			else
			{
				base.StopTweenAnim(4);
				base.PlayTweenAnim(5);
				this.PlayWarnAnim(false);
			}
			this.RefreshEnergy(true);
			if (this.CurState == SpecialEnergyBarSuisui.EState.Enhanced)
			{
				this.RefreshUltState(true);
			}
		}

		// Token: 0x0603228E RID: 205454 RVA: 0x00E0E70C File Offset: 0x00E0C90C
		private void SetFullState(bool isForced = false)
		{
			bool flag = this.PercentMachine.GetCurPercent() >= 1f;
			if (this.IsFull == flag && !isForced)
			{
				return;
			}
			this.IsFull = flag;
			if (flag)
			{
				base.StopTweenAnim(7);
				base.PlayTweenAnim(6);
				return;
			}
			base.StopTweenAnim(6);
			base.PlayTweenAnim(7);
		}

		// Token: 0x0603228F RID: 205455 RVA: 0x00E0E764 File Offset: 0x00E0C964
		private void SetEnhancedEnergyState(SpecialEnergyBarSuisui.EEnhancedEnergyState state, bool isForced = false)
		{
			if (this.CurEnhancedEnergyState == state && !isForced)
			{
				return;
			}
			this.CurEnhancedEnergyState = state;
			switch (state)
			{
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.ZeroToOneThird:
				base.PlayTweenAnim(8);
				return;
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.OneThirdToTwoThird:
				base.PlayTweenAnim(9);
				if (!isForced)
				{
					base.PlayTweenAnim(12);
					return;
				}
				break;
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.TwoThirdToFull:
				base.PlayTweenAnim(10);
				if (!isForced)
				{
					base.PlayTweenAnim(13);
					return;
				}
				break;
			case SpecialEnergyBarSuisui.EEnhancedEnergyState.Full:
				base.PlayTweenAnim(11);
				if (!isForced)
				{
					base.PlayTweenAnim(14);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06032290 RID: 205456 RVA: 0x00E0E7DF File Offset: 0x00E0C9DF
		private void SetUltState(bool isInUltState, bool isForced = false)
		{
			if (this.IsInUltState == isInUltState && !isForced)
			{
				return;
			}
			this.IsInUltState = isInUltState;
			if (isInUltState)
			{
				base.StopTweenAnim(16);
				base.PlayTweenAnim(15);
				return;
			}
			base.StopTweenAnim(15);
			base.PlayTweenAnim(16);
		}

		// Token: 0x06032291 RID: 205457 RVA: 0x00E0E81C File Offset: 0x00E0CA1C
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItem = this.BarItem;
			if (barItem != null)
			{
				barItem.Tick(delta);
			}
			SpecialEnergyBarSlot enhancedStateBarItem = this.EnhancedStateBarItem;
			if (enhancedStateBarItem != null)
			{
				enhancedStateBarItem.Tick(delta);
			}
			if (this.CurState == SpecialEnergyBarSuisui.EState.Normal)
			{
				this.PlayWarnAnim(false);
				return;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					goto IL_63;
				}
			}
			this.RefreshBuff();
			IL_63:
			if (this.Buff != null)
			{
				this.PlayWarnAnim(this.Buff.GetRemainDuration() < this.EnhancedStateConfig.ExtraFloatParams[0]);
				return;
			}
			this.PlayWarnAnim(false);
		}

		// Token: 0x06032292 RID: 205458 RVA: 0x00E0E8C0 File Offset: 0x00E0CAC0
		private void RefreshBuff()
		{
			if (this.EnhancedStateConfig != null && this.EnhancedStateConfig.BuffId != 0L)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				this.Buff = ((buffComponent != null) ? buffComponent.GetBuffById(this.EnhancedStateConfig.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x06032293 RID: 205459 RVA: 0x00E0E92C File Offset: 0x00E0CB2C
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(17);
				return;
			}
			base.StopTweenAnim(17);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetAlpha(1f);
		}

		// Token: 0x0401A939 RID: 108857
		private const int EnhancedStateConfigId = 111002;

		// Token: 0x0401A93A RID: 108858
		private const EAttributeType EnhancedEnergyAttrId = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A93B RID: 108859
		private const EAttributeType EnhancedEnergyMaxAttrId = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A93C RID: 108860
		[StaticVariableRuleIgnore]
		private static readonly int EnhancedStateTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.形态.强化"];

		// Token: 0x0401A93D RID: 108861
		[StaticVariableRuleIgnore]
		private static readonly int UltStateTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuisuiMd10011.领域.领域生效中"];

		// Token: 0x0401A93E RID: 108862
		[Nullable(2)]
		private SpecialEnergyBarInfo EnhancedStateConfig;

		// Token: 0x0401A93F RID: 108863
		[Nullable(2)]
		private SpecialEnergyBarSlot BarItem;

		// Token: 0x0401A940 RID: 108864
		[Nullable(2)]
		private SpecialEnergyBarSlot EnhancedStateBarItem;

		// Token: 0x0401A941 RID: 108865
		private bool IsFull;

		// Token: 0x0401A942 RID: 108866
		private bool IsInUltState;

		// Token: 0x0401A943 RID: 108867
		private SpecialEnergyBarSuisui.EState CurState;

		// Token: 0x0401A944 RID: 108868
		private SpecialEnergyBarSuisui.EEnhancedEnergyState CurEnhancedEnergyState;

		// Token: 0x0401A945 RID: 108869
		[Nullable(2)]
		private IActiveBuff Buff;

		// Token: 0x0401A946 RID: 108870
		private int BuffHandle;

		// Token: 0x0401A947 RID: 108871
		private bool IsPlayWarnAnim;

		// Token: 0x0200AB61 RID: 43873
		private enum EChildType
		{
			// Token: 0x04035051 RID: 217169
			PnlState01,
			// Token: 0x04035052 RID: 217170
			BarSlotState01,
			// Token: 0x04035053 RID: 217171
			PnlState02,
			// Token: 0x04035054 RID: 217172
			BarSlotState02,
			// Token: 0x04035055 RID: 217173
			AnimState01To02,
			// Token: 0x04035056 RID: 217174
			AnimState02To01,
			// Token: 0x04035057 RID: 217175
			AnimState01ToFull,
			// Token: 0x04035058 RID: 217176
			AnimState01ToNotFull,
			// Token: 0x04035059 RID: 217177
			AnimState2Zero,
			// Token: 0x0403505A RID: 217178
			AnimState2OneThird,
			// Token: 0x0403505B RID: 217179
			AnimState2TwoThird,
			// Token: 0x0403505C RID: 217180
			AnimState2Full,
			// Token: 0x0403505D RID: 217181
			AniState2ZeroToOneThird,
			// Token: 0x0403505E RID: 217182
			AniState2OneToTwoThird,
			// Token: 0x0403505F RID: 217183
			AniState2TwoThirdToFull,
			// Token: 0x04035060 RID: 217184
			AnimState02R,
			// Token: 0x04035061 RID: 217185
			AnimState02NotR,
			// Token: 0x04035062 RID: 217186
			AnimWarning
		}

		// Token: 0x0200AB62 RID: 43874
		private enum EState
		{
			// Token: 0x04035064 RID: 217188
			Normal,
			// Token: 0x04035065 RID: 217189
			Enhanced
		}

		// Token: 0x0200AB63 RID: 43875
		private enum EEnhancedEnergyState
		{
			// Token: 0x04035067 RID: 217191
			ZeroToOneThird,
			// Token: 0x04035068 RID: 217192
			OneThirdToTwoThird,
			// Token: 0x04035069 RID: 217193
			TwoThirdToFull,
			// Token: 0x0403506A RID: 217194
			Full
		}
	}
}
