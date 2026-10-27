using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E44 RID: 15940
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGInputUnrealInfo.SPCGInputUnrealInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SPCGInputUnrealInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280FF RID: 164095 RVA: 0x009A2FA7 File Offset: 0x009A11A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGInputUnrealInfo._ScriptStructPtr != 0) ? SPCGInputUnrealInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGInputUnrealInfo.SPCGInputUnrealInfo", ref SPCGInputUnrealInfo._ScriptStructPtr);
		}

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x06028100 RID: 164096 RVA: 0x009A2FCC File Offset: 0x009A11CC
		// (set) Token: 0x06028101 RID: 164097 RVA: 0x009A300F File Offset: 0x009A120F
		public SPCGRiverMeshInfoList RiverMeshInfo
		{
			get
			{
				base.FastCheckIsValid();
				SPCGRiverMeshInfoList result;
				if ((result = this._RiverMeshInfo) == null)
				{
					result = (this._RiverMeshInfo = new SPCGRiverMeshInfoList(base.NativePtr + (IntPtr)SPCGInputUnrealInfo.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCGRiverMeshInfoList.StaticStruct(), base.NativePtr + (IntPtr)SPCGInputUnrealInfo.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x06028102 RID: 164098 RVA: 0x009A3030 File Offset: 0x009A1230
		// (set) Token: 0x06028103 RID: 164099 RVA: 0x009A3073 File Offset: 0x009A1273
		public SPCGRoadMeshInfoList RoadMeshInfo
		{
			get
			{
				base.FastCheckIsValid();
				SPCGRoadMeshInfoList result;
				if ((result = this._RoadMeshInfo) == null)
				{
					result = (this._RoadMeshInfo = new SPCGRoadMeshInfoList(base.NativePtr + (IntPtr)SPCGInputUnrealInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCGRoadMeshInfoList.StaticStruct(), base.NativePtr + (IntPtr)SPCGInputUnrealInfo.__PropertyOffset_1, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005B9F RID: 23455
		// (get) Token: 0x06028104 RID: 164100 RVA: 0x009A3094 File Offset: 0x009A1294
		// (set) Token: 0x06028105 RID: 164101 RVA: 0x009A30D7 File Offset: 0x009A12D7
		public SPCGStaticMeshInfoList StaticMeshInfo
		{
			get
			{
				base.FastCheckIsValid();
				SPCGStaticMeshInfoList result;
				if ((result = this._StaticMeshInfo) == null)
				{
					result = (this._StaticMeshInfo = new SPCGStaticMeshInfoList(base.NativePtr + (IntPtr)SPCGInputUnrealInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCGStaticMeshInfoList.StaticStruct(), base.NativePtr + (IntPtr)SPCGInputUnrealInfo.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06028106 RID: 164102 RVA: 0x009A30F8 File Offset: 0x009A12F8
		public SPCGInputUnrealInfo()
		{
		}

		// Token: 0x06028107 RID: 164103 RVA: 0x009A3100 File Offset: 0x009A1300
		public SPCGInputUnrealInfo(SPCGRiverMeshInfoList RiverMeshInfo, SPCGRoadMeshInfoList RoadMeshInfo, SPCGStaticMeshInfoList StaticMeshInfo)
		{
			this.RiverMeshInfo = RiverMeshInfo;
			this.RoadMeshInfo = RoadMeshInfo;
			this.StaticMeshInfo = StaticMeshInfo;
		}

		// Token: 0x06028108 RID: 164104 RVA: 0x009A311D File Offset: 0x009A131D
		protected override IntPtr GetUStructPtr()
		{
			return SPCGInputUnrealInfo.StaticStruct();
		}

		// Token: 0x06028109 RID: 164105 RVA: 0x009A3129 File Offset: 0x009A1329
		[NullableContext(2)]
		public SPCGInputUnrealInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602810A RID: 164106 RVA: 0x009A3133 File Offset: 0x009A1333
		public SPCGInputUnrealInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602810B RID: 164107 RVA: 0x009A313E File Offset: 0x009A133E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGInputUnrealInfo(Pointer, false, true);
		}

		// Token: 0x0602810C RID: 164108 RVA: 0x009A3148 File Offset: 0x009A1348
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGInputUnrealInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014615 RID: 83477
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGInputUnrealInfo.SPCGInputUnrealInfo";

		// Token: 0x04014616 RID: 83478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014617 RID: 83479
		internal static int __PropertyOffset_0;

		// Token: 0x04014618 RID: 83480
		[Nullable(2)]
		private SPCGRiverMeshInfoList _RiverMeshInfo;

		// Token: 0x04014619 RID: 83481
		internal static int __PropertyOffset_1;

		// Token: 0x0401461A RID: 83482
		[Nullable(2)]
		private SPCGRoadMeshInfoList _RoadMeshInfo;

		// Token: 0x0401461B RID: 83483
		internal static int __PropertyOffset_2;

		// Token: 0x0401461C RID: 83484
		[Nullable(2)]
		private SPCGStaticMeshInfoList _StaticMeshInfo;
	}
}
