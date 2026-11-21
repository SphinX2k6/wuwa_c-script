using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068A4 RID: 26788
	public struct IBubbleRangeCylinderConfig : IFlatbufferObject
	{
		// Token: 0x1700C4DA RID: 50394
		// (get) Token: 0x0602DCBB RID: 187579 RVA: 0x006425CC File Offset: 0x006407CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DCBC RID: 187580 RVA: 0x006425D9 File Offset: 0x006407D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DCBD RID: 187581 RVA: 0x006425E0 File Offset: 0x006407E0
		public static IBubbleRangeCylinderConfig GetRootAsIBubbleRangeCylinderConfig(ByteBuffer _bb)
		{
			return IBubbleRangeCylinderConfig.GetRootAsIBubbleRangeCylinderConfig(_bb, default(IBubbleRangeCylinderConfig));
		}

		// Token: 0x0602DCBE RID: 187582 RVA: 0x006425FC File Offset: 0x006407FC
		public static IBubbleRangeCylinderConfig GetRootAsIBubbleRangeCylinderConfig(ByteBuffer _bb, IBubbleRangeCylinderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DCBF RID: 187583 RVA: 0x00642619 File Offset: 0x00640819
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DCC0 RID: 187584 RVA: 0x00642628 File Offset: 0x00640828
		public IBubbleRangeCylinderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C4DB RID: 50395
		// (get) Token: 0x0602DCC1 RID: 187585 RVA: 0x00642638 File Offset: 0x00640838
		public IBubbleCylinderConfig? InnerConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleCylinderConfig?(default(IBubbleCylinderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C4DC RID: 50396
		// (get) Token: 0x0602DCC2 RID: 187586 RVA: 0x00642698 File Offset: 0x00640898
		public IBubbleCylinderConfig? OuterConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IBubbleCylinderConfig?(default(IBubbleCylinderConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602DCC3 RID: 187587 RVA: 0x006426F5 File Offset: 0x006408F5
		public static Offset<IBubbleRangeCylinderConfig> CreateIBubbleRangeCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleCylinderConfig> InnerConfigOffset = default(Offset<IBubbleCylinderConfig>), Offset<IBubbleCylinderConfig> OuterConfigOffset = default(Offset<IBubbleCylinderConfig>))
		{
			builder.StartTable(2);
			IBubbleRangeCylinderConfig.AddOuterConfig(builder, OuterConfigOffset);
			IBubbleRangeCylinderConfig.AddInnerConfig(builder, InnerConfigOffset);
			return IBubbleRangeCylinderConfig.EndIBubbleRangeCylinderConfig(builder);
		}

		// Token: 0x0602DCC4 RID: 187588 RVA: 0x00642712 File Offset: 0x00640912
		public static void StartIBubbleRangeCylinderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DCC5 RID: 187589 RVA: 0x0064271B File Offset: 0x0064091B
		public static void AddInnerConfig(FlatBufferBuilder builder, Offset<IBubbleCylinderConfig> innerConfigOffset)
		{
			builder.AddOffset(0, innerConfigOffset.Value, 0);
		}

		// Token: 0x0602DCC6 RID: 187590 RVA: 0x0064272B File Offset: 0x0064092B
		public static void AddOuterConfig(FlatBufferBuilder builder, Offset<IBubbleCylinderConfig> outerConfigOffset)
		{
			builder.AddOffset(1, outerConfigOffset.Value, 0);
		}

		// Token: 0x0602DCC7 RID: 187591 RVA: 0x0064273B File Offset: 0x0064093B
		public static Offset<IBubbleRangeCylinderConfig> EndIBubbleRangeCylinderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleRangeCylinderConfig>(builder.EndTable());
		}

		// Token: 0x0602DCC8 RID: 187592 RVA: 0x00642748 File Offset: 0x00640948
		public IBubbleRangeCylinderConfigT UnPack()
		{
			IBubbleRangeCylinderConfigT bubbleRangeCylinderConfigT = new IBubbleRangeCylinderConfigT();
			this.UnPackTo(bubbleRangeCylinderConfigT);
			return bubbleRangeCylinderConfigT;
		}

		// Token: 0x0602DCC9 RID: 187593 RVA: 0x00642764 File Offset: 0x00640964
		public void UnPackTo(IBubbleRangeCylinderConfigT _o)
		{
			_o.InnerConfig = ((this.InnerConfig != null) ? this.InnerConfig.Value.UnPack() : null);
			_o.OuterConfig = ((this.OuterConfig != null) ? this.OuterConfig.Value.UnPack() : null);
		}

		// Token: 0x0602DCCA RID: 187594 RVA: 0x006427D0 File Offset: 0x006409D0
		public static Offset<IBubbleRangeCylinderConfig> Pack(FlatBufferBuilder builder, IBubbleRangeCylinderConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBubbleRangeCylinderConfig>);
			}
			Offset<IBubbleCylinderConfig> innerConfigOffset = (_o.InnerConfig == null) ? default(Offset<IBubbleCylinderConfig>) : IBubbleCylinderConfig.Pack(builder, _o.InnerConfig);
			Offset<IBubbleCylinderConfig> outerConfigOffset = (_o.OuterConfig == null) ? default(Offset<IBubbleCylinderConfig>) : IBubbleCylinderConfig.Pack(builder, _o.OuterConfig);
			return IBubbleRangeCylinderConfig.CreateIBubbleRangeCylinderConfig(builder, innerConfigOffset, outerConfigOffset);
		}

		// Token: 0x0401158D RID: 71053
		private Table __p;
	}
}
