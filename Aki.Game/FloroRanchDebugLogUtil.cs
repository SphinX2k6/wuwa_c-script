using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02000FEB RID: 4075
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDebugLogUtil
{
	// Token: 0x0600A2A5 RID: 41637 RVA: 0x002FC2F6 File Offset: 0x002FA4F6
	public static void LogDayStart()
	{
	}

	// Token: 0x0600A2A6 RID: 41638 RVA: 0x002FC2F8 File Offset: 0x002FA4F8
	public static void LogBuffActionInfo(FloroRanchEntityBase casterEntity, FloroRanchEntityBase targetEntity, FRUnitOperateBuffAction buff)
	{
	}

	// Token: 0x0600A2A7 RID: 41639 RVA: 0x002FC305 File Offset: 0x002FA505
	public static void LogEatActionInfo(FloroRanchEntityBase casterEntity, FloroRanchEntityBase targetEntity)
	{
	}

	// Token: 0x0600A2A8 RID: 41640 RVA: 0x002FC308 File Offset: 0x002FA508
	public static void LogEvolveActionInfo(FloroRanchEntityBase targetEntity, FloroRanchCardDataComponent cardDataComponent)
	{
	}

	// Token: 0x0600A2A9 RID: 41641 RVA: 0x002FC318 File Offset: 0x002FA518
	public static void LogTagActionInfo(FloroRanchEntityBase casterEntity, FRDebugActionInfo tagAction)
	{
	}

	// Token: 0x0600A2AA RID: 41642 RVA: 0x002FC328 File Offset: 0x002FA528
	public static void LogFusionStartActionInfo(FloroRanchEntityBase casterEntity, FRMixAction fusionActionData)
	{
	}

	// Token: 0x0600A2AB RID: 41643 RVA: 0x002FC338 File Offset: 0x002FA538
	public static void LogFusionEndActionInfo(FRMixAction fusionActionData)
	{
	}

	// Token: 0x0600A2AC RID: 41644 RVA: 0x002FC348 File Offset: 0x002FA548
	public static void LogResourceChangeActionInfo(FloroRanchEntityBase casterEntity, FRUnitResourcesChangeAction changeData)
	{
	}

	// Token: 0x0600A2AD RID: 41645 RVA: 0x002FC358 File Offset: 0x002FA558
	public static void LogWageSettleActionInfo(FRUnitResourcesChangeAction changeData)
	{
	}

	// Token: 0x0600A2AE RID: 41646 RVA: 0x002FC365 File Offset: 0x002FA565
	private static string GetCurrencyDebugName(FRUnitResourcesChangeType type)
	{
		return "";
	}

	// Token: 0x0600A2AF RID: 41647 RVA: 0x002FC36C File Offset: 0x002FA56C
	public static void LogToyLevelUpActionInfo(FloroRanchEntityBase entity, int lastLevel, int newLevel)
	{
	}

	// Token: 0x0600A2B0 RID: 41648 RVA: 0x002FC37C File Offset: 0x002FA57C
	public static void LogStageTributeChangeActionInfo(long newTarget)
	{
	}

	// Token: 0x0600A2B1 RID: 41649 RVA: 0x002FC38C File Offset: 0x002FA58C
	public static void LogSelfDefineValueActionInfo(FloroRanchEntityBase entity, int n, int m, int p)
	{
	}

	// Token: 0x0600A2B2 RID: 41650 RVA: 0x002FC399 File Offset: 0x002FA599
	public static void LogSacrificeActionInfo(FloroRanchEntityBase casterEntity)
	{
	}

	// Token: 0x0600A2B3 RID: 41651 RVA: 0x002FC39C File Offset: 0x002FA59C
	public static void LogEntityChangeActionInfo(FloroRanchEntityBase casterEntity, FRUnitOperate opType, FloroRanchPlayUnit changeData)
	{
	}

	// Token: 0x0600A2B4 RID: 41652 RVA: 0x002FC3A9 File Offset: 0x002FA5A9
	private static string GetEntityChangeTypeDebugName(FRUnitOperate opType)
	{
		return "";
	}

	// Token: 0x0600A2B5 RID: 41653 RVA: 0x002FC3B0 File Offset: 0x002FA5B0
	private static void Log(string info)
	{
	}
}
