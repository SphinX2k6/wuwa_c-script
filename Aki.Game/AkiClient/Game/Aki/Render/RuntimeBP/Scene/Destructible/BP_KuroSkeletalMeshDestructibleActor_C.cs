using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Scene.Destructible
{
	// Token: 0x02003B59 RID: 15193
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Scene/Destructible/BP_KuroSkeletalMeshDestructibleActor.BP_KuroSkeletalMeshDestructibleActor_C")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class BP_KuroSkeletalMeshDestructibleActor_C : AKuroDestructibleActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021AFE RID: 137982 RVA: 0x008F3145 File Offset: 0x008F1345
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroSkeletalMeshDestructibleActor_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Scene/Destructible/BP_KuroSkeletalMeshDestructibleActor.BP_KuroSkeletalMeshDestructibleActor_C");
			}
			return BP_KuroSkeletalMeshDestructibleActor_C._ClassPtr;
		}

		// Token: 0x06021AFF RID: 137983 RVA: 0x008F316C File Offset: 0x008F136C
		public BP_KuroSkeletalMeshDestructibleActor_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroSkeletalMeshDestructibleActor_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021B00 RID: 137984 RVA: 0x008F3194 File Offset: 0x008F1394
		[NullableContext(1)]
		public BP_KuroSkeletalMeshDestructibleActor_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroSkeletalMeshDestructibleActor_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021B01 RID: 137985 RVA: 0x008F31C7 File Offset: 0x008F13C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显示或隐藏破碎时渲染模型()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSkeletalMeshDestructibleActor_C.__显示或隐藏破碎时渲染模型_NativeFunctionPtr, null);
		}

		// Token: 0x06021B02 RID: 137986 RVA: 0x008F31DB File Offset: 0x008F13DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显示或隐藏所有的物理模拟碎块()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSkeletalMeshDestructibleActor_C.__显示或隐藏所有的物理模拟碎块_NativeFunctionPtr, null);
		}

		// Token: 0x06021B03 RID: 137987 RVA: 0x008F31EF File Offset: 0x008F13EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 显示或隐藏代理静态模型()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSkeletalMeshDestructibleActor_C.__显示或隐藏代理静态模型_NativeFunctionPtr, null);
		}

		// Token: 0x06021B04 RID: 137988 RVA: 0x008F3203 File Offset: 0x008F1403
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 编辑时预览破碎效果()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroSkeletalMeshDestructibleActor_C.__编辑时预览破碎效果_NativeFunctionPtr, null);
		}

		// Token: 0x06021B05 RID: 137989 RVA: 0x008F3217 File Offset: 0x008F1417
		protected BP_KuroSkeletalMeshDestructibleActor_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106EB RID: 67307
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Scene/Destructible/BP_KuroSkeletalMeshDestructibleActor.BP_KuroSkeletalMeshDestructibleActor_C";

		// Token: 0x040106EC RID: 67308
		private static IntPtr _ClassPtr;

		// Token: 0x040106ED RID: 67309
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106EE RID: 67310
		private static IntPtr __显示或隐藏破碎时渲染模型_NativeFunctionPtr;

		// Token: 0x040106EF RID: 67311
		private static IntPtr __显示或隐藏所有的物理模拟碎块_NativeFunctionPtr;

		// Token: 0x040106F0 RID: 67312
		private static IntPtr __显示或隐藏代理静态模型_NativeFunctionPtr;

		// Token: 0x040106F1 RID: 67313
		private static IntPtr __编辑时预览破碎效果_NativeFunctionPtr;
	}
}
