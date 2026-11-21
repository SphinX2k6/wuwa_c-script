using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C89 RID: 3209
	public struct CorniceChallenge : IFlatbufferObject
	{
		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600600D RID: 24589 RVA: 0x00221584 File Offset: 0x0021F784
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00221591 File Offset: 0x0021F791
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x00221598 File Offset: 0x0021F798
		public static CorniceChallenge GetRootAsCorniceChallenge(ByteBuffer _bb)
		{
			return CorniceChallenge.GetRootAsCorniceChallenge(_bb, default(CorniceChallenge));
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x002215B4 File Offset: 0x0021F7B4
		public static CorniceChallenge GetRootAsCorniceChallenge(ByteBuffer _bb, CorniceChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x002215D1 File Offset: 0x0021F7D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x002215E0 File Offset: 0x0021F7E0
		public CorniceChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x002215F0 File Offset: 0x0021F7F0
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

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06006014 RID: 24596 RVA: 0x0022162C File Offset: 0x0021F82C
		public int MarkId
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

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06006015 RID: 24597 RVA: 0x00221668 File Offset: 0x0021F868
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

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06006016 RID: 24598 RVA: 0x002216A4 File Offset: 0x0021F8A4
		public int ActivityId
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

		// Token: 0x06006017 RID: 24599 RVA: 0x002216E4 File Offset: 0x0021F8E4
		public IntPair? RewardList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00221748 File Offset: 0x0021F948
		public int RewardListLength
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

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x00221774 File Offset: 0x0021F974
		public int MaxScore
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

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x0600601A RID: 24602 RVA: 0x002217B4 File Offset: 0x0021F9B4
		public string BackgroundTexture
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

		// Token: 0x0600601B RID: 24603 RVA: 0x002217EC File Offset: 0x0021F9EC
		public Span<byte> GetBackgroundTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x002217FC File Offset: 0x0021F9FC
		public byte[] GetBackgroundTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600601D RID: 24605 RVA: 0x00221814 File Offset: 0x0021FA14
		public string Title
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

		// Token: 0x0600601E RID: 24606 RVA: 0x0022184C File Offset: 0x0021FA4C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x0022185C File Offset: 0x0021FA5C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00221874 File Offset: 0x0021FA74
		[NullableContext(1)]
		public IntPair[] RewardList()
		{
			return this.RewardListIter().ToArray<IntPair>();
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00221881 File Offset: 0x0021FA81
		[NullableContext(1)]
		public IEnumerable<IntPair> RewardListIter()
		{
			CorniceChallenge.<RewardListIter>d__30 <RewardListIter>d__ = new CorniceChallenge.<RewardListIter>d__30(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x040051AC RID: 20908
		private Table __p;
	}
}
