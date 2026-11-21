using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002637 RID: 9783
[NullableContext(1)]
[Nullable(0)]
public class LockOnDebug : IStaticVariableResetter
{
	// Token: 0x060186C8 RID: 100040 RVA: 0x00760253 File Offset: 0x0075E453
	static LockOnDebug()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LockOnDebug.CreateStaticDefaultValue), new Action(LockOnDebug.ResetStaticDefaultValue));
	}

	// Token: 0x1700265C RID: 9820
	// (get) Token: 0x060186C9 RID: 100041 RVA: 0x00760272 File Offset: 0x0075E472
	private static Dictionary<LockOnInfo, LockOnDebugData> LockOnDataMap
	{
		get
		{
			return LockOnDebug._lockOnDataMap;
		}
	}

	// Token: 0x060186CA RID: 100042 RVA: 0x00760279 File Offset: 0x0075E479
	public static void Clear()
	{
		LockOnDebug.LockOnDataMap.Clear();
	}

	// Token: 0x060186CB RID: 100043 RVA: 0x00760288 File Offset: 0x0075E488
	public static void Push(LockOnInfo info)
	{
		if (!LockOnDebug.IsShowDebugLine)
		{
			return;
		}
		LockOnDebugData value = new LockOnDebugData(info);
		LockOnDebug.LockOnDataMap[info] = value;
	}

	// Token: 0x060186CC RID: 100044 RVA: 0x007602B0 File Offset: 0x0075E4B0
	public static void SetDebugString(LockOnInfo info, float angle, float distance, Vector moveDir, [Nullable(2)] Vector actualDir)
	{
		if (!LockOnDebug.IsShowDebugLine)
		{
			return;
		}
		LockOnDebugData lockOnDebugData;
		if (LockOnDebug.LockOnDataMap.TryGetValue(info, out lockOnDebugData))
		{
			lockOnDebugData.ShowTip = string.Concat(new string[]
			{
				"角度：",
				LockOnDebug.FormatNumber((double)angle),
				"\n距离：",
				LockOnDebug.FormatNumber((double)distance),
				"\n移动方向：",
				LockOnDebug.FormatVector(moveDir)
			});
			if (actualDir != null)
			{
				LockOnDebugData lockOnDebugData2 = lockOnDebugData;
				lockOnDebugData2.ShowTip = lockOnDebugData2.ShowTip + "\n实际方向：" + LockOnDebug.FormatVector(actualDir);
			}
		}
	}

	// Token: 0x060186CD RID: 100045 RVA: 0x0076033C File Offset: 0x0075E53C
	public static void SetDebugArrow(LockOnInfo info, EColorType colorType)
	{
		if (!LockOnDebug.IsShowDebugLine)
		{
			return;
		}
		LockOnDebugData lockOnDebugData;
		if (LockOnDebug.LockOnDataMap.TryGetValue(info, out lockOnDebugData))
		{
			lockOnDebugData.ColorType = colorType;
		}
	}

	// Token: 0x060186CE RID: 100046 RVA: 0x00760367 File Offset: 0x0075E567
	private static string FormatNumber(double value)
	{
		return value.ToString("F2");
	}

	// Token: 0x060186CF RID: 100047 RVA: 0x00760378 File Offset: 0x0075E578
	private static string FormatVector(Vector vec)
	{
		return string.Concat(new string[]
		{
			"X=",
			LockOnDebug.FormatNumber(vec.X),
			", Y=",
			LockOnDebug.FormatNumber(vec.Y),
			", Z=",
			LockOnDebug.FormatNumber(vec.Z)
		});
	}

	// Token: 0x060186D0 RID: 100048 RVA: 0x007603D4 File Offset: 0x0075E5D4
	public static void Tick(Entity me)
	{
		if (!LockOnDebug.IsShowDebugLine)
		{
			return;
		}
		List<LockOnInfo> list = new List<LockOnInfo>();
		foreach (KeyValuePair<LockOnInfo, LockOnDebugData> keyValuePair in LockOnDebug.LockOnDataMap)
		{
			LockOnInfo lockOnInfo;
			LockOnDebugData lockOnDebugData;
			keyValuePair.Deconstruct(out lockOnInfo, out lockOnDebugData);
			LockOnInfo lockOnInfo2 = lockOnInfo;
			LockOnDebugData lockOnDebugData2 = lockOnDebugData;
			EntityHandle entityHandle = lockOnInfo2.EntityHandle;
			if (entityHandle == null || !entityHandle.Valid)
			{
				list.Add(lockOnInfo2);
			}
			else
			{
				lockOnDebugData2.DrawDebug(me);
			}
		}
		foreach (LockOnInfo key in list)
		{
			LockOnDebug.LockOnDataMap.Remove(key);
		}
	}

	// Token: 0x060186D1 RID: 100049 RVA: 0x007604AC File Offset: 0x0075E6AC
	public static void CreateStaticDefaultValue()
	{
		LockOnDebug.IsShowDebugLine = false;
		LockOnDebug._lockOnDataMap = new Dictionary<LockOnInfo, LockOnDebugData>();
	}

	// Token: 0x060186D2 RID: 100050 RVA: 0x007604BE File Offset: 0x0075E6BE
	public static void ResetStaticDefaultValue()
	{
		LockOnDebug.IsShowDebugLine = false;
		LockOnDebug._lockOnDataMap = null;
	}

	// Token: 0x0400D2DF RID: 53983
	public const float ARROW_SIZE = 15f;

	// Token: 0x0400D2E0 RID: 53984
	public const double DEBUG_TEXT_FALLBACK_Z_OFFSET = 120.0;

	// Token: 0x0400D2E1 RID: 53985
	public const double DEBUG_TEXT_EXTRA_Z_OFFSET = 50.0;

	// Token: 0x0400D2E2 RID: 53986
	public static bool IsShowDebugLine;

	// Token: 0x0400D2E3 RID: 53987
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<LockOnInfo, LockOnDebugData> _lockOnDataMap;
}
