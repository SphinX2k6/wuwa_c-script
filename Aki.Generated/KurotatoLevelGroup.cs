using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA4 RID: 3492
	public struct KurotatoLevelGroup : IFlatbufferObject
	{
		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x0026FA95 File Offset: 0x0026DC95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A54 RID: 35412 RVA: 0x0026FAA2 File Offset: 0x0026DCA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A55 RID: 35413 RVA: 0x0026FAAC File Offset: 0x0026DCAC
		public static KurotatoLevelGroup GetRootAsKurotatoLevelGroup(ByteBuffer _bb)
		{
			return KurotatoLevelGroup.GetRootAsKurotatoLevelGroup(_bb, default(KurotatoLevelGroup));
		}

		// Token: 0x06008A56 RID: 35414 RVA: 0x0026FAC8 File Offset: 0x0026DCC8
		public static KurotatoLevelGroup GetRootAsKurotatoLevelGroup(ByteBuffer _bb, KurotatoLevelGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A57 RID: 35415 RVA: 0x0026FAE5 File Offset: 0x0026DCE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A58 RID: 35416 RVA: 0x0026FAF4 File Offset: 0x0026DCF4
		public KurotatoLevelGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06008A59 RID: 35417 RVA: 0x0026FB04 File Offset: 0x0026DD04
		public int GroupId
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

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06008A5A RID: 35418 RVA: 0x0026FB40 File Offset: 0x0026DD40
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

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06008A5B RID: 35419 RVA: 0x0026FB7C File Offset: 0x0026DD7C
		public int PerId
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

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06008A5C RID: 35420 RVA: 0x0026FBB8 File Offset: 0x0026DDB8
		public int LevelId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x0026FBF8 File Offset: 0x0026DDF8
		public string Name
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

		// Token: 0x06008A5E RID: 35422 RVA: 0x0026FC30 File Offset: 0x0026DE30
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x0026FC40 File Offset: 0x0026DE40
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06008A60 RID: 35424 RVA: 0x0026FC58 File Offset: 0x0026DE58
		public string TitleBg
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008A61 RID: 35425 RVA: 0x0026FC90 File Offset: 0x0026DE90
		public Span<byte> GetTitleBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008A62 RID: 35426 RVA: 0x0026FCA0 File Offset: 0x0026DEA0
		public byte[] GetTitleBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06008A63 RID: 35427 RVA: 0x0026FCB8 File Offset: 0x0026DEB8
		public int DifficultyGroup(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06008A64 RID: 35428 RVA: 0x0026FCF8 File Offset: 0x0026DEF8
		public int DifficultyGroupLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x0026FD24 File Offset: 0x0026DF24
		public Span<int> GetDifficultyGroupBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x0026FD34 File Offset: 0x0026DF34
		public int[] GetDifficultyGroupArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06008A67 RID: 35431 RVA: 0x0026FD4C File Offset: 0x0026DF4C
		public int SecondGroup(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06008A68 RID: 35432 RVA: 0x0026FD8C File Offset: 0x0026DF8C
		public int SecondGroupLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008A69 RID: 35433 RVA: 0x0026FDB8 File Offset: 0x0026DFB8
		public Span<int> GetSecondGroupBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06008A6A RID: 35434 RVA: 0x0026FDC8 File Offset: 0x0026DFC8
		public int[] GetSecondGroupArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x06008A6B RID: 35435 RVA: 0x0026FDE0 File Offset: 0x0026DFE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DifficultyGroupIter()或GetDifficultyGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DifficultyGroup()
		{
			KurotatoLevelGroup kurotatoLevelGroup = this;
			return kurotatoLevelGroup.GetDifficultyGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A6C RID: 35436 RVA: 0x0026FE04 File Offset: 0x0026E004
		[NullableContext(1)]
		public readonly IEnumerable<int> DifficultyGroupIter()
		{
			KurotatoLevelGroup.<DifficultyGroupIter>d__35 <DifficultyGroupIter>d__ = new KurotatoLevelGroup.<DifficultyGroupIter>d__35(-2);
			<DifficultyGroupIter>d__.<>3__<>4__this = this;
			return <DifficultyGroupIter>d__;
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x0026FE1C File Offset: 0x0026E01C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SecondGroupIter()或GetSecondGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SecondGroup()
		{
			KurotatoLevelGroup kurotatoLevelGroup = this;
			return kurotatoLevelGroup.GetSecondGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0026FE40 File Offset: 0x0026E040
		[NullableContext(1)]
		public readonly IEnumerable<int> SecondGroupIter()
		{
			KurotatoLevelGroup.<SecondGroupIter>d__37 <SecondGroupIter>d__ = new KurotatoLevelGroup.<SecondGroupIter>d__37(-2);
			<SecondGroupIter>d__.<>3__<>4__this = this;
			return <SecondGroupIter>d__;
		}

		// Token: 0x04004E35 RID: 20021
		private Table __p;
	}
}
