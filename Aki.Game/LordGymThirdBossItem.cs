using System;
using System.Collections.Generic;
using UnrealEngine;

// Token: 0x020021B5 RID: 8629
public class LordGymThirdBossItem : LordGymLordEntranceItem
{
	// Token: 0x06010CA7 RID: 68775 RVA: 0x00413FAC File Offset: 0x004121AC
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(4, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(7, typeof(UUISprite)));
	}

	// Token: 0x06010CA8 RID: 68776 RVA: 0x0041402C File Offset: 0x0041222C
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

	// Token: 0x020086F4 RID: 34548
	private class EComponent
	{
		// Token: 0x0402BE6F RID: 179823
		public const int ItemToggle = 3;

		// Token: 0x0402BE70 RID: 179824
		public const int NewItem = 4;

		// Token: 0x0402BE71 RID: 179825
		public const int NormalItem = 5;

		// Token: 0x0402BE72 RID: 179826
		public const int NoneItem = 6;

		// Token: 0x0402BE73 RID: 179827
		public const int BossIconSprite = 7;
	}
}
