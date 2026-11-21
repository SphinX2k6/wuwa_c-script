using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DB5 RID: 19893
	public class SpecialEnergyBarChiXia : SpecialEnergyBarPointGraduate
	{
		// Token: 0x06032009 RID: 204809 RVA: 0x00DFEC77 File Offset: 0x00DFCE77
		protected override void OnInitData()
		{
			base.OnInitData();
			this.NeedInitSlot = false;
			this.NeedInitNumItem = true;
		}

		// Token: 0x0603200A RID: 204810 RVA: 0x00DFEC8D File Offset: 0x00DFCE8D
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1MaxiaofangMd10011.技能标识.移动射击技能持续"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange));
		}

		// Token: 0x0603200B RID: 204811 RVA: 0x00DFECB8 File Offset: 0x00DFCEB8
		private void OnTagChange(int tagId, bool tagExist)
		{
			if (!tagExist)
			{
				this.GraduateItemList[0].SetUIActive(false);
				return;
			}
			float num = this.AttributeComponent.GetCurrentValue((EAttributeType)this.Config.AttributeId) - 30f;
			float currentValue = this.AttributeComponent.GetCurrentValue((EAttributeType)this.Config.MaxAttributeId);
			float num2 = 0f;
			if (currentValue > 0f)
			{
				num2 = num / currentValue;
			}
			if (num2 >= 0f)
			{
				base.SetGraduateItemOffset(0, num2);
				this.GraduateItemList[0].SetUIActive(true);
				return;
			}
			this.GraduateItemList[0].SetUIActive(false);
		}

		// Token: 0x0603200C RID: 204812 RVA: 0x00DFED56 File Offset: 0x00DFCF56
		protected override void OnStart()
		{
			base.OnStart();
			this.GraduateItemList[0].SetUIActive(false);
		}

		// Token: 0x0603200D RID: 204813 RVA: 0x00DFED70 File Offset: 0x00DFCF70
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.PointItem.UpdatePercent(curPercent, true, 0);
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(curPercent >= this.Config.DisableKeyOnPercent, isStart);
			}
			int num = (int)this.AttributeComponent.GetCurrentValue((EAttributeType)this.Config.AttributeId);
			SpecialEnergyBarNumItem numItem = this.NumItem;
			if (numItem == null)
			{
				return;
			}
			numItem.SetNum(num);
		}

		// Token: 0x0401A787 RID: 108423
		private const int GRADUATE_ENERGY_NUM = 30;
	}
}
