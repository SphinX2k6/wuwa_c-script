using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SceneShader._3_7_InteractionBrigthComponent
{
	// Token: 0x02003C0F RID: 15375
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_InteractionBrigthComponent/BP_MeshGlowCopyComponent_Outline.BP_MeshGlowCopyComponent_Outline_C")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class BP_MeshGlowCopyComponent_Outline_C : BP_MeshGlowCopyComponent_Fresnel_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602321F RID: 143903 RVA: 0x0091B5A8 File Offset: 0x009197A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_MeshGlowCopyComponent_Outline_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_InteractionBrigthComponent/BP_MeshGlowCopyComponent_Outline.BP_MeshGlowCopyComponent_Outline_C");
			}
			return BP_MeshGlowCopyComponent_Outline_C._ClassPtr;
		}

		// Token: 0x06023220 RID: 143904 RVA: 0x0091B5CC File Offset: 0x009197CC
		public BP_MeshGlowCopyComponent_Outline_C() : this(BuiltinUtils.AllocNativeUObject(BP_MeshGlowCopyComponent_Outline_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023221 RID: 143905 RVA: 0x0091B5F4 File Offset: 0x009197F4
		[NullableContext(1)]
		public BP_MeshGlowCopyComponent_Outline_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_MeshGlowCopyComponent_Outline_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06023222 RID: 143906 RVA: 0x0091B627 File Offset: 0x00919827
		protected BP_MeshGlowCopyComponent_Outline_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114F8 RID: 70904
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SceneShader/3_7_InteractionBrigthComponent/BP_MeshGlowCopyComponent_Outline.BP_MeshGlowCopyComponent_Outline_C";

		// Token: 0x040114F9 RID: 70905
		private static IntPtr _ClassPtr;

		// Token: 0x040114FA RID: 70906
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
