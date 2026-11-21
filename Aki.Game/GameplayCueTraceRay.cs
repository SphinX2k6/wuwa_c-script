using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x0200252A RID: 9514
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueTraceRay : GameplayCueEffect
{
	// Token: 0x06017872 RID: 96370 RVA: 0x006F1A62 File Offset: 0x006EFC62
	protected override void OnInit()
	{
		base.OnInit();
		this.InitTrace();
		this.HitResultDistanceList = new List<GameplayCueTraceRay.HitResultDistance>();
	}

	// Token: 0x06017873 RID: 96371 RVA: 0x006F1A7C File Offset: 0x006EFC7C
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

	// Token: 0x06017874 RID: 96372 RVA: 0x006F1B08 File Offset: 0x006EFD08
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

	// Token: 0x06017875 RID: 96373 RVA: 0x006F1B76 File Offset: 0x006EFD76
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

	// Token: 0x06017876 RID: 96374 RVA: 0x006F1B96 File Offset: 0x006EFD96
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

	// Token: 0x06017877 RID: 96375 RVA: 0x006F1BB6 File Offset: 0x006EFDB6
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.IsEnable)
		{
			this.Trace();
		}
	}

	// Token: 0x06017878 RID: 96376 RVA: 0x006F1BD0 File Offset: 0x006EFDD0
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

	// Token: 0x06017879 RID: 96377 RVA: 0x006F1D94 File Offset: 0x006EFF94
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

	// Token: 0x0601787A RID: 96378 RVA: 0x006F1EE4 File Offset: 0x006F00E4
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

	// Token: 0x0400C82C RID: 51244
	private const float DEFAULT_TRACE_LENGTH = 1000f;

	// Token: 0x0400C82D RID: 51245
	private const float DEFAULT_TRACE_RADIUS = 10f;

	// Token: 0x0400C82E RID: 51246
	private const string PROFILE_GAMEPLAY_CUE_TRACE_RAY = "ProfileGameplayCueTraceRay";

	// Token: 0x0400C82F RID: 51247
	[Nullable(2)]
	private UTraceBaseElement TraceElement;

	// Token: 0x0400C830 RID: 51248
	private GameplayCueTraceRay.ETraceType TraceType;

	// Token: 0x0400C831 RID: 51249
	private float TraceLength = 1000f;

	// Token: 0x0400C832 RID: 51250
	private float TraceRadius = 10f;

	// Token: 0x0400C833 RID: 51251
	private Vector TraceStartPoint = Vector.Create();

	// Token: 0x0400C834 RID: 51252
	private Vector TraceEndPoint = Vector.Create();

	// Token: 0x0400C835 RID: 51253
	private Vector TraceForward = Vector.Create();

	// Token: 0x0400C836 RID: 51254
	private Transform TraceTransform = Transform.Create();

	// Token: 0x0400C837 RID: 51255
	private Quat TraceQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C838 RID: 51256
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<KuroEffectActorHandle, AActor> EffectActor;

	// Token: 0x0400C839 RID: 51257
	[Nullable(2)]
	private GameplayCueEffectCommonItem HitEffectItem;

	// Token: 0x0400C83A RID: 51258
	private bool HasSocket;

	// Token: 0x0400C83B RID: 51259
	private Vector HitResultLocation = Vector.Create();

	// Token: 0x0400C83C RID: 51260
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<GameplayCueTraceRay.HitResultDistance> HitResultDistanceList;

	// Token: 0x0400C83D RID: 51261
	private GameplayCueTraceRay.EEffectScaleAxis EffectScaleAxis;

	// Token: 0x0400C83E RID: 51262
	private Vector EffectScale = Vector.Create(1.0, 1.0, 1.0);

	// Token: 0x0400C83F RID: 51263
	private double TraceFrame;

	// Token: 0x0400C840 RID: 51264
	private double TraceIndex;

	// Token: 0x0400C841 RID: 51265
	[Nullable(2)]
	private FAsyncTraceDelegate TraceDelegate;

	// Token: 0x0400C842 RID: 51266
	private bool IsEnable = true;

	// Token: 0x0200883E RID: 34878
	[NullableContext(0)]
	private enum ETraceType
	{
		// Token: 0x0402B93A RID: 178490
		Ray,
		// Token: 0x0402B93B RID: 178491
		Sphere,
		// Token: 0x0402B93C RID: 178492
		MAX
	}

	// Token: 0x0200883F RID: 34879
	[NullableContext(0)]
	private enum ETraceObjectType
	{
		// Token: 0x0402B93E RID: 178494
		World,
		// Token: 0x0402B93F RID: 178495
		Player,
		// Token: 0x0402B940 RID: 178496
		Monster,
		// Token: 0x0402B941 RID: 178497
		MAX
	}

	// Token: 0x02008840 RID: 34880
	[NullableContext(0)]
	private enum EEffectScaleAxis
	{
		// Token: 0x0402B943 RID: 178499
		X,
		// Token: 0x0402B944 RID: 178500
		Y,
		// Token: 0x0402B945 RID: 178501
		Z,
		// Token: 0x0402B946 RID: 178502
		MAX
	}

	// Token: 0x02008841 RID: 34881
	[NullableContext(0)]
	private class HitResultDistance
	{
		// Token: 0x0402B947 RID: 178503
		public int Index;

		// Token: 0x0402B948 RID: 178504
		public float Distance;
	}
}
