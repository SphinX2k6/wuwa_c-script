using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DCC RID: 3532
	public struct LineCrossGroup : IFlatbufferObject
	{
		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x06008E3E RID: 36414 RVA: 0x0027808D File Offset: 0x0027628D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x0027809A File Offset: 0x0027629A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x002780A4 File Offset: 0x002762A4
		public static LineCrossGroup GetRootAsLineCrossGroup(ByteBuffer _bb)
		{
			return LineCrossGroup.GetRootAsLineCrossGroup(_bb, default(LineCrossGroup));
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x002780C0 File Offset: 0x002762C0
		public static LineCrossGroup GetRootAsLineCrossGroup(ByteBuffer _bb, LineCrossGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x002780DD File Offset: 0x002762DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E43 RID: 36419 RVA: 0x002780EC File Offset: 0x002762EC
		public LineCrossGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x06008E44 RID: 36420 RVA: 0x002780FC File Offset: 0x002762FC
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

		// Token: 0x06008E45 RID: 36421 RVA: 0x00278138 File Offset: 0x00276338
		public int NeedFinishGroup(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x06008E46 RID: 36422 RVA: 0x00278178 File Offset: 0x00276378
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

		// Token: 0x06008E47 RID: 36423 RVA: 0x002781A3 File Offset: 0x002763A3
		public Span<int> GetNeedFinishGroupBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008E48 RID: 36424 RVA: 0x002781B2 File Offset: 0x002763B2
		public int[] GetNeedFinishGroupArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x06008E49 RID: 36425 RVA: 0x002781CC File Offset: 0x002763CC
		public int ChallengeList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x06008E4A RID: 36426 RVA: 0x0027820C File Offset: 0x0027640C
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

		// Token: 0x06008E4B RID: 36427 RVA: 0x00278237 File Offset: 0x00276437
		public Span<int> GetChallengeListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x00278246 File Offset: 0x00276446
		public int[] GetChallengeListArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x06008E4D RID: 36429 RVA: 0x00278260 File Offset: 0x00276460
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

		// Token: 0x06008E4E RID: 36430 RVA: 0x00278298 File Offset: 0x00276498
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008E4F RID: 36431 RVA: 0x002782A8 File Offset: 0x002764A8
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x002782C0 File Offset: 0x002764C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChallengeListIter()或GetChallengeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ChallengeList()
		{
			LineCrossGroup lineCrossGroup = this;
			return lineCrossGroup.GetChallengeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x002782E4 File Offset: 0x002764E4
		[NullableContext(1)]
		public readonly IEnumerable<int> ChallengeListIter()
		{
			LineCrossGroup.<ChallengeListIter>d__25 <ChallengeListIter>d__ = new LineCrossGroup.<ChallengeListIter>d__25(-2);
			<ChallengeListIter>d__.<>3__<>4__this = this;
			return <ChallengeListIter>d__;
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x002782FC File Offset: 0x002764FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用NeedFinishGroupIter()或GetNeedFinishGroupBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] NeedFinishGroup()
		{
			LineCrossGroup lineCrossGroup = this;
			return lineCrossGroup.GetNeedFinishGroupArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00278320 File Offset: 0x00276520
		[NullableContext(1)]
		public readonly IEnumerable<int> NeedFinishGroupIter()
		{
			LineCrossGroup.<NeedFinishGroupIter>d__27 <NeedFinishGroupIter>d__ = new LineCrossGroup.<NeedFinishGroupIter>d__27(-2);
			<NeedFinishGroupIter>d__.<>3__<>4__this = this;
			return <NeedFinishGroupIter>d__;
		}

		// Token: 0x04004E62 RID: 20066
		private Table __p;
	}
}
