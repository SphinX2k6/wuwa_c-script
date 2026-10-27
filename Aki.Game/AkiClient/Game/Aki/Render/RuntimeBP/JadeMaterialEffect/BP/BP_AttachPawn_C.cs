using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.JadeMaterialEffect.BP
{
	// Token: 0x02003D06 RID: 15622
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/JadeMaterialEffect/BP/BP_AttachPawn.BP_AttachPawn_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_AttachPawn_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060255C1 RID: 153025 RVA: 0x00957D6F File Offset: 0x00955F6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_AttachPawn_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/JadeMaterialEffect/BP/BP_AttachPawn.BP_AttachPawn_C");
			}
			return BP_AttachPawn_C._ClassPtr;
		}

		// Token: 0x060255C2 RID: 153026 RVA: 0x00957D94 File Offset: 0x00955F94
		public BP_AttachPawn_C() : this(BuiltinUtils.AllocNativeUObject(BP_AttachPawn_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060255C3 RID: 153027 RVA: 0x00957DBC File Offset: 0x00955FBC
		[NullableContext(1)]
		public BP_AttachPawn_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_AttachPawn_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C3A RID: 19514
		// (get) Token: 0x060255C4 RID: 153028 RVA: 0x00957DEF File Offset: 0x00955FEF
		// (set) Token: 0x060255C5 RID: 153029 RVA: 0x00957E03 File Offset: 0x00956003
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_AttachPawn_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_AttachPawn_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x060255C6 RID: 153030 RVA: 0x00957E18 File Offset: 0x00956018
		protected BP_AttachPawn_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A1B RID: 76315
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/JadeMaterialEffect/BP/BP_AttachPawn.BP_AttachPawn_C";

		// Token: 0x04012A1C RID: 76316
		private static IntPtr _ClassPtr;

		// Token: 0x04012A1D RID: 76317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012A1E RID: 76318
		internal static int __PropertyOffset_0;
	}
}
