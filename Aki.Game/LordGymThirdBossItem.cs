using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x02001699 RID: 5785
public class LordGymThirdBossItem : LordGymLordEntranceItem
{
	// Token: 0x0600E138 RID: 57656 RVA: 0x0042088C File Offset: 0x0041EA8C
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUISprite)));
	}

	// Token: 0x0600E139 RID: 57657 RVA: 0x0042090C File Offset: 0x0041EB0C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		if (data != 0)
		{
			UUIItem item = base.GetItem(6);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			List<int> lordGymEntranceWithNewTag = LordGymModel.Instance.GetLordGymEntranceWithNewTag();
			UUIItem item3 = base.GetItem(4);
			if (item3 != null)
			{
				item3.SetUIActive(lordGymEntranceWithNewTag.Contains(data));
			}
			this.SetSpriteByPath(StringUtils.Format("/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity30/LordGym/SP_BossTogBgDecoration{0}.SP_BossTogBgDecoration{1}", new string[]
			{
				data.ToString(),
				data.ToString()
			}), base.GetSprite(7), true, null, null);
			base.Refresh(data, isSelected, gridIndex);
			return;
		}
		UUIItem item4 = base.GetItem(6);
		if (item4 != null)
		{
			item4.SetUIActive(true);
		}
		UUIItem item5 = base.GetItem(5);
		if (item5 != null)
		{
			item5.SetUIActive(false);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, false, false);
	}

	// Token: 0x0200787F RID: 30847
	private class EComponent
	{
		// Token: 0x04027190 RID: 160144
		public const int ItemToggle = 3;

		// Token: 0x04027191 RID: 160145
		public const int NewItem = 4;

		// Token: 0x04027192 RID: 160146
		public const int NormalItem = 5;

		// Token: 0x04027193 RID: 160147
		public const int NoneItem = 6;

		// Token: 0x04027194 RID: 160148
		public const int BossIconSprite = 7;
	}
}
