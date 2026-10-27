using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroVolumetricCloud
{
	// Token: 0x02003CFF RID: 15615
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroVolumetricCloud/BP_KuroVolumetricCloud.BP_KuroVolumetricCloud_C")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class BP_KuroVolumetricCloud_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060254D5 RID: 152789 RVA: 0x00956653 File Offset: 0x00954853
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_KuroVolumetricCloud_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroVolumetricCloud/BP_KuroVolumetricCloud.BP_KuroVolumetricCloud_C");
			}
			return BP_KuroVolumetricCloud_C._ClassPtr;
		}

		// Token: 0x060254D6 RID: 152790 RVA: 0x00956678 File Offset: 0x00954878
		public BP_KuroVolumetricCloud_C() : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumetricCloud_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060254D7 RID: 152791 RVA: 0x009566A0 File Offset: 0x009548A0
		[NullableContext(1)]
		public BP_KuroVolumetricCloud_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_KuroVolumetricCloud_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BE9 RID: 19433
		// (get) Token: 0x060254D8 RID: 152792 RVA: 0x009566D3 File Offset: 0x009548D3
		// (set) Token: 0x060254D9 RID: 152793 RVA: 0x009566E7 File Offset: 0x009548E7
		[Nullable(2)]
		public unsafe UKuroVolumetricCloudComponent KuroVolumetricCloud
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVolumetricCloudComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumetricCloud_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_KuroVolumetricCloud_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x060254DA RID: 152794 RVA: 0x009566FC File Offset: 0x009548FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_KuroVolumetricCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060254DB RID: 152795 RVA: 0x00956710 File Offset: 0x00954910
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_KuroVolumetricCloud_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060254DC RID: 152796 RVA: 0x00956725 File Offset: 0x00954925
		protected BP_KuroVolumetricCloud_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012986 RID: 76166
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroVolumetricCloud/BP_KuroVolumetricCloud.BP_KuroVolumetricCloud_C";

		// Token: 0x04012987 RID: 76167
		private static IntPtr _ClassPtr;

		// Token: 0x04012988 RID: 76168
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012989 RID: 76169
		internal static int __PropertyOffset_1;

		// Token: 0x0401298A RID: 76170
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;
	}
}
