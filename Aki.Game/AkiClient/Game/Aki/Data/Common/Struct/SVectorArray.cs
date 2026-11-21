using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x0200322E RID: 12846
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/SVectorArray.SVectorArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SVectorArray : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020130 RID: 131376 RVA: 0x0093C991 File Offset: 0x0093AB91
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVectorArray._ScriptStructPtr != 0) ? SVectorArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Common/Struct/SVectorArray.SVectorArray", ref SVectorArray._ScriptStructPtr);
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x06020131 RID: 131377 RVA: 0x0093C9B8 File Offset: 0x0093ABB8
		// (set) Token: 0x06020132 RID: 131378 RVA: 0x0093C9FB File Offset: 0x0093ABFB
		public TArray<FVectorDouble> Vectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._Vectors) == null)
				{
					result = (this._Vectors = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)SVectorArray.__PropertyOffset_Vectors, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vectors.CopyAssign(value);
			}
		}

		// Token: 0x06020133 RID: 131379 RVA: 0x0093CA09 File Offset: 0x0093AC09
		public SVectorArray()
		{
		}

		// Token: 0x06020134 RID: 131380 RVA: 0x0093CA11 File Offset: 0x0093AC11
		protected override IntPtr GetUStructPtr()
		{
			return SVectorArray.StaticStruct();
		}

		// Token: 0x06020135 RID: 131381 RVA: 0x0093CA1D File Offset: 0x0093AC1D
		[NullableContext(2)]
		public SVectorArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020136 RID: 131382 RVA: 0x0093CA27 File Offset: 0x0093AC27
		public SVectorArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020137 RID: 131383 RVA: 0x0093CA32 File Offset: 0x0093AC32
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVectorArray(Pointer, false, true);
		}

		// Token: 0x06020138 RID: 131384 RVA: 0x0093CA3C File Offset: 0x0093AC3C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVectorArray(Pointer, MemoryOwner);
		}

		// Token: 0x040113EC RID: 70636
		public const string __ObjectPath = "/Game/Aki/Data/Common/Struct/SVectorArray.SVectorArray";

		// Token: 0x040113ED RID: 70637
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040113EE RID: 70638
		internal static int __PropertyOffset_Vectors;

		// Token: 0x040113EF RID: 70639
		[Nullable(2)]
		private TArray<FVectorDouble> _Vectors;
	}
}
