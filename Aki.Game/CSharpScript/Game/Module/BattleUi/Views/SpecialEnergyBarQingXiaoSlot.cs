using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DFB RID: 24059
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarQingXiaoSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D29F RID: 250527 RVA: 0x00EBB29C File Offset: 0x00EB949C
		protected override void OnInitData()
		{
			base.OnInitData();
			this.QinPercentMachine.Init(this.GetQinTargetAttributePercent());
			this.JianPercentMachine.Init(this.GetJianTargetAttributePercent());
		}

		// Token: 0x0603D2A0 RID: 250528 RVA: 0x00EBB2C8 File Offset: 0x00EB94C8
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

		// Token: 0x0603D2A1 RID: 250529 RVA: 0x00EBB302 File Offset: 0x00EB9502
		protected float GetQinTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiaoSlot.QIN_ATTR_ID, SpecialEnergyBarQingXiaoSlot.MAX_QIN_ATTR_ID);
		}

		// Token: 0x0603D2A2 RID: 250530 RVA: 0x00EBB314 File Offset: 0x00EB9514
		protected float GetJianTargetAttributePercent()
		{
			return this.GetAttributePercent(SpecialEnergyBarQingXiaoSlot.JIAN_ATTR_ID, SpecialEnergyBarQingXiaoSlot.MAX_JIAN_ATTR_ID);
		}

		// Token: 0x0603D2A3 RID: 250531 RVA: 0x00EBB328 File Offset: 0x00EB9528
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.OnStart();
			this.SetItemStyle(SpecialEnergyBarQingXiaoSlot.QIN_SLOT_INDEX, this.Config.EffectColor, this.Config.PointColorList[SpecialEnergyBarQingXiaoSlot.QIN_SLOT_INDEX]);
			this.SetItemStyle(SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX, this.Config.OtherEffectColorList[SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX - 1], this.Config.PointColorList[SpecialEnergyBarQingXiaoSlot.JIAN_SLOT_INDEX]);
		}

		// Token: 0x0603D2A4 RID: 250532 RVA: 0x00EBB39C File Offset: 0x00EB959C
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

		// Token: 0x0603D2A5 RID: 250533 RVA: 0x00EBB3F4 File Offset: 0x00EB95F4
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.MAX_QIN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnQinPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
			base.ListenForAttributeChanged(SpecialEnergyBarQingXiaoSlot.MAX_JIAN_ATTR_ID, new Action<EAttributeType, float, float>(this.OnJianPercentChange));
		}

		// Token: 0x0603D2A6 RID: 250534 RVA: 0x00EBB463 File Offset: 0x00EB9663
		private void OnQinPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.QinPercentMachine.SetTargetPercent(this.GetQinTargetAttributePercent());
			this.RefreshQinBarPercent(false);
		}

		// Token: 0x0603D2A7 RID: 250535 RVA: 0x00EBB47D File Offset: 0x00EB967D
		private void OnJianPercentChange(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.JianPercentMachine.SetTargetPercent(this.GetJianTargetAttributePercent());
			this.RefreshJianBarPercent(false);
		}

		// Token: 0x0603D2A8 RID: 250536 RVA: 0x00EBB498 File Offset: 0x00EB9698
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

		// Token: 0x0603D2A9 RID: 250537 RVA: 0x00EBB4E0 File Offset: 0x00EB96E0
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

		// Token: 0x0603D2AA RID: 250538 RVA: 0x00EBB528 File Offset: 0x00EB9728
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

		// Token: 0x0603D2AB RID: 250539 RVA: 0x00EBB55D File Offset: 0x00EB975D
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

		// Token: 0x0603D2AC RID: 250540 RVA: 0x00EBB589 File Offset: 0x00EB9789
		protected override bool GetKeyEnable()
		{
			return this.IsKeyEnable;
		}

		// Token: 0x0603D2AD RID: 250541 RVA: 0x00EBB591 File Offset: 0x00EB9791
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

		// Token: 0x0401FE3A RID: 130618
		private static readonly EAttributeType QIN_ATTR_ID = EAttributeType.SpecialEnergy1;

		// Token: 0x0401FE3B RID: 130619
		private static readonly EAttributeType MAX_QIN_ATTR_ID = EAttributeType.SpecialEnergy1Max;

		// Token: 0x0401FE3C RID: 130620
		private static readonly EAttributeType JIAN_ATTR_ID = EAttributeType.SpecialEnergy2;

		// Token: 0x0401FE3D RID: 130621
		private static readonly EAttributeType MAX_JIAN_ATTR_ID = EAttributeType.SpecialEnergy2Max;

		// Token: 0x0401FE3E RID: 130622
		private static readonly int QIN_SLOT_INDEX = 0;

		// Token: 0x0401FE3F RID: 130623
		private static readonly int JIAN_SLOT_INDEX = 1;

		// Token: 0x0401FE40 RID: 130624
		protected SpecialEnergyBarPercentMachine QinPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401FE41 RID: 130625
		protected SpecialEnergyBarPercentMachine JianPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401FE42 RID: 130626
		private bool IsKeyEnable;

		// Token: 0x0401FE43 RID: 130627
		[Nullable(2)]
		public Action<int, float> PercentCallback;
	}
}
