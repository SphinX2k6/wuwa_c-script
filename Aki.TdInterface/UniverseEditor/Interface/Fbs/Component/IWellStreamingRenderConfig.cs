using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B71 RID: 23409
	public struct IWellStreamingRenderConfig : IFlatbufferObject
	{
		// Token: 0x1700B0E4 RID: 45284
		// (get) Token: 0x06028101 RID: 164097 RVA: 0x00581F32 File Offset: 0x00580132
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028102 RID: 164098 RVA: 0x00581F3F File Offset: 0x0058013F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028103 RID: 164099 RVA: 0x00581F48 File Offset: 0x00580148
		public static IWellStreamingRenderConfig GetRootAsIWellStreamingRenderConfig(ByteBuffer _bb)
		{
			return IWellStreamingRenderConfig.GetRootAsIWellStreamingRenderConfig(_bb, default(IWellStreamingRenderConfig));
		}

		// Token: 0x06028104 RID: 164100 RVA: 0x00581F64 File Offset: 0x00580164
		public static IWellStreamingRenderConfig GetRootAsIWellStreamingRenderConfig(ByteBuffer _bb, IWellStreamingRenderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028105 RID: 164101 RVA: 0x00581F81 File Offset: 0x00580181
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028106 RID: 164102 RVA: 0x00581F90 File Offset: 0x00580190
		public IWellStreamingRenderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0E5 RID: 45285
		// (get) Token: 0x06028107 RID: 164103 RVA: 0x00581FA0 File Offset: 0x005801A0
		public IWellStreamingRenderSelfConfig? SelfConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IWellStreamingRenderSelfConfig?(default(IWellStreamingRenderSelfConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B0E6 RID: 45286
		// (get) Token: 0x06028108 RID: 164104 RVA: 0x00582000 File Offset: 0x00580200
		public IWellStreamingRenderPointConfig? AsStreamPointConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IWellStreamingRenderPointConfig?(default(IWellStreamingRenderPointConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028109 RID: 164105 RVA: 0x0058205D File Offset: 0x0058025D
		public static Offset<IWellStreamingRenderConfig> CreateIWellStreamingRenderConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderSelfConfig> SelfConfigOffset = default(Offset<IWellStreamingRenderSelfConfig>), Offset<IWellStreamingRenderPointConfig> AsStreamPointConfigOffset = default(Offset<IWellStreamingRenderPointConfig>))
		{
			builder.StartTable(2);
			IWellStreamingRenderConfig.AddAsStreamPointConfig(builder, AsStreamPointConfigOffset);
			IWellStreamingRenderConfig.AddSelfConfig(builder, SelfConfigOffset);
			return IWellStreamingRenderConfig.EndIWellStreamingRenderConfig(builder);
		}

		// Token: 0x0602810A RID: 164106 RVA: 0x0058207A File Offset: 0x0058027A
		public static void StartIWellStreamingRenderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602810B RID: 164107 RVA: 0x00582083 File Offset: 0x00580283
		public static void AddSelfConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderSelfConfig> selfConfigOffset)
		{
			builder.AddOffset(0, selfConfigOffset.Value, 0);
		}

		// Token: 0x0602810C RID: 164108 RVA: 0x00582093 File Offset: 0x00580293
		public static void AddAsStreamPointConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderPointConfig> asStreamPointConfigOffset)
		{
			builder.AddOffset(1, asStreamPointConfigOffset.Value, 0);
		}

		// Token: 0x0602810D RID: 164109 RVA: 0x005820A3 File Offset: 0x005802A3
		public static Offset<IWellStreamingRenderConfig> EndIWellStreamingRenderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWellStreamingRenderConfig>(builder.EndTable());
		}

		// Token: 0x0602810E RID: 164110 RVA: 0x005820B0 File Offset: 0x005802B0
		public IWellStreamingRenderConfigT UnPack()
		{
			IWellStreamingRenderConfigT wellStreamingRenderConfigT = new IWellStreamingRenderConfigT();
			this.UnPackTo(wellStreamingRenderConfigT);
			return wellStreamingRenderConfigT;
		}

		// Token: 0x0602810F RID: 164111 RVA: 0x005820CC File Offset: 0x005802CC
		public void UnPackTo(IWellStreamingRenderConfigT _o)
		{
			_o.SelfConfig = ((this.SelfConfig != null) ? this.SelfConfig.Value.UnPack() : null);
			_o.AsStreamPointConfig = ((this.AsStreamPointConfig != null) ? this.AsStreamPointConfig.Value.UnPack() : null);
		}

		// Token: 0x06028110 RID: 164112 RVA: 0x00582138 File Offset: 0x00580338
		public static Offset<IWellStreamingRenderConfig> Pack(FlatBufferBuilder builder, IWellStreamingRenderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWellStreamingRenderConfig>);
			}
			Offset<IWellStreamingRenderSelfConfig> selfConfigOffset = (_o.SelfConfig == null) ? default(Offset<IWellStreamingRenderSelfConfig>) : IWellStreamingRenderSelfConfig.Pack(builder, _o.SelfConfig);
			Offset<IWellStreamingRenderPointConfig> asStreamPointConfigOffset = (_o.AsStreamPointConfig == null) ? default(Offset<IWellStreamingRenderPointConfig>) : IWellStreamingRenderPointConfig.Pack(builder, _o.AsStreamPointConfig);
			return IWellStreamingRenderConfig.CreateIWellStreamingRenderConfig(builder, selfConfigOffset, asStreamPointConfigOffset);
		}

		// Token: 0x0400F2C6 RID: 62150
		private Table __p;
	}
}
