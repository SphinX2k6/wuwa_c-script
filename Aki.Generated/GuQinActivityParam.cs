using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E04 RID: 3588
	public struct GuQinActivityParam : IFlatbufferObject
	{
		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060083A5 RID: 33701 RVA: 0x00270A66 File Offset: 0x0026EC66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x00270A73 File Offset: 0x0026EC73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x00270A7C File Offset: 0x0026EC7C
		public static GuQinActivityParam GetRootAsGuQinActivityParam(ByteBuffer _bb)
		{
			return GuQinActivityParam.GetRootAsGuQinActivityParam(_bb, default(GuQinActivityParam));
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x00270A98 File Offset: 0x0026EC98
		public static GuQinActivityParam GetRootAsGuQinActivityParam(ByteBuffer _bb, GuQinActivityParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x00270AB5 File Offset: 0x0026ECB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x00270AC4 File Offset: 0x0026ECC4
		public GuQinActivityParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060083AB RID: 33707 RVA: 0x00270AD4 File Offset: 0x0026ECD4
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

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060083AC RID: 33708 RVA: 0x00270B10 File Offset: 0x0026ED10
		public int RecommendQuestId
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

		// Token: 0x060083AD RID: 33709 RVA: 0x00270B4C File Offset: 0x0026ED4C
		public int RecommendQuestLinkList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060083AE RID: 33710 RVA: 0x00270B8C File Offset: 0x0026ED8C
		public int RecommendQuestLinkListLength
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

		// Token: 0x060083AF RID: 33711 RVA: 0x00270BB7 File Offset: 0x0026EDB7
		public Span<int> GetRecommendQuestLinkListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x00270BC6 File Offset: 0x0026EDC6
		public int[] GetRecommendQuestLinkListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x00270BE0 File Offset: 0x0026EDE0
		public string RecommendQuestLabel
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

		// Token: 0x060083B2 RID: 33714 RVA: 0x00270C18 File Offset: 0x0026EE18
		public Span<byte> GetRecommendQuestLabelBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x00270C28 File Offset: 0x0026EE28
		public byte[] GetRecommendQuestLabelArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x00270C40 File Offset: 0x0026EE40
		public string MaleMontagePaths(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060083B5 RID: 33717 RVA: 0x00270C7C File Offset: 0x0026EE7C
		public int MaleMontagePathsLength
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

		// Token: 0x060083B6 RID: 33718 RVA: 0x00270CA8 File Offset: 0x0026EEA8
		public string FemaleMontagePaths(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060083B7 RID: 33719 RVA: 0x00270CE4 File Offset: 0x0026EEE4
		public int FemaleMontagePathsLength
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

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060083B8 RID: 33720 RVA: 0x00270D10 File Offset: 0x0026EF10
		public string UiCameraId
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

		// Token: 0x060083B9 RID: 33721 RVA: 0x00270D48 File Offset: 0x0026EF48
		public Span<byte> GetUiCameraIdBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x00270D58 File Offset: 0x0026EF58
		public byte[] GetUiCameraIdArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x00270D70 File Offset: 0x0026EF70
		[NullableContext(1)]
		public string[] FemaleMontagePaths()
		{
			return this.FemaleMontagePathsIter().ToArray<string>();
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x00270D7D File Offset: 0x0026EF7D
		[NullableContext(1)]
		public IEnumerable<string> FemaleMontagePathsIter()
		{
			GuQinActivityParam.<FemaleMontagePathsIter>d__32 <FemaleMontagePathsIter>d__ = new GuQinActivityParam.<FemaleMontagePathsIter>d__32(-2);
			<FemaleMontagePathsIter>d__.<>3__<>4__this = this;
			return <FemaleMontagePathsIter>d__;
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x00270D92 File Offset: 0x0026EF92
		[NullableContext(1)]
		public string[] MaleMontagePaths()
		{
			return this.MaleMontagePathsIter().ToArray<string>();
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x00270D9F File Offset: 0x0026EF9F
		[NullableContext(1)]
		public IEnumerable<string> MaleMontagePathsIter()
		{
			GuQinActivityParam.<MaleMontagePathsIter>d__34 <MaleMontagePathsIter>d__ = new GuQinActivityParam.<MaleMontagePathsIter>d__34(-2);
			<MaleMontagePathsIter>d__.<>3__<>4__this = this;
			return <MaleMontagePathsIter>d__;
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x00270DB4 File Offset: 0x0026EFB4
		[NullableContext(1)]
		public int[] RecommendQuestLinkList()
		{
			return this.GetRecommendQuestLinkListArray();
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x00270DBC File Offset: 0x0026EFBC
		[NullableContext(1)]
		public IEnumerable<int> RecommendQuestLinkListIter()
		{
			GuQinActivityParam.<RecommendQuestLinkListIter>d__36 <RecommendQuestLinkListIter>d__ = new GuQinActivityParam.<RecommendQuestLinkListIter>d__36(-2);
			<RecommendQuestLinkListIter>d__.<>3__<>4__this = this;
			return <RecommendQuestLinkListIter>d__;
		}

		// Token: 0x0400537C RID: 21372
		private Table __p;
	}
}
