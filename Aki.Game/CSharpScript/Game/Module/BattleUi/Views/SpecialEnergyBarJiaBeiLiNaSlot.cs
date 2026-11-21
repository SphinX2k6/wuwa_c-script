using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC0 RID: 19904
	public class SpecialEnergyBarJiaBeiLiNaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060320AD RID: 204973 RVA: 0x00E02CB9 File Offset: 0x00E00EB9
		protected override void OnInitData()
		{
			base.OnInitData();
			this.RedPercentMachine.Init(this.GetRedTargetAttributePercent());
		}

		// Token: 0x060320AE RID: 204974 RVA: 0x00E02CD4 File Offset: 0x00E00ED4
		protected float GetRedTargetAttributePercent()
		{
			float currentValue = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2);
			float currentValue2 = this.AttributeComponent.GetCurrentValue(EAttributeType.SpecialEnergy2Max);
			float result = 0f;
			if (currentValue2 > 0f)
			{
				result = currentValue / currentValue2;
			}
			return result;
		}

		// Token: 0x060320AF RID: 204975 RVA: 0x00E02D10 File Offset: 0x00E00F10
		protected override void OnStart()
		{
			this.OverrideColor = true;
			base.OnStart();
			this.SlotItemList[0].SetEffectBasePercent(0.27f);
			this.SlotItemList[0].SetFullEffectPercent(1f);
			this.SlotItemList[1].SetEffectBasePercent(0.7f);
			this.SlotItemList[1].SetFullEffectPercent(1f);
			this.RefreshRedBarPercent(true);
		}

		// Token: 0x060320B0 RID: 204976 RVA: 0x00E02D89 File Offset: 0x00E00F89
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.RedAttributeChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2Max, new Action<EAttributeType, float, float>(this.RedMaxAttributeChanged));
		}

		// Token: 0x060320B1 RID: 204977 RVA: 0x00E02DB9 File Offset: 0x00E00FB9
		private void RedAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RedPercentMachine.SetTargetPercent(this.GetRedTargetAttributePercent());
			this.RefreshRedBarPercent(false);
		}

		// Token: 0x060320B2 RID: 204978 RVA: 0x00E02DD3 File Offset: 0x00E00FD3
		private void RedMaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RedPercentMachine.SetTargetPercent(this.GetRedTargetAttributePercent());
			this.RefreshRedBarPercent(false);
		}

		// Token: 0x060320B3 RID: 204979 RVA: 0x00E02DF0 File Offset: 0x00E00FF0
		protected void RefreshRedBarPercent(bool isStart = false)
		{
			float curPercent = this.RedPercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			this.SlotItemList[0].UpdatePercent(curPercent, keyEnable, false);
			Action<int, float> percentCallback = this.PercentCallback;
			if (percentCallback == null)
			{
				return;
			}
			percentCallback(0, curPercent);
		}

		// Token: 0x060320B4 RID: 204980 RVA: 0x00E02E38 File Offset: 0x00E01038
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			this.SlotItemList[1].UpdatePercent(curPercent, keyEnable, false);
			Action<int, float> percentCallback = this.PercentCallback;
			if (percentCallback != null)
			{
				percentCallback(1, curPercent);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(keyEnable, isStart);
			}
			if (isStart)
			{
				this.LastKeyEnable = keyEnable;
				return;
			}
			if (this.LastKeyEnable != keyEnable)
			{
				this.LastKeyEnable = keyEnable;
				this.RefreshRedBarPercent(false);
			}
		}

		// Token: 0x060320B5 RID: 204981 RVA: 0x00E02EB4 File Offset: 0x00E010B4
		protected override bool GetKeyEnable()
		{
			return this.PercentMachine.GetCurPercent() >= this.Config.DisableKeyOnPercent && (this.Config.KeyEnableTagId == 0 || this.HasKeyEnableTag);
		}

		// Token: 0x060320B6 RID: 204982 RVA: 0x00E02EE8 File Offset: 0x00E010E8
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.RedPercentMachine.Update(delta))
			{
				this.RefreshRedBarPercent(false);
			}
		}

		// Token: 0x0401A7EE RID: 108526
		[Nullable(1)]
		protected SpecialEnergyBarPercentMachine RedPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401A7EF RID: 108527
		private bool LastKeyEnable;

		// Token: 0x0401A7F0 RID: 108528
		[Nullable(2)]
		public Action<int, float> PercentCallback;
	}
}
