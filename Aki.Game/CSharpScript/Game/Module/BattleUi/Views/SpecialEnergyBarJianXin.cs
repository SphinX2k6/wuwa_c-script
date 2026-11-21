using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DC1 RID: 19905
	public class SpecialEnergyBarJianXin : SpecialEnergyBarPointGraduate
	{
		// Token: 0x060320B8 RID: 204984 RVA: 0x00E02F19 File Offset: 0x00E01119
		protected override void AddEvents()
		{
			base.AddEvents();
			base.ListenForTagCountChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1JianxinMd10011.技能ID.重击.攻"], new BaseTagComponent.TTagChangedCallback(this.OnTagCountChange));
		}

		// Token: 0x060320B9 RID: 204985 RVA: 0x00E02F42 File Offset: 0x00E01142
		private void OnTagCountChange(int count, int tagId, int exactTagId, int oldCount)
		{
			if (count > 0)
			{
				this.SlotItem.PlayUseEffectWithPercent(this.EffectPercent);
			}
		}

		// Token: 0x060320BA RID: 204986 RVA: 0x00E02F5C File Offset: 0x00E0115C
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float num = this.PercentMachine.GetCurPercent();
			if (this.PercentMachine.GetTargetPercent() == 1f)
			{
				num = 1f;
			}
			this.IsKeyEnable = (num >= this.Config.DisableKeyOnPercent);
			bool flag = true;
			bool flag2 = false;
			if (!isStart)
			{
				if (num > this.LastPercent)
				{
					flag2 = (num >= 1f);
					flag = !flag2;
				}
				else if (num < this.LastPercent)
				{
					flag2 = (num <= 0f);
					flag = flag2;
				}
			}
			else
			{
				flag = (num < 1f);
			}
			this.SlotItem.UpdatePercentWithVisible(num, flag, flag2, isStart, (flag2 && flag) ? 0f : this.LastPercent);
			this.PointItem.UpdatePercentWithVisible(num, !flag, flag2, isStart);
			if (flag2 || isStart)
			{
				foreach (UUIItem uuiitem in this.GraduateItemList)
				{
					uuiitem.SetUIActive(!flag);
				}
			}
			SpecialEnergyBarKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.RefreshKeyEnable(this.IsKeyEnable, isStart);
			}
			if (num == 0f)
			{
				this.EffectPercent = this.LastPercent;
			}
			this.LastPercent = num;
		}

		// Token: 0x0401A7F1 RID: 108529
		private float EffectPercent;
	}
}
