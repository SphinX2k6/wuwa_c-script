using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff
{
	// Token: 0x02003114 RID: 12564
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/PDA_FoliageClusteredEffectConfig.PDA_FoliageClusteredEffectConfig_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 108)]
	public class PDA_FoliageClusteredEffectConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC79 RID: 126073 RVA: 0x0091D1FC File Offset: 0x0091B3FC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_FoliageClusteredEffectConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/PDA_FoliageClusteredEffectConfig.PDA_FoliageClusteredEffectConfig_C");
			}
			return PDA_FoliageClusteredEffectConfig_C._ClassPtr;
		}

		// Token: 0x0601EC7A RID: 126074 RVA: 0x0091D220 File Offset: 0x0091B420
		public PDA_FoliageClusteredEffectConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_FoliageClusteredEffectConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC7B RID: 126075 RVA: 0x0091D248 File Offset: 0x0091B448
		public PDA_FoliageClusteredEffectConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_FoliageClusteredEffectConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0601EC7C RID: 126076 RVA: 0x0091D27C File Offset: 0x0091B47C
		// (set) Token: 0x0601EC7D RID: 126077 RVA: 0x0091D2B5 File Offset: 0x0091B4B5
		public TArray<SFoliageClusteredEffectEntry> SettingsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFoliageClusteredEffectEntry> result;
				if ((result = this._SettingsData) == null)
				{
					result = (this._SettingsData = new TArray<SFoliageClusteredEffectEntry>(base.NativePtr + (IntPtr)PDA_FoliageClusteredEffectConfig_C.__PropertyOffset_SettingsData, this));
				}
				return result;
			}
			set
			{
				this.SettingsData.CopyAssign(value);
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0601EC7E RID: 126078 RVA: 0x0091D2C3 File Offset: 0x0091B4C3
		// (set) Token: 0x0601EC7F RID: 126079 RVA: 0x0091D2D7 File Offset: 0x0091B4D7
		public unsafe FVector BoxExtend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_FoliageClusteredEffectConfig_C.__PropertyOffset_BoxExtend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_FoliageClusteredEffectConfig_C.__PropertyOffset_BoxExtend) = value;
			}
		}

		// Token: 0x0601EC80 RID: 126080 RVA: 0x0091D2EC File Offset: 0x0091B4EC
		protected PDA_FoliageClusteredEffectConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401059F RID: 66975
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/PDA_FoliageClusteredEffectConfig.PDA_FoliageClusteredEffectConfig_C";

		// Token: 0x040105A0 RID: 66976
		private static IntPtr _ClassPtr;

		// Token: 0x040105A1 RID: 66977
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040105A2 RID: 66978
		internal static int __PropertyOffset_SettingsData;

		// Token: 0x040105A3 RID: 66979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFoliageClusteredEffectEntry> _SettingsData;

		// Token: 0x040105A4 RID: 66980
		internal static int __PropertyOffset_BoxExtend;
	}
}
