using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000108 RID: 264
[NullableContext(1)]
[Nullable(0)]
public class TraceElementCommon : Singleton
{
	// Token: 0x060009D4 RID: 2516 RVA: 0x0003248B File Offset: 0x0003068B
	public bool LineTrace(UTraceLineElement element, string profileKey)
	{
		return UKuroTraceLibrary.LineTrace(element, profileKey);
	}

	// Token: 0x060009D5 RID: 2517 RVA: 0x00032494 File Offset: 0x00030694
	public bool BoxTrace(UTraceBoxElement element, string profileKey)
	{
		return UKuroTraceLibrary.BoxTrace(element, profileKey);
	}

	// Token: 0x060009D6 RID: 2518 RVA: 0x0003249D File Offset: 0x0003069D
	public bool CapsuleTrace(UTraceCapsuleElement element, string profileKey)
	{
		return UKuroTraceLibrary.CapsuleTrace(element, profileKey);
	}

	// Token: 0x060009D7 RID: 2519 RVA: 0x000324A6 File Offset: 0x000306A6
	public bool SphereTrace(UTraceSphereElement element, string profileKey)
	{
		return UKuroTraceLibrary.SphereTrace(element, profileKey);
	}

	// Token: 0x060009D8 RID: 2520 RVA: 0x000324B0 File Offset: 0x000306B0
	public bool ShapeTrace([Nullable(2)] UShapeComponent inShapeComp, UTraceBaseElement element, string traceTagName, string profileKey)
	{
		FName value = FNameUtil.GetDynamicFName(traceTagName).Value;
		return UKuroTraceLibrary.ShapeTrace(inShapeComp, element, value, profileKey);
	}

	// Token: 0x060009D9 RID: 2521 RVA: 0x000324D8 File Offset: 0x000306D8
	public TraceHandle AsyncLineTrace(UTraceLineElement element, string profileKey, FAsyncTraceDelegate @delegate)
	{
		if (Time.Instance.Frame != this.LineTraceFrame)
		{
			this.LineTraceIndex = 0;
		}
		else
		{
			this.LineTraceIndex++;
		}
		this.LineTraceFrame = Time.Instance.Frame;
		TraceHandle result = new TraceHandle(this.LineTraceFrame, this.LineTraceIndex);
		UKuroTraceLibrary.AsyncLineTrace(element, profileKey, @delegate, (double)this.LineTraceFrame, (double)this.LineTraceIndex);
		return result;
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00032548 File Offset: 0x00030748
	public TraceHandle AsyncBoxTrace(UTraceBoxElement element, string profileKey, FAsyncTraceDelegate @delegate)
	{
		if (Time.Instance.Frame > this.BoxTraceFrame)
		{
			this.BoxTraceIndex = 0;
		}
		else
		{
			this.BoxTraceIndex++;
		}
		this.BoxTraceFrame = Time.Instance.Frame;
		TraceHandle result = new TraceHandle(this.BoxTraceFrame, this.BoxTraceIndex);
		UKuroTraceLibrary.AsyncBoxTrace(element, profileKey, @delegate, (double)this.BoxTraceFrame, (double)this.BoxTraceIndex);
		return result;
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x000325B8 File Offset: 0x000307B8
	public TraceHandle AsyncCapsuleTrace(UTraceCapsuleElement element, string profileKey, FAsyncTraceDelegate @delegate)
	{
		if (Time.Instance.Frame > this.CapsuleTraceFrame)
		{
			this.CapsuleTraceIndex = 0;
		}
		else
		{
			this.CapsuleTraceIndex++;
		}
		this.CapsuleTraceFrame = Time.Instance.Frame;
		TraceHandle result = new TraceHandle(this.CapsuleTraceFrame, this.CapsuleTraceIndex);
		UKuroTraceLibrary.AsyncCapsuleTrace(element, profileKey, @delegate, (double)this.CapsuleTraceFrame, (double)this.CapsuleTraceIndex);
		return result;
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00032628 File Offset: 0x00030828
	public TraceHandle AsyncSphereTrace(UTraceSphereElement element, string profileKey, FAsyncTraceDelegate @delegate)
	{
		if (Time.Instance.Frame > this.SphereTraceFrame)
		{
			this.SphereTraceIndex = 0;
		}
		else
		{
			this.SphereTraceIndex++;
		}
		this.SphereTraceFrame = Time.Instance.Frame;
		TraceHandle result = new TraceHandle(this.SphereTraceFrame, this.SphereTraceIndex);
		UKuroTraceLibrary.AsyncSphereTrace(element, profileKey, @delegate, (double)this.SphereTraceFrame, (double)this.SphereTraceIndex);
		return result;
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00032696 File Offset: 0x00030896
	public void SetStartLocation(UTraceBaseElement element, IVector location)
	{
		element.SetStartLocation(location.X, location.Y, location.Z);
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x000326B0 File Offset: 0x000308B0
	public void SetEndLocation(UTraceBaseElement element, IVector location)
	{
		element.SetEndLocation(location.X, location.Y, location.Z);
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x000326CA File Offset: 0x000308CA
	public void SetTraceColor(UTraceBaseElement element, FLinearColor color)
	{
		element.SetTraceColor(color.R, color.G, color.B, color.A);
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x000326EA File Offset: 0x000308EA
	public void SetTraceHitColor(UTraceBaseElement element, FLinearColor color)
	{
		element.SetTraceHitColor(color.R, color.G, color.B, color.A);
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x0003270A File Offset: 0x0003090A
	public void SetBoxHalfSize(UTraceBoxElement boxElement, IVector size)
	{
		boxElement.SetBoxHalfSize((float)size.X, (float)size.Y, (float)size.Z);
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00032727 File Offset: 0x00030927
	public void SetBoxOrientation(UTraceBoxElement boxElement, IRotator rotator)
	{
		boxElement.SetBoxOrientation(rotator.Pitch, rotator.Yaw, rotator.Roll);
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00032741 File Offset: 0x00030941
	public void SetCapsuleOrientation(UTraceCapsuleElement capsuleElement, IRotator rotator)
	{
		capsuleElement.SetCapsuleOrientation(rotator.Pitch, rotator.Yaw, rotator.Roll);
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x0003275C File Offset: 0x0003095C
	public void GetHitLocation([Nullable(2)] UKuroHitResult hitResult, int index, IVector @out)
	{
		if (hitResult == null || !hitResult.bBlockingHit)
		{
			return;
		}
		@out.X = (double)hitResult.LocationX_Array.Get(index);
		@out.Y = (double)hitResult.LocationY_Array.Get(index);
		@out.Z = (double)hitResult.LocationZ_Array.Get(index);
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x000327B0 File Offset: 0x000309B0
	public void GetImpactPoint(UKuroHitResult hitResult, int index, IVector @out)
	{
		if (!hitResult.bBlockingHit)
		{
			return;
		}
		@out.X = (double)hitResult.ImpactPointX_Array.Get(index);
		@out.Y = (double)hitResult.ImpactPointY_Array.Get(index);
		@out.Z = (double)hitResult.ImpactPointZ_Array.Get(index);
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00032800 File Offset: 0x00030A00
	public void GetImpactNormal([Nullable(2)] UKuroHitResult hitResult, int index, IVector @out)
	{
		if (hitResult == null || !hitResult.bBlockingHit)
		{
			return;
		}
		@out.X = (double)hitResult.ImpactNormalX_Array.Get(index);
		@out.Y = (double)hitResult.ImpactNormalY_Array.Get(index);
		@out.Z = (double)hitResult.ImpactNormalZ_Array.Get(index);
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00032854 File Offset: 0x00030A54
	public bool IsHitOthers(UKuroHitResult hitResult, AActor fromActor, AActor toActor)
	{
		if (!hitResult.bBlockingHit)
		{
			return false;
		}
		int num = hitResult.Actors.Num();
		int num2 = 0;
		if (num2 >= num)
		{
			return false;
		}
		AActor aactor = hitResult.Actors.Get(num2);
		if (aactor == null)
		{
			return true;
		}
		while (aactor != null)
		{
			if (aactor != fromActor && aactor != toActor)
			{
				aactor = aactor.GetAttachParentActor();
			}
		}
		return true;
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000328AB File Offset: 0x00030AAB
	public static TraceElementCommon Instance
	{
		get
		{
			if (TraceElementCommon._instance == null)
			{
				TraceElementCommon._instance = new TraceElementCommon();
				TraceElementCommon._instance.OnInit();
			}
			return TraceElementCommon._instance;
		}
	}

	// Token: 0x060009E9 RID: 2537 RVA: 0x000328CE File Offset: 0x00030ACE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060009EA RID: 2538 RVA: 0x000328D0 File Offset: 0x00030AD0
	public static void ResetStaticDefaultValue()
	{
		TraceElementCommon instance = TraceElementCommon._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TraceElementCommon._instance = null;
	}

	// Token: 0x060009EB RID: 2539 RVA: 0x000328E9 File Offset: 0x00030AE9
	static TraceElementCommon()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TraceElementCommon.CreateStaticDefaultValue), new Action(TraceElementCommon.ResetStaticDefaultValue));
	}

	// Token: 0x0400068D RID: 1677
	private const bool OPEN_PROFILE_TEST = true;

	// Token: 0x0400068E RID: 1678
	private const string NO_PROFILE_KEY = "";

	// Token: 0x0400068F RID: 1679
	private int LineTraceFrame;

	// Token: 0x04000690 RID: 1680
	private int LineTraceIndex;

	// Token: 0x04000691 RID: 1681
	private int BoxTraceFrame;

	// Token: 0x04000692 RID: 1682
	private int BoxTraceIndex;

	// Token: 0x04000693 RID: 1683
	private int CapsuleTraceFrame;

	// Token: 0x04000694 RID: 1684
	private int CapsuleTraceIndex;

	// Token: 0x04000695 RID: 1685
	private int SphereTraceFrame;

	// Token: 0x04000696 RID: 1686
	private int SphereTraceIndex;

	// Token: 0x04000697 RID: 1687
	[Nullable(2)]
	private static TraceElementCommon _instance;
}
