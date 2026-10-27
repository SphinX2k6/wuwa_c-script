using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CE1 RID: 15585
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/PD_BakedBalloon.PD_BakedBalloon_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_BakedBalloon_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060250E9 RID: 151785 RVA: 0x0094FD2A File Offset: 0x0094DF2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_BakedBalloon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/PD_BakedBalloon.PD_BakedBalloon_C");
			}
			return PD_BakedBalloon_C._ClassPtr;
		}

		// Token: 0x060250EA RID: 151786 RVA: 0x0094FD50 File Offset: 0x0094DF50
		public PD_BakedBalloon_C() : this(BuiltinUtils.AllocNativeUObject(PD_BakedBalloon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060250EB RID: 151787 RVA: 0x0094FD78 File Offset: 0x0094DF78
		public PD_BakedBalloon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_BakedBalloon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x060250EC RID: 151788 RVA: 0x0094FDAC File Offset: 0x0094DFAC
		// (set) Token: 0x060250ED RID: 151789 RVA: 0x0094FDE5 File Offset: 0x0094DFE5
		public TMap<int, S_BakedBalloonSet> IntToBakedBalloons
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, S_BakedBalloonSet> result;
				if ((result = this._IntToBakedBalloons) == null)
				{
					result = (this._IntToBakedBalloons = new TMap<int, S_BakedBalloonSet>(base.NativePtr + (IntPtr)PD_BakedBalloon_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.IntToBakedBalloons.CopyAssign(value);
			}
		}

		// Token: 0x060250EE RID: 151790 RVA: 0x0094FDF3 File Offset: 0x0094DFF3
		protected PD_BakedBalloon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126F0 RID: 75504
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/PD_BakedBalloon.PD_BakedBalloon_C";

		// Token: 0x040126F1 RID: 75505
		private static IntPtr _ClassPtr;

		// Token: 0x040126F2 RID: 75506
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126F3 RID: 75507
		internal static int __PropertyOffset_0;

		// Token: 0x040126F4 RID: 75508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, S_BakedBalloonSet> _IntToBakedBalloons;
	}
}
