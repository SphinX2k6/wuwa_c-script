using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Common.DollMachine
{
	// Token: 0x02003B70 RID: 15216
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItemsPool.BP_DollItemsPool_C")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class BP_DollItemsPool_C : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021DD8 RID: 138712 RVA: 0x008F80CC File Offset: 0x008F62CC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_DollItemsPool_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItemsPool.BP_DollItemsPool_C");
			}
			return BP_DollItemsPool_C._ClassPtr;
		}

		// Token: 0x06021DD9 RID: 138713 RVA: 0x008F80F0 File Offset: 0x008F62F0
		public BP_DollItemsPool_C() : this(BuiltinUtils.AllocNativeUObject(BP_DollItemsPool_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021DDA RID: 138714 RVA: 0x008F8118 File Offset: 0x008F6318
		[NullableContext(1)]
		public BP_DollItemsPool_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_DollItemsPool_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x06021DDB RID: 138715 RVA: 0x008F814B File Offset: 0x008F634B
		// (set) Token: 0x06021DDC RID: 138716 RVA: 0x008F815F File Offset: 0x008F635F
		[Nullable(2)]
		public unsafe USceneComponent DefaultSceneRoot
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItemsPool_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_DollItemsPool_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x06021DDD RID: 138717 RVA: 0x008F8174 File Offset: 0x008F6374
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 重置并重分配物品ID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItemsPool_C.__重置并重分配物品ID_NativeFunctionPtr, null);
		}

		// Token: 0x06021DDE RID: 138718 RVA: 0x008F8188 File Offset: 0x008F6388
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 分配物件ID()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_DollItemsPool_C.__分配物件ID_NativeFunctionPtr, null);
		}

		// Token: 0x06021DDF RID: 138719 RVA: 0x008F819C File Offset: 0x008F639C
		protected BP_DollItemsPool_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040108C2 RID: 67778
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Common/DollMachine/BP_DollItemsPool.BP_DollItemsPool_C";

		// Token: 0x040108C3 RID: 67779
		private static IntPtr _ClassPtr;

		// Token: 0x040108C4 RID: 67780
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040108C5 RID: 67781
		internal static int __PropertyOffset_0;

		// Token: 0x040108C6 RID: 67782
		private static IntPtr __重置并重分配物品ID_NativeFunctionPtr;

		// Token: 0x040108C7 RID: 67783
		private static IntPtr __分配物件ID_NativeFunctionPtr;
	}
}
