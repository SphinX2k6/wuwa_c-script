using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.ShadowSpotLight
{
	// Token: 0x02003C02 RID: 15362
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/ShadowSpotLight/BP_CaptureDepthForShadow.BP_CaptureDepthForShadow_C")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class BP_CaptureDepthForShadow_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F94 RID: 143252 RVA: 0x009174D2 File Offset: 0x009156D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_CaptureDepthForShadow_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/ShadowSpotLight/BP_CaptureDepthForShadow.BP_CaptureDepthForShadow_C");
			}
			return BP_CaptureDepthForShadow_C._ClassPtr;
		}

		// Token: 0x06022F95 RID: 143253 RVA: 0x009174F8 File Offset: 0x009156F8
		public BP_CaptureDepthForShadow_C() : this(BuiltinUtils.AllocNativeUObject(BP_CaptureDepthForShadow_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F96 RID: 143254 RVA: 0x00917520 File Offset: 0x00915720
		public BP_CaptureDepthForShadow_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_CaptureDepthForShadow_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EC1 RID: 16065
		// (get) Token: 0x06022F97 RID: 143255 RVA: 0x00917553 File Offset: 0x00915753
		// (set) Token: 0x06022F98 RID: 143256 RVA: 0x00917567 File Offset: 0x00915767
		[Nullable(2)]
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaptureDepthForShadow_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaptureDepthForShadow_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x06022F99 RID: 143257 RVA: 0x0091757C File Offset: 0x0091577C
		// (set) Token: 0x06022F9A RID: 143258 RVA: 0x00917590 File Offset: 0x00915790
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaptureDepthForShadow_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_CaptureDepthForShadow_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x06022F9B RID: 143259 RVA: 0x009175A5 File Offset: 0x009157A5
		// (set) Token: 0x06022F9C RID: 143260 RVA: 0x009175B9 File Offset: 0x009157B9
		public unsafe string SavePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x06022F9D RID: 143261 RVA: 0x009175CE File Offset: 0x009157CE
		// (set) Token: 0x06022F9E RID: 143262 RVA: 0x009175E2 File Offset: 0x009157E2
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_3)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_3)), value);
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x06022F9F RID: 143263 RVA: 0x009175F7 File Offset: 0x009157F7
		// (set) Token: 0x06022FA0 RID: 143264 RVA: 0x0091760B File Offset: 0x0091580B
		public unsafe FLinearColor LightPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x06022FA1 RID: 143265 RVA: 0x00917620 File Offset: 0x00915820
		// (set) Token: 0x06022FA2 RID: 143266 RVA: 0x00917634 File Offset: 0x00915834
		public unsafe FLinearColor LightVec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x06022FA3 RID: 143267 RVA: 0x00917649 File Offset: 0x00915849
		// (set) Token: 0x06022FA4 RID: 143268 RVA: 0x0091765D File Offset: 0x0091585D
		public unsafe string MatSavePathTemp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_6)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_6)), value);
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x06022FA5 RID: 143269 RVA: 0x00917672 File Offset: 0x00915872
		// (set) Token: 0x06022FA6 RID: 143270 RVA: 0x00917686 File Offset: 0x00915886
		public unsafe string MatNameTemp
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_CaptureDepthForShadow_C.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x06022FA7 RID: 143271 RVA: 0x0091769B File Offset: 0x0091589B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CaptureDepth()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_CaptureDepthForShadow_C.__CaptureDepth_NativeFunctionPtr, null);
		}

		// Token: 0x06022FA8 RID: 143272 RVA: 0x009176AF File Offset: 0x009158AF
		protected BP_CaptureDepthForShadow_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011383 RID: 70531
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/ShadowSpotLight/BP_CaptureDepthForShadow.BP_CaptureDepthForShadow_C";

		// Token: 0x04011384 RID: 70532
		private static IntPtr _ClassPtr;

		// Token: 0x04011385 RID: 70533
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011386 RID: 70534
		internal static int __PropertyOffset_0;

		// Token: 0x04011387 RID: 70535
		internal static int __PropertyOffset_1;

		// Token: 0x04011388 RID: 70536
		internal static int __PropertyOffset_2;

		// Token: 0x04011389 RID: 70537
		internal static int __PropertyOffset_3;

		// Token: 0x0401138A RID: 70538
		internal static int __PropertyOffset_4;

		// Token: 0x0401138B RID: 70539
		internal static int __PropertyOffset_5;

		// Token: 0x0401138C RID: 70540
		internal static int __PropertyOffset_6;

		// Token: 0x0401138D RID: 70541
		internal static int __PropertyOffset_7;

		// Token: 0x0401138E RID: 70542
		private static IntPtr __CaptureDepth_NativeFunctionPtr;
	}
}
