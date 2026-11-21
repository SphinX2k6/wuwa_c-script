using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F28 RID: 32552
	public class TLiveParamConfigUnion
	{
		// Token: 0x1700F293 RID: 62099
		// (get) Token: 0x0603AB7F RID: 240511 RVA: 0x007E57B4 File Offset: 0x007E39B4
		// (set) Token: 0x0603AB80 RID: 240512 RVA: 0x007E57BC File Offset: 0x007E39BC
		public TLiveParamConfig Type { get; set; }

		// Token: 0x1700F294 RID: 62100
		// (get) Token: 0x0603AB81 RID: 240513 RVA: 0x007E57C5 File Offset: 0x007E39C5
		// (set) Token: 0x0603AB82 RID: 240514 RVA: 0x007E57CD File Offset: 0x007E39CD
		public object Value { get; set; }

		// Token: 0x0603AB83 RID: 240515 RVA: 0x007E57D6 File Offset: 0x007E39D6
		public TLiveParamConfigUnion()
		{
			this.Type = TLiveParamConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603AB84 RID: 240516 RVA: 0x007E57EC File Offset: 0x007E39EC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AB85 RID: 240517 RVA: 0x007E57FE File Offset: 0x007E39FE
		public ILiveDanmakuIntervalParamT AsILiveDanmakuIntervalParam()
		{
			return this.As<ILiveDanmakuIntervalParamT>();
		}

		// Token: 0x0603AB86 RID: 240518 RVA: 0x007E5806 File Offset: 0x007E3A06
		public static TLiveParamConfigUnion FromILiveDanmakuIntervalParam(ILiveDanmakuIntervalParamT _ilivedanmakuintervalparam)
		{
			return new TLiveParamConfigUnion
			{
				Type = TLiveParamConfig.ILiveDanmakuIntervalParam,
				Value = _ilivedanmakuintervalparam
			};
		}

		// Token: 0x0603AB87 RID: 240519 RVA: 0x007E581B File Offset: 0x007E3A1B
		public ILiveDanmakuTrackCountParamT AsILiveDanmakuTrackCountParam()
		{
			return this.As<ILiveDanmakuTrackCountParamT>();
		}

		// Token: 0x0603AB88 RID: 240520 RVA: 0x007E5823 File Offset: 0x007E3A23
		public static TLiveParamConfigUnion FromILiveDanmakuTrackCountParam(ILiveDanmakuTrackCountParamT _ilivedanmakutrackcountparam)
		{
			return new TLiveParamConfigUnion
			{
				Type = TLiveParamConfig.ILiveDanmakuTrackCountParam,
				Value = _ilivedanmakutrackcountparam
			};
		}

		// Token: 0x0603AB89 RID: 240521 RVA: 0x007E5838 File Offset: 0x007E3A38
		public ILiveForceDanmakuParamT AsILiveForceDanmakuParam()
		{
			return this.As<ILiveForceDanmakuParamT>();
		}

		// Token: 0x0603AB8A RID: 240522 RVA: 0x007E5840 File Offset: 0x007E3A40
		public static TLiveParamConfigUnion FromILiveForceDanmakuParam(ILiveForceDanmakuParamT _iliveforcedanmakuparam)
		{
			return new TLiveParamConfigUnion
			{
				Type = TLiveParamConfig.ILiveForceDanmakuParam,
				Value = _iliveforcedanmakuparam
			};
		}

		// Token: 0x0603AB8B RID: 240523 RVA: 0x007E5855 File Offset: 0x007E3A55
		public ILiveHeatParamT AsILiveHeatParam()
		{
			return this.As<ILiveHeatParamT>();
		}

		// Token: 0x0603AB8C RID: 240524 RVA: 0x007E585D File Offset: 0x007E3A5D
		public static TLiveParamConfigUnion FromILiveHeatParam(ILiveHeatParamT _iliveheatparam)
		{
			return new TLiveParamConfigUnion
			{
				Type = TLiveParamConfig.ILiveHeatParam,
				Value = _iliveheatparam
			};
		}

		// Token: 0x0603AB8D RID: 240525 RVA: 0x007E5872 File Offset: 0x007E3A72
		public ILiveLikeParamT AsILiveLikeParam()
		{
			return this.As<ILiveLikeParamT>();
		}

		// Token: 0x0603AB8E RID: 240526 RVA: 0x007E587A File Offset: 0x007E3A7A
		public static TLiveParamConfigUnion FromILiveLikeParam(ILiveLikeParamT _ilivelikeparam)
		{
			return new TLiveParamConfigUnion
			{
				Type = TLiveParamConfig.ILiveLikeParam,
				Value = _ilivelikeparam
			};
		}

		// Token: 0x0603AB8F RID: 240527 RVA: 0x007E5890 File Offset: 0x007E3A90
		public static int Pack(FlatBufferBuilder builder, TLiveParamConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TLiveParamConfig.ILiveDanmakuIntervalParam:
				return ILiveDanmakuIntervalParam.Pack(builder, _o.AsILiveDanmakuIntervalParam()).Value;
			case TLiveParamConfig.ILiveDanmakuTrackCountParam:
				return ILiveDanmakuTrackCountParam.Pack(builder, _o.AsILiveDanmakuTrackCountParam()).Value;
			case TLiveParamConfig.ILiveForceDanmakuParam:
				return ILiveForceDanmakuParam.Pack(builder, _o.AsILiveForceDanmakuParam()).Value;
			case TLiveParamConfig.ILiveHeatParam:
				return ILiveHeatParam.Pack(builder, _o.AsILiveHeatParam()).Value;
			case TLiveParamConfig.ILiveLikeParam:
				return ILiveLikeParam.Pack(builder, _o.AsILiveLikeParam()).Value;
			default:
				return 0;
			}
		}
	}
}
