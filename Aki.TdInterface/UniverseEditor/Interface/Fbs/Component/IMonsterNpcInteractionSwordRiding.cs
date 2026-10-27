using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005590 RID: 21904
	public struct IMonsterNpcInteractionSwordRiding : IFlatbufferObject
	{
		// Token: 0x1700A1D5 RID: 41429
		// (get) Token: 0x0602442F RID: 148527 RVA: 0x00501D6D File Offset: 0x004FFF6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024430 RID: 148528 RVA: 0x00501D7A File Offset: 0x004FFF7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024431 RID: 148529 RVA: 0x00501D84 File Offset: 0x004FFF84
		public static IMonsterNpcInteractionSwordRiding GetRootAsIMonsterNpcInteractionSwordRiding(ByteBuffer _bb)
		{
			return IMonsterNpcInteractionSwordRiding.GetRootAsIMonsterNpcInteractionSwordRiding(_bb, default(IMonsterNpcInteractionSwordRiding));
		}

		// Token: 0x06024432 RID: 148530 RVA: 0x00501DA0 File Offset: 0x004FFFA0
		public static IMonsterNpcInteractionSwordRiding GetRootAsIMonsterNpcInteractionSwordRiding(ByteBuffer _bb, IMonsterNpcInteractionSwordRiding obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024433 RID: 148531 RVA: 0x00501DBD File Offset: 0x004FFFBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024434 RID: 148532 RVA: 0x00501DCC File Offset: 0x004FFFCC
		public IMonsterNpcInteractionSwordRiding __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1D6 RID: 41430
		// (get) Token: 0x06024435 RID: 148533 RVA: 0x00501DDC File Offset: 0x004FFFDC
		public EMonsterNpcInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return (EMonsterNpcInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024436 RID: 148534 RVA: 0x00501E18 File Offset: 0x00500018
		public static Offset<IMonsterNpcInteractionSwordRiding> CreateIMonsterNpcInteractionSwordRiding(FlatBufferBuilder builder, EMonsterNpcInteractionType Type = EMonsterNpcInteractionType.WallRun)
		{
			builder.StartTable(1);
			IMonsterNpcInteractionSwordRiding.AddType(builder, Type);
			return IMonsterNpcInteractionSwordRiding.EndIMonsterNpcInteractionSwordRiding(builder);
		}

		// Token: 0x06024437 RID: 148535 RVA: 0x00501E2E File Offset: 0x0050002E
		public static void StartIMonsterNpcInteractionSwordRiding(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024438 RID: 148536 RVA: 0x00501E37 File Offset: 0x00500037
		public static void AddType(FlatBufferBuilder builder, EMonsterNpcInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024439 RID: 148537 RVA: 0x00501E42 File Offset: 0x00500042
		public static Offset<IMonsterNpcInteractionSwordRiding> EndIMonsterNpcInteractionSwordRiding(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterNpcInteractionSwordRiding>(builder.EndTable());
		}

		// Token: 0x0602443A RID: 148538 RVA: 0x00501E50 File Offset: 0x00500050
		public IMonsterNpcInteractionSwordRidingT UnPack()
		{
			IMonsterNpcInteractionSwordRidingT monsterNpcInteractionSwordRidingT = new IMonsterNpcInteractionSwordRidingT();
			this.UnPackTo(monsterNpcInteractionSwordRidingT);
			return monsterNpcInteractionSwordRidingT;
		}

		// Token: 0x0602443B RID: 148539 RVA: 0x00501E6B File Offset: 0x0050006B
		public void UnPackTo(IMonsterNpcInteractionSwordRidingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602443C RID: 148540 RVA: 0x00501E7C File Offset: 0x0050007C
		public static Offset<IMonsterNpcInteractionSwordRiding> Pack(FlatBufferBuilder builder, IMonsterNpcInteractionSwordRidingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterNpcInteractionSwordRiding>);
			}
			return IMonsterNpcInteractionSwordRiding.CreateIMonsterNpcInteractionSwordRiding(builder, _o.Type);
		}

		// Token: 0x0400E8C1 RID: 59585
		private Table __p;
	}
}
