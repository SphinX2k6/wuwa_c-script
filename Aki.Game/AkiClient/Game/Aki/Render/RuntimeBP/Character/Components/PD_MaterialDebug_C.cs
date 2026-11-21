using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Character.Components
{
	// Token: 0x0200313E RID: 12606
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Character/Components/PD_MaterialDebug.PD_MaterialDebug_C")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class PD_MaterialDebug_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFFC RID: 126972 RVA: 0x00923ADF File Offset: 0x00921CDF
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MaterialDebug_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Character/Components/PD_MaterialDebug.PD_MaterialDebug_C");
			}
			return PD_MaterialDebug_C._ClassPtr;
		}

		// Token: 0x0601EFFD RID: 126973 RVA: 0x00923B04 File Offset: 0x00921D04
		public PD_MaterialDebug_C() : this(BuiltinUtils.AllocNativeUObject(PD_MaterialDebug_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EFFE RID: 126974 RVA: 0x00923B2C File Offset: 0x00921D2C
		public PD_MaterialDebug_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MaterialDebug_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0601EFFF RID: 126975 RVA: 0x00923B60 File Offset: 0x00921D60
		// (set) Token: 0x0601F000 RID: 126976 RVA: 0x00923B99 File Offset: 0x00921D99
		public TMap<int, string> MaterialControllerList
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, string> result;
				if ((result = this._MaterialControllerList) == null)
				{
					result = (this._MaterialControllerList = new TMap<int, string>(base.NativePtr + (IntPtr)PD_MaterialDebug_C.__PropertyOffset_MaterialControllerList, this));
				}
				return result;
			}
			set
			{
				this.MaterialControllerList.CopyAssign(value);
			}
		}

		// Token: 0x0601F001 RID: 126977 RVA: 0x00923BA7 File Offset: 0x00921DA7
		protected PD_MaterialDebug_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401084D RID: 67661
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Character/Components/PD_MaterialDebug.PD_MaterialDebug_C";

		// Token: 0x0401084E RID: 67662
		private static IntPtr _ClassPtr;

		// Token: 0x0401084F RID: 67663
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010850 RID: 67664
		internal static int __PropertyOffset_MaterialControllerList;

		// Token: 0x04010851 RID: 67665
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, string> _MaterialControllerList;
	}
}
