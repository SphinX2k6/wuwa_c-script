using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DCA RID: 24010
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarAiMiSiSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D044 RID: 249924 RVA: 0x00EAC17C File Offset: 0x00EAA37C
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarAiMiSiSlot.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarAiMiSiSlot.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D045 RID: 249925 RVA: 0x00EAC1C0 File Offset: 0x00EAA3C0
		protected override void OnStart()
		{
			this.ForceEffectBasePercent = 0.29268292f;
			base.OnStart();
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectPercent(1f);
			}
		}

		// Token: 0x0603D046 RID: 249926 RVA: 0x00EAC228 File Offset: 0x00EAA428
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

		// Token: 0x0603D047 RID: 249927 RVA: 0x00EAC2DC File Offset: 0x00EAA4DC
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

		// Token: 0x0603D048 RID: 249928 RVA: 0x00EAC344 File Offset: 0x00EAA544
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

		// Token: 0x0603D049 RID: 249929 RVA: 0x00EAC3D8 File Offset: 0x00EAA5D8
		public void SetKeyVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(this.SlotNum);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(bVisible);
		}

		// Token: 0x0401FC9F RID: 130207
		private readonly List<FColor> ColorList = new List<FColor>();

		// Token: 0x0401FCA0 RID: 130208
		private readonly List<FColor> PointColorList = new List<FColor>();
	}
}
