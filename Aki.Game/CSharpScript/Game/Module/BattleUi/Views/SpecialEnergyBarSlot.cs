using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E0D RID: 19981
	[NullableContext(1)]
	[Nullable(0)]
	public class SpecialEnergyBarSlot : SpecialEnergyBarBase
	{
		// Token: 0x06032458 RID: 205912 RVA: 0x00E17614 File Offset: 0x00E15814
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

		// Token: 0x06032459 RID: 205913 RVA: 0x00E176A0 File Offset: 0x00E158A0
		protected override UniTask OnBeforeStartAsync()
		{
			SpecialEnergyBarSlot.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpecialEnergyBarSlot.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603245A RID: 205914 RVA: 0x00E176E4 File Offset: 0x00E158E4
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

		// Token: 0x0603245B RID: 205915 RVA: 0x00E17730 File Offset: 0x00E15930
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

		// Token: 0x0603245C RID: 205916 RVA: 0x00E178B8 File Offset: 0x00E15AB8
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

		// Token: 0x0603245D RID: 205917 RVA: 0x00E1791F File Offset: 0x00E15B1F
		protected override void OnBarPercentChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603245E RID: 205918 RVA: 0x00E17928 File Offset: 0x00E15B28
		protected override void OnKeyEnableChanged()
		{
			this.RefreshBarPercent(false);
		}

		// Token: 0x0603245F RID: 205919 RVA: 0x00E17934 File Offset: 0x00E15B34
		public override void Tick(float delta)
		{
			base.Tick(delta);
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.Tick(delta);
			}
		}

		// Token: 0x06032460 RID: 205920 RVA: 0x00E1798C File Offset: 0x00E15B8C
		public override void ReplaceFullEffect(UNiagaraSystem niagara)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.ReplaceFullEffect(niagara);
			}
		}

		// Token: 0x06032461 RID: 205921 RVA: 0x00E179E0 File Offset: 0x00E15BE0
		public override void RevertFullEffect()
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.RevertFullEffect();
			}
		}

		// Token: 0x06032462 RID: 205922 RVA: 0x00E17A30 File Offset: 0x00E15C30
		public void UpdateFullEffectOffsetBySlotWidth()
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetFullEffectOffsetX(specialEnergyBarSlotItem.GetRootItem().Width / 2f);
			}
		}

		// Token: 0x06032463 RID: 205923 RVA: 0x00E17A94 File Offset: 0x00E15C94
		public void SetCustomEffectBasePercent(float effectBasePercent)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetEffectBasePercent(effectBasePercent);
			}
		}

		// Token: 0x06032464 RID: 205924 RVA: 0x00E17AE8 File Offset: 0x00E15CE8
		public void SetFullEffectVisible(int index, bool visible)
		{
			SpecialEnergyBarSlotItem valueOrDefault = this.SlotItemList.GetValueOrDefault(index);
			if (valueOrDefault == null)
			{
				return;
			}
			valueOrDefault.SetFullEffectVisible(visible);
		}

		// Token: 0x06032465 RID: 205925 RVA: 0x00E17B04 File Offset: 0x00E15D04
		public void SetUseEffectMode(EUseEffectMode mode)
		{
			foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
			{
				specialEnergyBarSlotItem.SetUseEffectMode(mode);
			}
		}

		// Token: 0x06032466 RID: 205926 RVA: 0x00E17B58 File Offset: 0x00E15D58
		[NullableContext(2)]
		public UUIItem GetKeyItem()
		{
			return base.GetItem(this.SlotNum);
		}

		// Token: 0x0401AA4A RID: 109130
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

		// Token: 0x0401AA4B RID: 109131
		protected int SlotNum;

		// Token: 0x0401AA4C RID: 109132
		protected readonly List<SpecialEnergyBarSlotItem> SlotItemList = new List<SpecialEnergyBarSlotItem>();

		// Token: 0x0401AA4D RID: 109133
		public bool IsMorph;

		// Token: 0x0401AA4E RID: 109134
		public bool ForceHideBottomLine;

		// Token: 0x0401AA4F RID: 109135
		public float ForceEffectBasePercent = -1f;

		// Token: 0x0401AA50 RID: 109136
		public bool OverrideColor;
	}
}
