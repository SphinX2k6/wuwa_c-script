using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Weather.BP.Thunder
{
	// Token: 0x02003A83 RID: 14979
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_ThunderConfigMap.PDA_ThunderConfigMap_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PDA_ThunderConfigMap_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FC94 RID: 130196 RVA: 0x008C29F4 File Offset: 0x008C0BF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_ThunderConfigMap_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_ThunderConfigMap.PDA_ThunderConfigMap_C");
			}
			return PDA_ThunderConfigMap_C._ClassPtr;
		}

		// Token: 0x0601FC95 RID: 130197 RVA: 0x008C2A18 File Offset: 0x008C0C18
		public PDA_ThunderConfigMap_C() : this(BuiltinUtils.AllocNativeUObject(PDA_ThunderConfigMap_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FC96 RID: 130198 RVA: 0x008C2A40 File Offset: 0x008C0C40
		[NullableContext(1)]
		public PDA_ThunderConfigMap_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_ThunderConfigMap_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0601FC97 RID: 130199 RVA: 0x008C2A74 File Offset: 0x008C0C74
		// (set) Token: 0x0601FC98 RID: 130200 RVA: 0x008C2AAD File Offset: 0x008C0CAD
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<EKuroThunderType>, PDA_ThunderConfig_C> Data
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EKuroThunderType>, PDA_ThunderConfig_C> result;
				if ((result = this._Data) == null)
				{
					result = (this._Data = new TMap<TEnumAsByte<EKuroThunderType>, PDA_ThunderConfig_C>(base.NativePtr + (IntPtr)PDA_ThunderConfigMap_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.Data.CopyAssign(value);
			}
		}

		// Token: 0x0601FC99 RID: 130201 RVA: 0x008C2ABB File Offset: 0x008C0CBB
		protected PDA_ThunderConfigMap_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F515 RID: 62741
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Weather/BP/Thunder/PDA_ThunderConfigMap.PDA_ThunderConfigMap_C";

		// Token: 0x0400F516 RID: 62742
		private static IntPtr _ClassPtr;

		// Token: 0x0400F517 RID: 62743
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F518 RID: 62744
		internal static int __PropertyOffset_0;

		// Token: 0x0400F519 RID: 62745
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<EKuroThunderType>, PDA_ThunderConfig_C> _Data;
	}
}
