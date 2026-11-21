using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA8 RID: 27560
	public struct IDartChampionOwnerInteractType : IFlatbufferObject
	{
		// Token: 0x1700CA32 RID: 51762
		// (get) Token: 0x0602F6E1 RID: 194273 RVA: 0x0067858E File Offset: 0x0067678E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6E2 RID: 194274 RVA: 0x0067859B File Offset: 0x0067679B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6E3 RID: 194275 RVA: 0x006785A4 File Offset: 0x006767A4
		public static IDartChampionOwnerInteractType GetRootAsIDartChampionOwnerInteractType(ByteBuffer _bb)
		{
			return IDartChampionOwnerInteractType.GetRootAsIDartChampionOwnerInteractType(_bb, default(IDartChampionOwnerInteractType));
		}

		// Token: 0x0602F6E4 RID: 194276 RVA: 0x006785C0 File Offset: 0x006767C0
		public static IDartChampionOwnerInteractType GetRootAsIDartChampionOwnerInteractType(ByteBuffer _bb, IDartChampionOwnerInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6E5 RID: 194277 RVA: 0x006785DD File Offset: 0x006767DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6E6 RID: 194278 RVA: 0x006785EC File Offset: 0x006767EC
		public IDartChampionOwnerInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA33 RID: 51763
		// (get) Token: 0x0602F6E7 RID: 194279 RVA: 0x006785FC File Offset: 0x006767FC
		public EDartInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartInteractType.Machine;
				}
				return (EDartInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA34 RID: 51764
		// (get) Token: 0x0602F6E8 RID: 194280 RVA: 0x00678638 File Offset: 0x00676838
		public int CompetitorId
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

		// Token: 0x0602F6E9 RID: 194281 RVA: 0x00678674 File Offset: 0x00676874
		public static Offset<IDartChampionOwnerInteractType> CreateIDartChampionOwnerInteractType(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine, int CompetitorId = 0)
		{
			builder.StartTable(2);
			IDartChampionOwnerInteractType.AddCompetitorId(builder, CompetitorId);
			IDartChampionOwnerInteractType.AddType(builder, Type);
			return IDartChampionOwnerInteractType.EndIDartChampionOwnerInteractType(builder);
		}

		// Token: 0x0602F6EA RID: 194282 RVA: 0x00678691 File Offset: 0x00676891
		public static void StartIDartChampionOwnerInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F6EB RID: 194283 RVA: 0x0067869A File Offset: 0x0067689A
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F6EC RID: 194284 RVA: 0x006786A5 File Offset: 0x006768A5
		public static void AddCompetitorId(FlatBufferBuilder builder, int competitorId)
		{
			builder.AddInt(1, competitorId, 0);
		}

		// Token: 0x0602F6ED RID: 194285 RVA: 0x006786B0 File Offset: 0x006768B0
		public static Offset<IDartChampionOwnerInteractType> EndIDartChampionOwnerInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IDartChampionOwnerInteractType>(builder.EndTable());
		}

		// Token: 0x0602F6EE RID: 194286 RVA: 0x006786C0 File Offset: 0x006768C0
		public IDartChampionOwnerInteractTypeT UnPack()
		{
			IDartChampionOwnerInteractTypeT dartChampionOwnerInteractTypeT = new IDartChampionOwnerInteractTypeT();
			this.UnPackTo(dartChampionOwnerInteractTypeT);
			return dartChampionOwnerInteractTypeT;
		}

		// Token: 0x0602F6EF RID: 194287 RVA: 0x006786DB File Offset: 0x006768DB
		public void UnPackTo(IDartChampionOwnerInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.CompetitorId = this.CompetitorId;
		}

		// Token: 0x0602F6F0 RID: 194288 RVA: 0x006786F8 File Offset: 0x006768F8
		public static Offset<IDartChampionOwnerInteractType> Pack(FlatBufferBuilder builder, IDartChampionOwnerInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartChampionOwnerInteractType>);
			}
			return IDartChampionOwnerInteractType.CreateIDartChampionOwnerInteractType(builder, _o.Type, _o.CompetitorId);
		}

		// Token: 0x0401199A RID: 72090
		private Table __p;
	}
}
