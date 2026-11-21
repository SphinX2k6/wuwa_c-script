using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EFC RID: 3836
	public struct MonsterIconTag : IFlatbufferObject
	{
		// Token: 0x17001FDB RID: 8155
		// (get) Token: 0x06009B3E RID: 39742 RVA: 0x002A5911 File Offset: 0x002A3B11
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x002A591E File Offset: 0x002A3B1E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x002A5928 File Offset: 0x002A3B28
		public static MonsterIconTag GetRootAsMonsterIconTag(ByteBuffer _bb)
		{
			return MonsterIconTag.GetRootAsMonsterIconTag(_bb, default(MonsterIconTag));
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x002A5944 File Offset: 0x002A3B44
		public static MonsterIconTag GetRootAsMonsterIconTag(ByteBuffer _bb, MonsterIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x002A5961 File Offset: 0x002A3B61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x002A5970 File Offset: 0x002A3B70
		public MonsterIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FDC RID: 8156
		// (get) Token: 0x06009B44 RID: 39748 RVA: 0x002A5980 File Offset: 0x002A3B80
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x002A59B7 File Offset: 0x002A3BB7
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x002A59C6 File Offset: 0x002A3BC6
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001FDD RID: 8157
		// (get) Token: 0x06009B47 RID: 39751 RVA: 0x002A59E0 File Offset: 0x002A3BE0
		public string ConfigParam
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

		// Token: 0x06009B48 RID: 39752 RVA: 0x002A5A17 File Offset: 0x002A3C17
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x002A5A26 File Offset: 0x002A3C26
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040054A1 RID: 21665
		private Table __p;
	}
}
