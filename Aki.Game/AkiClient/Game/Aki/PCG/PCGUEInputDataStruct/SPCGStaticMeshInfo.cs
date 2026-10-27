using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.PCG.PCGUEInputDataStruct
{
	// Token: 0x02003E49 RID: 15945
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGStaticMeshInfo.SPCGStaticMeshInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class SPCGStaticMeshInfo : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602813D RID: 164157 RVA: 0x009A3570 File Offset: 0x009A1770
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPCGStaticMeshInfo._ScriptStructPtr != 0) ? SPCGStaticMeshInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/PCG/PCGUEInputDataStruct/SPCGStaticMeshInfo.SPCGStaticMeshInfo", ref SPCGStaticMeshInfo._ScriptStructPtr);
		}

		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x0602813E RID: 164158 RVA: 0x009A3594 File Offset: 0x009A1794
		// (set) Token: 0x0602813F RID: 164159 RVA: 0x009A35A8 File Offset: 0x009A17A8
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPCGStaticMeshInfo.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPCGStaticMeshInfo.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x06028140 RID: 164160 RVA: 0x009A35C0 File Offset: 0x009A17C0
		// (set) Token: 0x06028141 RID: 164161 RVA: 0x009A3603 File Offset: 0x009A1803
		public TArray<float> Location
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new TArray<float>(base.NativePtr + (IntPtr)SPCGStaticMeshInfo.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Location.CopyAssign(value);
			}
		}

		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x06028142 RID: 164162 RVA: 0x009A3614 File Offset: 0x009A1814
		// (set) Token: 0x06028143 RID: 164163 RVA: 0x009A3657 File Offset: 0x009A1857
		public TArray<float> Rotation
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TArray<float>(base.NativePtr + (IntPtr)SPCGStaticMeshInfo.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x06028144 RID: 164164 RVA: 0x009A3668 File Offset: 0x009A1868
		// (set) Token: 0x06028145 RID: 164165 RVA: 0x009A36AB File Offset: 0x009A18AB
		public TArray<float> Scale
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new TArray<float>(base.NativePtr + (IntPtr)SPCGStaticMeshInfo.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Scale.CopyAssign(value);
			}
		}

		// Token: 0x06028146 RID: 164166 RVA: 0x009A36B9 File Offset: 0x009A18B9
		public SPCGStaticMeshInfo()
		{
		}

		// Token: 0x06028147 RID: 164167 RVA: 0x009A36C1 File Offset: 0x009A18C1
		public SPCGStaticMeshInfo(string Name, TArray<float> Location, TArray<float> Rotation, TArray<float> Scale)
		{
			this.Name = Name;
			this.Location = Location;
			this.Rotation = Rotation;
			this.Scale = Scale;
		}

		// Token: 0x06028148 RID: 164168 RVA: 0x009A36E6 File Offset: 0x009A18E6
		protected override IntPtr GetUStructPtr()
		{
			return SPCGStaticMeshInfo.StaticStruct();
		}

		// Token: 0x06028149 RID: 164169 RVA: 0x009A36F2 File Offset: 0x009A18F2
		[NullableContext(2)]
		public SPCGStaticMeshInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602814A RID: 164170 RVA: 0x009A36FC File Offset: 0x009A18FC
		public SPCGStaticMeshInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602814B RID: 164171 RVA: 0x009A3707 File Offset: 0x009A1907
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPCGStaticMeshInfo(Pointer, false, true);
		}

		// Token: 0x0602814C RID: 164172 RVA: 0x009A3711 File Offset: 0x009A1911
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPCGStaticMeshInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04014633 RID: 83507
		public const string __ObjectPath = "/Game/Aki/PCG/PCGUEInputDataStruct/SPCGStaticMeshInfo.SPCGStaticMeshInfo";

		// Token: 0x04014634 RID: 83508
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014635 RID: 83509
		internal static int __PropertyOffset_0;

		// Token: 0x04014636 RID: 83510
		internal static int __PropertyOffset_1;

		// Token: 0x04014637 RID: 83511
		[Nullable(2)]
		private TArray<float> _Location;

		// Token: 0x04014638 RID: 83512
		internal static int __PropertyOffset_2;

		// Token: 0x04014639 RID: 83513
		[Nullable(2)]
		private TArray<float> _Rotation;

		// Token: 0x0401463A RID: 83514
		internal static int __PropertyOffset_3;

		// Token: 0x0401463B RID: 83515
		[Nullable(2)]
		private TArray<float> _Scale;
	}
}
