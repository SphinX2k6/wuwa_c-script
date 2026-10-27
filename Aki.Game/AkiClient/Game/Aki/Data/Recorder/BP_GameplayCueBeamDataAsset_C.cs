using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Common.Struct;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Recorder
{
	// Token: 0x02003EA6 RID: 16038
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Recorder/BP_GameplayCueBeamDataAsset.BP_GameplayCueBeamDataAsset_C")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class BP_GameplayCueBeamDataAsset_C : UKuroBpDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028906 RID: 166150 RVA: 0x009AF440 File Offset: 0x009AD640
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GameplayCueBeamDataAsset_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Recorder/BP_GameplayCueBeamDataAsset.BP_GameplayCueBeamDataAsset_C");
			}
			return BP_GameplayCueBeamDataAsset_C._ClassPtr;
		}

		// Token: 0x06028907 RID: 166151 RVA: 0x009AF464 File Offset: 0x009AD664
		public BP_GameplayCueBeamDataAsset_C() : this(BuiltinUtils.AllocNativeUObject(BP_GameplayCueBeamDataAsset_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028908 RID: 166152 RVA: 0x009AF48C File Offset: 0x009AD68C
		public BP_GameplayCueBeamDataAsset_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GameplayCueBeamDataAsset_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E80 RID: 24192
		// (get) Token: 0x06028909 RID: 166153 RVA: 0x009AF4C0 File Offset: 0x009AD6C0
		// (set) Token: 0x0602890A RID: 166154 RVA: 0x009AF4F9 File Offset: 0x009AD6F9
		public TArray<float> TimeLine
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._TimeLine) == null)
				{
					result = (this._TimeLine = new TArray<float>(base.NativePtr + (IntPtr)BP_GameplayCueBeamDataAsset_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.TimeLine.CopyAssign(value);
			}
		}

		// Token: 0x17005E81 RID: 24193
		// (get) Token: 0x0602890B RID: 166155 RVA: 0x009AF508 File Offset: 0x009AD708
		// (set) Token: 0x0602890C RID: 166156 RVA: 0x009AF541 File Offset: 0x009AD741
		public TArray<SVectorArray> PointPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SVectorArray> result;
				if ((result = this._PointPositions) == null)
				{
					result = (this._PointPositions = new TArray<SVectorArray>(base.NativePtr + (IntPtr)BP_GameplayCueBeamDataAsset_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.PointPositions.CopyAssign(value);
			}
		}

		// Token: 0x0602890D RID: 166157 RVA: 0x009AF54F File Offset: 0x009AD74F
		protected BP_GameplayCueBeamDataAsset_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014B11 RID: 84753
		public new const string __ObjectPath = "/Game/Aki/Data/Recorder/BP_GameplayCueBeamDataAsset.BP_GameplayCueBeamDataAsset_C";

		// Token: 0x04014B12 RID: 84754
		private static IntPtr _ClassPtr;

		// Token: 0x04014B13 RID: 84755
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014B14 RID: 84756
		internal static int __PropertyOffset_0;

		// Token: 0x04014B15 RID: 84757
		[Nullable(2)]
		private TArray<float> _TimeLine;

		// Token: 0x04014B16 RID: 84758
		internal static int __PropertyOffset_1;

		// Token: 0x04014B17 RID: 84759
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SVectorArray> _PointPositions;
	}
}
