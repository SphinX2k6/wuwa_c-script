using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleM.Zhezhi.Data
{
	// Token: 0x02004095 RID: 16533
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleM/Zhezhi/Data/BP_SkillTrackCurve.BP_SkillTrackCurve_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_SkillTrackCurve_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A957 RID: 174423 RVA: 0x009E52F8 File Offset: 0x009E34F8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SkillTrackCurve_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleM/Zhezhi/Data/BP_SkillTrackCurve.BP_SkillTrackCurve_C");
			}
			return BP_SkillTrackCurve_C._ClassPtr;
		}

		// Token: 0x0602A958 RID: 174424 RVA: 0x009E531C File Offset: 0x009E351C
		public BP_SkillTrackCurve_C() : this(BuiltinUtils.AllocNativeUObject(BP_SkillTrackCurve_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A959 RID: 174425 RVA: 0x009E5344 File Offset: 0x009E3544
		public BP_SkillTrackCurve_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SkillTrackCurve_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700686A RID: 26730
		// (get) Token: 0x0602A95A RID: 174426 RVA: 0x009E5377 File Offset: 0x009E3577
		// (set) Token: 0x0602A95B RID: 174427 RVA: 0x009E538B File Offset: 0x009E358B
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkillTrackCurve_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkillTrackCurve_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700686B RID: 26731
		// (get) Token: 0x0602A95C RID: 174428 RVA: 0x009E53A0 File Offset: 0x009E35A0
		// (set) Token: 0x0602A95D RID: 174429 RVA: 0x009E53B0 File Offset: 0x009E35B0
		public unsafe int SplinePointsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700686C RID: 26732
		// (get) Token: 0x0602A95E RID: 174430 RVA: 0x009E53C1 File Offset: 0x009E35C1
		// (set) Token: 0x0602A95F RID: 174431 RVA: 0x009E53D1 File Offset: 0x009E35D1
		public unsafe int SplinePointsIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700686D RID: 26733
		// (get) Token: 0x0602A960 RID: 174432 RVA: 0x009E53E4 File Offset: 0x009E35E4
		// (set) Token: 0x0602A961 RID: 174433 RVA: 0x009E541D File Offset: 0x009E361D
		public TMap<int, FSplinePoint> SplinePointsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FSplinePoint> result;
				if ((result = this._SplinePointsMap) == null)
				{
					result = (this._SplinePointsMap = new TMap<int, FSplinePoint>(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.SplinePointsMap.CopyAssign(value);
			}
		}

		// Token: 0x0602A962 RID: 174434 RVA: 0x009E542B File Offset: 0x009E362B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void UpdateSplineData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SkillTrackCurve_C.__UpdateSplineData_NativeFunctionPtr, null);
		}

		// Token: 0x0602A963 RID: 174435 RVA: 0x009E543F File Offset: 0x009E363F
		protected BP_SkillTrackCurve_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04016057 RID: 90199
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleM/Zhezhi/Data/BP_SkillTrackCurve.BP_SkillTrackCurve_C";

		// Token: 0x04016058 RID: 90200
		private static IntPtr _ClassPtr;

		// Token: 0x04016059 RID: 90201
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401605A RID: 90202
		internal static int __PropertyOffset_0;

		// Token: 0x0401605B RID: 90203
		internal static int __PropertyOffset_1;

		// Token: 0x0401605C RID: 90204
		internal static int __PropertyOffset_2;

		// Token: 0x0401605D RID: 90205
		internal static int __PropertyOffset_3;

		// Token: 0x0401605E RID: 90206
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FSplinePoint> _SplinePointsMap;

		// Token: 0x0401605F RID: 90207
		private static IntPtr __UpdateSplineData_NativeFunctionPtr;
	}
}
