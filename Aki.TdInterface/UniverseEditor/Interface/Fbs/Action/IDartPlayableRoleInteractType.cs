using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006546 RID: 25926
	public struct IDartPlayableRoleInteractType : IFlatbufferObject
	{
		// Token: 0x1700C0B5 RID: 49333
		// (get) Token: 0x0602CFAA RID: 184234 RVA: 0x0062CC9E File Offset: 0x0062AE9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CFAB RID: 184235 RVA: 0x0062CCAB File Offset: 0x0062AEAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CFAC RID: 184236 RVA: 0x0062CCB4 File Offset: 0x0062AEB4
		public static IDartPlayableRoleInteractType GetRootAsIDartPlayableRoleInteractType(ByteBuffer _bb)
		{
			return IDartPlayableRoleInteractType.GetRootAsIDartPlayableRoleInteractType(_bb, default(IDartPlayableRoleInteractType));
		}

		// Token: 0x0602CFAD RID: 184237 RVA: 0x0062CCD0 File Offset: 0x0062AED0
		public static IDartPlayableRoleInteractType GetRootAsIDartPlayableRoleInteractType(ByteBuffer _bb, IDartPlayableRoleInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CFAE RID: 184238 RVA: 0x0062CCED File Offset: 0x0062AEED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CFAF RID: 184239 RVA: 0x0062CCFC File Offset: 0x0062AEFC
		public IDartPlayableRoleInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0B6 RID: 49334
		// (get) Token: 0x0602CFB0 RID: 184240 RVA: 0x0062CD0C File Offset: 0x0062AF0C
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

		// Token: 0x1700C0B7 RID: 49335
		// (get) Token: 0x0602CFB1 RID: 184241 RVA: 0x0062CD48 File Offset: 0x0062AF48
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

		// Token: 0x0602CFB2 RID: 184242 RVA: 0x0062CD84 File Offset: 0x0062AF84
		public static Offset<IDartPlayableRoleInteractType> CreateIDartPlayableRoleInteractType(FlatBufferBuilder builder, EDartInteractType Type = EDartInteractType.Machine, int CompetitorId = 0)
		{
			builder.StartTable(2);
			IDartPlayableRoleInteractType.AddCompetitorId(builder, CompetitorId);
			IDartPlayableRoleInteractType.AddType(builder, Type);
			return IDartPlayableRoleInteractType.EndIDartPlayableRoleInteractType(builder);
		}

		// Token: 0x0602CFB3 RID: 184243 RVA: 0x0062CDA1 File Offset: 0x0062AFA1
		public static void StartIDartPlayableRoleInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CFB4 RID: 184244 RVA: 0x0062CDAA File Offset: 0x0062AFAA
		public static void AddType(FlatBufferBuilder builder, EDartInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CFB5 RID: 184245 RVA: 0x0062CDB5 File Offset: 0x0062AFB5
		public static void AddCompetitorId(FlatBufferBuilder builder, int competitorId)
		{
			builder.AddInt(1, competitorId, 0);
		}

		// Token: 0x0602CFB6 RID: 184246 RVA: 0x0062CDC0 File Offset: 0x0062AFC0
		public static Offset<IDartPlayableRoleInteractType> EndIDartPlayableRoleInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IDartPlayableRoleInteractType>(builder.EndTable());
		}

		// Token: 0x0602CFB7 RID: 184247 RVA: 0x0062CDD0 File Offset: 0x0062AFD0
		public IDartPlayableRoleInteractTypeT UnPack()
		{
			IDartPlayableRoleInteractTypeT dartPlayableRoleInteractTypeT = new IDartPlayableRoleInteractTypeT();
			this.UnPackTo(dartPlayableRoleInteractTypeT);
			return dartPlayableRoleInteractTypeT;
		}

		// Token: 0x0602CFB8 RID: 184248 RVA: 0x0062CDEB File Offset: 0x0062AFEB
		public void UnPackTo(IDartPlayableRoleInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.CompetitorId = this.CompetitorId;
		}

		// Token: 0x0602CFB9 RID: 184249 RVA: 0x0062CE08 File Offset: 0x0062B008
		public static Offset<IDartPlayableRoleInteractType> Pack(FlatBufferBuilder builder, IDartPlayableRoleInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartPlayableRoleInteractType>);
			}
			return IDartPlayableRoleInteractType.CreateIDartPlayableRoleInteractType(builder, _o.Type, _o.CompetitorId);
		}

		// Token: 0x04010B94 RID: 68500
		private Table __p;
	}
}
