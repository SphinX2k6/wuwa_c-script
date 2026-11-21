using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B01 RID: 23297
	public struct IMonsterCombatInteractionConfig : IFlatbufferObject
	{
		// Token: 0x1700AA06 RID: 43526
		// (get) Token: 0x06026482 RID: 156802 RVA: 0x0053EAFE File Offset: 0x0053CCFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026483 RID: 156803 RVA: 0x0053EB0B File Offset: 0x0053CD0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026484 RID: 156804 RVA: 0x0053EB14 File Offset: 0x0053CD14
		public static IMonsterCombatInteractionConfig GetRootAsIMonsterCombatInteractionConfig(ByteBuffer _bb)
		{
			return IMonsterCombatInteractionConfig.GetRootAsIMonsterCombatInteractionConfig(_bb, default(IMonsterCombatInteractionConfig));
		}

		// Token: 0x06026485 RID: 156805 RVA: 0x0053EB30 File Offset: 0x0053CD30
		public static IMonsterCombatInteractionConfig GetRootAsIMonsterCombatInteractionConfig(ByteBuffer _bb, IMonsterCombatInteractionConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026486 RID: 156806 RVA: 0x0053EB4D File Offset: 0x0053CD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026487 RID: 156807 RVA: 0x0053EB5C File Offset: 0x0053CD5C
		public IMonsterCombatInteractionConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA07 RID: 43527
		// (get) Token: 0x06026488 RID: 156808 RVA: 0x0053EB6C File Offset: 0x0053CD6C
		public EMonsterCombatInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterCombatInteractionType.WaterBoxStagnation;
				}
				return (EMonsterCombatInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026489 RID: 156809 RVA: 0x0053EBA8 File Offset: 0x0053CDA8
		public static Offset<IMonsterCombatInteractionConfig> CreateIMonsterCombatInteractionConfig(FlatBufferBuilder builder, EMonsterCombatInteractionType Type = EMonsterCombatInteractionType.WaterBoxStagnation)
		{
			builder.StartTable(1);
			IMonsterCombatInteractionConfig.AddType(builder, Type);
			return IMonsterCombatInteractionConfig.EndIMonsterCombatInteractionConfig(builder);
		}

		// Token: 0x0602648A RID: 156810 RVA: 0x0053EBBE File Offset: 0x0053CDBE
		public static void StartIMonsterCombatInteractionConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602648B RID: 156811 RVA: 0x0053EBC7 File Offset: 0x0053CDC7
		public static void AddType(FlatBufferBuilder builder, EMonsterCombatInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602648C RID: 156812 RVA: 0x0053EBD2 File Offset: 0x0053CDD2
		public static Offset<IMonsterCombatInteractionConfig> EndIMonsterCombatInteractionConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterCombatInteractionConfig>(builder.EndTable());
		}

		// Token: 0x0602648D RID: 156813 RVA: 0x0053EBE0 File Offset: 0x0053CDE0
		public IMonsterCombatInteractionConfigT UnPack()
		{
			IMonsterCombatInteractionConfigT monsterCombatInteractionConfigT = new IMonsterCombatInteractionConfigT();
			this.UnPackTo(monsterCombatInteractionConfigT);
			return monsterCombatInteractionConfigT;
		}

		// Token: 0x0602648E RID: 156814 RVA: 0x0053EBFB File Offset: 0x0053CDFB
		public void UnPackTo(IMonsterCombatInteractionConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602648F RID: 156815 RVA: 0x0053EC0C File Offset: 0x0053CE0C
		public static Offset<IMonsterCombatInteractionConfig> Pack(FlatBufferBuilder builder, IMonsterCombatInteractionConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterCombatInteractionConfig>);
			}
			return IMonsterCombatInteractionConfig.CreateIMonsterCombatInteractionConfig(builder, _o.Type);
		}

		// Token: 0x0400F4E4 RID: 62692
		private Table __p;
	}
}
