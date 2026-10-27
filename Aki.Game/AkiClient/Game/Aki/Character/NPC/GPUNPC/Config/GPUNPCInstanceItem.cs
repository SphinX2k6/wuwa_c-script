using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.Config
{
	// Token: 0x02004194 RID: 16788
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCInstanceItem.GPUNPCInstanceItem")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class GPUNPCInstanceItem : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602B8D6 RID: 178390 RVA: 0x00A03CBC File Offset: 0x00A01EBC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GPUNPCInstanceItem._ScriptStructPtr != 0) ? GPUNPCInstanceItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCInstanceItem.GPUNPCInstanceItem", ref GPUNPCInstanceItem._ScriptStructPtr);
		}

		// Token: 0x17006BC9 RID: 27593
		// (get) Token: 0x0602B8D7 RID: 178391 RVA: 0x00A03CE0 File Offset: 0x00A01EE0
		// (set) Token: 0x0602B8D8 RID: 178392 RVA: 0x00A03CF0 File Offset: 0x00A01EF0
		public unsafe int GroupIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GPUNPCInstanceItem.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GPUNPCInstanceItem.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006BCA RID: 27594
		// (get) Token: 0x0602B8D9 RID: 178393 RVA: 0x00A03D01 File Offset: 0x00A01F01
		// (set) Token: 0x0602B8DA RID: 178394 RVA: 0x00A03D11 File Offset: 0x00A01F11
		public unsafe int AnimTextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GPUNPCInstanceItem.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GPUNPCInstanceItem.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006BCB RID: 27595
		// (get) Token: 0x0602B8DB RID: 178395 RVA: 0x00A03D22 File Offset: 0x00A01F22
		// (set) Token: 0x0602B8DC RID: 178396 RVA: 0x00A03D36 File Offset: 0x00A01F36
		public unsafe FTransform InstanceTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GPUNPCInstanceItem.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GPUNPCInstanceItem.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602B8DD RID: 178397 RVA: 0x00A03D4B File Offset: 0x00A01F4B
		public GPUNPCInstanceItem()
		{
		}

		// Token: 0x0602B8DE RID: 178398 RVA: 0x00A03D53 File Offset: 0x00A01F53
		public GPUNPCInstanceItem(int GroupIndex, int AnimTextureIndex, FTransform InstanceTransform)
		{
			this.GroupIndex = GroupIndex;
			this.AnimTextureIndex = AnimTextureIndex;
			this.InstanceTransform = InstanceTransform;
		}

		// Token: 0x0602B8DF RID: 178399 RVA: 0x00A03D70 File Offset: 0x00A01F70
		protected override IntPtr GetUStructPtr()
		{
			return GPUNPCInstanceItem.StaticStruct();
		}

		// Token: 0x0602B8E0 RID: 178400 RVA: 0x00A03D7C File Offset: 0x00A01F7C
		[NullableContext(2)]
		public GPUNPCInstanceItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602B8E1 RID: 178401 RVA: 0x00A03D86 File Offset: 0x00A01F86
		public GPUNPCInstanceItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602B8E2 RID: 178402 RVA: 0x00A03D91 File Offset: 0x00A01F91
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GPUNPCInstanceItem(Pointer, false, true);
		}

		// Token: 0x0602B8E3 RID: 178403 RVA: 0x00A03D9B File Offset: 0x00A01F9B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GPUNPCInstanceItem(Pointer, MemoryOwner);
		}

		// Token: 0x04016ACD RID: 92877
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCInstanceItem.GPUNPCInstanceItem";

		// Token: 0x04016ACE RID: 92878
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016ACF RID: 92879
		internal static int __PropertyOffset_0;

		// Token: 0x04016AD0 RID: 92880
		internal static int __PropertyOffset_1;

		// Token: 0x04016AD1 RID: 92881
		internal static int __PropertyOffset_2;
	}
}
