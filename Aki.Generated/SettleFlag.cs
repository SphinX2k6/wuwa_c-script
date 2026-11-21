using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001193 RID: 4499
	public struct SettleFlag : IFlatbufferObject
	{
		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600D821 RID: 55329 RVA: 0x0032AD2D File Offset: 0x00328F2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x0032AD3A File Offset: 0x00328F3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x0032AD44 File Offset: 0x00328F44
		public static SettleFlag GetRootAsSettleFlag(ByteBuffer _bb)
		{
			return SettleFlag.GetRootAsSettleFlag(_bb, default(SettleFlag));
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x0032AD60 File Offset: 0x00328F60
		public static SettleFlag GetRootAsSettleFlag(ByteBuffer _bb, SettleFlag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x0032AD7D File Offset: 0x00328F7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D826 RID: 55334 RVA: 0x0032AD8C File Offset: 0x00328F8C
		public SettleFlag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600D827 RID: 55335 RVA: 0x0032AD9C File Offset: 0x00328F9C
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

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600D828 RID: 55336 RVA: 0x0032ADD8 File Offset: 0x00328FD8
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600D829 RID: 55337 RVA: 0x0032AE14 File Offset: 0x00329014
		public string Title
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

		// Token: 0x0600D82A RID: 55338 RVA: 0x0032AE4B File Offset: 0x0032904B
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D82B RID: 55339 RVA: 0x0032AE5A File Offset: 0x0032905A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600D82C RID: 55340 RVA: 0x0032AE74 File Offset: 0x00329074
		public string Content
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

		// Token: 0x0600D82D RID: 55341 RVA: 0x0032AEAC File Offset: 0x003290AC
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D82E RID: 55342 RVA: 0x0032AEBC File Offset: 0x003290BC
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600D82F RID: 55343 RVA: 0x0032AED4 File Offset: 0x003290D4
		public int Args
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040057A4 RID: 22436
		private Table __p;
	}
}
