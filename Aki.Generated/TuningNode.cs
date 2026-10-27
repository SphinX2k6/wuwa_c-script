using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200117B RID: 4475
	public struct TuningNode : IFlatbufferObject
	{
		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x0600E59B RID: 58779 RVA: 0x0033D319 File Offset: 0x0033B519
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E59C RID: 58780 RVA: 0x0033D326 File Offset: 0x0033B526
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E59D RID: 58781 RVA: 0x0033D330 File Offset: 0x0033B530
		public static TuningNode GetRootAsTuningNode(ByteBuffer _bb)
		{
			return TuningNode.GetRootAsTuningNode(_bb, default(TuningNode));
		}

		// Token: 0x0600E59E RID: 58782 RVA: 0x0033D34C File Offset: 0x0033B54C
		public static TuningNode GetRootAsTuningNode(ByteBuffer _bb, TuningNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E59F RID: 58783 RVA: 0x0033D369 File Offset: 0x0033B569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E5A0 RID: 58784 RVA: 0x0033D378 File Offset: 0x0033B578
		public TuningNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x0600E5A1 RID: 58785 RVA: 0x0033D388 File Offset: 0x0033B588
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

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600E5A2 RID: 58786 RVA: 0x0033D3C4 File Offset: 0x0033B5C4
		public string Desc
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

		// Token: 0x0600E5A3 RID: 58787 RVA: 0x0033D3FB File Offset: 0x0033B5FB
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E5A4 RID: 58788 RVA: 0x0033D40A File Offset: 0x0033B60A
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600E5A5 RID: 58789 RVA: 0x0033D424 File Offset: 0x0033B624
		public string AkEvent
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

		// Token: 0x0600E5A6 RID: 58790 RVA: 0x0033D45B File Offset: 0x0033B65B
		public Span<byte> GetAkEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E5A7 RID: 58791 RVA: 0x0033D46A File Offset: 0x0033B66A
		public byte[] GetAkEventArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052C1 RID: 21185
		private Table __p;
	}
}
