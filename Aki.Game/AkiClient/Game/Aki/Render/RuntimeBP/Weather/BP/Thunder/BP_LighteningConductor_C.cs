using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A7F RID: 14975
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_LighteningConductor.BP_LighteningConductor_C")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class BP_LighteningConductor_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC4A RID: 130122 RVA: 0x008C1FE8 File Offset: 0x008C01E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_LighteningConductor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_LighteningConductor.BP_LighteningConductor_C");
			}
			return BP_LighteningConductor_C._ClassPtr;
		}

		// Token: 0x0601FC4B RID: 130123 RVA: 0x008C200C File Offset: 0x008C020C
		public BP_LighteningConductor_C() : this(BuiltinUtils.AllocNativeUObject(BP_LighteningConductor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC4C RID: 130124 RVA: 0x008C2034 File Offset: 0x008C0234
		[NullableContext(1)]
		public BP_LighteningConductor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_LighteningConductor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x0601FC4D RID: 130125 RVA: 0x008C2067 File Offset: 0x008C0267
		// (set) Token: 0x0601FC4E RID: 130126 RVA: 0x008C207B File Offset: 0x008C027B
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_LighteningConductor_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_LighteningConductor_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601FC4F RID: 130127 RVA: 0x008C2090 File Offset: 0x008C0290
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Thunder()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LighteningConductor_C.__Thunder_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC50 RID: 130128 RVA: 0x008C20A4 File Offset: 0x008C02A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Lightening()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_LighteningConductor_C.__Lightening_NativeFunctionPtr, null);
		}

		// Token: 0x0601FC51 RID: 130129 RVA: 0x008C20B8 File Offset: 0x008C02B8
		protected BP_LighteningConductor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F4E7 RID: 62695
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/BP_LighteningConductor.BP_LighteningConductor_C";

		// Token: 0x0400F4E8 RID: 62696
		private static IntPtr _ClassPtr;

		// Token: 0x0400F4E9 RID: 62697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F4EA RID: 62698
		internal static int __PropertyOffset_0;

		// Token: 0x0400F4EB RID: 62699
		private static IntPtr __Thunder_NativeFunctionPtr;

		// Token: 0x0400F4EC RID: 62700
		private static IntPtr __Lightening_NativeFunctionPtr;
	}
}
