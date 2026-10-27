using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115E RID: 4446
	public struct TrapDefenseBuildingType : IFlatbufferObject
	{
		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0600E32E RID: 58158 RVA: 0x00337B8C File Offset: 0x00335D8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E32F RID: 58159 RVA: 0x00337B99 File Offset: 0x00335D99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E330 RID: 58160 RVA: 0x00337BA0 File Offset: 0x00335DA0
		public static TrapDefenseBuildingType GetRootAsTrapDefenseBuildingType(ByteBuffer _bb)
		{
			return TrapDefenseBuildingType.GetRootAsTrapDefenseBuildingType(_bb, default(TrapDefenseBuildingType));
		}

		// Token: 0x0600E331 RID: 58161 RVA: 0x00337BBC File Offset: 0x00335DBC
		public static TrapDefenseBuildingType GetRootAsTrapDefenseBuildingType(ByteBuffer _bb, TrapDefenseBuildingType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E332 RID: 58162 RVA: 0x00337BD9 File Offset: 0x00335DD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E333 RID: 58163 RVA: 0x00337BE8 File Offset: 0x00335DE8
		public TrapDefenseBuildingType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600E334 RID: 58164 RVA: 0x00337BF8 File Offset: 0x00335DF8
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

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600E335 RID: 58165 RVA: 0x00337C34 File Offset: 0x00335E34
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

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600E336 RID: 58166 RVA: 0x00337C70 File Offset: 0x00335E70
		public int SortId
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

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600E337 RID: 58167 RVA: 0x00337CAC File Offset: 0x00335EAC
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

		// Token: 0x0600E338 RID: 58168 RVA: 0x00337CE4 File Offset: 0x00335EE4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E339 RID: 58169 RVA: 0x00337CF4 File Offset: 0x00335EF4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0600E33A RID: 58170 RVA: 0x00337D0C File Offset: 0x00335F0C
		public int TemplateId
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

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0600E33B RID: 58171 RVA: 0x00337D4C File Offset: 0x00335F4C
		public int DamageType
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

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0600E33C RID: 58172 RVA: 0x00337D8C File Offset: 0x00335F8C
		public int PlacementType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C0D RID: 15373
		// (get) Token: 0x0600E33D RID: 58173 RVA: 0x00337DCC File Offset: 0x00335FCC
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C0E RID: 15374
		// (get) Token: 0x0600E33E RID: 58174 RVA: 0x00337E0C File Offset: 0x0033600C
		public int InitMaxLevel
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 2;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003C0F RID: 15375
		// (get) Token: 0x0600E33F RID: 58175 RVA: 0x00337E4C File Offset: 0x0033604C
		public bool IsInitUnlocked
		{
			get
			{
				int num = this.__p.__offset(22);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x0600E340 RID: 58176 RVA: 0x00337E8C File Offset: 0x0033608C
		public int BranchCount
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x00337ECC File Offset: 0x003360CC
		public int AttrShow(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x0600E342 RID: 58178 RVA: 0x00337F0C File Offset: 0x0033610C
		public int AttrShowLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E343 RID: 58179 RVA: 0x00337F38 File Offset: 0x00336138
		public Span<int> GetAttrShowBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600E344 RID: 58180 RVA: 0x00337F48 File Offset: 0x00336148
		public int[] GetAttrShowArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x00337F60 File Offset: 0x00336160
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E346 RID: 58182 RVA: 0x00337F98 File Offset: 0x00336198
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x00337FA8 File Offset: 0x003361A8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x0600E348 RID: 58184 RVA: 0x00337FC0 File Offset: 0x003361C0
		public string VideoName
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E349 RID: 58185 RVA: 0x00337FF8 File Offset: 0x003361F8
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E34A RID: 58186 RVA: 0x00338008 File Offset: 0x00336208
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0600E34B RID: 58187 RVA: 0x00338020 File Offset: 0x00336220
		public string VideoPath
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E34C RID: 58188 RVA: 0x00338058 File Offset: 0x00336258
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600E34D RID: 58189 RVA: 0x00338068 File Offset: 0x00336268
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0600E34E RID: 58190 RVA: 0x00338080 File Offset: 0x00336280
		public bool CanRotate
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600E34F RID: 58191 RVA: 0x003380C0 File Offset: 0x003362C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttrShowIter()或GetAttrShowBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttrShow()
		{
			TrapDefenseBuildingType trapDefenseBuildingType = this;
			return trapDefenseBuildingType.GetAttrShowArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E350 RID: 58192 RVA: 0x003380E4 File Offset: 0x003362E4
		[NullableContext(1)]
		public readonly IEnumerable<int> AttrShowIter()
		{
			TrapDefenseBuildingType.<AttrShowIter>d__52 <AttrShowIter>d__ = new TrapDefenseBuildingType.<AttrShowIter>d__52(-2);
			<AttrShowIter>d__.<>3__<>4__this = this;
			return <AttrShowIter>d__;
		}

		// Token: 0x040052A3 RID: 21155
		private Table __p;
	}
}
