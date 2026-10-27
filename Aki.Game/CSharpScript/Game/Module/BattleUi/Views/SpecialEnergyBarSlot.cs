using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E28 RID: 24104
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarSlot : SpecialEnergyBarBase
	{
		// Token: 0x0603D4C9 RID: 251081 RVA: 0x00EC60B4 File Offset: 0x00EC42B4
		protected override void OnRegisterComponent()
		{
			this.SlotNum = this.Config.SlotNum;
			if (this.SlotNum == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "槽型的能量条，分段数量不能为0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", this.Config.Id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			for (int i = 0; i <= this.SlotNum + 1; i++)
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(i, typeof(UUIItem)));
			}
		}

		// Token: 0x0603D4CA RID: 251082 RVA: 0x00EC6140 File Offset: 0x00EC4340
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSlot.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSlot.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4CB RID: 251083 RVA: 0x00EC6184 File Offset: 0x00EC4384
		protected virtual UniTask InitSlotItem(UUIItem slotItem)
		{
			SpecialEnergyBarSlot.<InitSlotItem>d__9 <InitSlotItem>d__;
			<InitSlotItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitSlotItem>d__.<>4__this = this;
			<InitSlotItem>d__.slotItem = slotItem;
			<InitSlotItem>d__.<>1__state = -1;
			<InitSlotItem>d__.<>t__builder.Start<SpecialEnergyBarSlot.<InitSlotItem>d__9>(ref <InitSlotItem>d__);
			return <InitSlotItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603D4CC RID: 251084 RVA: 0x00EC61D0 File Offset: 0x00EC43D0
		protected override void OnStart()
		{
			if (this.Config == null)
			{
				return;
			}
			float effectBasePercent = (this.ForceEffectBasePercent > 0f) ? this.ForceEffectBasePercent : SpecialEnergyBarSlot.effectBasePercents[this.SlotNum - 1];
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetEffectBasePercent(effectBasePercent);
			}
			if (!this.OverrideColor && !string.IsNullOrEmpty(this.Config.EffectColor))
			{
				FColor fcolor = FColor.FromHex(this.Config.EffectColor);
				FLinearColor flinearColor = new FLinearColor(ref fcolor);
				FColor fcolor2 = fcolor;
				if (!string.IsNullOrEmpty(this.Config.PointColor))
				{
					fcolor2 = FColor.FromHex(this.Config.PointColor);
				}
				foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem2 in this.SlotItemList)
				{
					specialEnergyBarSlotItem2.SetBarColor(fcolor);
					specialEnergyBarSlotItem2.SetPointColor(fcolor2);
					specialEnergyBarSlotItem2.SetFullEffectColor(flinearColor, this.IsMorph);
				}
			}
			bool uiactive = true;
			if (this.ForceHideBottomLine)
			{
				uiactive = false;
			}
			else if (this.IsMorph)
			{
				SpecialEnergyBarInfo config = this.Config;
				if (!string.IsNullOrEmpty((config != null) ? config.IconPath : null))
				{
					uiactive = false;
				}
			}
			UUIItem item = base.GetItem(this.SlotNum + 1);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			this.RefreshBarPercent(true);
		}

		// Token: 0x0603D4CD RID: 251085 RVA: 0x00EC6358 File Offset: 0x00EC4558
		protected virtual void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			bool keyEnable = this.GetKeyEnable();
			for (int i = 0; i < this.SlotItemList.Count; i++)
			{
				this.SlotItemList[i].UpdatePercent(curPercent * (float)this.SlotNum - (float)i, keyEnable, false);
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.RefreshKeyEnable(keyEnable, isStart);
		}

		// Token: 0x0603D4CE RID: 251086 RVA: 0x00EC63BF File Offset: 0x00EC45BF
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D4CF RID: 251087 RVA: 0x00EC63C8 File Offset: 0x00EC45C8
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603D4D0 RID: 251088 RVA: 0x00EC63D4 File Offset: 0x00EC45D4
		public override void Tick(float delta)
		{
			base.Tick(delta);
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.Tick(delta);
			}
		}

		// Token: 0x0603D4D1 RID: 251089 RVA: 0x00EC642C File Offset: 0x00EC462C
		public override void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.ReplaceFullEffect(niagara);
			}
		}

		// Token: 0x0603D4D2 RID: 251090 RVA: 0x00EC6480 File Offset: 0x00EC4680
		public override void RevertFullEffect()
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.RevertFullEffect();
			}
		}

		// Token: 0x0603D4D3 RID: 251091 RVA: 0x00EC64D0 File Offset: 0x00EC46D0
		public void UpdateFullEffectOffsetBySlotWidth()
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectOffsetX(specialEnergyBarSlotItem.GetRootItem().Width / 2f);
			}
		}

		// Token: 0x0603D4D4 RID: 251092 RVA: 0x00EC6534 File Offset: 0x00EC4734
		public void SetCustomEffectBasePercent(float effectBasePercent)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetEffectBasePercent(effectBasePercent);
			}
		}

		// Token: 0x0603D4D5 RID: 251093 RVA: 0x00EC6588 File Offset: 0x00EC4788
		public void SetFullEffectVisible(int index, bool visible)
		{
			SpecialEnergyBarSlotItem valueOrDefault = this.SlotItemList.GetValueOrDefault(index);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.SetFullEffectVisible(visible);
		}

		// Token: 0x0603D4D6 RID: 251094 RVA: 0x00EC65A4 File Offset: 0x00EC47A4
		public void SetUseEffectMode(EUseEffectMode mode)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetUseEffectMode(mode);
			}
		}

		// Token: 0x0401FF83 RID: 130947
		[StaticVariableRuleIgnore]
		private static readonly float[] effectBasePercents = new float[]
		{
			1f,
			0.4878049f,
			0.31707317f,
			0.2195122f,
			0.17073171f,
			0.14634146f
		};

		// Token: 0x0401FF84 RID: 130948
		protected int SlotNum;

		// Token: 0x0401FF85 RID: 130949
		protected readonly List<SpecialEnergyBarSlotItem> SlotItemList = new List<SpecialEnergyBarSlotItem>();

		// Token: 0x0401FF86 RID: 130950
		public bool IsMorph;

		// Token: 0x0401FF87 RID: 130951
		public bool ForceHideBottomLine;

		// Token: 0x0401FF88 RID: 130952
		public float ForceEffectBasePercent = -1f;

		// Token: 0x0401FF89 RID: 130953
		public bool OverrideColor;
	}
}
