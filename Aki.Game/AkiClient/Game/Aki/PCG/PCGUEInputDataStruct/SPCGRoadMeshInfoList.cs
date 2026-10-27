using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E48 RID: 15944
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRoadMeshInfoList.SPCGRoadMeshInfoList")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SPCGRoadMeshInfoList : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028133 RID: 164147 RVA: 0x009A34AE File Offset: 0x009A16AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGRoadMeshInfoList._ScriptStructPtr != 0) ? SPCGRoadMeshInfoList._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRoadMeshInfoList.SPCGRoadMeshInfoList", ref SPCGRoadMeshInfoList._ScriptStructPtr);
		}

		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x06028134 RID: 164148 RVA: 0x009A34D4 File Offset: 0x009A16D4
		// (set) Token: 0x06028135 RID: 164149 RVA: 0x009A3517 File Offset: 0x009A1717
		public TArray<SPCGRoadMeshInfo> RoadMeshList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SPCGRoadMeshInfo> result;
				if ((result = this._RoadMeshList) == null)
				{
					result = (this._RoadMeshList = new TArray<SPCGRoadMeshInfo>(base.NativePtr + (IntPtr)SPCGRoadMeshInfoList.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RoadMeshList.CopyAssign(value);
			}
		}

		// Token: 0x06028136 RID: 164150 RVA: 0x009A3525 File Offset: 0x009A1725
		public SPCGRoadMeshInfoList()
		{
		}

		// Token: 0x06028137 RID: 164151 RVA: 0x009A352D File Offset: 0x009A172D
		public SPCGRoadMeshInfoList(TArray<SPCGRoadMeshInfo> RoadMeshList)
		{
			this.RoadMeshList = RoadMeshList;
		}

		// Token: 0x06028138 RID: 164152 RVA: 0x009A353C File Offset: 0x009A173C
		protected override IntPtr GetUStructPtr()
		{
			return SPCGRoadMeshInfoList.StaticStruct();
		}

		// Token: 0x06028139 RID: 164153 RVA: 0x009A3548 File Offset: 0x009A1748
		[NullableContext(2)]
		public SPCGRoadMeshInfoList(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602813A RID: 164154 RVA: 0x009A3552 File Offset: 0x009A1752
		public SPCGRoadMeshInfoList(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602813B RID: 164155 RVA: 0x009A355D File Offset: 0x009A175D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGRoadMeshInfoList(Pointer, false, true);
		}

		// Token: 0x0602813C RID: 164156 RVA: 0x009A3567 File Offset: 0x009A1767
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGRoadMeshInfoList(Pointer, MemoryOwner);
		}

		// Token: 0x0401462F RID: 83503
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRoadMeshInfoList.SPCGRoadMeshInfoList";

		// Token: 0x04014630 RID: 83504
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014631 RID: 83505
		internal static int __PropertyOffset_0;

		// Token: 0x04014632 RID: 83506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SPCGRoadMeshInfo> _RoadMeshList;
	}
}
