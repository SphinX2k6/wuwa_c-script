using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712A RID: 28970
	public struct ILiveSetParam : IFlatbufferObject
	{
		// Token: 0x1700D420 RID: 54304
		// (get) Token: 0x06032533 RID: 206131 RVA: 0x006CDE45 File Offset: 0x006CC045
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032534 RID: 206132 RVA: 0x006CDE52 File Offset: 0x006CC052
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032535 RID: 206133 RVA: 0x006CDE5C File Offset: 0x006CC05C
		public static ILiveSetParam GetRootAsILiveSetParam(ByteBuffer _bb)
		{
			return ILiveSetParam.GetRootAsILiveSetParam(_bb, default(ILiveSetParam));
		}

		// Token: 0x06032536 RID: 206134 RVA: 0x006CDE78 File Offset: 0x006CC078
		public static ILiveSetParam GetRootAsILiveSetParam(ByteBuffer _bb, ILiveSetParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032537 RID: 206135 RVA: 0x006CDE95 File Offset: 0x006CC095
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032538 RID: 206136 RVA: 0x006CDEA4 File Offset: 0x006CC0A4
		public ILiveSetParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D421 RID: 54305
		// (get) Token: 0x06032539 RID: 206137 RVA: 0x006CDEB4 File Offset: 0x006CC0B4
		public TLiveParamConfig ParamType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TLiveParamConfig.NONE;
				}
				return (TLiveParamConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603253A RID: 206138 RVA: 0x006CDEF0 File Offset: 0x006CC0F0
		public TTable? Param<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603253B RID: 206139 RVA: 0x006CDF34 File Offset: 0x006CC134
		public ILiveDanmakuIntervalParam ParamAsILiveDanmakuIntervalParam()
		{
			return this.Param<ILiveDanmakuIntervalParam>().Value;
		}

		// Token: 0x0603253C RID: 206140 RVA: 0x006CDF50 File Offset: 0x006CC150
		public ILiveDanmakuTrackCountParam ParamAsILiveDanmakuTrackCountParam()
		{
			return this.Param<ILiveDanmakuTrackCountParam>().Value;
		}

		// Token: 0x0603253D RID: 206141 RVA: 0x006CDF6C File Offset: 0x006CC16C
		public ILiveForceDanmakuParam ParamAsILiveForceDanmakuParam()
		{
			return this.Param<ILiveForceDanmakuParam>().Value;
		}

		// Token: 0x0603253E RID: 206142 RVA: 0x006CDF88 File Offset: 0x006CC188
		public ILiveHeatParam ParamAsILiveHeatParam()
		{
			return this.Param<ILiveHeatParam>().Value;
		}

		// Token: 0x0603253F RID: 206143 RVA: 0x006CDFA4 File Offset: 0x006CC1A4
		public ILiveLikeParam ParamAsILiveLikeParam()
		{
			return this.Param<ILiveLikeParam>().Value;
		}

		// Token: 0x06032540 RID: 206144 RVA: 0x006CDFBF File Offset: 0x006CC1BF
		public static Offset<ILiveSetParam> CreateILiveSetParam(FlatBufferBuilder builder, TLiveParamConfig Param_type = TLiveParamConfig.NONE, int ParamOffset = 0)
		{
			builder.StartTable(2);
			ILiveSetParam.AddParam(builder, ParamOffset);
			ILiveSetParam.AddParamType(builder, Param_type);
			return ILiveSetParam.EndILiveSetParam(builder);
		}

		// Token: 0x06032541 RID: 206145 RVA: 0x006CDFDC File Offset: 0x006CC1DC
		public static void StartILiveSetParam(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06032542 RID: 206146 RVA: 0x006CDFE5 File Offset: 0x006CC1E5
		public static void AddParamType(FlatBufferBuilder builder, TLiveParamConfig paramType)
		{
			builder.AddByte(0, (byte)paramType, 0);
		}

		// Token: 0x06032543 RID: 206147 RVA: 0x006CDFF0 File Offset: 0x006CC1F0
		public static void AddParam(FlatBufferBuilder builder, int paramOffset)
		{
			builder.AddOffset(1, paramOffset, 0);
		}

		// Token: 0x06032544 RID: 206148 RVA: 0x006CDFFB File Offset: 0x006CC1FB
		public static Offset<ILiveSetParam> EndILiveSetParam(FlatBufferBuilder builder)
		{
			return new Offset<ILiveSetParam>(builder.EndTable());
		}

		// Token: 0x06032545 RID: 206149 RVA: 0x006CE008 File Offset: 0x006CC208
		public ILiveSetParamT UnPack()
		{
			ILiveSetParamT liveSetParamT = new ILiveSetParamT();
			this.UnPackTo(liveSetParamT);
			return liveSetParamT;
		}

		// Token: 0x06032546 RID: 206150 RVA: 0x006CE024 File Offset: 0x006CC224
		public void UnPackTo(ILiveSetParamT _o)
		{
			_o.Param = new TLiveParamConfigUnion();
			_o.Param.Type = this.ParamType;
			switch (this.ParamType)
			{
			case TLiveParamConfig.ILiveDanmakuIntervalParam:
				_o.Param.Value = ((this.Param<ILiveDanmakuIntervalParam>() != null) ? this.Param<ILiveDanmakuIntervalParam>().Value.UnPack() : null);
				return;
			case TLiveParamConfig.ILiveDanmakuTrackCountParam:
				_o.Param.Value = ((this.Param<ILiveDanmakuTrackCountParam>() != null) ? this.Param<ILiveDanmakuTrackCountParam>().Value.UnPack() : null);
				return;
			case TLiveParamConfig.ILiveForceDanmakuParam:
				_o.Param.Value = ((this.Param<ILiveForceDanmakuParam>() != null) ? this.Param<ILiveForceDanmakuParam>().Value.UnPack() : null);
				return;
			case TLiveParamConfig.ILiveHeatParam:
				_o.Param.Value = ((this.Param<ILiveHeatParam>() != null) ? this.Param<ILiveHeatParam>().Value.UnPack() : null);
				return;
			case TLiveParamConfig.ILiveLikeParam:
				_o.Param.Value = ((this.Param<ILiveLikeParam>() != null) ? this.Param<ILiveLikeParam>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06032547 RID: 206151 RVA: 0x006CE184 File Offset: 0x006CC384
		public static Offset<ILiveSetParam> Pack(FlatBufferBuilder builder, ILiveSetParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILiveSetParam>);
			}
			TLiveParamConfig param_type = (_o.Param == null) ? TLiveParamConfig.NONE : _o.Param.Type;
			int paramOffset = (_o.Param == null) ? 0 : TLiveParamConfigUnion.Pack(builder, _o.Param);
			return ILiveSetParam.CreateILiveSetParam(builder, param_type, paramOffset);
		}

		// Token: 0x04012111 RID: 74001
		private Table __p;
	}
}
