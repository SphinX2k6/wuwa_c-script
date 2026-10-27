using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E46 RID: 15942
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRiverMeshInfoList.SPCGRiverMeshInfoList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SPCGRiverMeshInfoList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602811B RID: 164123 RVA: 0x009A329E File Offset: 0x009A149E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGRiverMeshInfoList._ScriptStructPtr != 0) ? SPCGRiverMeshInfoList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRiverMeshInfoList.SPCGRiverMeshInfoList", ref SPCGRiverMeshInfoList._ScriptStructPtr);
		}

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x0602811C RID: 164124 RVA: 0x009A32C4 File Offset: 0x009A14C4
		// (set) Token: 0x0602811D RID: 164125 RVA: 0x009A3307 File Offset: 0x009A1507
		public TArray<SPCGRiverMeshInfo> RiverMeshList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPCGRiverMeshInfo> result;
				if ((result = this._RiverMeshList) == null)
				{
					result = (this._RiverMeshList = new TArray<SPCGRiverMeshInfo>(base.NativePtr + (IntPtr)SPCGRiverMeshInfoList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RiverMeshList.CopyAssign(value);
			}
		}

		// Token: 0x0602811E RID: 164126 RVA: 0x009A3315 File Offset: 0x009A1515
		public SPCGRiverMeshInfoList()
		{
		}

		// Token: 0x0602811F RID: 164127 RVA: 0x009A331D File Offset: 0x009A151D
		public SPCGRiverMeshInfoList(TArray<SPCGRiverMeshInfo> RiverMeshList)
		{
			this.RiverMeshList = RiverMeshList;
		}

		// Token: 0x06028120 RID: 164128 RVA: 0x009A332C File Offset: 0x009A152C
		protected override IntPtr GetUStructPtr()
		{
			return SPCGRiverMeshInfoList.StaticStruct();
		}

		// Token: 0x06028121 RID: 164129 RVA: 0x009A3338 File Offset: 0x009A1538
		[NullableContext(2)]
		public SPCGRiverMeshInfoList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028122 RID: 164130 RVA: 0x009A3342 File Offset: 0x009A1542
		public SPCGRiverMeshInfoList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028123 RID: 164131 RVA: 0x009A334D File Offset: 0x009A154D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGRiverMeshInfoList(Pointer, false, true);
		}

		// Token: 0x06028124 RID: 164132 RVA: 0x009A3357 File Offset: 0x009A1557
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGRiverMeshInfoList(Pointer, MemoryOwner);
		}

		// Token: 0x04014624 RID: 83492
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRiverMeshInfoList.SPCGRiverMeshInfoList";

		// Token: 0x04014625 RID: 83493
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014626 RID: 83494
		internal static int __PropertyOffset_0;

		// Token: 0x04014627 RID: 83495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPCGRiverMeshInfo> _RiverMeshList;
	}
}
