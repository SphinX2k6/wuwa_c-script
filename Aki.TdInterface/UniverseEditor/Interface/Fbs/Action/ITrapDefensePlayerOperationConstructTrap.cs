using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200745D RID: 29789
	public struct ITrapDefensePlayerOperationConstructTrap : IFlatbufferObject
	{
		// Token: 0x1700E225 RID: 57893
		// (get) Token: 0x060361F2 RID: 221682 RVA: 0x0075C0F4 File Offset: 0x0075A2F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060361F3 RID: 221683 RVA: 0x0075C101 File Offset: 0x0075A301
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060361F4 RID: 221684 RVA: 0x0075C108 File Offset: 0x0075A308
		public static ITrapDefensePlayerOperationConstructTrap GetRootAsITrapDefensePlayerOperationConstructTrap(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationConstructTrap.GetRootAsITrapDefensePlayerOperationConstructTrap(_bb, default(ITrapDefensePlayerOperationConstructTrap));
		}

		// Token: 0x060361F5 RID: 221685 RVA: 0x0075C124 File Offset: 0x0075A324
		public static ITrapDefensePlayerOperationConstructTrap GetRootAsITrapDefensePlayerOperationConstructTrap(ByteBuffer _bb, ITrapDefensePlayerOperationConstructTrap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060361F6 RID: 221686 RVA: 0x0075C141 File Offset: 0x0075A341
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060361F7 RID: 221687 RVA: 0x0075C150 File Offset: 0x0075A350
		public ITrapDefensePlayerOperationConstructTrap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E226 RID: 57894
		// (get) Token: 0x060361F8 RID: 221688 RVA: 0x0075C160 File Offset: 0x0075A360
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

		// Token: 0x060361F9 RID: 221689 RVA: 0x0075C19C File Offset: 0x0075A39C
		public static Offset<ITrapDefensePlayerOperationConstructTrap> CreateITrapDefensePlayerOperationConstructTrap(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationConstructTrap.AddType(builder, Type);
			return ITrapDefensePlayerOperationConstructTrap.EndITrapDefensePlayerOperationConstructTrap(builder);
		}

		// Token: 0x060361FA RID: 221690 RVA: 0x0075C1B2 File Offset: 0x0075A3B2
		public static void StartITrapDefensePlayerOperationConstructTrap(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060361FB RID: 221691 RVA: 0x0075C1BB File Offset: 0x0075A3BB
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060361FC RID: 221692 RVA: 0x0075C1C6 File Offset: 0x0075A3C6
		public static Offset<ITrapDefensePlayerOperationConstructTrap> EndITrapDefensePlayerOperationConstructTrap(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationConstructTrap>(builder.EndTable());
		}

		// Token: 0x060361FD RID: 221693 RVA: 0x0075C1D4 File Offset: 0x0075A3D4
		public ITrapDefensePlayerOperationConstructTrapT UnPack()
		{
			ITrapDefensePlayerOperationConstructTrapT trapDefensePlayerOperationConstructTrapT = new ITrapDefensePlayerOperationConstructTrapT();
			this.UnPackTo(trapDefensePlayerOperationConstructTrapT);
			return trapDefensePlayerOperationConstructTrapT;
		}

		// Token: 0x060361FE RID: 221694 RVA: 0x0075C1EF File Offset: 0x0075A3EF
		public void UnPackTo(ITrapDefensePlayerOperationConstructTrapT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060361FF RID: 221695 RVA: 0x0075C200 File Offset: 0x0075A400
		public static Offset<ITrapDefensePlayerOperationConstructTrap> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationConstructTrapT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationConstructTrap>);
			}
			return ITrapDefensePlayerOperationConstructTrap.CreateITrapDefensePlayerOperationConstructTrap(builder, _o.Type);
		}

		// Token: 0x040122E7 RID: 74471
		private Table __p;
	}
}
