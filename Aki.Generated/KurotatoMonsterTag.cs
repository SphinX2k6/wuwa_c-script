using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E91 RID: 3729
	public struct KurotatoMonsterTag : IFlatbufferObject
	{
		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06009110 RID: 37136 RVA: 0x0028F904 File Offset: 0x0028DB04
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009111 RID: 37137 RVA: 0x0028F911 File Offset: 0x0028DB11
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x0028F918 File Offset: 0x0028DB18
		public static KurotatoMonsterTag GetRootAsKurotatoMonsterTag(ByteBuffer _bb)
		{
			return KurotatoMonsterTag.GetRootAsKurotatoMonsterTag(_bb, default(KurotatoMonsterTag));
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x0028F934 File Offset: 0x0028DB34
		public static KurotatoMonsterTag GetRootAsKurotatoMonsterTag(ByteBuffer _bb, KurotatoMonsterTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x0028F951 File Offset: 0x0028DB51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x0028F960 File Offset: 0x0028DB60
		public KurotatoMonsterTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06009116 RID: 37142 RVA: 0x0028F970 File Offset: 0x0028DB70
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

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x0028F9AC File Offset: 0x0028DBAC
		public string Icon
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

		// Token: 0x06009118 RID: 37144 RVA: 0x0028F9E3 File Offset: 0x0028DBE3
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009119 RID: 37145 RVA: 0x0028F9F2 File Offset: 0x0028DBF2
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x0028FA0C File Offset: 0x0028DC0C
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

		// Token: 0x0600911B RID: 37147 RVA: 0x0028FA43 File Offset: 0x0028DC43
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x0028FA52 File Offset: 0x0028DC52
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x0028FA6C File Offset: 0x0028DC6C
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

		// Token: 0x0600911E RID: 37150 RVA: 0x0028FAA4 File Offset: 0x0028DCA4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x0028FAB4 File Offset: 0x0028DCB4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005423 RID: 21539
		private Table __p;
	}
}
