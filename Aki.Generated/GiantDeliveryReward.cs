using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DDE RID: 3550
	public struct GiantDeliveryReward : IFlatbufferObject
	{
		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x0600804F RID: 32847 RVA: 0x0026945D File Offset: 0x0026765D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x0026946A File Offset: 0x0026766A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x00269474 File Offset: 0x00267674
		public static GiantDeliveryReward GetRootAsGiantDeliveryReward(ByteBuffer _bb)
		{
			return GiantDeliveryReward.GetRootAsGiantDeliveryReward(_bb, default(GiantDeliveryReward));
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x00269490 File Offset: 0x00267690
		public static GiantDeliveryReward GetRootAsGiantDeliveryReward(ByteBuffer _bb, GiantDeliveryReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x002694AD File Offset: 0x002676AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x002694BC File Offset: 0x002676BC
		public GiantDeliveryReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06008055 RID: 32853 RVA: 0x002694CC File Offset: 0x002676CC
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

		// Token: 0x06008056 RID: 32854 RVA: 0x00269508 File Offset: 0x00267708
		public int ItemIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06008057 RID: 32855 RVA: 0x00269548 File Offset: 0x00267748
		public int ItemIdsLength
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

		// Token: 0x06008058 RID: 32856 RVA: 0x00269573 File Offset: 0x00267773
		public Span<int> GetItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x00269582 File Offset: 0x00267782
		public int[] GetItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x0026959C File Offset: 0x0026779C
		public int Goal(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x0600805B RID: 32859 RVA: 0x002695DC File Offset: 0x002677DC
		public int GoalLength
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

		// Token: 0x0600805C RID: 32860 RVA: 0x00269607 File Offset: 0x00267807
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x00269616 File Offset: 0x00267816
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00269630 File Offset: 0x00267830
		public int DropIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x0600805F RID: 32863 RVA: 0x00269670 File Offset: 0x00267870
		public int DropIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x0026969C File Offset: 0x0026789C
		public Span<int> GetDropIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x002696AC File Offset: 0x002678AC
		public int[] GetDropIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x06008062 RID: 32866 RVA: 0x002696C4 File Offset: 0x002678C4
		public int UnlockCondition
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

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06008063 RID: 32867 RVA: 0x00269704 File Offset: 0x00267904
		public int MaxLevelCost
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

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06008064 RID: 32868 RVA: 0x00269744 File Offset: 0x00267944
		public int MaxLevelDropId
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

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06008065 RID: 32869 RVA: 0x00269784 File Offset: 0x00267984
		public int MaxStableValue
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

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x002697C4 File Offset: 0x002679C4
		public int MaxDeliveryCount
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06008067 RID: 32871 RVA: 0x00269804 File Offset: 0x00267A04
		public int AltarMarkId
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008068 RID: 32872 RVA: 0x00269841 File Offset: 0x00267A41
		[NullableContext(1)]
		public int[] DropIds()
		{
			return this.GetDropIdsArray();
		}

		// Token: 0x06008069 RID: 32873 RVA: 0x00269849 File Offset: 0x00267A49
		[NullableContext(1)]
		public IEnumerable<int> DropIdsIter()
		{
			GiantDeliveryReward.<DropIdsIter>d__38 <DropIdsIter>d__ = new GiantDeliveryReward.<DropIdsIter>d__38(-2);
			<DropIdsIter>d__.<>3__<>4__this = this;
			return <DropIdsIter>d__;
		}

		// Token: 0x0600806A RID: 32874 RVA: 0x0026985E File Offset: 0x00267A5E
		[NullableContext(1)]
		public int[] Goal()
		{
			return this.GetGoalArray();
		}

		// Token: 0x0600806B RID: 32875 RVA: 0x00269866 File Offset: 0x00267A66
		[NullableContext(1)]
		public IEnumerable<int> GoalIter()
		{
			GiantDeliveryReward.<GoalIter>d__40 <GoalIter>d__ = new GiantDeliveryReward.<GoalIter>d__40(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x0026987B File Offset: 0x00267A7B
		[NullableContext(1)]
		public int[] ItemIds()
		{
			return this.GetItemIdsArray();
		}

		// Token: 0x0600806D RID: 32877 RVA: 0x00269883 File Offset: 0x00267A83
		[NullableContext(1)]
		public IEnumerable<int> ItemIdsIter()
		{
			GiantDeliveryReward.<ItemIdsIter>d__42 <ItemIdsIter>d__ = new GiantDeliveryReward.<ItemIdsIter>d__42(-2);
			<ItemIdsIter>d__.<>3__<>4__this = this;
			return <ItemIdsIter>d__;
		}

		// Token: 0x04005351 RID: 21329
		private Table __p;
	}
}
