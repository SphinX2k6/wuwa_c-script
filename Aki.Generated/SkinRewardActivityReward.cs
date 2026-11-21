using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011C5 RID: 4549
	public struct SkinRewardActivityReward : IFlatbufferObject
	{
		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600DE1A RID: 56858 RVA: 0x00339484 File Offset: 0x00337684
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x00339491 File Offset: 0x00337691
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x00339498 File Offset: 0x00337698
		public static SkinRewardActivityReward GetRootAsSkinRewardActivityReward(ByteBuffer _bb)
		{
			return SkinRewardActivityReward.GetRootAsSkinRewardActivityReward(_bb, default(SkinRewardActivityReward));
		}

		// Token: 0x0600DE1D RID: 56861 RVA: 0x003394B4 File Offset: 0x003376B4
		public static SkinRewardActivityReward GetRootAsSkinRewardActivityReward(ByteBuffer _bb, SkinRewardActivityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x003394D1 File Offset: 0x003376D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE1F RID: 56863 RVA: 0x003394E0 File Offset: 0x003376E0
		public SkinRewardActivityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x003394F0 File Offset: 0x003376F0
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

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600DE21 RID: 56865 RVA: 0x0033952C File Offset: 0x0033772C
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

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600DE22 RID: 56866 RVA: 0x00339568 File Offset: 0x00337768
		public int ConditionGroup
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

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600DE23 RID: 56867 RVA: 0x003395A4 File Offset: 0x003377A4
		public int TargetQuestID
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

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600DE24 RID: 56868 RVA: 0x003395E4 File Offset: 0x003377E4
		public int DirectTrainActivityId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x00339624 File Offset: 0x00337824
		public int PathQuestArray(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600DE26 RID: 56870 RVA: 0x00339664 File Offset: 0x00337864
		public int PathQuestArrayLength
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

		// Token: 0x0600DE27 RID: 56871 RVA: 0x00339690 File Offset: 0x00337890
		public Span<int> GetPathQuestArrayBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600DE28 RID: 56872 RVA: 0x003396A0 File Offset: 0x003378A0
		public int[] GetPathQuestArrayArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600DE29 RID: 56873 RVA: 0x003396B8 File Offset: 0x003378B8
		public int MaleSkinId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600DE2A RID: 56874 RVA: 0x003396F8 File Offset: 0x003378F8
		public int FemaleSkinId
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

		// Token: 0x0600DE2B RID: 56875 RVA: 0x00339735 File Offset: 0x00337935
		[NullableContext(1)]
		public int[] PathQuestArray()
		{
			return this.GetPathQuestArrayArray();
		}

		// Token: 0x0600DE2C RID: 56876 RVA: 0x0033973D File Offset: 0x0033793D
		[NullableContext(1)]
		public IEnumerable<int> PathQuestArrayIter()
		{
			SkinRewardActivityReward.<PathQuestArrayIter>d__28 <PathQuestArrayIter>d__ = new SkinRewardActivityReward.<PathQuestArrayIter>d__28(-2);
			<PathQuestArrayIter>d__.<>3__<>4__this = this;
			return <PathQuestArrayIter>d__;
		}

		// Token: 0x040057FB RID: 22523
		private Table __p;
	}
}
