using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007119 RID: 28953
	public class ILiveParamConfig_UnionUnion
	{
		// Token: 0x1700D40C RID: 54284
		// (get) Token: 0x060324B5 RID: 206005 RVA: 0x006CD009 File Offset: 0x006CB209
		// (set) Token: 0x060324B6 RID: 206006 RVA: 0x006CD011 File Offset: 0x006CB211
		public ILiveParamConfig_Union Type { get; set; }

		// Token: 0x1700D40D RID: 54285
		// (get) Token: 0x060324B7 RID: 206007 RVA: 0x006CD01A File Offset: 0x006CB21A
		// (set) Token: 0x060324B8 RID: 206008 RVA: 0x006CD022 File Offset: 0x006CB222
		public object Value { get; set; }

		// Token: 0x060324B9 RID: 206009 RVA: 0x006CD02B File Offset: 0x006CB22B
		public ILiveParamConfig_UnionUnion()
		{
			this.Type = ILiveParamConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060324BA RID: 206010 RVA: 0x006CD041 File Offset: 0x006CB241
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060324BB RID: 206011 RVA: 0x006CD053 File Offset: 0x006CB253
		public ILiveParamConfigT AsILiveParamConfig()
		{
			return this.As<ILiveParamConfigT>();
		}

		// Token: 0x060324BC RID: 206012 RVA: 0x006CD05B File Offset: 0x006CB25B
		public static ILiveParamConfig_UnionUnion FromILiveParamConfig(ILiveParamConfigT _iliveparamconfig)
		{
			return new ILiveParamConfig_UnionUnion
			{
				Type = ILiveParamConfig_Union.ILiveParamConfig,
				Value = _iliveparamconfig
			};
		}

		// Token: 0x060324BD RID: 206013 RVA: 0x006CD070 File Offset: 0x006CB270
		public ILiveHeatParamT AsILiveHeatParam()
		{
			return this.As<ILiveHeatParamT>();
		}

		// Token: 0x060324BE RID: 206014 RVA: 0x006CD078 File Offset: 0x006CB278
		public static ILiveParamConfig_UnionUnion FromILiveHeatParam(ILiveHeatParamT _iliveheatparam)
		{
			return new ILiveParamConfig_UnionUnion
			{
				Type = ILiveParamConfig_Union.ILiveHeatParam,
				Value = _iliveheatparam
			};
		}

		// Token: 0x060324BF RID: 206015 RVA: 0x006CD08D File Offset: 0x006CB28D
		public ILiveDanmakuIntervalParamT AsILiveDanmakuIntervalParam()
		{
			return this.As<ILiveDanmakuIntervalParamT>();
		}

		// Token: 0x060324C0 RID: 206016 RVA: 0x006CD095 File Offset: 0x006CB295
		public static ILiveParamConfig_UnionUnion FromILiveDanmakuIntervalParam(ILiveDanmakuIntervalParamT _ilivedanmakuintervalparam)
		{
			return new ILiveParamConfig_UnionUnion
			{
				Type = ILiveParamConfig_Union.ILiveDanmakuIntervalParam,
				Value = _ilivedanmakuintervalparam
			};
		}

		// Token: 0x060324C1 RID: 206017 RVA: 0x006CD0AA File Offset: 0x006CB2AA
		public ILiveDanmakuTrackCountParamT AsILiveDanmakuTrackCountParam()
		{
			return this.As<ILiveDanmakuTrackCountParamT>();
		}

		// Token: 0x060324C2 RID: 206018 RVA: 0x006CD0B2 File Offset: 0x006CB2B2
		public static ILiveParamConfig_UnionUnion FromILiveDanmakuTrackCountParam(ILiveDanmakuTrackCountParamT _ilivedanmakutrackcountparam)
		{
			return new ILiveParamConfig_UnionUnion
			{
				Type = ILiveParamConfig_Union.ILiveDanmakuTrackCountParam,
				Value = _ilivedanmakutrackcountparam
			};
		}

		// Token: 0x060324C3 RID: 206019 RVA: 0x006CD0C7 File Offset: 0x006CB2C7
		public ILiveForceDanmakuParamT AsILiveForceDanmakuParam()
		{
			return this.As<ILiveForceDanmakuParamT>();
		}

		// Token: 0x060324C4 RID: 206020 RVA: 0x006CD0CF File Offset: 0x006CB2CF
		public static ILiveParamConfig_UnionUnion FromILiveForceDanmakuParam(ILiveForceDanmakuParamT _iliveforcedanmakuparam)
		{
			return new ILiveParamConfig_UnionUnion
			{
				Type = ILiveParamConfig_Union.ILiveForceDanmakuParam,
				Value = _iliveforcedanmakuparam
			};
		}

		// Token: 0x060324C5 RID: 206021 RVA: 0x006CD0E4 File Offset: 0x006CB2E4
		public ILiveLikeParamT AsILiveLikeParam()
		{
			return this.As<ILiveLikeParamT>();
		}

		// Token: 0x060324C6 RID: 206022 RVA: 0x006CD0EC File Offset: 0x006CB2EC
		public static ILiveParamConfig_UnionUnion FromILiveLikeParam(ILiveLikeParamT _ilivelikeparam)
		{
			return new ILiveParamConfig_UnionUnion
			{
				Type = ILiveParamConfig_Union.ILiveLikeParam,
				Value = _ilivelikeparam
			};
		}

		// Token: 0x060324C7 RID: 206023 RVA: 0x006CD104 File Offset: 0x006CB304
		public static int Pack(FlatBufferBuilder builder, ILiveParamConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ILiveParamConfig_Union.ILiveParamConfig:
				return ILiveParamConfig.Pack(builder, _o.AsILiveParamConfig()).Value;
			case ILiveParamConfig_Union.ILiveHeatParam:
				return ILiveHeatParam.Pack(builder, _o.AsILiveHeatParam()).Value;
			case ILiveParamConfig_Union.ILiveDanmakuIntervalParam:
				return ILiveDanmakuIntervalParam.Pack(builder, _o.AsILiveDanmakuIntervalParam()).Value;
			case ILiveParamConfig_Union.ILiveDanmakuTrackCountParam:
				return ILiveDanmakuTrackCountParam.Pack(builder, _o.AsILiveDanmakuTrackCountParam()).Value;
			case ILiveParamConfig_Union.ILiveForceDanmakuParam:
				return ILiveForceDanmakuParam.Pack(builder, _o.AsILiveForceDanmakuParam()).Value;
			case ILiveParamConfig_Union.ILiveLikeParam:
				return ILiveLikeParam.Pack(builder, _o.AsILiveLikeParam()).Value;
			default:
				return 0;
			}
		}
	}
}
