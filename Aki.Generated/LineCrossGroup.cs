using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EB1 RID: 3761
	public struct LineCrossGroup : IFlatbufferObject
	{
		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x0600945A RID: 37978 RVA: 0x002965BA File Offset: 0x002947BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x002965C7 File Offset: 0x002947C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x002965D0 File Offset: 0x002947D0
		public static LineCrossGroup GetRootAsLineCrossGroup(ByteBuffer _bb)
		{
			return LineCrossGroup.GetRootAsLineCrossGroup(_bb, default(LineCrossGroup));
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x002965EC File Offset: 0x002947EC
		public static LineCrossGroup GetRootAsLineCrossGroup(ByteBuffer _bb, LineCrossGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x00296609 File Offset: 0x00294809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x00296618 File Offset: 0x00294818
		public LineCrossGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06009460 RID: 37984 RVA: 0x00296628 File Offset: 0x00294828
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

		// Token: 0x06009461 RID: 37985 RVA: 0x00296664 File Offset: 0x00294864
		public int NeedFinishGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06009462 RID: 37986 RVA: 0x002966A4 File Offset: 0x002948A4
		public int NeedFinishGroupLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x002966CF File Offset: 0x002948CF
		public Span<int> GetNeedFinishGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x002966DE File Offset: 0x002948DE
		public int[] GetNeedFinishGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x002966F8 File Offset: 0x002948F8
		public int ChallengeList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06009466 RID: 37990 RVA: 0x00296738 File Offset: 0x00294938
		public int ChallengeListLength
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

		// Token: 0x06009467 RID: 37991 RVA: 0x00296763 File Offset: 0x00294963
		public Span<int> GetChallengeListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x00296772 File Offset: 0x00294972
		public int[] GetChallengeListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06009469 RID: 37993 RVA: 0x0029678C File Offset: 0x0029498C
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

		// Token: 0x0600946A RID: 37994 RVA: 0x002967C4 File Offset: 0x002949C4
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x002967D4 File Offset: 0x002949D4
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x002967EC File Offset: 0x002949EC
		[NullableContext(1)]
		public int[] ChallengeList()
		{
			return this.GetChallengeListArray();
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x002967F4 File Offset: 0x002949F4
		[NullableContext(1)]
		public IEnumerable<int> ChallengeListIter()
		{
			LineCrossGroup.<ChallengeListIter>d__25 <ChallengeListIter>d__ = new LineCrossGroup.<ChallengeListIter>d__25(-2);
			<ChallengeListIter>d__.<>3__<>4__this = this;
			return <ChallengeListIter>d__;
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x00296809 File Offset: 0x00294A09
		[NullableContext(1)]
		public int[] NeedFinishGroup()
		{
			return this.GetNeedFinishGroupArray();
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x00296811 File Offset: 0x00294A11
		[NullableContext(1)]
		public IEnumerable<int> NeedFinishGroupIter()
		{
			LineCrossGroup.<NeedFinishGroupIter>d__27 <NeedFinishGroupIter>d__ = new LineCrossGroup.<NeedFinishGroupIter>d__27(-2);
			<NeedFinishGroupIter>d__.<>3__<>4__this = this;
			return <NeedFinishGroupIter>d__;
		}

		// Token: 0x04005447 RID: 21575
		private Table __p;
	}
}
