using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common
{
	// Token: 0x02003B65 RID: 15205
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/SSpineLightRuntimeData.SSpineLightRuntimeData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SSpineLightRuntimeData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021C22 RID: 138274 RVA: 0x008F5191 File Offset: 0x008F3391
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SSpineLightRuntimeData._ScriptStructPtr != 0) ? SSpineLightRuntimeData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/Scene/Common/SSpineLightRuntimeData.SSpineLightRuntimeData", ref SSpineLightRuntimeData._ScriptStructPtr);
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x06021C23 RID: 138275 RVA: 0x008F51B5 File Offset: 0x008F33B5
		// (set) Token: 0x06021C24 RID: 138276 RVA: 0x008F51C5 File Offset: 0x008F33C5
		public unsafe float LifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpineLightRuntimeData.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpineLightRuntimeData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x06021C25 RID: 138277 RVA: 0x008F51D6 File Offset: 0x008F33D6
		// (set) Token: 0x06021C26 RID: 138278 RVA: 0x008F51E6 File Offset: 0x008F33E6
		public unsafe float CurveBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpineLightRuntimeData.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpineLightRuntimeData.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x06021C27 RID: 138279 RVA: 0x008F51F7 File Offset: 0x008F33F7
		// (set) Token: 0x06021C28 RID: 138280 RVA: 0x008F5207 File Offset: 0x008F3407
		public unsafe float Age
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SSpineLightRuntimeData.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SSpineLightRuntimeData.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x06021C29 RID: 138281 RVA: 0x008F5218 File Offset: 0x008F3418
		// (set) Token: 0x06021C2A RID: 138282 RVA: 0x008F522C File Offset: 0x008F342C
		[Nullable(2)]
		public unsafe UPointLightComponent LightComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPointLightComponent>(base.NativePtr / (IntPtr)sizeof(void*) + SSpineLightRuntimeData.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SSpineLightRuntimeData.__PropertyOffset_3, value);
			}
		}

		// Token: 0x06021C2B RID: 138283 RVA: 0x008F5241 File Offset: 0x008F3441
		public SSpineLightRuntimeData()
		{
		}

		// Token: 0x06021C2C RID: 138284 RVA: 0x008F5249 File Offset: 0x008F3449
		[NullableContext(1)]
		public SSpineLightRuntimeData(float LifeTime, float CurveBias, float Age, UPointLightComponent LightComp)
		{
			this.LifeTime = LifeTime;
			this.CurveBias = CurveBias;
			this.Age = Age;
			this.LightComp = LightComp;
		}

		// Token: 0x06021C2D RID: 138285 RVA: 0x008F526E File Offset: 0x008F346E
		protected override IntPtr GetUStructPtr()
		{
			return SSpineLightRuntimeData.StaticStruct();
		}

		// Token: 0x06021C2E RID: 138286 RVA: 0x008F527A File Offset: 0x008F347A
		[NullableContext(2)]
		public SSpineLightRuntimeData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021C2F RID: 138287 RVA: 0x008F5284 File Offset: 0x008F3484
		public SSpineLightRuntimeData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021C30 RID: 138288 RVA: 0x008F528F File Offset: 0x008F348F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SSpineLightRuntimeData(Pointer, false, true);
		}

		// Token: 0x06021C31 RID: 138289 RVA: 0x008F5299 File Offset: 0x008F3499
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SSpineLightRuntimeData(Pointer, MemoryOwner);
		}

		// Token: 0x040107A4 RID: 67492
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/SSpineLightRuntimeData.SSpineLightRuntimeData";

		// Token: 0x040107A5 RID: 67493
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040107A6 RID: 67494
		internal static int __PropertyOffset_0;

		// Token: 0x040107A7 RID: 67495
		internal static int __PropertyOffset_1;

		// Token: 0x040107A8 RID: 67496
		internal static int __PropertyOffset_2;

		// Token: 0x040107A9 RID: 67497
		internal static int __PropertyOffset_3;
	}
}
