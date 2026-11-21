using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011E8 RID: 4584
	public struct SolarSchoolForumPost : IFlatbufferObject
	{
		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600E156 RID: 57686 RVA: 0x00340BCA File Offset: 0x0033EDCA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E157 RID: 57687 RVA: 0x00340BD7 File Offset: 0x0033EDD7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E158 RID: 57688 RVA: 0x00340BE0 File Offset: 0x0033EDE0
		public static SolarSchoolForumPost GetRootAsSolarSchoolForumPost(ByteBuffer _bb)
		{
			return SolarSchoolForumPost.GetRootAsSolarSchoolForumPost(_bb, default(SolarSchoolForumPost));
		}

		// Token: 0x0600E159 RID: 57689 RVA: 0x00340BFC File Offset: 0x0033EDFC
		public static SolarSchoolForumPost GetRootAsSolarSchoolForumPost(ByteBuffer _bb, SolarSchoolForumPost obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E15A RID: 57690 RVA: 0x00340C19 File Offset: 0x0033EE19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E15B RID: 57691 RVA: 0x00340C28 File Offset: 0x0033EE28
		public SolarSchoolForumPost __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x00340C38 File Offset: 0x0033EE38
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

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600E15D RID: 57693 RVA: 0x00340C74 File Offset: 0x0033EE74
		public string UserName
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

		// Token: 0x0600E15E RID: 57694 RVA: 0x00340CAB File Offset: 0x0033EEAB
		public Span<byte> GetUserNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E15F RID: 57695 RVA: 0x00340CBA File Offset: 0x0033EEBA
		public byte[] GetUserNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x00340CD4 File Offset: 0x0033EED4
		public string Content
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

		// Token: 0x0600E161 RID: 57697 RVA: 0x00340D0B File Offset: 0x0033EF0B
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E162 RID: 57698 RVA: 0x00340D1A File Offset: 0x0033EF1A
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600E163 RID: 57699 RVA: 0x00340D34 File Offset: 0x0033EF34
		public string ContentImage
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

		// Token: 0x0600E164 RID: 57700 RVA: 0x00340D6C File Offset: 0x0033EF6C
		public Span<byte> GetContentImageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x00340D7C File Offset: 0x0033EF7C
		public byte[] GetContentImageArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005825 RID: 22565
		private Table __p;
	}
}
