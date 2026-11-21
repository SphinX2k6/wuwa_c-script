using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001198 RID: 4504
	public struct SheriffClue : IFlatbufferObject
	{
		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600D88B RID: 55435 RVA: 0x0032BC6E File Offset: 0x00329E6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D88C RID: 55436 RVA: 0x0032BC7B File Offset: 0x00329E7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D88D RID: 55437 RVA: 0x0032BC84 File Offset: 0x00329E84
		public static SheriffClue GetRootAsSheriffClue(ByteBuffer _bb)
		{
			return SheriffClue.GetRootAsSheriffClue(_bb, default(SheriffClue));
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x0032BCA0 File Offset: 0x00329EA0
		public static SheriffClue GetRootAsSheriffClue(ByteBuffer _bb, SheriffClue obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D88F RID: 55439 RVA: 0x0032BCBD File Offset: 0x00329EBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D890 RID: 55440 RVA: 0x0032BCCC File Offset: 0x00329ECC
		public SheriffClue __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600D891 RID: 55441 RVA: 0x0032BCDC File Offset: 0x00329EDC
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

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600D892 RID: 55442 RVA: 0x0032BD18 File Offset: 0x00329F18
		public int SheriffAnomalyId
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

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600D893 RID: 55443 RVA: 0x0032BD54 File Offset: 0x00329F54
		public string Name
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

		// Token: 0x0600D894 RID: 55444 RVA: 0x0032BD8B File Offset: 0x00329F8B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D895 RID: 55445 RVA: 0x0032BD9A File Offset: 0x00329F9A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600D896 RID: 55446 RVA: 0x0032BDB4 File Offset: 0x00329FB4
		public string Desc
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

		// Token: 0x0600D897 RID: 55447 RVA: 0x0032BDEC File Offset: 0x00329FEC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D898 RID: 55448 RVA: 0x0032BDFC File Offset: 0x00329FFC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600D899 RID: 55449 RVA: 0x0032BE14 File Offset: 0x0032A014
		public string Icon
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

		// Token: 0x0600D89A RID: 55450 RVA: 0x0032BE4C File Offset: 0x0032A04C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D89B RID: 55451 RVA: 0x0032BE5C File Offset: 0x0032A05C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040057AA RID: 22442
		private Table __p;
	}
}
