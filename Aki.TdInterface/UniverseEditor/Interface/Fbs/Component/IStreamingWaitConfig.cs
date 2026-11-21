using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FED RID: 24557
	public struct IStreamingWaitConfig : IFlatbufferObject
	{
		// Token: 0x1700B614 RID: 46612
		// (get) Token: 0x06029600 RID: 169472 RVA: 0x005A5E84 File Offset: 0x005A4084
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029601 RID: 169473 RVA: 0x005A5E91 File Offset: 0x005A4091
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029602 RID: 169474 RVA: 0x005A5E98 File Offset: 0x005A4098
		public static IStreamingWaitConfig GetRootAsIStreamingWaitConfig(ByteBuffer _bb)
		{
			return IStreamingWaitConfig.GetRootAsIStreamingWaitConfig(_bb, default(IStreamingWaitConfig));
		}

		// Token: 0x06029603 RID: 169475 RVA: 0x005A5EB4 File Offset: 0x005A40B4
		public static IStreamingWaitConfig GetRootAsIStreamingWaitConfig(ByteBuffer _bb, IStreamingWaitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029604 RID: 169476 RVA: 0x005A5ED1 File Offset: 0x005A40D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029605 RID: 169477 RVA: 0x005A5EE0 File Offset: 0x005A40E0
		public IStreamingWaitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B615 RID: 46613
		// (get) Token: 0x06029606 RID: 169478 RVA: 0x005A5EF0 File Offset: 0x005A40F0
		public float MinWaitStreamDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B616 RID: 46614
		// (get) Token: 0x06029607 RID: 169479 RVA: 0x005A5F30 File Offset: 0x005A4130
		public float MaxWaitStreamDuration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029608 RID: 169480 RVA: 0x005A5F70 File Offset: 0x005A4170
		public static Offset<IStreamingWaitConfig> CreateIStreamingWaitConfig(FlatBufferBuilder builder, float MinWaitStreamDuration = 0f, float MaxWaitStreamDuration = 0f)
		{
			builder.StartTable(2);
			IStreamingWaitConfig.AddMaxWaitStreamDuration(builder, MaxWaitStreamDuration);
			IStreamingWaitConfig.AddMinWaitStreamDuration(builder, MinWaitStreamDuration);
			return IStreamingWaitConfig.EndIStreamingWaitConfig(builder);
		}

		// Token: 0x06029609 RID: 169481 RVA: 0x005A5F8D File Offset: 0x005A418D
		public static void StartIStreamingWaitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602960A RID: 169482 RVA: 0x005A5F96 File Offset: 0x005A4196
		public static void AddMinWaitStreamDuration(FlatBufferBuilder builder, float minWaitStreamDuration)
		{
			builder.AddFloat(0, minWaitStreamDuration, 0.0);
		}

		// Token: 0x0602960B RID: 169483 RVA: 0x005A5FA9 File Offset: 0x005A41A9
		public static void AddMaxWaitStreamDuration(FlatBufferBuilder builder, float maxWaitStreamDuration)
		{
			builder.AddFloat(1, maxWaitStreamDuration, 0.0);
		}

		// Token: 0x0602960C RID: 169484 RVA: 0x005A5FBC File Offset: 0x005A41BC
		public static Offset<IStreamingWaitConfig> EndIStreamingWaitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingWaitConfig>(builder.EndTable());
		}

		// Token: 0x0602960D RID: 169485 RVA: 0x005A5FCC File Offset: 0x005A41CC
		public IStreamingWaitConfigT UnPack()
		{
			IStreamingWaitConfigT streamingWaitConfigT = new IStreamingWaitConfigT();
			this.UnPackTo(streamingWaitConfigT);
			return streamingWaitConfigT;
		}

		// Token: 0x0602960E RID: 169486 RVA: 0x005A5FE7 File Offset: 0x005A41E7
		public void UnPackTo(IStreamingWaitConfigT _o)
		{
			_o.MinWaitStreamDuration = this.MinWaitStreamDuration;
			_o.MaxWaitStreamDuration = this.MaxWaitStreamDuration;
		}

		// Token: 0x0602960F RID: 169487 RVA: 0x005A6004 File Offset: 0x005A4204
		public static Offset<IStreamingWaitConfig> Pack(FlatBufferBuilder builder, IStreamingWaitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingWaitConfig>);
			}
			return IStreamingWaitConfig.CreateIStreamingWaitConfig(builder, _o.MinWaitStreamDuration, _o.MaxWaitStreamDuration);
		}

		// Token: 0x0400FD10 RID: 64784
		private Table __p;
	}
}
