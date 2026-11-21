using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.AssistedWalk
{
	// Token: 0x020031CF RID: 12751
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Level/AssistedWalk/BP_AssistedWalkConfig.BP_AssistedWalkConfig_C")]
	[UnrealStructLayout(304, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class BP_AssistedWalkConfig_C : BP_AttachMoveConfig_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F9A6 RID: 129446 RVA: 0x00931491 File Offset: 0x0092F691
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AssistedWalkConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/AssistedWalk/BP_AssistedWalkConfig.BP_AssistedWalkConfig_C");
			}
			return BP_AssistedWalkConfig_C._ClassPtr;
		}

		// Token: 0x0601F9A7 RID: 129447 RVA: 0x009314B8 File Offset: 0x0092F6B8
		public BP_AssistedWalkConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_AssistedWalkConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F9A8 RID: 129448 RVA: 0x009314E0 File Offset: 0x0092F6E0
		public BP_AssistedWalkConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AssistedWalkConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0601F9A9 RID: 129449 RVA: 0x00931513 File Offset: 0x0092F713
		// (set) Token: 0x0601F9AA RID: 129450 RVA: 0x00931523 File Offset: 0x0092F723
		public unsafe int BaseMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_BaseMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_BaseMoveSpeed) = value;
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0601F9AB RID: 129451 RVA: 0x00931534 File Offset: 0x0092F734
		// (set) Token: 0x0601F9AC RID: 129452 RVA: 0x00931544 File Offset: 0x0092F744
		public unsafe int LeaderTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_LeaderTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_LeaderTurnSpeed) = value;
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0601F9AD RID: 129453 RVA: 0x00931555 File Offset: 0x0092F755
		// (set) Token: 0x0601F9AE RID: 129454 RVA: 0x00931569 File Offset: 0x0092F769
		public unsafe FTransform StartTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_StartTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_StartTransform) = value;
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0601F9AF RID: 129455 RVA: 0x0093157E File Offset: 0x0092F77E
		// (set) Token: 0x0601F9B0 RID: 129456 RVA: 0x00931592 File Offset: 0x0092F792
		public unsafe FVector2D AnimSpeedRateRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_AnimSpeedRateRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_AnimSpeedRateRange) = value;
			}
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0601F9B1 RID: 129457 RVA: 0x009315A8 File Offset: 0x0092F7A8
		// (set) Token: 0x0601F9B2 RID: 129458 RVA: 0x009315E1 File Offset: 0x0092F7E1
		public FGameplayTagContainer LeaderGameplayTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._LeaderGameplayTagList) == null)
				{
					result = (this._LeaderGameplayTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_LeaderGameplayTagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_AssistedWalkConfig_C.__PropertyOffset_LeaderGameplayTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601F9B3 RID: 129459 RVA: 0x00931602 File Offset: 0x0092F802
		protected BP_AssistedWalkConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F3C RID: 69436
		public new const string __ObjectPath = "/Game/Aki/Data/Level/AssistedWalk/BP_AssistedWalkConfig.BP_AssistedWalkConfig_C";

		// Token: 0x04010F3D RID: 69437
		private static IntPtr _ClassPtr;

		// Token: 0x04010F3E RID: 69438
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F3F RID: 69439
		internal static int __PropertyOffset_BaseMoveSpeed;

		// Token: 0x04010F40 RID: 69440
		internal static int __PropertyOffset_LeaderTurnSpeed;

		// Token: 0x04010F41 RID: 69441
		internal static int __PropertyOffset_StartTransform;

		// Token: 0x04010F42 RID: 69442
		internal static int __PropertyOffset_AnimSpeedRateRange;

		// Token: 0x04010F43 RID: 69443
		internal static int __PropertyOffset_LeaderGameplayTagList;

		// Token: 0x04010F44 RID: 69444
		[Nullable(2)]
		private FGameplayTagContainer _LeaderGameplayTagList;
	}
}
