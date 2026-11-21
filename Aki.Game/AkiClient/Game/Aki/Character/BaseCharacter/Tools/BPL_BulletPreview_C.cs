using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02003374 RID: 13172
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/BPL_BulletPreview.BPL_BulletPreview_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_BulletPreview_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021731 RID: 137009 RVA: 0x00960D1C File Offset: 0x0095EF1C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_BulletPreview_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Tools/BPL_BulletPreview.BPL_BulletPreview_C");
			}
			return BPL_BulletPreview_C._ClassPtr;
		}

		// Token: 0x06021732 RID: 137010 RVA: 0x00960D40 File Offset: 0x0095EF40
		public BPL_BulletPreview_C() : this(BuiltinUtils.AllocNativeUObject(BPL_BulletPreview_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021733 RID: 137011 RVA: 0x00960D68 File Offset: 0x0095EF68
		[NullableContext(1)]
		public BPL_BulletPreview_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_BulletPreview_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021734 RID: 137012 RVA: 0x00960D9C File Offset: 0x0095EF9C
		[NullableContext(2)]
		[SkipLocalsInit]
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

		// Token: 0x06021735 RID: 137013 RVA: 0x00960E73 File Offset: 0x0095F073
		protected BPL_BulletPreview_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012482 RID: 74882
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/BPL_BulletPreview.BPL_BulletPreview_C";

		// Token: 0x04012483 RID: 74883
		private static IntPtr _ClassPtr;

		// Token: 0x04012484 RID: 74884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012485 RID: 74885
		private static IntPtr __ShowBulletPreview_NativeFunctionPtr;

		// Token: 0x02009085 RID: 36997
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4160)]
		protected ref struct __ShowBulletPreview_FunctionParams
		{
			// Token: 0x0402CE99 RID: 183961
			[FieldOffset(0)]
			public FString 子弹表路径;

			// Token: 0x0402CE9A RID: 183962
			[FieldOffset(16)]
			public FName 子弹ID;

			// Token: 0x0402CE9B RID: 183963
			[FieldOffset(32)]
			public IntPtr 拥有者;

			// Token: 0x0402CE9C RID: 183964
			[FieldOffset(40)]
			public IntPtr meshComp;

			// Token: 0x0402CE9D RID: 183965
			[FieldOffset(48)]
			public IntPtr __WorldContext;

			// Token: 0x0402CE9E RID: 183966
			[FieldOffset(56)]
			public IntPtr Ret;
		}
	}
}
