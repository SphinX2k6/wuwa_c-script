using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.GMOrder.Struct
{
	// Token: 0x02003F24 RID: 16164
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/GMOrder/Struct/SGMOrderInfo.SGMOrderInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SGMOrderInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060290AB RID: 168107 RVA: 0x009BA577 File Offset: 0x009B8777
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGMOrderInfo._ScriptStructPtr != 0) ? SGMOrderInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/GMOrder/Struct/SGMOrderInfo.SGMOrderInfo", ref SGMOrderInfo._ScriptStructPtr);
		}

		// Token: 0x17006118 RID: 24856
		// (get) Token: 0x060290AC RID: 168108 RVA: 0x009BA59B File Offset: 0x009B879B
		// (set) Token: 0x060290AD RID: 168109 RVA: 0x009BA5AF File Offset: 0x009B87AF
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SGMOrderInfo.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SGMOrderInfo.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006119 RID: 24857
		// (get) Token: 0x060290AE RID: 168110 RVA: 0x009BA5C4 File Offset: 0x009B87C4
		// (set) Token: 0x060290AF RID: 168111 RVA: 0x009BA5D8 File Offset: 0x009B87D8
		public unsafe string Code
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SGMOrderInfo.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SGMOrderInfo.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x060290B0 RID: 168112 RVA: 0x009BA5ED File Offset: 0x009B87ED
		public SGMOrderInfo()
		{
		}

		// Token: 0x060290B1 RID: 168113 RVA: 0x009BA5F5 File Offset: 0x009B87F5
		public SGMOrderInfo(FName Name, string Code)
		{
			this.Name = Name;
			this.Code = Code;
		}

		// Token: 0x060290B2 RID: 168114 RVA: 0x009BA60B File Offset: 0x009B880B
		protected override IntPtr GetUStructPtr()
		{
			return SGMOrderInfo.StaticStruct();
		}

		// Token: 0x060290B3 RID: 168115 RVA: 0x009BA617 File Offset: 0x009B8817
		[NullableContext(2)]
		public SGMOrderInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060290B4 RID: 168116 RVA: 0x009BA621 File Offset: 0x009B8821
		public SGMOrderInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060290B5 RID: 168117 RVA: 0x009BA62C File Offset: 0x009B882C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGMOrderInfo(Pointer, false, true);
		}

		// Token: 0x060290B6 RID: 168118 RVA: 0x009BA636 File Offset: 0x009B8836
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGMOrderInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401501B RID: 86043
		public const string __ObjectPath = "/Game/Aki/Data/GMOrder/Struct/SGMOrderInfo.SGMOrderInfo";

		// Token: 0x0401501C RID: 86044
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401501D RID: 86045
		internal static int __PropertyOffset_0;

		// Token: 0x0401501E RID: 86046
		internal static int __PropertyOffset_1;
	}
}
