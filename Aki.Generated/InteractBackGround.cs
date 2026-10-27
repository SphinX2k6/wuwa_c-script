using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D78 RID: 3448
	public struct InteractBackGround : IFlatbufferObject
	{
		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x00264EB9 File Offset: 0x002630B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060085E5 RID: 34277 RVA: 0x00264EC6 File Offset: 0x002630C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060085E6 RID: 34278 RVA: 0x00264ED0 File Offset: 0x002630D0
		public static InteractBackGround GetRootAsInteractBackGround(ByteBuffer _bb)
		{
			return InteractBackGround.GetRootAsInteractBackGround(_bb, default(InteractBackGround));
		}

		// Token: 0x060085E7 RID: 34279 RVA: 0x00264EEC File Offset: 0x002630EC
		public static InteractBackGround GetRootAsInteractBackGround(ByteBuffer _bb, InteractBackGround obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060085E8 RID: 34280 RVA: 0x00264F09 File Offset: 0x00263109
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060085E9 RID: 34281 RVA: 0x00264F18 File Offset: 0x00263118
		public InteractBackGround __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x060085EA RID: 34282 RVA: 0x00264F28 File Offset: 0x00263128
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

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x060085EB RID: 34283 RVA: 0x00264F64 File Offset: 0x00263164
		public string ViewName
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

		// Token: 0x060085EC RID: 34284 RVA: 0x00264F9B File Offset: 0x0026319B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060085ED RID: 34285 RVA: 0x00264FAA File Offset: 0x002631AA
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170019DA RID: 6618
		// (get) Token: 0x060085EE RID: 34286 RVA: 0x00264FC4 File Offset: 0x002631C4
		public string Title
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

		// Token: 0x060085EF RID: 34287 RVA: 0x00264FFB File Offset: 0x002631FB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060085F0 RID: 34288 RVA: 0x0026500A File Offset: 0x0026320A
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x060085F1 RID: 34289 RVA: 0x00265024 File Offset: 0x00263224
		public string TitleSpritePath
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

		// Token: 0x060085F2 RID: 34290 RVA: 0x0026505C File Offset: 0x0026325C
		public Span<byte> GetTitleSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060085F3 RID: 34291 RVA: 0x0026506C File Offset: 0x0026326C
		public byte[] GetTitleSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x060085F4 RID: 34292 RVA: 0x00265084 File Offset: 0x00263284
		public string ContentSpritePath
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

		// Token: 0x060085F5 RID: 34293 RVA: 0x002650BC File Offset: 0x002632BC
		public Span<byte> GetContentSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060085F6 RID: 34294 RVA: 0x002650CC File Offset: 0x002632CC
		public byte[] GetContentSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x060085F7 RID: 34295 RVA: 0x002650E4 File Offset: 0x002632E4
		public int CostItemList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x060085F8 RID: 34296 RVA: 0x00265124 File Offset: 0x00263324
		public int CostItemListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060085F9 RID: 34297 RVA: 0x00265150 File Offset: 0x00263350
		public Span<int> GetCostItemListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x060085FA RID: 34298 RVA: 0x00265160 File Offset: 0x00263360
		public int[] GetCostItemListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x060085FB RID: 34299 RVA: 0x00265178 File Offset: 0x00263378
		public bool IsHelpButtonVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x060085FC RID: 34300 RVA: 0x002651B8 File Offset: 0x002633B8
		public int HelpGroupId
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

		// Token: 0x060085FD RID: 34301 RVA: 0x002651F8 File Offset: 0x002633F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CostItemListIter()或GetCostItemListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CostItemList()
		{
			InteractBackGround interactBackGround = this;
			return interactBackGround.GetCostItemListArray() ?? Array.Empty<int>();
		}

		// Token: 0x060085FE RID: 34302 RVA: 0x0026521C File Offset: 0x0026341C
		[NullableContext(1)]
		public readonly IEnumerable<int> CostItemListIter()
		{
			InteractBackGround.<CostItemListIter>d__36 <CostItemListIter>d__ = new InteractBackGround.<CostItemListIter>d__36(-2);
			<CostItemListIter>d__.<>3__<>4__this = this;
			return <CostItemListIter>d__;
		}

		// Token: 0x04004E00 RID: 19968
		private Table __p;
	}
}
