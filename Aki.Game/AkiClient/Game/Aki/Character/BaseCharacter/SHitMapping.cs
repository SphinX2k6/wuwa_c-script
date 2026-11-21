using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003354 RID: 13140
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SHitMapping.SHitMapping")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SHitMapping : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021456 RID: 136278 RVA: 0x0095CEE4 File Offset: 0x0095B0E4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SHitMapping._ScriptStructPtr != 0) ? SHitMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SHitMapping.SHitMapping", ref SHitMapping._ScriptStructPtr);
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x06021457 RID: 136279 RVA: 0x0095CF08 File Offset: 0x0095B108
		// (set) Token: 0x06021458 RID: 136280 RVA: 0x0095CF18 File Offset: 0x0095B118
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SHitMapping.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SHitMapping.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x06021459 RID: 136281 RVA: 0x0095CF2C File Offset: 0x0095B12C
		// (set) Token: 0x0602145A RID: 136282 RVA: 0x0095CF6F File Offset: 0x0095B16F
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<EHitAnim>> 映射表
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<EHitAnim>> result;
				if ((result = this._映射表) == null)
				{
					result = (this._映射表 = new TArray<TEnumAsByte<EHitAnim>>(base.NativePtr + (IntPtr)SHitMapping.__PropertyOffset_映射表, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.映射表.CopyAssign(value);
			}
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x0602145B RID: 136283 RVA: 0x0095CF7D File Offset: 0x0095B17D
		// (set) Token: 0x0602145C RID: 136284 RVA: 0x0095CF91 File Offset: 0x0095B191
		public unsafe string 备注
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SHitMapping.__PropertyOffset_备注)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SHitMapping.__PropertyOffset_备注)), value);
			}
		}

		// Token: 0x0602145D RID: 136285 RVA: 0x0095CFA6 File Offset: 0x0095B1A6
		public SHitMapping()
		{
		}

		// Token: 0x0602145E RID: 136286 RVA: 0x0095CFAE File Offset: 0x0095B1AE
		protected override IntPtr GetUStructPtr()
		{
			return SHitMapping.StaticStruct();
		}

		// Token: 0x0602145F RID: 136287 RVA: 0x0095CFBA File Offset: 0x0095B1BA
		[NullableContext(2)]
		public SHitMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021460 RID: 136288 RVA: 0x0095CFC4 File Offset: 0x0095B1C4
		public SHitMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021461 RID: 136289 RVA: 0x0095CFCF File Offset: 0x0095B1CF
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SHitMapping(Pointer, false, true);
		}

		// Token: 0x06021462 RID: 136290 RVA: 0x0095CFD9 File Offset: 0x0095B1D9
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SHitMapping(Pointer, MemoryOwner);
		}

		// Token: 0x040122FE RID: 74494
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SHitMapping.SHitMapping";

		// Token: 0x040122FF RID: 74495
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012300 RID: 74496
		internal static int __PropertyOffset_ID;

		// Token: 0x04012301 RID: 74497
		internal static int __PropertyOffset_映射表;

		// Token: 0x04012302 RID: 74498
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<EHitAnim>> _映射表;

		// Token: 0x04012303 RID: 74499
		internal static int __PropertyOffset_备注;
	}
}
