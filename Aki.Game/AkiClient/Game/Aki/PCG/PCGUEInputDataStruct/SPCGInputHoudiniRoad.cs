using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E43 RID: 15939
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGInputHoudiniRoad.SPCGInputHoudiniRoad")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SPCGInputHoudiniRoad : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060280F5 RID: 164085 RVA: 0x009A2ED4 File Offset: 0x009A10D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGInputHoudiniRoad._ScriptStructPtr != 0) ? SPCGInputHoudiniRoad._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGInputHoudiniRoad.SPCGInputHoudiniRoad", ref SPCGInputHoudiniRoad._ScriptStructPtr);
		}

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x060280F6 RID: 164086 RVA: 0x009A2EF8 File Offset: 0x009A10F8
		// (set) Token: 0x060280F7 RID: 164087 RVA: 0x009A2F3B File Offset: 0x009A113B
		public SPCGRoadMeshInfoList RoadMeshInfo
		{
			get
			{
				base.FastCheckIsValid();
				SPCGRoadMeshInfoList result;
				if ((result = this._RoadMeshInfo) == null)
				{
					result = (this._RoadMeshInfo = new SPCGRoadMeshInfoList(base.NativePtr + (IntPtr)SPCGInputHoudiniRoad.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SPCGRoadMeshInfoList.StaticStruct(), base.NativePtr + (IntPtr)SPCGInputHoudiniRoad.__PropertyOffset_0, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060280F8 RID: 164088 RVA: 0x009A2F5C File Offset: 0x009A115C
		public SPCGInputHoudiniRoad()
		{
		}

		// Token: 0x060280F9 RID: 164089 RVA: 0x009A2F64 File Offset: 0x009A1164
		public SPCGInputHoudiniRoad(SPCGRoadMeshInfoList RoadMeshInfo)
		{
			this.RoadMeshInfo = RoadMeshInfo;
		}

		// Token: 0x060280FA RID: 164090 RVA: 0x009A2F73 File Offset: 0x009A1173
		protected override IntPtr GetUStructPtr()
		{
			return SPCGInputHoudiniRoad.StaticStruct();
		}

		// Token: 0x060280FB RID: 164091 RVA: 0x009A2F7F File Offset: 0x009A117F
		[NullableContext(2)]
		public SPCGInputHoudiniRoad(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060280FC RID: 164092 RVA: 0x009A2F89 File Offset: 0x009A1189
		public SPCGInputHoudiniRoad(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060280FD RID: 164093 RVA: 0x009A2F94 File Offset: 0x009A1194
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGInputHoudiniRoad(Pointer, false, true);
		}

		// Token: 0x060280FE RID: 164094 RVA: 0x009A2F9E File Offset: 0x009A119E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGInputHoudiniRoad(Pointer, MemoryOwner);
		}

		// Token: 0x04014611 RID: 83473
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGInputHoudiniRoad.SPCGInputHoudiniRoad";

		// Token: 0x04014612 RID: 83474
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014613 RID: 83475
		internal static int __PropertyOffset_0;

		// Token: 0x04014614 RID: 83476
		[Nullable(2)]
		private SPCGRoadMeshInfoList _RoadMeshInfo;
	}
}
