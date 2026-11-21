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
	// Token: 0x02004DE8 RID: 19944
	[NullableContext(2)]
	[Nullable(0)]
	public class SpecialEnergyBarSuoMing : SpecialEnergyBarBase
	{
		// Token: 0x060322A2 RID: 205474 RVA: 0x00E0EBB0 File Offset: 0x00E0CDB0
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

		// Token: 0x060322A3 RID: 205475 RVA: 0x00E0EDCD File Offset: 0x00E0CFCD
		protected override void OnInitData()
		{
			this.StrengthConfig = BattleUiModel.Instance.SpecialEnergyBarData.GetSpecialEnergyBarInfo(SpecialEnergyBarSuoMing.STRENGTH_CONFIG_ID);
		}

		// Token: 0x060322A4 RID: 205476 RVA: 0x00E0EDEC File Offset: 0x00E0CFEC
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuoMing.StateStrengthTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuoMing.StateFinalTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnStateTagChange));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarSuoMing.PrepareTriggerFinalTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnPrepareTagChange));
			base.ListenForAttributeChanged(SpecialEnergyBarSuoMing.STRENGTH_ATTR_ID, new Action<EAttributeType, float, float>(this.OnStrengthEnergyChange));
			base.ListenForAttributeChanged(SpecialEnergyBarSuoMing.MAX_STRENGTH_ATTR_ID, new Action<EAttributeType, float, float>(this.OnStrengthEnergyChange));
		}

		// Token: 0x060322A5 RID: 205477 RVA: 0x00E0EE72 File Offset: 0x00E0D072
		private void OnStateTagChange(int tagId, bool tagExist)
		{
			this.RefreshState();
		}

		// Token: 0x060322A6 RID: 205478 RVA: 0x00E0EE7C File Offset: 0x00E0D07C
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

		// Token: 0x060322A7 RID: 205479 RVA: 0x00E0EEF0 File Offset: 0x00E0D0F0
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

		// Token: 0x060322A8 RID: 205480 RVA: 0x00E0EF2A File Offset: 0x00E0D12A
		private void OnStrengthEnergyChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.UpdateStrengthBarStyle();
		}

		// Token: 0x060322A9 RID: 205481 RVA: 0x00E0EF34 File Offset: 0x00E0D134
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

		// Token: 0x060322AA RID: 205482 RVA: 0x00E0EFB0 File Offset: 0x00E0D1B0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSuoMing.<OnBeforeStartAsync>d__24 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSuoMing.<OnBeforeStartAsync>d__24>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060322AB RID: 205483 RVA: 0x00E0EFF4 File Offset: 0x00E0D1F4
		protected UniTask InitBarItem()
		{
			SpecialEnergyBarSuoMing.<InitBarItem>d__25 <InitBarItem>d__;
			<InitBarItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitBarItem>d__.<>4__this = this;
			<InitBarItem>d__.<>1__state = -1;
			<InitBarItem>d__.<>t__builder.Start<SpecialEnergyBarSuoMing.<InitBarItem>d__25>(ref <InitBarItem>d__);
			return <InitBarItem>d__.<>t__builder.Task;
		}

		// Token: 0x060322AC RID: 205484 RVA: 0x00E0F038 File Offset: 0x00E0D238
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

		// Token: 0x060322AD RID: 205485 RVA: 0x00E0F08F File Offset: 0x00E0D28F
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

		// Token: 0x060322AE RID: 205486 RVA: 0x00E0F0D0 File Offset: 0x00E0D2D0
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

		// Token: 0x060322AF RID: 205487 RVA: 0x00E0F128 File Offset: 0x00E0D328
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

		// Token: 0x060322B0 RID: 205488 RVA: 0x00E0F19C File Offset: 0x00E0D39C
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

		// Token: 0x060322B1 RID: 205489 RVA: 0x00E0F240 File Offset: 0x00E0D440
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

		// Token: 0x060322B2 RID: 205490 RVA: 0x00E0F2B8 File Offset: 0x00E0D4B8
		private void TickWarnAnim()
		{
			bool bPlay = this.CurState == SpecialEnergyBarSuoMing.EState.Final && this.Buff != null && this.Buff.GetRemainDuration() < this.StrengthConfig.ExtraFloatParams[0];
			this.PlayWarnAnim(bPlay);
		}

		// Token: 0x060322B3 RID: 205491 RVA: 0x00E0F300 File Offset: 0x00E0D500
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

		// Token: 0x060322B4 RID: 205492 RVA: 0x00E0F36C File Offset: 0x00E0D56C
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

		// Token: 0x060322B5 RID: 205493 RVA: 0x00E0F414 File Offset: 0x00E0D614
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

		// Token: 0x060322B6 RID: 205494 RVA: 0x00E0F468 File Offset: 0x00E0D668
		protected override void ClearAllTweenAnim()
		{
			base.StopTweenAnim(13);
			base.ClearAllTweenAnim();
		}

		// Token: 0x0401A94B RID: 108875
		[StaticVariableRuleIgnore]
		private static readonly int STRENGTH_CONFIG_ID = 131201;

		// Token: 0x0401A94C RID: 108876
		private SpecialEnergyBarInfo StrengthConfig;

		// Token: 0x0401A94D RID: 108877
		private static readonly int StateStrengthTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.变形状态.进阶阶段"];

		// Token: 0x0401A94E RID: 108878
		private static readonly int StateFinalTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.变形状态.终结阶段"];

		// Token: 0x0401A94F RID: 108879
		private static readonly int PrepareTriggerFinalTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SuomingMd10011.动作状态.触发电钻蓄力"];

		// Token: 0x0401A950 RID: 108880
		private static readonly EAttributeType STRENGTH_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A951 RID: 108881
		private static readonly EAttributeType MAX_STRENGTH_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A952 RID: 108882
		private SpecialEnergyBarSuoMing.EState CurState = SpecialEnergyBarSuoMing.EState.Max;

		// Token: 0x0401A953 RID: 108883
		private SpecialEnergyBarSlot BarItemNormal;

		// Token: 0x0401A954 RID: 108884
		private SpecialEnergyBarSuoMingSlot BarItemStrength;

		// Token: 0x0401A955 RID: 108885
		private IActiveBuff Buff;

		// Token: 0x0401A956 RID: 108886
		private int BuffHandle;

		// Token: 0x0401A957 RID: 108887
		private bool IsPlayWarnAnim;

		// Token: 0x0401A958 RID: 108888
		private float LastPercent;

		// Token: 0x0200AB6B RID: 43883
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04035089 RID: 217225
			BarSlotNormal,
			// Token: 0x0403508A RID: 217226
			BarSlotStrength,
			// Token: 0x0403508B RID: 217227
			TexDescBg,
			// Token: 0x0403508C RID: 217228
			TexDescMiddle,
			// Token: 0x0403508D RID: 217229
			PnlMiddle,
			// Token: 0x0403508E RID: 217230
			TexCircleBg,
			// Token: 0x0403508F RID: 217231
			TexLightAdd,
			// Token: 0x04035090 RID: 217232
			TexLight,
			// Token: 0x04035091 RID: 217233
			AniStart,
			// Token: 0x04035092 RID: 217234
			AniBottomGlow,
			// Token: 0x04035093 RID: 217235
			AniBottomRes,
			// Token: 0x04035094 RID: 217236
			Ani2SlotStrength,
			// Token: 0x04035095 RID: 217237
			AniFinal,
			// Token: 0x04035096 RID: 217238
			AniBlink,
			// Token: 0x04035097 RID: 217239
			AniFinalReady
		}

		// Token: 0x0200AB6C RID: 43884
		[NullableContext(0)]
		public enum EState
		{
			// Token: 0x04035099 RID: 217241
			Normal,
			// Token: 0x0403509A RID: 217242
			Strength,
			// Token: 0x0403509B RID: 217243
			Final,
			// Token: 0x0403509C RID: 217244
			Max
		}
	}
}
