using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02004343 RID: 17219
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/BPL_BulletPreview.BPL_BulletPreview_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_BulletPreview_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CA87 RID: 182919 RVA: 0x00A2519F File Offset: 0x00A2339F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_BulletPreview_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Tools/BPL_BulletPreview.BPL_BulletPreview_C");
			}
			return BPL_BulletPreview_C._ClassPtr;
		}

		// Token: 0x0602CA88 RID: 182920 RVA: 0x00A251C4 File Offset: 0x00A233C4
		public BPL_BulletPreview_C() : this(BuiltinUtils.AllocNativeUObject(BPL_BulletPreview_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CA89 RID: 182921 RVA: 0x00A251EC File Offset: 0x00A233EC
		[NullableContext(1)]
		public BPL_BulletPreview_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_BulletPreview_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CA8A RID: 182922 RVA: 0x00A25220 File Offset: 0x00A23420
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ShowBulletPreview([Nullable(1)] string 子弹表路径, FName 子弹ID, AActor 拥有者, USkeletalMeshComponent meshComp, UObject __WorldContext, ref AActor Ret)
		{
			BPL_BulletPreview_C.StaticClass();
			BPL_BulletPreview_C.__ShowBulletPreview_FunctionParams* ptr = stackalloc BPL_BulletPreview_C.__ShowBulletPreview_FunctionParams[(UIntPtr)4175] + 15L / (long)sizeof(BPL_BulletPreview_C.__ShowBulletPreview_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_BulletPreview_C.__ShowBulletPreview_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->子弹表路径), 子弹表路径);
			ptr->子弹ID = 子弹ID;
			ptr->拥有者 = ((拥有者 != null) ? 拥有者.NativePtr : IntPtr.Zero);
			ptr->meshComp = ((meshComp != null) ? meshComp.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			ref BPL_BulletPreview_C.__ShowBulletPreview_FunctionParams ptr2 = ref *ptr;
			AActor aactor = Ret;
			ptr2.Ret = ((aactor != null) ? aactor.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_BulletPreview_C._ClassDefaultObjectPtr, BPL_BulletPreview_C.__ShowBulletPreview_NativeFunctionPtr, (void*)ptr);
			Ret = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->Ret);
			UnrealReflectionUtils.DestroyStruct(BPL_BulletPreview_C.__ShowBulletPreview_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602CA8B RID: 182923 RVA: 0x00A252F7 File Offset: 0x00A234F7
		protected BPL_BulletPreview_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040178A8 RID: 96424
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/BPL_BulletPreview.BPL_BulletPreview_C";

		// Token: 0x040178A9 RID: 96425
		private static IntPtr _ClassPtr;

		// Token: 0x040178AA RID: 96426
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040178AB RID: 96427
		private static IntPtr __ShowBulletPreview_NativeFunctionPtr;

		// Token: 0x0200A672 RID: 42610
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4160)]
		protected ref struct __ShowBulletPreview_FunctionParams
		{
			// Token: 0x040325AD RID: 206253
			[FieldOffset(0)]
			public FString 子弹表路径;

			// Token: 0x040325AE RID: 206254
			[FieldOffset(16)]
			public FName 子弹ID;

			// Token: 0x040325AF RID: 206255
			[FieldOffset(32)]
			public IntPtr 拥有者;

			// Token: 0x040325B0 RID: 206256
			[FieldOffset(40)]
			public IntPtr meshComp;

			// Token: 0x040325B1 RID: 206257
			[FieldOffset(48)]
			public IntPtr __WorldContext;

			// Token: 0x040325B2 RID: 206258
			[FieldOffset(56)]
			public IntPtr Ret;
		}
	}
}
