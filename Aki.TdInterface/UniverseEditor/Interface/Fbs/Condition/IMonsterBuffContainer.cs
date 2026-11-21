using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200514E RID: 20814
	public struct IMonsterBuffContainer : IFlatbufferObject
	{
		// Token: 0x17009529 RID: 38185
		// (get) Token: 0x06020BE1 RID: 134113 RVA: 0x00489232 File Offset: 0x00487432
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BE2 RID: 134114 RVA: 0x0048923F File Offset: 0x0048743F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BE3 RID: 134115 RVA: 0x00489248 File Offset: 0x00487448
		public static IMonsterBuffContainer GetRootAsIMonsterBuffContainer(ByteBuffer _bb)
		{
			return IMonsterBuffContainer.GetRootAsIMonsterBuffContainer(_bb, default(IMonsterBuffContainer));
		}

		// Token: 0x06020BE4 RID: 134116 RVA: 0x00489264 File Offset: 0x00487464
		public static IMonsterBuffContainer GetRootAsIMonsterBuffContainer(ByteBuffer _bb, IMonsterBuffContainer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020BE5 RID: 134117 RVA: 0x00489281 File Offset: 0x00487481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020BE6 RID: 134118 RVA: 0x00489290 File Offset: 0x00487490
		public IMonsterBuffContainer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700952A RID: 38186
		// (get) Token: 0x06020BE7 RID: 134119 RVA: 0x004892A0 File Offset: 0x004874A0
		public ETargetBuffContainer Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetBuffContainer.Monster;
				}
				return (ETargetBuffContainer)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700952B RID: 38187
		// (get) Token: 0x06020BE8 RID: 134120 RVA: 0x004892DC File Offset: 0x004874DC
		public int MonsterEntityId
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

		// Token: 0x06020BE9 RID: 134121 RVA: 0x00489318 File Offset: 0x00487518
		public static Offset<IMonsterBuffContainer> CreateIMonsterBuffContainer(FlatBufferBuilder builder, ETargetBuffContainer Type = ETargetBuffContainer.Monster, int MonsterEntityId = 0)
		{
			builder.StartTable(2);
			IMonsterBuffContainer.AddMonsterEntityId(builder, MonsterEntityId);
			IMonsterBuffContainer.AddType(builder, Type);
			return IMonsterBuffContainer.EndIMonsterBuffContainer(builder);
		}

		// Token: 0x06020BEA RID: 134122 RVA: 0x00489335 File Offset: 0x00487535
		public static void StartIMonsterBuffContainer(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020BEB RID: 134123 RVA: 0x0048933E File Offset: 0x0048753E
		public static void AddType(FlatBufferBuilder builder, ETargetBuffContainer type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020BEC RID: 134124 RVA: 0x00489349 File Offset: 0x00487549
		public static void AddMonsterEntityId(FlatBufferBuilder builder, int monsterEntityId)
		{
			builder.AddInt(1, monsterEntityId, 0);
		}

		// Token: 0x06020BED RID: 134125 RVA: 0x00489354 File Offset: 0x00487554
		public static Offset<IMonsterBuffContainer> EndIMonsterBuffContainer(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterBuffContainer>(builder.EndTable());
		}

		// Token: 0x06020BEE RID: 134126 RVA: 0x00489364 File Offset: 0x00487564
		public IMonsterBuffContainerT UnPack()
		{
			IMonsterBuffContainerT monsterBuffContainerT = new IMonsterBuffContainerT();
			this.UnPackTo(monsterBuffContainerT);
			return monsterBuffContainerT;
		}

		// Token: 0x06020BEF RID: 134127 RVA: 0x0048937F File Offset: 0x0048757F
		public void UnPackTo(IMonsterBuffContainerT _o)
		{
			_o.Type = this.Type;
			_o.MonsterEntityId = this.MonsterEntityId;
		}

		// Token: 0x06020BF0 RID: 134128 RVA: 0x0048939C File Offset: 0x0048759C
		public static Offset<IMonsterBuffContainer> Pack(FlatBufferBuilder builder, IMonsterBuffContainerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterBuffContainer>);
			}
			return IMonsterBuffContainer.CreateIMonsterBuffContainer(builder, _o.Type, _o.MonsterEntityId);
		}

		// Token: 0x0400E126 RID: 57638
		private Table __p;
	}
}
