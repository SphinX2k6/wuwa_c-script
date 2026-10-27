using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001178 RID: 4472
	public struct TrialPhantomPropItem : IFlatbufferObject
	{
		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600E563 RID: 58723 RVA: 0x0033CA0D File Offset: 0x0033AC0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E564 RID: 58724 RVA: 0x0033CA1A File Offset: 0x0033AC1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E565 RID: 58725 RVA: 0x0033CA24 File Offset: 0x0033AC24
		public static TrialPhantomPropItem GetRootAsTrialPhantomPropItem(ByteBuffer _bb)
		{
			return TrialPhantomPropItem.GetRootAsTrialPhantomPropItem(_bb, default(TrialPhantomPropItem));
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x0033CA40 File Offset: 0x0033AC40
		public static TrialPhantomPropItem GetRootAsTrialPhantomPropItem(ByteBuffer _bb, TrialPhantomPropItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E567 RID: 58727 RVA: 0x0033CA5D File Offset: 0x0033AC5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E568 RID: 58728 RVA: 0x0033CA6C File Offset: 0x0033AC6C
		public TrialPhantomPropItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600E569 RID: 58729 RVA: 0x0033CA7C File Offset: 0x0033AC7C
		public int Id
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

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600E56A RID: 58730 RVA: 0x0033CAB8 File Offset: 0x0033ACB8
		public ConfigPropValue? Prop
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x040052BE RID: 21182
		private Table __p;
	}
}
