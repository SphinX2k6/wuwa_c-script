using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.FluidNinjaLive.SimCache.BP
{
	// Token: 0x02003D98 RID: 15768
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/FluidNinjaLive/SimCache/BP/PD_NinjaSimCache.PD_NinjaSimCache_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_NinjaSimCache_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027164 RID: 160100 RVA: 0x0098658C File Offset: 0x0098478C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_NinjaSimCache_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/SimCache/BP/PD_NinjaSimCache.PD_NinjaSimCache_C");
			}
			return PD_NinjaSimCache_C._ClassPtr;
		}

		// Token: 0x06027165 RID: 160101 RVA: 0x009865B0 File Offset: 0x009847B0
		public PD_NinjaSimCache_C() : this(BuiltinUtils.AllocNativeUObject(PD_NinjaSimCache_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027166 RID: 160102 RVA: 0x009865D8 File Offset: 0x009847D8
		public PD_NinjaSimCache_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_NinjaSimCache_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005647 RID: 22087
		// (get) Token: 0x06027167 RID: 160103 RVA: 0x0098660C File Offset: 0x0098480C
		// (set) Token: 0x06027168 RID: 160104 RVA: 0x00986645 File Offset: 0x00984845
		public TMap<string, UTexture2D> CachedSimMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UTexture2D> result;
				if ((result = this._CachedSimMap) == null)
				{
					result = (this._CachedSimMap = new TMap<string, UTexture2D>(base.NativePtr + (IntPtr)PD_NinjaSimCache_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.CachedSimMap.CopyAssign(value);
			}
		}

		// Token: 0x06027169 RID: 160105 RVA: 0x00986653 File Offset: 0x00984853
		protected PD_NinjaSimCache_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013B03 RID: 80643
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/FluidNinjaLive/SimCache/BP/PD_NinjaSimCache.PD_NinjaSimCache_C";

		// Token: 0x04013B04 RID: 80644
		private static IntPtr _ClassPtr;

		// Token: 0x04013B05 RID: 80645
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013B06 RID: 80646
		internal static int __PropertyOffset_0;

		// Token: 0x04013B07 RID: 80647
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UTexture2D> _CachedSimMap;
	}
}
