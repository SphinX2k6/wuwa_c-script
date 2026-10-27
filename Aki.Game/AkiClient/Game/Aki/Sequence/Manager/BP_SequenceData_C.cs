using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003A29 RID: 14889
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/BP_SequenceData.BP_SequenceData_C")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 369)]
	public class BP_SequenceData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F54E RID: 128334 RVA: 0x008B5B15 File Offset: 0x008B3D15
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Manager/BP_SequenceData.BP_SequenceData_C");
			}
			return BP_SequenceData_C._ClassPtr;
		}

		// Token: 0x0601F54F RID: 128335 RVA: 0x008B5B3C File Offset: 0x008B3D3C
		public BP_SequenceData_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F550 RID: 128336 RVA: 0x008B5B64 File Offset: 0x008B3D64
		public BP_SequenceData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x0601F551 RID: 128337 RVA: 0x008B5B97 File Offset: 0x008B3D97
		// (set) Token: 0x0601F552 RID: 128338 RVA: 0x008B5BAB File Offset: 0x008B3DAB
		[Nullable(0)]
		public unsafe TEnumAsByte<EPlotSequenceType> 类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0601F553 RID: 128339 RVA: 0x008B5BC0 File Offset: 0x008B3DC0
		// (set) Token: 0x0601F554 RID: 128340 RVA: 0x008B5BF9 File Offset: 0x008B3DF9
		public TArray<ULevelSequence> 剧情资源
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelSequence> result;
				if ((result = this._剧情资源) == null)
				{
					result = (this._剧情资源 = new TArray<ULevelSequence>(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.剧情资源.CopyAssign(value);
			}
		}

		// Token: 0x17002ACE RID: 10958
		// (get) Token: 0x0601F555 RID: 128341 RVA: 0x008B5C07 File Offset: 0x008B3E07
		// (set) Token: 0x0601F556 RID: 128342 RVA: 0x008B5C1B File Offset: 0x008B3E1B
		public unsafe string 文本资源ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17002ACF RID: 10959
		// (get) Token: 0x0601F557 RID: 128343 RVA: 0x008B5C30 File Offset: 0x008B3E30
		// (set) Token: 0x0601F558 RID: 128344 RVA: 0x008B5C69 File Offset: 0x008B3E69
		public TArray<FName> 绑定角色标签
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._绑定角色标签) == null)
				{
					result = (this._绑定角色标签 = new TArray<FName>(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_3, this));
				}
				return result;
			}
			set
			{
				this.绑定角色标签.CopyAssign(value);
			}
		}

		// Token: 0x17002AD0 RID: 10960
		// (get) Token: 0x0601F559 RID: 128345 RVA: 0x008B5C77 File Offset: 0x008B3E77
		// (set) Token: 0x0601F55A RID: 128346 RVA: 0x008B5C8B File Offset: 0x008B3E8B
		public unsafe string 绑定起始点标签
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_4)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_4)), value);
			}
		}

		// Token: 0x17002AD1 RID: 10961
		// (get) Token: 0x0601F55B RID: 128347 RVA: 0x008B5CA0 File Offset: 0x008B3EA0
		// (set) Token: 0x0601F55C RID: 128348 RVA: 0x008B5CB0 File Offset: 0x008B3EB0
		public unsafe bool 是否固定起始点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AD2 RID: 10962
		// (get) Token: 0x0601F55D RID: 128349 RVA: 0x008B5CC1 File Offset: 0x008B3EC1
		// (set) Token: 0x0601F55E RID: 128350 RVA: 0x008B5CD1 File Offset: 0x008B3ED1
		public unsafe bool NeedSwitchMainCharacter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AD3 RID: 10963
		// (get) Token: 0x0601F55F RID: 128351 RVA: 0x008B5CE2 File Offset: 0x008B3EE2
		// (set) Token: 0x0601F560 RID: 128352 RVA: 0x008B5CF2 File Offset: 0x008B3EF2
		public unsafe bool IsTransformOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x0601F561 RID: 128353 RVA: 0x008B5D03 File Offset: 0x008B3F03
		// (set) Token: 0x0601F562 RID: 128354 RVA: 0x008B5D17 File Offset: 0x008B3F17
		public unsafe FTransform OverrideTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x0601F563 RID: 128355 RVA: 0x008B5D2C File Offset: 0x008B3F2C
		// (set) Token: 0x0601F564 RID: 128356 RVA: 0x008B5D3C File Offset: 0x008B3F3C
		public unsafe float AnimationBlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x0601F565 RID: 128357 RVA: 0x008B5D4D File Offset: 0x008B3F4D
		// (set) Token: 0x0601F566 RID: 128358 RVA: 0x008B5D5D File Offset: 0x008B3F5D
		public unsafe float AnimationBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0601F567 RID: 128359 RVA: 0x008B5D6E File Offset: 0x008B3F6E
		// (set) Token: 0x0601F568 RID: 128360 RVA: 0x008B5D7E File Offset: 0x008B3F7E
		public unsafe float CameraBlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0601F569 RID: 128361 RVA: 0x008B5D8F File Offset: 0x008B3F8F
		// (set) Token: 0x0601F56A RID: 128362 RVA: 0x008B5D9F File Offset: 0x008B3F9F
		public unsafe float CameraBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0601F56B RID: 128363 RVA: 0x008B5DB0 File Offset: 0x008B3FB0
		// (set) Token: 0x0601F56C RID: 128364 RVA: 0x008B5DC0 File Offset: 0x008B3FC0
		public unsafe bool MovementSync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0601F56D RID: 128365 RVA: 0x008B5DD1 File Offset: 0x008B3FD1
		// (set) Token: 0x0601F56E RID: 128366 RVA: 0x008B5DE1 File Offset: 0x008B3FE1
		public unsafe bool SaveFinalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x0601F56F RID: 128367 RVA: 0x008B5DF2 File Offset: 0x008B3FF2
		// (set) Token: 0x0601F570 RID: 128368 RVA: 0x008B5E02 File Offset: 0x008B4002
		public unsafe bool 标识为演出制作中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x0601F571 RID: 128369 RVA: 0x008B5E13 File Offset: 0x008B4013
		// (set) Token: 0x0601F572 RID: 128370 RVA: 0x008B5E23 File Offset: 0x008B4023
		public unsafe bool HidePlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0601F573 RID: 128371 RVA: 0x008B5E34 File Offset: 0x008B4034
		// (set) Token: 0x0601F574 RID: 128372 RVA: 0x008B5E48 File Offset: 0x008B4048
		[Nullable(2)]
		public unsafe BP_SequenceData_Generated_C GeneratedData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SequenceData_Generated_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceData_C.__PropertyOffset_17);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceData_C.__PropertyOffset_17, value);
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0601F575 RID: 128373 RVA: 0x008B5E5D File Offset: 0x008B405D
		// (set) Token: 0x0601F576 RID: 128374 RVA: 0x008B5E6D File Offset: 0x008B406D
		public unsafe int 葫芦状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0601F577 RID: 128375 RVA: 0x008B5E7E File Offset: 0x008B407E
		// (set) Token: 0x0601F578 RID: 128376 RVA: 0x008B5E92 File Offset: 0x008B4092
		public unsafe string GraphName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_19)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_19)), value);
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0601F579 RID: 128377 RVA: 0x008B5EA7 File Offset: 0x008B40A7
		// (set) Token: 0x0601F57A RID: 128378 RVA: 0x008B5EB7 File Offset: 0x008B40B7
		public unsafe bool bIsForceFinalTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_20) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_20) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0601F57B RID: 128379 RVA: 0x008B5EC8 File Offset: 0x008B40C8
		// (set) Token: 0x0601F57C RID: 128380 RVA: 0x008B5ED8 File Offset: 0x008B40D8
		public unsafe bool CollectExtraTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_21) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_21) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0601F57D RID: 128381 RVA: 0x008B5EE9 File Offset: 0x008B40E9
		// (set) Token: 0x0601F57E RID: 128382 RVA: 0x008B5EF9 File Offset: 0x008B40F9
		public unsafe float 相机过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x0601F57F RID: 128383 RVA: 0x008B5F0A File Offset: 0x008B410A
		// (set) Token: 0x0601F580 RID: 128384 RVA: 0x008B5F1A File Offset: 0x008B411A
		public unsafe bool 约束宽高比
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_23) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_23) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x0601F581 RID: 128385 RVA: 0x008B5F2B File Offset: 0x008B412B
		// (set) Token: 0x0601F582 RID: 128386 RVA: 0x008B5F3B File Offset: 0x008B413B
		public unsafe bool IsEnableDynamicStreamingSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x0601F583 RID: 128387 RVA: 0x008B5F4C File Offset: 0x008B414C
		// (set) Token: 0x0601F584 RID: 128388 RVA: 0x008B5F5C File Offset: 0x008B415C
		public unsafe bool 使用UI黑边
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x0601F585 RID: 128389 RVA: 0x008B5F6D File Offset: 0x008B416D
		// (set) Token: 0x0601F586 RID: 128390 RVA: 0x008B5F7D File Offset: 0x008B417D
		public unsafe bool EnableStartTransformBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_26) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_26) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x0601F587 RID: 128391 RVA: 0x008B5F8E File Offset: 0x008B418E
		// (set) Token: 0x0601F588 RID: 128392 RVA: 0x008B5F9E File Offset: 0x008B419E
		public unsafe float StartTransformBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_27);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_27) = value;
			}
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x0601F589 RID: 128393 RVA: 0x008B5FAF File Offset: 0x008B41AF
		// (set) Token: 0x0601F58A RID: 128394 RVA: 0x008B5FBF File Offset: 0x008B41BF
		public unsafe bool 混入到相机首帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x0601F58B RID: 128395 RVA: 0x008B5FD0 File Offset: 0x008B41D0
		// (set) Token: 0x0601F58C RID: 128396 RVA: 0x008B5FE0 File Offset: 0x008B41E0
		public unsafe bool IsForceStreamSceneActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x0601F58D RID: 128397 RVA: 0x008B5FF4 File Offset: 0x008B41F4
		// (set) Token: 0x0601F58E RID: 128398 RVA: 0x008B602D File Offset: 0x008B422D
		public TMap<int, FName> 实体说话人ID
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._实体说话人ID) == null)
				{
					result = (this._实体说话人ID = new TMap<int, FName>(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_30, this));
				}
				return result;
			}
			set
			{
				this.实体说话人ID.CopyAssign(value);
			}
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x0601F58F RID: 128399 RVA: 0x008B603B File Offset: 0x008B423B
		// (set) Token: 0x0601F590 RID: 128400 RVA: 0x008B604B File Offset: 0x008B424B
		public unsafe bool AutoCalcStartTransformBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F591 RID: 128401 RVA: 0x008B605C File Offset: 0x008B425C
		protected BP_SequenceData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F096 RID: 61590
		public new const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_SequenceData.BP_SequenceData_C";

		// Token: 0x0400F097 RID: 61591
		private static IntPtr _ClassPtr;

		// Token: 0x0400F098 RID: 61592
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F099 RID: 61593
		internal static int __PropertyOffset_0;

		// Token: 0x0400F09A RID: 61594
		internal static int __PropertyOffset_1;

		// Token: 0x0400F09B RID: 61595
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelSequence> _剧情资源;

		// Token: 0x0400F09C RID: 61596
		internal static int __PropertyOffset_2;

		// Token: 0x0400F09D RID: 61597
		internal static int __PropertyOffset_3;

		// Token: 0x0400F09E RID: 61598
		[Nullable(2)]
		private TArray<FName> _绑定角色标签;

		// Token: 0x0400F09F RID: 61599
		internal static int __PropertyOffset_4;

		// Token: 0x0400F0A0 RID: 61600
		internal static int __PropertyOffset_5;

		// Token: 0x0400F0A1 RID: 61601
		internal static int __PropertyOffset_6;

		// Token: 0x0400F0A2 RID: 61602
		internal static int __PropertyOffset_7;

		// Token: 0x0400F0A3 RID: 61603
		internal static int __PropertyOffset_8;

		// Token: 0x0400F0A4 RID: 61604
		internal static int __PropertyOffset_9;

		// Token: 0x0400F0A5 RID: 61605
		internal static int __PropertyOffset_10;

		// Token: 0x0400F0A6 RID: 61606
		internal static int __PropertyOffset_11;

		// Token: 0x0400F0A7 RID: 61607
		internal static int __PropertyOffset_12;

		// Token: 0x0400F0A8 RID: 61608
		internal static int __PropertyOffset_13;

		// Token: 0x0400F0A9 RID: 61609
		internal static int __PropertyOffset_14;

		// Token: 0x0400F0AA RID: 61610
		internal static int __PropertyOffset_15;

		// Token: 0x0400F0AB RID: 61611
		internal static int __PropertyOffset_16;

		// Token: 0x0400F0AC RID: 61612
		internal static int __PropertyOffset_17;

		// Token: 0x0400F0AD RID: 61613
		internal static int __PropertyOffset_18;

		// Token: 0x0400F0AE RID: 61614
		internal static int __PropertyOffset_19;

		// Token: 0x0400F0AF RID: 61615
		internal static int __PropertyOffset_20;

		// Token: 0x0400F0B0 RID: 61616
		internal static int __PropertyOffset_21;

		// Token: 0x0400F0B1 RID: 61617
		internal static int __PropertyOffset_22;

		// Token: 0x0400F0B2 RID: 61618
		internal static int __PropertyOffset_23;

		// Token: 0x0400F0B3 RID: 61619
		internal static int __PropertyOffset_24;

		// Token: 0x0400F0B4 RID: 61620
		internal static int __PropertyOffset_25;

		// Token: 0x0400F0B5 RID: 61621
		internal static int __PropertyOffset_26;

		// Token: 0x0400F0B6 RID: 61622
		internal static int __PropertyOffset_27;

		// Token: 0x0400F0B7 RID: 61623
		internal static int __PropertyOffset_28;

		// Token: 0x0400F0B8 RID: 61624
		internal static int __PropertyOffset_29;

		// Token: 0x0400F0B9 RID: 61625
		internal static int __PropertyOffset_30;

		// Token: 0x0400F0BA RID: 61626
		[Nullable(2)]
		private TMap<int, FName> _实体说话人ID;

		// Token: 0x0400F0BB RID: 61627
		internal static int __PropertyOffset_31;
	}
}
