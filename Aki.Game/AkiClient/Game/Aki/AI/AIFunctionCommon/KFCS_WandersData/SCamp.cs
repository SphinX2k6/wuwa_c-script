using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02004448 RID: 17480
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SCamp.SCamp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SCamp : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602D40A RID: 185354 RVA: 0x00A37CA2 File Offset: 0x00A35EA2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamp._ScriptStructPtr != 0) ? SCamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SCamp.SCamp", ref SCamp._ScriptStructPtr);
		}

		// Token: 0x170072BE RID: 29374
		// (get) Token: 0x0602D40B RID: 185355 RVA: 0x00A37CC8 File Offset: 0x00A35EC8
		// (set) Token: 0x0602D40C RID: 185356 RVA: 0x00A37D0B File Offset: 0x00A35F0B
		public TArray<int> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<int>(base.NativePtr + (IntPtr)SCamp.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x0602D40D RID: 185357 RVA: 0x00A37D19 File Offset: 0x00A35F19
		public SCamp()
		{
		}

		// Token: 0x0602D40E RID: 185358 RVA: 0x00A37D21 File Offset: 0x00A35F21
		public SCamp(TArray<int> Value)
		{
			this.Value = Value;
		}

		// Token: 0x0602D40F RID: 185359 RVA: 0x00A37D30 File Offset: 0x00A35F30
		protected override IntPtr GetUStructPtr()
		{
			return SCamp.StaticStruct();
		}

		// Token: 0x0602D410 RID: 185360 RVA: 0x00A37D3C File Offset: 0x00A35F3C
		[NullableContext(2)]
		public SCamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602D411 RID: 185361 RVA: 0x00A37D46 File Offset: 0x00A35F46
		public SCamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602D412 RID: 185362 RVA: 0x00A37D51 File Offset: 0x00A35F51
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamp(Pointer, false, true);
		}

		// Token: 0x0602D413 RID: 185363 RVA: 0x00A37D5B File Offset: 0x00A35F5B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamp(Pointer, MemoryOwner);
		}

		// Token: 0x04018130 RID: 98608
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SCamp.SCamp";

		// Token: 0x04018131 RID: 98609
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04018132 RID: 98610
		internal static int __PropertyOffset_0;

		// Token: 0x04018133 RID: 98611
		[Nullable(2)]
		private TArray<int> _Value;
	}
}
