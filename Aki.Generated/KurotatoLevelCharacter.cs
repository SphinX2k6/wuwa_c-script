using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA3 RID: 3491
	public struct KurotatoLevelCharacter : IFlatbufferObject
	{
		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x06008A3E RID: 35390 RVA: 0x0026F7D5 File Offset: 0x0026D9D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x0026F7E2 File Offset: 0x0026D9E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x0026F7EC File Offset: 0x0026D9EC
		public static KurotatoLevelCharacter GetRootAsKurotatoLevelCharacter(ByteBuffer _bb)
		{
			return KurotatoLevelCharacter.GetRootAsKurotatoLevelCharacter(_bb, default(KurotatoLevelCharacter));
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x0026F808 File Offset: 0x0026DA08
		public static KurotatoLevelCharacter GetRootAsKurotatoLevelCharacter(ByteBuffer _bb, KurotatoLevelCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x0026F825 File Offset: 0x0026DA25
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x0026F834 File Offset: 0x0026DA34
		public KurotatoLevelCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BAE RID: 7086
		// (get) Token: 0x06008A44 RID: 35396 RVA: 0x0026F844 File Offset: 0x0026DA44
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

		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x0026F880 File Offset: 0x0026DA80
		public int CharacterId
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

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06008A46 RID: 35398 RVA: 0x0026F8BC File Offset: 0x0026DABC
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A47 RID: 35399 RVA: 0x0026F8F8 File Offset: 0x0026DAF8
		public int InitItemIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06008A48 RID: 35400 RVA: 0x0026F938 File Offset: 0x0026DB38
		public int InitItemIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A49 RID: 35401 RVA: 0x0026F964 File Offset: 0x0026DB64
		public Span<int> GetInitItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x0026F974 File Offset: 0x0026DB74
		public int[] GetInitItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x0026F98C File Offset: 0x0026DB8C
		public int InitWeaponIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06008A4C RID: 35404 RVA: 0x0026F9CC File Offset: 0x0026DBCC
		public int InitWeaponIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A4D RID: 35405 RVA: 0x0026F9F8 File Offset: 0x0026DBF8
		public Span<int> GetInitWeaponIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008A4E RID: 35406 RVA: 0x0026FA08 File Offset: 0x0026DC08
		public int[] GetInitWeaponIdsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x06008A4F RID: 35407 RVA: 0x0026FA20 File Offset: 0x0026DC20
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitItemIdsIter()或GetInitItemIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitItemIds()
		{
			KurotatoLevelCharacter kurotatoLevelCharacter = this;
			return kurotatoLevelCharacter.GetInitItemIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A50 RID: 35408 RVA: 0x0026FA44 File Offset: 0x0026DC44
		[NullableContext(1)]
		public readonly IEnumerable<int> InitItemIdsIter()
		{
			KurotatoLevelCharacter.<InitItemIdsIter>d__25 <InitItemIdsIter>d__ = new KurotatoLevelCharacter.<InitItemIdsIter>d__25(-2);
			<InitItemIdsIter>d__.<>3__<>4__this = this;
			return <InitItemIdsIter>d__;
		}

		// Token: 0x06008A51 RID: 35409 RVA: 0x0026FA5C File Offset: 0x0026DC5C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InitWeaponIdsIter()或GetInitWeaponIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] InitWeaponIds()
		{
			KurotatoLevelCharacter kurotatoLevelCharacter = this;
			return kurotatoLevelCharacter.GetInitWeaponIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A52 RID: 35410 RVA: 0x0026FA80 File Offset: 0x0026DC80
		[NullableContext(1)]
		public readonly IEnumerable<int> InitWeaponIdsIter()
		{
			KurotatoLevelCharacter.<InitWeaponIdsIter>d__27 <InitWeaponIdsIter>d__ = new KurotatoLevelCharacter.<InitWeaponIdsIter>d__27(-2);
			<InitWeaponIdsIter>d__.<>3__<>4__this = this;
			return <InitWeaponIdsIter>d__;
		}

		// Token: 0x04004E34 RID: 20020
		private Table __p;
	}
}
