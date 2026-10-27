using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.CreatureTools.Designer
{
	// Token: 0x02003FCD RID: 16333
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/CreatureTools/Designer/GeneralActionGroupAll.GeneralActionGroupAll")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class GeneralActionGroupAll : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029D0B RID: 171275 RVA: 0x009CD18A File Offset: 0x009CB38A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (GeneralActionGroupAll._ScriptStructPtr != 0) ? GeneralActionGroupAll._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/CreatureTools/Designer/GeneralActionGroupAll.GeneralActionGroupAll", ref GeneralActionGroupAll._ScriptStructPtr);
		}

		// Token: 0x17006560 RID: 25952
		// (get) Token: 0x06029D0C RID: 171276 RVA: 0x009CD1AE File Offset: 0x009CB3AE
		// (set) Token: 0x06029D0D RID: 171277 RVA: 0x009CD1C2 File Offset: 0x009CB3C2
		public unsafe string DefineMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionGroupAll.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionGroupAll.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006561 RID: 25953
		// (get) Token: 0x06029D0E RID: 171278 RVA: 0x009CD1D7 File Offset: 0x009CB3D7
		// (set) Token: 0x06029D0F RID: 171279 RVA: 0x009CD1EB File Offset: 0x009CB3EB
		public unsafe string DataMd5
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionGroupAll.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)GeneralActionGroupAll.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006562 RID: 25954
		// (get) Token: 0x06029D10 RID: 171280 RVA: 0x009CD200 File Offset: 0x009CB400
		// (set) Token: 0x06029D11 RID: 171281 RVA: 0x009CD243 File Offset: 0x009CB443
		public TArray<NPCGeneralActionGroup> Data
		{
			get
			{
				base.FastCheckIsValid();
				TArray<NPCGeneralActionGroup> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TArray<NPCGeneralActionGroup>(base.NativePtr + (IntPtr)GeneralActionGroupAll.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x06029D12 RID: 171282 RVA: 0x009CD251 File Offset: 0x009CB451
		public GeneralActionGroupAll()
		{
		}

		// Token: 0x06029D13 RID: 171283 RVA: 0x009CD259 File Offset: 0x009CB459
		public GeneralActionGroupAll(string DefineMd5, string DataMd5, TArray<NPCGeneralActionGroup> Data)
		{
			this.DefineMd5 = DefineMd5;
			this.DataMd5 = DataMd5;
			this.Data = Data;
		}

		// Token: 0x06029D14 RID: 171284 RVA: 0x009CD276 File Offset: 0x009CB476
		protected override IntPtr GetUStructPtr()
		{
			return GeneralActionGroupAll.StaticStruct();
		}

		// Token: 0x06029D15 RID: 171285 RVA: 0x009CD282 File Offset: 0x009CB482
		[NullableContext(2)]
		public GeneralActionGroupAll(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029D16 RID: 171286 RVA: 0x009CD28C File Offset: 0x009CB48C
		public GeneralActionGroupAll(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029D17 RID: 171287 RVA: 0x009CD297 File Offset: 0x009CB497
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new GeneralActionGroupAll(Pointer, false, true);
		}

		// Token: 0x06029D18 RID: 171288 RVA: 0x009CD2A1 File Offset: 0x009CB4A1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new GeneralActionGroupAll(Pointer, MemoryOwner);
		}

		// Token: 0x04015799 RID: 87961
		public const string __ObjectPath = "/Game/Aki/CreatureTools/Designer/GeneralActionGroupAll.GeneralActionGroupAll";

		// Token: 0x0401579A RID: 87962
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401579B RID: 87963
		internal static int __PropertyOffset_0;

		// Token: 0x0401579C RID: 87964
		internal static int __PropertyOffset_1;

		// Token: 0x0401579D RID: 87965
		internal static int __PropertyOffset_2;

		// Token: 0x0401579E RID: 87966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<NPCGeneralActionGroup> _Data;
	}
}
