using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x020033FC RID: 13308
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_EffectAudio.BP_EffectAudio_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_EffectAudio_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021C7D RID: 138365 RVA: 0x0096ADB3 File Offset: 0x00968FB3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectAudio_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_EffectAudio.BP_EffectAudio_C");
			}
			return BP_EffectAudio_C._ClassPtr;
		}

		// Token: 0x06021C7E RID: 138366 RVA: 0x0096ADD8 File Offset: 0x00968FD8
		public BP_EffectAudio_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectAudio_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021C7F RID: 138367 RVA: 0x0096AE00 File Offset: 0x00969000
		[NullableContext(1)]
		public BP_EffectAudio_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectAudio_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x06021C80 RID: 138368 RVA: 0x0096AE33 File Offset: 0x00969033
		// (set) Token: 0x06021C81 RID: 138369 RVA: 0x0096AE47 File Offset: 0x00969047
		public unsafe UAkComponent AkComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_AkComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_AkComponent, value);
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x06021C82 RID: 138370 RVA: 0x0096AE5C File Offset: 0x0096905C
		// (set) Token: 0x06021C83 RID: 138371 RVA: 0x0096AE70 File Offset: 0x00969070
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x06021C84 RID: 138372 RVA: 0x0096AE85 File Offset: 0x00969085
		protected BP_EffectAudio_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129EE RID: 76270
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_EffectAudio.BP_EffectAudio_C";

		// Token: 0x040129EF RID: 76271
		private static IntPtr _ClassPtr;

		// Token: 0x040129F0 RID: 76272
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129F1 RID: 76273
		internal static int __PropertyOffset_AkComponent;

		// Token: 0x040129F2 RID: 76274
		internal static int __PropertyOffset_DefaultSceneRoot;
	}
}
