using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001B2C RID: 6956
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDebugLogUtil
{
	// Token: 0x0600CE94 RID: 52884 RVA: 0x002F1216 File Offset: 0x002EF416
	public static void LogDayStart()
	{
	}

	// Token: 0x0600CE95 RID: 52885 RVA: 0x002F1218 File Offset: 0x002EF418
	public static void LogBuffActionInfo(FloroRanchEntityBase casterEntity, FloroRanchEntityBase targetEntity, FRUnitOperateBuffAction buff)
	{
	}

	// Token: 0x0600CE96 RID: 52886 RVA: 0x002F1225 File Offset: 0x002EF425
	public static void LogEatActionInfo(FloroRanchEntityBase casterEntity, FloroRanchEntityBase targetEntity)
	{
	}

	// Token: 0x0600CE97 RID: 52887 RVA: 0x002F1228 File Offset: 0x002EF428
	public static void LogEvolveActionInfo(FloroRanchEntityBase targetEntity, FloroRanchCardDataComponent cardDataComponent)
	{
	}

	// Token: 0x0600CE98 RID: 52888 RVA: 0x002F1238 File Offset: 0x002EF438
	public static void LogTagActionInfo(FloroRanchEntityBase casterEntity, FRDebugActionInfo tagAction)
	{
	}

	// Token: 0x0600CE99 RID: 52889 RVA: 0x002F1248 File Offset: 0x002EF448
	public static void LogFusionStartActionInfo(FloroRanchEntityBase casterEntity, FRMixAction fusionActionData)
	{
	}

	// Token: 0x0600CE9A RID: 52890 RVA: 0x002F1258 File Offset: 0x002EF458
	public static void LogFusionEndActionInfo(FRMixAction fusionActionData)
	{
	}

	// Token: 0x0600CE9B RID: 52891 RVA: 0x002F1268 File Offset: 0x002EF468
	public static void LogResourceChangeActionInfo(FloroRanchEntityBase casterEntity, FRUnitResourcesChangeAction changeData)
	{
	}

	// Token: 0x0600CE9C RID: 52892 RVA: 0x002F1278 File Offset: 0x002EF478
	public static void LogWageSettleActionInfo(FRUnitResourcesChangeAction changeData)
	{
	}

	// Token: 0x0600CE9D RID: 52893 RVA: 0x002F1285 File Offset: 0x002EF485
	private static string GetCurrencyDebugName(FRUnitResourcesChangeType type)
	{
		return "";
	}

	// Token: 0x0600CE9E RID: 52894 RVA: 0x002F128C File Offset: 0x002EF48C
	public static void LogToyLevelUpActionInfo(FloroRanchEntityBase entity, int lastLevel, int newLevel)
	{
	}

	// Token: 0x0600CE9F RID: 52895 RVA: 0x002F129C File Offset: 0x002EF49C
	public static void LogStageTributeChangeActionInfo(long newTarget)
	{
	}

	// Token: 0x0600CEA0 RID: 52896 RVA: 0x002F12AC File Offset: 0x002EF4AC
	public static void LogSelfDefineValueActionInfo(FloroRanchEntityBase entity, int n, int m, int p)
	{
	}

	// Token: 0x0600CEA1 RID: 52897 RVA: 0x002F12B9 File Offset: 0x002EF4B9
	public static void LogSacrificeActionInfo(FloroRanchEntityBase casterEntity)
	{
	}

	// Token: 0x0600CEA2 RID: 52898 RVA: 0x002F12BC File Offset: 0x002EF4BC
	public static void LogEntityChangeActionInfo(FloroRanchEntityBase casterEntity, FRUnitOperate opType, FloroRanchPlayUnit changeData)
	{
	}

	// Token: 0x0600CEA3 RID: 52899 RVA: 0x002F12C9 File Offset: 0x002EF4C9
	private static string GetEntityChangeTypeDebugName(FRUnitOperate opType)
	{
		return "";
	}

	// Token: 0x0600CEA4 RID: 52900 RVA: 0x002F12D0 File Offset: 0x002EF4D0
	private static void Log(string info)
	{
	}
}
