using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E17 RID: 3607
	public struct MonsterIconTag : IFlatbufferObject
	{
		// Token: 0x17001F76 RID: 8054
		// (get) Token: 0x0600951E RID: 38174 RVA: 0x00287B49 File Offset: 0x00285D49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600951F RID: 38175 RVA: 0x00287B56 File Offset: 0x00285D56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009520 RID: 38176 RVA: 0x00287B60 File Offset: 0x00285D60
		public static MonsterIconTag GetRootAsMonsterIconTag(ByteBuffer _bb)
		{
			return MonsterIconTag.GetRootAsMonsterIconTag(_bb, default(MonsterIconTag));
		}

		// Token: 0x06009521 RID: 38177 RVA: 0x00287B7C File Offset: 0x00285D7C
		public static MonsterIconTag GetRootAsMonsterIconTag(ByteBuffer _bb, MonsterIconTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x00287B99 File Offset: 0x00285D99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009523 RID: 38179 RVA: 0x00287BA8 File Offset: 0x00285DA8
		public MonsterIconTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06009524 RID: 38180 RVA: 0x00287BB8 File Offset: 0x00285DB8
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

		// Token: 0x06009525 RID: 38181 RVA: 0x00287BEF File Offset: 0x00285DEF
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06009526 RID: 38182 RVA: 0x00287BFE File Offset: 0x00285DFE
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06009527 RID: 38183 RVA: 0x00287C18 File Offset: 0x00285E18
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

		// Token: 0x06009528 RID: 38184 RVA: 0x00287C4F File Offset: 0x00285E4F
		public Span<byte> GetConfigParamBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009529 RID: 38185 RVA: 0x00287C5E File Offset: 0x00285E5E
		public byte[] GetConfigParamArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EBC RID: 20156
		private Table __p;
	}
}
