using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BA7 RID: 2983
	public struct CorniceChallenge : IFlatbufferObject
	{
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06005A34 RID: 23092 RVA: 0x00201840 File Offset: 0x001FFA40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x0020184D File Offset: 0x001FFA4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00201854 File Offset: 0x001FFA54
		public static CorniceChallenge GetRootAsCorniceChallenge(ByteBuffer _bb)
		{
			return CorniceChallenge.GetRootAsCorniceChallenge(_bb, default(CorniceChallenge));
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00201870 File Offset: 0x001FFA70
		public static CorniceChallenge GetRootAsCorniceChallenge(ByteBuffer _bb, CorniceChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x0020188D File Offset: 0x001FFA8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x0020189C File Offset: 0x001FFA9C
		public CorniceChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x002018AC File Offset: 0x001FFAAC
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

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06005A3B RID: 23099 RVA: 0x002018E8 File Offset: 0x001FFAE8
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

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06005A3C RID: 23100 RVA: 0x00201924 File Offset: 0x001FFB24
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

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06005A3D RID: 23101 RVA: 0x00201960 File Offset: 0x001FFB60
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

		// Token: 0x06005A3E RID: 23102 RVA: 0x002019A0 File Offset: 0x001FFBA0
		public IntPair? RewardList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06005A3F RID: 23103 RVA: 0x00201A04 File Offset: 0x001FFC04
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

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x00201A30 File Offset: 0x001FFC30
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

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06005A41 RID: 23105 RVA: 0x00201A70 File Offset: 0x001FFC70
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

		// Token: 0x06005A42 RID: 23106 RVA: 0x00201AA8 File Offset: 0x001FFCA8
		public Span<byte> GetBackgroundTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x00201AB8 File Offset: 0x001FFCB8
		public byte[] GetBackgroundTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x00201AD0 File Offset: 0x001FFCD0
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

		// Token: 0x06005A45 RID: 23109 RVA: 0x00201B08 File Offset: 0x001FFD08
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00201B18 File Offset: 0x001FFD18
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x00201B30 File Offset: 0x001FFD30
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardListIter()或GetRewardListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly IntPair[] RewardList()
		{
			return this.RewardListIter().ToArray<IntPair>();
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x00201B3D File Offset: 0x001FFD3D
		[NullableContext(1)]
		public readonly IEnumerable<IntPair> RewardListIter()
		{
			CorniceChallenge.<RewardListIter>d__30 <RewardListIter>d__ = new CorniceChallenge.<RewardListIter>d__30(-2);
			<RewardListIter>d__.<>3__<>4__this = this;
			return <RewardListIter>d__;
		}

		// Token: 0x04004BCA RID: 19402
		private Table __p;
	}
}
