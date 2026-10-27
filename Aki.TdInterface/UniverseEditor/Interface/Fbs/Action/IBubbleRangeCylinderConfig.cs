using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006233 RID: 25139
	public struct IBubbleRangeCylinderConfig : IFlatbufferObject
	{
		// Token: 0x1700BB52 RID: 47954
		// (get) Token: 0x0602B55A RID: 177498 RVA: 0x005F77C4 File Offset: 0x005F59C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B55B RID: 177499 RVA: 0x005F77D1 File Offset: 0x005F59D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B55C RID: 177500 RVA: 0x005F77D8 File Offset: 0x005F59D8
		public static IBubbleRangeCylinderConfig GetRootAsIBubbleRangeCylinderConfig(ByteBuffer _bb)
		{
			return IBubbleRangeCylinderConfig.GetRootAsIBubbleRangeCylinderConfig(_bb, default(IBubbleRangeCylinderConfig));
		}

		// Token: 0x0602B55D RID: 177501 RVA: 0x005F77F4 File Offset: 0x005F59F4
		public static IBubbleRangeCylinderConfig GetRootAsIBubbleRangeCylinderConfig(ByteBuffer _bb, IBubbleRangeCylinderConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B55E RID: 177502 RVA: 0x005F7811 File Offset: 0x005F5A11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B55F RID: 177503 RVA: 0x005F7820 File Offset: 0x005F5A20
		public IBubbleRangeCylinderConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB53 RID: 47955
		// (get) Token: 0x0602B560 RID: 177504 RVA: 0x005F7830 File Offset: 0x005F5A30
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

		// Token: 0x1700BB54 RID: 47956
		// (get) Token: 0x0602B561 RID: 177505 RVA: 0x005F7890 File Offset: 0x005F5A90
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

		// Token: 0x0602B562 RID: 177506 RVA: 0x005F78ED File Offset: 0x005F5AED
		public static Offset<IBubbleRangeCylinderConfig> CreateIBubbleRangeCylinderConfig(FlatBufferBuilder builder, Offset<IBubbleCylinderConfig> InnerConfigOffset = default(Offset<IBubbleCylinderConfig>), Offset<IBubbleCylinderConfig> OuterConfigOffset = default(Offset<IBubbleCylinderConfig>))
		{
			builder.StartTable(2);
			IBubbleRangeCylinderConfig.AddOuterConfig(builder, OuterConfigOffset);
			IBubbleRangeCylinderConfig.AddInnerConfig(builder, InnerConfigOffset);
			return IBubbleRangeCylinderConfig.EndIBubbleRangeCylinderConfig(builder);
		}

		// Token: 0x0602B563 RID: 177507 RVA: 0x005F790A File Offset: 0x005F5B0A
		public static void StartIBubbleRangeCylinderConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B564 RID: 177508 RVA: 0x005F7913 File Offset: 0x005F5B13
		public static void AddInnerConfig(FlatBufferBuilder builder, Offset<IBubbleCylinderConfig> innerConfigOffset)
		{
			builder.AddOffset(0, innerConfigOffset.Value, 0);
		}

		// Token: 0x0602B565 RID: 177509 RVA: 0x005F7923 File Offset: 0x005F5B23
		public static void AddOuterConfig(FlatBufferBuilder builder, Offset<IBubbleCylinderConfig> outerConfigOffset)
		{
			builder.AddOffset(1, outerConfigOffset.Value, 0);
		}

		// Token: 0x0602B566 RID: 177510 RVA: 0x005F7933 File Offset: 0x005F5B33
		public static Offset<IBubbleRangeCylinderConfig> EndIBubbleRangeCylinderConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBubbleRangeCylinderConfig>(builder.EndTable());
		}

		// Token: 0x0602B567 RID: 177511 RVA: 0x005F7940 File Offset: 0x005F5B40
		public IBubbleRangeCylinderConfigT UnPack()
		{
			IBubbleRangeCylinderConfigT bubbleRangeCylinderConfigT = new IBubbleRangeCylinderConfigT();
			this.UnPackTo(bubbleRangeCylinderConfigT);
			return bubbleRangeCylinderConfigT;
		}

		// Token: 0x0602B568 RID: 177512 RVA: 0x005F795C File Offset: 0x005F5B5C
		public void UnPackTo(IBubbleRangeCylinderConfigT _o)
		{
			_o.InnerConfig = ((this.InnerConfig != null) ? this.InnerConfig.Value.UnPack() : null);
			_o.OuterConfig = ((this.OuterConfig != null) ? this.OuterConfig.Value.UnPack() : null);
		}

		// Token: 0x0602B569 RID: 177513 RVA: 0x005F79C8 File Offset: 0x005F5BC8
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

		// Token: 0x04010778 RID: 67448
		private Table __p;
	}
}
