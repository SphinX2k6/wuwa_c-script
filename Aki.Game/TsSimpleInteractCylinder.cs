using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.World;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002820 RID: 10272
[NullableContext(2)]
[Nullable(0)]
[UClass("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractCylinder.TsSimpleInteractCylinder_C")]
public class TsSimpleInteractCylinder : TsSimpleInteractBase, IUnrealUObject, IUnrealObject
{
	// Token: 0x170029BF RID: 10687
	// (get) Token: 0x06019E0B RID: 105995 RVA: 0x007F8BE4 File Offset: 0x007F6DE4
	// (set) Token: 0x06019E0C RID: 105996 RVA: 0x007F8BF4 File Offset: 0x007F6DF4
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CylinderHalfHeight
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_CylinderHalfHeight);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_CylinderHalfHeight) = value;
		}
	}

	// Token: 0x170029C0 RID: 10688
	// (get) Token: 0x06019E0D RID: 105997 RVA: 0x007F8C05 File Offset: 0x007F6E05
	// (set) Token: 0x06019E0E RID: 105998 RVA: 0x007F8C15 File Offset: 0x007F6E15
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float CylinderRadius
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_CylinderRadius);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_CylinderRadius) = value;
		}
	}

	// Token: 0x170029C1 RID: 10689
	// (get) Token: 0x06019E0F RID: 105999 RVA: 0x007F8C26 File Offset: 0x007F6E26
	// (set) Token: 0x06019E10 RID: 106000 RVA: 0x007F8C36 File Offset: 0x007F6E36
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe bool Intro
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_Intro) != 0;
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_Intro) = (value ? 1 : 0);
		}
	}

	// Token: 0x170029C2 RID: 10690
	// (get) Token: 0x06019E11 RID: 106001 RVA: 0x007F8C47 File Offset: 0x007F6E47
	// (set) Token: 0x06019E12 RID: 106002 RVA: 0x007F8C57 File Offset: 0x007F6E57
	[UProperty(EPropertyFlags.CPF_None)]
	public unsafe float Angle
	{
		get
		{
			return *(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_Angle);
		}
		set
		{
			*(base.NativePtr + (IntPtr)TsSimpleInteractCylinder.__PropertyOffset_Angle) = value;
		}
	}

	// Token: 0x06019E13 RID: 106003 RVA: 0x007F8C68 File Offset: 0x007F6E68
	protected override void OnBeginPlay()
	{
		this.SelfForward = Vector.Create();
		this.SelfRight = Vector.Create();
		this.SelfUp = Vector.Create();
		this.AngleLimit = new TsSimpleInteractCylinder.AngleLimitClass();
		this.TmpResultLocation = Vector.Create();
		this.TmpLocation = Vector.Create();
		this.TmpRotator = Rotator.Create();
		this.StartLocation = Vector.Create();
		this.EndLocation = Vector.Create();
		this.ActorFinalUp = Vector.Create();
		base.OnBeginPlay();
	}

	// Token: 0x06019E14 RID: 106004 RVA: 0x007F8CEC File Offset: 0x007F6EEC
	protected override void UpdateData()
	{
		base.UpdateData();
		Quat rotation = this.SelfTransform.GetRotation();
		rotation.RotateVector(Vector.ForwardVectorProxy, this.SelfForward);
		rotation.RotateVector(Vector.RightVectorProxy, this.SelfRight);
		this.SelfForward.CrossProduct(this.SelfRight, this.SelfUp);
		if (this.SelfUp.Z < 0.0)
		{
			this.ActorFinalUp.Set(-this.SelfUp.X, -this.SelfUp.Y, -this.SelfUp.Z);
			return;
		}
		this.ActorFinalUp.Set(this.SelfUp.X, this.SelfUp.Y, this.SelfUp.Z);
	}

	// Token: 0x06019E15 RID: 106005 RVA: 0x007F8DB4 File Offset: 0x007F6FB4
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
		float num = Math.Min(180f, this.Angle);
		int num2 = (int)Math.Ceiling((double)(num * 2f / 1f)) + 1;
		float num3 = (num2 > 1) ? (num * 2f / (float)(num2 - 1) * 0.017453292f) : 0f;
		float num4 = -num * 0.017453292f;
		for (int i = 0; i < num2; i++)
		{
			this.TmpLocation.X = (double)((float)Math.Cos((double)num4) * this.CylinderRadius);
			this.TmpLocation.Y = (double)((float)Math.Sin((double)num4) * this.CylinderRadius);
			this.TmpLocation.Z = (double)(-(double)this.CylinderHalfHeight);
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.StartLocation);
			this.TmpLocation.Z = (double)this.CylinderHalfHeight;
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.EndLocation);
			this.LineTrace.WorldContextObject = this;
			TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.StartLocation);
			TraceElementCommon.Instance.SetEndLocation(this.LineTrace, this.EndLocation);
			if (TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsSimpleInteractCylinder_CheckLegal"))
			{
				return false;
			}
			num4 += num3;
		}
		return true;
	}

	// Token: 0x06019E16 RID: 106006 RVA: 0x007F8F54 File Offset: 0x007F7154
	protected override void OnDraw()
	{
		if (this.LineTrace == null)
		{
			base.InitTraceInfo();
		}
		FLinearColor lineColor = this.IsLegal ? TsSimpleInteractCylinder.greenColor : TsSimpleInteractCylinder.yellowColor;
		float num = Math.Min(180f, this.Angle);
		int num2 = (int)Math.Floor((double)(num * 2f / 10f)) + 1;
		float num3 = (num2 > 1) ? (num * 2f / (float)(num2 - 1) * 0.017453292f) : 0f;
		float num4 = -num * 0.017453292f;
		Vector vector = Vector.Create();
		Vector vector2 = Vector.Create();
		Vector vector3 = Vector.Create();
		Vector vector4 = Vector.Create();
		for (int i = 0; i < num2; i++)
		{
			this.TmpLocation.X = (double)((float)Math.Cos((double)num4) * this.CylinderRadius);
			this.TmpLocation.Y = (double)((float)Math.Sin((double)num4) * this.CylinderRadius);
			this.TmpLocation.Z = (double)(-(double)this.CylinderHalfHeight);
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.StartLocation);
			this.TmpLocation.Z = (double)this.CylinderHalfHeight;
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.EndLocation);
			UKismetSystemLibrary.D_DrawDebugLine(this, this.StartLocation.ToUeVector(false), this.EndLocation.ToUeVector(false), lineColor, 0.05f, 4f);
			if (i == 0)
			{
				vector.DeepCopy(this.StartLocation);
				vector2.DeepCopy(this.EndLocation);
			}
			else
			{
				UKismetSystemLibrary.D_DrawDebugLine(this, vector3.ToUeVector(false), this.StartLocation.ToUeVector(false), lineColor, 0.05f, 4f);
				UKismetSystemLibrary.D_DrawDebugLine(this, vector4.ToUeVector(false), this.EndLocation.ToUeVector(false), lineColor, 0.05f, 4f);
			}
			vector3.DeepCopy(this.StartLocation);
			vector4.DeepCopy(this.EndLocation);
			num4 += num3;
		}
		if (this.Angle >= 180f)
		{
			UKismetSystemLibrary.D_DrawDebugLine(this, vector3.ToUeVector(false), vector.ToUeVector(false), lineColor, 0.05f, 4f);
			UKismetSystemLibrary.D_DrawDebugLine(this, vector4.ToUeVector(false), vector2.ToUeVector(false), lineColor, 0.05f, 4f);
		}
		float num5 = 0f;
		while ((double)num5 < 6.283185307179586)
		{
			this.TmpLocation.X = (double)((float)Math.Cos((double)num5) * this.CylinderRadius);
			this.TmpLocation.Y = (double)((float)Math.Sin((double)num5) * this.CylinderRadius);
			this.TmpLocation.Z = 0.0;
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.StartLocation);
			this.TmpLocation.X *= (double)(this.Intro ? 0.5f : 1.5f);
			this.TmpLocation.Y *= (double)(this.Intro ? 0.5f : 1.5f);
			this.SelfTransform.TransformPositionNoScale(this.TmpLocation, this.EndLocation);
			UKismetSystemLibrary.D_DrawDebugArrow(this, this.StartLocation.ToUeVector(false), this.EndLocation.ToUeVector(false), 50f, TsSimpleInteractCylinder.redColor, 0.05f, 4f);
			num5 += 1.5707964f;
		}
	}

	// Token: 0x06019E17 RID: 106007 RVA: 0x007F92B4 File Offset: 0x007F74B4
	protected override void SetText(FVector offset)
	{
		base.Text.HorizontalAlignment = EHorizTextAligment.EHTA_Center;
		base.Text.SetWorldSize(200f);
		base.Text.SetTextRenderColor(TsSimpleInteractCylinder.textColor);
		UTextRenderComponent text = base.Text;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
		defaultInterpolatedStringHandler.AppendLiteral("Cylinder ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(base.TypeId);
		text.Text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06019E18 RID: 106008 RVA: 0x007F932C File Offset: 0x007F752C
	[NullableContext(1)]
	protected override SSimpleInteractResult OnGetBestTransform(AActor actor, FVector moveOffset, float halfHeight, float radius)
	{
		this.UpdateData();
		SSimpleInteractResult tmpResult = this.TmpResult;
		float num = this.Intro ? (this.CylinderRadius - radius) : (this.CylinderRadius + radius);
		if (num <= 0f)
		{
			tmpResult.Success = false;
			return tmpResult;
		}
		Vector actorLocation = this.ActorLocation;
		FVectorDouble fvectorDouble = actor.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		this.ActorLocation.Subtraction(this.SelfLocation, this.SelfToActor);
		this.MoveOffset.FromUeVector(moveOffset);
		if (!this.CalAngleLimit(num))
		{
			tmpResult.Success = false;
			return tmpResult;
		}
		this.TmpVector1.DeepCopy(this.ActorLocation);
		this.TmpVector1.Z += this.MoveOffset.Z;
		double num2 = this.MoveOffset.SizeSquared2D();
		float num3 = (float)this.ActorLocation.Z + (float)this.MoveOffset.Z;
		float num4 = this.CylinderHalfHeight / (float)this.SelfUp.Z;
		double num5 = 1E+50;
		tmpResult.Success = false;
		int num6 = 1;
		foreach (float[] array in this.AngleLimit.Limits)
		{
			float num7 = array[1] - array[0];
			if (array[2] > 0f)
			{
				num7 += 360f;
			}
			int num8 = (int)Math.Ceiling((double)(num7 / 15f)) + 1;
			float num9 = num7 / (float)(num8 - 1) * 0.017453292f;
			float num10 = array[0] * 0.017453292f;
			for (int i = 0; i < num8; i++)
			{
				this.SelfForward.Multiply(Math.Cos((double)num10) * (double)num, this.TmpVector3);
				this.SelfRight.Multiply(Math.Sin((double)num10) * (double)num, this.TmpVector4);
				this.TmpVector3.AdditionEqual(this.TmpVector4);
				this.TmpVector3.AdditionEqual(this.SelfLocation);
				double value = (double)num3 - this.TmpVector3.Z;
				this.SelfUp.Multiply((double)Math.Sign(value) * Math.Min(Math.Abs(value), (double)num4) / this.SelfUp.Z, this.TmpVector4);
				this.TmpVector3.AdditionEqual(this.TmpVector4);
				double num11 = Vector.DistSquared2D(this.TmpVector1, this.TmpVector3);
				double num12 = MathUtils.Instance.Square(this.TmpVector1.Z - this.TmpVector3.Z) + num11 + num2 - 2.0 * Math.Sqrt(num11 * num2);
				if (Math.Abs(num5 - num12) < 0.0001)
				{
					num6++;
					if (Random.Shared.NextDouble() * (double)num6 < 1.0)
					{
						this.TmpResultLocation.DeepCopy(this.TmpVector3);
					}
				}
				else if (num5 > num12)
				{
					num6 = 1;
					num5 = num12;
					tmpResult.Success = true;
					this.TmpResultLocation.DeepCopy(this.TmpVector3);
				}
				num10 += num9;
			}
		}
		if (!tmpResult.Success)
		{
			return tmpResult;
		}
		this.LineTrace.WorldContextObject = actor;
		TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.ActorLocation);
		TraceElementCommon.Instance.SetEndLocation(this.LineTrace, this.TmpResultLocation);
		tmpResult.Success = !TraceElementCommon.Instance.LineTrace(this.LineTrace, "TsSimpleInteractCylindere_GetBestTransform");
		this.LineTrace.WorldContextObject = null;
		if (!tmpResult.Success)
		{
			return tmpResult;
		}
		tmpResult.Location = this.TmpResultLocation.ToUeVectorOld();
		tmpResult.SquaredOffsetLength = (float)num5;
		if (this.Intro)
		{
			this.TmpResultLocation.Subtraction(this.SelfLocation, this.TmpVector1);
		}
		else
		{
			this.SelfLocation.Subtraction(this.TmpResultLocation, this.TmpVector1);
		}
		MathUtils.Instance.LookRotationUpFirst(this.TmpVector1, this.ActorFinalUp, this.TmpRotator);
		tmpResult.Rotator = this.TmpRotator.ToUeRotator();
		return tmpResult;
	}

	// Token: 0x06019E19 RID: 106009 RVA: 0x007F9774 File Offset: 0x007F7974
	private bool CalAngleLimit(float cylinderRadius)
	{
		this.AngleLimit.Limits.Clear();
		this.SelfTransform.InverseTransformPositionNoScale(this.ActorLocation, this.TmpVector1);
		Vector tmpVector = this.TmpVector1;
		double num = (double)(cylinderRadius * cylinderRadius) / tmpVector.SizeSquared2D();
		if (num >= 1.0)
		{
			if (!this.Intro)
			{
				return false;
			}
			if (this.Angle < 180f)
			{
				List<float[]> limits = this.AngleLimit.Limits;
				float[] array = new float[3];
				array[0] = -this.Angle;
				array[1] = this.Angle;
				limits.Add(array);
			}
			else
			{
				List<float[]> limits2 = this.AngleLimit.Limits;
				float[] array2 = new float[3];
				array2[0] = -180f;
				array2[1] = 180f;
				limits2.Add(array2);
			}
			return true;
		}
		else
		{
			double num2 = Math.Acos(Math.Sqrt(num)) * 57.295780181884766;
			this.ActorAngleInSelf = new float?((float)MathUtils.Instance.GetAngleByVector2D(tmpVector));
			float num3;
			float num4;
			if (this.Intro)
			{
				num3 = (float)((double)this.ActorAngleInSelf.Value - num2);
				if (num3 < -180f)
				{
					num3 += 360f;
				}
				num4 = (float)((double)this.ActorAngleInSelf.Value + num2);
				if (num4 > 180f)
				{
					num4 -= 360f;
				}
			}
			else
			{
				num4 = (float)((double)this.ActorAngleInSelf.Value - num2);
				if (num4 < -180f)
				{
					num4 += 360f;
				}
				num3 = (float)((double)this.ActorAngleInSelf.Value + num2);
				if (num3 > 180f)
				{
					num3 -= 360f;
				}
			}
			if (this.Angle >= 180f)
			{
				this.AngleLimit.Limits.Add(new float[]
				{
					num4,
					num3,
					num4 >= num3
				});
				return true;
			}
			if (num4 >= num3)
			{
				if (num4 <= this.Angle && num3 >= -this.Angle)
				{
					List<float[]> limits3 = this.AngleLimit.Limits;
					float[] array3 = new float[3];
					array3[0] = num4;
					array3[1] = this.Angle;
					limits3.Add(array3);
				}
				if (num3 <= this.Angle && num3 >= -this.Angle)
				{
					List<float[]> limits4 = this.AngleLimit.Limits;
					float[] array4 = new float[3];
					array4[0] = -this.Angle;
					array4[1] = num3;
					limits4.Add(array4);
				}
				if (this.AngleLimit.Limits.Count == 0)
				{
					if (num4 * num3 < 0f)
					{
						return false;
					}
					List<float[]> limits5 = this.AngleLimit.Limits;
					float[] array5 = new float[3];
					array5[0] = -this.Angle;
					array5[1] = this.Angle;
					limits5.Add(array5);
				}
				return true;
			}
			num4 = Math.Max(num4, -this.Angle);
			num3 = Math.Min(num3, this.Angle);
			if (num4 > num3)
			{
				return false;
			}
			List<float[]> limits6 = this.AngleLimit.Limits;
			float[] array6 = new float[3];
			array6[0] = num4;
			array6[1] = num3;
			limits6.Add(array6);
			return true;
		}
	}

	// Token: 0x06019E1A RID: 106010 RVA: 0x007F9A3E File Offset: 0x007F7C3E
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsSimpleInteractCylinder._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractCylinder.TsSimpleInteractCylinder_C");
		}
		return TsSimpleInteractCylinder._ClassPtr;
	}

	// Token: 0x06019E1B RID: 106011 RVA: 0x007F9A64 File Offset: 0x007F7C64
	public TsSimpleInteractCylinder() : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractCylinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06019E1C RID: 106012 RVA: 0x007F9A8C File Offset: 0x007F7C8C
	[NullableContext(1)]
	public TsSimpleInteractCylinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsSimpleInteractCylinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06019E1D RID: 106013 RVA: 0x007F9ABF File Offset: 0x007F7CBF
	protected TsSimpleInteractCylinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0400E2CC RID: 58060
	private static readonly FLinearColor redColor = new FLinearColor(1f, 0f, 0f, 1f);

	// Token: 0x0400E2CD RID: 58061
	private static readonly FLinearColor yellowColor = new FLinearColor(1f, 1f, 0f, 1f);

	// Token: 0x0400E2CE RID: 58062
	private static readonly FLinearColor greenColor = new FLinearColor(0f, 1f, 0f, 1f);

	// Token: 0x0400E2CF RID: 58063
	private const float DRAW_TIME = 0.05f;

	// Token: 0x0400E2D0 RID: 58064
	private const float DEFAULT_THICKNESS = 4f;

	// Token: 0x0400E2D1 RID: 58065
	private const float DEFAULT_ARROW_SIZE = 50f;

	// Token: 0x0400E2D2 RID: 58066
	private const float NOT_INTRO_SIZE = 1.5f;

	// Token: 0x0400E2D3 RID: 58067
	private const float DRAW_ANGLE_PERIOD = 10f;

	// Token: 0x0400E2D4 RID: 58068
	private static readonly FColor textColor = new FColor(byte.MaxValue, 128, 128, byte.MaxValue);

	// Token: 0x0400E2D5 RID: 58069
	private const float TEXT_SIZE = 200f;

	// Token: 0x0400E2D6 RID: 58070
	private const float CHECK_ANGLE_PERIODIC = 1f;

	// Token: 0x0400E2D7 RID: 58071
	private const float MINUS_180 = -180f;

	// Token: 0x0400E2D8 RID: 58072
	private const float TRY_GET_ANGLE_PERIODIC = 15f;

	// Token: 0x0400E2D9 RID: 58073
	[Nullable(1)]
	private const string PROFILE_KEY_CEHCK_LEGAL = "TsSimpleInteractCylinder_CheckLegal";

	// Token: 0x0400E2DA RID: 58074
	[Nullable(1)]
	private const string PROFILE_KEY = "TsSimpleInteractCylindere_GetBestTransform";

	// Token: 0x0400E2DB RID: 58075
	private Vector SelfForward;

	// Token: 0x0400E2DC RID: 58076
	private Vector SelfRight;

	// Token: 0x0400E2DD RID: 58077
	private Vector SelfUp;

	// Token: 0x0400E2DE RID: 58078
	private TsSimpleInteractCylinder.AngleLimitClass AngleLimit;

	// Token: 0x0400E2DF RID: 58079
	private float? ActorAngleInSelf;

	// Token: 0x0400E2E0 RID: 58080
	private Vector TmpResultLocation;

	// Token: 0x0400E2E1 RID: 58081
	private Vector ActorFinalUp;

	// Token: 0x0400E2E2 RID: 58082
	private Vector TmpLocation;

	// Token: 0x0400E2E3 RID: 58083
	private Rotator TmpRotator;

	// Token: 0x0400E2E4 RID: 58084
	private Vector StartLocation;

	// Token: 0x0400E2E5 RID: 58085
	private Vector EndLocation;

	// Token: 0x0400E2E6 RID: 58086
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/NewWorld/SceneItem/SimpleBlueprintItem/TsSimpleInteractCylinder.TsSimpleInteractCylinder_C";

	// Token: 0x0400E2E7 RID: 58087
	private static IntPtr _ClassPtr;

	// Token: 0x0400E2E8 RID: 58088
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x0400E2E9 RID: 58089
	private static int __PropertyOffset_CylinderHalfHeight;

	// Token: 0x0400E2EA RID: 58090
	private static int __PropertyOffset_CylinderRadius;

	// Token: 0x0400E2EB RID: 58091
	private static int __PropertyOffset_Intro;

	// Token: 0x0400E2EC RID: 58092
	private static int __PropertyOffset_Angle;

	// Token: 0x02008971 RID: 35185
	[NullableContext(0)]
	private class AngleLimitClass
	{
		// Token: 0x06042994 RID: 272788 RVA: 0x013C75D8 File Offset: 0x013C57D8
		public ValueTuple<float, float> GetAngleFromLimits(float angle)
		{
			if (this.Limits.Count == 0)
			{
				return new ValueTuple<float, float>(angle, 0f);
			}
			float num = 360f;
			float item = 360f;
			foreach (float[] array in this.Limits)
			{
				if (array[2] == 0f)
				{
					float num2 = array[0] - angle;
					if (num2 > 0f)
					{
						if (num > num2)
						{
							num = num2;
							item = array[0];
						}
					}
					else
					{
						num2 = angle - array[1];
						if (num2 <= 0f)
						{
							return new ValueTuple<float, float>(angle, 0f);
						}
						if (num > num2)
						{
							num = num2;
							item = array[0];
						}
					}
				}
				else
				{
					int num3 = 0;
					float num4 = array[0] - angle;
					if (num4 > 0f)
					{
						if (num > num4)
						{
							num = num4;
							item = array[0];
						}
						num3++;
					}
					num4 = angle - array[1];
					if (num4 > 0f)
					{
						if (num > num4)
						{
							num = num4;
							item = array[0];
						}
						num3++;
					}
					if (num3 < 2)
					{
						return new ValueTuple<float, float>(angle, 0f);
					}
				}
			}
			return new ValueTuple<float, float>(item, num);
		}

		// Token: 0x0402BD0B RID: 179467
		[Nullable(1)]
		public readonly List<float[]> Limits = new List<float[]>();
	}
}
