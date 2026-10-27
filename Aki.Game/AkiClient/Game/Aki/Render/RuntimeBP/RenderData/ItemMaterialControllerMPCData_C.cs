using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.RenderData
{
	// Token: 0x02003BBA RID: 15290
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/RenderData/ItemMaterialControllerMPCData.ItemMaterialControllerMPCData_C")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class ItemMaterialControllerMPCData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602229D RID: 139933 RVA: 0x0090154C File Offset: 0x008FF74C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ItemMaterialControllerMPCData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/RenderData/ItemMaterialControllerMPCData.ItemMaterialControllerMPCData_C");
			}
			return ItemMaterialControllerMPCData_C._ClassPtr;
		}

		// Token: 0x0602229E RID: 139934 RVA: 0x00901570 File Offset: 0x008FF770
		public ItemMaterialControllerMPCData_C() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerMPCData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602229F RID: 139935 RVA: 0x00901598 File Offset: 0x008FF798
		public ItemMaterialControllerMPCData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerMPCData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x060222A0 RID: 139936 RVA: 0x009015CC File Offset: 0x008FF7CC
		// (set) Token: 0x060222A1 RID: 139937 RVA: 0x00901605 File Offset: 0x008FF805
		public TMap<string, FLinearColor> Vector
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FLinearColor> result;
				if ((result = this._Vector) == null)
				{
					result = (this._Vector = new TMap<string, FLinearColor>(base.NativePtr + (IntPtr)ItemMaterialControllerMPCData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.Vector.CopyAssign(value);
			}
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x060222A2 RID: 139938 RVA: 0x00901614 File Offset: 0x008FF814
		// (set) Token: 0x060222A3 RID: 139939 RVA: 0x0090164D File Offset: 0x008FF84D
		public TMap<string, float> Scalar
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._Scalar) == null)
				{
					result = (this._Scalar = new TMap<string, float>(base.NativePtr + (IntPtr)ItemMaterialControllerMPCData_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.Scalar.CopyAssign(value);
			}
		}

		// Token: 0x060222A4 RID: 139940 RVA: 0x0090165B File Offset: 0x008FF85B
		protected ItemMaterialControllerMPCData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010BCA RID: 68554
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/RenderData/ItemMaterialControllerMPCData.ItemMaterialControllerMPCData_C";

		// Token: 0x04010BCB RID: 68555
		private static IntPtr _ClassPtr;

		// Token: 0x04010BCC RID: 68556
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010BCD RID: 68557
		internal static int __PropertyOffset_0;

		// Token: 0x04010BCE RID: 68558
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FLinearColor> _Vector;

		// Token: 0x04010BCF RID: 68559
		internal static int __PropertyOffset_1;

		// Token: 0x04010BD0 RID: 68560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _Scalar;
	}
}
