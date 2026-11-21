using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.AI.AIFunctionCommon.KFCS_WandersData
{
	// Token: 0x02003405 RID: 13317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SCamp.SCamp")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SCamp : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021D06 RID: 138502 RVA: 0x0096C44F File Offset: 0x0096A64F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCamp._ScriptStructPtr != 0) ? SCamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SCamp.SCamp", ref SCamp._ScriptStructPtr);
		}

		// Token: 0x1700462F RID: 17967
		// (get) Token: 0x06021D07 RID: 138503 RVA: 0x0096C474 File Offset: 0x0096A674
		// (set) Token: 0x06021D08 RID: 138504 RVA: 0x0096C4B7 File Offset: 0x0096A6B7
		public TArray<int> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<int>(base.NativePtr + (IntPtr)SCamp.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x06021D09 RID: 138505 RVA: 0x0096C4C5 File Offset: 0x0096A6C5
		public SCamp()
		{
		}

		// Token: 0x06021D0A RID: 138506 RVA: 0x0096C4CD File Offset: 0x0096A6CD
		protected override IntPtr GetUStructPtr()
		{
			return SCamp.StaticStruct();
		}

		// Token: 0x06021D0B RID: 138507 RVA: 0x0096C4D9 File Offset: 0x0096A6D9
		[NullableContext(2)]
		public SCamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021D0C RID: 138508 RVA: 0x0096C4E3 File Offset: 0x0096A6E3
		public SCamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021D0D RID: 138509 RVA: 0x0096C4EE File Offset: 0x0096A6EE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCamp(Pointer, false, true);
		}

		// Token: 0x06021D0E RID: 138510 RVA: 0x0096C4F8 File Offset: 0x0096A6F8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCamp(Pointer, MemoryOwner);
		}

		// Token: 0x04012A6B RID: 76395
		public const string __ObjectPath = "/Game/Aki/AI/AIFunctionCommon/KFCS_WandersData/SCamp.SCamp";

		// Token: 0x04012A6C RID: 76396
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012A6D RID: 76397
		internal static int __PropertyOffset_Value;

		// Token: 0x04012A6E RID: 76398
		[Nullable(2)]
		private TArray<int> _Value;
	}
}
