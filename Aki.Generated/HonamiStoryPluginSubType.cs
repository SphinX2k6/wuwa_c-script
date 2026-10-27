using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D45 RID: 3397
	public struct HonamiStoryPluginSubType : IFlatbufferObject
	{
		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x060080C3 RID: 32963 RVA: 0x00259398 File Offset: 0x00257598
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x002593A5 File Offset: 0x002575A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x002593AC File Offset: 0x002575AC
		public static HonamiStoryPluginSubType GetRootAsHonamiStoryPluginSubType(ByteBuffer _bb)
		{
			return HonamiStoryPluginSubType.GetRootAsHonamiStoryPluginSubType(_bb, default(HonamiStoryPluginSubType));
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x002593C8 File Offset: 0x002575C8
		public static HonamiStoryPluginSubType GetRootAsHonamiStoryPluginSubType(ByteBuffer _bb, HonamiStoryPluginSubType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x002593E5 File Offset: 0x002575E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x002593F4 File Offset: 0x002575F4
		public HonamiStoryPluginSubType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x060080C9 RID: 32969 RVA: 0x00259404 File Offset: 0x00257604
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

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x060080CA RID: 32970 RVA: 0x00259440 File Offset: 0x00257640
		public string Name
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

		// Token: 0x060080CB RID: 32971 RVA: 0x00259477 File Offset: 0x00257677
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x00259486 File Offset: 0x00257686
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x060080CD RID: 32973 RVA: 0x002594A0 File Offset: 0x002576A0
		public string ActiveSpritePath
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

		// Token: 0x060080CE RID: 32974 RVA: 0x002594D7 File Offset: 0x002576D7
		public Span<byte> GetActiveSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x002594E6 File Offset: 0x002576E6
		public byte[] GetActiveSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x060080D0 RID: 32976 RVA: 0x00259500 File Offset: 0x00257700
		public string ActiveOneSpritePath
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

		// Token: 0x060080D1 RID: 32977 RVA: 0x00259538 File Offset: 0x00257738
		public Span<byte> GetActiveOneSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x00259548 File Offset: 0x00257748
		public byte[] GetActiveOneSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x060080D3 RID: 32979 RVA: 0x00259560 File Offset: 0x00257760
		public string ActiveAllSpritePath
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

		// Token: 0x060080D4 RID: 32980 RVA: 0x00259598 File Offset: 0x00257798
		public Span<byte> GetActiveAllSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x002595A8 File Offset: 0x002577A8
		public byte[] GetActiveAllSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004DC1 RID: 19905
		private Table __p;
	}
}
