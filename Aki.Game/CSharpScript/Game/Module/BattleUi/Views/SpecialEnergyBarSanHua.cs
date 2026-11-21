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
	// Token: 0x02004DE4 RID: 19940
	public class SpecialEnergyBarSanHua : SpecialEnergyBarBase
	{
		// Token: 0x0603226E RID: 205422 RVA: 0x00E0DD24 File Offset: 0x00E0BF24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603226F RID: 205423 RVA: 0x00E0DDF0 File Offset: 0x00E0BFF0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSanHua.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSanHua.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032270 RID: 205424 RVA: 0x00E0DE34 File Offset: 0x00E0C034
		[NullableContext(1)]
		protected UniTask InitPointItem(UUIItem pointItem)
		{
			SpecialEnergyBarSanHua.<InitPointItem>d__14 <InitPointItem>d__;
			<InitPointItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointItem>d__.<>4__this = this;
			<InitPointItem>d__.pointItem = pointItem;
			<InitPointItem>d__.<>1__state = -1;
			<InitPointItem>d__.<>t__builder.Start<SpecialEnergyBarSanHua.<InitPointItem>d__14>(ref <InitPointItem>d__);
			return <InitPointItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032271 RID: 205425 RVA: 0x00E0DE80 File Offset: 0x00E0C080
		protected override void OnStart()
		{
			if (this.Config == null)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.Config.EffectColor))
			{
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				this.PointItem.SetFullEffectColor(flinearColor, false);
			}
			this.RefreshPercentRange();
			this.RefreshBarPercent(true);
			base.GetUiNiagara(3).SetUIActive(false);
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(true, true);
		}

		// Token: 0x06032272 RID: 205426 RVA: 0x00E0DEFC File Offset: 0x00E0C0FC
		private void RefreshPercentRange()
		{
			int buffCountByBuffId = base.GetBuffCountByBuffId(1102012003L);
			float currentValue = this.AttributeComponent.GetCurrentValue((EAttributeType)this.Config.MaxAttributeId);
			this.CurLeftPercent = this.Config.ExtraFloatParams[buffCountByBuffId * 2] / currentValue;
			this.CurRightPercent = this.Config.ExtraFloatParams[buffCountByBuffId * 2 + 1] / currentValue;
		}

		// Token: 0x06032273 RID: 205427 RVA: 0x00E0DF68 File Offset: 0x00E0C168
		protected void RefreshBarPercent(bool isStart = false)
		{
			float targetPercent = this.PercentMachine.GetTargetPercent();
			if (targetPercent > 0f)
			{
				this.LastPercent = targetPercent;
			}
			this.PointItem.UpdateLeftRightPercent(this.CurLeftPercent, this.CurRightPercent);
			base.GetItem(1).SetAnchorOffsetX(369f * (targetPercent - 0.5f));
			bool flag = targetPercent > this.CurLeftPercent && targetPercent <= this.CurRightPercent;
			if (isStart || flag != this.TipEffectEnable)
			{
				this.TipEffectEnable = flag;
				base.GetUiNiagara(2).SetUIActive(flag);
			}
		}

		// Token: 0x06032274 RID: 205428 RVA: 0x00E0DFF9 File Offset: 0x00E0C1F9
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032275 RID: 205429 RVA: 0x00E0E002 File Offset: 0x00E0C202
		public override void Tick(float delta)
		{
			base.Tick(delta);
			SpecialEnergyBarPointItem pointItem = this.PointItem;
			if (pointItem == null)
			{
				return;
			}
			pointItem.Tick(delta);
		}

		// Token: 0x06032276 RID: 205430 RVA: 0x00E0E01C File Offset: 0x00E0C21C
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(SpecialEnergyBarSanHua.SuccessTagId, new BaseTagComponent.TTagChangedCallback(this.OnSuccessTagCountChange));
			base.ListenForTagCountChanged(SpecialEnergyBarSanHua.BuffTagId, new BaseTagComponent.TTagChangedCallback(this.OnBuffTagCountChange));
		}

		// Token: 0x06032277 RID: 205431 RVA: 0x00E0E054 File Offset: 0x00E0C254
		private void OnSuccessTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			UUINiagara uiNiagara = base.GetUiNiagara(3);
			if (count > 0)
			{
				uiNiagara.SetAnchorOffsetX(369f * (this.LastPercent - 0.5f));
				uiNiagara.SetUIActive(true);
				return;
			}
			uiNiagara.SetUIActive(false);
		}

		// Token: 0x06032278 RID: 205432 RVA: 0x00E0E094 File Offset: 0x00E0C294
		private void OnBuffTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshPercentRange();
			this.RefreshBarPercent(false);
		}

		// Token: 0x0401A92E RID: 108846
		private const int POINT_NUM = 41;

		// Token: 0x0401A92F RID: 108847
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401A930 RID: 108848
		private const float TOTAL_WIDTH = 369f;

		// Token: 0x0401A931 RID: 108849
		[StaticVariableRuleIgnore]
		private static readonly int SuccessTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SanhuaMd10011.状态标识.蓄力判定成功暂停"];

		// Token: 0x0401A932 RID: 108850
		[StaticVariableRuleIgnore]
		private static readonly int BuffTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SanhuaMd10011.状态标识.蓄力被动触发"];

		// Token: 0x0401A933 RID: 108851
		private const int BUFF_ID = 1102012003;

		// Token: 0x0401A934 RID: 108852
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401A935 RID: 108853
		private bool TipEffectEnable;

		// Token: 0x0401A936 RID: 108854
		private float CurLeftPercent;

		// Token: 0x0401A937 RID: 108855
		private float CurRightPercent = 1f;

		// Token: 0x0401A938 RID: 108856
		private float LastPercent;

		// Token: 0x0200AB5E RID: 43870
		private enum EChildType
		{
			// Token: 0x04035042 RID: 217154
			PointItem,
			// Token: 0x04035043 RID: 217155
			SliderItem,
			// Token: 0x04035044 RID: 217156
			PointTipEffect,
			// Token: 0x04035045 RID: 217157
			PointSuccessEffect,
			// Token: 0x04035046 RID: 217158
			KeyContainerItem
		}
	}
}
