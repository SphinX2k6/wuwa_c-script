using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EE5 RID: 3813
	public struct MatchThreeLevel : IFlatbufferObject
	{
		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06009905 RID: 39173 RVA: 0x002A09DD File Offset: 0x0029EBDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x002A09EA File Offset: 0x0029EBEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x002A09F4 File Offset: 0x0029EBF4
		public static MatchThreeLevel GetRootAsMatchThreeLevel(ByteBuffer _bb)
		{
			return MatchThreeLevel.GetRootAsMatchThreeLevel(_bb, default(MatchThreeLevel));
		}

		// Token: 0x06009908 RID: 39176 RVA: 0x002A0A10 File Offset: 0x0029EC10
		public static MatchThreeLevel GetRootAsMatchThreeLevel(ByteBuffer _bb, MatchThreeLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x002A0A2D File Offset: 0x0029EC2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x002A0A3C File Offset: 0x0029EC3C
		public MatchThreeLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600990B RID: 39179 RVA: 0x002A0A4C File Offset: 0x0029EC4C
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

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600990C RID: 39180 RVA: 0x002A0A88 File Offset: 0x0029EC88
		public int ActivityId
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

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600990D RID: 39181 RVA: 0x002A0AC4 File Offset: 0x0029ECC4
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

		// Token: 0x0600990E RID: 39182 RVA: 0x002A0AFB File Offset: 0x0029ECFB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x002A0B0A File Offset: 0x0029ED0A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06009910 RID: 39184 RVA: 0x002A0B24 File Offset: 0x0029ED24
		public string Description
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

		// Token: 0x06009911 RID: 39185 RVA: 0x002A0B5C File Offset: 0x0029ED5C
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x002A0B6C File Offset: 0x0029ED6C
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06009913 RID: 39187 RVA: 0x002A0B84 File Offset: 0x0029ED84
		public int Chapter
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06009914 RID: 39188 RVA: 0x002A0BC4 File Offset: 0x0029EDC4
		public int PreChapter
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06009915 RID: 39189 RVA: 0x002A0C04 File Offset: 0x0029EE04
		public int UnLockDay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06009916 RID: 39190 RVA: 0x002A0C44 File Offset: 0x0029EE44
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06009917 RID: 39191 RVA: 0x002A0C84 File Offset: 0x0029EE84
		public bool EndLess
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06009918 RID: 39192 RVA: 0x002A0CC4 File Offset: 0x0029EEC4
		public int RewardDrop
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06009919 RID: 39193 RVA: 0x002A0D04 File Offset: 0x0029EF04
		public int DefaultRole
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005486 RID: 21638
		private Table __p;
	}
}
