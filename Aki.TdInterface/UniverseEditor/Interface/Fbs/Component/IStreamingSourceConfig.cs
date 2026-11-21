using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE1 RID: 24545
	public struct IStreamingSourceConfig : IFlatbufferObject
	{
		// Token: 0x1700B5FF RID: 46591
		// (get) Token: 0x060295A4 RID: 169380 RVA: 0x005A5494 File Offset: 0x005A3694
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060295A5 RID: 169381 RVA: 0x005A54A1 File Offset: 0x005A36A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060295A6 RID: 169382 RVA: 0x005A54A8 File Offset: 0x005A36A8
		public static IStreamingSourceConfig GetRootAsIStreamingSourceConfig(ByteBuffer _bb)
		{
			return IStreamingSourceConfig.GetRootAsIStreamingSourceConfig(_bb, default(IStreamingSourceConfig));
		}

		// Token: 0x060295A7 RID: 169383 RVA: 0x005A54C4 File Offset: 0x005A36C4
		public static IStreamingSourceConfig GetRootAsIStreamingSourceConfig(ByteBuffer _bb, IStreamingSourceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060295A8 RID: 169384 RVA: 0x005A54E1 File Offset: 0x005A36E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060295A9 RID: 169385 RVA: 0x005A54F0 File Offset: 0x005A36F0
		public IStreamingSourceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B600 RID: 46592
		// (get) Token: 0x060295AA RID: 169386 RVA: 0x005A5500 File Offset: 0x005A3700
		public int StreamingSourceTargetEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B601 RID: 46593
		// (get) Token: 0x060295AB RID: 169387 RVA: 0x005A553C File Offset: 0x005A373C
		public bool IsNoRenderStreaming
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B602 RID: 46594
		// (get) Token: 0x060295AC RID: 169388 RVA: 0x005A557C File Offset: 0x005A377C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060295AD RID: 169389 RVA: 0x005A55B8 File Offset: 0x005A37B8
		public static Offset<IStreamingSourceConfig> CreateIStreamingSourceConfig(FlatBufferBuilder builder, int StreamingSourceTargetEntityId = 0, bool IsNoRenderStreaming = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IStreamingSourceConfig.AddStreamingSourceTargetEntityId(builder, StreamingSourceTargetEntityId);
			IStreamingSourceConfig.AddNullMask(builder, NullMask);
			IStreamingSourceConfig.AddIsNoRenderStreaming(builder, IsNoRenderStreaming);
			return IStreamingSourceConfig.EndIStreamingSourceConfig(builder);
		}

		// Token: 0x060295AE RID: 169390 RVA: 0x005A55DC File Offset: 0x005A37DC
		public static void StartIStreamingSourceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060295AF RID: 169391 RVA: 0x005A55E5 File Offset: 0x005A37E5
		public static void AddStreamingSourceTargetEntityId(FlatBufferBuilder builder, int streamingSourceTargetEntityId)
		{
			builder.AddInt(0, streamingSourceTargetEntityId, 0);
		}

		// Token: 0x060295B0 RID: 169392 RVA: 0x005A55F0 File Offset: 0x005A37F0
		public static void AddIsNoRenderStreaming(FlatBufferBuilder builder, bool isNoRenderStreaming)
		{
			builder.AddBool(1, isNoRenderStreaming, false);
		}

		// Token: 0x060295B1 RID: 169393 RVA: 0x005A55FB File Offset: 0x005A37FB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060295B2 RID: 169394 RVA: 0x005A5606 File Offset: 0x005A3806
		public static Offset<IStreamingSourceConfig> EndIStreamingSourceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingSourceConfig>(builder.EndTable());
		}

		// Token: 0x060295B3 RID: 169395 RVA: 0x005A5614 File Offset: 0x005A3814
		public IStreamingSourceConfigT UnPack()
		{
			IStreamingSourceConfigT streamingSourceConfigT = new IStreamingSourceConfigT();
			this.UnPackTo(streamingSourceConfigT);
			return streamingSourceConfigT;
		}

		// Token: 0x060295B4 RID: 169396 RVA: 0x005A562F File Offset: 0x005A382F
		public void UnPackTo(IStreamingSourceConfigT _o)
		{
			_o.StreamingSourceTargetEntityId = this.StreamingSourceTargetEntityId;
			_o.IsNoRenderStreaming = this.IsNoRenderStreaming;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060295B5 RID: 169397 RVA: 0x005A5658 File Offset: 0x005A3858
		public static Offset<IStreamingSourceConfig> Pack(FlatBufferBuilder builder, IStreamingSourceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingSourceConfig>);
			}
			return IStreamingSourceConfig.CreateIStreamingSourceConfig(builder, _o.StreamingSourceTargetEntityId, _o.IsNoRenderStreaming, _o.NullMask);
		}

		// Token: 0x0400FCFE RID: 64766
		private Table __p;
	}
}
