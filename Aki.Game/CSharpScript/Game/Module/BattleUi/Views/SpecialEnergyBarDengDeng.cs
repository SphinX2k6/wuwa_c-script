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
	// Token: 0x02004DB9 RID: 19897
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarDengDeng : SpecialEnergyBarBase
	{
		// Token: 0x06032042 RID: 204866 RVA: 0x00E004BC File Offset: 0x00DFE6BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06032043 RID: 204867 RVA: 0x00E005CA File Offset: 0x00DFE7CA
		protected override void OnInitData()
		{
			base.OnInitData();
			this.IsRedState = this.TagComponent.HasTag(SpecialEnergyBarDengDeng.TagRed);
			this.SecondPercentMachine.Init(this.GetSecondTargetAttributePercent());
		}

		// Token: 0x06032044 RID: 204868 RVA: 0x00E005FC File Offset: 0x00DFE7FC
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarDengDeng.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarDengDeng.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032045 RID: 204869 RVA: 0x00E00640 File Offset: 0x00DFE840
		private UniTask InitPointLeftItem(UUIItem pointItem)
		{
			SpecialEnergyBarDengDeng.<InitPointLeftItem>d__15 <InitPointLeftItem>d__;
			<InitPointLeftItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointLeftItem>d__.<>4__this = this;
			<InitPointLeftItem>d__.pointItem = pointItem;
			<InitPointLeftItem>d__.<>1__state = -1;
			<InitPointLeftItem>d__.<>t__builder.Start<SpecialEnergyBarDengDeng.<InitPointLeftItem>d__15>(ref <InitPointLeftItem>d__);
			return <InitPointLeftItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032046 RID: 204870 RVA: 0x00E0068C File Offset: 0x00DFE88C
		private UniTask InitPointRightItem(UUIItem pointItem)
		{
			SpecialEnergyBarDengDeng.<InitPointRightItem>d__16 <InitPointRightItem>d__;
			<InitPointRightItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPointRightItem>d__.<>4__this = this;
			<InitPointRightItem>d__.pointItem = pointItem;
			<InitPointRightItem>d__.<>1__state = -1;
			<InitPointRightItem>d__.<>t__builder.Start<SpecialEnergyBarDengDeng.<InitPointRightItem>d__16>(ref <InitPointRightItem>d__);
			return <InitPointRightItem>d__.<>t__builder.Task;
		}

		// Token: 0x06032047 RID: 204871 RVA: 0x00E006D8 File Offset: 0x00DFE8D8
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(this.SecondAttributeId, new Action<EAttributeType, float, float>(this.SecondAttributeChanged));
			base.ListenForAttributeChanged(this.SecondMaxAttributeId, new Action<EAttributeType, float, float>(this.SecondMaxAttributeChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarDengDeng.TagRed, new BaseTagComponent.TTagSwitchedCallback(this.OnTagRedChange));
		}

		// Token: 0x06032048 RID: 204872 RVA: 0x00E00732 File Offset: 0x00DFE932
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(this.SecondAttributeId, new Action<EAttributeType, float, float>(this.SecondAttributeChanged));
			base.RemoveListenAttributeChanged(this.SecondMaxAttributeId, new Action<EAttributeType, float, float>(this.SecondMaxAttributeChanged));
		}

		// Token: 0x06032049 RID: 204873 RVA: 0x00E0076C File Offset: 0x00DFE96C
		protected override void OnStart()
		{
			if (this.Config == null)
			{
				return;
			}
			this.SlotLeftItem.SetEffectBasePercent(0.4878049f);
			this.SlotRightItem.SetEffectBasePercent(0.4878049f);
			this.InitColor(this.SlotLeftItem, this.Config.PointColorList[0], this.Config.PointColorList[1], this.Config.EffectColor);
			this.InitColor(this.SlotRightItem, this.Config.PointColorList[2], this.Config.PointColorList[3], this.Config.OtherEffectColorList[0]);
			this.SlotLeftItem.ReplaceFullEffect(this.NiagaraList[0]);
			this.SlotRightItem.ReplaceFullEffect(this.NiagaraList[1]);
			this.UpdateRedState(true);
			this.RefreshBarPercent(true);
			this.RefreshSecondBarPercent(true);
			this.RefreshKeyEnable(true);
		}

		// Token: 0x0603204A RID: 204874 RVA: 0x00E00854 File Offset: 0x00DFEA54
		private void InitColor(SpecialEnergyBarSlotItem slotItem, string pointBgColorStr, string pointColorStr, string effectColorStr)
		{
			FColor fcolor = FColor.FromHex(pointBgColorStr);
			FColor fcolor2 = FColor.FromHex(pointColorStr);
			FColor fcolor3 = FColor.FromHex(effectColorStr);
			FLinearColor flinearColor = new FLinearColor(ref fcolor3);
			slotItem.SetPointBgColor(fcolor);
			slotItem.SetBarColor(fcolor2);
			slotItem.SetPointColor(fcolor2);
			slotItem.SetBgAndUseEffectColor(flinearColor);
		}

		// Token: 0x0603204B RID: 204875 RVA: 0x00E0089F File Offset: 0x00DFEA9F
		private void UpdateRedState(bool isStart = false)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(!this.IsRedState);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(this.IsRedState);
			}
			if (!isStart)
			{
				this.RefreshKeyEnable(false);
			}
		}

		// Token: 0x0603204C RID: 204876 RVA: 0x00E008E0 File Offset: 0x00DFEAE0
		private void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.SlotLeftItem.UpdatePercent(curPercent, curPercent >= this.Config.DisableKeyOnPercent, false);
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetAnchorOffsetX(-curPercent * 190f);
			}
			if (!this.IsRedState && !isStart)
			{
				this.RefreshKeyEnable(false);
			}
			bool flag = curPercent > 0f;
			if (isStart || flag != this.IsLeftGraduateEffectVisible)
			{
				this.IsLeftGraduateEffectVisible = flag;
				UUINiagara uiNiagara = base.GetUiNiagara(5);
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetUIActive(flag);
			}
		}

		// Token: 0x0603204D RID: 204877 RVA: 0x00E00974 File Offset: 0x00DFEB74
		private void RefreshSecondBarPercent(bool isStart = false)
		{
			float curPercent = this.SecondPercentMachine.GetCurPercent();
			this.SlotRightItem.UpdatePercent(curPercent, curPercent >= this.Config.DisableKeyOnPercent, false);
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetAnchorOffsetX(curPercent * 190f);
			}
			if (this.IsRedState && !isStart)
			{
				this.RefreshKeyEnable(isStart);
			}
			bool flag = curPercent > 0f;
			if (isStart || flag != this.IsRightGraduateEffectVisible)
			{
				this.IsRightGraduateEffectVisible = flag;
				UUINiagara uiNiagara = base.GetUiNiagara(6);
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetUIActive(flag);
			}
		}

		// Token: 0x0603204E RID: 204878 RVA: 0x00E00A04 File Offset: 0x00DFEC04
		private void RefreshKeyEnable(bool isStart = false)
		{
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x0603204F RID: 204879 RVA: 0x00E00A1D File Offset: 0x00DFEC1D
		protected override bool GetKeyEnable()
		{
			return (this.IsRedState ? this.SecondPercentMachine.GetCurPercent() : this.PercentMachine.GetCurPercent()) >= this.Config.DisableKeyOnPercent;
		}

		// Token: 0x06032050 RID: 204880 RVA: 0x00E00A4F File Offset: 0x00DFEC4F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x06032051 RID: 204881 RVA: 0x00E00A58 File Offset: 0x00DFEC58
		private void OnSecondBarPercentChanged()
		{
			this.RefreshSecondBarPercent(false);
		}

		// Token: 0x06032052 RID: 204882 RVA: 0x00E00A61 File Offset: 0x00DFEC61
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.SecondPercentMachine.Update(delta))
			{
				this.OnSecondBarPercentChanged();
			}
			SpecialEnergyBarSlotItem slotLeftItem = this.SlotLeftItem;
			if (slotLeftItem != null)
			{
				slotLeftItem.Tick(delta);
			}
			SpecialEnergyBarSlotItem slotRightItem = this.SlotRightItem;
			if (slotRightItem == null)
			{
				return;
			}
			slotRightItem.Tick(delta);
		}

		// Token: 0x06032053 RID: 204883 RVA: 0x00E00AA1 File Offset: 0x00DFECA1
		private void SecondAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SecondPercentMachine.SetTargetPercent(this.GetSecondTargetAttributePercent());
			this.OnSecondBarPercentChanged();
		}

		// Token: 0x06032054 RID: 204884 RVA: 0x00E00ABA File Offset: 0x00DFECBA
		private void SecondMaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SecondPercentMachine.SetTargetPercent(this.GetSecondTargetAttributePercent());
			this.OnSecondBarPercentChanged();
		}

		// Token: 0x06032055 RID: 204885 RVA: 0x00E00AD4 File Offset: 0x00DFECD4
		private float GetSecondTargetAttributePercent()
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(this.SecondAttributeId);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(this.SecondMaxAttributeId);
			float result = 0f;
			if (currentValue2 > 0f)
			{
				result = currentValue / currentValue2;
			}
			return result;
		}

		// Token: 0x06032056 RID: 204886 RVA: 0x00E00B18 File Offset: 0x00DFED18
		private void OnTagRedChange(int tagId, bool tagExist)
		{
			if (tagExist == this.IsRedState)
			{
				return;
			}
			this.IsRedState = tagExist;
			this.UpdateRedState(false);
		}

		// Token: 0x0401A7AC RID: 108460
		private const float WIDTH = 190f;

		// Token: 0x0401A7AD RID: 108461
		private const float EFFECT_BASE_PERCENT = 0.4878049f;

		// Token: 0x0401A7AE RID: 108462
		[StaticVariableRuleIgnore]
		private static readonly int TagRed = GameplayTagDefine.EGameplayTagId["角色.R2T1DengDengMd10011.状态标识.红剑"];

		// Token: 0x0401A7AF RID: 108463
		[Nullable(2)]
		private SpecialEnergyBarSlotItem SlotLeftItem;

		// Token: 0x0401A7B0 RID: 108464
		[Nullable(2)]
		private SpecialEnergyBarSlotItem SlotRightItem;

		// Token: 0x0401A7B1 RID: 108465
		private readonly SpecialEnergyBarPercentMachine SecondPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401A7B2 RID: 108466
		private readonly EAttributeType SecondAttributeId = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A7B3 RID: 108467
		private readonly EAttributeType SecondMaxAttributeId = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A7B4 RID: 108468
		private bool IsRedState;

		// Token: 0x0401A7B5 RID: 108469
		private bool IsLeftGraduateEffectVisible;

		// Token: 0x0401A7B6 RID: 108470
		private bool IsRightGraduateEffectVisible;

		// Token: 0x0200AAF6 RID: 43766
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04034D6F RID: 216431
			SlotLeftItem,
			// Token: 0x04034D70 RID: 216432
			SlotRightItem,
			// Token: 0x04034D71 RID: 216433
			KeyContainerItem,
			// Token: 0x04034D72 RID: 216434
			LeftGraduateItem,
			// Token: 0x04034D73 RID: 216435
			RightGraduateItem,
			// Token: 0x04034D74 RID: 216436
			LeftGraduateEffect,
			// Token: 0x04034D75 RID: 216437
			RightGraduateEffect
		}
	}
}
