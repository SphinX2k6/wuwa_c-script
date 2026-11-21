using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C50 RID: 31824
	public struct ITrapDefensePlayerOperationConstructTrap : IFlatbufferObject
	{
		// Token: 0x1700EE42 RID: 60994
		// (get) Token: 0x060395DB RID: 234971 RVA: 0x007BEE20 File Offset: 0x007BD020
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060395DC RID: 234972 RVA: 0x007BEE2D File Offset: 0x007BD02D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060395DD RID: 234973 RVA: 0x007BEE34 File Offset: 0x007BD034
		public static ITrapDefensePlayerOperationConstructTrap GetRootAsITrapDefensePlayerOperationConstructTrap(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationConstructTrap.GetRootAsITrapDefensePlayerOperationConstructTrap(_bb, default(ITrapDefensePlayerOperationConstructTrap));
		}

		// Token: 0x060395DE RID: 234974 RVA: 0x007BEE50 File Offset: 0x007BD050
		public static ITrapDefensePlayerOperationConstructTrap GetRootAsITrapDefensePlayerOperationConstructTrap(ByteBuffer _bb, ITrapDefensePlayerOperationConstructTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060395DF RID: 234975 RVA: 0x007BEE6D File Offset: 0x007BD06D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060395E0 RID: 234976 RVA: 0x007BEE7C File Offset: 0x007BD07C
		public ITrapDefensePlayerOperationConstructTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE43 RID: 60995
		// (get) Token: 0x060395E1 RID: 234977 RVA: 0x007BEE8C File Offset: 0x007BD08C
		public ETrapDefensePlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefensePlayerOperationType.SpawnMonster;
				}
				return (ETrapDefensePlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060395E2 RID: 234978 RVA: 0x007BEEC8 File Offset: 0x007BD0C8
		public static Offset<ITrapDefensePlayerOperationConstructTrap> CreateITrapDefensePlayerOperationConstructTrap(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationConstructTrap.AddType(builder, Type);
			return ITrapDefensePlayerOperationConstructTrap.EndITrapDefensePlayerOperationConstructTrap(builder);
		}

		// Token: 0x060395E3 RID: 234979 RVA: 0x007BEEDE File Offset: 0x007BD0DE
		public static void StartITrapDefensePlayerOperationConstructTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060395E4 RID: 234980 RVA: 0x007BEEE7 File Offset: 0x007BD0E7
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060395E5 RID: 234981 RVA: 0x007BEEF2 File Offset: 0x007BD0F2
		public static Offset<ITrapDefensePlayerOperationConstructTrap> EndITrapDefensePlayerOperationConstructTrap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationConstructTrap>(builder.EndTable());
		}

		// Token: 0x060395E6 RID: 234982 RVA: 0x007BEF00 File Offset: 0x007BD100
		public ITrapDefensePlayerOperationConstructTrapT UnPack()
		{
			ITrapDefensePlayerOperationConstructTrapT trapDefensePlayerOperationConstructTrapT = new ITrapDefensePlayerOperationConstructTrapT();
			this.UnPackTo(trapDefensePlayerOperationConstructTrapT);
			return trapDefensePlayerOperationConstructTrapT;
		}

		// Token: 0x060395E7 RID: 234983 RVA: 0x007BEF1B File Offset: 0x007BD11B
		public void UnPackTo(ITrapDefensePlayerOperationConstructTrapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060395E8 RID: 234984 RVA: 0x007BEF2C File Offset: 0x007BD12C
		public static Offset<ITrapDefensePlayerOperationConstructTrap> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationConstructTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationConstructTrap>);
			}
			return ITrapDefensePlayerOperationConstructTrap.CreateITrapDefensePlayerOperationConstructTrap(builder, _o.Type);
		}

		// Token: 0x0401330E RID: 78606
		private Table __p;
	}
}
