using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001494 RID: 5268
[NullableContext(1)]
[Nullable(0)]
public static class PhantomStackUtil
{
	// Token: 0x0600D2AA RID: 53930 RVA: 0x003E7B6A File Offset: 0x003E5D6A
	public static int GetUnitCount(int selectedCount)
	{
		if (selectedCount <= 0)
		{
			return 1;
		}
		return selectedCount;
	}

	// Token: 0x0600D2AB RID: 53931 RVA: 0x003E7B73 File Offset: 0x003E5D73
	public static int GetUnitCount(ISelectedData data)
	{
		return PhantomStackUtil.GetUnitCount(data.SelectedCount);
	}

	// Token: 0x0600D2AC RID: 53932 RVA: 0x003E7B80 File Offset: 0x003E5D80
	public static bool IsUpdateInfoRemoved(PhantomItem updateInfo)
	{
		return updateInfo.StackCount == 0;
	}

	// Token: 0x0600D2AD RID: 53933 RVA: 0x003E7B8C File Offset: 0x003E5D8C
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

	// Token: 0x0600D2AE RID: 53934 RVA: 0x003E7BE4 File Offset: 0x003E5DE4
	public static int GetStackUnitCount(int stackCount)
	{
		if (stackCount <= 1)
		{
			return 1;
		}
		return stackCount;
	}

	// Token: 0x0600D2AF RID: 53935 RVA: 0x003E7BED File Offset: 0x003E5DED
	public static bool IsStackedPhantom(int incId)
	{
		if (incId > 0)
		{
			PhantomItemData phantomItemData = InventoryModel.Instance.GetPhantomItemData(incId);
			return ((phantomItemData != null) ? phantomItemData.GetStackCount() : 0) > 1;
		}
		return false;
	}

	// Token: 0x0600D2B0 RID: 53936 RVA: 0x003E7C10 File Offset: 0x003E5E10
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

	// Token: 0x0600D2B1 RID: 53937 RVA: 0x003E7C50 File Offset: 0x003E5E50
	[NullableContext(2)]
	public static int GetStackUnitCount(PhantomItemData itemData)
	{
		return PhantomStackUtil.GetStackUnitCount((itemData != null) ? itemData.GetStackCount() : 0);
	}

	// Token: 0x0600D2B2 RID: 53938 RVA: 0x003E7C64 File Offset: 0x003E5E64
	public static int GetStackUnitCountByIncIdList(List<int> incIdList)
	{
		int num = 0;
		foreach (int uniqueId in incIdList)
		{
			num += PhantomStackUtil.GetStackUnitCount(InventoryModel.Instance.GetPhantomItemData(uniqueId));
		}
		return num;
	}

	// Token: 0x0600D2B3 RID: 53939 RVA: 0x003E7CC4 File Offset: 0x003E5EC4
	public static int GetStackUnitCountByDataList(List<PhantomItemData> dataList)
	{
		int num = 0;
		foreach (PhantomItemData itemData in dataList)
		{
			num += PhantomStackUtil.GetStackUnitCount(itemData);
		}
		return num;
	}

	// Token: 0x0600D2B4 RID: 53940 RVA: 0x003E7D18 File Offset: 0x003E5F18
	public static string GetEchoStackBadgeSpritePath(EMediumItemGridEchoStackType type)
	{
		string resourceId = (type == EMediumItemGridEchoStackType.Extract) ? "SP_IconEchoExtract" : "SP_IconEchoStack";
		return UiResourceConfig.Instance.GetResourcePath(resourceId);
	}

	// Token: 0x0600D2B5 RID: 53941 RVA: 0x003E7D41 File Offset: 0x003E5F41
	public static string GetEchoStackBadgeCountText(int count)
	{
		if (count <= 999)
		{
			return count.ToString();
		}
		return "999+";
	}

	// Token: 0x0600D2B6 RID: 53942 RVA: 0x003E7D58 File Offset: 0x003E5F58
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

	// Token: 0x04007691 RID: 30353
	private const int BadgeMaxDisplayCount = 999;

	// Token: 0x04007692 RID: 30354
	public const string EchoGridBgResourceId = "SP_QualityFrmAEcho";

	// Token: 0x04007693 RID: 30355
	public const string NormalGridBgResourceId = "SP_QualityFrmA";

	// Token: 0x04007694 RID: 30356
	private const string StackSelectedCountColor = "fcdd42ff";
}
