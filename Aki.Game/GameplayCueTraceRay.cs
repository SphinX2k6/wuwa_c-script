using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002FD6 RID: 12246
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueTraceRay : GameplayCueEffect
{
	// Token: 0x06019F60 RID: 106336 RVA: 0x006CB16E File Offset: 0x006C936E
	protected override void OnInit()
	{
		base.OnInit();
		this.InitTrace();
		this.HitResultDistanceList = new List<GameplayCueTraceRay.HitResultDistance>();
	}

	// Token: 0x06019F61 RID: 106337 RVA: 0x006CB188 File Offset: 0x006C9388
	protected override void OnCreate()
	{
		base.OnCreate();
		if (this.TargetSocket != null)
		{
			this.HasSocket = (this.TargetSocket != FName.NAME_None);
		}
		this.EffectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		if (this.CueConfig.ResourcesLength > 0)
		{
			Vector vector = Vector.Create();
			this.HitEffectItem = GameplayCueEffectCommonItem.Spawn(this.ActorInternal, vector.ToUeVector(false), this.CueConfig.Resources());
		}
	}

	// Token: 0x06019F62 RID: 106338 RVA: 0x006CB214 File Offset: 0x006C9414
	protected override void OnDestroy()
	{
		base.OnDestroy();
		UTraceBaseElement traceElement = this.TraceElement;
		if (traceElement != null)
		{
			traceElement.Dispose();
		}
		this.TraceElement = null;
		this.EffectActor.Clear();
		GameplayCueEffectCommonItem hitEffectItem = this.HitEffectItem;
		if (hitEffectItem != null)
		{
			hitEffectItem.Destroy();
		}
		this.HitEffectItem = null;
		if (this.TraceDelegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<bool, UTraceBaseElement, double, double>(this.TraceHitResultHandle));
			this.TraceDelegate = null;
		}
	}

	// Token: 0x06019F63 RID: 106339 RVA: 0x006CB282 File Offset: 0x006C9482
	public override void OnEnable()
	{
		base.OnEnable();
		this.IsEnable = true;
		GameplayCueEffectCommonItem hitEffectItem = this.HitEffectItem;
		if (hitEffectItem == null)
		{
			return;
		}
		hitEffectItem.SetVisible(true);
	}

	// Token: 0x06019F64 RID: 106340 RVA: 0x006CB2A2 File Offset: 0x006C94A2
	public override void OnDisable()
	{
		base.OnDisable();
		this.IsEnable = false;
		GameplayCueEffectCommonItem hitEffectItem = this.HitEffectItem;
		if (hitEffectItem == null)
		{
			return;
		}
		hitEffectItem.SetVisible(false);
	}

	// Token: 0x06019F65 RID: 106341 RVA: 0x006CB2C2 File Offset: 0x006C94C2
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.IsEnable)
		{
			this.Trace();
		}
	}

	// Token: 0x06019F66 RID: 106342 RVA: 0x006CB2DC File Offset: 0x006C94DC
	private void InitTrace()
	{
		int parametersLength = this.CueConfig.ParametersLength;
		if (parametersLength > 0)
		{
			this.TraceType = (GameplayCueTraceRay.ETraceType)Math.Min(int.Parse(this.CueConfig.Parameters(0)), 1);
		}
		List<EObjectTypeQuery> list = new List<EObjectTypeQuery>();
		if (parametersLength > 1)
		{
			string text = this.CueConfig.Parameters(1);
			for (int i = 0; i < text.Length; i++)
			{
				if (text[i] == '1')
				{
					if (i == 0)
					{
						list.Add(KuroObjectTypeQuery.WorldStatic);
						list.Add(KuroObjectTypeQuery.WorldDynamic);
					}
					else if (i == 1)
					{
						list.Add(KuroObjectTypeQuery.PawnPlayer);
					}
					else if (i == 2)
					{
						list.Add(KuroObjectTypeQuery.PawnMonster);
					}
				}
			}
		}
		if (parametersLength > 2)
		{
			this.TraceLength = float.Parse(this.CueConfig.Parameters(2));
		}
		if (parametersLength > 3)
		{
			this.EffectScaleAxis = (GameplayCueTraceRay.EEffectScaleAxis)Math.Min(int.Parse(this.CueConfig.Parameters(3)), 2);
		}
		if (parametersLength > 4 && this.TraceType == GameplayCueTraceRay.ETraceType.Sphere)
		{
			this.TraceRadius = float.Parse(this.CueConfig.Parameters(4));
		}
		UTraceBaseElement utraceBaseElement;
		if (this.TraceType == GameplayCueTraceRay.ETraceType.Sphere)
		{
			utraceBaseElement = new UTraceSphereElement
			{
				Radius = this.TraceRadius
			};
		}
		else
		{
			utraceBaseElement = new UTraceLineElement();
		}
		utraceBaseElement.WorldContextObject = GlobalData.World;
		utraceBaseElement.bIsSingle = true;
		utraceBaseElement.bTraceComplex = false;
		utraceBaseElement.bIgnoreSelf = true;
		utraceBaseElement.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		foreach (EObjectTypeQuery objectType in list)
		{
			utraceBaseElement.AddObjectTypeQuery(objectType);
		}
		this.TraceElement = utraceBaseElement;
		this.TraceDelegate = DelegateUtils.ToManualReleaseDelegate<FAsyncTraceDelegate>(new Action<bool, UTraceBaseElement, double, double>(this.TraceHitResultHandle));
	}

	// Token: 0x06019F67 RID: 106343 RVA: 0x006CB4A0 File Offset: 0x006C96A0
	private void Trace()
	{
		if (this.TraceElement == null)
		{
			return;
		}
		ABaseCharacter actorInternal = this.ActorInternal;
		Vector traceStartPoint = this.TraceStartPoint;
		Vector traceEndPoint = this.TraceEndPoint;
		FTransform ftransform;
		if (this.HasSocket)
		{
			ftransform = actorInternal.Mesh.D_GetSocketTransform(this.TargetSocket, ERelativeTransformSpace.RTS_World).ToTransform();
		}
		else
		{
			ftransform = actorInternal.GetTransform();
		}
		this.TraceTransform.FromUeTransform(ftransform);
		Vector vector = traceStartPoint;
		FVector location = ftransform.GetLocation();
		vector.FromUeVector(location);
		this.TraceQuat.FromUeQuat(ftransform.GetRotation());
		this.TraceQuat.RotateVector(Vector.ForwardVectorProxy, this.TraceForward);
		traceEndPoint.FromUeVector(this.TraceForward);
		traceEndPoint.MultiplyEqual((double)this.TraceLength);
		traceEndPoint.AdditionEqual(traceStartPoint);
		TraceElementCommon.Instance.SetStartLocation(this.TraceElement, traceStartPoint);
		TraceElementCommon.Instance.SetEndLocation(this.TraceElement, traceEndPoint);
		TraceHandle traceHandle;
		if (this.TraceType == GameplayCueTraceRay.ETraceType.Sphere)
		{
			traceHandle = TraceElementCommon.Instance.AsyncSphereTrace((UTraceSphereElement)this.TraceElement, "ProfileGameplayCueTraceRay", this.TraceDelegate);
		}
		else
		{
			traceHandle = TraceElementCommon.Instance.AsyncLineTrace((UTraceLineElement)this.TraceElement, "ProfileGameplayCueTraceRay", this.TraceDelegate);
		}
		this.TraceFrame = (double)traceHandle.Frame;
		this.TraceIndex = (double)traceHandle.Index;
	}

	// Token: 0x06019F68 RID: 106344 RVA: 0x006CB5F0 File Offset: 0x006C97F0
	[NullableContext(2)]
	private void TraceHitResultHandle(bool result, UTraceBaseElement element, double frame, double index)
	{
		if (!this.IsActive || !this.IsEnable)
		{
			return;
		}
		if (frame < this.TraceFrame)
		{
			return;
		}
		if (frame == this.TraceFrame && index < this.TraceIndex)
		{
			return;
		}
		this.TraceFrame = frame;
		this.TraceIndex = index;
		UKuroHitResult hitResult = element.HitResult;
		int? num = (hitResult != null) ? new int?(hitResult.GetHitCount()) : null;
		int? num2 = num;
		int num3 = 0;
		if (!(num2.GetValueOrDefault() == num3 & num2 != null))
		{
			this.HitResultDistanceList.Clear();
			int num4 = 0;
			for (;;)
			{
				int num5 = num4;
				num2 = num;
				if (!(num5 < num2.GetValueOrDefault() & num2 != null))
				{
					break;
				}
				this.HitResultDistanceList.Add(new GameplayCueTraceRay.HitResultDistance
				{
					Distance = element.HitResult.DistanceArray.Get(num4),
					Index = num4
				});
				num4++;
			}
			if (this.HitResultDistanceList.Count > 0)
			{
				this.HitResultDistanceList.Sort((GameplayCueTraceRay.HitResultDistance a, GameplayCueTraceRay.HitResultDistance b) => a.Distance.CompareTo(b.Distance));
				if (this.EffectScaleAxis == GameplayCueTraceRay.EEffectScaleAxis.X)
				{
					this.EffectScale.X = (double)(this.HitResultDistanceList[0].Distance / this.TraceLength);
				}
				else if (this.EffectScaleAxis == GameplayCueTraceRay.EEffectScaleAxis.Y)
				{
					this.EffectScale.Y = (double)(this.HitResultDistanceList[0].Distance / this.TraceLength);
				}
				else
				{
					this.EffectScale.Z = (double)(this.HitResultDistanceList[0].Distance / this.TraceLength);
				}
				OneOf<KuroEffectActorHandle, AActor> effectActor = this.EffectActor;
				FVectorDouble fvectorDouble = this.EffectScale.ToUeVector(false);
				effectActor.D_SetActorScale3D(fvectorDouble);
				int index2 = this.HitResultDistanceList[0].Index;
				UKuroHitResult hitResult2 = element.HitResult;
				TArray<float> tarray = (hitResult2 != null) ? hitResult2.LocationX_Array : null;
				UKuroHitResult hitResult3 = element.HitResult;
				TArray<float> tarray2 = (hitResult3 != null) ? hitResult3.LocationY_Array : null;
				UKuroHitResult hitResult4 = element.HitResult;
				TArray<float> tarray3 = (hitResult4 != null) ? hitResult4.LocationZ_Array : null;
				this.HitResultLocation.X = ((tarray != null && index2 < tarray.Num()) ? ((double)tarray.Get(index2)) : this.HitResultLocation.X);
				this.HitResultLocation.Y = ((tarray2 != null && index2 < tarray2.Num()) ? ((double)tarray2.Get(index2)) : this.HitResultLocation.Y);
				this.HitResultLocation.Z = ((tarray3 != null && index2 < tarray3.Num()) ? ((double)tarray3.Get(index2)) : this.HitResultLocation.Z);
				GameplayCueEffectCommonItem hitEffectItem = this.HitEffectItem;
				if (hitEffectItem == null)
				{
					return;
				}
				hitEffectItem.Refresh(true, this.HitResultLocation, this.TraceTransform.GetRotation().Rotator(null));
				return;
			}
		}
		else
		{
			GameplayCueEffectCommonItem hitEffectItem2 = this.HitEffectItem;
			if (hitEffectItem2 == null)
			{
				return;
			}
			hitEffectItem2.Refresh(false, null, null);
		}
	}

	// Token: 0x0400C483 RID: 50307
	private const float DEFAULT_TRACE_LENGTH = 1000f;

	// Token: 0x0400C484 RID: 50308
	private const float DEFAULT_TRACE_RADIUS = 10f;

	// Token: 0x0400C485 RID: 50309
	private const string PROFILE_GAMEPLAY_CUE_TRACE_RAY = "ProfileGameplayCueTraceRay";

	// Token: 0x0400C486 RID: 50310
	[Nullable(2)]
	private UTraceBaseElement TraceElement;

	// Token: 0x0400C487 RID: 50311
	private GameplayCueTraceRay.ETraceType TraceType;

	// Token: 0x0400C488 RID: 50312
	private float TraceLength = 1000f;

	// Token: 0x0400C489 RID: 50313
	private float TraceRadius = 10f;

	// Token: 0x0400C48A RID: 50314
	private Vector TraceStartPoint = Vector.Create();

	// Token: 0x0400C48B RID: 50315
	private Vector TraceEndPoint = Vector.Create();

	// Token: 0x0400C48C RID: 50316
	private Vector TraceForward = Vector.Create();

	// Token: 0x0400C48D RID: 50317
	private Transform TraceTransform = Transform.Create();

	// Token: 0x0400C48E RID: 50318
	private Quat TraceQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C48F RID: 50319
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<KuroEffectActorHandle, AActor> EffectActor;

	// Token: 0x0400C490 RID: 50320
	[Nullable(2)]
	private GameplayCueEffectCommonItem HitEffectItem;

	// Token: 0x0400C491 RID: 50321
	private bool HasSocket;

	// Token: 0x0400C492 RID: 50322
	private Vector HitResultLocation = Vector.Create();

	// Token: 0x0400C493 RID: 50323
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<GameplayCueTraceRay.HitResultDistance> HitResultDistanceList;

	// Token: 0x0400C494 RID: 50324
	private GameplayCueTraceRay.EEffectScaleAxis EffectScaleAxis;

	// Token: 0x0400C495 RID: 50325
	private Vector EffectScale = Vector.Create(1.0, 1.0, 1.0);

	// Token: 0x0400C496 RID: 50326
	private double TraceFrame;

	// Token: 0x0400C497 RID: 50327
	private double TraceIndex;

	// Token: 0x0400C498 RID: 50328
	[Nullable(2)]
	private FAsyncTraceDelegate TraceDelegate;

	// Token: 0x0400C499 RID: 50329
	private bool IsEnable = true;

	// Token: 0x0200961D RID: 38429
	[NullableContext(0)]
	private enum ETraceType
	{
		// Token: 0x040302AD RID: 197293
		Ray,
		// Token: 0x040302AE RID: 197294
		Sphere,
		// Token: 0x040302AF RID: 197295
		MAX
	}

	// Token: 0x0200961E RID: 38430
	[NullableContext(0)]
	private enum ETraceObjectType
	{
		// Token: 0x040302B1 RID: 197297
		World,
		// Token: 0x040302B2 RID: 197298
		Player,
		// Token: 0x040302B3 RID: 197299
		Monster,
		// Token: 0x040302B4 RID: 197300
		MAX
	}

	// Token: 0x0200961F RID: 38431
	[NullableContext(0)]
	private enum EEffectScaleAxis
	{
		// Token: 0x040302B6 RID: 197302
		X,
		// Token: 0x040302B7 RID: 197303
		Y,
		// Token: 0x040302B8 RID: 197304
		Z,
		// Token: 0x040302B9 RID: 197305
		MAX
	}

	// Token: 0x02009620 RID: 38432
	[NullableContext(0)]
	private class HitResultDistance
	{
		// Token: 0x040302BA RID: 197306
		public int Index;

		// Token: 0x040302BB RID: 197307
		public float Distance;
	}
}
