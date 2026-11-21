using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002377 RID: 9079
[NullableContext(1)]
[Nullable(0)]
public class BulletTraceElementPool : IStaticVariableResetter
{
	// Token: 0x06016639 RID: 91705 RVA: 0x00685493 File Offset: 0x00683693
	static BulletTraceElementPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletTraceElementPool.CreateStaticDefaultValue), new Action(BulletTraceElementPool.ResetStaticDefaultValue));
	}

	// Token: 0x170022E3 RID: 8931
	// (get) Token: 0x0601663A RID: 91706 RVA: 0x006854B2 File Offset: 0x006836B2
	private static List<UTraceBoxElement> TraceBoxElementList
	{
		get
		{
			return BulletTraceElementPool._traceBoxElementList;
		}
	}

	// Token: 0x170022E4 RID: 8932
	// (get) Token: 0x0601663B RID: 91707 RVA: 0x006854B9 File Offset: 0x006836B9
	private static List<UTraceLineElement> TraceLineElementList
	{
		get
		{
			return BulletTraceElementPool._traceLineElementList;
		}
	}

	// Token: 0x170022E5 RID: 8933
	// (get) Token: 0x0601663C RID: 91708 RVA: 0x006854C0 File Offset: 0x006836C0
	private static List<UTraceSphereElement> TraceSphereElementList
	{
		get
		{
			return BulletTraceElementPool._traceSphereElementList;
		}
	}

	// Token: 0x0601663D RID: 91709 RVA: 0x006854C7 File Offset: 0x006836C7
	public static UTraceBoxElement GetTraceBoxElement([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null)
	{
		return BulletTraceElementPool.GetTraceElement<UTraceBoxElement>(BulletTraceElementPool.TraceBoxElementList, traceObjectType, attackerId, ignoreObjectType);
	}

	// Token: 0x0601663E RID: 91710 RVA: 0x006854D6 File Offset: 0x006836D6
	public static UTraceLineElement GetTraceLineElement([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null)
	{
		return BulletTraceElementPool.GetTraceElement<UTraceLineElement>(BulletTraceElementPool.TraceLineElementList, traceObjectType, attackerId, ignoreObjectType);
	}

	// Token: 0x0601663F RID: 91711 RVA: 0x006854E5 File Offset: 0x006836E5
	public static UTraceSphereElement GetTraceSphereElement([Nullable(new byte[]
	{
		1,
		0
	})] TArray<TEnumAsByte<EObjectTypeQuery>> traceObjectType, int attackerId, [Nullable(2)] HashSet<EObjectTypeQuery> ignoreObjectType = null)
	{
		return BulletTraceElementPool.GetTraceElement<UTraceSphereElement>(BulletTraceElementPool.TraceSphereElementList, traceObjectType, attackerId, ignoreObjectType);
	}

	// Token: 0x06016640 RID: 91712 RVA: 0x006854F4 File Offset: 0x006836F4
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
			return t;
		}
		return BulletTraceElementPool.NewTraceElement<T>(traceObjectType, ignoreObjectType, false);
	}

	// Token: 0x06016641 RID: 91713 RVA: 0x0068558E File Offset: 0x0068378E
	[NullableContext(2)]
	public static void RecycleTraceBoxElement(UTraceBoxElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			BulletTraceElementPool.TraceBoxElementList.Add(traceElement);
		}
	}

	// Token: 0x06016642 RID: 91714 RVA: 0x006855A5 File Offset: 0x006837A5
	[NullableContext(2)]
	public static void RecycleTraceLineElement(UTraceLineElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			BulletTraceElementPool.TraceLineElementList.Add(traceElement);
		}
	}

	// Token: 0x06016643 RID: 91715 RVA: 0x006855BC File Offset: 0x006837BC
	[NullableContext(2)]
	public static void RecycleTraceSphereElement(UTraceSphereElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			BulletTraceElementPool.TraceSphereElementList.Add(traceElement);
		}
	}

	// Token: 0x06016644 RID: 91716 RVA: 0x006855D4 File Offset: 0x006837D4
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

	// Token: 0x06016645 RID: 91717 RVA: 0x00685660 File Offset: 0x00683860
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

	// Token: 0x06016646 RID: 91718 RVA: 0x006856B2 File Offset: 0x006838B2
	public static void Clear()
	{
		BulletTraceElementPool.TraceBoxElementList.Clear();
		BulletTraceElementPool.TraceLineElementList.Clear();
		BulletTraceElementPool.TraceSphereElementList.Clear();
	}

	// Token: 0x06016647 RID: 91719 RVA: 0x006856D2 File Offset: 0x006838D2
	public static void CreateStaticDefaultValue()
	{
		BulletTraceElementPool._traceBoxElementList = new List<UTraceBoxElement>();
		BulletTraceElementPool._traceLineElementList = new List<UTraceLineElement>();
		BulletTraceElementPool._traceSphereElementList = new List<UTraceSphereElement>();
	}

	// Token: 0x06016648 RID: 91720 RVA: 0x006856F2 File Offset: 0x006838F2
	public static void ResetStaticDefaultValue()
	{
		BulletTraceElementPool._traceBoxElementList = null;
		BulletTraceElementPool._traceLineElementList = null;
		BulletTraceElementPool._traceSphereElementList = null;
	}

	// Token: 0x0400BDF6 RID: 48630
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceBoxElement> _traceBoxElementList;

	// Token: 0x0400BDF7 RID: 48631
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceLineElement> _traceLineElementList;

	// Token: 0x0400BDF8 RID: 48632
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceSphereElement> _traceSphereElementList;
}
