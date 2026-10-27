using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005276 RID: 21110
	public struct IFixedStreamingSource : IFlatbufferObject
	{
		// Token: 0x17009AB4 RID: 39604
		// (get) Token: 0x060225CD RID: 140749 RVA: 0x004C3815 File Offset: 0x004C1A15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060225CE RID: 140750 RVA: 0x004C3822 File Offset: 0x004C1A22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060225CF RID: 140751 RVA: 0x004C382C File Offset: 0x004C1A2C
		public static IFixedStreamingSource GetRootAsIFixedStreamingSource(ByteBuffer _bb)
		{
			return IFixedStreamingSource.GetRootAsIFixedStreamingSource(_bb, default(IFixedStreamingSource));
		}

		// Token: 0x060225D0 RID: 140752 RVA: 0x004C3848 File Offset: 0x004C1A48
		public static IFixedStreamingSource GetRootAsIFixedStreamingSource(ByteBuffer _bb, IFixedStreamingSource obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060225D1 RID: 140753 RVA: 0x004C3865 File Offset: 0x004C1A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060225D2 RID: 140754 RVA: 0x004C3874 File Offset: 0x004C1A74
		public IFixedStreamingSource __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AB5 RID: 39605
		// (get) Token: 0x060225D3 RID: 140755 RVA: 0x004C3884 File Offset: 0x004C1A84
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

		// Token: 0x17009AB6 RID: 39606
		// (get) Token: 0x060225D4 RID: 140756 RVA: 0x004C38C0 File Offset: 0x004C1AC0
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

		// Token: 0x060225D5 RID: 140757 RVA: 0x004C391D File Offset: 0x004C1B1D
		public static Offset<IFixedStreamingSource> CreateIFixedStreamingSource(FlatBufferBuilder builder, EStreamingSourceMode Type = EStreamingSourceMode.Fixed, Offset<IStreamingSourceConfig> StreamingSourceConfigOffset = default(Offset<IStreamingSourceConfig>))
		{
			builder.StartTable(2);
			IFixedStreamingSource.AddStreamingSourceConfig(builder, StreamingSourceConfigOffset);
			IFixedStreamingSource.AddType(builder, Type);
			return IFixedStreamingSource.EndIFixedStreamingSource(builder);
		}

		// Token: 0x060225D6 RID: 140758 RVA: 0x004C393A File Offset: 0x004C1B3A
		public static void StartIFixedStreamingSource(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060225D7 RID: 140759 RVA: 0x004C3943 File Offset: 0x004C1B43
		public static void AddType(FlatBufferBuilder builder, EStreamingSourceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060225D8 RID: 140760 RVA: 0x004C394E File Offset: 0x004C1B4E
		public static void AddStreamingSourceConfig(FlatBufferBuilder builder, Offset<IStreamingSourceConfig> streamingSourceConfigOffset)
		{
			builder.AddOffset(1, streamingSourceConfigOffset.Value, 0);
		}

		// Token: 0x060225D9 RID: 140761 RVA: 0x004C395E File Offset: 0x004C1B5E
		public static Offset<IFixedStreamingSource> EndIFixedStreamingSource(FlatBufferBuilder builder)
		{
			return new Offset<IFixedStreamingSource>(builder.EndTable());
		}

		// Token: 0x060225DA RID: 140762 RVA: 0x004C396C File Offset: 0x004C1B6C
		public IFixedStreamingSourceT UnPack()
		{
			IFixedStreamingSourceT fixedStreamingSourceT = new IFixedStreamingSourceT();
			this.UnPackTo(fixedStreamingSourceT);
			return fixedStreamingSourceT;
		}

		// Token: 0x060225DB RID: 140763 RVA: 0x004C3988 File Offset: 0x004C1B88
		public void UnPackTo(IFixedStreamingSourceT _o)
		{
			_o.Type = this.Type;
			_o.StreamingSourceConfig = ((this.StreamingSourceConfig != null) ? this.StreamingSourceConfig.Value.UnPack() : null);
		}

		// Token: 0x060225DC RID: 140764 RVA: 0x004C39D0 File Offset: 0x004C1BD0
		public static Offset<IFixedStreamingSource> Pack(FlatBufferBuilder builder, IFixedStreamingSourceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedStreamingSource>);
			}
			Offset<IStreamingSourceConfig> streamingSourceConfigOffset = (_o.StreamingSourceConfig == null) ? default(Offset<IStreamingSourceConfig>) : IStreamingSourceConfig.Pack(builder, _o.StreamingSourceConfig);
			return IFixedStreamingSource.CreateIFixedStreamingSource(builder, _o.Type, streamingSourceConfigOffset);
		}

		// Token: 0x0400E3D5 RID: 58325
		private Table __p;
	}
}
