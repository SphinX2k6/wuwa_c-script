using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E45 RID: 15941
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRiverMeshInfo.SPCGRiverMeshInfo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class SPCGRiverMeshInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602810D RID: 164109 RVA: 0x009A3151 File Offset: 0x009A1351
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGRiverMeshInfo._ScriptStructPtr != 0) ? SPCGRiverMeshInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRiverMeshInfo.SPCGRiverMeshInfo", ref SPCGRiverMeshInfo._ScriptStructPtr);
		}

		// Token: 0x17005BA0 RID: 23456
		// (get) Token: 0x0602810E RID: 164110 RVA: 0x009A3175 File Offset: 0x009A1375
		// (set) Token: 0x0602810F RID: 164111 RVA: 0x009A3189 File Offset: 0x009A1389
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPCGRiverMeshInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPCGRiverMeshInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x06028110 RID: 164112 RVA: 0x009A31A0 File Offset: 0x009A13A0
		// (set) Token: 0x06028111 RID: 164113 RVA: 0x009A31E3 File Offset: 0x009A13E3
		public TArray<float> Location
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new TArray<float>(base.NativePtr + (IntPtr)SPCGRiverMeshInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Location.CopyAssign(value);
			}
		}

		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x06028112 RID: 164114 RVA: 0x009A31F4 File Offset: 0x009A13F4
		// (set) Token: 0x06028113 RID: 164115 RVA: 0x009A3237 File Offset: 0x009A1437
		public TArray<float> Rotation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TArray<float>(base.NativePtr + (IntPtr)SPCGRiverMeshInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x06028114 RID: 164116 RVA: 0x009A3245 File Offset: 0x009A1445
		public SPCGRiverMeshInfo()
		{
		}

		// Token: 0x06028115 RID: 164117 RVA: 0x009A324D File Offset: 0x009A144D
		public SPCGRiverMeshInfo(string Name, TArray<float> Location, TArray<float> Rotation)
		{
			this.Name = Name;
			this.Location = Location;
			this.Rotation = Rotation;
		}

		// Token: 0x06028116 RID: 164118 RVA: 0x009A326A File Offset: 0x009A146A
		protected override IntPtr GetUStructPtr()
		{
			return SPCGRiverMeshInfo.StaticStruct();
		}

		// Token: 0x06028117 RID: 164119 RVA: 0x009A3276 File Offset: 0x009A1476
		[NullableContext(2)]
		public SPCGRiverMeshInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028118 RID: 164120 RVA: 0x009A3280 File Offset: 0x009A1480
		public SPCGRiverMeshInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028119 RID: 164121 RVA: 0x009A328B File Offset: 0x009A148B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGRiverMeshInfo(Pointer, false, true);
		}

		// Token: 0x0602811A RID: 164122 RVA: 0x009A3295 File Offset: 0x009A1495
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGRiverMeshInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0401461D RID: 83485
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGRiverMeshInfo.SPCGRiverMeshInfo";

		// Token: 0x0401461E RID: 83486
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401461F RID: 83487
		internal static int __PropertyOffset_0;

		// Token: 0x04014620 RID: 83488
		internal static int __PropertyOffset_1;

		// Token: 0x04014621 RID: 83489
		[Nullable(2)]
		private TArray<float> _Location;

		// Token: 0x04014622 RID: 83490
		internal static int __PropertyOffset_2;

		// Token: 0x04014623 RID: 83491
		[Nullable(2)]
		private TArray<float> _Rotation;
	}
}
