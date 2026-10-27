using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x020040A8 RID: 16552
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfig.BP_FirstPersonConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 153)]
	public class BP_FirstPersonConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AB86 RID: 174982 RVA: 0x009E9E30 File Offset: 0x009E8030
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FirstPersonConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfig.BP_FirstPersonConfig_C");
			}
			return BP_FirstPersonConfig_C._ClassPtr;
		}

		// Token: 0x0602AB87 RID: 174983 RVA: 0x009E9E54 File Offset: 0x009E8054
		public BP_FirstPersonConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AB88 RID: 174984 RVA: 0x009E9E7C File Offset: 0x009E807C
		public BP_FirstPersonConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006916 RID: 26902
		// (get) Token: 0x0602AB89 RID: 174985 RVA: 0x009E9EAF File Offset: 0x009E80AF
		// (set) Token: 0x0602AB8A RID: 174986 RVA: 0x009E9EBF File Offset: 0x009E80BF
		public unsafe int ForwardAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006917 RID: 26903
		// (get) Token: 0x0602AB8B RID: 174987 RVA: 0x009E9ED0 File Offset: 0x009E80D0
		// (set) Token: 0x0602AB8C RID: 174988 RVA: 0x009E9F09 File Offset: 0x009E8109
		public FGameplayTagContainer FirstPersonTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._FirstPersonTagList) == null)
				{
					result = (this._FirstPersonTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006918 RID: 26904
		// (get) Token: 0x0602AB8D RID: 174989 RVA: 0x009E9F2C File Offset: 0x009E812C
		// (set) Token: 0x0602AB8E RID: 174990 RVA: 0x009E9F65 File Offset: 0x009E8165
		public FGameplayTagContainer ForbidRotationTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidRotationTagList) == null)
				{
					result = (this._ForbidRotationTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006919 RID: 26905
		// (get) Token: 0x0602AB8F RID: 174991 RVA: 0x009E9F86 File Offset: 0x009E8186
		// (set) Token: 0x0602AB90 RID: 174992 RVA: 0x009E9F96 File Offset: 0x009E8196
		public unsafe bool DashInForwardAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AB91 RID: 174993 RVA: 0x009E9FA7 File Offset: 0x009E81A7
		protected BP_FirstPersonConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040161C0 RID: 90560
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfig.BP_FirstPersonConfig_C";

		// Token: 0x040161C1 RID: 90561
		private static IntPtr _ClassPtr;

		// Token: 0x040161C2 RID: 90562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040161C3 RID: 90563
		internal static int __PropertyOffset_0;

		// Token: 0x040161C4 RID: 90564
		internal static int __PropertyOffset_1;

		// Token: 0x040161C5 RID: 90565
		[Nullable(2)]
		private FGameplayTagContainer _FirstPersonTagList;

		// Token: 0x040161C6 RID: 90566
		internal static int __PropertyOffset_2;

		// Token: 0x040161C7 RID: 90567
		[Nullable(2)]
		private FGameplayTagContainer _ForbidRotationTagList;

		// Token: 0x040161C8 RID: 90568
		internal static int __PropertyOffset_3;
	}
}
