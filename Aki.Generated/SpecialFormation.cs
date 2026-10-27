using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DF RID: 4319
	public struct SpecialFormation : IFlatbufferObject
	{
		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x0031DD38 File Offset: 0x0031BF38
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x0031DD45 File Offset: 0x0031BF45
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D7D5 RID: 55253 RVA: 0x0031DD4C File Offset: 0x0031BF4C
		public static SpecialFormation GetRootAsSpecialFormation(ByteBuffer _bb)
		{
			return SpecialFormation.GetRootAsSpecialFormation(_bb, default(SpecialFormation));
		}

		// Token: 0x0600D7D6 RID: 55254 RVA: 0x0031DD68 File Offset: 0x0031BF68
		public static SpecialFormation GetRootAsSpecialFormation(ByteBuffer _bb, SpecialFormation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x0031DD85 File Offset: 0x0031BF85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x0031DD94 File Offset: 0x0031BF94
		public SpecialFormation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600D7D9 RID: 55257 RVA: 0x0031DDA4 File Offset: 0x0031BFA4
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

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x0031DDE0 File Offset: 0x0031BFE0
		public int Type
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

		// Token: 0x0600D7DB RID: 55259 RVA: 0x0031DE1C File Offset: 0x0031C01C
		public int CharacterId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x0031DE5C File Offset: 0x0031C05C
		public int CharacterIdLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x0031DE87 File Offset: 0x0031C087
		public Span<int> GetCharacterIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D7DE RID: 55262 RVA: 0x0031DE96 File Offset: 0x0031C096
		public int[] GetCharacterIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600D7DF RID: 55263 RVA: 0x0031DEB0 File Offset: 0x0031C0B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CharacterIdIter()或GetCharacterIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CharacterId()
		{
			SpecialFormation specialFormation = this;
			return specialFormation.GetCharacterIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D7E0 RID: 55264 RVA: 0x0031DED4 File Offset: 0x0031C0D4
		[NullableContext(1)]
		public readonly IEnumerable<int> CharacterIdIter()
		{
			SpecialFormation.<CharacterIdIter>d__18 <CharacterIdIter>d__ = new SpecialFormation.<CharacterIdIter>d__18(-2);
			<CharacterIdIter>d__.<>3__<>4__this = this;
			return <CharacterIdIter>d__;
		}

		// Token: 0x04005212 RID: 21010
		private Table __p;
	}
}
