using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E0 RID: 13024
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_BasePlatform.BP_BasePlatform_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_BasePlatform_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602111E RID: 135454 RVA: 0x009583E6 File Offset: 0x009565E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_BasePlatform_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_BasePlatform.BP_BasePlatform_C");
			}
			return BP_BasePlatform_C._ClassPtr;
		}

		// Token: 0x0602111F RID: 135455 RVA: 0x0095840C File Offset: 0x0095660C
		public BP_BasePlatform_C() : this(BuiltinUtils.AllocNativeUObject(BP_BasePlatform_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021120 RID: 135456 RVA: 0x00958434 File Offset: 0x00956634
		[NullableContext(1)]
		public BP_BasePlatform_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_BasePlatform_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x06021121 RID: 135457 RVA: 0x00958467 File Offset: 0x00956667
		// (set) Token: 0x06021122 RID: 135458 RVA: 0x0095847B File Offset: 0x0095667B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePlatform_C.__PropertyOffset_DefaultSceneRoot);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_BasePlatform_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x06021123 RID: 135459 RVA: 0x00958490 File Offset: 0x00956690
		// (set) Token: 0x06021124 RID: 135460 RVA: 0x009584A0 File Offset: 0x009566A0
		public unsafe float LeaveSphereRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_LeaveSphereRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_LeaveSphereRadius) = value;
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x06021125 RID: 135461 RVA: 0x009584B1 File Offset: 0x009566B1
		// (set) Token: 0x06021126 RID: 135462 RVA: 0x009584C5 File Offset: 0x009566C5
		public unsafe FVector LeaveSphereCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_LeaveSphereCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_BasePlatform_C.__PropertyOffset_LeaveSphereCenter) = value;
			}
		}

		// Token: 0x06021127 RID: 135463 RVA: 0x009584DA File Offset: 0x009566DA
		protected BP_BasePlatform_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F0E RID: 73486
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_BasePlatform.BP_BasePlatform_C";

		// Token: 0x04011F0F RID: 73487
		private static IntPtr _ClassPtr;

		// Token: 0x04011F10 RID: 73488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F11 RID: 73489
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04011F12 RID: 73490
		internal static int __PropertyOffset_LeaveSphereRadius;

		// Token: 0x04011F13 RID: 73491
		internal static int __PropertyOffset_LeaveSphereCenter;
	}
}
