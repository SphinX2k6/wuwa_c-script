using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.System.GlobalMapOverride
{
	// Token: 0x02003ABD RID: 15037
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/System/GlobalMapOverride/BP_KuroGlobalMapOverrideVolume.BP_KuroGlobalMapOverrideVolume_C")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class BP_KuroGlobalMapOverrideVolume_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602043D RID: 132157 RVA: 0x008CE300 File Offset: 0x008CC500
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroGlobalMapOverrideVolume_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/System/GlobalMapOverride/BP_KuroGlobalMapOverrideVolume.BP_KuroGlobalMapOverrideVolume_C");
			}
			return BP_KuroGlobalMapOverrideVolume_C._ClassPtr;
		}

		// Token: 0x0602043E RID: 132158 RVA: 0x008CE324 File Offset: 0x008CC524
		public BP_KuroGlobalMapOverrideVolume_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroGlobalMapOverrideVolume_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602043F RID: 132159 RVA: 0x008CE34C File Offset: 0x008CC54C
		[NullableContext(1)]
		public BP_KuroGlobalMapOverrideVolume_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroGlobalMapOverrideVolume_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06020440 RID: 132160 RVA: 0x008CE37F File Offset: 0x008CC57F
		// (set) Token: 0x06020441 RID: 132161 RVA: 0x008CE393 File Offset: 0x008CC593
		public unsafe UKuroGlobalMapOverrideComponent KuroGlobalMapOverride
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroGlobalMapOverrideComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroGlobalMapOverrideVolume_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroGlobalMapOverrideVolume_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x06020442 RID: 132162 RVA: 0x008CE3A8 File Offset: 0x008CC5A8
		// (set) Token: 0x06020443 RID: 132163 RVA: 0x008CE3BC File Offset: 0x008CC5BC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroGlobalMapOverrideVolume_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroGlobalMapOverrideVolume_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x06020444 RID: 132164 RVA: 0x008CE3D1 File Offset: 0x008CC5D1
		protected BP_KuroGlobalMapOverrideVolume_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F9A4 RID: 63908
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/System/GlobalMapOverride/BP_KuroGlobalMapOverrideVolume.BP_KuroGlobalMapOverrideVolume_C";

		// Token: 0x0400F9A5 RID: 63909
		private static IntPtr _ClassPtr;

		// Token: 0x0400F9A6 RID: 63910
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F9A7 RID: 63911
		internal static int __PropertyOffset_0;

		// Token: 0x0400F9A8 RID: 63912
		internal static int __PropertyOffset_1;
	}
}
