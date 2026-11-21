using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Recorder
{
	// Token: 0x02003174 RID: 12660
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Recorder/BP_GameplayCueBeamDataAsset.BP_GameplayCueBeamDataAsset_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class BP_GameplayCueBeamDataAsset_C : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F3AC RID: 127916 RVA: 0x00929174 File Offset: 0x00927374
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GameplayCueBeamDataAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Recorder/BP_GameplayCueBeamDataAsset.BP_GameplayCueBeamDataAsset_C");
			}
			return BP_GameplayCueBeamDataAsset_C._ClassPtr;
		}

		// Token: 0x0601F3AD RID: 127917 RVA: 0x00929198 File Offset: 0x00927398
		public BP_GameplayCueBeamDataAsset_C() : this(BuiltinUtils.AllocNativeUObject(BP_GameplayCueBeamDataAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F3AE RID: 127918 RVA: 0x009291C0 File Offset: 0x009273C0
		public BP_GameplayCueBeamDataAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GameplayCueBeamDataAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0601F3AF RID: 127919 RVA: 0x009291F4 File Offset: 0x009273F4
		// (set) Token: 0x0601F3B0 RID: 127920 RVA: 0x0092922D File Offset: 0x0092742D
		public TArray<float> TimeLine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._TimeLine) == null)
				{
					result = (this._TimeLine = new TArray<float>(base.NativePtr + (IntPtr)BP_GameplayCueBeamDataAsset_C.__PropertyOffset_TimeLine, this));
				}
				return result;
			}
			set
			{
				this.TimeLine.CopyAssign(value);
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0601F3B1 RID: 127921 RVA: 0x0092923C File Offset: 0x0092743C
		// (set) Token: 0x0601F3B2 RID: 127922 RVA: 0x00929275 File Offset: 0x00927475
		public TArray<SVectorArray> PointPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SVectorArray> result;
				if ((result = this._PointPositions) == null)
				{
					result = (this._PointPositions = new TArray<SVectorArray>(base.NativePtr + (IntPtr)BP_GameplayCueBeamDataAsset_C.__PropertyOffset_PointPositions, this));
				}
				return result;
			}
			set
			{
				this.PointPositions.CopyAssign(value);
			}
		}

		// Token: 0x0601F3B3 RID: 127923 RVA: 0x00929283 File Offset: 0x00927483
		protected BP_GameplayCueBeamDataAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010B3D RID: 68413
		public new const string __ObjectPath = "/Game/Aki/Data/Recorder/BP_GameplayCueBeamDataAsset.BP_GameplayCueBeamDataAsset_C";

		// Token: 0x04010B3E RID: 68414
		private static IntPtr _ClassPtr;

		// Token: 0x04010B3F RID: 68415
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010B40 RID: 68416
		internal static int __PropertyOffset_TimeLine;

		// Token: 0x04010B41 RID: 68417
		[Nullable(2)]
		private TArray<float> _TimeLine;

		// Token: 0x04010B42 RID: 68418
		internal static int __PropertyOffset_PointPositions;

		// Token: 0x04010B43 RID: 68419
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SVectorArray> _PointPositions;
	}
}
