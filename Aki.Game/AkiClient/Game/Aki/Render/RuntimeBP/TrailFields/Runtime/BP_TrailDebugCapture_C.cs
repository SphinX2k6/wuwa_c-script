using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.TrailFields.Runtime
{
	// Token: 0x02003AA7 RID: 15015
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDebugCapture.BP_TrailDebugCapture_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_TrailDebugCapture_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602023F RID: 131647 RVA: 0x008CAC5A File Offset: 0x008C8E5A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_TrailDebugCapture_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDebugCapture.BP_TrailDebugCapture_C");
			}
			return BP_TrailDebugCapture_C._ClassPtr;
		}

		// Token: 0x06020240 RID: 131648 RVA: 0x008CAC80 File Offset: 0x008C8E80
		public BP_TrailDebugCapture_C() : this(BuiltinUtils.AllocNativeUObject(BP_TrailDebugCapture_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020241 RID: 131649 RVA: 0x008CACA8 File Offset: 0x008C8EA8
		[NullableContext(1)]
		public BP_TrailDebugCapture_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_TrailDebugCapture_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06020242 RID: 131650 RVA: 0x008CACDB File Offset: 0x008C8EDB
		// (set) Token: 0x06020243 RID: 131651 RVA: 0x008CACEF File Offset: 0x008C8EEF
		public unsafe USceneCaptureComponent2D SceneCaptureComponent2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneCaptureComponent2D>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugCapture_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugCapture_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x06020244 RID: 131652 RVA: 0x008CAD04 File Offset: 0x008C8F04
		// (set) Token: 0x06020245 RID: 131653 RVA: 0x008CAD18 File Offset: 0x008C8F18
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugCapture_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugCapture_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x06020246 RID: 131654 RVA: 0x008CAD2D File Offset: 0x008C8F2D
		// (set) Token: 0x06020247 RID: 131655 RVA: 0x008CAD41 File Offset: 0x008C8F41
		public unsafe AActor CaptureActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugCapture_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_TrailDebugCapture_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x06020248 RID: 131656 RVA: 0x008CAD56 File Offset: 0x008C8F56
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void StartCapture()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_TrailDebugCapture_C.__StartCapture_NativeFunctionPtr, null);
		}

		// Token: 0x06020249 RID: 131657 RVA: 0x008CAD6A File Offset: 0x008C8F6A
		protected BP_TrailDebugCapture_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F871 RID: 63601
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/TrailFields/Runtime/BP_TrailDebugCapture.BP_TrailDebugCapture_C";

		// Token: 0x0400F872 RID: 63602
		private static IntPtr _ClassPtr;

		// Token: 0x0400F873 RID: 63603
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F874 RID: 63604
		internal static int __PropertyOffset_0;

		// Token: 0x0400F875 RID: 63605
		internal static int __PropertyOffset_1;

		// Token: 0x0400F876 RID: 63606
		internal static int __PropertyOffset_2;

		// Token: 0x0400F877 RID: 63607
		private static IntPtr __StartCapture_NativeFunctionPtr;
	}
}
