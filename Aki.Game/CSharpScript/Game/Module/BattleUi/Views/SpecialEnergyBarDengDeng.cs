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
	// Token: 0x02005DD5 RID: 24021
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarDengDeng : SpecialEnergyBarBase
	{
		// Token: 0x0603D0CB RID: 250059 RVA: 0x00EAF5C8 File Offset: 0x00EAD7C8
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

		// Token: 0x0603D0CC RID: 250060 RVA: 0x00EAF6D6 File Offset: 0x00EAD8D6
		protected override void OnInitData()
		{
			base.OnInitData();
			this.IsRedState = this.TagComponent.HasTag(SpecialEnergyBarDengDeng.TagRed);
			this.SecondPercentMachine.Init(this.GetSecondTargetAttributePercent());
		}

		// Token: 0x0603D0CD RID: 250061 RVA: 0x00EAF708 File Offset: 0x00EAD908
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarDengDeng.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarDengDeng.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D0CE RID: 250062 RVA: 0x00EAF74C File Offset: 0x00EAD94C
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

		// Token: 0x0603D0CF RID: 250063 RVA: 0x00EAF798 File Offset: 0x00EAD998
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

		// Token: 0x0603D0D0 RID: 250064 RVA: 0x00EAF7E4 File Offset: 0x00EAD9E4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(this.SecondAttributeId, new Action<EAttributeType, float, float>(this.SecondAttributeChanged));
			base.ListenForAttributeChanged(this.SecondMaxAttributeId, new Action<EAttributeType, float, float>(this.SecondMaxAttributeChanged));
			base.ListenForTagAddOrRemoveChanged(SpecialEnergyBarDengDeng.TagRed, new BaseTagComponent.TTagSwitchedCallback(this.OnTagRedChange));
		}

		// Token: 0x0603D0D1 RID: 250065 RVA: 0x00EAF83E File Offset: 0x00EADA3E
		protected override void RemoveEvents()
		{
			base.RemoveEvents();
			base.RemoveListenAttributeChanged(this.SecondAttributeId, new Action<EAttributeType, float, float>(this.SecondAttributeChanged));
			base.RemoveListenAttributeChanged(this.SecondMaxAttributeId, new Action<EAttributeType, float, float>(this.SecondMaxAttributeChanged));
		}

		// Token: 0x0603D0D2 RID: 250066 RVA: 0x00EAF878 File Offset: 0x00EADA78
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

		// Token: 0x0603D0D3 RID: 250067 RVA: 0x00EAF960 File Offset: 0x00EADB60
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

		// Token: 0x0603D0D4 RID: 250068 RVA: 0x00EAF9AB File Offset: 0x00EADBAB
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

		// Token: 0x0603D0D5 RID: 250069 RVA: 0x00EAF9EC File Offset: 0x00EADBEC
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

		// Token: 0x0603D0D6 RID: 250070 RVA: 0x00EAFA80 File Offset: 0x00EADC80
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

		// Token: 0x0603D0D7 RID: 250071 RVA: 0x00EAFB10 File Offset: 0x00EADD10
		private void RefreshKeyEnable(bool isStart = false)
		{
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(this.GetKeyEnable(), isStart);
		}

		// Token: 0x0603D0D8 RID: 250072 RVA: 0x00EAFB29 File Offset: 0x00EADD29
		protected override bool GetKeyEnable()
		{
			return (this.IsRedState ? this.SecondPercentMachine.GetCurPercent() : this.PercentMachine.GetCurPercent()) >= this.Config.DisableKeyOnPercent;
		}

		// Token: 0x0603D0D9 RID: 250073 RVA: 0x00EAFB5B File Offset: 0x00EADD5B
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D0DA RID: 250074 RVA: 0x00EAFB64 File Offset: 0x00EADD64
		private void OnSecondBarPercentChanged()
		{
			this.RefreshSecondBarPercent(false);
		}

		// Token: 0x0603D0DB RID: 250075 RVA: 0x00EAFB6D File Offset: 0x00EADD6D
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

		// Token: 0x0603D0DC RID: 250076 RVA: 0x00EAFBAD File Offset: 0x00EADDAD
		private void SecondAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SecondPercentMachine.SetTargetPercent(this.GetSecondTargetAttributePercent());
			this.OnSecondBarPercentChanged();
		}

		// Token: 0x0603D0DD RID: 250077 RVA: 0x00EAFBC6 File Offset: 0x00EADDC6
		private void SecondMaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.SecondPercentMachine.SetTargetPercent(this.GetSecondTargetAttributePercent());
			this.OnSecondBarPercentChanged();
		}

		// Token: 0x0603D0DE RID: 250078 RVA: 0x00EAFBE0 File Offset: 0x00EADDE0
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

		// Token: 0x0603D0DF RID: 250079 RVA: 0x00EAFC24 File Offset: 0x00EADE24
		private void OnTagRedChange(int tagId, bool tagExist)
		{
			if (tagExist == this.IsRedState)
			{
				return;
			}
			this.IsRedState = tagExist;
			this.UpdateRedState(false);
		}

		// Token: 0x0401FCEF RID: 130287
		private const float WIDTH = 190f;

		// Token: 0x0401FCF0 RID: 130288
		private const float EFFECT_BASE_PERCENT = 0.4878049f;

		// Token: 0x0401FCF1 RID: 130289
		[StaticVariableRuleIgnore]
		private static readonly int TagRed = GameplayTagDefine.EGameplayTagId["角色.R2T1DengDengMd10011.状态标识.红剑"];

		// Token: 0x0401FCF2 RID: 130290
		[Nullable(2)]
		private SpecialEnergyBarSlotItem SlotLeftItem;

		// Token: 0x0401FCF3 RID: 130291
		[Nullable(2)]
		private SpecialEnergyBarSlotItem SlotRightItem;

		// Token: 0x0401FCF4 RID: 130292
		private readonly SpecialEnergyBarPercentMachine SecondPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401FCF5 RID: 130293
		private readonly EAttributeType SecondAttributeId = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FCF6 RID: 130294
		private readonly EAttributeType SecondMaxAttributeId = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FCF7 RID: 130295
		private bool IsRedState;

		// Token: 0x0401FCF8 RID: 130296
		private bool IsLeftGraduateEffectVisible;

		// Token: 0x0401FCF9 RID: 130297
		private bool IsRightGraduateEffectVisible;

		// Token: 0x0200C0ED RID: 49389
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A39D RID: 238493
			SlotLeftItem,
			// Token: 0x0403A39E RID: 238494
			SlotRightItem,
			// Token: 0x0403A39F RID: 238495
			KeyContainerItem,
			// Token: 0x0403A3A0 RID: 238496
			LeftGraduateItem,
			// Token: 0x0403A3A1 RID: 238497
			RightGraduateItem,
			// Token: 0x0403A3A2 RID: 238498
			LeftGraduateEffect,
			// Token: 0x0403A3A3 RID: 238499
			RightGraduateEffect
		}
	}
}
