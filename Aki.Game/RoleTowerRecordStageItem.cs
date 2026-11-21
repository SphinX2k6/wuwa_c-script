using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D06 RID: 7430
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRecordStageItem : GridProxyAbstract<RoleTowerStageRecordData>
{
	// Token: 0x06012647 RID: 75335 RVA: 0x0056F140 File Offset: 0x0056D340
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06012648 RID: 75336 RVA: 0x0056F220 File Offset: 0x0056D420
	protected override void OnStart()
	{
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(3);
		bool flag;
		if (horizontalLayout == null)
		{
			flag = (null != null);
		}
		else
		{
			UUIItem uuiitem = horizontalLayout.RootUIComp.Get();
			flag = (((uuiitem != null) ? uuiitem.GetAttachUIChild(0) : null) != null);
		}
		if (flag)
		{
			this.RoleLayout = new GenericLayout<RoleTowerRecordRoleItem, int>(horizontalLayout, () => new RoleTowerRecordRoleItem(), null, false, true);
		}
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(5);
		bool flag2;
		if (verticalLayout == null)
		{
			flag2 = (null != null);
		}
		else
		{
			UUIItem uuiitem2 = verticalLayout.RootUIComp.Get();
			flag2 = (((uuiitem2 != null) ? uuiitem2.GetAttachUIChild(0) : null) != null);
		}
		if (flag2)
		{
			this.FloorLayout = new GenericLayout<RoleTowerRecordFloorItem, RoleTowerFloorRecordData>(verticalLayout, () => new RoleTowerRecordFloorItem(), null, false, true);
		}
	}

	// Token: 0x06012649 RID: 75337 RVA: 0x0056F2E0 File Offset: 0x0056D4E0
	public override void Refresh(RoleTowerStageRecordData data, bool isSelected, int gridIndex)
	{
		RoleTowerStage? stageCfg = RoleTowerModel.Instance.GetStageCfg(data.StageId);
		bool flag = stageCfg != null;
		this.RefreshStageIcon(flag ? stageCfg.Value.RoleTowerStageIcon : null);
		if (flag && !string.IsNullOrEmpty(stageCfg.Value.RoleTowerStageName))
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.ShowTextNew(stageCfg.Value.RoleTowerStageName);
			}
		}
		else
		{
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText("", true);
			}
		}
		UUIText text3 = base.GetText(2);
		if (data.IsPassed)
		{
			if (text3 != null)
			{
				text3.SetText(RoleTowerTimeUtil.Format(data.RemainTimeMs), true);
			}
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(text3, "RoleTowerRecordNotPassed", Array.Empty<object>());
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(data.IsPassed);
		}
		UUIItem item2 = base.GetItem(8);
		if (item2 != null)
		{
			item2.SetUIActive(!data.IsPassed);
		}
		List<int> list = new List<int>(data.RoleIds);
		if (list.Count == 0)
		{
			list.AddRange(new int[3]);
		}
		GenericLayout<RoleTowerRecordRoleItem, int> roleLayout = this.RoleLayout;
		if (roleLayout != null)
		{
			roleLayout.RefreshByData(list, null, false);
		}
		GenericLayout<RoleTowerRecordFloorItem, RoleTowerFloorRecordData> floorLayout = this.FloorLayout;
		if (floorLayout == null)
		{
			return;
		}
		floorLayout.RefreshByData(new List<RoleTowerFloorRecordData>(data.FloorRecords), null, false);
	}

	// Token: 0x0601264A RID: 75338 RVA: 0x0056F438 File Offset: 0x0056D638
	[NullableContext(2)]
	private void RefreshStageIcon(string iconPath)
	{
		UUISprite sprite = base.GetSprite(0);
		if (sprite == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(iconPath))
		{
			sprite.SetUIActive(false);
			return;
		}
		sprite.SetUIActive(true);
		this.SetSpriteByPath(iconPath, sprite, false, null, null);
	}

	// Token: 0x0601264B RID: 75339 RVA: 0x0056F47B File Offset: 0x0056D67B
	public override object GetKey(RoleTowerStageRecordData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x0400A043 RID: 41027
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerRecordRoleItem, int> RoleLayout;

	// Token: 0x0400A044 RID: 41028
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerRecordFloorItem, RoleTowerFloorRecordData> FloorLayout;

	// Token: 0x02008033 RID: 32819
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297B8 RID: 169912
		public const int SprNumIcon = 0;

		// Token: 0x040297B9 RID: 169913
		public const int TxtRoundTitle = 1;

		// Token: 0x040297BA RID: 169914
		public const int TxtRemainTimeValue = 2;

		// Token: 0x040297BB RID: 169915
		public const int PnlRoleItemLayout = 3;

		// Token: 0x040297BC RID: 169916
		public const int PnlRoleItem = 4;

		// Token: 0x040297BD RID: 169917
		public const int PnlChildItemInfo = 5;

		// Token: 0x040297BE RID: 169918
		public const int UiItemMonsterBattleTime = 6;

		// Token: 0x040297BF RID: 169919
		public const int PnlPassTime = 7;

		// Token: 0x040297C0 RID: 169920
		public const int PnlNotPassed = 8;
	}
}
