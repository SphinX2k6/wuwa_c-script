using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.GI.UI;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.UI
{
	// Token: 0x02003AA1 RID: 15009
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/UI/BP_UIScene.BP_UIScene_C")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1065)]
	public class BP_UIScene_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060201CE RID: 131534 RVA: 0x008C9F35 File Offset: 0x008C8135
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_UIScene_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/UI/BP_UIScene.BP_UIScene_C");
			}
			return BP_UIScene_C._ClassPtr;
		}

		// Token: 0x060201CF RID: 131535 RVA: 0x008C9F5C File Offset: 0x008C815C
		public BP_UIScene_C() : this(BuiltinUtils.AllocNativeUObject(BP_UIScene_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060201D0 RID: 131536 RVA: 0x008C9F84 File Offset: 0x008C8184
		[NullableContext(1)]
		public BP_UIScene_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_UIScene_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x060201D1 RID: 131537 RVA: 0x008C9FB7 File Offset: 0x008C81B7
		// (set) Token: 0x060201D2 RID: 131538 RVA: 0x008C9FCB File Offset: 0x008C81CB
		public unsafe UKuroPostProcessComponent KuroPostProcess
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPostProcessComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIScene_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIScene_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x060201D3 RID: 131539 RVA: 0x008C9FE0 File Offset: 0x008C81E0
		// (set) Token: 0x060201D4 RID: 131540 RVA: 0x008C9FF4 File Offset: 0x008C81F4
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIScene_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIScene_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17002F0A RID: 12042
		// (get) Token: 0x060201D5 RID: 131541 RVA: 0x008CA009 File Offset: 0x008C8209
		// (set) Token: 0x060201D6 RID: 131542 RVA: 0x008CA01D File Offset: 0x008C821D
		public unsafe PDA_GIUIData_C GIUIData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<PDA_GIUIData_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIScene_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_UIScene_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x17002F0B RID: 12043
		// (get) Token: 0x060201D7 RID: 131543 RVA: 0x008CA032 File Offset: 0x008C8232
		// (set) Token: 0x060201D8 RID: 131544 RVA: 0x008CA042 File Offset: 0x008C8242
		public unsafe bool IsNewUiScene
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_UIScene_C.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_UIScene_C.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x060201D9 RID: 131545 RVA: 0x008CA053 File Offset: 0x008C8253
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_UIScene_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060201DA RID: 131546 RVA: 0x008CA067 File Offset: 0x008C8267
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_UIScene_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060201DB RID: 131547 RVA: 0x008CA07C File Offset: 0x008C827C
		protected BP_UIScene_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F82F RID: 63535
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/UI/BP_UIScene.BP_UIScene_C";

		// Token: 0x0400F830 RID: 63536
		private static IntPtr _ClassPtr;

		// Token: 0x0400F831 RID: 63537
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F832 RID: 63538
		internal static int __PropertyOffset_0;

		// Token: 0x0400F833 RID: 63539
		internal static int __PropertyOffset_1;

		// Token: 0x0400F834 RID: 63540
		internal static int __PropertyOffset_2;

		// Token: 0x0400F835 RID: 63541
		internal static int __PropertyOffset_3;

		// Token: 0x0400F836 RID: 63542
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;
	}
}
