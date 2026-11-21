using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000108 RID: 264
[NullableContext(1)]
[Nullable(0)]
public class TraceElementCommon : Singleton
{
	// Token: 0x06000A25 RID: 2597 RVA: 0x00032DE7 File Offset: 0x00030FE7
	public bool LineTrace(UTraceLineElement element, string profileKey)
	{
		return UKuroTraceLibrary.LineTrace(element, profileKey);
	}

	// Token: 0x06000A26 RID: 2598 RVA: 0x00032DF0 File Offset: 0x00030FF0
	public bool BoxTrace(UTraceBoxElement element, string profileKey)
	{
		return UKuroTraceLibrary.BoxTrace(element, profileKey);
	}

	// Token: 0x06000A27 RID: 2599 RVA: 0x00032DF9 File Offset: 0x00030FF9
	public bool CapsuleTrace(UTraceCapsuleElement element, string profileKey)
	{
		return UKuroTraceLibrary.CapsuleTrace(element, profileKey);
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00032E02 File Offset: 0x00031002
	public bool SphereTrace(UTraceSphereElement element, string profileKey)
	{
		return UKuroTraceLibrary.SphereTrace(element, profileKey);
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00032E0C File Offset: 0x0003100C
	public bool ShapeTrace([Nullable(2)] UShapeComponent inShapeComp, UTraceBaseElement element, string traceTagName, string profileKey)
	{
		FName value = FNameUtil.GetDynamicFName(traceTagName).Value;
		return UKuroTraceLibrary.ShapeTrace(inShapeComp, element, value, profileKey);
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00032E34 File Offset: 0x00031034
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

	// Token: 0x06000A2B RID: 2603 RVA: 0x00032EA4 File Offset: 0x000310A4
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

	// Token: 0x06000A2C RID: 2604 RVA: 0x00032F14 File Offset: 0x00031114
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

	// Token: 0x06000A2D RID: 2605 RVA: 0x00032F84 File Offset: 0x00031184
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

	// Token: 0x06000A2E RID: 2606 RVA: 0x00032FF2 File Offset: 0x000311F2
	public void SetStartLocation(UTraceBaseElement element, IVector location)
	{
		element.SetStartLocation(location.X, location.Y, location.Z);
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x0003300C File Offset: 0x0003120C
	public void SetEndLocation(UTraceBaseElement element, IVector location)
	{
		element.SetEndLocation(location.X, location.Y, location.Z);
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00033026 File Offset: 0x00031226
	public void SetTraceColor(UTraceBaseElement element, FLinearColor color)
	{
		element.SetTraceColor(color.R, color.G, color.B, color.A);
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00033046 File Offset: 0x00031246
	public void SetTraceHitColor(UTraceBaseElement element, FLinearColor color)
	{
		element.SetTraceHitColor(color.R, color.G, color.B, color.A);
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00033066 File Offset: 0x00031266
	public void SetBoxHalfSize(UTraceBoxElement boxElement, IVector size)
	{
		boxElement.SetBoxHalfSize((float)size.X, (float)size.Y, (float)size.Z);
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00033083 File Offset: 0x00031283
	public void SetBoxOrientation(UTraceBoxElement boxElement, IRotator rotator)
	{
		boxElement.SetBoxOrientation(rotator.Pitch, rotator.Yaw, rotator.Roll);
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x0003309D File Offset: 0x0003129D
	public void SetCapsuleOrientation(UTraceCapsuleElement capsuleElement, IRotator rotator)
	{
		capsuleElement.SetCapsuleOrientation(rotator.Pitch, rotator.Yaw, rotator.Roll);
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x000330B8 File Offset: 0x000312B8
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

	// Token: 0x06000A36 RID: 2614 RVA: 0x0003310C File Offset: 0x0003130C
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

	// Token: 0x06000A37 RID: 2615 RVA: 0x0003315C File Offset: 0x0003135C
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

	// Token: 0x06000A38 RID: 2616 RVA: 0x000331B0 File Offset: 0x000313B0
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

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00033207 File Offset: 0x00031407
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

	// Token: 0x06000A3A RID: 2618 RVA: 0x0003322A File Offset: 0x0003142A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x0003322C File Offset: 0x0003142C
	public static void ResetStaticDefaultValue()
	{
		TraceElementCommon instance = TraceElementCommon._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		TraceElementCommon._instance = null;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00033245 File Offset: 0x00031445
	static TraceElementCommon()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TraceElementCommon.CreateStaticDefaultValue), new Action(TraceElementCommon.ResetStaticDefaultValue));
	}

	// Token: 0x04000698 RID: 1688
	private const bool OPEN_PROFILE_TEST = true;

	// Token: 0x04000699 RID: 1689
	private const string NO_PROFILE_KEY = "";

	// Token: 0x0400069A RID: 1690
	private int LineTraceFrame;

	// Token: 0x0400069B RID: 1691
	private int LineTraceIndex;

	// Token: 0x0400069C RID: 1692
	private int BoxTraceFrame;

	// Token: 0x0400069D RID: 1693
	private int BoxTraceIndex;

	// Token: 0x0400069E RID: 1694
	private int CapsuleTraceFrame;

	// Token: 0x0400069F RID: 1695
	private int CapsuleTraceIndex;

	// Token: 0x040006A0 RID: 1696
	private int SphereTraceFrame;

	// Token: 0x040006A1 RID: 1697
	private int SphereTraceIndex;

	// Token: 0x040006A2 RID: 1698
	[Nullable(2)]
	private static TraceElementCommon _instance;
}
