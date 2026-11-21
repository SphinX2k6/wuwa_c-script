using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.Data.Structure
{
	// Token: 0x0200329F RID: 12959
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfig.BP_FirstPersonConfig_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 153)]
	public class BP_FirstPersonConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020903 RID: 133379 RVA: 0x00949E00 File Offset: 0x00948000
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FirstPersonConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfig.BP_FirstPersonConfig_C");
			}
			return BP_FirstPersonConfig_C._ClassPtr;
		}

		// Token: 0x06020904 RID: 133380 RVA: 0x00949E24 File Offset: 0x00948024
		public BP_FirstPersonConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020905 RID: 133381 RVA: 0x00949E4C File Offset: 0x0094804C
		public BP_FirstPersonConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FirstPersonConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x06020906 RID: 133382 RVA: 0x00949E7F File Offset: 0x0094807F
		// (set) Token: 0x06020907 RID: 133383 RVA: 0x00949E8F File Offset: 0x0094808F
		public unsafe int ForwardAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_ForwardAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_ForwardAngle) = value;
			}
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x06020908 RID: 133384 RVA: 0x00949EA0 File Offset: 0x009480A0
		// (set) Token: 0x06020909 RID: 133385 RVA: 0x00949ED9 File Offset: 0x009480D9
		public FGameplayTagContainer FirstPersonTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._FirstPersonTagList) == null)
				{
					result = (this._FirstPersonTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_FirstPersonTagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_FirstPersonTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x0602090A RID: 133386 RVA: 0x00949EFC File Offset: 0x009480FC
		// (set) Token: 0x0602090B RID: 133387 RVA: 0x00949F35 File Offset: 0x00948135
		public FGameplayTagContainer ForbidRotationTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidRotationTagList) == null)
				{
					result = (this._ForbidRotationTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_ForbidRotationTagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_ForbidRotationTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x0602090C RID: 133388 RVA: 0x00949F56 File Offset: 0x00948156
		// (set) Token: 0x0602090D RID: 133389 RVA: 0x00949F66 File Offset: 0x00948166
		public unsafe bool DashInForwardAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_DashInForwardAngle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FirstPersonConfig_C.__PropertyOffset_DashInForwardAngle) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602090E RID: 133390 RVA: 0x00949F77 File Offset: 0x00948177
		protected BP_FirstPersonConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401199E RID: 72094
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/Data/Structure/BP_FirstPersonConfig.BP_FirstPersonConfig_C";

		// Token: 0x0401199F RID: 72095
		private static IntPtr _ClassPtr;

		// Token: 0x040119A0 RID: 72096
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119A1 RID: 72097
		internal static int __PropertyOffset_ForwardAngle;

		// Token: 0x040119A2 RID: 72098
		internal static int __PropertyOffset_FirstPersonTagList;

		// Token: 0x040119A3 RID: 72099
		[Nullable(2)]
		private FGameplayTagContainer _FirstPersonTagList;

		// Token: 0x040119A4 RID: 72100
		internal static int __PropertyOffset_ForbidRotationTagList;

		// Token: 0x040119A5 RID: 72101
		[Nullable(2)]
		private FGameplayTagContainer _ForbidRotationTagList;

		// Token: 0x040119A6 RID: 72102
		internal static int __PropertyOffset_DashInForwardAngle;
	}
}
