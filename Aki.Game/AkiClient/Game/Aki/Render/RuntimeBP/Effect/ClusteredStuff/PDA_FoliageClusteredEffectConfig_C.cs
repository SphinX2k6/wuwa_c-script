using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.Effect.ClusteredStuff
{
	// Token: 0x02003DE0 RID: 15840
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/PDA_FoliageClusteredEffectConfig.PDA_FoliageClusteredEffectConfig_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 108)]
	public class PDA_FoliageClusteredEffectConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060277F4 RID: 161780 RVA: 0x00993158 File Offset: 0x00991358
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PDA_FoliageClusteredEffectConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/PDA_FoliageClusteredEffectConfig.PDA_FoliageClusteredEffectConfig_C");
			}
			return PDA_FoliageClusteredEffectConfig_C._ClassPtr;
		}

		// Token: 0x060277F5 RID: 161781 RVA: 0x0099317C File Offset: 0x0099137C
		public PDA_FoliageClusteredEffectConfig_C() : this(BuiltinUtils.AllocNativeUObject(PDA_FoliageClusteredEffectConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060277F6 RID: 161782 RVA: 0x009931A4 File Offset: 0x009913A4
		public PDA_FoliageClusteredEffectConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PDA_FoliageClusteredEffectConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x060277F7 RID: 161783 RVA: 0x009931D8 File Offset: 0x009913D8
		// (set) Token: 0x060277F8 RID: 161784 RVA: 0x00993211 File Offset: 0x00991411
		public TArray<SFoliageClusteredEffectEntry> SettingsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SFoliageClusteredEffectEntry> result;
				if ((result = this._SettingsData) == null)
				{
					result = (this._SettingsData = new TArray<SFoliageClusteredEffectEntry>(base.NativePtr + (IntPtr)PDA_FoliageClusteredEffectConfig_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SettingsData.CopyAssign(value);
			}
		}

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x060277F9 RID: 161785 RVA: 0x0099321F File Offset: 0x0099141F
		// (set) Token: 0x060277FA RID: 161786 RVA: 0x00993233 File Offset: 0x00991433
		public unsafe FVector BoxExtend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)PDA_FoliageClusteredEffectConfig_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)PDA_FoliageClusteredEffectConfig_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x060277FB RID: 161787 RVA: 0x00993248 File Offset: 0x00991448
		protected PDA_FoliageClusteredEffectConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013F6F RID: 81775
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/Effect/ClusteredStuff/PDA_FoliageClusteredEffectConfig.PDA_FoliageClusteredEffectConfig_C";

		// Token: 0x04013F70 RID: 81776
		private static IntPtr _ClassPtr;

		// Token: 0x04013F71 RID: 81777
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F72 RID: 81778
		internal static int __PropertyOffset_0;

		// Token: 0x04013F73 RID: 81779
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SFoliageClusteredEffectEntry> _SettingsData;

		// Token: 0x04013F74 RID: 81780
		internal static int __PropertyOffset_1;
	}
}
