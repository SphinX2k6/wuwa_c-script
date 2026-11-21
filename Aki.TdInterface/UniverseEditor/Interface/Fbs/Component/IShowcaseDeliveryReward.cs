using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F18 RID: 24344
	public struct IShowcaseDeliveryReward : IFlatbufferObject
	{
		// Token: 0x1700B411 RID: 46097
		// (get) Token: 0x06028DCA RID: 167370 RVA: 0x005956D4 File Offset: 0x005938D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028DCB RID: 167371 RVA: 0x005956E1 File Offset: 0x005938E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028DCC RID: 167372 RVA: 0x005956E8 File Offset: 0x005938E8
		public static IShowcaseDeliveryReward GetRootAsIShowcaseDeliveryReward(ByteBuffer _bb)
		{
			return IShowcaseDeliveryReward.GetRootAsIShowcaseDeliveryReward(_bb, default(IShowcaseDeliveryReward));
		}

		// Token: 0x06028DCD RID: 167373 RVA: 0x00595704 File Offset: 0x00593904
		public static IShowcaseDeliveryReward GetRootAsIShowcaseDeliveryReward(ByteBuffer _bb, IShowcaseDeliveryReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028DCE RID: 167374 RVA: 0x00595721 File Offset: 0x00593921
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028DCF RID: 167375 RVA: 0x00595730 File Offset: 0x00593930
		public IShowcaseDeliveryReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B412 RID: 46098
		// (get) Token: 0x06028DD0 RID: 167376 RVA: 0x00595740 File Offset: 0x00593940
		public int AchievedDollCount
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

		// Token: 0x1700B413 RID: 46099
		// (get) Token: 0x06028DD1 RID: 167377 RVA: 0x0059577C File Offset: 0x0059397C
		public int DropId
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

		// Token: 0x06028DD2 RID: 167378 RVA: 0x005957B8 File Offset: 0x005939B8
		public static Offset<IShowcaseDeliveryReward> CreateIShowcaseDeliveryReward(FlatBufferBuilder builder, int AchievedDollCount = 0, int DropId = 0)
		{
			builder.StartTable(2);
			IShowcaseDeliveryReward.AddDropId(builder, DropId);
			IShowcaseDeliveryReward.AddAchievedDollCount(builder, AchievedDollCount);
			return IShowcaseDeliveryReward.EndIShowcaseDeliveryReward(builder);
		}

		// Token: 0x06028DD3 RID: 167379 RVA: 0x005957D5 File Offset: 0x005939D5
		public static void StartIShowcaseDeliveryReward(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06028DD4 RID: 167380 RVA: 0x005957DE File Offset: 0x005939DE
		public static void AddAchievedDollCount(FlatBufferBuilder builder, int achievedDollCount)
		{
			builder.AddInt(0, achievedDollCount, 0);
		}

		// Token: 0x06028DD5 RID: 167381 RVA: 0x005957E9 File Offset: 0x005939E9
		public static void AddDropId(FlatBufferBuilder builder, int dropId)
		{
			builder.AddInt(1, dropId, 0);
		}

		// Token: 0x06028DD6 RID: 167382 RVA: 0x005957F4 File Offset: 0x005939F4
		public static Offset<IShowcaseDeliveryReward> EndIShowcaseDeliveryReward(FlatBufferBuilder builder)
		{
			return new Offset<IShowcaseDeliveryReward>(builder.EndTable());
		}

		// Token: 0x06028DD7 RID: 167383 RVA: 0x00595804 File Offset: 0x00593A04
		public IShowcaseDeliveryRewardT UnPack()
		{
			IShowcaseDeliveryRewardT showcaseDeliveryRewardT = new IShowcaseDeliveryRewardT();
			this.UnPackTo(showcaseDeliveryRewardT);
			return showcaseDeliveryRewardT;
		}

		// Token: 0x06028DD8 RID: 167384 RVA: 0x0059581F File Offset: 0x00593A1F
		public void UnPackTo(IShowcaseDeliveryRewardT _o)
		{
			_o.AchievedDollCount = this.AchievedDollCount;
			_o.DropId = this.DropId;
		}

		// Token: 0x06028DD9 RID: 167385 RVA: 0x0059583C File Offset: 0x00593A3C
		public static Offset<IShowcaseDeliveryReward> Pack(FlatBufferBuilder builder, IShowcaseDeliveryRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowcaseDeliveryReward>);
			}
			return IShowcaseDeliveryReward.CreateIShowcaseDeliveryReward(builder, _o.AchievedDollCount, _o.DropId);
		}

		// Token: 0x0400FBA2 RID: 64418
		private Table __p;
	}
}
