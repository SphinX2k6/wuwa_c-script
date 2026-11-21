using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001276 RID: 4726
	public struct TowerDifficulty : IFlatbufferObject
	{
		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0600EDAE RID: 60846 RVA: 0x0035C4E4 File Offset: 0x0035A6E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EDAF RID: 60847 RVA: 0x0035C4F1 File Offset: 0x0035A6F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EDB0 RID: 60848 RVA: 0x0035C4F8 File Offset: 0x0035A6F8
		public static TowerDifficulty GetRootAsTowerDifficulty(ByteBuffer _bb)
		{
			return TowerDifficulty.GetRootAsTowerDifficulty(_bb, default(TowerDifficulty));
		}

		// Token: 0x0600EDB1 RID: 60849 RVA: 0x0035C514 File Offset: 0x0035A714
		public static TowerDifficulty GetRootAsTowerDifficulty(ByteBuffer _bb, TowerDifficulty obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EDB2 RID: 60850 RVA: 0x0035C531 File Offset: 0x0035A731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EDB3 RID: 60851 RVA: 0x0035C540 File Offset: 0x0035A740
		public TowerDifficulty __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600EDB4 RID: 60852 RVA: 0x0035C550 File Offset: 0x0035A750
		public int Difficulty
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

		// Token: 0x0600EDB5 RID: 60853 RVA: 0x0035C58C File Offset: 0x0035A78C
		public IntPair? Reward(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IntPair?(default(IntPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600EDB6 RID: 60854 RVA: 0x0035C5EC File Offset: 0x0035A7EC
		public int RewardLength
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

		// Token: 0x0600EDB7 RID: 60855 RVA: 0x0035C617 File Offset: 0x0035A817
		[NullableContext(1)]
		public IntPair[] Reward()
		{
			return this.RewardIter().ToArray<IntPair>();
		}

		// Token: 0x0600EDB8 RID: 60856 RVA: 0x0035C624 File Offset: 0x0035A824
		[NullableContext(1)]
		public IEnumerable<IntPair> RewardIter()
		{
			TowerDifficulty.<RewardIter>d__14 <RewardIter>d__ = new TowerDifficulty.<RewardIter>d__14(-2);
			<RewardIter>d__.<>3__<>4__this = this;
			return <RewardIter>d__;
		}

		// Token: 0x040058C4 RID: 22724
		private Table __p;
	}
}
