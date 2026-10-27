using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.NPC.GPUNPC.Config
{
	// Token: 0x02004193 RID: 16787
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCInstanceConfigs.GPUNPCInstanceConfigs")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class GPUNPCInstanceConfigs : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602B8CC RID: 178380 RVA: 0x00A03BFA File Offset: 0x00A01DFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GPUNPCInstanceConfigs._ScriptStructPtr != 0) ? GPUNPCInstanceConfigs._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCInstanceConfigs.GPUNPCInstanceConfigs", ref GPUNPCInstanceConfigs._ScriptStructPtr);
		}

		// Token: 0x17006BC8 RID: 27592
		// (get) Token: 0x0602B8CD RID: 178381 RVA: 0x00A03C20 File Offset: 0x00A01E20
		// (set) Token: 0x0602B8CE RID: 178382 RVA: 0x00A03C63 File Offset: 0x00A01E63
		public TArray<int> RandomItemIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._RandomItemIndices) == null)
				{
					result = (this._RandomItemIndices = new TArray<int>(base.NativePtr + (IntPtr)GPUNPCInstanceConfigs.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RandomItemIndices.CopyAssign(value);
			}
		}

		// Token: 0x0602B8CF RID: 178383 RVA: 0x00A03C71 File Offset: 0x00A01E71
		public GPUNPCInstanceConfigs()
		{
		}

		// Token: 0x0602B8D0 RID: 178384 RVA: 0x00A03C79 File Offset: 0x00A01E79
		public GPUNPCInstanceConfigs(TArray<int> RandomItemIndices)
		{
			this.RandomItemIndices = RandomItemIndices;
		}

		// Token: 0x0602B8D1 RID: 178385 RVA: 0x00A03C88 File Offset: 0x00A01E88
		protected override IntPtr GetUStructPtr()
		{
			return GPUNPCInstanceConfigs.StaticStruct();
		}

		// Token: 0x0602B8D2 RID: 178386 RVA: 0x00A03C94 File Offset: 0x00A01E94
		[NullableContext(2)]
		public GPUNPCInstanceConfigs(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602B8D3 RID: 178387 RVA: 0x00A03C9E File Offset: 0x00A01E9E
		public GPUNPCInstanceConfigs(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602B8D4 RID: 178388 RVA: 0x00A03CA9 File Offset: 0x00A01EA9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GPUNPCInstanceConfigs(Pointer, false, true);
		}

		// Token: 0x0602B8D5 RID: 178389 RVA: 0x00A03CB3 File Offset: 0x00A01EB3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GPUNPCInstanceConfigs(Pointer, MemoryOwner);
		}

		// Token: 0x04016AC9 RID: 92873
		public const string __ObjectPath = "/Game/Aki/Character/NPC/GPUNPC/Config/GPUNPCInstanceConfigs.GPUNPCInstanceConfigs";

		// Token: 0x04016ACA RID: 92874
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016ACB RID: 92875
		internal static int __PropertyOffset_0;

		// Token: 0x04016ACC RID: 92876
		[Nullable(2)]
		private TArray<int> _RandomItemIndices;
	}
}
