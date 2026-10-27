using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x02003FA5 RID: 16293
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/SVectorArray.SVectorArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SVectorArray : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029A06 RID: 170502 RVA: 0x009C8FF0 File Offset: 0x009C71F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SVectorArray._ScriptStructPtr != 0) ? SVectorArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Common/Struct/SVectorArray.SVectorArray", ref SVectorArray._ScriptStructPtr);
		}

		// Token: 0x17006445 RID: 25669
		// (get) Token: 0x06029A07 RID: 170503 RVA: 0x009C9014 File Offset: 0x009C7214
		// (set) Token: 0x06029A08 RID: 170504 RVA: 0x009C9057 File Offset: 0x009C7257
		public TArray<FVectorDouble> Vectors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._Vectors) == null)
				{
					result = (this._Vectors = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)SVectorArray.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Vectors.CopyAssign(value);
			}
		}

		// Token: 0x06029A09 RID: 170505 RVA: 0x009C9065 File Offset: 0x009C7265
		public SVectorArray()
		{
		}

		// Token: 0x06029A0A RID: 170506 RVA: 0x009C906D File Offset: 0x009C726D
		public SVectorArray(TArray<FVectorDouble> Vectors)
		{
			this.Vectors = Vectors;
		}

		// Token: 0x06029A0B RID: 170507 RVA: 0x009C907C File Offset: 0x009C727C
		protected override IntPtr GetUStructPtr()
		{
			return SVectorArray.StaticStruct();
		}

		// Token: 0x06029A0C RID: 170508 RVA: 0x009C9088 File Offset: 0x009C7288
		[NullableContext(2)]
		public SVectorArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029A0D RID: 170509 RVA: 0x009C9092 File Offset: 0x009C7292
		public SVectorArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029A0E RID: 170510 RVA: 0x009C909D File Offset: 0x009C729D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SVectorArray(Pointer, false, true);
		}

		// Token: 0x06029A0F RID: 170511 RVA: 0x009C90A7 File Offset: 0x009C72A7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SVectorArray(Pointer, MemoryOwner);
		}

		// Token: 0x040155C7 RID: 87495
		public const string __ObjectPath = "/Game/Aki/Data/Common/Struct/SVectorArray.SVectorArray";

		// Token: 0x040155C8 RID: 87496
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155C9 RID: 87497
		internal static int __PropertyOffset_0;

		// Token: 0x040155CA RID: 87498
		[Nullable(2)]
		private TArray<FVectorDouble> _Vectors;
	}
}
