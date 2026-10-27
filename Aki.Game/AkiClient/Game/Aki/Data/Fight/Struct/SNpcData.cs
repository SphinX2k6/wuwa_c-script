using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F6E RID: 16238
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SNpcData.SNpcData")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SNpcData : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602967A RID: 169594 RVA: 0x009C36AA File Offset: 0x009C18AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNpcData._ScriptStructPtr != 0) ? SNpcData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SNpcData.SNpcData", ref SNpcData._ScriptStructPtr);
		}

		// Token: 0x1700630B RID: 25355
		// (get) Token: 0x0602967B RID: 169595 RVA: 0x009C36CE File Offset: 0x009C18CE
		// (set) Token: 0x0602967C RID: 169596 RVA: 0x009C36E2 File Offset: 0x009C18E2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<TsBaseCharacter> 蓝图类
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)SNpcData.__PropertyOffset_0);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)SNpcData.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602967D RID: 169597 RVA: 0x009C36F7 File Offset: 0x009C18F7
		public SNpcData()
		{
		}

		// Token: 0x0602967E RID: 169598 RVA: 0x009C36FF File Offset: 0x009C18FF
		public SNpcData([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<TsBaseCharacter> 蓝图类)
		{
			this.蓝图类 = 蓝图类;
		}

		// Token: 0x0602967F RID: 169599 RVA: 0x009C370E File Offset: 0x009C190E
		protected override IntPtr GetUStructPtr()
		{
			return SNpcData.StaticStruct();
		}

		// Token: 0x06029680 RID: 169600 RVA: 0x009C371A File Offset: 0x009C191A
		[NullableContext(2)]
		public SNpcData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029681 RID: 169601 RVA: 0x009C3724 File Offset: 0x009C1924
		public SNpcData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029682 RID: 169602 RVA: 0x009C372F File Offset: 0x009C192F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNpcData(Pointer, false, true);
		}

		// Token: 0x06029683 RID: 169603 RVA: 0x009C3739 File Offset: 0x009C1939
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNpcData(Pointer, MemoryOwner);
		}

		// Token: 0x04015374 RID: 86900
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SNpcData.SNpcData";

		// Token: 0x04015375 RID: 86901
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015376 RID: 86902
		internal static int __PropertyOffset_0;
	}
}
