using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EBC RID: 3772
	public struct PhantomBattleBadge : IFlatbufferObject
	{
		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x0600A437 RID: 42039 RVA: 0x002A95E4 File Offset: 0x002A77E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x002A95F1 File Offset: 0x002A77F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A439 RID: 42041 RVA: 0x002A95F8 File Offset: 0x002A77F8
		public static PhantomBattleBadge GetRootAsPhantomBattleBadge(ByteBuffer _bb)
		{
			return PhantomBattleBadge.GetRootAsPhantomBattleBadge(_bb, default(PhantomBattleBadge));
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x002A9614 File Offset: 0x002A7814
		public static PhantomBattleBadge GetRootAsPhantomBattleBadge(ByteBuffer _bb, PhantomBattleBadge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x002A9631 File Offset: 0x002A7831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x002A9640 File Offset: 0x002A7840
		public PhantomBattleBadge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x0600A43D RID: 42045 RVA: 0x002A9650 File Offset: 0x002A7850
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

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x0600A43E RID: 42046 RVA: 0x002A968C File Offset: 0x002A788C
		public int GroupId
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

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x0600A43F RID: 42047 RVA: 0x002A96C8 File Offset: 0x002A78C8
		public int ActivityId
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

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x0600A440 RID: 42048 RVA: 0x002A9704 File Offset: 0x002A7904
		public int ItemType
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

		// Token: 0x1700252A RID: 9514
		// (get) Token: 0x0600A441 RID: 42049 RVA: 0x002A9744 File Offset: 0x002A7944
		public string ShowIcon
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

		// Token: 0x0600A442 RID: 42050 RVA: 0x002A977C File Offset: 0x002A797C
		public Span<byte> GetShowIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x002A978C File Offset: 0x002A798C
		public byte[] GetShowIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700252B RID: 9515
		// (get) Token: 0x0600A444 RID: 42052 RVA: 0x002A97A4 File Offset: 0x002A79A4
		public string Name
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

		// Token: 0x0600A445 RID: 42053 RVA: 0x002A97DC File Offset: 0x002A79DC
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x002A97EC File Offset: 0x002A79EC
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700252C RID: 9516
		// (get) Token: 0x0600A447 RID: 42055 RVA: 0x002A9804 File Offset: 0x002A7A04
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x002A983C File Offset: 0x002A7A3C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x002A984C File Offset: 0x002A7A4C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x0600A44A RID: 42058 RVA: 0x002A9864 File Offset: 0x002A7A64
		public int ConditionGroup
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

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x002A98A4 File Offset: 0x002A7AA4
		public int QualityId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x0600A44C RID: 42060 RVA: 0x002A98E4 File Offset: 0x002A7AE4
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x002A991C File Offset: 0x002A7B1C
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x002A992C File Offset: 0x002A7B2C
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x0600A44F RID: 42063 RVA: 0x002A9944 File Offset: 0x002A7B44
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x002A997C File Offset: 0x002A7B7C
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x002A998C File Offset: 0x002A7B8C
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17002531 RID: 9521
		// (get) Token: 0x0600A452 RID: 42066 RVA: 0x002A99A4 File Offset: 0x002A7BA4
		public string BgDescription
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

		// Token: 0x0600A453 RID: 42067 RVA: 0x002A99DC File Offset: 0x002A7BDC
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x002A99EC File Offset: 0x002A7BEC
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17002532 RID: 9522
		// (get) Token: 0x0600A455 RID: 42069 RVA: 0x002A9A04 File Offset: 0x002A7C04
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

		// Token: 0x0600A456 RID: 42070 RVA: 0x002A9A3C File Offset: 0x002A7C3C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x002A9A4C File Offset: 0x002A7C4C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x0600A458 RID: 42072 RVA: 0x002A9A64 File Offset: 0x002A7C64
		public string IconMiddle
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

		// Token: 0x0600A459 RID: 42073 RVA: 0x002A9A9C File Offset: 0x002A7C9C
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x002A9AAC File Offset: 0x002A7CAC
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x0600A45B RID: 42075 RVA: 0x002A9AC4 File Offset: 0x002A7CC4
		public string IconSmall
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

		// Token: 0x0600A45C RID: 42076 RVA: 0x002A9AFC File Offset: 0x002A7CFC
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600A45D RID: 42077 RVA: 0x002A9B0C File Offset: 0x002A7D0C
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x002A9B24 File Offset: 0x002A7D24
		public string Mesh
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x002A9B5C File Offset: 0x002A7D5C
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x002A9B6C File Offset: 0x002A7D6C
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x0600A461 RID: 42081 RVA: 0x002A9B84 File Offset: 0x002A7D84
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x002A9BBC File Offset: 0x002A7DBC
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x002A9BCC File Offset: 0x002A7DCC
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x0600A464 RID: 42084 RVA: 0x002A9BE4 File Offset: 0x002A7DE4
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(38);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x002A9C24 File Offset: 0x002A7E24
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x0600A466 RID: 42086 RVA: 0x002A9C64 File Offset: 0x002A7E64
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x002A9C90 File Offset: 0x002A7E90
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x002A9CA0 File Offset: 0x002A7EA0
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x0600A469 RID: 42089 RVA: 0x002A9CB8 File Offset: 0x002A7EB8
		public int SortIndex
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x0600A46A RID: 42090 RVA: 0x002A9CF8 File Offset: 0x002A7EF8
		public int RedDotDisableRule
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x002A9D38 File Offset: 0x002A7F38
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			PhantomBattleBadge phantomBattleBadge = this;
			return phantomBattleBadge.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x002A9D5C File Offset: 0x002A7F5C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			PhantomBattleBadge.<ItemAccessIter>d__76 <ItemAccessIter>d__ = new PhantomBattleBadge.<ItemAccessIter>d__76(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x04004F77 RID: 20343
		private Table __p;
	}
}
