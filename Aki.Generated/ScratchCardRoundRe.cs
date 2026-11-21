using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200118C RID: 4492
	public struct ScratchCardRoundRe : IFlatbufferObject
	{
		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600D79B RID: 55195 RVA: 0x00329C62 File Offset: 0x00327E62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x00329C6F File Offset: 0x00327E6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D79D RID: 55197 RVA: 0x00329C78 File Offset: 0x00327E78
		public static ScratchCardRoundRe GetRootAsScratchCardRoundRe(ByteBuffer _bb)
		{
			return ScratchCardRoundRe.GetRootAsScratchCardRoundRe(_bb, default(ScratchCardRoundRe));
		}

		// Token: 0x0600D79E RID: 55198 RVA: 0x00329C94 File Offset: 0x00327E94
		public static ScratchCardRoundRe GetRootAsScratchCardRoundRe(ByteBuffer _bb, ScratchCardRoundRe obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D79F RID: 55199 RVA: 0x00329CB1 File Offset: 0x00327EB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D7A0 RID: 55200 RVA: 0x00329CC0 File Offset: 0x00327EC0
		public ScratchCardRoundRe __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600D7A1 RID: 55201 RVA: 0x00329CD0 File Offset: 0x00327ED0
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

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600D7A2 RID: 55202 RVA: 0x00329D0C File Offset: 0x00327F0C
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

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600D7A3 RID: 55203 RVA: 0x00329D48 File Offset: 0x00327F48
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

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x00329D84 File Offset: 0x00327F84
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

		// Token: 0x0600D7A5 RID: 55205 RVA: 0x00329DC4 File Offset: 0x00327FC4
		public int RewardSortList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600D7A6 RID: 55206 RVA: 0x00329E04 File Offset: 0x00328004
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

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x00329E30 File Offset: 0x00328030
		public Span<int> GetRewardSortListBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600D7A8 RID: 55208 RVA: 0x00329E40 File Offset: 0x00328040
		public int[] GetRewardSortListArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600D7A9 RID: 55209 RVA: 0x00329E58 File Offset: 0x00328058
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

		// Token: 0x0600D7AA RID: 55210 RVA: 0x00329E90 File Offset: 0x00328090
		public Span<byte> GetYellowRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x00329EA0 File Offset: 0x003280A0
		public byte[] GetYellowRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600D7AC RID: 55212 RVA: 0x00329EB8 File Offset: 0x003280B8
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

		// Token: 0x0600D7AD RID: 55213 RVA: 0x00329EF0 File Offset: 0x003280F0
		public Span<byte> GetBlackRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x00329F00 File Offset: 0x00328100
		public byte[] GetBlackRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x00329F18 File Offset: 0x00328118
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

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x00329F50 File Offset: 0x00328150
		public Span<byte> GetTogRoundIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x00329F60 File Offset: 0x00328160
		public byte[] GetTogRoundIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x00329F78 File Offset: 0x00328178
		[NullableContext(1)]
		public int[] RewardSortList()
		{
			return this.GetRewardSortListArray();
		}

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x00329F80 File Offset: 0x00328180
		[NullableContext(1)]
		public IEnumerable<int> RewardSortListIter()
		{
			ScratchCardRoundRe.<RewardSortListIter>d__34 <RewardSortListIter>d__ = new ScratchCardRoundRe.<RewardSortListIter>d__34(-2);
			<RewardSortListIter>d__.<>3__<>4__this = this;
			return <RewardSortListIter>d__;
		}

		// Token: 0x0400579D RID: 22429
		private Table __p;
	}
}
