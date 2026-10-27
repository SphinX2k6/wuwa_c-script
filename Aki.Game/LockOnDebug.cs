using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020030DF RID: 12511
[NullableContext(1)]
[Nullable(0)]
public class LockOnDebug : IStaticVariableResetter
{
	// Token: 0x0601ACAC RID: 109740 RVA: 0x0073A817 File Offset: 0x00738A17
	static LockOnDebug()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LockOnDebug.CreateStaticDefaultValue), new Action(LockOnDebug.ResetStaticDefaultValue));
	}

	// Token: 0x170024D2 RID: 9426
	// (get) Token: 0x0601ACAD RID: 109741 RVA: 0x0073A836 File Offset: 0x00738A36
	private static Dictionary<LockOnInfo, LockOnDebugData> LockOnDataMap
	{
		get
		{
			return LockOnDebug._lockOnDataMap;
		}
	}

	// Token: 0x0601ACAE RID: 109742 RVA: 0x0073A83D File Offset: 0x00738A3D
	public static void Clear()
	{
		LockOnDebug.LockOnDataMap.Clear();
	}

	// Token: 0x0601ACAF RID: 109743 RVA: 0x0073A84C File Offset: 0x00738A4C
	public static void Push(LockOnInfo info)
	{
		if (!LockOnDebug.IsShowDebugLine)
		{
			return;
		}
		LockOnDebugData value = new LockOnDebugData(info);
		LockOnDebug.LockOnDataMap[info] = value;
	}

	// Token: 0x0601ACB0 RID: 109744 RVA: 0x0073A874 File Offset: 0x00738A74
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

	// Token: 0x0601ACB1 RID: 109745 RVA: 0x0073A900 File Offset: 0x00738B00
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

	// Token: 0x0601ACB2 RID: 109746 RVA: 0x0073A92B File Offset: 0x00738B2B
	private static string FormatNumber(double value)
	{
		return value.ToString("F2");
	}

	// Token: 0x0601ACB3 RID: 109747 RVA: 0x0073A93C File Offset: 0x00738B3C
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

	// Token: 0x0601ACB4 RID: 109748 RVA: 0x0073A998 File Offset: 0x00738B98
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

	// Token: 0x0601ACB5 RID: 109749 RVA: 0x0073AA70 File Offset: 0x00738C70
	public static void CreateStaticDefaultValue()
	{
		LockOnDebug.IsShowDebugLine = false;
		LockOnDebug._lockOnDataMap = new Dictionary<LockOnInfo, LockOnDebugData>();
	}

	// Token: 0x0601ACB6 RID: 109750 RVA: 0x0073AA82 File Offset: 0x00738C82
	public static void ResetStaticDefaultValue()
	{
		LockOnDebug.IsShowDebugLine = false;
		LockOnDebug._lockOnDataMap = null;
	}

	// Token: 0x0400CEEF RID: 52975
	public const float ARROW_SIZE = 15f;

	// Token: 0x0400CEF0 RID: 52976
	public const double DEBUG_TEXT_FALLBACK_Z_OFFSET = 120.0;

	// Token: 0x0400CEF1 RID: 52977
	public const double DEBUG_TEXT_EXTRA_Z_OFFSET = 50.0;

	// Token: 0x0400CEF2 RID: 52978
	public static bool IsShowDebugLine;

	// Token: 0x0400CEF3 RID: 52979
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<LockOnInfo, LockOnDebugData> _lockOnDataMap;
}
