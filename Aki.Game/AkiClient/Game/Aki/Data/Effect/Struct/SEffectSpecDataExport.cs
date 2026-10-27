using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Effect.Struct
{
	// Token: 0x02003F9B RID: 16283
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Effect/Struct/SEffectSpecDataExport.SEffectSpecDataExport")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SEffectSpecDataExport : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029967 RID: 170343 RVA: 0x009C8023 File Offset: 0x009C6223
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SEffectSpecDataExport._ScriptStructPtr != 0) ? SEffectSpecDataExport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Effect/Struct/SEffectSpecDataExport.SEffectSpecDataExport", ref SEffectSpecDataExport._ScriptStructPtr);
		}

		// Token: 0x17006417 RID: 25623
		// (get) Token: 0x06029968 RID: 170344 RVA: 0x009C8048 File Offset: 0x009C6248
		// (set) Token: 0x06029969 RID: 170345 RVA: 0x009C808B File Offset: 0x009C628B
		public TArray<SEffectSpec> EffectSpecs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SEffectSpec> result;
				if ((result = this._EffectSpecs) == null)
				{
					result = (this._EffectSpecs = new TArray<SEffectSpec>(base.NativePtr + (IntPtr)SEffectSpecDataExport.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EffectSpecs.CopyAssign(value);
			}
		}

		// Token: 0x0602996A RID: 170346 RVA: 0x009C8099 File Offset: 0x009C6299
		public SEffectSpecDataExport()
		{
		}

		// Token: 0x0602996B RID: 170347 RVA: 0x009C80A1 File Offset: 0x009C62A1
		public SEffectSpecDataExport(TArray<SEffectSpec> EffectSpecs)
		{
			this.EffectSpecs = EffectSpecs;
		}

		// Token: 0x0602996C RID: 170348 RVA: 0x009C80B0 File Offset: 0x009C62B0
		protected override IntPtr GetUStructPtr()
		{
			return SEffectSpecDataExport.StaticStruct();
		}

		// Token: 0x0602996D RID: 170349 RVA: 0x009C80BC File Offset: 0x009C62BC
		[NullableContext(2)]
		public SEffectSpecDataExport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602996E RID: 170350 RVA: 0x009C80C6 File Offset: 0x009C62C6
		public SEffectSpecDataExport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602996F RID: 170351 RVA: 0x009C80D1 File Offset: 0x009C62D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SEffectSpecDataExport(Pointer, false, true);
		}

		// Token: 0x06029970 RID: 170352 RVA: 0x009C80DB File Offset: 0x009C62DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SEffectSpecDataExport(Pointer, MemoryOwner);
		}

		// Token: 0x0401556E RID: 87406
		public const string __ObjectPath = "/Game/Aki/Data/Effect/Struct/SEffectSpecDataExport.SEffectSpecDataExport";

		// Token: 0x0401556F RID: 87407
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015570 RID: 87408
		internal static int __PropertyOffset_0;

		// Token: 0x04015571 RID: 87409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SEffectSpec> _EffectSpecs;
	}
}
