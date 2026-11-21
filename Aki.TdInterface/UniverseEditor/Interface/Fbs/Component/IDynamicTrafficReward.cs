using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566A RID: 22122
	public struct IDynamicTrafficReward : IFlatbufferObject
	{
		// Token: 0x17009F0D RID: 40717
		// (get) Token: 0x060235F8 RID: 144888 RVA: 0x004DDD5F File Offset: 0x004DBF5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060235F9 RID: 144889 RVA: 0x004DDD6C File Offset: 0x004DBF6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060235FA RID: 144890 RVA: 0x004DDD74 File Offset: 0x004DBF74
		public static IDynamicTrafficReward GetRootAsIDynamicTrafficReward(ByteBuffer _bb)
		{
			return IDynamicTrafficReward.GetRootAsIDynamicTrafficReward(_bb, default(IDynamicTrafficReward));
		}

		// Token: 0x060235FB RID: 144891 RVA: 0x004DDD90 File Offset: 0x004DBF90
		public static IDynamicTrafficReward GetRootAsIDynamicTrafficReward(ByteBuffer _bb, IDynamicTrafficReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060235FC RID: 144892 RVA: 0x004DDDAD File Offset: 0x004DBFAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060235FD RID: 144893 RVA: 0x004DDDBC File Offset: 0x004DBFBC
		public IDynamicTrafficReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F0E RID: 40718
		// (get) Token: 0x060235FE RID: 144894 RVA: 0x004DDDCC File Offset: 0x004DBFCC
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

		// Token: 0x17009F0F RID: 40719
		// (get) Token: 0x060235FF RID: 144895 RVA: 0x004DDE08 File Offset: 0x004DC008
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

		// Token: 0x06023600 RID: 144896 RVA: 0x004DDE44 File Offset: 0x004DC044
		public static Offset<IDynamicTrafficReward> CreateIDynamicTrafficReward(FlatBufferBuilder builder, EDynamicEntityRewardType Type = EDynamicEntityRewardType.Traffic, int RewardId = 0)
		{
			builder.StartTable(2);
			IDynamicTrafficReward.AddRewardId(builder, RewardId);
			IDynamicTrafficReward.AddType(builder, Type);
			return IDynamicTrafficReward.EndIDynamicTrafficReward(builder);
		}

		// Token: 0x06023601 RID: 144897 RVA: 0x004DDE61 File Offset: 0x004DC061
		public static void StartIDynamicTrafficReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06023602 RID: 144898 RVA: 0x004DDE6A File Offset: 0x004DC06A
		public static void AddType(FlatBufferBuilder builder, EDynamicEntityRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023603 RID: 144899 RVA: 0x004DDE75 File Offset: 0x004DC075
		public static void AddRewardId(FlatBufferBuilder builder, int rewardId)
		{
			builder.AddInt(1, rewardId, 0);
		}

		// Token: 0x06023604 RID: 144900 RVA: 0x004DDE80 File Offset: 0x004DC080
		public static Offset<IDynamicTrafficReward> EndIDynamicTrafficReward(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicTrafficReward>(builder.EndTable());
		}

		// Token: 0x06023605 RID: 144901 RVA: 0x004DDE90 File Offset: 0x004DC090
		public IDynamicTrafficRewardT UnPack()
		{
			IDynamicTrafficRewardT dynamicTrafficRewardT = new IDynamicTrafficRewardT();
			this.UnPackTo(dynamicTrafficRewardT);
			return dynamicTrafficRewardT;
		}

		// Token: 0x06023606 RID: 144902 RVA: 0x004DDEAB File Offset: 0x004DC0AB
		public void UnPackTo(IDynamicTrafficRewardT _o)
		{
			_o.Type = this.Type;
			_o.RewardId = this.RewardId;
		}

		// Token: 0x06023607 RID: 144903 RVA: 0x004DDEC8 File Offset: 0x004DC0C8
		public static Offset<IDynamicTrafficReward> Pack(FlatBufferBuilder builder, IDynamicTrafficRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicTrafficReward>);
			}
			return IDynamicTrafficReward.CreateIDynamicTrafficReward(builder, _o.Type, _o.RewardId);
		}

		// Token: 0x0400ED6E RID: 60782
		private Table __p;
	}
}
