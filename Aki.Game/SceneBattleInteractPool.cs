using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02001EC1 RID: 7873
[NullableContext(1)]
[Nullable(0)]
public class SceneBattleInteractPool : IStaticVariableResetter
{
	// Token: 0x06013735 RID: 79669 RVA: 0x005AB974 File Offset: 0x005A9B74
	static SceneBattleInteractPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneBattleInteractPool.CreateStaticDefaultValue), new Action(SceneBattleInteractPool.ResetStaticDefaultValue));
	}

	// Token: 0x06013736 RID: 79670 RVA: 0x005AB993 File Offset: 0x005A9B93
	public static void CreateStaticDefaultValue()
	{
		SceneBattleInteractPool.TraceCapsuleElementList = new List<UTraceCapsuleElement>();
		SceneBattleInteractPool.TraceLineElementList = new List<UTraceLineElement>();
		SceneBattleInteractPool.TraceSphereElementList = new List<UTraceSphereElement>();
	}

	// Token: 0x06013737 RID: 79671 RVA: 0x005AB9B3 File Offset: 0x005A9BB3
	public static void ResetStaticDefaultValue()
	{
		SceneBattleInteractPool.TraceCapsuleElementList = null;
		SceneBattleInteractPool.TraceLineElementList = null;
		SceneBattleInteractPool.TraceSphereElementList = null;
	}

	// Token: 0x06013738 RID: 79672 RVA: 0x005AB9C7 File Offset: 0x005A9BC7
	public static UTraceCapsuleElement GetTraceCapsuleElement(ETraceTypeQuery traceChannel)
	{
		return SceneBattleInteractPool.GetTraceElement<UTraceCapsuleElement>(UTraceCapsuleElement.StaticClass().ToClass(), SceneBattleInteractPool.TraceCapsuleElementList, traceChannel, false);
	}

	// Token: 0x06013739 RID: 79673 RVA: 0x005AB9DF File Offset: 0x005A9BDF
	public static UTraceLineElement GetTraceLineElement(ETraceTypeQuery traceChannel)
	{
		return SceneBattleInteractPool.GetTraceElement<UTraceLineElement>(UTraceLineElement.StaticClass().ToClass(), SceneBattleInteractPool.TraceLineElementList, traceChannel, false);
	}

	// Token: 0x0601373A RID: 79674 RVA: 0x005AB9F7 File Offset: 0x005A9BF7
	public static UTraceSphereElement GetTraceSphereElement(ETraceTypeQuery traceChannel)
	{
		return SceneBattleInteractPool.GetTraceElement<UTraceSphereElement>(UTraceSphereElement.StaticClass().ToClass(), SceneBattleInteractPool.TraceSphereElementList, traceChannel, false);
	}

	// Token: 0x0601373B RID: 79675 RVA: 0x005ABA10 File Offset: 0x005A9C10
	private static T GetTraceElement<[Nullable(0)] T>(UClass type, List<T> elementList, ETraceTypeQuery traceChannel, bool bIsSingle = false) where T : UTraceBaseElement
	{
		if (elementList.Count > 0)
		{
			int index = elementList.Count - 1;
			T t = elementList[index];
			elementList.RemoveAt(index);
			t.SetTraceTypeQuery(traceChannel);
			t.bIsSingle = bIsSingle;
			return t;
		}
		T t2 = UE.NewObject<T>(type, null, EObjectFlags.RF_NoFlags);
		t2.WorldContextObject = GlobalData.World;
		t2.SetTraceTypeQuery(traceChannel);
		t2.bTraceComplex = false;
		t2.bIgnoreSelf = true;
		t2.bIsSingle = bIsSingle;
		return t2;
	}

	// Token: 0x0601373C RID: 79676 RVA: 0x005ABA9E File Offset: 0x005A9C9E
	[NullableContext(2)]
	public static void RecycleTraceCapsuleElement(UTraceCapsuleElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			SceneBattleInteractPool.TraceCapsuleElementList.Add(traceElement);
		}
	}

	// Token: 0x0601373D RID: 79677 RVA: 0x005ABAB5 File Offset: 0x005A9CB5
	[NullableContext(2)]
	public static void RecycleTraceLineElement(UTraceLineElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			SceneBattleInteractPool.TraceLineElementList.Add(traceElement);
		}
	}

	// Token: 0x0601373E RID: 79678 RVA: 0x005ABACC File Offset: 0x005A9CCC
	[NullableContext(2)]
	public static void RecycleTraceSphereElement(UTraceSphereElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			SceneBattleInteractPool.TraceSphereElementList.Add(traceElement);
		}
	}

	// Token: 0x0601373F RID: 79679 RVA: 0x005ABAE3 File Offset: 0x005A9CE3
	public static void Clear()
	{
		List<UTraceCapsuleElement> traceCapsuleElementList = SceneBattleInteractPool.TraceCapsuleElementList;
		if (traceCapsuleElementList != null)
		{
			traceCapsuleElementList.Clear();
		}
		List<UTraceLineElement> traceLineElementList = SceneBattleInteractPool.TraceLineElementList;
		if (traceLineElementList != null)
		{
			traceLineElementList.Clear();
		}
		List<UTraceSphereElement> traceSphereElementList = SceneBattleInteractPool.TraceSphereElementList;
		if (traceSphereElementList == null)
		{
			return;
		}
		traceSphereElementList.Clear();
	}

	// Token: 0x0400A660 RID: 42592
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceCapsuleElement> TraceCapsuleElementList;

	// Token: 0x0400A661 RID: 42593
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceLineElement> TraceLineElementList;

	// Token: 0x0400A662 RID: 42594
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceSphereElement> TraceSphereElementList;
}
