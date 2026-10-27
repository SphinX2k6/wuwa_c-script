using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200498B RID: 18827
	public struct ICheckBvbActivityRank : IFlatbufferObject
	{
		// Token: 0x170087FD RID: 34813
		// (get) Token: 0x0601D5AC RID: 120236 RVA: 0x004238C0 File Offset: 0x00421AC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D5AD RID: 120237 RVA: 0x004238CD File Offset: 0x00421ACD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D5AE RID: 120238 RVA: 0x004238D4 File Offset: 0x00421AD4
		public static ICheckBvbActivityRank GetRootAsICheckBvbActivityRank(ByteBuffer _bb)
		{
			return ICheckBvbActivityRank.GetRootAsICheckBvbActivityRank(_bb, default(ICheckBvbActivityRank));
		}

		// Token: 0x0601D5AF RID: 120239 RVA: 0x004238F0 File Offset: 0x00421AF0
		public static ICheckBvbActivityRank GetRootAsICheckBvbActivityRank(ByteBuffer _bb, ICheckBvbActivityRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D5B0 RID: 120240 RVA: 0x0042390D File Offset: 0x00421B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D5B1 RID: 120241 RVA: 0x0042391C File Offset: 0x00421B1C
		public ICheckBvbActivityRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087FE RID: 34814
		// (get) Token: 0x0601D5B2 RID: 120242 RVA: 0x0042392C File Offset: 0x00421B2C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170087FF RID: 34815
		// (get) Token: 0x0601D5B3 RID: 120243 RVA: 0x00423968 File Offset: 0x00421B68
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008800 RID: 34816
		// (get) Token: 0x0601D5B4 RID: 120244 RVA: 0x004239A4 File Offset: 0x00421BA4
		public int Rank
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

		// Token: 0x0601D5B5 RID: 120245 RVA: 0x004239E0 File Offset: 0x00421BE0
		public static Offset<ICheckBvbActivityRank> CreateICheckBvbActivityRank(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Rank = 0)
		{
			builder.StartTable(3);
			ICheckBvbActivityRank.AddRank(builder, Rank);
			ICheckBvbActivityRank.AddCompare(builder, Compare);
			ICheckBvbActivityRank.AddType(builder, Type);
			return ICheckBvbActivityRank.EndICheckBvbActivityRank(builder);
		}

		// Token: 0x0601D5B6 RID: 120246 RVA: 0x00423A04 File Offset: 0x00421C04
		public static void StartICheckBvbActivityRank(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D5B7 RID: 120247 RVA: 0x00423A0D File Offset: 0x00421C0D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D5B8 RID: 120248 RVA: 0x00423A18 File Offset: 0x00421C18
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601D5B9 RID: 120249 RVA: 0x00423A23 File Offset: 0x00421C23
		public static void AddRank(FlatBufferBuilder builder, int rank)
		{
			builder.AddInt(2, rank, 0);
		}

		// Token: 0x0601D5BA RID: 120250 RVA: 0x00423A2E File Offset: 0x00421C2E
		public static Offset<ICheckBvbActivityRank> EndICheckBvbActivityRank(FlatBufferBuilder builder)
		{
			return new Offset<ICheckBvbActivityRank>(builder.EndTable());
		}

		// Token: 0x0601D5BB RID: 120251 RVA: 0x00423A3C File Offset: 0x00421C3C
		public ICheckBvbActivityRankT UnPack()
		{
			ICheckBvbActivityRankT checkBvbActivityRankT = new ICheckBvbActivityRankT();
			this.UnPackTo(checkBvbActivityRankT);
			return checkBvbActivityRankT;
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x00423A57 File Offset: 0x00421C57
		public void UnPackTo(ICheckBvbActivityRankT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Rank = this.Rank;
		}

		// Token: 0x0601D5BD RID: 120253 RVA: 0x00423A80 File Offset: 0x00421C80
		public static Offset<ICheckBvbActivityRank> Pack(FlatBufferBuilder builder, ICheckBvbActivityRankT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckBvbActivityRank>);
			}
			return ICheckBvbActivityRank.CreateICheckBvbActivityRank(builder, _o.Type, _o.Compare, _o.Rank);
		}

		// Token: 0x0400D199 RID: 53657
		private Table __p;
	}
}
