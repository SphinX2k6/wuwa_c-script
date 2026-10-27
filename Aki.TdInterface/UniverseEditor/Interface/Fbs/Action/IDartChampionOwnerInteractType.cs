using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006537 RID: 25911
	public struct IDartChampionOwnerInteractType : IFlatbufferObject
	{
		// Token: 0x1700C09B RID: 49307
		// (get) Token: 0x0602CF2D RID: 184109 RVA: 0x0062BEE1 File Offset: 0x0062A0E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF2E RID: 184110 RVA: 0x0062BEEE File Offset: 0x0062A0EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF2F RID: 184111 RVA: 0x0062BEF8 File Offset: 0x0062A0F8
		public static IDartChampionOwnerInteractType GetRootAsIDartChampionOwnerInteractType(ByteBuffer _bb)
		{
			return IDartChampionOwnerInteractType.GetRootAsIDartChampionOwnerInteractType(_bb, default(IDartChampionOwnerInteractType));
		}

		// Token: 0x0602CF30 RID: 184112 RVA: 0x0062BF14 File Offset: 0x0062A114
		public static IDartChampionOwnerInteractType GetRootAsIDartChampionOwnerInteractType(ByteBuffer _bb, IDartChampionOwnerInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF31 RID: 184113 RVA: 0x0062BF31 File Offset: 0x0062A131
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF32 RID: 184114 RVA: 0x0062BF40 File Offset: 0x0062A140
		public IDartChampionOwnerInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C09C RID: 49308
		// (get) Token: 0x0602CF33 RID: 184115 RVA: 0x0062BF50 File Offset: 0x0062A150
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

		// Token: 0x1700C09D RID: 49309
		// (get) Token: 0x0602CF34 RID: 184116 RVA: 0x0062BF8C File Offset: 0x0062A18C
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

		// Token: 0x0602CF35 RID: 184117 RVA: 0x0062BFC8 File Offset: 0x0062A1C8
		public static Offset<IDartChampionOwnerInteractType> CreateIDartChampionOwnerInteractType(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine, int CompetitorId = 0)
		{
			builder.StartTable(2);
			IDartChampionOwnerInteractType.AddCompetitorId(builder, CompetitorId);
			IDartChampionOwnerInteractType.AddType(builder, Type);
			return IDartChampionOwnerInteractType.EndIDartChampionOwnerInteractType(builder);
		}

		// Token: 0x0602CF36 RID: 184118 RVA: 0x0062BFE5 File Offset: 0x0062A1E5
		public static void StartIDartChampionOwnerInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CF37 RID: 184119 RVA: 0x0062BFEE File Offset: 0x0062A1EE
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF38 RID: 184120 RVA: 0x0062BFF9 File Offset: 0x0062A1F9
		public static void AddCompetitorId(FlatBufferBuilder builder, int competitorId)
		{
			builder.AddInt(1, competitorId, 0);
		}

		// Token: 0x0602CF39 RID: 184121 RVA: 0x0062C004 File Offset: 0x0062A204
		public static Offset<IDartChampionOwnerInteractType> EndIDartChampionOwnerInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IDartChampionOwnerInteractType>(builder.EndTable());
		}

		// Token: 0x0602CF3A RID: 184122 RVA: 0x0062C014 File Offset: 0x0062A214
		public IDartChampionOwnerInteractTypeT UnPack()
		{
			IDartChampionOwnerInteractTypeT dartChampionOwnerInteractTypeT = new IDartChampionOwnerInteractTypeT();
			this.UnPackTo(dartChampionOwnerInteractTypeT);
			return dartChampionOwnerInteractTypeT;
		}

		// Token: 0x0602CF3B RID: 184123 RVA: 0x0062C02F File Offset: 0x0062A22F
		public void UnPackTo(IDartChampionOwnerInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.CompetitorId = this.CompetitorId;
		}

		// Token: 0x0602CF3C RID: 184124 RVA: 0x0062C04C File Offset: 0x0062A24C
		public static Offset<IDartChampionOwnerInteractType> Pack(FlatBufferBuilder builder, IDartChampionOwnerInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartChampionOwnerInteractType>);
			}
			return IDartChampionOwnerInteractType.CreateIDartChampionOwnerInteractType(builder, _o.Type, _o.CompetitorId);
		}

		// Token: 0x04010B7E RID: 68478
		private Table __p;
	}
}
