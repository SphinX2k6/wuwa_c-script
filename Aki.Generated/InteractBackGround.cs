using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E5D RID: 3677
	public struct InteractBackGround : IFlatbufferObject
	{
		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06008BFF RID: 35839 RVA: 0x00283189 File Offset: 0x00281389
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008C00 RID: 35840 RVA: 0x00283196 File Offset: 0x00281396
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008C01 RID: 35841 RVA: 0x002831A0 File Offset: 0x002813A0
		public static InteractBackGround GetRootAsInteractBackGround(ByteBuffer _bb)
		{
			return InteractBackGround.GetRootAsInteractBackGround(_bb, default(InteractBackGround));
		}

		// Token: 0x06008C02 RID: 35842 RVA: 0x002831BC File Offset: 0x002813BC
		public static InteractBackGround GetRootAsInteractBackGround(ByteBuffer _bb, InteractBackGround obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008C03 RID: 35843 RVA: 0x002831D9 File Offset: 0x002813D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008C04 RID: 35844 RVA: 0x002831E8 File Offset: 0x002813E8
		public InteractBackGround __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x06008C05 RID: 35845 RVA: 0x002831F8 File Offset: 0x002813F8
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

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x06008C06 RID: 35846 RVA: 0x00283234 File Offset: 0x00281434
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

		// Token: 0x06008C07 RID: 35847 RVA: 0x0028326B File Offset: 0x0028146B
		public Span<byte> GetViewNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008C08 RID: 35848 RVA: 0x0028327A File Offset: 0x0028147A
		public byte[] GetViewNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x06008C09 RID: 35849 RVA: 0x00283294 File Offset: 0x00281494
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

		// Token: 0x06008C0A RID: 35850 RVA: 0x002832CB File Offset: 0x002814CB
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008C0B RID: 35851 RVA: 0x002832DA File Offset: 0x002814DA
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x06008C0C RID: 35852 RVA: 0x002832F4 File Offset: 0x002814F4
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

		// Token: 0x06008C0D RID: 35853 RVA: 0x0028332C File Offset: 0x0028152C
		public Span<byte> GetTitleSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008C0E RID: 35854 RVA: 0x0028333C File Offset: 0x0028153C
		public byte[] GetTitleSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x06008C0F RID: 35855 RVA: 0x00283354 File Offset: 0x00281554
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

		// Token: 0x06008C10 RID: 35856 RVA: 0x0028338C File Offset: 0x0028158C
		public Span<byte> GetContentSpritePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008C11 RID: 35857 RVA: 0x0028339C File Offset: 0x0028159C
		public byte[] GetContentSpritePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x06008C12 RID: 35858 RVA: 0x002833B4 File Offset: 0x002815B4
		public int CostItemList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06008C13 RID: 35859 RVA: 0x002833F4 File Offset: 0x002815F4
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

		// Token: 0x06008C14 RID: 35860 RVA: 0x00283420 File Offset: 0x00281620
		public Span<int> GetCostItemListBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008C15 RID: 35861 RVA: 0x00283430 File Offset: 0x00281630
		public int[] GetCostItemListArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06008C16 RID: 35862 RVA: 0x00283448 File Offset: 0x00281648
		public bool IsHelpButtonVisible
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06008C17 RID: 35863 RVA: 0x00283488 File Offset: 0x00281688
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

		// Token: 0x06008C18 RID: 35864 RVA: 0x002834C5 File Offset: 0x002816C5
		[NullableContext(1)]
		public int[] CostItemList()
		{
			return this.GetCostItemListArray();
		}

		// Token: 0x06008C19 RID: 35865 RVA: 0x002834CD File Offset: 0x002816CD
		[NullableContext(1)]
		public IEnumerable<int> CostItemListIter()
		{
			InteractBackGround.<CostItemListIter>d__36 <CostItemListIter>d__ = new InteractBackGround.<CostItemListIter>d__36(-2);
			<CostItemListIter>d__.<>3__<>4__this = this;
			return <CostItemListIter>d__;
		}

		// Token: 0x040053E5 RID: 21477
		private Table __p;
	}
}
