using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006187 RID: 24967
	public struct IWellStreamingRenderConfig : IFlatbufferObject
	{
		// Token: 0x1700BA2C RID: 47660
		// (get) Token: 0x0602A6C5 RID: 173765 RVA: 0x005C99C2 File Offset: 0x005C7BC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A6C6 RID: 173766 RVA: 0x005C99CF File Offset: 0x005C7BCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A6C7 RID: 173767 RVA: 0x005C99D8 File Offset: 0x005C7BD8
		public static IWellStreamingRenderConfig GetRootAsIWellStreamingRenderConfig(ByteBuffer _bb)
		{
			return IWellStreamingRenderConfig.GetRootAsIWellStreamingRenderConfig(_bb, default(IWellStreamingRenderConfig));
		}

		// Token: 0x0602A6C8 RID: 173768 RVA: 0x005C99F4 File Offset: 0x005C7BF4
		public static IWellStreamingRenderConfig GetRootAsIWellStreamingRenderConfig(ByteBuffer _bb, IWellStreamingRenderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A6C9 RID: 173769 RVA: 0x005C9A11 File Offset: 0x005C7C11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A6CA RID: 173770 RVA: 0x005C9A20 File Offset: 0x005C7C20
		public IWellStreamingRenderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA2D RID: 47661
		// (get) Token: 0x0602A6CB RID: 173771 RVA: 0x005C9A30 File Offset: 0x005C7C30
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

		// Token: 0x1700BA2E RID: 47662
		// (get) Token: 0x0602A6CC RID: 173772 RVA: 0x005C9A90 File Offset: 0x005C7C90
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

		// Token: 0x0602A6CD RID: 173773 RVA: 0x005C9AED File Offset: 0x005C7CED
		public static Offset<IWellStreamingRenderConfig> CreateIWellStreamingRenderConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderSelfConfig> SelfConfigOffset = default(Offset<IWellStreamingRenderSelfConfig>), Offset<IWellStreamingRenderPointConfig> AsStreamPointConfigOffset = default(Offset<IWellStreamingRenderPointConfig>))
		{
			builder.StartTable(2);
			IWellStreamingRenderConfig.AddAsStreamPointConfig(builder, AsStreamPointConfigOffset);
			IWellStreamingRenderConfig.AddSelfConfig(builder, SelfConfigOffset);
			return IWellStreamingRenderConfig.EndIWellStreamingRenderConfig(builder);
		}

		// Token: 0x0602A6CE RID: 173774 RVA: 0x005C9B0A File Offset: 0x005C7D0A
		public static void StartIWellStreamingRenderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602A6CF RID: 173775 RVA: 0x005C9B13 File Offset: 0x005C7D13
		public static void AddSelfConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderSelfConfig> selfConfigOffset)
		{
			builder.AddOffset(0, selfConfigOffset.Value, 0);
		}

		// Token: 0x0602A6D0 RID: 173776 RVA: 0x005C9B23 File Offset: 0x005C7D23
		public static void AddAsStreamPointConfig(FlatBufferBuilder builder, Offset<IWellStreamingRenderPointConfig> asStreamPointConfigOffset)
		{
			builder.AddOffset(1, asStreamPointConfigOffset.Value, 0);
		}

		// Token: 0x0602A6D1 RID: 173777 RVA: 0x005C9B33 File Offset: 0x005C7D33
		public static Offset<IWellStreamingRenderConfig> EndIWellStreamingRenderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWellStreamingRenderConfig>(builder.EndTable());
		}

		// Token: 0x0602A6D2 RID: 173778 RVA: 0x005C9B40 File Offset: 0x005C7D40
		public IWellStreamingRenderConfigT UnPack()
		{
			IWellStreamingRenderConfigT wellStreamingRenderConfigT = new IWellStreamingRenderConfigT();
			this.UnPackTo(wellStreamingRenderConfigT);
			return wellStreamingRenderConfigT;
		}

		// Token: 0x0602A6D3 RID: 173779 RVA: 0x005C9B5C File Offset: 0x005C7D5C
		public void UnPackTo(IWellStreamingRenderConfigT _o)
		{
			_o.SelfConfig = ((this.SelfConfig != null) ? this.SelfConfig.Value.UnPack() : null);
			_o.AsStreamPointConfig = ((this.AsStreamPointConfig != null) ? this.AsStreamPointConfig.Value.UnPack() : null);
		}

		// Token: 0x0602A6D4 RID: 173780 RVA: 0x005C9BC8 File Offset: 0x005C7DC8
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

		// Token: 0x0400FFCC RID: 65484
		private Table __p;
	}
}
