using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E47 RID: 15943
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRoadMeshInfo.SPCGRoadMeshInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SPCGRoadMeshInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028125 RID: 164133 RVA: 0x009A3360 File Offset: 0x009A1560
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGRoadMeshInfo._ScriptStructPtr != 0) ? SPCGRoadMeshInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRoadMeshInfo.SPCGRoadMeshInfo", ref SPCGRoadMeshInfo._ScriptStructPtr);
		}

		// Token: 0x17005BA4 RID: 23460
		// (get) Token: 0x06028126 RID: 164134 RVA: 0x009A3384 File Offset: 0x009A1584
		// (set) Token: 0x06028127 RID: 164135 RVA: 0x009A3398 File Offset: 0x009A1598
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPCGRoadMeshInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPCGRoadMeshInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x06028128 RID: 164136 RVA: 0x009A33B0 File Offset: 0x009A15B0
		// (set) Token: 0x06028129 RID: 164137 RVA: 0x009A33F3 File Offset: 0x009A15F3
		public TArray<float> Location
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new TArray<float>(base.NativePtr + (IntPtr)SPCGRoadMeshInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Location.CopyAssign(value);
			}
		}

		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x0602812A RID: 164138 RVA: 0x009A3404 File Offset: 0x009A1604
		// (set) Token: 0x0602812B RID: 164139 RVA: 0x009A3447 File Offset: 0x009A1647
		public TArray<float> Rotation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TArray<float>(base.NativePtr + (IntPtr)SPCGRoadMeshInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x0602812C RID: 164140 RVA: 0x009A3455 File Offset: 0x009A1655
		public SPCGRoadMeshInfo()
		{
		}

		// Token: 0x0602812D RID: 164141 RVA: 0x009A345D File Offset: 0x009A165D
		public SPCGRoadMeshInfo(string Name, TArray<float> Location, TArray<float> Rotation)
		{
			this.Name = Name;
			this.Location = Location;
			this.Rotation = Rotation;
		}

		// Token: 0x0602812E RID: 164142 RVA: 0x009A347A File Offset: 0x009A167A
		protected override IntPtr GetUStructPtr()
		{
			return SPCGRoadMeshInfo.StaticStruct();
		}

		// Token: 0x0602812F RID: 164143 RVA: 0x009A3486 File Offset: 0x009A1686
		[NullableContext(2)]
		public SPCGRoadMeshInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028130 RID: 164144 RVA: 0x009A3490 File Offset: 0x009A1690
		public SPCGRoadMeshInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028131 RID: 164145 RVA: 0x009A349B File Offset: 0x009A169B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGRoadMeshInfo(Pointer, false, true);
		}

		// Token: 0x06028132 RID: 164146 RVA: 0x009A34A5 File Offset: 0x009A16A5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGRoadMeshInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014628 RID: 83496
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRoadMeshInfo.SPCGRoadMeshInfo";

		// Token: 0x04014629 RID: 83497
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401462A RID: 83498
		internal static int __PropertyOffset_0;

		// Token: 0x0401462B RID: 83499
		internal static int __PropertyOffset_1;

		// Token: 0x0401462C RID: 83500
		[Nullable(2)]
		private TArray<float> _Location;

		// Token: 0x0401462D RID: 83501
		internal static int __PropertyOffset_2;

		// Token: 0x0401462E RID: 83502
		[Nullable(2)]
		private TArray<float> _Rotation;
	}
}
