using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.KuroSceneSwitch
{
	// Token: 0x02003D03 RID: 15619
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/PD_SceneDissovleMats.PD_SceneDissovleMats_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PD_SceneDissovleMats_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025568 RID: 152936 RVA: 0x00957623 File Offset: 0x00955823
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_SceneDissovleMats_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/PD_SceneDissovleMats.PD_SceneDissovleMats_C");
			}
			return PD_SceneDissovleMats_C._ClassPtr;
		}

		// Token: 0x06025569 RID: 152937 RVA: 0x00957648 File Offset: 0x00955848
		public PD_SceneDissovleMats_C() : this(BuiltinUtils.AllocNativeUObject(PD_SceneDissovleMats_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602556A RID: 152938 RVA: 0x00957670 File Offset: 0x00955870
		public PD_SceneDissovleMats_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_SceneDissovleMats_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C17 RID: 19479
		// (get) Token: 0x0602556B RID: 152939 RVA: 0x009576A4 File Offset: 0x009558A4
		// (set) Token: 0x0602556C RID: 152940 RVA: 0x009576DD File Offset: 0x009558DD
		public TArray<UMaterialInstanceConstant> MATS
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceConstant> result;
				if ((result = this._MATS) == null)
				{
					result = (this._MATS = new TArray<UMaterialInstanceConstant>(base.NativePtr + (IntPtr)PD_SceneDissovleMats_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MATS.CopyAssign(value);
			}
		}

		// Token: 0x0602556D RID: 152941 RVA: 0x009576EB File Offset: 0x009558EB
		protected PD_SceneDissovleMats_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040129EA RID: 76266
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/KuroSceneSwitch/PD_SceneDissovleMats.PD_SceneDissovleMats_C";

		// Token: 0x040129EB RID: 76267
		private static IntPtr _ClassPtr;

		// Token: 0x040129EC RID: 76268
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040129ED RID: 76269
		internal static int __PropertyOffset_0;

		// Token: 0x040129EE RID: 76270
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceConstant> _MATS;
	}
}
