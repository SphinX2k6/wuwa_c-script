using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DDC RID: 24028
	public class SpecialEnergyBarJiaBeiLiNaSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D136 RID: 250166 RVA: 0x00EB1DC5 File Offset: 0x00EAFFC5
		protected override void OnInitData()
		{
			base.OnInitData();
			this.RedPercentMachine.Init(this.GetRedTargetAttributePercent());
		}

		// Token: 0x0603D137 RID: 250167 RVA: 0x00EB1DE0 File Offset: 0x00EAFFE0
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

		// Token: 0x0603D138 RID: 250168 RVA: 0x00EB1E1C File Offset: 0x00EB001C
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

		// Token: 0x0603D139 RID: 250169 RVA: 0x00EB1E95 File Offset: 0x00EB0095
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2, new Action<EAttributeType, float, float>(this.RedAttributeChanged));
			base.ListenForAttributeChanged(EAttributeType.SpecialEnergy2Max, new Action<EAttributeType, float, float>(this.RedMaxAttributeChanged));
		}

		// Token: 0x0603D13A RID: 250170 RVA: 0x00EB1EC5 File Offset: 0x00EB00C5
		private void RedAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RedPercentMachine.SetTargetPercent(this.GetRedTargetAttributePercent());
			this.RefreshRedBarPercent(false);
		}

		// Token: 0x0603D13B RID: 250171 RVA: 0x00EB1EDF File Offset: 0x00EB00DF
		private void RedMaxAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
		{
			this.RedPercentMachine.SetTargetPercent(this.GetRedTargetAttributePercent());
			this.RefreshRedBarPercent(false);
		}

		// Token: 0x0603D13C RID: 250172 RVA: 0x00EB1EFC File Offset: 0x00EB00FC
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

		// Token: 0x0603D13D RID: 250173 RVA: 0x00EB1F44 File Offset: 0x00EB0144
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

		// Token: 0x0603D13E RID: 250174 RVA: 0x00EB1FC0 File Offset: 0x00EB01C0
		protected override bool GetKeyEnable()
		{
			return this.PercentMachine.GetCurPercent() >= this.Config.DisableKeyOnPercent && (this.Config.KeyEnableTagId == 0 || this.HasKeyEnableTag);
		}

		// Token: 0x0603D13F RID: 250175 RVA: 0x00EB1FF4 File Offset: 0x00EB01F4
		public override void Tick(float delta)
		{
			base.Tick(delta);
			if (this.RedPercentMachine.Update(delta))
			{
				this.RefreshRedBarPercent(false);
			}
		}

		// Token: 0x0401FD31 RID: 130353
		[Nullable(1)]
		protected SpecialEnergyBarPercentMachine RedPercentMachine = new SpecialEnergyBarPercentMachine();

		// Token: 0x0401FD32 RID: 130354
		private bool LastKeyEnable;

		// Token: 0x0401FD33 RID: 130355
		[Nullable(2)]
		public Action<int, float> PercentCallback;
	}
}
