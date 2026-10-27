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
	// Token: 0x02005E03 RID: 24067
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarSuoMing : SpecialEnergyBarBase
	{
		// Token: 0x0603D313 RID: 250643 RVA: 0x00EBD650 File Offset: 0x00EBB850
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D314 RID: 250644 RVA: 0x00EBD86D File Offset: 0x00EBBA6D
		protected override void OnInitData()
		{
			this.StrengthConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(SpecialEnergyBarSuoMing.STRENGTH_CONFIG_ID);
		}

		// Token: 0x0603D315 RID: 250645 RVA: 0x00EBD88C File Offset: 0x00EBBA8C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuoMing.StateStrengthTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuoMing.StateFinalTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuoMing.PrepareTriggerFinalTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnPrepareTagChange));
			base.ListenForAttributeChanged(SpecialEnergyBarSuoMing.STRENGTH_ATTR_ID, new Action<EAttributeType, float, float>(this.OnStrengthEnergyChange));
			base.ListenForAttributeChanged(SpecialEnergyBarSuoMing.MAX_STRENGTH_ATTR_ID, new Action<EAttributeType, float, float>(this.OnStrengthEnergyChange));
		}

		// Token: 0x0603D316 RID: 250646 RVA: 0x00EBD912 File Offset: 0x00EBBB12
		private void OnStateTagChange(int tagId, bool tagExist)
		{
			this.RefreshState();
		}

		// Token: 0x0603D317 RID: 250647 RVA: 0x00EBD91C File Offset: 0x00EBBB1C
		private void OnPrepareTagChange(int tagId, bool tagExist)
		{
			if (tagExist)
			{
				SpecialEnergyBarSuoMingSlot barItemStrength = this.BarItemStrength;
				if (barItemStrength != null)
				{
					barItemStrength.UpdateFinalStateRemainingPercent(1f);
				}
				base.PlayTweenAnim(14);
			}
			else
			{
				if (this.CurState == SpecialEnergyBarSuoMing.EState.Strength)
				{
					base.StopTweenAnim(14);
					base.PlayTweenAnim(11);
				}
				if (this.CurState == SpecialEnergyBarSuoMing.EState.Final)
				{
					base.StopTweenAnim(14);
					base.PlayTweenAnim(12);
				}
			}
			SpecialEnergyBarSuoMingSlot barItemStrength2 = this.BarItemStrength;
			if (barItemStrength2 == null)
			{
				return;
			}
			barItemStrength2.SetIsInPrepareState(tagExist);
		}

		// Token: 0x0603D318 RID: 250648 RVA: 0x00EBD990 File Offset: 0x00EBBB90
		protected float GetAttributePercent(EAttributeType attrId, EAttributeType maxAttrId)
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(attrId);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(maxAttrId);
			float result = 0f;
			if (currentValue2 > 0f)
			{
				result = currentValue / currentValue2;
			}
			return result;
		}

		// Token: 0x0603D319 RID: 250649 RVA: 0x00EBD9CA File Offset: 0x00EBBBCA
		private void OnStrengthEnergyChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateStrengthBarStyle();
		}

		// Token: 0x0603D31A RID: 250650 RVA: 0x00EBD9D4 File Offset: 0x00EBBBD4
		protected void UpdateStrengthBarStyle()
		{
			float attributePercent = this.GetAttributePercent(SpecialEnergyBarSuoMing.STRENGTH_ATTR_ID, SpecialEnergyBarSuoMing.MAX_STRENGTH_ATTR_ID);
			float attributePercent2 = this.GetAttributePercent((EAttributeType)this.Config.AttributeId, (EAttributeType)this.Config.MaxAttributeId);
			UUITexture texture = base.GetTexture(6);
			if (texture != null)
			{
				texture.SetUIActive(attributePercent > 0f);
			}
			UUITexture texture2 = base.GetTexture(7);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(attributePercent >= 1f && attributePercent2 >= 1f);
		}

		// Token: 0x0603D31B RID: 250651 RVA: 0x00EBDA50 File Offset: 0x00EBBC50
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSuoMing.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSuoMing.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D31C RID: 250652 RVA: 0x00EBDA94 File Offset: 0x00EBBC94
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarSuoMing.<InitBarItem>d__25 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuoMing.<InitBarItem>d__25>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D31D RID: 250653 RVA: 0x00EBDAD8 File Offset: 0x00EBBCD8
		protected override void OnStart()
		{
			base.InitTweenAnim(8);
			base.InitTweenAnim(9);
			base.InitTweenAnim(10);
			base.InitTweenAnim(11);
			base.InitTweenAnim(12);
			base.InitTweenAnim(13);
			base.InitTweenAnim(14);
			base.PlayTweenAnim(8);
			this.RefreshState();
			this.UpdateStrengthBarStyle();
		}

		// Token: 0x0603D31E RID: 250654 RVA: 0x00EBDB2F File Offset: 0x00EBBD2F
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarSlot barItemNormal = this.BarItemNormal;
			if (barItemNormal != null)
			{
				barItemNormal.Tick(delta);
			}
			SpecialEnergyBarSuoMingSlot barItemStrength = this.BarItemStrength;
			if (barItemStrength != null)
			{
				barItemStrength.Tick(delta);
			}
			this.RefreshBuff();
			this.TickWarnAnim();
			this.TickFinalStateRemaining();
		}

		// Token: 0x0603D31F RID: 250655 RVA: 0x00EBDB70 File Offset: 0x00EBBD70
		protected void RefreshState()
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(SpecialEnergyBarSuoMing.StateFinalTagId))
			{
				this.SetState(SpecialEnergyBarSuoMing.EState.Final);
				return;
			}
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(SpecialEnergyBarSuoMing.StateStrengthTagId))
			{
				this.SetState(SpecialEnergyBarSuoMing.EState.Strength);
				return;
			}
			this.SetState(SpecialEnergyBarSuoMing.EState.Normal);
		}

		// Token: 0x0603D320 RID: 250656 RVA: 0x00EBDBC8 File Offset: 0x00EBBDC8
		protected void SetState(SpecialEnergyBarSuoMing.EState state)
		{
			if (this.CurState == state)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(state == SpecialEnergyBarSuoMing.EState.Normal);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(state > SpecialEnergyBarSuoMing.EState.Normal);
			}
			this.PlayStateChangeAnim(this.CurState, state);
			this.CurState = state;
			this.OnBarPercentChanged();
			SpecialEnergyBarSuoMingSlot barItemStrength = this.BarItemStrength;
			if (barItemStrength == null)
			{
				return;
			}
			barItemStrength.SetIsInFinalState(SpecialEnergyBarSuoMing.EState.Final == state);
		}

		// Token: 0x0603D321 RID: 250657 RVA: 0x00EBDC3C File Offset: 0x00EBBE3C
		protected void PlayStateChangeAnim(SpecialEnergyBarSuoMing.EState oldState, SpecialEnergyBarSuoMing.EState newState)
		{
			if (oldState != SpecialEnergyBarSuoMing.EState.Max && newState == SpecialEnergyBarSuoMing.EState.Normal)
			{
				base.StopTweenAnim(11);
				base.StopTweenAnim(12);
				base.StopTweenAnim(9);
				base.PlayTweenAnim(10);
			}
			if (newState == SpecialEnergyBarSuoMing.EState.Strength)
			{
				base.StopTweenAnim(14);
				base.StopTweenAnim(10);
				base.StopTweenAnim(12);
				base.StopTweenAnim(8);
				if (this.LastPercent < 1f && oldState == SpecialEnergyBarSuoMing.EState.Normal)
				{
					base.PlayTweenAnim(9);
				}
				base.PlayTweenAnim(11);
			}
			if (newState == SpecialEnergyBarSuoMing.EState.Final)
			{
				base.StopTweenAnim(14);
				base.StopTweenAnim(10);
				base.StopTweenAnim(11);
				base.StopTweenAnim(8);
				base.PlayTweenAnim(12);
			}
		}

		// Token: 0x0603D322 RID: 250658 RVA: 0x00EBDCE0 File Offset: 0x00EBBEE0
		protected override void OnBarPercentChanged()
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			if (this.CurState == SpecialEnergyBarSuoMing.EState.Normal)
			{
				if (this.LastPercent < 1f && curPercent >= 1f)
				{
					base.StopTweenAnim(8);
					base.PlayTweenAnim(9);
				}
				if (this.LastPercent >= 1f && curPercent < 1f)
				{
					base.StopTweenAnim(9);
					base.PlayTweenAnim(8);
				}
			}
			else
			{
				this.UpdateStrengthBarStyle();
			}
			this.LastPercent = curPercent;
		}

		// Token: 0x0603D323 RID: 250659 RVA: 0x00EBDD58 File Offset: 0x00EBBF58
		private void TickWarnAnim()
		{
			bool bPlay = this.CurState == SpecialEnergyBarSuoMing.EState.Final && this.Buff != null && this.Buff.GetRemainDuration() < this.StrengthConfig.ExtraFloatParams[0];
			this.PlayWarnAnim(bPlay);
		}

		// Token: 0x0603D324 RID: 250660 RVA: 0x00EBDDA0 File Offset: 0x00EBBFA0
		private void TickFinalStateRemaining()
		{
			if (this.CurState != SpecialEnergyBarSuoMing.EState.Final)
			{
				return;
			}
			float percent = 0f;
			if (this.CurState == SpecialEnergyBarSuoMing.EState.Final && this.Buff != null && this.Buff.Duration > 0f)
			{
				percent = this.Buff.GetRemainDuration() / this.Buff.Duration;
			}
			SpecialEnergyBarSuoMingSlot barItemStrength = this.BarItemStrength;
			if (barItemStrength == null)
			{
				return;
			}
			barItemStrength.UpdateFinalStateRemainingPercent(percent);
		}

		// Token: 0x0603D325 RID: 250661 RVA: 0x00EBDE0C File Offset: 0x00EBC00C
		private void RefreshBuff()
		{
			if (this.CurState != SpecialEnergyBarSuoMing.EState.Final)
			{
				return;
			}
			if (this.Buff != null)
			{
				CharacterBuffComponent buffComponent = this.BuffComponent;
				if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
				{
					return;
				}
			}
			SpecialEnergyBarInfo strengthConfig = this.StrengthConfig;
			bool flag;
			if (strengthConfig == null)
			{
				flag = false;
			}
			else
			{
				long buffId = strengthConfig.BuffId;
				flag = true;
			}
			if (flag && this.StrengthConfig.BuffId != 0L)
			{
				CharacterBuffComponent buffComponent2 = this.BuffComponent;
				this.Buff = ((buffComponent2 != null) ? buffComponent2.GetBuffById(this.StrengthConfig.BuffId) : null);
				IActiveBuff buff = this.Buff;
				this.BuffHandle = ((buff != null) ? buff.Handle : 0);
				return;
			}
			this.Buff = null;
			this.BuffHandle = 0;
		}

		// Token: 0x0603D326 RID: 250662 RVA: 0x00EBDEB4 File Offset: 0x00EBC0B4
		private void PlayWarnAnim(bool bPlay)
		{
			if (this.IsPlayWarnAnim == bPlay)
			{
				return;
			}
			this.IsPlayWarnAnim = bPlay;
			if (bPlay)
			{
				base.PlayTweenAnim(13);
				return;
			}
			base.StopTweenAnim(13);
			base.GetItem(0).SetAlpha(1f);
			base.GetItem(1).SetAlpha(1f);
		}

		// Token: 0x0603D327 RID: 250663 RVA: 0x00EBDF08 File Offset: 0x00EBC108
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(13);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0401FE84 RID: 130692
		[StaticVariableRuleIgnore]
		private static readonly int STRENGTH_CONFIG_ID = 131201;

		// Token: 0x0401FE85 RID: 130693
		private SpecialEnergyBarInfo StrengthConfig;

		// Token: 0x0401FE86 RID: 130694
		private static readonly int StateStrengthTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.变形状态.进阶阶段"];

		// Token: 0x0401FE87 RID: 130695
		private static readonly int StateFinalTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.变形状态.终结阶段"];

		// Token: 0x0401FE88 RID: 130696
		private static readonly int PrepareTriggerFinalTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.动作状态.触发电钻蓄力"];

		// Token: 0x0401FE89 RID: 130697
		private static readonly EAttributeType STRENGTH_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FE8A RID: 130698
		private static readonly EAttributeType MAX_STRENGTH_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FE8B RID: 130699
		private SpecialEnergyBarSuoMing.EState CurState = SpecialEnergyBarSuoMing.EState.Max;

		// Token: 0x0401FE8C RID: 130700
		private SpecialEnergyBarSlot BarItemNormal;

		// Token: 0x0401FE8D RID: 130701
		private SpecialEnergyBarSuoMingSlot BarItemStrength;

		// Token: 0x0401FE8E RID: 130702
		private IActiveBuff Buff;

		// Token: 0x0401FE8F RID: 130703
		private int BuffHandle;

		// Token: 0x0401FE90 RID: 130704
		private bool IsPlayWarnAnim;

		// Token: 0x0401FE91 RID: 130705
		private float LastPercent;

		// Token: 0x0200C15C RID: 49500
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A697 RID: 239255
			BarSlotNormal,
			// Token: 0x0403A698 RID: 239256
			BarSlotStrength,
			// Token: 0x0403A699 RID: 239257
			TexDescBg,
			// Token: 0x0403A69A RID: 239258
			TexDescMiddle,
			// Token: 0x0403A69B RID: 239259
			PnlMiddle,
			// Token: 0x0403A69C RID: 239260
			TexCircleBg,
			// Token: 0x0403A69D RID: 239261
			TexLightAdd,
			// Token: 0x0403A69E RID: 239262
			TexLight,
			// Token: 0x0403A69F RID: 239263
			AniStart,
			// Token: 0x0403A6A0 RID: 239264
			AniBottomGlow,
			// Token: 0x0403A6A1 RID: 239265
			AniBottomRes,
			// Token: 0x0403A6A2 RID: 239266
			Ani2SlotStrength,
			// Token: 0x0403A6A3 RID: 239267
			AniFinal,
			// Token: 0x0403A6A4 RID: 239268
			AniBlink,
			// Token: 0x0403A6A5 RID: 239269
			AniFinalReady
		}

		// Token: 0x0200C15D RID: 49501
		[NullableContext(0)]
		public enum EState
		{
			// Token: 0x0403A6A7 RID: 239271
			Normal,
			// Token: 0x0403A6A8 RID: 239272
			Strength,
			// Token: 0x0403A6A9 RID: 239273
			Final,
			// Token: 0x0403A6AA RID: 239274
			Max
		}
	}
}
