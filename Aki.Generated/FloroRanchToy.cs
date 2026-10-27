using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CBC RID: 3260
	public struct FloroRanchToy : IFlatbufferObject
	{
		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x060074F9 RID: 29945 RVA: 0x0023EFD8 File Offset: 0x0023D1D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x0023EFE5 File Offset: 0x0023D1E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x0023EFEC File Offset: 0x0023D1EC
		public static FloroRanchToy GetRootAsFloroRanchToy(ByteBuffer _bb)
		{
			return FloroRanchToy.GetRootAsFloroRanchToy(_bb, default(FloroRanchToy));
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x0023F008 File Offset: 0x0023D208
		public static FloroRanchToy GetRootAsFloroRanchToy(ByteBuffer _bb, FloroRanchToy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x0023F025 File Offset: 0x0023D225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x0023F034 File Offset: 0x0023D234
		public FloroRanchToy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x0023F044 File Offset: 0x0023D244
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

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x06007500 RID: 29952 RVA: 0x0023F080 File Offset: 0x0023D280
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

		// Token: 0x06007501 RID: 29953 RVA: 0x0023F0BC File Offset: 0x0023D2BC
		public int Race(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06007502 RID: 29954 RVA: 0x0023F0FC File Offset: 0x0023D2FC
		public int RaceLength
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

		// Token: 0x06007503 RID: 29955 RVA: 0x0023F127 File Offset: 0x0023D327
		public Span<int> GetRaceBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x0023F136 File Offset: 0x0023D336
		public int[] GetRaceArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x0023F150 File Offset: 0x0023D350
		public string Name
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

		// Token: 0x06007506 RID: 29958 RVA: 0x0023F188 File Offset: 0x0023D388
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x0023F198 File Offset: 0x0023D398
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06007508 RID: 29960 RVA: 0x0023F1B0 File Offset: 0x0023D3B0
		public int RarityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x0023F1F0 File Offset: 0x0023D3F0
		public int Tag
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x0600750A RID: 29962 RVA: 0x0023F230 File Offset: 0x0023D430
		public bool EuicklyEffectTag
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600750B RID: 29963 RVA: 0x0023F270 File Offset: 0x0023D470
		public int Price
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600750C RID: 29964 RVA: 0x0023F2B0 File Offset: 0x0023D4B0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x0023F2E8 File Offset: 0x0023D4E8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x0023F2F8 File Offset: 0x0023D4F8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x0023F310 File Offset: 0x0023D510
		public int Remove
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06007510 RID: 29968 RVA: 0x0023F350 File Offset: 0x0023D550
		public bool Unique
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x0023F390 File Offset: 0x0023D590
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x0023F3C8 File Offset: 0x0023D5C8
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x0023F3D8 File Offset: 0x0023D5D8
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06007514 RID: 29972 RVA: 0x0023F3F0 File Offset: 0x0023D5F0
		public int Level
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x0023F430 File Offset: 0x0023D630
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RaceIter()或GetRaceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Race()
		{
			FloroRanchToy floroRanchToy = this;
			return floroRanchToy.GetRaceArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x0023F454 File Offset: 0x0023D654
		[NullableContext(1)]
		public readonly IEnumerable<int> RaceIter()
		{
			FloroRanchToy.<RaceIter>d__44 <RaceIter>d__ = new FloroRanchToy.<RaceIter>d__44(-2);
			<RaceIter>d__.<>3__<>4__this = this;
			return <RaceIter>d__;
		}

		// Token: 0x04004D2C RID: 19756
		private Table __p;
	}
}
