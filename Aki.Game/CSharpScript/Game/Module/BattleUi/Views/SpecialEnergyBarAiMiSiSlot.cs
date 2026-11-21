using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DAE RID: 19886
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarAiMiSiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x06031FBB RID: 204731 RVA: 0x00DFD070 File Offset: 0x00DFB270
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarAiMiSiSlot.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarAiMiSiSlot.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031FBC RID: 204732 RVA: 0x00DFD0B4 File Offset: 0x00DFB2B4
		protected override void OnStart()
		{
			this.ForceEffectBasePercent = 0.29268292f;
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectPercent(1f);
			}
		}

		// Token: 0x06031FBD RID: 204733 RVA: 0x00DFD11C File Offset: 0x00DFB31C
		protected override void OnInitData()
		{
			base.OnInitData();
			if (this.Config != null)
			{
				if (!string.IsNullOrEmpty(this.Config.EffectColor))
				{
					FColor item = FColor.FromHex(this.Config.EffectColor);
					this.ColorList.Add(item);
				}
				string valueOrDefault = this.Config.OtherEffectColorList.GetValueOrDefault(0);
				if (!string.IsNullOrEmpty(valueOrDefault))
				{
					FColor item2 = FColor.FromHex(valueOrDefault);
					this.ColorList.Add(item2);
				}
				if (this.Config.PointColorList.Length >= 2)
				{
					for (int i = 0; i < 2; i++)
					{
						this.PointColorList.Add(FColor.FromHex(this.Config.PointColorList[i]));
					}
				}
			}
		}

		// Token: 0x06031FBE RID: 204734 RVA: 0x00DFD1D0 File Offset: 0x00DFB3D0
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SlotItemList[i].UpdatePercent(curPercent * (float)this.SlotNum - (float)i, true, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x06031FBF RID: 204735 RVA: 0x00DFD238 File Offset: 0x00DFB438
		public void SetBarColor(int type)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				FColor fcolor = this.ColorList[type];
				specialEnergyBarSlotItem.SetBarColor(fcolor);
				fcolor = this.PointColorList[type];
				specialEnergyBarSlotItem.SetPointColor(fcolor);
			}
			if (type == 0)
			{
				this.RevertFullEffect();
				return;
			}
			this.ReplaceFullEffect(this.NiagaraList[type - 1]);
		}

		// Token: 0x06031FC0 RID: 204736 RVA: 0x00DFD2CC File Offset: 0x00DFB4CC
		public void SetKeyVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(this.SlotNum);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0401A75C RID: 108380
		private readonly List<FColor> ColorList = new List<FColor>();

		// Token: 0x0401A75D RID: 108381
		private readonly List<FColor> PointColorList = new List<FColor>();
	}
}
