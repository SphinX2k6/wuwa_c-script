using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools.Data.Struct
{
	// Token: 0x0200434C RID: 17228
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBodyPhysicsAssetPath.SBodyPhysicsAssetPath")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SBodyPhysicsAssetPath : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CAD6 RID: 182998 RVA: 0x00A258D6 File Offset: 0x00A23AD6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBodyPhysicsAssetPath._ScriptStructPtr != 0) ? SBodyPhysicsAssetPath._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBodyPhysicsAssetPath.SBodyPhysicsAssetPath", ref SBodyPhysicsAssetPath._ScriptStructPtr);
		}

		// Token: 0x1700706D RID: 28781
		// (get) Token: 0x0602CAD7 RID: 182999 RVA: 0x00A258FA File Offset: 0x00A23AFA
		// (set) Token: 0x0602CAD8 RID: 183000 RVA: 0x00A2590E File Offset: 0x00A23B0E
		[Nullable(2)]
		public unsafe USkeletalMesh Mesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + SBodyPhysicsAssetPath.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SBodyPhysicsAssetPath.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700706E RID: 28782
		// (get) Token: 0x0602CAD9 RID: 183001 RVA: 0x00A25923 File Offset: 0x00A23B23
		// (set) Token: 0x0602CADA RID: 183002 RVA: 0x00A25937 File Offset: 0x00A23B37
		public unsafe string Path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBodyPhysicsAssetPath.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBodyPhysicsAssetPath.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x0602CADB RID: 183003 RVA: 0x00A2594C File Offset: 0x00A23B4C
		public SBodyPhysicsAssetPath()
		{
		}

		// Token: 0x0602CADC RID: 183004 RVA: 0x00A25954 File Offset: 0x00A23B54
		public SBodyPhysicsAssetPath(USkeletalMesh Mesh, string Path)
		{
			this.Mesh = Mesh;
			this.Path = Path;
		}

		// Token: 0x0602CADD RID: 183005 RVA: 0x00A2596A File Offset: 0x00A23B6A
		protected override IntPtr GetUStructPtr()
		{
			return SBodyPhysicsAssetPath.StaticStruct();
		}

		// Token: 0x0602CADE RID: 183006 RVA: 0x00A25976 File Offset: 0x00A23B76
		[NullableContext(2)]
		public SBodyPhysicsAssetPath(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CADF RID: 183007 RVA: 0x00A25980 File Offset: 0x00A23B80
		public SBodyPhysicsAssetPath(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CAE0 RID: 183008 RVA: 0x00A2598B File Offset: 0x00A23B8B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBodyPhysicsAssetPath(Pointer, false, true);
		}

		// Token: 0x0602CAE1 RID: 183009 RVA: 0x00A25995 File Offset: 0x00A23B95
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBodyPhysicsAssetPath(Pointer, MemoryOwner);
		}

		// Token: 0x040178D8 RID: 96472
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/Data/Struct/SBodyPhysicsAssetPath.SBodyPhysicsAssetPath";

		// Token: 0x040178D9 RID: 96473
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178DA RID: 96474
		internal static int __PropertyOffset_0;

		// Token: 0x040178DB RID: 96475
		internal static int __PropertyOffset_1;
	}
}
