using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057DE RID: 22494
	public struct IFixedStreamingSource : IFlatbufferObject
	{
		// Token: 0x1700A2B2 RID: 41650
		// (get) Token: 0x06024567 RID: 148839 RVA: 0x004FE385 File Offset: 0x004FC585
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024568 RID: 148840 RVA: 0x004FE392 File Offset: 0x004FC592
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024569 RID: 148841 RVA: 0x004FE39C File Offset: 0x004FC59C
		public static IFixedStreamingSource GetRootAsIFixedStreamingSource(ByteBuffer _bb)
		{
			return IFixedStreamingSource.GetRootAsIFixedStreamingSource(_bb, default(IFixedStreamingSource));
		}

		// Token: 0x0602456A RID: 148842 RVA: 0x004FE3B8 File Offset: 0x004FC5B8
		public static IFixedStreamingSource GetRootAsIFixedStreamingSource(ByteBuffer _bb, IFixedStreamingSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602456B RID: 148843 RVA: 0x004FE3D5 File Offset: 0x004FC5D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602456C RID: 148844 RVA: 0x004FE3E4 File Offset: 0x004FC5E4
		public IFixedStreamingSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2B3 RID: 41651
		// (get) Token: 0x0602456D RID: 148845 RVA: 0x004FE3F4 File Offset: 0x004FC5F4
		public EStreamingSourceMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStreamingSourceMode.Fixed;
				}
				return (EStreamingSourceMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A2B4 RID: 41652
		// (get) Token: 0x0602456E RID: 148846 RVA: 0x004FE430 File Offset: 0x004FC630
		public IStreamingSourceConfig? StreamingSourceConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IStreamingSourceConfig?(default(IStreamingSourceConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602456F RID: 148847 RVA: 0x004FE48D File Offset: 0x004FC68D
		public static Offset<IFixedStreamingSource> CreateIFixedStreamingSource(FlatBufferBuilder builder, EStreamingSourceMode Type = EStreamingSourceMode.Fixed, Offset<IStreamingSourceConfig> StreamingSourceConfigOffset = default(Offset<IStreamingSourceConfig>))
		{
			builder.StartTable(2);
			IFixedStreamingSource.AddStreamingSourceConfig(builder, StreamingSourceConfigOffset);
			IFixedStreamingSource.AddType(builder, Type);
			return IFixedStreamingSource.EndIFixedStreamingSource(builder);
		}

		// Token: 0x06024570 RID: 148848 RVA: 0x004FE4AA File Offset: 0x004FC6AA
		public static void StartIFixedStreamingSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024571 RID: 148849 RVA: 0x004FE4B3 File Offset: 0x004FC6B3
		public static void AddType(FlatBufferBuilder builder, EStreamingSourceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024572 RID: 148850 RVA: 0x004FE4BE File Offset: 0x004FC6BE
		public static void AddStreamingSourceConfig(FlatBufferBuilder builder, Offset<IStreamingSourceConfig> streamingSourceConfigOffset)
		{
			builder.AddOffset(1, streamingSourceConfigOffset.Value, 0);
		}

		// Token: 0x06024573 RID: 148851 RVA: 0x004FE4CE File Offset: 0x004FC6CE
		public static Offset<IFixedStreamingSource> EndIFixedStreamingSource(FlatBufferBuilder builder)
		{
			return new Offset<IFixedStreamingSource>(builder.EndTable());
		}

		// Token: 0x06024574 RID: 148852 RVA: 0x004FE4DC File Offset: 0x004FC6DC
		public IFixedStreamingSourceT UnPack()
		{
			IFixedStreamingSourceT fixedStreamingSourceT = new IFixedStreamingSourceT();
			this.UnPackTo(fixedStreamingSourceT);
			return fixedStreamingSourceT;
		}

		// Token: 0x06024575 RID: 148853 RVA: 0x004FE4F8 File Offset: 0x004FC6F8
		public void UnPackTo(IFixedStreamingSourceT _o)
		{
			_o.Type = this.Type;
			_o.StreamingSourceConfig = ((this.StreamingSourceConfig != null) ? this.StreamingSourceConfig.Value.UnPack() : null);
		}

		// Token: 0x06024576 RID: 148854 RVA: 0x004FE540 File Offset: 0x004FC740
		public static Offset<IFixedStreamingSource> Pack(FlatBufferBuilder builder, IFixedStreamingSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedStreamingSource>);
			}
			Offset<IStreamingSourceConfig> streamingSourceConfigOffset = (_o.StreamingSourceConfig == null) ? default(Offset<IStreamingSourceConfig>) : IStreamingSourceConfig.Pack(builder, _o.StreamingSourceConfig);
			return IFixedStreamingSource.CreateIFixedStreamingSource(builder, _o.Type, streamingSourceConfigOffset);
		}

		// Token: 0x0400EFDC RID: 61404
		private Table __p;
	}
}
