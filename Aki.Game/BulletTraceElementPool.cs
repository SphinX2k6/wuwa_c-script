using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002E1B RID: 11803
[NullableContext(1)]
[Nullable(0)]
public class BulletTraceElementPool : IStaticVariableResetter
{
	// Token: 0x06018D77 RID: 101751 RVA: 0x0065F367 File Offset: 0x0065D567
	static BulletTraceElementPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletTraceElementPool.CreateStaticDefaultValue), new Action(BulletTraceElementPool.ResetStaticDefaultValue));
	}

	// Token: 0x1700227B RID: 8827
	// (get) Token: 0x06018D78 RID: 101752 RVA: 0x0065F386 File Offset: 0x0065D586
	private static List<UTraceBoxElement> TraceBoxElementList
	{
		get
		{
			return BulletTraceElementPool._traceBoxElementList;
		}
	}

	// Token: 0x1700227C RID: 8828
	// (get) Token: 0x06018D79 RID: 101753 RVA: 0x0065F38D File Offset: 0x0065D58D
	private static List<UTraceLineElement> TraceLineElementList
	{
		get
		{
			return BulletTraceElementPool._traceLineElementList;
		}
	}

	// Token: 0x1700227D RID: 8829
	// (get) Token: 0x06018D7A RID: 101754 RVA: 0x0065F394 File Offset: 0x0065D594
	private static List<UTraceSphereElement> TraceSphereElementList
	{
		get
		{
			return BulletTraceElementPool._traceSphereElementList;
		}
	}

	// Token: 0x06018D7B RID: 101755 RVA: 0x0065F39B File Offset: 0x0065D59B
	public static UTraceBoxElement GetTraceBoxElement([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null)
	{
		return BulletTraceElementPool.GetTraceElement<UTraceBoxElement>(BulletTraceElementPool.TraceBoxElementList, traceObjectType, attackerId, ignoreObjectType);
	}

	// Token: 0x06018D7C RID: 101756 RVA: 0x0065F3AA File Offset: 0x0065D5AA
	public static UTraceLineElement GetTraceLineElement([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null)
	{
		return BulletTraceElementPool.GetTraceElement<UTraceLineElement>(BulletTraceElementPool.TraceLineElementList, traceObjectType, attackerId, ignoreObjectType);
	}

	// Token: 0x06018D7D RID: 101757 RVA: 0x0065F3B9 File Offset: 0x0065D5B9
	public static UTraceSphereElement GetTraceSphereElement([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null)
	{
		return BulletTraceElementPool.GetTraceElement<UTraceSphereElement>(BulletTraceElementPool.TraceSphereElementList, traceObjectType, attackerId, ignoreObjectType);
	}

	// Token: 0x06018D7E RID: 101758 RVA: 0x0065F3C8 File Offset: 0x0065D5C8
	private static T GetTraceElement<[Nullable(0)] T>(List<T> elementList, [Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null) where T : UTraceBaseElement, new()
	{
		if (elementList.Count > 0)
		{
			T t = elementList[elementList.Count - 1];
			elementList.RemoveAt(elementList.Count - 1);
			TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
			t.SetObjectTypesQuery(ref tarray);
			int i = 0;
			int num = traceObjectType.Num();
			while (i < num)
			{
				TEnumAsByte<EObjectTypeQuery> value = traceObjectType.Get(i);
				if (ignoreObjectType == null || !ignoreObjectType.Contains(value))
				{
					t.AddObjectTypeQuery(value);
				}
				i++;
			}
			if (Info.Instance.IsBuildDevelopmentOrDebug)
			{
				bool flag = BulletModel.Instance.ShowBulletTrace(attackerId);
				t.SetDrawDebugTrace(flag ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
				if (flag)
				{
					TraceElementCommon.Instance.SetTraceColor(t, ColorUtils.LinearGreen);
					TraceElementCommon.Instance.SetTraceHitColor(t, ColorUtils.LinearRed);
				}
			}
			return t;
		}
		T t2 = BulletTraceElementPool.NewTraceElement<T>(traceObjectType, ignoreObjectType, false);
		if (Info.Instance.IsBuildDevelopmentOrDebug)
		{
			bool flag2 = BulletModel.Instance.ShowBulletTrace(attackerId);
			t2.SetDrawDebugTrace(flag2 ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None);
			if (flag2)
			{
				TraceElementCommon.Instance.SetTraceColor(t2, ColorUtils.LinearGreen);
				TraceElementCommon.Instance.SetTraceHitColor(t2, ColorUtils.LinearRed);
			}
		}
		return t2;
	}

	// Token: 0x06018D7F RID: 101759 RVA: 0x0065F519 File Offset: 0x0065D719
	[NullableContext(2)]
	public static void RecycleTraceBoxElement(UTraceBoxElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			BulletTraceElementPool.TraceBoxElementList.Add(traceElement);
		}
	}

	// Token: 0x06018D80 RID: 101760 RVA: 0x0065F530 File Offset: 0x0065D730
	[NullableContext(2)]
	public static void RecycleTraceLineElement(UTraceLineElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			BulletTraceElementPool.TraceLineElementList.Add(traceElement);
		}
	}

	// Token: 0x06018D81 RID: 101761 RVA: 0x0065F547 File Offset: 0x0065D747
	[NullableContext(2)]
	public static void RecycleTraceSphereElement(UTraceSphereElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			BulletTraceElementPool.TraceSphereElementList.Add(traceElement);
		}
	}

	// Token: 0x06018D82 RID: 101762 RVA: 0x0065F560 File Offset: 0x0065D760
	private static T NewTraceElement<[Nullable(0)] T>([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null, bool bIsSingle = false) where T : UTraceBaseElement, new()
	{
		T t = Activator.CreateInstance<T>();
		t.WorldContextObject = GlobalData.World;
		int i = 0;
		int num = traceObjectType.Num();
		while (i < num)
		{
			TEnumAsByte<EObjectTypeQuery> value = traceObjectType.Get(i);
			if (ignoreObjectType == null || !ignoreObjectType.Contains(value))
			{
				t.AddObjectTypeQuery(value);
			}
			i++;
		}
		t.bTraceComplex = false;
		t.bIgnoreSelf = true;
		t.bIsSingle = bIsSingle;
		return t;
	}

	// Token: 0x06018D83 RID: 101763 RVA: 0x0065F5EC File Offset: 0x0065D7EC
	public static T NewTraceElementByTraceChannel<[Nullable(0)] T>(ETraceTypeQuery traceChannel, bool bIsSingle = false) where T : UTraceBaseElement, new()
	{
		T t = Activator.CreateInstance<T>();
		t.WorldContextObject = GlobalData.World;
		t.SetTraceTypeQuery(traceChannel);
		t.bTraceComplex = false;
		t.bIgnoreSelf = true;
		t.bIsSingle = bIsSingle;
		return t;
	}

	// Token: 0x06018D84 RID: 101764 RVA: 0x0065F63E File Offset: 0x0065D83E
	public static void Clear()
	{
		BulletTraceElementPool.TraceBoxElementList.Clear();
		BulletTraceElementPool.TraceLineElementList.Clear();
		BulletTraceElementPool.TraceSphereElementList.Clear();
	}

	// Token: 0x06018D85 RID: 101765 RVA: 0x0065F65E File Offset: 0x0065D85E
	public static void CreateStaticDefaultValue()
	{
		BulletTraceElementPool._traceBoxElementList = new List<UTraceBoxElement>();
		BulletTraceElementPool._traceLineElementList = new List<UTraceLineElement>();
		BulletTraceElementPool._traceSphereElementList = new List<UTraceSphereElement>();
	}

	// Token: 0x06018D86 RID: 101766 RVA: 0x0065F67E File Offset: 0x0065D87E
	public static void ResetStaticDefaultValue()
	{
		BulletTraceElementPool._traceBoxElementList = null;
		BulletTraceElementPool._traceLineElementList = null;
		BulletTraceElementPool._traceSphereElementList = null;
	}

	// Token: 0x0400BA68 RID: 47720
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceBoxElement> _traceBoxElementList;

	// Token: 0x0400BA69 RID: 47721
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceLineElement> _traceLineElementList;

	// Token: 0x0400BA6A RID: 47722
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceSphereElement> _traceSphereElementList;
}
