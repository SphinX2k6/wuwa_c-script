using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C45 RID: 3141
	public struct CharacterDisplayStyle : IFlatbufferObject
	{
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600588A RID: 22666 RVA: 0x00210216 File Offset: 0x0020E416
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x00210223 File Offset: 0x0020E423
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x0021022C File Offset: 0x0020E42C
		public static CharacterDisplayStyle GetRootAsCharacterDisplayStyle(ByteBuffer _bb)
		{
			return CharacterDisplayStyle.GetRootAsCharacterDisplayStyle(_bb, default(CharacterDisplayStyle));
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x00210248 File Offset: 0x0020E448
		public static CharacterDisplayStyle GetRootAsCharacterDisplayStyle(ByteBuffer _bb, CharacterDisplayStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x00210265 File Offset: 0x0020E465
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x00210274 File Offset: 0x0020E474
		public CharacterDisplayStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06005890 RID: 22672 RVA: 0x00210284 File Offset: 0x0020E484
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

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06005891 RID: 22673 RVA: 0x002102C0 File Offset: 0x0020E4C0
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

		// Token: 0x06005892 RID: 22674 RVA: 0x002102F7 File Offset: 0x0020E4F7
		public Span<byte> GetIllustrationAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x00210306 File Offset: 0x0020E506
		public byte[] GetIllustrationAssetArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x00210320 File Offset: 0x0020E520
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

		// Token: 0x06005895 RID: 22677 RVA: 0x00210357 File Offset: 0x0020E557
		public Span<byte> GetCharacterNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00210366 File Offset: 0x0020E566
		public byte[] GetCharacterNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x00210380 File Offset: 0x0020E580
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

		// Token: 0x06005898 RID: 22680 RVA: 0x002103B8 File Offset: 0x0020E5B8
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x002103C8 File Offset: 0x0020E5C8
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005147 RID: 20807
		private Table __p;
	}
}
