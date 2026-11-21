using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.RenderData
{
	// Token: 0x020030D8 RID: 12504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/RenderData/ItemMaterialControllerMPCData.ItemMaterialControllerMPCData_C")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class ItemMaterialControllerMPCData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E2B3 RID: 123571 RVA: 0x0090CD5F File Offset: 0x0090AF5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ItemMaterialControllerMPCData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/RenderData/ItemMaterialControllerMPCData.ItemMaterialControllerMPCData_C");
			}
			return ItemMaterialControllerMPCData_C._ClassPtr;
		}

		// Token: 0x0601E2B4 RID: 123572 RVA: 0x0090CD84 File Offset: 0x0090AF84
		public ItemMaterialControllerMPCData_C() : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerMPCData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E2B5 RID: 123573 RVA: 0x0090CDAC File Offset: 0x0090AFAC
		public ItemMaterialControllerMPCData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ItemMaterialControllerMPCData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0601E2B6 RID: 123574 RVA: 0x0090CDE0 File Offset: 0x0090AFE0
		// (set) Token: 0x0601E2B7 RID: 123575 RVA: 0x0090CE19 File Offset: 0x0090B019
		public TMap<string, FLinearColor> Vector
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FLinearColor> result;
				if ((result = this._Vector) == null)
				{
					result = (this._Vector = new TMap<string, FLinearColor>(base.NativePtr + (IntPtr)ItemMaterialControllerMPCData_C.__PropertyOffset_Vector, this));
				}
				return result;
			}
			set
			{
				this.Vector.CopyAssign(value);
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0601E2B8 RID: 123576 RVA: 0x0090CE28 File Offset: 0x0090B028
		// (set) Token: 0x0601E2B9 RID: 123577 RVA: 0x0090CE61 File Offset: 0x0090B061
		public TMap<string, float> Scalar
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, float> result;
				if ((result = this._Scalar) == null)
				{
					result = (this._Scalar = new TMap<string, float>(base.NativePtr + (IntPtr)ItemMaterialControllerMPCData_C.__PropertyOffset_Scalar, this));
				}
				return result;
			}
			set
			{
				this.Scalar.CopyAssign(value);
			}
		}

		// Token: 0x0601E2BA RID: 123578 RVA: 0x0090CE6F File Offset: 0x0090B06F
		protected ItemMaterialControllerMPCData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FF59 RID: 65369
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/RenderData/ItemMaterialControllerMPCData.ItemMaterialControllerMPCData_C";

		// Token: 0x0400FF5A RID: 65370
		private static IntPtr _ClassPtr;

		// Token: 0x0400FF5B RID: 65371
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FF5C RID: 65372
		internal static int __PropertyOffset_Vector;

		// Token: 0x0400FF5D RID: 65373
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, FLinearColor> _Vector;

		// Token: 0x0400FF5E RID: 65374
		internal static int __PropertyOffset_Scalar;

		// Token: 0x0400FF5F RID: 65375
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, float> _Scalar;
	}
}
