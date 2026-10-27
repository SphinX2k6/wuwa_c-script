using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.UI.Module.Common.View.Widget
{
	// Token: 0x020039D8 RID: 14808
	[UnrealObjectPath("/Game/Aki/UI/Module/Common/View/Widget/KuroButton.KuroButton_C")]
	[UnrealStructLayout(1600, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class KuroButton_C : UButton, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF92 RID: 126866 RVA: 0x008A6431 File Offset: 0x008A4631
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (KuroButton_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/UI/Module/Common/View/Widget/KuroButton.KuroButton_C");
			}
			return KuroButton_C._ClassPtr;
		}

		// Token: 0x0601EF93 RID: 126867 RVA: 0x008A6458 File Offset: 0x008A4658
		public KuroButton_C() : this(BuiltinUtils.AllocNativeUObject(KuroButton_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF94 RID: 126868 RVA: 0x008A6480 File Offset: 0x008A4680
		[NullableContext(1)]
		public KuroButton_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(KuroButton_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0601EF95 RID: 126869 RVA: 0x008A64B3 File Offset: 0x008A46B3
		// (set) Token: 0x0601EF96 RID: 126870 RVA: 0x008A64C7 File Offset: 0x008A46C7
		[Nullable(2)]
		public unsafe UAkAudioEvent 音频文件
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + KuroButton_C.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + KuroButton_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x0601EF97 RID: 126871 RVA: 0x008A64DC File Offset: 0x008A46DC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 通过文件播放音效(UAkAudioEvent 音效)
		{
			KuroButton_C.__通过文件播放音效_FunctionParams* ptr = stackalloc KuroButton_C.__通过文件播放音效_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(KuroButton_C.__通过文件播放音效_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(KuroButton_C.__通过文件播放音效_NativeFunctionPtr, (void*)ptr, 1);
			ptr->音效 = ((音效 != null) ? 音效.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, KuroButton_C.__通过文件播放音效_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EF98 RID: 126872 RVA: 0x008A6531 File Offset: 0x008A4731
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 播放音效()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, KuroButton_C.__播放音效_NativeFunctionPtr, null);
		}

		// Token: 0x0601EF99 RID: 126873 RVA: 0x008A6548 File Offset: 0x008A4748
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void 设置音频路径(UAkAudioEvent paht)
		{
			KuroButton_C.__设置音频路径_FunctionParams* ptr = stackalloc KuroButton_C.__设置音频路径_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(KuroButton_C.__设置音频路径_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(KuroButton_C.__设置音频路径_NativeFunctionPtr, (void*)ptr, 1);
			ptr->paht = ((paht != null) ? paht.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, KuroButton_C.__设置音频路径_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601EF9A RID: 126874 RVA: 0x008A659D File Offset: 0x008A479D
		protected KuroButton_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED29 RID: 60713
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/UI/Module/Common/View/Widget/KuroButton.KuroButton_C";

		// Token: 0x0400ED2A RID: 60714
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED2B RID: 60715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED2C RID: 60716
		internal static int __PropertyOffset_0;

		// Token: 0x0400ED2D RID: 60717
		private static IntPtr __通过文件播放音效_NativeFunctionPtr;

		// Token: 0x0400ED2E RID: 60718
		private static IntPtr __播放音效_NativeFunctionPtr;

		// Token: 0x0400ED2F RID: 60719
		private static IntPtr __设置音频路径_NativeFunctionPtr;

		// Token: 0x020099CE RID: 39374
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __通过文件播放音效_FunctionParams
		{
			// Token: 0x04030E9A RID: 200346
			[FieldOffset(0)]
			public IntPtr 音效;
		}

		// Token: 0x020099CF RID: 39375
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __设置音频路径_FunctionParams
		{
			// Token: 0x04030E9B RID: 200347
			[FieldOffset(0)]
			public IntPtr paht;
		}
	}
}
