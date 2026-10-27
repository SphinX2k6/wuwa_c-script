using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005105 RID: 20741
	public struct IDynamicTrafficReward : IFlatbufferObject
	{
		// Token: 0x17009720 RID: 38688
		// (get) Token: 0x060216A4 RID: 136868 RVA: 0x004A3DD3 File Offset: 0x004A1FD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060216A5 RID: 136869 RVA: 0x004A3DE0 File Offset: 0x004A1FE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060216A6 RID: 136870 RVA: 0x004A3DE8 File Offset: 0x004A1FE8
		public static IDynamicTrafficReward GetRootAsIDynamicTrafficReward(ByteBuffer _bb)
		{
			return IDynamicTrafficReward.GetRootAsIDynamicTrafficReward(_bb, default(IDynamicTrafficReward));
		}

		// Token: 0x060216A7 RID: 136871 RVA: 0x004A3E04 File Offset: 0x004A2004
		public static IDynamicTrafficReward GetRootAsIDynamicTrafficReward(ByteBuffer _bb, IDynamicTrafficReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060216A8 RID: 136872 RVA: 0x004A3E21 File Offset: 0x004A2021
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060216A9 RID: 136873 RVA: 0x004A3E30 File Offset: 0x004A2030
		public IDynamicTrafficReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009721 RID: 38689
		// (get) Token: 0x060216AA RID: 136874 RVA: 0x004A3E40 File Offset: 0x004A2040
		public EDynamicEntityRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDynamicEntityRewardType.Traffic;
				}
				return (EDynamicEntityRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009722 RID: 38690
		// (get) Token: 0x060216AB RID: 136875 RVA: 0x004A3E7C File Offset: 0x004A207C
		public int RewardId
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

		// Token: 0x060216AC RID: 136876 RVA: 0x004A3EB8 File Offset: 0x004A20B8
		public static Offset<IDynamicTrafficReward> CreateIDynamicTrafficReward(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic, int RewardId = 0)
		{
			builder.StartTable(2);
			IDynamicTrafficReward.AddRewardId(builder, RewardId);
			IDynamicTrafficReward.AddType(builder, Type);
			return IDynamicTrafficReward.EndIDynamicTrafficReward(builder);
		}

		// Token: 0x060216AD RID: 136877 RVA: 0x004A3ED5 File Offset: 0x004A20D5
		public static void StartIDynamicTrafficReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060216AE RID: 136878 RVA: 0x004A3EDE File Offset: 0x004A20DE
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060216AF RID: 136879 RVA: 0x004A3EE9 File Offset: 0x004A20E9
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x060216B0 RID: 136880 RVA: 0x004A3EF4 File Offset: 0x004A20F4
		public static Offset<IDynamicTrafficReward> EndIDynamicTrafficReward(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicTrafficReward>(builder.EndTable());
		}

		// Token: 0x060216B1 RID: 136881 RVA: 0x004A3F04 File Offset: 0x004A2104
		public IDynamicTrafficRewardT UnPack()
		{
			IDynamicTrafficRewardT dynamicTrafficRewardT = new IDynamicTrafficRewardT();
			this.UnPackTo(dynamicTrafficRewardT);
			return dynamicTrafficRewardT;
		}

		// Token: 0x060216B2 RID: 136882 RVA: 0x004A3F1F File Offset: 0x004A211F
		public void UnPackTo(IDynamicTrafficRewardT _o)
		{
			_o.Type = this.Type;
			_o.RewardId = this.RewardId;
		}

		// Token: 0x060216B3 RID: 136883 RVA: 0x004A3F3C File Offset: 0x004A213C
		public static Offset<IDynamicTrafficReward> Pack(FlatBufferBuilder builder, IDynamicTrafficRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicTrafficReward>);
			}
			return IDynamicTrafficReward.CreateIDynamicTrafficReward(builder, _o.Type, _o.RewardId);
		}

		// Token: 0x0400E171 RID: 57713
		private Table __p;
	}
}
