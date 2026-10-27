using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DD1 RID: 24017
	public class SpecialEnergyBarChiXia : SpecialEnergyBarPointGraduate
	{
		// Token: 0x0603D092 RID: 250002 RVA: 0x00EADD83 File Offset: 0x00EABF83
		protected override void OnInitData()
		{
			base.OnInitData();
			this.NeedInitSlot = false;
			this.NeedInitNumItem = true;
		}

		// Token: 0x0603D093 RID: 250003 RVA: 0x00EADD99 File Offset: 0x00EABF99
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagAddOrRemoveChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1MaxiaofangMd10011.技能标识.移动射击技能持续"], new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange));
		}

		// Token: 0x0603D094 RID: 250004 RVA: 0x00EADDC4 File Offset: 0x00EABFC4
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

		// Token: 0x0603D095 RID: 250005 RVA: 0x00EADE62 File Offset: 0x00EAC062
		protected override void OnStart()
		{
			base.OnStart();
			this.GraduateItemList[0].SetUIActive(false);
		}

		// Token: 0x0603D096 RID: 250006 RVA: 0x00EADE7C File Offset: 0x00EAC07C
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

		// Token: 0x0401FCCA RID: 130250
		private const int GRADUATE_ENERGY_NUM = 30;
	}
}
