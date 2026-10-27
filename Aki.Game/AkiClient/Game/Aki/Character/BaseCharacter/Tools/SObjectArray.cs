using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02004346 RID: 17222
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/SObjectArray.SObjectArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SObjectArray : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA8C RID: 182924 RVA: 0x00A25300 File Offset: 0x00A23500
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SObjectArray._ScriptStructPtr != 0) ? SObjectArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/SObjectArray.SObjectArray", ref SObjectArray._ScriptStructPtr);
		}

		// Token: 0x17007060 RID: 28768
		// (get) Token: 0x0602CA8D RID: 182925 RVA: 0x00A25324 File Offset: 0x00A23524
		// (set) Token: 0x0602CA8E RID: 182926 RVA: 0x00A25367 File Offset: 0x00A23567
		public TArray<UObject> Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._Array) == null)
				{
					result = (this._Array = new TArray<UObject>(base.NativePtr + (IntPtr)SObjectArray.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Array.CopyAssign(value);
			}
		}

		// Token: 0x0602CA8F RID: 182927 RVA: 0x00A25375 File Offset: 0x00A23575
		public SObjectArray()
		{
		}

		// Token: 0x0602CA90 RID: 182928 RVA: 0x00A2537D File Offset: 0x00A2357D
		public SObjectArray(TArray<UObject> Array)
		{
			this.Array = Array;
		}

		// Token: 0x0602CA91 RID: 182929 RVA: 0x00A2538C File Offset: 0x00A2358C
		protected override IntPtr GetUStructPtr()
		{
			return SObjectArray.StaticStruct();
		}

		// Token: 0x0602CA92 RID: 182930 RVA: 0x00A25398 File Offset: 0x00A23598
		[NullableContext(2)]
		public SObjectArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA93 RID: 182931 RVA: 0x00A253A2 File Offset: 0x00A235A2
		public SObjectArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA94 RID: 182932 RVA: 0x00A253AD File Offset: 0x00A235AD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SObjectArray(Pointer, false, true);
		}

		// Token: 0x0602CA95 RID: 182933 RVA: 0x00A253B7 File Offset: 0x00A235B7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SObjectArray(Pointer, MemoryOwner);
		}

		// Token: 0x040178B9 RID: 96441
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/SObjectArray.SObjectArray";

		// Token: 0x040178BA RID: 96442
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178BB RID: 96443
		internal static int __PropertyOffset_0;

		// Token: 0x040178BC RID: 96444
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _Array;
	}
}
