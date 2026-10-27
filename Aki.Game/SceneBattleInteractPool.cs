using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002946 RID: 10566
[NullableContext(1)]
[Nullable(0)]
public class SceneBattleInteractPool : IStaticVariableResetter
{
	// Token: 0x06015D31 RID: 89393 RVA: 0x00580974 File Offset: 0x0057EB74
	static SceneBattleInteractPool()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SceneBattleInteractPool.CreateStaticDefaultValue), new Action(SceneBattleInteractPool.ResetStaticDefaultValue));
	}

	// Token: 0x06015D32 RID: 89394 RVA: 0x00580993 File Offset: 0x0057EB93
	public static void CreateStaticDefaultValue()
	{
		SceneBattleInteractPool.TraceCapsuleElementList = new List<UTraceCapsuleElement>();
		SceneBattleInteractPool.TraceLineElementList = new List<UTraceLineElement>();
		SceneBattleInteractPool.TraceSphereElementList = new List<UTraceSphereElement>();
	}

	// Token: 0x06015D33 RID: 89395 RVA: 0x005809B3 File Offset: 0x0057EBB3
	public static void ResetStaticDefaultValue()
	{
		SceneBattleInteractPool.TraceCapsuleElementList = null;
		SceneBattleInteractPool.TraceLineElementList = null;
		SceneBattleInteractPool.TraceSphereElementList = null;
	}

	// Token: 0x06015D34 RID: 89396 RVA: 0x005809C7 File Offset: 0x0057EBC7
	public static UTraceCapsuleElement GetTraceCapsuleElement(ETraceTypeQuery traceChannel)
	{
		return SceneBattleInteractPool.GetTraceElement<UTraceCapsuleElement>(UTraceCapsuleElement.StaticClass().ToClass(), SceneBattleInteractPool.TraceCapsuleElementList, traceChannel, false);
	}

	// Token: 0x06015D35 RID: 89397 RVA: 0x005809DF File Offset: 0x0057EBDF
	public static UTraceLineElement GetTraceLineElement(ETraceTypeQuery traceChannel)
	{
		return SceneBattleInteractPool.GetTraceElement<UTraceLineElement>(UTraceLineElement.StaticClass().ToClass(), SceneBattleInteractPool.TraceLineElementList, traceChannel, false);
	}

	// Token: 0x06015D36 RID: 89398 RVA: 0x005809F7 File Offset: 0x0057EBF7
	public static UTraceSphereElement GetTraceSphereElement(ETraceTypeQuery traceChannel)
	{
		return SceneBattleInteractPool.GetTraceElement<UTraceSphereElement>(UTraceSphereElement.StaticClass().ToClass(), SceneBattleInteractPool.TraceSphereElementList, traceChannel, false);
	}

	// Token: 0x06015D37 RID: 89399 RVA: 0x00580A10 File Offset: 0x0057EC10
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

	// Token: 0x06015D38 RID: 89400 RVA: 0x00580A9E File Offset: 0x0057EC9E
	[NullableContext(2)]
	public static void RecycleTraceCapsuleElement(UTraceCapsuleElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			SceneBattleInteractPool.TraceCapsuleElementList.Add(traceElement);
		}
	}

	// Token: 0x06015D39 RID: 89401 RVA: 0x00580AB5 File Offset: 0x0057ECB5
	[NullableContext(2)]
	public static void RecycleTraceLineElement(UTraceLineElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			SceneBattleInteractPool.TraceLineElementList.Add(traceElement);
		}
	}

	// Token: 0x06015D3A RID: 89402 RVA: 0x00580ACC File Offset: 0x0057ECCC
	[NullableContext(2)]
	public static void RecycleTraceSphereElement(UTraceSphereElement traceElement)
	{
		if (traceElement != null)
		{
			traceElement.ClearCacheData(false);
			SceneBattleInteractPool.TraceSphereElementList.Add(traceElement);
		}
	}

	// Token: 0x06015D3B RID: 89403 RVA: 0x00580AE3 File Offset: 0x0057ECE3
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

	// Token: 0x0400A276 RID: 41590
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceCapsuleElement> TraceCapsuleElementList;

	// Token: 0x0400A277 RID: 41591
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceLineElement> TraceLineElementList;

	// Token: 0x0400A278 RID: 41592
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<UTraceSphereElement> TraceSphereElementList;
}
