using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DE0 RID: 19936
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarQingXiaoSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603222E RID: 205358 RVA: 0x00E0C7E8 File Offset: 0x00E0A9E8
		protected override void OnInitData()
		{
			base.OnInitData();
			this.QinPercentMachine.Init(this.GetQinTargetAttributePercent());
			this.JianPercentMachine.Init(this.GetJianTargetAttributePercent());
		}

		// Token: 0x0603222F RID: 205359 RVA: 0x00E0C814 File Offset: 0x00E0AA14
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

		// Token: 0x06032230 RID: 205360 RVA: 0x00E0C84E File Offset: 0x00E0AA4E
		protected float GetQinTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiaoSlot.QIN_ATTR_ID, SpecialEnergyBarQingXiaoSlot.MAX_QIN_ATTR_ID);
		}

		// Token: 0x06032231 RID: 205361 RVA: 0x00E0C860 File Offset: 0x00E0AA60
		protected float GetJianTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiaoSlot.JIAN_ATTR_ID, SpecialEnergyBarQingXiaoSlot.MAX_JIAN_ATTR_ID);
		}

		// Token: 0x06032232 RID: 205362 RVA: 0x00E0C874 File Offset: 0x00E0AA74
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.OnStart();
			this.SetItemStyle(SpecialEnergyBarQingXiaoSlot.QIN_SLOT_INDEX, this.Config.EffectColor, this.Config.PointColorList[SpecialEnergyBarQingXiaoSlot.QIN_SLOT_INDEX]);
			this.SetItemStyle(SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX, this.Config.OtherEffectColorList[SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX - 1], this.Config.PointColorList[SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX]);
		}

		// Token: 0x06032233 RID: 205363 RVA: 0x00E0C8E8 File Offset: 0x00E0AAE8
		private void SetItemStyle(int index, string barColor, string pointColor)
		{
			this.SlotItemList[index].SetFullEffectPercent(1f);
			SpecialEnergyBarSlotItem specialEnergyBarSlotItem = this.SlotItemList[index];
			FColor fcolor = FColor.FromHex(barColor);
			specialEnergyBarSlotItem.SetBarColor(fcolor);
			SpecialEnergyBarSlotItem specialEnergyBarSlotItem2 = this.SlotItemList[index];
			fcolor = FColor.FromHex(pointColor);
			specialEnergyBarSlotItem2.SetPointColor(fcolor);
		}

		// Token: 0x06032234 RID: 205364 RVA: 0x00E0C940 File Offset: 0x00E0AB40
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.MAX_QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.MAX_JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
		}

		// Token: 0x06032235 RID: 205365 RVA: 0x00E0C9AF File Offset: 0x00E0ABAF
		private void OnQinPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.QinPercentMachine.SetTargetPercent(this.GetQinTargetAttributePercent());
			this.RefreshQinBarPercent(false);
		}

		// Token: 0x06032236 RID: 205366 RVA: 0x00E0C9C9 File Offset: 0x00E0ABC9
		private void OnJianPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.JianPercentMachine.SetTargetPercent(this.GetJianTargetAttributePercent());
			this.RefreshJianBarPercent(false);
		}

		// Token: 0x06032237 RID: 205367 RVA: 0x00E0C9E4 File Offset: 0x00E0ABE4
		protected void RefreshQinBarPercent(bool isStart = false)
		{
			float curPercent = this.QinPercentMachine.GetCurPercent();
			this.SlotItemList[SpecialEnergyBarQingXiaoSlot.QIN_SLOT_INDEX].UpdatePercent(curPercent, true, false);
			Action<int, float> percentCallback = this.PercentCallback;
			if (percentCallback == null)
			{
				return;
			}
			percentCallback(SpecialEnergyBarQingXiaoSlot.QIN_SLOT_INDEX, curPercent);
		}

		// Token: 0x06032238 RID: 205368 RVA: 0x00E0CA2C File Offset: 0x00E0AC2C
		protected void RefreshJianBarPercent(bool isStart = false)
		{
			float curPercent = this.JianPercentMachine.GetCurPercent();
			this.SlotItemList[SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX].UpdatePercent(curPercent, true, false);
			Action<int, float> percentCallback = this.PercentCallback;
			if (percentCallback == null)
			{
				return;
			}
			percentCallback(SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX, curPercent);
		}

		// Token: 0x06032239 RID: 205369 RVA: 0x00E0CA74 File Offset: 0x00E0AC74
		protected override void RefreshBarPercent(bool isStart = false)
		{
			bool keyEnable = this.GetKeyEnable();
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(keyEnable, isStart);
			}
			this.RefreshQinBarPercent(isStart);
			this.RefreshJianBarPercent(isStart);
		}

		// Token: 0x0603223A RID: 205370 RVA: 0x00E0CAA9 File Offset: 0x00E0ACA9
		public void SetKeyEnable(bool enable)
		{
			if (this.IsKeyEnable == enable)
			{
				return;
			}
			this.IsKeyEnable = enable;
			this.RefreshBarPercent(false);
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(enable, false);
		}

		// Token: 0x0603223B RID: 205371 RVA: 0x00E0CAD5 File Offset: 0x00E0ACD5
		protected override bool GetKeyEnable()
		{
			return this.IsKeyEnable;
		}

		// Token: 0x0603223C RID: 205372 RVA: 0x00E0CADD File Offset: 0x00E0ACDD
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.QinPercentMachine.Update(delta))
			{
				this.RefreshQinBarPercent(false);
			}
			if (this.JianPercentMachine.Update(delta))
			{
				this.RefreshJianBarPercent(false);
			}
		}

		// Token: 0x0401A901 RID: 108801
		private static readonly EAttributeType QIN_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401A902 RID: 108802
		private static readonly EAttributeType MAX_QIN_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401A903 RID: 108803
		private static readonly EAttributeType JIAN_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401A904 RID: 108804
		private static readonly EAttributeType MAX_JIAN_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401A905 RID: 108805
		private static readonly int QIN_SLOT_INDEX = 0;

		// Token: 0x0401A906 RID: 108806
		private static readonly int JIAN_SLOT_INDEX = 1;

		// Token: 0x0401A907 RID: 108807
		protected SpecialEnergyBarPercentMachine QinPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401A908 RID: 108808
		protected SpecialEnergyBarPercentMachine JianPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401A909 RID: 108809
		private bool IsKeyEnable;

		// Token: 0x0401A90A RID: 108810
		[Nullable(2)]
		public Action<int, float> PercentCallback;
	}
}
