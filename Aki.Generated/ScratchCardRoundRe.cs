using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001091 RID: 4241
	public struct ScratchCardRoundRe : IFlatbufferObject
	{
		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600CFC8 RID: 53192 RVA: 0x0030A68E File Offset: 0x0030888E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CFC9 RID: 53193 RVA: 0x0030A69B File Offset: 0x0030889B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CFCA RID: 53194 RVA: 0x0030A6A4 File Offset: 0x003088A4
		public static ScratchCardRoundRe GetRootAsScratchCardRoundRe(ByteBuffer _bb)
		{
			return ScratchCardRoundRe.GetRootAsScratchCardRoundRe(_bb, default(ScratchCardRoundRe));
		}

		// Token: 0x0600CFCB RID: 53195 RVA: 0x0030A6C0 File Offset: 0x003088C0
		public static ScratchCardRoundRe GetRootAsScratchCardRoundRe(ByteBuffer _bb, ScratchCardRoundRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CFCC RID: 53196 RVA: 0x0030A6DD File Offset: 0x003088DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CFCD RID: 53197 RVA: 0x0030A6EC File Offset: 0x003088EC
		public ScratchCardRoundRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600CFCE RID: 53198 RVA: 0x0030A6FC File Offset: 0x003088FC
		public int RoundId
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

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600CFCF RID: 53199 RVA: 0x0030A738 File Offset: 0x00308938
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

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600CFD0 RID: 53200 RVA: 0x0030A774 File Offset: 0x00308974
		public int PreRoundId
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

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600CFD1 RID: 53201 RVA: 0x0030A7B0 File Offset: 0x003089B0
		public int Size
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

		// Token: 0x0600CFD2 RID: 53202 RVA: 0x0030A7F0 File Offset: 0x003089F0
		public int RewardSortList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600CFD3 RID: 53203 RVA: 0x0030A830 File Offset: 0x00308A30
		public int RewardSortListLength
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

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x0030A85C File Offset: 0x00308A5C
		public Span<int> GetRewardSortListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600CFD5 RID: 53205 RVA: 0x0030A86C File Offset: 0x00308A6C
		public int[] GetRewardSortListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600CFD6 RID: 53206 RVA: 0x0030A884 File Offset: 0x00308A84
		public string YellowRoundIcon
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

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x0030A8BC File Offset: 0x00308ABC
		public Span<byte> GetYellowRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600CFD8 RID: 53208 RVA: 0x0030A8CC File Offset: 0x00308ACC
		public byte[] GetYellowRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003506 RID: 13574
		// (get) Token: 0x0600CFD9 RID: 53209 RVA: 0x0030A8E4 File Offset: 0x00308AE4
		public string BlackRoundIcon
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

		// Token: 0x0600CFDA RID: 53210 RVA: 0x0030A91C File Offset: 0x00308B1C
		public Span<byte> GetBlackRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600CFDB RID: 53211 RVA: 0x0030A92C File Offset: 0x00308B2C
		public byte[] GetBlackRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003507 RID: 13575
		// (get) Token: 0x0600CFDC RID: 53212 RVA: 0x0030A944 File Offset: 0x00308B44
		public string TogRoundIcon
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600CFDD RID: 53213 RVA: 0x0030A97C File Offset: 0x00308B7C
		public Span<byte> GetTogRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600CFDE RID: 53214 RVA: 0x0030A98C File Offset: 0x00308B8C
		public byte[] GetTogRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600CFDF RID: 53215 RVA: 0x0030A9A4 File Offset: 0x00308BA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardSortListIter()或GetRewardSortListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardSortList()
		{
			ScratchCardRoundRe scratchCardRoundRe = this;
			return scratchCardRoundRe.GetRewardSortListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600CFE0 RID: 53216 RVA: 0x0030A9C8 File Offset: 0x00308BC8
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardSortListIter()
		{
			ScratchCardRoundRe.<RewardSortListIter>d__34 <RewardSortListIter>d__ = new ScratchCardRoundRe.<RewardSortListIter>d__34(-2);
			<RewardSortListIter>d__.<>3__<>4__this = this;
			return <RewardSortListIter>d__;
		}

		// Token: 0x0400519E RID: 20894
		private Table __p;
	}
}
