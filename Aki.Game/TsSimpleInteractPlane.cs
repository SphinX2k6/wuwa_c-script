using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020032B1 RID: 12977
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPlane.TsSimpleInteractPlane_C")]
public class TsSimpleInteractPlane : TsSimpleInteractBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170026D6 RID: 9942
	// (get) Token: 0x0601C1E7 RID: 115175 RVA: 0x007D2DA5 File Offset: 0x007D0FA5
	// (set) Token: 0x0601C1E8 RID: 115176 RVA: 0x007D2DB5 File Offset: 0x007D0FB5
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float PlaneHalfHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractPlane.__PropertyOffset_PlaneHalfHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractPlane.__PropertyOffset_PlaneHalfHeight) = value;
		}
	}

	// Token: 0x170026D7 RID: 9943
	// (get) Token: 0x0601C1E9 RID: 115177 RVA: 0x007D2DC6 File Offset: 0x007D0FC6
	// (set) Token: 0x0601C1EA RID: 115178 RVA: 0x007D2DD6 File Offset: 0x007D0FD6
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float PlaneHalfWidth
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractPlane.__PropertyOffset_PlaneHalfWidth);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractPlane.__PropertyOffset_PlaneHalfWidth) = value;
		}
	}

	// Token: 0x0601C1EB RID: 115179 RVA: 0x007D2DE8 File Offset: 0x007D0FE8
	protected override void OnBeginPlay()
	{
		this.SelfForward = Vector.Create();
		this.SelfRight = Vector.Create();
		this.SelfUp = Vector.Create();
		this.SelfBackward = Vector.Create();
		this.Forward2D = Vector.Create();
		this.TmpResultLocation = Vector.Create();
		this.TmpResultRotator = Rotator.Create();
		this.TmpLocation = Vector.Create();
		this.StartLocation = Vector.Create();
		this.EndLocation = Vector.Create();
		this.NormalRotator = Rotator.Create();
		base.OnBeginPlay();
	}

	// Token: 0x0601C1EC RID: 115180 RVA: 0x007D2E74 File Offset: 0x007D1074
	protected override void UpdateData()
	{
		base.UpdateData();
		Quat rotation = this.SelfTransform.GetRotation();
		rotation.RotateVector(Vector.ForwardVectorProxy, this.SelfForward);
		rotation.RotateVector(Vector.RightVectorProxy, this.SelfRight);
		this.SelfForward.CrossProduct(this.SelfRight, this.SelfUp);
		this.ForwardSizeSquared2D = (float)(1.0 - MathUtils.Instance.Square(this.SelfForward.Z));
		if (!this.IsHorizontalPlane)
		{
			this.Forward2D.DeepCopy(this.SelfForward);
			this.Forward2D.Z = 0.0;
			this.Forward2D.DivisionEqual((double)this.ForwardSizeSquared2D);
			MathUtils.Instance.LookRotationForwardFirst(this.SelfBackward, Vector.UpVectorProxy, this.NormalRotator);
		}
	}

	// Token: 0x0601C1ED RID: 115181 RVA: 0x007D2F4C File Offset: 0x007D114C
	protected override bool CheckLegal()
	{
		if (this.TmpLocation == null)
		{
			this.TmpLocation = Vector.Create();
		}
		if (this.StartLocation == null)
		{
			this.StartLocation = Vector.Create();
		}
		if (this.EndLocation == null)
		{
			this.EndLocation = Vector.Create();
		}
		bool isLegal = this.IsLegal;
		if (this.LineTrace == null)
		{
			base.InitTraceInfo();
		}
		int num = (int)Math.Ceiling((double)(this.PlaneHalfHeight * 2f / 100f)) + 1;
		float num2 = (num > 1) ? (this.PlaneHalfHeight * 2f / (float)(num - 1)) : 0f;
		float num3 = -this.PlaneHalfHeight;
		for (int i = 0; i < num; i++)
		{
			this.TmpLocation.X = 0.0;
			this.TmpLocation.Y = (double)(-(double)this.PlaneHalfWidth);
			this.TmpLocation.Z = (double)num3;
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.StartLocation);
			this.TmpLocation.Y = (double)this.PlaneHalfWidth;
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.EndLocation);
			this.LineTrace.WorldContextObject = this;
			TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.LineTrace, this.EndLocation);
			if (TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsSimpleInteractPlane_CheckLegal"))
			{
				return false;
			}
			num3 += num2;
		}
		int num4 = (int)Math.Ceiling((double)(this.PlaneHalfWidth * 2f / 100f)) + 1;
		float num5 = (num4 > 1) ? (this.PlaneHalfWidth * 2f / (float)(num4 - 1)) : 0f;
		float num6 = -this.PlaneHalfWidth;
		for (int j = 0; j < num4; j++)
		{
			this.TmpLocation.X = 0.0;
			this.TmpLocation.Y = (double)num6;
			this.TmpLocation.Z = (double)(-(double)this.PlaneHalfHeight);
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.StartLocation);
			this.TmpLocation.Z = (double)this.PlaneHalfHeight;
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.EndLocation);
			this.LineTrace.WorldContextObject = this;
			TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.LineTrace, this.EndLocation);
			if (TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsSimpleInteractPlane_CheckLegal"))
			{
				return false;
			}
			num6 += num5;
		}
		return true;
	}

	// Token: 0x0601C1EE RID: 115182 RVA: 0x007D31F0 File Offset: 0x007D13F0
	protected override void OnDraw()
	{
		FLinearColor lineColor = this.IsLegal ? TsSimpleInteractPlane.GreenColor : TsSimpleInteractPlane.YellowColor;
		this.TmpLocation.X = 0.0;
		int num = TsSimpleInteractPlane.DrawPoints.Length;
		for (int i = 0; i < num; i++)
		{
			this.TmpLocation.Y = (double)(TsSimpleInteractPlane.DrawPoints[i].Y * this.PlaneHalfWidth);
			this.TmpLocation.Z = (double)(TsSimpleInteractPlane.DrawPoints[i].Z * this.PlaneHalfHeight);
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.StartLocation);
			for (int j = i + 1; j < num; j++)
			{
				this.TmpLocation.Y = (double)(TsSimpleInteractPlane.DrawPoints[j].Y * this.PlaneHalfWidth);
				this.TmpLocation.Z = (double)(TsSimpleInteractPlane.DrawPoints[j].Z * this.PlaneHalfHeight);
				this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.EndLocation);
				UKismetSystemLibrary.D_DrawDebugLine(this, this.StartLocation.ToUeVector(false), this.EndLocation.ToUeVector(false), lineColor, 0.05f, 4f);
			}
		}
		this.SelfTransform.TransformPositionNoScale(TsSimpleInteractPlane.ForwardOffset, this.EndLocation);
		UKismetSystemLibrary.D_DrawDebugArrow(this, base.D_K2_GetActorLocation(), this.EndLocation.ToUeVector(false), 100f, TsSimpleInteractPlane.RedColor, 0.05f, 4f);
	}

	// Token: 0x0601C1EF RID: 115183 RVA: 0x007D337C File Offset: 0x007D157C
	protected override void SetText(FVector offset)
	{
		base.Text.HorizontalAlignment = EHorizTextAligment.EHTA_Center;
		base.Text.SetWorldSize(200f);
		base.Text.SetTextRenderColor(TsSimpleInteractPlane.TextColor);
		UTextRenderComponent text = base.Text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Plane ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(base.TypeId);
		text.Text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601C1F0 RID: 115184 RVA: 0x007D33F4 File Offset: 0x007D15F4
	[NullableContext(1)]
	protected override SSimpleInteractResult OnGetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		this.UpdateData();
		SSimpleInteractResult tmpResult = this.TmpResult;
		Vector actorLocation = this.ActorLocation;
		FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		this.ActorLocation.Subtraction(this.SelfLocation, this.SelfToActor);
		tmpResult.Success = (this.SelfToActor.DotProduct(this.SelfForward) > (double)radius);
		if (!tmpResult.Success)
		{
			return tmpResult;
		}
		this.MoveOffset.FromUeVector(moveOffset);
		if (this.IsHorizontalPlane)
		{
			ValueTuple<Vector, Rotator, float> bestTransformHorizontal = this.GetBestTransformHorizontal(halfHeight, radius);
			tmpResult.Location = bestTransformHorizontal.Item1.ToUeVectorOld();
			tmpResult.Rotator = bestTransformHorizontal.Item2.ToUeRotator();
			tmpResult.SquaredOffsetLength = bestTransformHorizontal.Item3;
		}
		else
		{
			ValueTuple<Vector, Rotator, float> bestTransformNotHorizontal = this.GetBestTransformNotHorizontal(halfHeight, radius);
			tmpResult.Location = bestTransformNotHorizontal.Item1.ToUeVectorOld();
			tmpResult.Rotator = bestTransformNotHorizontal.Item2.ToUeRotator();
			tmpResult.SquaredOffsetLength = bestTransformNotHorizontal.Item3;
		}
		this.LineTrace.WorldContextObject = actor;
		TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.ActorLocation);
		TraceElementCommon.Instance.SetEndLocation(this.LineTrace, tmpResult.Location);
		tmpResult.Success = !TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsSimpleInteractPlane_GetBestTransform");
		return tmpResult;
	}

	// Token: 0x0601C1F1 RID: 115185 RVA: 0x007D354C File Offset: 0x007D174C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private ValueTuple<Vector, Rotator, float> GetBestTransformHorizontal(float halfHeight, float radius)
	{
		double num = this.SelfRight.DotProduct(this.SelfToActor);
		double num2 = this.SelfUp.DotProduct(this.SelfToActor);
		double num3 = num + this.SelfRight.DotProduct(this.MoveOffset);
		double num4 = num2 + this.SelfUp.DotProduct(this.MoveOffset);
		double num5 = Math.Abs(num3);
		double num6 = Math.Abs(num4);
		float planeHalfWidth = this.PlaneHalfWidth;
		float planeHalfHeight = this.PlaneHalfHeight;
		if (num5 < (double)planeHalfWidth && num6 < (double)planeHalfHeight)
		{
			this.ActorLocation.Addition(this.MoveOffset, this.TmpResultLocation);
			double num7 = this.SelfLocation.Z + this.SelfForward.X * (double)radius;
			double num8 = num7 - this.TmpResultLocation.Z;
			this.TmpResultLocation.Z = num7;
			MathUtils.Instance.LookRotationForwardFirst(this.SelfBackward, this.MoveOffset, this.TmpResultRotator);
			return new ValueTuple<Vector, Rotator, float>(this.TmpResultLocation, this.TmpResultRotator, (float)(num8 * num8));
		}
		double num9 = Math.Abs(num);
		double num10 = Math.Abs(num2);
		double num11 = MathUtils.Instance.Square(num9 + (double)planeHalfWidth) + MathUtils.Instance.Square(num10 + (double)planeHalfHeight);
		double num12 = this.MoveOffset.SizeSquared2D();
		if (num11 <= num12)
		{
			this.TmpResultLocation.X = (double)radius;
			this.TmpResultLocation.Y = (double)((num3 > 0.0) ? (-(double)planeHalfWidth) : planeHalfWidth);
			this.TmpResultLocation.Z = (double)((num4 > 0.0) ? (-(double)planeHalfHeight) : planeHalfHeight);
			this.SelfTransform.TransformPositionNoScale(this.TmpResultLocation, this.TmpResultLocation);
			this.TmpResultLocation.Subtraction(this.ActorLocation, this.TmpVector1);
			MathUtils.Instance.LookRotationForwardFirst(this.SelfBackward, this.TmpVector1, this.TmpResultRotator);
			double num13 = MathUtils.Instance.Square(this.TmpResultLocation.Z - (this.ActorLocation.Z + this.MoveOffset.Z)) + MathUtils.Instance.Square((double)((float)Math.Sqrt(num12) - (float)Math.Sqrt(num11)));
			return new ValueTuple<Vector, Rotator, float>(this.TmpResultLocation, this.TmpResultRotator, (float)num13);
		}
		if (this.FindHitMatrixAndCircle((double)planeHalfWidth, (double)planeHalfHeight, num, num2, num12, num3, num4))
		{
			this.TmpResultLocation.X = (double)radius;
			this.TmpResultLocation.Subtraction(this.ActorLocation, this.TmpVector1);
			MathUtils.Instance.LookRotationForwardFirst(this.SelfBackward, this.TmpVector1, this.TmpResultRotator);
			double num14 = MathUtils.Instance.Square(this.TmpResultLocation.Z - (this.ActorLocation.Z + this.MoveOffset.Z));
			return new ValueTuple<Vector, Rotator, float>(this.TmpResultLocation, this.TmpResultRotator, (float)num14);
		}
		this.TmpResultLocation.X = (double)radius;
		this.TmpResultLocation.Y = (double)((num3 > 0.0) ? planeHalfWidth : (-(double)planeHalfWidth));
		this.TmpResultLocation.Z = (double)((num4 > 0.0) ? planeHalfHeight : (-(double)planeHalfHeight));
		this.SelfTransform.TransformPositionNoScale(this.TmpResultLocation, this.TmpResultLocation);
		this.TmpResultLocation.Subtraction(this.ActorLocation, this.TmpVector1);
		MathUtils.Instance.LookRotationForwardFirst(this.SelfBackward, this.TmpVector1, this.TmpResultRotator);
		num11 = MathUtils.Instance.Square(num9 - (double)planeHalfWidth) + MathUtils.Instance.Square(num10 - (double)planeHalfHeight);
		double num15 = MathUtils.Instance.Square(this.TmpResultLocation.Z - (this.ActorLocation.Z + this.MoveOffset.Z)) + num12 + num11 - (double)(2f * (float)Math.Sqrt(num12 * num11));
		return new ValueTuple<Vector, Rotator, float>(this.TmpResultLocation, this.TmpResultRotator, (float)num15);
	}

	// Token: 0x0601C1F2 RID: 115186 RVA: 0x007D394C File Offset: 0x007D1B4C
	private bool FindHitMatrixAndCircle(double validHalfWidth, double validHalfHeight, double yActor, double zActor, double moveOffsetSizeSquared2D, double yMoveTarget, double zMoveTarget)
	{
		double num = moveOffsetSizeSquared2D * 10.0;
		for (int i = 0; i < 2; i++)
		{
			double num2 = (i == 0) ? validHalfWidth : (-validHalfWidth);
			double num3 = moveOffsetSizeSquared2D - MathUtils.Instance.Square(yActor - num2);
			if (num3 > 0.0)
			{
				double num4 = Math.Sqrt(num3);
				double num5 = zActor - num4;
				if (Math.Abs(num5) < validHalfHeight)
				{
					double num6 = MathUtils.Instance.Square(num2 - yMoveTarget) + MathUtils.Instance.Square(num5 - zMoveTarget);
					if (num6 < num)
					{
						num = num6;
						this.TmpResultLocation.Y = num2;
						this.TmpResultLocation.Z = num5;
					}
				}
				num5 = zActor + num4;
				if (Math.Abs(num5) < validHalfHeight)
				{
					double num7 = MathUtils.Instance.Square(num2 - yMoveTarget) + MathUtils.Instance.Square(num5 - zMoveTarget);
					if (num7 < num)
					{
						num = num7;
						this.TmpResultLocation.Y = num2;
						this.TmpResultLocation.Z = num5;
					}
				}
			}
		}
		for (int j = 0; j < 2; j++)
		{
			double num8 = (j == 0) ? validHalfHeight : (-validHalfHeight);
			double num9 = moveOffsetSizeSquared2D - MathUtils.Instance.Square(zActor - num8);
			if (num9 > 0.0)
			{
				float num10 = (float)Math.Sqrt(num9);
				double num11 = yActor - (double)num10;
				if (Math.Abs(yActor) < validHalfWidth)
				{
					double num12 = MathUtils.Instance.Square(num11 - yMoveTarget) + MathUtils.Instance.Square(num8 - zMoveTarget);
					if (num12 < num)
					{
						num = (double)((float)num12);
						this.TmpResultLocation.Y = num11;
						this.TmpResultLocation.Z = num8;
					}
				}
				num11 = yActor + (double)num10;
				if (Math.Abs(num11) < validHalfHeight)
				{
					double num13 = MathUtils.Instance.Square(num11 - yMoveTarget) + MathUtils.Instance.Square(num8 - zMoveTarget);
					if (num13 < num)
					{
						num = (double)((float)num13);
						this.TmpResultLocation.Y = num11;
						this.TmpResultLocation.Z = num8;
					}
				}
			}
		}
		return num < moveOffsetSizeSquared2D * 10.0;
	}

	// Token: 0x0601C1F3 RID: 115187 RVA: 0x007D3B58 File Offset: 0x007D1D58
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private ValueTuple<Vector, Rotator, float> GetBestTransformNotHorizontal(float halfHeight, float radius)
	{
		this.TmpVector1.DeepCopy(this.SelfToActor);
		this.TmpVector1.Z += this.MoveOffset.Z;
		double num = this.SelfForward.DotProduct(this.TmpVector1);
		double num2 = MathUtils.Instance.Square(num - (double)radius) / (double)this.ForwardSizeSquared2D;
		double num3 = this.MoveOffset.SizeSquared2D();
		float planeHalfWidth = this.PlaneHalfWidth;
		float planeHalfHeight = this.PlaneHalfHeight;
		if (num2 >= num3)
		{
			this.TmpVector2.DeepCopy(this.Forward2D);
			this.TmpVector2.MultiplyEqual((double)((float)Math.Sqrt(num3)));
			this.TmpVector1.SubtractionEqual(this.TmpVector2);
			this.TmpResultLocation.X = (double)radius;
			this.TmpResultLocation.Y = MathUtils.Instance.Clamp(this.SelfRight.DotProduct(this.TmpVector1), (double)(-(double)planeHalfWidth), (double)planeHalfWidth);
			this.TmpResultLocation.Z = MathUtils.Instance.Clamp(this.SelfUp.DotProduct(this.TmpVector1), (double)(-(double)planeHalfHeight), (double)planeHalfHeight);
			this.SelfTransform.TransformPositionNoScale(this.TmpResultLocation, this.TmpResultLocation);
			this.TmpResultLocation.Subtraction(this.ActorLocation, this.TmpVector1);
			return new ValueTuple<Vector, Rotator, float>(this.TmpResultLocation, this.NormalRotator, (float)(MathUtils.Instance.Square(this.TmpVector1.Size2D() - (double)((float)Math.Sqrt(num3))) + MathUtils.Instance.Square(this.TmpVector1.Z - this.MoveOffset.Z)));
		}
		Vector.UpVectorProxy.CrossProduct(this.SelfForward, this.TmpVector1);
		Vector.UpVectorProxy.CrossProduct(this.TmpVector1, this.TmpVector2);
		this.TmpVector2.MultiplyEqual((double)((float)Math.Sign(num - (double)radius) * (float)Math.Sqrt(num2 / this.TmpVector2.SizeSquared())));
		this.TmpVector2.AdditionEqual(this.ActorLocation);
		this.TmpVector2.Z += this.MoveOffset.Z;
		this.TmpVector1.MultiplyEqual((double)((float)Math.Sqrt((num3 - num2) / this.TmpVector1.SizeSquared())));
		this.TmpVector2.Addition(this.TmpVector1, this.TmpVector3);
		this.SelfTransform.InverseTransformPositionNoScale(this.TmpVector3, this.TmpVector3);
		double num4 = MathUtils.Instance.Square(Math.Max(0.0, Math.Abs(this.TmpVector3.Y) - (double)planeHalfWidth)) + MathUtils.Instance.Square(Math.Max(0.0, Math.Abs(this.TmpVector3.Z) - (double)planeHalfHeight));
		this.TmpVector3.Y = (double)Math.Sign(this.TmpVector3.Y) * Math.Min(Math.Abs(this.TmpVector3.Y), (double)planeHalfWidth);
		this.TmpVector3.Z = (double)Math.Sign(this.TmpVector3.Z) * Math.Min(Math.Abs(this.TmpVector3.Z), (double)planeHalfHeight);
		this.TmpVector2.Subtraction(this.TmpVector1, this.TmpVector4);
		this.SelfTransform.InverseTransformPositionNoScale(this.TmpVector4, this.TmpVector4);
		double num5 = MathUtils.Instance.Square(Math.Max(0.0, Math.Abs(this.TmpVector4.Y) - (double)planeHalfWidth)) + MathUtils.Instance.Square(Math.Max(0.0, Math.Abs(this.TmpVector4.Z) - (double)planeHalfHeight));
		if (num4 > num5 || (Math.Abs(num4 - num5) < 0.10000000149011612 && UKismetMathLibrary.RandomFloat() >= 0.5f))
		{
			num4 = num5;
			this.TmpVector4.Y = (double)Math.Sign(this.TmpVector4.Y) * Math.Min(Math.Abs(this.TmpVector4.Y), (double)planeHalfWidth);
			this.TmpVector4.Z = (double)Math.Sign(this.TmpVector4.Z) * Math.Min(Math.Abs(this.TmpVector4.Z), (double)planeHalfHeight);
			this.SelfTransform.InverseTransformPositionNoScale(this.TmpVector4, this.TmpResultLocation);
		}
		else
		{
			this.TmpVector3.Y = (double)Math.Sign(this.TmpVector3.Y) * Math.Min(Math.Abs(this.TmpVector3.Y), (double)planeHalfWidth);
			this.TmpVector3.Z = (double)Math.Sign(this.TmpVector3.Z) * Math.Min(Math.Abs(this.TmpVector3.Z), (double)planeHalfHeight);
			this.SelfTransform.InverseTransformPositionNoScale(this.TmpVector3, this.TmpResultLocation);
		}
		return new ValueTuple<Vector, Rotator, float>(this.TmpResultLocation, this.NormalRotator, (float)num4);
	}

	// Token: 0x0601C1F4 RID: 115188 RVA: 0x007D4069 File Offset: 0x007D2269
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractPlane._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPlane.TsSimpleInteractPlane_C");
		}
		return TsSimpleInteractPlane._ClassPtr;
	}

	// Token: 0x0601C1F5 RID: 115189 RVA: 0x007D4090 File Offset: 0x007D2290
	public TsSimpleInteractPlane() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPlane.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601C1F6 RID: 115190 RVA: 0x007D40B8 File Offset: 0x007D22B8
	[NullableContext(1)]
	public TsSimpleInteractPlane(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractPlane.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C1F7 RID: 115191 RVA: 0x007D40EB File Offset: 0x007D22EB
	protected TsSimpleInteractPlane(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400DE56 RID: 56918
	private static readonly FLinearColor RedColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400DE57 RID: 56919
	private static readonly FLinearColor YellowColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x0400DE58 RID: 56920
	private static readonly FLinearColor GreenColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400DE59 RID: 56921
	private const float DRAW_TIME = 0.05f;

	// Token: 0x0400DE5A RID: 56922
	private const float DEFAULT_THICKNESS = 4f;

	// Token: 0x0400DE5B RID: 56923
	private const float DEFAULT_ARROW_SIZE = 100f;

	// Token: 0x0400DE5C RID: 56924
	private const float DRAW_LENGTH = 200f;

	// Token: 0x0400DE5D RID: 56925
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector ForwardOffset = Vector.Create(200.0, 0.0, 0.0);

	// Token: 0x0400DE5E RID: 56926
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly FVector[] DrawPoints = new FVector[]
	{
		new FVector(0f, -1f, -1f),
		new FVector(0f, -1f, 1f),
		new FVector(0f, 1f, -1f),
		new FVector(0f, 1f, 1f)
	};

	// Token: 0x0400DE5F RID: 56927
	private static readonly FColor TextColor = new FColor(byte.MaxValue, 128, 128, byte.MaxValue);

	// Token: 0x0400DE60 RID: 56928
	private const float TEXT_SIZE = 200f;

	// Token: 0x0400DE61 RID: 56929
	private const float LEGAL_CHECK_PERIOD = 100f;

	// Token: 0x0400DE62 RID: 56930
	private const float SMALL_VALUE = 0.1f;

	// Token: 0x0400DE63 RID: 56931
	[Nullable(1)]
	private const string PROFILE_KEY_CEHCK_LEGAL = "TsSimpleInteractPlane_CheckLegal";

	// Token: 0x0400DE64 RID: 56932
	[Nullable(1)]
	private const string PROFILE_KEY = "TsSimpleInteractPlane_GetBestTransform";

	// Token: 0x0400DE65 RID: 56933
	private Vector SelfForward;

	// Token: 0x0400DE66 RID: 56934
	private Vector SelfBackward;

	// Token: 0x0400DE67 RID: 56935
	private Vector SelfRight;

	// Token: 0x0400DE68 RID: 56936
	private Vector SelfUp;

	// Token: 0x0400DE69 RID: 56937
	private readonly bool IsHorizontalPlane;

	// Token: 0x0400DE6A RID: 56938
	private Vector TmpResultLocation;

	// Token: 0x0400DE6B RID: 56939
	private Rotator TmpResultRotator;

	// Token: 0x0400DE6C RID: 56940
	private float ForwardSizeSquared2D;

	// Token: 0x0400DE6D RID: 56941
	private Vector Forward2D;

	// Token: 0x0400DE6E RID: 56942
	private Rotator NormalRotator;

	// Token: 0x0400DE6F RID: 56943
	private Vector TmpLocation;

	// Token: 0x0400DE70 RID: 56944
	private Vector StartLocation;

	// Token: 0x0400DE71 RID: 56945
	private Vector EndLocation;

	// Token: 0x0400DE72 RID: 56946
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractPlane.TsSimpleInteractPlane_C";

	// Token: 0x0400DE73 RID: 56947
	private static IntPtr _ClassPtr;

	// Token: 0x0400DE74 RID: 56948
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400DE75 RID: 56949
	private static int __PropertyOffset_PlaneHalfHeight;

	// Token: 0x0400DE76 RID: 56950
	private static int __PropertyOffset_PlaneHalfWidth;
}
