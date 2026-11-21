using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x02002A9F RID: 10911
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TraceElementModel : ModelBase
{
	// Token: 0x0601BBBD RID: 113597 RVA: 0x0088A99C File Offset: 0x00888B9C
	protected override bool OnClear()
	{
		if (this.SpecificTraceTypeElement != null)
		{
			foreach (UTraceBaseElement utraceBaseElement in this.SpecificTraceTypeElement.Values)
			{
				utraceBaseElement.Dispose();
			}
			this.SpecificTraceTypeElement.Clear();
			this.SpecificTraceTypeElement = null;
		}
		if (this.ActorTrace != null)
		{
			this.ActorTrace.Dispose();
			this.ActorTrace = null;
		}
		if (this.BoxTrace != null)
		{
			this.BoxTrace.Dispose();
			this.BoxTrace = null;
		}
		if (this.CapsuleTrace != null)
		{
			this.CapsuleTrace.Dispose();
			this.CapsuleTrace = null;
		}
		return true;
	}

	// Token: 0x0601BBBE RID: 113598 RVA: 0x0088AA5C File Offset: 0x00888C5C
	[NullableContext(2)]
	[Obsolete]
	public UTraceSphereElement GetActorTrace()
	{
		if (this.ActorTrace == null)
		{
			this.InitActorTraceInternal();
		}
		return this.ActorTrace;
	}

	// Token: 0x0601BBBF RID: 113599 RVA: 0x0088AA72 File Offset: 0x00888C72
	[Obsolete]
	public void ClearActorTrace()
	{
		if (this.ActorTrace != null)
		{
			this.ActorTrace.WorldContextObject = null;
			this.ActorTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601BBC0 RID: 113600 RVA: 0x0088AA9C File Offset: 0x00888C9C
	private void InitActorTraceInternal()
	{
		UTraceSphereElement utraceSphereElement = new UTraceSphereElement();
		utraceSphereElement.bIsSingle = false;
		utraceSphereElement.bIgnoreSelf = true;
		utraceSphereElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		TraceElementCommon.Instance.SetTraceColor(utraceSphereElement, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(utraceSphereElement, ColorUtils.LinearRed);
		this.ActorTrace = utraceSphereElement;
	}

	// Token: 0x0601BBC1 RID: 113601 RVA: 0x0088AAEF File Offset: 0x00888CEF
	[NullableContext(2)]
	[Obsolete]
	public UTraceLineElement GetLineTrace()
	{
		if (this.LineTrace == null)
		{
			this.InitLineTraceInternal();
		}
		return this.LineTrace;
	}

	// Token: 0x0601BBC2 RID: 113602 RVA: 0x0088AB05 File Offset: 0x00888D05
	[Obsolete]
	public void ClearLineTrace()
	{
		if (this.LineTrace != null)
		{
			this.LineTrace.WorldContextObject = null;
			this.LineTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601BBC3 RID: 113603 RVA: 0x0088AB2C File Offset: 0x00888D2C
	private void InitLineTraceInternal()
	{
		UTraceLineElement utraceLineElement = new UTraceLineElement();
		utraceLineElement.bIsSingle = true;
		utraceLineElement.bIgnoreSelf = true;
		utraceLineElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		TraceElementCommon.Instance.SetTraceColor(utraceLineElement, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(utraceLineElement, ColorUtils.LinearRed);
		this.LineTrace = utraceLineElement;
	}

	// Token: 0x0601BBC4 RID: 113604 RVA: 0x0088AB7F File Offset: 0x00888D7F
	[NullableContext(2)]
	[Obsolete]
	public UTraceBoxElement GetBoxTrace()
	{
		if (this.BoxTrace == null)
		{
			this.InitBoxTraceInternal();
		}
		return this.BoxTrace;
	}

	// Token: 0x0601BBC5 RID: 113605 RVA: 0x0088AB95 File Offset: 0x00888D95
	[Obsolete]
	public void ClearBoxTrace()
	{
		if (this.BoxTrace != null)
		{
			this.BoxTrace.WorldContextObject = null;
			this.BoxTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601BBC6 RID: 113606 RVA: 0x0088ABBC File Offset: 0x00888DBC
	private void InitBoxTraceInternal()
	{
		UTraceBoxElement utraceBoxElement = new UTraceBoxElement();
		utraceBoxElement.bIsSingle = true;
		utraceBoxElement.bIgnoreSelf = true;
		utraceBoxElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		TraceElementCommon.Instance.SetTraceColor(utraceBoxElement, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(utraceBoxElement, ColorUtils.LinearRed);
		this.BoxTrace = utraceBoxElement;
	}

	// Token: 0x0601BBC7 RID: 113607 RVA: 0x0088AC0F File Offset: 0x00888E0F
	[NullableContext(2)]
	[Obsolete]
	public UTraceCapsuleElement GetCapsuleTrace()
	{
		if (this.CapsuleTrace == null)
		{
			this.InitCapsuleTraceInternal();
		}
		return this.CapsuleTrace;
	}

	// Token: 0x0601BBC8 RID: 113608 RVA: 0x0088AC25 File Offset: 0x00888E25
	[Obsolete]
	public void ClearCapsuleTrace()
	{
		if (this.CapsuleTrace != null)
		{
			this.CapsuleTrace.WorldContextObject = null;
			this.CapsuleTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601BBC9 RID: 113609 RVA: 0x0088AC4C File Offset: 0x00888E4C
	private void InitCapsuleTraceInternal()
	{
		UTraceCapsuleElement utraceCapsuleElement = new UTraceCapsuleElement();
		utraceCapsuleElement.bIsSingle = true;
		utraceCapsuleElement.bIgnoreSelf = true;
		utraceCapsuleElement.SetTraceTypeQuery(KuroTraceTypeQuery.IkGround);
		TraceElementCommon.Instance.SetTraceColor(utraceCapsuleElement, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(utraceCapsuleElement, ColorUtils.LinearRed);
		this.CapsuleTrace = utraceCapsuleElement;
	}

	// Token: 0x0601BBCA RID: 113610 RVA: 0x0088ACA0 File Offset: 0x00888EA0
	private T GetElement<[Nullable(0)] T>(UObject worldContextObject, bool isSingle, bool ignoreSelf) where T : UTraceBaseElement, IUnrealUObject
	{
		if (this.SpecificTraceTypeElement == null)
		{
			this.SpecificTraceTypeElement = new Dictionary<Type, UTraceBaseElement>();
		}
		Type typeFromHandle = typeof(T);
		if (!this.SpecificTraceTypeElement.ContainsKey(typeFromHandle))
		{
			T t = UE.NewObject<T>(null, null, EObjectFlags.RF_NoFlags);
			TraceElementCommon.Instance.SetTraceColor(t, ColorUtils.LinearGreen);
			TraceElementCommon.Instance.SetTraceHitColor(t, ColorUtils.LinearRed);
			this.SpecificTraceTypeElement[typeFromHandle] = t;
		}
		T t2 = (T)((object)this.SpecificTraceTypeElement[typeFromHandle]);
		t2.ClearCacheData(true);
		t2.ActorsToIgnore.Empty(true);
		t2.bIsSingle = isSingle;
		t2.bIgnoreSelf = ignoreSelf;
		t2.WorldContextObject = worldContextObject;
		if (this.ShowDebugTrace)
		{
			t2.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
		}
		return t2;
	}

	// Token: 0x0601BBCB RID: 113611 RVA: 0x0088AD86 File Offset: 0x00888F86
	public T GetTraceTypeElement<[Nullable(0)] T>(ETraceTypeQuery traceTypeQuery, UObject worldContextObject, bool isSingle = true, bool ignoreSelf = true) where T : UTraceBaseElement, IUnrealUObject
	{
		T element = this.GetElement<T>(worldContextObject, isSingle, ignoreSelf);
		element.SetTraceTypeQuery(traceTypeQuery);
		return element;
	}

	// Token: 0x0601BBCC RID: 113612 RVA: 0x0088ADA0 File Offset: 0x00888FA0
	public T GetObjectTypeElement<[Nullable(0)] T>(EObjectTypeQuery[] objectTypeQueries, UObject worldContextObject, bool isSingle = true, bool ignoreSelf = true) where T : UTraceBaseElement, IUnrealUObject
	{
		T element = this.GetElement<T>(worldContextObject, isSingle, ignoreSelf);
		TArray<TEnumAsByte<EObjectTypeQuery>> tarray = new TArray<TEnumAsByte<EObjectTypeQuery>>();
		foreach (EObjectTypeQuery value in objectTypeQueries)
		{
			tarray.Add(value);
		}
		element.SetObjectTypesQuery(ref tarray);
		return element;
	}

	// Token: 0x0601BBCD RID: 113613 RVA: 0x0088ADEE File Offset: 0x00888FEE
	public T GetObjectTypeElement<[Nullable(0)] T>(EObjectTypeQuery objectTypeQuery, UObject worldContextObject, bool isSingle = true, bool ignoreSelf = true) where T : UTraceBaseElement, IUnrealUObject
	{
		return this.GetObjectTypeElement<T>(new EObjectTypeQuery[]
		{
			objectTypeQuery
		}, worldContextObject, isSingle, ignoreSelf);
	}

	// Token: 0x17002CF7 RID: 11511
	// (get) Token: 0x0601BBCE RID: 113614 RVA: 0x0088AE04 File Offset: 0x00889004
	public static TraceElementModel Instance
	{
		get
		{
			return TraceElementModel._Instance;
		}
	}

	// Token: 0x0601BBCF RID: 113615 RVA: 0x0088AE0B File Offset: 0x0088900B
	public static TraceElementModel GetOrCreateInstance()
	{
		if (TraceElementModel._Instance == null)
		{
			TraceElementModel.CreateInstance();
		}
		return TraceElementModel._Instance;
	}

	// Token: 0x0601BBD0 RID: 113616 RVA: 0x0088AE1F File Offset: 0x0088901F
	public static bool CreateInstance()
	{
		if (TraceElementModel._Instance != null)
		{
			return true;
		}
		TraceElementModel._Instance = new TraceElementModel();
		return true;
	}

	// Token: 0x0601BBD1 RID: 113617 RVA: 0x0088AE35 File Offset: 0x00889035
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601BBD2 RID: 113618 RVA: 0x0088AE37 File Offset: 0x00889037
	public static void ResetStaticDefaultValue()
	{
		TraceElementModel._Instance = null;
	}

	// Token: 0x0601BBD3 RID: 113619 RVA: 0x0088AE3F File Offset: 0x0088903F
	static TraceElementModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TraceElementModel.CreateStaticDefaultValue), new Action(TraceElementModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EF9E RID: 61342
	[Nullable(2)]
	private UTraceSphereElement ActorTrace;

	// Token: 0x0400EF9F RID: 61343
	[Nullable(2)]
	private UTraceLineElement LineTrace;

	// Token: 0x0400EFA0 RID: 61344
	public Vector CommonStartLocation = Vector.Create();

	// Token: 0x0400EFA1 RID: 61345
	public Vector CommonEndLocation = Vector.Create();

	// Token: 0x0400EFA2 RID: 61346
	public Vector CommonHitLocation = Vector.Create();

	// Token: 0x0400EFA3 RID: 61347
	[Nullable(2)]
	private UTraceBoxElement BoxTrace;

	// Token: 0x0400EFA4 RID: 61348
	[Nullable(2)]
	private UTraceCapsuleElement CapsuleTrace;

	// Token: 0x0400EFA5 RID: 61349
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<Type, UTraceBaseElement> SpecificTraceTypeElement;

	// Token: 0x0400EFA6 RID: 61350
	public bool ShowDebugTrace;

	// Token: 0x0400EFA7 RID: 61351
	[Nullable(2)]
	private static TraceElementModel _Instance;
}
