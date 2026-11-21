using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Sequence.Manager
{
	// Token: 0x02003072 RID: 12402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Sequence/Manager/BP_SequenceData.BP_SequenceData_C")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 369)]
	public class BP_SequenceData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D8D2 RID: 121042 RVA: 0x008FB2A3 File Offset: 0x008F94A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SequenceData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Sequence/Manager/BP_SequenceData.BP_SequenceData_C");
			}
			return BP_SequenceData_C._ClassPtr;
		}

		// Token: 0x0601D8D3 RID: 121043 RVA: 0x008FB2C8 File Offset: 0x008F94C8
		public BP_SequenceData_C() : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D8D4 RID: 121044 RVA: 0x008FB2F0 File Offset: 0x008F94F0
		public BP_SequenceData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SequenceData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x0601D8D5 RID: 121045 RVA: 0x008FB323 File Offset: 0x008F9523
		// (set) Token: 0x0601D8D6 RID: 121046 RVA: 0x008FB337 File Offset: 0x008F9537
		[Nullable(0)]
		public unsafe TEnumAsByte<EPlotSequenceType> 类型
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_类型);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_类型) = value;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x0601D8D7 RID: 121047 RVA: 0x008FB34C File Offset: 0x008F954C
		// (set) Token: 0x0601D8D8 RID: 121048 RVA: 0x008FB385 File Offset: 0x008F9585
		public TArray<ULevelSequence> 剧情资源
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelSequence> result;
				if ((result = this._剧情资源) == null)
				{
					result = (this._剧情资源 = new TArray<ULevelSequence>(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_剧情资源, this));
				}
				return result;
			}
			set
			{
				this.剧情资源.CopyAssign(value);
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x0601D8D9 RID: 121049 RVA: 0x008FB393 File Offset: 0x008F9593
		// (set) Token: 0x0601D8DA RID: 121050 RVA: 0x008FB3A7 File Offset: 0x008F95A7
		public unsafe string 文本资源ID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_文本资源ID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_文本资源ID)), value);
			}
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x0601D8DB RID: 121051 RVA: 0x008FB3BC File Offset: 0x008F95BC
		// (set) Token: 0x0601D8DC RID: 121052 RVA: 0x008FB3F5 File Offset: 0x008F95F5
		public TArray<FName> 绑定角色标签
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._绑定角色标签) == null)
				{
					result = (this._绑定角色标签 = new TArray<FName>(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_绑定角色标签, this));
				}
				return result;
			}
			set
			{
				this.绑定角色标签.CopyAssign(value);
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x0601D8DD RID: 121053 RVA: 0x008FB403 File Offset: 0x008F9603
		// (set) Token: 0x0601D8DE RID: 121054 RVA: 0x008FB417 File Offset: 0x008F9617
		public unsafe string 绑定起始点标签
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_绑定起始点标签)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_绑定起始点标签)), value);
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x0601D8DF RID: 121055 RVA: 0x008FB42C File Offset: 0x008F962C
		// (set) Token: 0x0601D8E0 RID: 121056 RVA: 0x008FB43C File Offset: 0x008F963C
		public unsafe bool 是否固定起始点
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_是否固定起始点) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_是否固定起始点) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x0601D8E1 RID: 121057 RVA: 0x008FB44D File Offset: 0x008F964D
		// (set) Token: 0x0601D8E2 RID: 121058 RVA: 0x008FB45D File Offset: 0x008F965D
		public unsafe bool NeedSwitchMainCharacter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_NeedSwitchMainCharacter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_NeedSwitchMainCharacter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x0601D8E3 RID: 121059 RVA: 0x008FB46E File Offset: 0x008F966E
		// (set) Token: 0x0601D8E4 RID: 121060 RVA: 0x008FB47E File Offset: 0x008F967E
		public unsafe bool IsTransformOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_IsTransformOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_IsTransformOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x0601D8E5 RID: 121061 RVA: 0x008FB48F File Offset: 0x008F968F
		// (set) Token: 0x0601D8E6 RID: 121062 RVA: 0x008FB4A3 File Offset: 0x008F96A3
		public unsafe FTransform OverrideTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_OverrideTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_OverrideTransform) = value;
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x0601D8E7 RID: 121063 RVA: 0x008FB4B8 File Offset: 0x008F96B8
		// (set) Token: 0x0601D8E8 RID: 121064 RVA: 0x008FB4C8 File Offset: 0x008F96C8
		public unsafe float AnimationBlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_AnimationBlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_AnimationBlendInTime) = value;
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x0601D8E9 RID: 121065 RVA: 0x008FB4D9 File Offset: 0x008F96D9
		// (set) Token: 0x0601D8EA RID: 121066 RVA: 0x008FB4E9 File Offset: 0x008F96E9
		public unsafe float AnimationBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_AnimationBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_AnimationBlendOutTime) = value;
			}
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x0601D8EB RID: 121067 RVA: 0x008FB4FA File Offset: 0x008F96FA
		// (set) Token: 0x0601D8EC RID: 121068 RVA: 0x008FB50A File Offset: 0x008F970A
		public unsafe float CameraBlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_CameraBlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_CameraBlendInTime) = value;
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x0601D8ED RID: 121069 RVA: 0x008FB51B File Offset: 0x008F971B
		// (set) Token: 0x0601D8EE RID: 121070 RVA: 0x008FB52B File Offset: 0x008F972B
		public unsafe float CameraBlendOutTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_CameraBlendOutTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_CameraBlendOutTime) = value;
			}
		}

		// Token: 0x17002F61 RID: 12129
		// (get) Token: 0x0601D8EF RID: 121071 RVA: 0x008FB53C File Offset: 0x008F973C
		// (set) Token: 0x0601D8F0 RID: 121072 RVA: 0x008FB54C File Offset: 0x008F974C
		public unsafe bool MovementSync
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_MovementSync) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_MovementSync) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0601D8F1 RID: 121073 RVA: 0x008FB55D File Offset: 0x008F975D
		// (set) Token: 0x0601D8F2 RID: 121074 RVA: 0x008FB56D File Offset: 0x008F976D
		public unsafe bool SaveFinalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_SaveFinalTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_SaveFinalTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0601D8F3 RID: 121075 RVA: 0x008FB57E File Offset: 0x008F977E
		// (set) Token: 0x0601D8F4 RID: 121076 RVA: 0x008FB58E File Offset: 0x008F978E
		public unsafe bool 标识为演出制作中
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_标识为演出制作中) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_标识为演出制作中) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0601D8F5 RID: 121077 RVA: 0x008FB59F File Offset: 0x008F979F
		// (set) Token: 0x0601D8F6 RID: 121078 RVA: 0x008FB5AF File Offset: 0x008F97AF
		public unsafe bool HidePlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_HidePlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_HidePlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0601D8F7 RID: 121079 RVA: 0x008FB5C0 File Offset: 0x008F97C0
		// (set) Token: 0x0601D8F8 RID: 121080 RVA: 0x008FB5D4 File Offset: 0x008F97D4
		[Nullable(2)]
		public unsafe BP_SequenceData_Generated_C GeneratedData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_SequenceData_Generated_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceData_C.__PropertyOffset_GeneratedData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SequenceData_C.__PropertyOffset_GeneratedData, value);
			}
		}

		// Token: 0x17002F66 RID: 12134
		// (get) Token: 0x0601D8F9 RID: 121081 RVA: 0x008FB5E9 File Offset: 0x008F97E9
		// (set) Token: 0x0601D8FA RID: 121082 RVA: 0x008FB5F9 File Offset: 0x008F97F9
		public unsafe int 葫芦状态
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_葫芦状态);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_葫芦状态) = value;
			}
		}

		// Token: 0x17002F67 RID: 12135
		// (get) Token: 0x0601D8FB RID: 121083 RVA: 0x008FB60A File Offset: 0x008F980A
		// (set) Token: 0x0601D8FC RID: 121084 RVA: 0x008FB61E File Offset: 0x008F981E
		public unsafe string GraphName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_GraphName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)BP_SequenceData_C.__PropertyOffset_GraphName)), value);
			}
		}

		// Token: 0x17002F68 RID: 12136
		// (get) Token: 0x0601D8FD RID: 121085 RVA: 0x008FB633 File Offset: 0x008F9833
		// (set) Token: 0x0601D8FE RID: 121086 RVA: 0x008FB643 File Offset: 0x008F9843
		public unsafe bool bIsForceFinalTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_bIsForceFinalTrans) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_bIsForceFinalTrans) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F69 RID: 12137
		// (get) Token: 0x0601D8FF RID: 121087 RVA: 0x008FB654 File Offset: 0x008F9854
		// (set) Token: 0x0601D900 RID: 121088 RVA: 0x008FB664 File Offset: 0x008F9864
		public unsafe bool CollectExtraTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_CollectExtraTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_CollectExtraTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F6A RID: 12138
		// (get) Token: 0x0601D901 RID: 121089 RVA: 0x008FB675 File Offset: 0x008F9875
		// (set) Token: 0x0601D902 RID: 121090 RVA: 0x008FB685 File Offset: 0x008F9885
		public unsafe float 相机过渡时间
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_相机过渡时间);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_相机过渡时间) = value;
			}
		}

		// Token: 0x17002F6B RID: 12139
		// (get) Token: 0x0601D903 RID: 121091 RVA: 0x008FB696 File Offset: 0x008F9896
		// (set) Token: 0x0601D904 RID: 121092 RVA: 0x008FB6A6 File Offset: 0x008F98A6
		public unsafe bool 约束宽高比
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_约束宽高比) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_约束宽高比) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x0601D905 RID: 121093 RVA: 0x008FB6B7 File Offset: 0x008F98B7
		// (set) Token: 0x0601D906 RID: 121094 RVA: 0x008FB6C7 File Offset: 0x008F98C7
		public unsafe bool IsEnableDynamicStreamingSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_IsEnableDynamicStreamingSource) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_IsEnableDynamicStreamingSource) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x0601D907 RID: 121095 RVA: 0x008FB6D8 File Offset: 0x008F98D8
		// (set) Token: 0x0601D908 RID: 121096 RVA: 0x008FB6E8 File Offset: 0x008F98E8
		public unsafe bool 使用UI黑边
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_使用UI黑边) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_使用UI黑边) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F6E RID: 12142
		// (get) Token: 0x0601D909 RID: 121097 RVA: 0x008FB6F9 File Offset: 0x008F98F9
		// (set) Token: 0x0601D90A RID: 121098 RVA: 0x008FB709 File Offset: 0x008F9909
		public unsafe bool EnableStartTransformBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_EnableStartTransformBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_EnableStartTransformBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F6F RID: 12143
		// (get) Token: 0x0601D90B RID: 121099 RVA: 0x008FB71A File Offset: 0x008F991A
		// (set) Token: 0x0601D90C RID: 121100 RVA: 0x008FB72A File Offset: 0x008F992A
		public unsafe float StartTransformBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_StartTransformBlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_StartTransformBlendTime) = value;
			}
		}

		// Token: 0x17002F70 RID: 12144
		// (get) Token: 0x0601D90D RID: 121101 RVA: 0x008FB73B File Offset: 0x008F993B
		// (set) Token: 0x0601D90E RID: 121102 RVA: 0x008FB74B File Offset: 0x008F994B
		public unsafe bool 混入到相机首帧
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_混入到相机首帧) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_混入到相机首帧) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F71 RID: 12145
		// (get) Token: 0x0601D90F RID: 121103 RVA: 0x008FB75C File Offset: 0x008F995C
		// (set) Token: 0x0601D910 RID: 121104 RVA: 0x008FB76C File Offset: 0x008F996C
		public unsafe bool IsForceStreamSceneActor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_IsForceStreamSceneActor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_IsForceStreamSceneActor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002F72 RID: 12146
		// (get) Token: 0x0601D911 RID: 121105 RVA: 0x008FB780 File Offset: 0x008F9980
		// (set) Token: 0x0601D912 RID: 121106 RVA: 0x008FB7B9 File Offset: 0x008F99B9
		public TMap<int, FName> 实体说话人ID
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FName> result;
				if ((result = this._实体说话人ID) == null)
				{
					result = (this._实体说话人ID = new TMap<int, FName>(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_实体说话人ID, this));
				}
				return result;
			}
			set
			{
				this.实体说话人ID.CopyAssign(value);
			}
		}

		// Token: 0x17002F73 RID: 12147
		// (get) Token: 0x0601D913 RID: 121107 RVA: 0x008FB7C7 File Offset: 0x008F99C7
		// (set) Token: 0x0601D914 RID: 121108 RVA: 0x008FB7D7 File Offset: 0x008F99D7
		public unsafe bool AutoCalcStartTransformBlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_AutoCalcStartTransformBlendTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SequenceData_C.__PropertyOffset_AutoCalcStartTransformBlendTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601D915 RID: 121109 RVA: 0x008FB7E8 File Offset: 0x008F99E8
		protected BP_SequenceData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F912 RID: 63762
		public new const string __ObjectPath = "/Game/Aki/Sequence/Manager/BP_SequenceData.BP_SequenceData_C";

		// Token: 0x0400F913 RID: 63763
		private static IntPtr _ClassPtr;

		// Token: 0x0400F914 RID: 63764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F915 RID: 63765
		internal static int __PropertyOffset_类型;

		// Token: 0x0400F916 RID: 63766
		internal static int __PropertyOffset_剧情资源;

		// Token: 0x0400F917 RID: 63767
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelSequence> _剧情资源;

		// Token: 0x0400F918 RID: 63768
		internal static int __PropertyOffset_文本资源ID;

		// Token: 0x0400F919 RID: 63769
		internal static int __PropertyOffset_绑定角色标签;

		// Token: 0x0400F91A RID: 63770
		[Nullable(2)]
		private TArray<FName> _绑定角色标签;

		// Token: 0x0400F91B RID: 63771
		internal static int __PropertyOffset_绑定起始点标签;

		// Token: 0x0400F91C RID: 63772
		internal static int __PropertyOffset_是否固定起始点;

		// Token: 0x0400F91D RID: 63773
		internal static int __PropertyOffset_NeedSwitchMainCharacter;

		// Token: 0x0400F91E RID: 63774
		internal static int __PropertyOffset_IsTransformOverride;

		// Token: 0x0400F91F RID: 63775
		internal static int __PropertyOffset_OverrideTransform;

		// Token: 0x0400F920 RID: 63776
		internal static int __PropertyOffset_AnimationBlendInTime;

		// Token: 0x0400F921 RID: 63777
		internal static int __PropertyOffset_AnimationBlendOutTime;

		// Token: 0x0400F922 RID: 63778
		internal static int __PropertyOffset_CameraBlendInTime;

		// Token: 0x0400F923 RID: 63779
		internal static int __PropertyOffset_CameraBlendOutTime;

		// Token: 0x0400F924 RID: 63780
		internal static int __PropertyOffset_MovementSync;

		// Token: 0x0400F925 RID: 63781
		internal static int __PropertyOffset_SaveFinalTransform;

		// Token: 0x0400F926 RID: 63782
		internal static int __PropertyOffset_标识为演出制作中;

		// Token: 0x0400F927 RID: 63783
		internal static int __PropertyOffset_HidePlayer;

		// Token: 0x0400F928 RID: 63784
		internal static int __PropertyOffset_GeneratedData;

		// Token: 0x0400F929 RID: 63785
		internal static int __PropertyOffset_葫芦状态;

		// Token: 0x0400F92A RID: 63786
		internal static int __PropertyOffset_GraphName;

		// Token: 0x0400F92B RID: 63787
		internal static int __PropertyOffset_bIsForceFinalTrans;

		// Token: 0x0400F92C RID: 63788
		internal static int __PropertyOffset_CollectExtraTexture;

		// Token: 0x0400F92D RID: 63789
		internal static int __PropertyOffset_相机过渡时间;

		// Token: 0x0400F92E RID: 63790
		internal static int __PropertyOffset_约束宽高比;

		// Token: 0x0400F92F RID: 63791
		internal static int __PropertyOffset_IsEnableDynamicStreamingSource;

		// Token: 0x0400F930 RID: 63792
		internal static int __PropertyOffset_使用UI黑边;

		// Token: 0x0400F931 RID: 63793
		internal static int __PropertyOffset_EnableStartTransformBlend;

		// Token: 0x0400F932 RID: 63794
		internal static int __PropertyOffset_StartTransformBlendTime;

		// Token: 0x0400F933 RID: 63795
		internal static int __PropertyOffset_混入到相机首帧;

		// Token: 0x0400F934 RID: 63796
		internal static int __PropertyOffset_IsForceStreamSceneActor;

		// Token: 0x0400F935 RID: 63797
		internal static int __PropertyOffset_实体说话人ID;

		// Token: 0x0400F936 RID: 63798
		[Nullable(2)]
		private TMap<int, FName> _实体说话人ID;

		// Token: 0x0400F937 RID: 63799
		internal static int __PropertyOffset_AutoCalcStartTransformBlendTime;
	}
}
