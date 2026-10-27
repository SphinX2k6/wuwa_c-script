using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PSOSwitchSettingDebug.Niagara
{
	// Token: 0x02003BCF RID: 15311
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/Niagara/PDA_PSONiagaraMaterialList.PDA_PSONiagaraMaterialList_C")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class PDA_PSONiagaraMaterialList_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060225B3 RID: 140723 RVA: 0x00906B4C File Offset: 0x00904D4C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_PSONiagaraMaterialList_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/Niagara/PDA_PSONiagaraMaterialList.PDA_PSONiagaraMaterialList_C");
			}
			return PDA_PSONiagaraMaterialList_C._ClassPtr;
		}

		// Token: 0x060225B4 RID: 140724 RVA: 0x00906B70 File Offset: 0x00904D70
		public PDA_PSONiagaraMaterialList_C() : this(BuiltinUtils.AllocNativeUObject(PDA_PSONiagaraMaterialList_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060225B5 RID: 140725 RVA: 0x00906B98 File Offset: 0x00904D98
		public PDA_PSONiagaraMaterialList_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_PSONiagaraMaterialList_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x060225B6 RID: 140726 RVA: 0x00906BCC File Offset: 0x00904DCC
		// (set) Token: 0x060225B7 RID: 140727 RVA: 0x00906C05 File Offset: 0x00904E05
		public TArray<UMaterialInterface> Materials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._Materials) == null)
				{
					result = (this._Materials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)PDA_PSONiagaraMaterialList_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.Materials.CopyAssign(value);
			}
		}

		// Token: 0x060225B8 RID: 140728 RVA: 0x00906C13 File Offset: 0x00904E13
		protected PDA_PSONiagaraMaterialList_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DB6 RID: 69046
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PSOSwitchSettingDebug/Niagara/PDA_PSONiagaraMaterialList.PDA_PSONiagaraMaterialList_C";

		// Token: 0x04010DB7 RID: 69047
		private static IntPtr _ClassPtr;

		// Token: 0x04010DB8 RID: 69048
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DB9 RID: 69049
		internal static int __PropertyOffset_0;

		// Token: 0x04010DBA RID: 69050
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _Materials;
	}
}
