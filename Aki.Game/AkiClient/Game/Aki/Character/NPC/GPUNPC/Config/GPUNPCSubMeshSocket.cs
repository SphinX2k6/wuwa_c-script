using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.Config
{
	// Token: 0x02004195 RID: 16789
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCSubMeshSocket.GPUNPCSubMeshSocket")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class GPUNPCSubMeshSocket : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602B8E4 RID: 178404 RVA: 0x00A03DA4 File Offset: 0x00A01FA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GPUNPCSubMeshSocket._ScriptStructPtr != 0) ? GPUNPCSubMeshSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCSubMeshSocket.GPUNPCSubMeshSocket", ref GPUNPCSubMeshSocket._ScriptStructPtr);
		}

		// Token: 0x17006BCC RID: 27596
		// (get) Token: 0x0602B8E5 RID: 178405 RVA: 0x00A03DC8 File Offset: 0x00A01FC8
		// (set) Token: 0x0602B8E6 RID: 178406 RVA: 0x00A03DDC File Offset: 0x00A01FDC
		[Nullable(2)]
		public unsafe USkeletalMesh SubMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCSubMeshSocket.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GPUNPCSubMeshSocket.__PropertyOffset_0, value);
			}
		}

		// Token: 0x17006BCD RID: 27597
		// (get) Token: 0x0602B8E7 RID: 178407 RVA: 0x00A03DF1 File Offset: 0x00A01FF1
		// (set) Token: 0x0602B8E8 RID: 178408 RVA: 0x00A03E05 File Offset: 0x00A02005
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GPUNPCSubMeshSocket.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GPUNPCSubMeshSocket.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006BCE RID: 27598
		// (get) Token: 0x0602B8E9 RID: 178409 RVA: 0x00A03E1A File Offset: 0x00A0201A
		// (set) Token: 0x0602B8EA RID: 178410 RVA: 0x00A03E2E File Offset: 0x00A0202E
		public unsafe FTransform SocketTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GPUNPCSubMeshSocket.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GPUNPCSubMeshSocket.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B8EB RID: 178411 RVA: 0x00A03E43 File Offset: 0x00A02043
		public GPUNPCSubMeshSocket()
		{
		}

		// Token: 0x0602B8EC RID: 178412 RVA: 0x00A03E4B File Offset: 0x00A0204B
		[NullableContext(1)]
		public GPUNPCSubMeshSocket(USkeletalMesh SubMesh, FName SocketName, FTransform SocketTransform)
		{
			this.SubMesh = SubMesh;
			this.SocketName = SocketName;
			this.SocketTransform = SocketTransform;
		}

		// Token: 0x0602B8ED RID: 178413 RVA: 0x00A03E68 File Offset: 0x00A02068
		protected override IntPtr GetUStructPtr()
		{
			return GPUNPCSubMeshSocket.StaticStruct();
		}

		// Token: 0x0602B8EE RID: 178414 RVA: 0x00A03E74 File Offset: 0x00A02074
		[NullableContext(2)]
		public GPUNPCSubMeshSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602B8EF RID: 178415 RVA: 0x00A03E7E File Offset: 0x00A0207E
		public GPUNPCSubMeshSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602B8F0 RID: 178416 RVA: 0x00A03E89 File Offset: 0x00A02089
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GPUNPCSubMeshSocket(Pointer, false, true);
		}

		// Token: 0x0602B8F1 RID: 178417 RVA: 0x00A03E93 File Offset: 0x00A02093
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GPUNPCSubMeshSocket(Pointer, MemoryOwner);
		}

		// Token: 0x04016AD2 RID: 92882
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCSubMeshSocket.GPUNPCSubMeshSocket";

		// Token: 0x04016AD3 RID: 92883
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016AD4 RID: 92884
		internal static int __PropertyOffset_0;

		// Token: 0x04016AD5 RID: 92885
		internal static int __PropertyOffset_1;

		// Token: 0x04016AD6 RID: 92886
		internal static int __PropertyOffset_2;
	}
}
