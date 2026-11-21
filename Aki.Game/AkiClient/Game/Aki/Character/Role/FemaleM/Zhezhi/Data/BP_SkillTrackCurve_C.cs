using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.FemaleM.Zhezhi.Data
{
	// Token: 0x02003296 RID: 12950
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/FemaleM/Zhezhi/Data/BP_SkillTrackCurve.BP_SkillTrackCurve_C")]
	[UnrealStructLayout(1136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1136)]
	public class BP_SkillTrackCurve_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602072D RID: 132909 RVA: 0x00946DA8 File Offset: 0x00944FA8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SkillTrackCurve_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/FemaleM/Zhezhi/Data/BP_SkillTrackCurve.BP_SkillTrackCurve_C");
			}
			return BP_SkillTrackCurve_C._ClassPtr;
		}

		// Token: 0x0602072E RID: 132910 RVA: 0x00946DCC File Offset: 0x00944FCC
		public BP_SkillTrackCurve_C() : this(BuiltinUtils.AllocNativeUObject(BP_SkillTrackCurve_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602072F RID: 132911 RVA: 0x00946DF4 File Offset: 0x00944FF4
		public BP_SkillTrackCurve_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SkillTrackCurve_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F18 RID: 16152
		// (get) Token: 0x06020730 RID: 132912 RVA: 0x00946E27 File Offset: 0x00945027
		// (set) Token: 0x06020731 RID: 132913 RVA: 0x00946E3B File Offset: 0x0094503B
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkillTrackCurve_C.__PropertyOffset_Spline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SkillTrackCurve_C.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x17003F19 RID: 16153
		// (get) Token: 0x06020732 RID: 132914 RVA: 0x00946E50 File Offset: 0x00945050
		// (set) Token: 0x06020733 RID: 132915 RVA: 0x00946E60 File Offset: 0x00945060
		public unsafe int SplinePointsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_SplinePointsNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_SplinePointsNum) = value;
			}
		}

		// Token: 0x17003F1A RID: 16154
		// (get) Token: 0x06020734 RID: 132916 RVA: 0x00946E71 File Offset: 0x00945071
		// (set) Token: 0x06020735 RID: 132917 RVA: 0x00946E81 File Offset: 0x00945081
		public unsafe int SplinePointsIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_SplinePointsIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_SplinePointsIndex) = value;
			}
		}

		// Token: 0x17003F1B RID: 16155
		// (get) Token: 0x06020736 RID: 132918 RVA: 0x00946E94 File Offset: 0x00945094
		// (set) Token: 0x06020737 RID: 132919 RVA: 0x00946ECD File Offset: 0x009450CD
		public TMap<int, FSplinePoint> SplinePointsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FSplinePoint> result;
				if ((result = this._SplinePointsMap) == null)
				{
					result = (this._SplinePointsMap = new TMap<int, FSplinePoint>(base.NativePtr + (IntPtr)BP_SkillTrackCurve_C.__PropertyOffset_SplinePointsMap, this));
				}
				return result;
			}
			set
			{
				this.SplinePointsMap.CopyAssign(value);
			}
		}

		// Token: 0x06020738 RID: 132920 RVA: 0x00946EDB File Offset: 0x009450DB
		[SkipLocalsInit]
		public virtual void UpdateSplineData()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_SkillTrackCurve_C.__UpdateSplineData_NativeFunctionPtr, null);
		}

		// Token: 0x06020739 RID: 132921 RVA: 0x00946EEF File Offset: 0x009450EF
		protected BP_SkillTrackCurve_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401187F RID: 71807
		public new const string __ObjectPath = "/Game/Aki/Character/Role/FemaleM/Zhezhi/Data/BP_SkillTrackCurve.BP_SkillTrackCurve_C";

		// Token: 0x04011880 RID: 71808
		private static IntPtr _ClassPtr;

		// Token: 0x04011881 RID: 71809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011882 RID: 71810
		internal static int __PropertyOffset_Spline;

		// Token: 0x04011883 RID: 71811
		internal static int __PropertyOffset_SplinePointsNum;

		// Token: 0x04011884 RID: 71812
		internal static int __PropertyOffset_SplinePointsIndex;

		// Token: 0x04011885 RID: 71813
		internal static int __PropertyOffset_SplinePointsMap;

		// Token: 0x04011886 RID: 71814
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FSplinePoint> _SplinePointsMap;

		// Token: 0x04011887 RID: 71815
		private static IntPtr __UpdateSplineData_NativeFunctionPtr;
	}
}
