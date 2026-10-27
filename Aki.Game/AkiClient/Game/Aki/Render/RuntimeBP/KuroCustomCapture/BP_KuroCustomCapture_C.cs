using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroCustomCapture
{
	// Token: 0x02003D05 RID: 15621
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroCustomCapture/BP_KuroCustomCapture.BP_KuroCustomCapture_C")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class BP_KuroCustomCapture_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060255AF RID: 153007 RVA: 0x00957BCE File Offset: 0x00955DCE
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroCustomCapture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroCustomCapture/BP_KuroCustomCapture.BP_KuroCustomCapture_C");
			}
			return BP_KuroCustomCapture_C._ClassPtr;
		}

		// Token: 0x060255B0 RID: 153008 RVA: 0x00957BF4 File Offset: 0x00955DF4
		public BP_KuroCustomCapture_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroCustomCapture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060255B1 RID: 153009 RVA: 0x00957C1C File Offset: 0x00955E1C
		[NullableContext(1)]
		public BP_KuroCustomCapture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroCustomCapture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x060255B2 RID: 153010 RVA: 0x00957C4F File Offset: 0x00955E4F
		// (set) Token: 0x060255B3 RID: 153011 RVA: 0x00957C63 File Offset: 0x00955E63
		public unsafe UBoxComponent Box
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x060255B4 RID: 153012 RVA: 0x00957C78 File Offset: 0x00955E78
		// (set) Token: 0x060255B5 RID: 153013 RVA: 0x00957C8C File Offset: 0x00955E8C
		public unsafe UKuroCustomCaptureVolume KuroCustomCaptureVolume
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCustomCaptureVolume>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17004C36 RID: 19510
		// (get) Token: 0x060255B6 RID: 153014 RVA: 0x00957CA1 File Offset: 0x00955EA1
		// (set) Token: 0x060255B7 RID: 153015 RVA: 0x00957CB5 File Offset: 0x00955EB5
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x060255B8 RID: 153016 RVA: 0x00957CCA File Offset: 0x00955ECA
		// (set) Token: 0x060255B9 RID: 153017 RVA: 0x00957CDA File Offset: 0x00955EDA
		public unsafe bool bCapture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomCapture_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomCapture_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x060255BA RID: 153018 RVA: 0x00957CEB File Offset: 0x00955EEB
		// (set) Token: 0x060255BB RID: 153019 RVA: 0x00957CFF File Offset: 0x00955EFF
		[Nullable(0)]
		public unsafe TEnumAsByte<ECaptureMode> CaptureMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_KuroCustomCapture_C.__PropertyOffset_4);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_KuroCustomCapture_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17004C39 RID: 19513
		// (get) Token: 0x060255BC RID: 153020 RVA: 0x00957D14 File Offset: 0x00955F14
		// (set) Token: 0x060255BD RID: 153021 RVA: 0x00957D28 File Offset: 0x00955F28
		public unsafe UTextureRenderTarget2D RT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroCustomCapture_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x060255BE RID: 153022 RVA: 0x00957D3D File Offset: 0x00955F3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroCustomCapture_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060255BF RID: 153023 RVA: 0x00957D51 File Offset: 0x00955F51
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroCustomCapture_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060255C0 RID: 153024 RVA: 0x00957D66 File Offset: 0x00955F66
		protected BP_KuroCustomCapture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A11 RID: 76305
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroCustomCapture/BP_KuroCustomCapture.BP_KuroCustomCapture_C";

		// Token: 0x04012A12 RID: 76306
		private static IntPtr _ClassPtr;

		// Token: 0x04012A13 RID: 76307
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A14 RID: 76308
		internal static int __PropertyOffset_0;

		// Token: 0x04012A15 RID: 76309
		internal static int __PropertyOffset_1;

		// Token: 0x04012A16 RID: 76310
		internal static int __PropertyOffset_2;

		// Token: 0x04012A17 RID: 76311
		internal static int __PropertyOffset_3;

		// Token: 0x04012A18 RID: 76312
		internal static int __PropertyOffset_4;

		// Token: 0x04012A19 RID: 76313
		internal static int __PropertyOffset_5;

		// Token: 0x04012A1A RID: 76314
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
