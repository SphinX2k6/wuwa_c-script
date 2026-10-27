using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A5 RID: 4261
	public struct SheriffQuestionMainCsv : IFlatbufferObject
	{
		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600D16D RID: 53613 RVA: 0x0030E079 File Offset: 0x0030C279
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x0030E086 File Offset: 0x0030C286
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x0030E090 File Offset: 0x0030C290
		public static SheriffQuestionMainCsv GetRootAsSheriffQuestionMainCsv(ByteBuffer _bb)
		{
			return SheriffQuestionMainCsv.GetRootAsSheriffQuestionMainCsv(_bb, default(SheriffQuestionMainCsv));
		}

		// Token: 0x0600D170 RID: 53616 RVA: 0x0030E0AC File Offset: 0x0030C2AC
		public static SheriffQuestionMainCsv GetRootAsSheriffQuestionMainCsv(ByteBuffer _bb, SheriffQuestionMainCsv obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x0030E0C9 File Offset: 0x0030C2C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x0030E0D8 File Offset: 0x0030C2D8
		public SheriffQuestionMainCsv __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600D173 RID: 53619 RVA: 0x0030E0E8 File Offset: 0x0030C2E8
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

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600D174 RID: 53620 RVA: 0x0030E124 File Offset: 0x0030C324
		public string Remark
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

		// Token: 0x0600D175 RID: 53621 RVA: 0x0030E15B File Offset: 0x0030C35B
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D176 RID: 53622 RVA: 0x0030E16A File Offset: 0x0030C36A
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D177 RID: 53623 RVA: 0x0030E184 File Offset: 0x0030C384
		public int ClueIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600D178 RID: 53624 RVA: 0x0030E1C4 File Offset: 0x0030C3C4
		public int ClueIdsLength
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

		// Token: 0x0600D179 RID: 53625 RVA: 0x0030E1EF File Offset: 0x0030C3EF
		public Span<int> GetClueIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x0030E1FE File Offset: 0x0030C3FE
		public int[] GetClueIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600D17B RID: 53627 RVA: 0x0030E218 File Offset: 0x0030C418
		public string QuestionConfigs
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

		// Token: 0x0600D17C RID: 53628 RVA: 0x0030E250 File Offset: 0x0030C450
		public Span<byte> GetQuestionConfigsBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x0030E260 File Offset: 0x0030C460
		public byte[] GetQuestionConfigsArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x0030E278 File Offset: 0x0030C478
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ClueIdsIter()或GetClueIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ClueIds()
		{
			SheriffQuestionMainCsv sheriffQuestionMainCsv = this;
			return sheriffQuestionMainCsv.GetClueIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D17F RID: 53631 RVA: 0x0030E29C File Offset: 0x0030C49C
		[NullableContext(1)]
		public readonly IEnumerable<int> ClueIdsIter()
		{
			SheriffQuestionMainCsv.<ClueIdsIter>d__24 <ClueIdsIter>d__ = new SheriffQuestionMainCsv.<ClueIdsIter>d__24(-2);
			<ClueIdsIter>d__.<>3__<>4__this = this;
			return <ClueIdsIter>d__;
		}

		// Token: 0x040051B4 RID: 20916
		private Table __p;
	}
}
