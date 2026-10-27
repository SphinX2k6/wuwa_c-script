using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001FC1 RID: 8129
[NullableContext(1)]
[Nullable(0)]
public static class PhantomStackUtil
{
	// Token: 0x0600FE42 RID: 65090 RVA: 0x003DB58E File Offset: 0x003D978E
	public static int GetUnitCount(int selectedCount)
	{
		if (selectedCount <= 0)
		{
			return 1;
		}
		return selectedCount;
	}

	// Token: 0x0600FE43 RID: 65091 RVA: 0x003DB597 File Offset: 0x003D9797
	public static int GetUnitCount(ISelectedData data)
	{
		return PhantomStackUtil.GetUnitCount(data.SelectedCount);
	}

	// Token: 0x0600FE44 RID: 65092 RVA: 0x003DB5A4 File Offset: 0x003D97A4
	public static bool IsUpdateInfoRemoved(PhantomItem updateInfo)
	{
		return updateInfo.StackCount == 0;
	}

	// Token: 0x0600FE45 RID: 65093 RVA: 0x003DB5B0 File Offset: 0x003D97B0
	public static int GetSelectedUnitCount([Nullable(new byte[]
	{
		2,
		1
	})] List<ISelectedData> dataList)
	{
		if (dataList == null)
		{
			return 0;
		}
		int num = 0;
		foreach (ISelectedData data in dataList)
		{
			num += PhantomStackUtil.GetUnitCount(data);
		}
		return num;
	}

	// Token: 0x0600FE46 RID: 65094 RVA: 0x003DB608 File Offset: 0x003D9808
	public static int GetStackUnitCount(int stackCount)
	{
		if (stackCount <= 1)
		{
			return 1;
		}
		return stackCount;
	}

	// Token: 0x0600FE47 RID: 65095 RVA: 0x003DB611 File Offset: 0x003D9811
	public static bool IsStackedPhantom(int incId)
	{
		if (incId > 0)
		{
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
			return ((phantomItemData != null) ? phantomItemData.GetStackCount() : 0) > 1;
		}
		return false;
	}

	// Token: 0x0600FE48 RID: 65096 RVA: 0x003DB634 File Offset: 0x003D9834
	[NullableContext(2)]
	public static bool CanStackWithSameSpec(PhantomDataBase battleData)
	{
		if (battleData == null)
		{
			return false;
		}
		int incrId = battleData.GetIncrId();
		return InventoryModel.Instance.GetPhantomItemData(incrId) != null && battleData.GetVisionNoCultivated() && !PhantomBattleModel.Instance.CheckPhantomIsEquip(incrId);
	}

	// Token: 0x0600FE49 RID: 65097 RVA: 0x003DB674 File Offset: 0x003D9874
	[NullableContext(2)]
	public static int GetStackUnitCount(PhantomItemData itemData)
	{
		return PhantomStackUtil.GetStackUnitCount((itemData != null) ? itemData.GetStackCount() : 0);
	}

	// Token: 0x0600FE4A RID: 65098 RVA: 0x003DB688 File Offset: 0x003D9888
	public static int GetStackUnitCountByIncIdList(List<int> incIdList)
	{
		int num = 0;
		foreach (int uniqueId in incIdList)
		{
			num += PhantomStackUtil.GetStackUnitCount(InventoryModel.Instance.GetPhantomItemData(uniqueId));
		}
		return num;
	}

	// Token: 0x0600FE4B RID: 65099 RVA: 0x003DB6E8 File Offset: 0x003D98E8
	public static int GetStackUnitCountByDataList(List<PhantomItemData> dataList)
	{
		int num = 0;
		foreach (PhantomItemData itemData in dataList)
		{
			num += PhantomStackUtil.GetStackUnitCount(itemData);
		}
		return num;
	}

	// Token: 0x0600FE4C RID: 65100 RVA: 0x003DB73C File Offset: 0x003D993C
	public static string GetEchoStackBadgeSpritePath(EMediumItemGridEchoStackType type)
	{
		string resourceId = (type == EMediumItemGridEchoStackType.Extract) ? "SP_IconEchoExtract" : "SP_IconEchoStack";
		return UiResourceConfig.Instance.GetResourcePath(resourceId);
	}

	// Token: 0x0600FE4D RID: 65101 RVA: 0x003DB765 File Offset: 0x003D9965
	public static string GetEchoStackBadgeCountText(int count)
	{
		if (count <= 999)
		{
			return count.ToString();
		}
		return "999+";
	}

	// Token: 0x0600FE4E RID: 65102 RVA: 0x003DB77C File Offset: 0x003D997C
	public static string GetStackBottomText(int stackCount, int selectedCount, bool alwaysShowSelected = false)
	{
		if (selectedCount > 0 || alwaysShowSelected)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=#");
			defaultInterpolatedStringHandler.AppendFormatted("fcdd42ff");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(selectedCount);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(stackCount);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return stackCount.ToString();
	}

	// Token: 0x040075A8 RID: 30120
	private const int BadgeMaxDisplayCount = 999;

	// Token: 0x040075A9 RID: 30121
	public const string EchoGridBgResourceId = "SP_QualityFrmAEcho";

	// Token: 0x040075AA RID: 30122
	public const string NormalGridBgResourceId = "SP_QualityFrmA";

	// Token: 0x040075AB RID: 30123
	private const string StackSelectedCountColor = "fcdd42ff";
}
