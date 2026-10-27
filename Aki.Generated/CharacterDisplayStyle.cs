using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B65 RID: 2917
	public struct CharacterDisplayStyle : IFlatbufferObject
	{
		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x001F0486 File Offset: 0x001EE686
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x001F0493 File Offset: 0x001EE693
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x001F049C File Offset: 0x001EE69C
		public static CharacterDisplayStyle GetRootAsCharacterDisplayStyle(ByteBuffer _bb)
		{
			return CharacterDisplayStyle.GetRootAsCharacterDisplayStyle(_bb, default(CharacterDisplayStyle));
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x001F04B8 File Offset: 0x001EE6B8
		public static CharacterDisplayStyle GetRootAsCharacterDisplayStyle(ByteBuffer _bb, CharacterDisplayStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x001F04D5 File Offset: 0x001EE6D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x001F04E4 File Offset: 0x001EE6E4
		public CharacterDisplayStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x060052CE RID: 21198 RVA: 0x001F04F4 File Offset: 0x001EE6F4
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

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060052CF RID: 21199 RVA: 0x001F0530 File Offset: 0x001EE730
		public string IllustrationAsset
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

		// Token: 0x060052D0 RID: 21200 RVA: 0x001F0567 File Offset: 0x001EE767
		public Span<byte> GetIllustrationAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x001F0576 File Offset: 0x001EE776
		public byte[] GetIllustrationAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060052D2 RID: 21202 RVA: 0x001F0590 File Offset: 0x001EE790
		public string CharacterName
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

		// Token: 0x060052D3 RID: 21203 RVA: 0x001F05C7 File Offset: 0x001EE7C7
		public Span<byte> GetCharacterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x001F05D6 File Offset: 0x001EE7D6
		public byte[] GetCharacterNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060052D5 RID: 21205 RVA: 0x001F05F0 File Offset: 0x001EE7F0
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

		// Token: 0x060052D6 RID: 21206 RVA: 0x001F0628 File Offset: 0x001EE828
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x001F0638 File Offset: 0x001EE838
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B67 RID: 19303
		private Table __p;
	}
}
