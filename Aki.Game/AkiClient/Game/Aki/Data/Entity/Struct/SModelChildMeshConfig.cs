using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Entity.Struct
{
	// Token: 0x02003222 RID: 12834
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Entity/Struct/SModelChildMeshConfig.SModelChildMeshConfig")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 65)]
	public class SModelChildMeshConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602007A RID: 131194 RVA: 0x0093B7E8 File Offset: 0x009399E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SModelChildMeshConfig._ScriptStructPtr != 0) ? SModelChildMeshConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Entity/Struct/SModelChildMeshConfig.SModelChildMeshConfig", ref SModelChildMeshConfig._ScriptStructPtr);
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0602007B RID: 131195 RVA: 0x0093B80C File Offset: 0x00939A0C
		// (set) Token: 0x0602007C RID: 131196 RVA: 0x0093B82B File Offset: 0x00939A2B
		public TSoftObjectPtr<USkeletalMesh> SkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_SkeletalMesh, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_SkeletalMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0602007D RID: 131197 RVA: 0x0093B850 File Offset: 0x00939A50
		// (set) Token: 0x0602007E RID: 131198 RVA: 0x0093B864 File Offset: 0x00939A64
		public unsafe string ComponentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SModelChildMeshConfig.__PropertyOffset_ComponentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SModelChildMeshConfig.__PropertyOffset_ComponentName)), value);
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0602007F RID: 131199 RVA: 0x0093B879 File Offset: 0x00939A79
		// (set) Token: 0x06020080 RID: 131200 RVA: 0x0093B889 File Offset: 0x00939A89
		public unsafe bool DefaultVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_DefaultVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SModelChildMeshConfig.__PropertyOffset_DefaultVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x06020081 RID: 131201 RVA: 0x0093B89A File Offset: 0x00939A9A
		public SModelChildMeshConfig()
		{
		}

		// Token: 0x06020082 RID: 131202 RVA: 0x0093B8A2 File Offset: 0x00939AA2
		protected override IntPtr GetUStructPtr()
		{
			return SModelChildMeshConfig.StaticStruct();
		}

		// Token: 0x06020083 RID: 131203 RVA: 0x0093B8AE File Offset: 0x00939AAE
		[NullableContext(2)]
		public SModelChildMeshConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020084 RID: 131204 RVA: 0x0093B8B8 File Offset: 0x00939AB8
		public SModelChildMeshConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020085 RID: 131205 RVA: 0x0093B8C3 File Offset: 0x00939AC3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SModelChildMeshConfig(Pointer, false, true);
		}

		// Token: 0x06020086 RID: 131206 RVA: 0x0093B8CD File Offset: 0x00939ACD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SModelChildMeshConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401135D RID: 70493
		public const string __ObjectPath = "/Game/Aki/Data/Entity/Struct/SModelChildMeshConfig.SModelChildMeshConfig";

		// Token: 0x0401135E RID: 70494
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401135F RID: 70495
		internal static int __PropertyOffset_SkeletalMesh;

		// Token: 0x04011360 RID: 70496
		internal static int __PropertyOffset_ComponentName;

		// Token: 0x04011361 RID: 70497
		internal static int __PropertyOffset_DefaultVisible;
	}
}
