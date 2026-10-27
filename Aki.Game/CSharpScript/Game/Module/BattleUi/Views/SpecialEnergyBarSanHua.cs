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
	// Token: 0x02005DFF RID: 24063
	public class SpecialEnergyBarSanHua : SpecialEnergyBarBase
	{
		// Token: 0x0603D2DF RID: 250591 RVA: 0x00EBC7C4 File Offset: 0x00EBA9C4
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

		// Token: 0x0603D2E0 RID: 250592 RVA: 0x00EBC890 File Offset: 0x00EBAA90
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSanHua.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSanHua.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D2E1 RID: 250593 RVA: 0x00EBC8D4 File Offset: 0x00EBAAD4
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

		// Token: 0x0603D2E2 RID: 250594 RVA: 0x00EBC920 File Offset: 0x00EBAB20
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

		// Token: 0x0603D2E3 RID: 250595 RVA: 0x00EBC99C File Offset: 0x00EBAB9C
		private void RefreshPercentRange()
		{
			int buffCountByBuffId = base.GetBuffCountByBuffId(1102012003L);
			float currentValue = this.AttributeComponent.GetCurrentValue((EAttributeType)this.Config.MaxAttributeId);
			this.CurLeftPercent = this.Config.ExtraFloatParams[buffCountByBuffId * 2] / currentValue;
			this.CurRightPercent = this.Config.ExtraFloatParams[buffCountByBuffId * 2 + 1] / currentValue;
		}

		// Token: 0x0603D2E4 RID: 250596 RVA: 0x00EBCA08 File Offset: 0x00EBAC08
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

		// Token: 0x0603D2E5 RID: 250597 RVA: 0x00EBCA99 File Offset: 0x00EBAC99
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D2E6 RID: 250598 RVA: 0x00EBCAA2 File Offset: 0x00EBACA2
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

		// Token: 0x0603D2E7 RID: 250599 RVA: 0x00EBCABC File Offset: 0x00EBACBC
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(SpecialEnergyBarSanHua.SuccessTagId, new BaseTagComponent.TTagChangedCallback(this.OnSuccessTagCountChange));
			base.ListenForTagCountChanged(SpecialEnergyBarSanHua.BuffTagId, new BaseTagComponent.TTagChangedCallback(this.OnBuffTagCountChange));
		}

		// Token: 0x0603D2E8 RID: 250600 RVA: 0x00EBCAF4 File Offset: 0x00EBACF4
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

		// Token: 0x0603D2E9 RID: 250601 RVA: 0x00EBCB34 File Offset: 0x00EBAD34
		private void OnBuffTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			this.RefreshPercentRange();
			this.RefreshBarPercent(false);
		}

		// Token: 0x0401FE67 RID: 130663
		private const int POINT_NUM = 41;

		// Token: 0x0401FE68 RID: 130664
		private const float POINT_WIDTH = 9f;

		// Token: 0x0401FE69 RID: 130665
		private const float TOTAL_WIDTH = 369f;

		// Token: 0x0401FE6A RID: 130666
		[StaticVariableRuleIgnore]
		private static readonly int SuccessTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SanhuaMd10011.状态标识.蓄力判定成功暂停"];

		// Token: 0x0401FE6B RID: 130667
		[StaticVariableRuleIgnore]
		private static readonly int BuffTagId = GameplayTagDefine.EGameplayTagId["角色.R2T1SanhuaMd10011.状态标识.蓄力被动触发"];

		// Token: 0x0401FE6C RID: 130668
		private const int BUFF_ID = 1102012003;

		// Token: 0x0401FE6D RID: 130669
		[Nullable(2)]
		private SpecialEnergyBarPointItem PointItem;

		// Token: 0x0401FE6E RID: 130670
		private bool TipEffectEnable;

		// Token: 0x0401FE6F RID: 130671
		private float CurLeftPercent;

		// Token: 0x0401FE70 RID: 130672
		private float CurRightPercent = 1f;

		// Token: 0x0401FE71 RID: 130673
		private float LastPercent;

		// Token: 0x0200C14F RID: 49487
		private enum EChildType
		{
			// Token: 0x0403A650 RID: 239184
			PointItem,
			// Token: 0x0403A651 RID: 239185
			SliderItem,
			// Token: 0x0403A652 RID: 239186
			PointTipEffect,
			// Token: 0x0403A653 RID: 239187
			PointSuccessEffect,
			// Token: 0x0403A654 RID: 239188
			KeyContainerItem
		}
	}
}
