using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.Giant
{
	// Token: 0x020031F2 RID: 12786
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/Giant/BP_GiantSystem.BP_GiantSystem_C")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class BP_GiantSystem_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FCBE RID: 130238 RVA: 0x00935F18 File Offset: 0x00934118
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_GiantSystem_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/Giant/BP_GiantSystem.BP_GiantSystem_C");
			}
			return BP_GiantSystem_C._ClassPtr;
		}

		// Token: 0x0601FCBF RID: 130239 RVA: 0x00935F3C File Offset: 0x0093413C
		public BP_GiantSystem_C() : this(BuiltinUtils.AllocNativeUObject(BP_GiantSystem_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FCC0 RID: 130240 RVA: 0x00935F64 File Offset: 0x00934164
		public BP_GiantSystem_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_GiantSystem_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003B80 RID: 15232
		// (get) Token: 0x0601FCC1 RID: 130241 RVA: 0x00935F97 File Offset: 0x00934197
		// (set) Token: 0x0601FCC2 RID: 130242 RVA: 0x00935FAC File Offset: 0x009341AC
		public TSoftClassPtr<AActor> GiantActorClass
		{
			get
			{
				return new TSoftClassPtr<AActor>(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_GiantActorClass, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_GiantActorClass, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003B81 RID: 15233
		// (get) Token: 0x0601FCC3 RID: 130243 RVA: 0x00935FD1 File Offset: 0x009341D1
		// (set) Token: 0x0601FCC4 RID: 130244 RVA: 0x00935FE5 File Offset: 0x009341E5
		public unsafe FTransformDouble GiantActorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_GiantActorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_GiantActorTransform) = value;
			}
		}

		// Token: 0x17003B82 RID: 15234
		// (get) Token: 0x0601FCC5 RID: 130245 RVA: 0x00935FFC File Offset: 0x009341FC
		// (set) Token: 0x0601FCC6 RID: 130246 RVA: 0x00936035 File Offset: 0x00934235
		public TMap<int, FName> SpecialBaseIdles
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._SpecialBaseIdles) == null)
				{
					result = (this._SpecialBaseIdles = new TMap<int, FName>(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_SpecialBaseIdles, this));
				}
				return result;
			}
			set
			{
				this.SpecialBaseIdles.CopyAssign(value);
			}
		}

		// Token: 0x17003B83 RID: 15235
		// (get) Token: 0x0601FCC7 RID: 130247 RVA: 0x00936043 File Offset: 0x00934243
		// (set) Token: 0x0601FCC8 RID: 130248 RVA: 0x00936053 File Offset: 0x00934253
		public unsafe float RestLoopAnimSwitchTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_RestLoopAnimSwitchTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_RestLoopAnimSwitchTime) = value;
			}
		}

		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0601FCC9 RID: 130249 RVA: 0x00936064 File Offset: 0x00934264
		// (set) Token: 0x0601FCCA RID: 130250 RVA: 0x00936074 File Offset: 0x00934274
		public unsafe float MainViewPicSwitchInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_MainViewPicSwitchInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_MainViewPicSwitchInterval) = value;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0601FCCB RID: 130251 RVA: 0x00936085 File Offset: 0x00934285
		// (set) Token: 0x0601FCCC RID: 130252 RVA: 0x00936095 File Offset: 0x00934295
		public unsafe int InteractMarkId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_InteractMarkId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_InteractMarkId) = value;
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0601FCCD RID: 130253 RVA: 0x009360A6 File Offset: 0x009342A6
		// (set) Token: 0x0601FCCE RID: 130254 RVA: 0x009360B6 File Offset: 0x009342B6
		public unsafe int HelpId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_HelpId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_HelpId) = value;
			}
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0601FCCF RID: 130255 RVA: 0x009360C7 File Offset: 0x009342C7
		// (set) Token: 0x0601FCD0 RID: 130256 RVA: 0x009360DB File Offset: 0x009342DB
		public unsafe FName TipsKeyPreMainlineWholeLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyPreMainlineWholeLock);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyPreMainlineWholeLock) = value;
			}
		}

		// Token: 0x17003B88 RID: 15240
		// (get) Token: 0x0601FCD1 RID: 130257 RVA: 0x009360F0 File Offset: 0x009342F0
		// (set) Token: 0x0601FCD2 RID: 130258 RVA: 0x00936104 File Offset: 0x00934304
		public unsafe FName TipsKeyHighQualityLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyHighQualityLock);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyHighQualityLock) = value;
			}
		}

		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0601FCD3 RID: 130259 RVA: 0x00936119 File Offset: 0x00934319
		// (set) Token: 0x0601FCD4 RID: 130260 RVA: 0x0093612D File Offset: 0x0093432D
		public unsafe FName TipsKeyNoDeliverableItem
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyNoDeliverableItem);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyNoDeliverableItem) = value;
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0601FCD5 RID: 130261 RVA: 0x00936142 File Offset: 0x00934342
		// (set) Token: 0x0601FCD6 RID: 130262 RVA: 0x00936156 File Offset: 0x00934356
		public unsafe FName TipsKeyEcoMaxLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyEcoMaxLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyEcoMaxLevel) = value;
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0601FCD7 RID: 130263 RVA: 0x0093616B File Offset: 0x0093436B
		// (set) Token: 0x0601FCD8 RID: 130264 RVA: 0x0093617F File Offset: 0x0093437F
		public unsafe FName TipsKeyNodeLockedInteract
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyNodeLockedInteract);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyNodeLockedInteract) = value;
			}
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0601FCD9 RID: 130265 RVA: 0x00936194 File Offset: 0x00934394
		// (set) Token: 0x0601FCDA RID: 130266 RVA: 0x009361A8 File Offset: 0x009343A8
		public unsafe FName TipsKeyNodePendingActivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyNodePendingActivate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyNodePendingActivate) = value;
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0601FCDB RID: 130267 RVA: 0x009361BD File Offset: 0x009343BD
		// (set) Token: 0x0601FCDC RID: 130268 RVA: 0x009361D1 File Offset: 0x009343D1
		public unsafe FName TextKeyRewardTitleUpgrade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyRewardTitleUpgrade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyRewardTitleUpgrade) = value;
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0601FCDD RID: 130269 RVA: 0x009361E6 File Offset: 0x009343E6
		// (set) Token: 0x0601FCDE RID: 130270 RVA: 0x009361FA File Offset: 0x009343FA
		public unsafe FName TextKeyRewardTitleOffering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyRewardTitleOffering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyRewardTitleOffering) = value;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0601FCDF RID: 130271 RVA: 0x0093620F File Offset: 0x0093440F
		// (set) Token: 0x0601FCE0 RID: 130272 RVA: 0x00936223 File Offset: 0x00934423
		public unsafe FName TextKeyTraitTitleUpgrade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyTraitTitleUpgrade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyTraitTitleUpgrade) = value;
			}
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x0601FCE1 RID: 130273 RVA: 0x00936238 File Offset: 0x00934438
		// (set) Token: 0x0601FCE2 RID: 130274 RVA: 0x0093624C File Offset: 0x0093444C
		public unsafe FName TextKeyTraitTitleMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyTraitTitleMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyTraitTitleMax) = value;
			}
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0601FCE3 RID: 130275 RVA: 0x00936261 File Offset: 0x00934461
		// (set) Token: 0x0601FCE4 RID: 130276 RVA: 0x00936275 File Offset: 0x00934475
		public unsafe FName TextKeyGoBtnNormal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGoBtnNormal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGoBtnNormal) = value;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0601FCE5 RID: 130277 RVA: 0x0093628A File Offset: 0x0093448A
		// (set) Token: 0x0601FCE6 RID: 130278 RVA: 0x0093629E File Offset: 0x0093449E
		public unsafe FName TextKeyGoBtnActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGoBtnActive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGoBtnActive) = value;
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0601FCE7 RID: 130279 RVA: 0x009362B3 File Offset: 0x009344B3
		// (set) Token: 0x0601FCE8 RID: 130280 RVA: 0x009362C7 File Offset: 0x009344C7
		public unsafe FName TextKeyGiantTotalNodeAttitude0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGiantTotalNodeAttitude0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGiantTotalNodeAttitude0) = value;
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0601FCE9 RID: 130281 RVA: 0x009362DC File Offset: 0x009344DC
		// (set) Token: 0x0601FCEA RID: 130282 RVA: 0x009362F0 File Offset: 0x009344F0
		public unsafe FName TextKeyGiantTotalNodeAssist0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGiantTotalNodeAssist0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyGiantTotalNodeAssist0) = value;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x0601FCEB RID: 130283 RVA: 0x00936305 File Offset: 0x00934505
		// (set) Token: 0x0601FCEC RID: 130284 RVA: 0x00936319 File Offset: 0x00934519
		public unsafe FName TextKeyCollectAutoSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyCollectAutoSelect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyCollectAutoSelect) = value;
			}
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x0601FCED RID: 130285 RVA: 0x0093632E File Offset: 0x0093452E
		// (set) Token: 0x0601FCEE RID: 130286 RVA: 0x00936342 File Offset: 0x00934542
		public unsafe FName TextKeyCollectClearSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyCollectClearSelect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TextKeyCollectClearSelect) = value;
			}
		}

		// Token: 0x17003B97 RID: 15255
		// (get) Token: 0x0601FCEF RID: 130287 RVA: 0x00936358 File Offset: 0x00934558
		// (set) Token: 0x0601FCF0 RID: 130288 RVA: 0x00936391 File Offset: 0x00934591
		public TMap<int, FName> TipsKeyGiantNodeAttitudeByStage
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._TipsKeyGiantNodeAttitudeByStage) == null)
				{
					result = (this._TipsKeyGiantNodeAttitudeByStage = new TMap<int, FName>(base.NativePtr + (IntPtr)BP_GiantSystem_C.__PropertyOffset_TipsKeyGiantNodeAttitudeByStage, this));
				}
				return result;
			}
			set
			{
				this.TipsKeyGiantNodeAttitudeByStage.CopyAssign(value);
			}
		}

		// Token: 0x0601FCF1 RID: 130289 RVA: 0x0093639F File Offset: 0x0093459F
		protected BP_GiantSystem_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011108 RID: 69896
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/Giant/BP_GiantSystem.BP_GiantSystem_C";

		// Token: 0x04011109 RID: 69897
		private static IntPtr _ClassPtr;

		// Token: 0x0401110A RID: 69898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401110B RID: 69899
		internal static int __PropertyOffset_GiantActorClass;

		// Token: 0x0401110C RID: 69900
		internal static int __PropertyOffset_GiantActorTransform;

		// Token: 0x0401110D RID: 69901
		internal static int __PropertyOffset_SpecialBaseIdles;

		// Token: 0x0401110E RID: 69902
		[Nullable(2)]
		private TMap<int, FName> _SpecialBaseIdles;

		// Token: 0x0401110F RID: 69903
		internal static int __PropertyOffset_RestLoopAnimSwitchTime;

		// Token: 0x04011110 RID: 69904
		internal static int __PropertyOffset_MainViewPicSwitchInterval;

		// Token: 0x04011111 RID: 69905
		internal static int __PropertyOffset_InteractMarkId;

		// Token: 0x04011112 RID: 69906
		internal static int __PropertyOffset_HelpId;

		// Token: 0x04011113 RID: 69907
		internal static int __PropertyOffset_TipsKeyPreMainlineWholeLock;

		// Token: 0x04011114 RID: 69908
		internal static int __PropertyOffset_TipsKeyHighQualityLock;

		// Token: 0x04011115 RID: 69909
		internal static int __PropertyOffset_TipsKeyNoDeliverableItem;

		// Token: 0x04011116 RID: 69910
		internal static int __PropertyOffset_TipsKeyEcoMaxLevel;

		// Token: 0x04011117 RID: 69911
		internal static int __PropertyOffset_TipsKeyNodeLockedInteract;

		// Token: 0x04011118 RID: 69912
		internal static int __PropertyOffset_TipsKeyNodePendingActivate;

		// Token: 0x04011119 RID: 69913
		internal static int __PropertyOffset_TextKeyRewardTitleUpgrade;

		// Token: 0x0401111A RID: 69914
		internal static int __PropertyOffset_TextKeyRewardTitleOffering;

		// Token: 0x0401111B RID: 69915
		internal static int __PropertyOffset_TextKeyTraitTitleUpgrade;

		// Token: 0x0401111C RID: 69916
		internal static int __PropertyOffset_TextKeyTraitTitleMax;

		// Token: 0x0401111D RID: 69917
		internal static int __PropertyOffset_TextKeyGoBtnNormal;

		// Token: 0x0401111E RID: 69918
		internal static int __PropertyOffset_TextKeyGoBtnActive;

		// Token: 0x0401111F RID: 69919
		internal static int __PropertyOffset_TextKeyGiantTotalNodeAttitude0;

		// Token: 0x04011120 RID: 69920
		internal static int __PropertyOffset_TextKeyGiantTotalNodeAssist0;

		// Token: 0x04011121 RID: 69921
		internal static int __PropertyOffset_TextKeyCollectAutoSelect;

		// Token: 0x04011122 RID: 69922
		internal static int __PropertyOffset_TextKeyCollectClearSelect;

		// Token: 0x04011123 RID: 69923
		internal static int __PropertyOffset_TipsKeyGiantNodeAttitudeByStage;

		// Token: 0x04011124 RID: 69924
		[Nullable(2)]
		private TMap<int, FName> _TipsKeyGiantNodeAttitudeByStage;
	}
}
