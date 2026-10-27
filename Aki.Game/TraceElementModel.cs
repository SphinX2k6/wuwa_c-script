using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;
using UnrealEngine.Interface;

// Token: 0x0200352A RID: 13610
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class TraceElementModel : ModelBase
{
	// Token: 0x0601DE95 RID: 122517 RVA: 0x00862D64 File Offset: 0x00860F64
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

	// Token: 0x0601DE96 RID: 122518 RVA: 0x00862E24 File Offset: 0x00861024
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

	// Token: 0x0601DE97 RID: 122519 RVA: 0x00862E3A File Offset: 0x0086103A
	[Obsolete]
	public void ClearActorTrace()
	{
		if (this.ActorTrace != null)
		{
			this.ActorTrace.WorldContextObject = null;
			this.ActorTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601DE98 RID: 122520 RVA: 0x00862E64 File Offset: 0x00861064
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

	// Token: 0x0601DE99 RID: 122521 RVA: 0x00862EB7 File Offset: 0x008610B7
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

	// Token: 0x0601DE9A RID: 122522 RVA: 0x00862ECD File Offset: 0x008610CD
	[Obsolete]
	public void ClearLineTrace()
	{
		if (this.LineTrace != null)
		{
			this.LineTrace.WorldContextObject = null;
			this.LineTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601DE9B RID: 122523 RVA: 0x00862EF4 File Offset: 0x008610F4
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

	// Token: 0x0601DE9C RID: 122524 RVA: 0x00862F47 File Offset: 0x00861147
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

	// Token: 0x0601DE9D RID: 122525 RVA: 0x00862F5D File Offset: 0x0086115D
	[Obsolete]
	public void ClearBoxTrace()
	{
		if (this.BoxTrace != null)
		{
			this.BoxTrace.WorldContextObject = null;
			this.BoxTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601DE9E RID: 122526 RVA: 0x00862F84 File Offset: 0x00861184
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

	// Token: 0x0601DE9F RID: 122527 RVA: 0x00862FD7 File Offset: 0x008611D7
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

	// Token: 0x0601DEA0 RID: 122528 RVA: 0x00862FED File Offset: 0x008611ED
	[Obsolete]
	public void ClearCapsuleTrace()
	{
		if (this.CapsuleTrace != null)
		{
			this.CapsuleTrace.WorldContextObject = null;
			this.CapsuleTrace.ActorsToIgnore.Empty(true);
		}
	}

	// Token: 0x0601DEA1 RID: 122529 RVA: 0x00863014 File Offset: 0x00861214
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

	// Token: 0x0601DEA2 RID: 122530 RVA: 0x00863068 File Offset: 0x00861268
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

	// Token: 0x0601DEA3 RID: 122531 RVA: 0x0086314E File Offset: 0x0086134E
	public T GetTraceTypeElement<[Nullable(0)] T>(ETraceTypeQuery traceTypeQuery, UObject worldContextObject, bool isSingle = true, bool ignoreSelf = true) where T : UTraceBaseElement, IUnrealUObject
	{
		T element = this.GetElement<T>(worldContextObject, isSingle, ignoreSelf);
		element.SetTraceTypeQuery(traceTypeQuery);
		return element;
	}

	// Token: 0x0601DEA4 RID: 122532 RVA: 0x00863168 File Offset: 0x00861368
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

	// Token: 0x0601DEA5 RID: 122533 RVA: 0x008631B6 File Offset: 0x008613B6
	public T GetObjectTypeElement<[Nullable(0)] T>(EObjectTypeQuery objectTypeQuery, UObject worldContextObject, bool isSingle = true, bool ignoreSelf = true) where T : UTraceBaseElement, IUnrealUObject
	{
		return this.GetObjectTypeElement<T>(new EObjectTypeQuery[]
		{
			objectTypeQuery
		}, worldContextObject, isSingle, ignoreSelf);
	}

	// Token: 0x1700295E RID: 10590
	// (get) Token: 0x0601DEA6 RID: 122534 RVA: 0x008631CC File Offset: 0x008613CC
	public static TraceElementModel Instance
	{
		get
		{
			return TraceElementModel._Instance;
		}
	}

	// Token: 0x0601DEA7 RID: 122535 RVA: 0x008631D3 File Offset: 0x008613D3
	public static TraceElementModel GetOrCreateInstance()
	{
		if (TraceElementModel._Instance == null)
		{
			TraceElementModel.CreateInstance();
		}
		return TraceElementModel._Instance;
	}

	// Token: 0x0601DEA8 RID: 122536 RVA: 0x008631E7 File Offset: 0x008613E7
	public static bool CreateInstance()
	{
		if (TraceElementModel._Instance != null)
		{
			return true;
		}
		TraceElementModel._Instance = new TraceElementModel();
		return true;
	}

	// Token: 0x0601DEA9 RID: 122537 RVA: 0x008631FD File Offset: 0x008613FD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601DEAA RID: 122538 RVA: 0x008631FF File Offset: 0x008613FF
	public static void ResetStaticDefaultValue()
	{
		TraceElementModel._Instance = null;
	}

	// Token: 0x0601DEAB RID: 122539 RVA: 0x00863207 File Offset: 0x00861407
	static TraceElementModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TraceElementModel.CreateStaticDefaultValue), new Action(TraceElementModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400EAE1 RID: 60129
	[Nullable(2)]
	private UTraceSphereElement ActorTrace;

	// Token: 0x0400EAE2 RID: 60130
	[Nullable(2)]
	private UTraceLineElement LineTrace;

	// Token: 0x0400EAE3 RID: 60131
	public Vector CommonStartLocation = Vector.Create();

	// Token: 0x0400EAE4 RID: 60132
	public Vector CommonEndLocation = Vector.Create();

	// Token: 0x0400EAE5 RID: 60133
	public Vector CommonHitLocation = Vector.Create();

	// Token: 0x0400EAE6 RID: 60134
	[Nullable(2)]
	private UTraceBoxElement BoxTrace;

	// Token: 0x0400EAE7 RID: 60135
	[Nullable(2)]
	private UTraceCapsuleElement CapsuleTrace;

	// Token: 0x0400EAE8 RID: 60136
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<Type, UTraceBaseElement> SpecificTraceTypeElement;

	// Token: 0x0400EAE9 RID: 60137
	public bool ShowDebugTrace;

	// Token: 0x0400EAEA RID: 60138
	[Nullable(2)]
	private static TraceElementModel _Instance;
}
