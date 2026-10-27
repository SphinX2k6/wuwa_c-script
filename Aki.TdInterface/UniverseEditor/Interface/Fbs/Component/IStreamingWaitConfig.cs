using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059E0 RID: 23008
	public struct IStreamingWaitConfig : IFlatbufferObject
	{
		// Token: 0x1700ACDC RID: 44252
		// (get) Token: 0x06027088 RID: 159880 RVA: 0x0055EEC0 File Offset: 0x0055D0C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027089 RID: 159881 RVA: 0x0055EECD File Offset: 0x0055D0CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602708A RID: 159882 RVA: 0x0055EED4 File Offset: 0x0055D0D4
		public static IStreamingWaitConfig GetRootAsIStreamingWaitConfig(ByteBuffer _bb)
		{
			return IStreamingWaitConfig.GetRootAsIStreamingWaitConfig(_bb, default(IStreamingWaitConfig));
		}

		// Token: 0x0602708B RID: 159883 RVA: 0x0055EEF0 File Offset: 0x0055D0F0
		public static IStreamingWaitConfig GetRootAsIStreamingWaitConfig(ByteBuffer _bb, IStreamingWaitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602708C RID: 159884 RVA: 0x0055EF0D File Offset: 0x0055D10D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602708D RID: 159885 RVA: 0x0055EF1C File Offset: 0x0055D11C
		public IStreamingWaitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACDD RID: 44253
		// (get) Token: 0x0602708E RID: 159886 RVA: 0x0055EF2C File Offset: 0x0055D12C
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

		// Token: 0x1700ACDE RID: 44254
		// (get) Token: 0x0602708F RID: 159887 RVA: 0x0055EF6C File Offset: 0x0055D16C
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

		// Token: 0x06027090 RID: 159888 RVA: 0x0055EFAC File Offset: 0x0055D1AC
		public static Offset<IStreamingWaitConfig> CreateIStreamingWaitConfig(FlatBufferBuilder builder, float MinWaitStreamDuration = 0f, float MaxWaitStreamDuration = 0f)
		{
			builder.StartTable(2);
			IStreamingWaitConfig.AddMaxWaitStreamDuration(builder, MaxWaitStreamDuration);
			IStreamingWaitConfig.AddMinWaitStreamDuration(builder, MinWaitStreamDuration);
			return IStreamingWaitConfig.EndIStreamingWaitConfig(builder);
		}

		// Token: 0x06027091 RID: 159889 RVA: 0x0055EFC9 File Offset: 0x0055D1C9
		public static void StartIStreamingWaitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027092 RID: 159890 RVA: 0x0055EFD2 File Offset: 0x0055D1D2
		public static void AddMinWaitStreamDuration(FlatBufferBuilder builder, float minWaitStreamDuration)
		{
			builder.AddFloat(0, minWaitStreamDuration, 0.0);
		}

		// Token: 0x06027093 RID: 159891 RVA: 0x0055EFE5 File Offset: 0x0055D1E5
		public static void AddMaxWaitStreamDuration(FlatBufferBuilder builder, float maxWaitStreamDuration)
		{
			builder.AddFloat(1, maxWaitStreamDuration, 0.0);
		}

		// Token: 0x06027094 RID: 159892 RVA: 0x0055EFF8 File Offset: 0x0055D1F8
		public static Offset<IStreamingWaitConfig> EndIStreamingWaitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStreamingWaitConfig>(builder.EndTable());
		}

		// Token: 0x06027095 RID: 159893 RVA: 0x0055F008 File Offset: 0x0055D208
		public IStreamingWaitConfigT UnPack()
		{
			IStreamingWaitConfigT streamingWaitConfigT = new IStreamingWaitConfigT();
			this.UnPackTo(streamingWaitConfigT);
			return streamingWaitConfigT;
		}

		// Token: 0x06027096 RID: 159894 RVA: 0x0055F023 File Offset: 0x0055D223
		public void UnPackTo(IStreamingWaitConfigT _o)
		{
			_o.MinWaitStreamDuration = this.MinWaitStreamDuration;
			_o.MaxWaitStreamDuration = this.MaxWaitStreamDuration;
		}

		// Token: 0x06027097 RID: 159895 RVA: 0x0055F040 File Offset: 0x0055D240
		public static Offset<IStreamingWaitConfig> Pack(FlatBufferBuilder builder, IStreamingWaitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStreamingWaitConfig>);
			}
			return IStreamingWaitConfig.CreateIStreamingWaitConfig(builder, _o.MinWaitStreamDuration, _o.MaxWaitStreamDuration);
		}

		// Token: 0x0400F019 RID: 61465
		private Table __p;
	}
}
