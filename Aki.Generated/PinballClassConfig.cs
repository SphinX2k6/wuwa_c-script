using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F25 RID: 3877
	public struct PinballClassConfig : IFlatbufferObject
	{
		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x0600AE62 RID: 44642 RVA: 0x002C078D File Offset: 0x002BE98D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AE63 RID: 44643 RVA: 0x002C079A File Offset: 0x002BE99A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AE64 RID: 44644 RVA: 0x002C07A4 File Offset: 0x002BE9A4
		public static PinballClassConfig GetRootAsPinballClassConfig(ByteBuffer _bb)
		{
			return PinballClassConfig.GetRootAsPinballClassConfig(_bb, default(PinballClassConfig));
		}

		// Token: 0x0600AE65 RID: 44645 RVA: 0x002C07C0 File Offset: 0x002BE9C0
		public static PinballClassConfig GetRootAsPinballClassConfig(ByteBuffer _bb, PinballClassConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AE66 RID: 44646 RVA: 0x002C07DD File Offset: 0x002BE9DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AE67 RID: 44647 RVA: 0x002C07EC File Offset: 0x002BE9EC
		public PinballClassConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600AE68 RID: 44648 RVA: 0x002C07FC File Offset: 0x002BE9FC
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

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600AE69 RID: 44649 RVA: 0x002C0838 File Offset: 0x002BEA38
		public string PinballClassName
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE6A RID: 44650 RVA: 0x002C086F File Offset: 0x002BEA6F
		public Span<byte> GetPinballClassNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600AE6B RID: 44651 RVA: 0x002C087E File Offset: 0x002BEA7E
		public byte[] GetPinballClassNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600AE6C RID: 44652 RVA: 0x002C0898 File Offset: 0x002BEA98
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE6D RID: 44653 RVA: 0x002C08CF File Offset: 0x002BEACF
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600AE6E RID: 44654 RVA: 0x002C08DE File Offset: 0x002BEADE
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600AE6F RID: 44655 RVA: 0x002C08F8 File Offset: 0x002BEAF8
		public string BigIcon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE70 RID: 44656 RVA: 0x002C0930 File Offset: 0x002BEB30
		public Span<byte> GetBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600AE71 RID: 44657 RVA: 0x002C0940 File Offset: 0x002BEB40
		public byte[] GetBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002917 RID: 10519
		// (get) Token: 0x0600AE72 RID: 44658 RVA: 0x002C0958 File Offset: 0x002BEB58
		public string HoverBigIcon
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE73 RID: 44659 RVA: 0x002C0990 File Offset: 0x002BEB90
		public Span<byte> GetHoverBigIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600AE74 RID: 44660 RVA: 0x002C09A0 File Offset: 0x002BEBA0
		public byte[] GetHoverBigIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002918 RID: 10520
		// (get) Token: 0x0600AE75 RID: 44661 RVA: 0x002C09B8 File Offset: 0x002BEBB8
		public string BgColor
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600AE76 RID: 44662 RVA: 0x002C09F0 File Offset: 0x002BEBF0
		public Span<byte> GetBgColorBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600AE77 RID: 44663 RVA: 0x002C0A00 File Offset: 0x002BEC00
		public byte[] GetBgColorArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FEE RID: 20462
		private Table __p;
	}
}
