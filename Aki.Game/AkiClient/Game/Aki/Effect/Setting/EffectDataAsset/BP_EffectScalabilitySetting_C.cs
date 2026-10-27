using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scalability;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Effect.Setting.EffectDataAsset
{
	// Token: 0x02003E7A RID: 15994
	[UnrealObjectPath("/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectScalabilitySetting.BP_EffectScalabilitySetting_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class BP_EffectScalabilitySetting_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028543 RID: 165187 RVA: 0x009A9DA0 File Offset: 0x009A7FA0
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_EffectScalabilitySetting_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectScalabilitySetting.BP_EffectScalabilitySetting_C");
			}
			return BP_EffectScalabilitySetting_C._ClassPtr;
		}

		// Token: 0x06028544 RID: 165188 RVA: 0x009A9DC4 File Offset: 0x009A7FC4
		public BP_EffectScalabilitySetting_C() : this(BuiltinUtils.AllocNativeUObject(BP_EffectScalabilitySetting_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028545 RID: 165189 RVA: 0x009A9DEC File Offset: 0x009A7FEC
		[NullableContext(1)]
		public BP_EffectScalabilitySetting_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_EffectScalabilitySetting_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x06028546 RID: 165190 RVA: 0x009A9E20 File Offset: 0x009A8020
		// (set) Token: 0x06028547 RID: 165191 RVA: 0x009A9E59 File Offset: 0x009A8059
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> NiagaraSettings
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> result;
				if ((result = this._NiagaraSettings) == null)
				{
					result = (this._NiagaraSettings = new TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>>(base.NativePtr + (IntPtr)BP_EffectScalabilitySetting_C.__PropertyOffset_0, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1,
				1
			})]
			set
			{
				this.NiagaraSettings.CopyAssign(value);
			}
		}

		// Token: 0x06028548 RID: 165192 RVA: 0x009A9E67 File Offset: 0x009A8067
		protected BP_EffectScalabilitySetting_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040148CC RID: 84172
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Effect/Setting/EffectDataAsset/BP_EffectScalabilitySetting.BP_EffectScalabilitySetting_C";

		// Token: 0x040148CD RID: 84173
		private static IntPtr _ClassPtr;

		// Token: 0x040148CE RID: 84174
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040148CF RID: 84175
		internal static int __PropertyOffset_0;

		// Token: 0x040148D0 RID: 84176
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		private TMap<TEnumAsByte<EEffectScalabilityType>, TSoftObjectPtr<NiagaraScalabilitySetting>> _NiagaraSettings;
	}
}
