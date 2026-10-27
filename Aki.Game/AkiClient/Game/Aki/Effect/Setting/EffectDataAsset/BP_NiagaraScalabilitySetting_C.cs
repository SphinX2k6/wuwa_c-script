using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E7B RID: 15995
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_NiagaraScalabilitySetting.BP_NiagaraScalabilitySetting_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_NiagaraScalabilitySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028549 RID: 165193 RVA: 0x009A9E70 File Offset: 0x009A8070
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_NiagaraScalabilitySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_NiagaraScalabilitySetting.BP_NiagaraScalabilitySetting_C");
			}
			return BP_NiagaraScalabilitySetting_C._ClassPtr;
		}

		// Token: 0x0602854A RID: 165194 RVA: 0x009A9E94 File Offset: 0x009A8094
		public BP_NiagaraScalabilitySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_NiagaraScalabilitySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602854B RID: 165195 RVA: 0x009A9EBC File Offset: 0x009A80BC
		[NullableContext(1)]
		public BP_NiagaraScalabilitySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_NiagaraScalabilitySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D31 RID: 23857
		// (get) Token: 0x0602854C RID: 165196 RVA: 0x009A9EF0 File Offset: 0x009A80F0
		// (set) Token: 0x0602854D RID: 165197 RVA: 0x009A9F29 File Offset: 0x009A8129
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<TEnumAsByte<ENiagaraScalabilityType>, UNiagaraEffectType> NiagaraEffectTypes
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
				TMap<TEnumAsByte<ENiagaraScalabilityType>, UNiagaraEffectType> result;
				if ((result = this._NiagaraEffectTypes) == null)
				{
					result = (this._NiagaraEffectTypes = new TMap<TEnumAsByte<ENiagaraScalabilityType>, UNiagaraEffectType>(base.NativePtr + (IntPtr)BP_NiagaraScalabilitySetting_C.__PropertyOffset_0, this));
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
				this.NiagaraEffectTypes.CopyAssign(value);
			}
		}

		// Token: 0x0602854E RID: 165198 RVA: 0x009A9F37 File Offset: 0x009A8137
		protected BP_NiagaraScalabilitySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040148D1 RID: 84177
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_NiagaraScalabilitySetting.BP_NiagaraScalabilitySetting_C";

		// Token: 0x040148D2 RID: 84178
		private static IntPtr _ClassPtr;

		// Token: 0x040148D3 RID: 84179
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040148D4 RID: 84180
		internal static int __PropertyOffset_0;

		// Token: 0x040148D5 RID: 84181
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<TEnumAsByte<ENiagaraScalabilityType>, UNiagaraEffectType> _NiagaraEffectTypes;
	}
}
