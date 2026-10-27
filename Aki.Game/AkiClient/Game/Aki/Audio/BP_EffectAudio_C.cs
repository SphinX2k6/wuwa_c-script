using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Audio
{
	// Token: 0x02004430 RID: 17456
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Audio/BP_EffectAudio.BP_EffectAudio_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_EffectAudio_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602D2D6 RID: 185046 RVA: 0x00A35597 File Offset: 0x00A33797
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectAudio_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Audio/BP_EffectAudio.BP_EffectAudio_C");
			}
			return BP_EffectAudio_C._ClassPtr;
		}

		// Token: 0x0602D2D7 RID: 185047 RVA: 0x00A355BC File Offset: 0x00A337BC
		public BP_EffectAudio_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectAudio_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602D2D8 RID: 185048 RVA: 0x00A355E4 File Offset: 0x00A337E4
		[NullableContext(1)]
		public BP_EffectAudio_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectAudio_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007266 RID: 29286
		// (get) Token: 0x0602D2D9 RID: 185049 RVA: 0x00A35617 File Offset: 0x00A33817
		// (set) Token: 0x0602D2DA RID: 185050 RVA: 0x00A3562B File Offset: 0x00A3382B
		public unsafe UAkComponent AkComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17007267 RID: 29287
		// (get) Token: 0x0602D2DB RID: 185051 RVA: 0x00A35640 File Offset: 0x00A33840
		// (set) Token: 0x0602D2DC RID: 185052 RVA: 0x00A35654 File Offset: 0x00A33854
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_EffectAudio_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x0602D2DD RID: 185053 RVA: 0x00A35669 File Offset: 0x00A33869
		protected BP_EffectAudio_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401801B RID: 98331
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Audio/BP_EffectAudio.BP_EffectAudio_C";

		// Token: 0x0401801C RID: 98332
		private static IntPtr _ClassPtr;

		// Token: 0x0401801D RID: 98333
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401801E RID: 98334
		internal static int __PropertyOffset_0;

		// Token: 0x0401801F RID: 98335
		internal static int __PropertyOffset_1;
	}
}
