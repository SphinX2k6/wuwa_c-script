using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.GamePlay.PathPoints
{
	// Token: 0x02003E5D RID: 15965
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/GamePlay/PathPoints/SPointsRow.SPointsRow")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class SPointsRow : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028236 RID: 164406 RVA: 0x009A507C File Offset: 0x009A327C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPointsRow._ScriptStructPtr != 0) ? SPointsRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/GamePlay/PathPoints/SPointsRow.SPointsRow", ref SPointsRow._ScriptStructPtr);
		}

		// Token: 0x17005BE6 RID: 23526
		// (get) Token: 0x06028237 RID: 164407 RVA: 0x009A50A0 File Offset: 0x009A32A0
		// (set) Token: 0x06028238 RID: 164408 RVA: 0x009A50B0 File Offset: 0x009A32B0
		public unsafe float X
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPointsRow.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPointsRow.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17005BE7 RID: 23527
		// (get) Token: 0x06028239 RID: 164409 RVA: 0x009A50C4 File Offset: 0x009A32C4
		// (set) Token: 0x0602823A RID: 164410 RVA: 0x009A5107 File Offset: 0x009A3307
		public TArray<FVector> PointsRow
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PointsRow) == null)
				{
					result = (this._PointsRow = new TArray<FVector>(base.NativePtr + (IntPtr)SPointsRow.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PointsRow.CopyAssign(value);
			}
		}

		// Token: 0x0602823B RID: 164411 RVA: 0x009A5115 File Offset: 0x009A3315
		public SPointsRow()
		{
		}

		// Token: 0x0602823C RID: 164412 RVA: 0x009A511D File Offset: 0x009A331D
		public SPointsRow(float X, TArray<FVector> PointsRow)
		{
			this.X = X;
			this.PointsRow = PointsRow;
		}

		// Token: 0x0602823D RID: 164413 RVA: 0x009A5133 File Offset: 0x009A3333
		protected override IntPtr GetUStructPtr()
		{
			return SPointsRow.StaticStruct();
		}

		// Token: 0x0602823E RID: 164414 RVA: 0x009A513F File Offset: 0x009A333F
		[NullableContext(2)]
		public SPointsRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602823F RID: 164415 RVA: 0x009A5149 File Offset: 0x009A3349
		public SPointsRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028240 RID: 164416 RVA: 0x009A5154 File Offset: 0x009A3354
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPointsRow(Pointer, false, true);
		}

		// Token: 0x06028241 RID: 164417 RVA: 0x009A515E File Offset: 0x009A335E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPointsRow(Pointer, MemoryOwner);
		}

		// Token: 0x040146DE RID: 83678
		public const string __ObjectPath = "/Game/Aki/GamePlay/PathPoints/SPointsRow.SPointsRow";

		// Token: 0x040146DF RID: 83679
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040146E0 RID: 83680
		internal static int __PropertyOffset_0;

		// Token: 0x040146E1 RID: 83681
		internal static int __PropertyOffset_1;

		// Token: 0x040146E2 RID: 83682
		[Nullable(2)]
		private TArray<FVector> _PointsRow;
	}
}
