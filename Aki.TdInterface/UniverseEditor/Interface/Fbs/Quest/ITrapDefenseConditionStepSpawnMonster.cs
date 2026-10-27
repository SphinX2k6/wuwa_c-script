using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004235 RID: 16949
	public struct ITrapDefenseConditionStepSpawnMonster : IFlatbufferObject
	{
		// Token: 0x17007858 RID: 30808
		// (get) Token: 0x060190EC RID: 102636 RVA: 0x0039AB31 File Offset: 0x00398D31
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060190ED RID: 102637 RVA: 0x0039AB3E File Offset: 0x00398D3E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060190EE RID: 102638 RVA: 0x0039AB48 File Offset: 0x00398D48
		public static ITrapDefenseConditionStepSpawnMonster GetRootAsITrapDefenseConditionStepSpawnMonster(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepSpawnMonster.GetRootAsITrapDefenseConditionStepSpawnMonster(_bb, default(ITrapDefenseConditionStepSpawnMonster));
		}

		// Token: 0x060190EF RID: 102639 RVA: 0x0039AB64 File Offset: 0x00398D64
		public static ITrapDefenseConditionStepSpawnMonster GetRootAsITrapDefenseConditionStepSpawnMonster(ByteBuffer _bb, ITrapDefenseConditionStepSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060190F0 RID: 102640 RVA: 0x0039AB81 File Offset: 0x00398D81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060190F1 RID: 102641 RVA: 0x0039AB90 File Offset: 0x00398D90
		public ITrapDefenseConditionStepSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007859 RID: 30809
		// (get) Token: 0x060190F2 RID: 102642 RVA: 0x0039ABA0 File Offset: 0x00398DA0
		public ETrapDefenseConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseConditionStep.Reward;
				}
				return (ETrapDefenseConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060190F3 RID: 102643 RVA: 0x0039ABDC File Offset: 0x00398DDC
		public static Offset<ITrapDefenseConditionStepSpawnMonster> CreateITrapDefenseConditionStepSpawnMonster(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepSpawnMonster.AddType(builder, Type);
			return ITrapDefenseConditionStepSpawnMonster.EndITrapDefenseConditionStepSpawnMonster(builder);
		}

		// Token: 0x060190F4 RID: 102644 RVA: 0x0039ABF2 File Offset: 0x00398DF2
		public static void StartITrapDefenseConditionStepSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060190F5 RID: 102645 RVA: 0x0039ABFB File Offset: 0x00398DFB
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060190F6 RID: 102646 RVA: 0x0039AC06 File Offset: 0x00398E06
		public static Offset<ITrapDefenseConditionStepSpawnMonster> EndITrapDefenseConditionStepSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepSpawnMonster>(builder.EndTable());
		}

		// Token: 0x060190F7 RID: 102647 RVA: 0x0039AC14 File Offset: 0x00398E14
		public ITrapDefenseConditionStepSpawnMonsterT UnPack()
		{
			ITrapDefenseConditionStepSpawnMonsterT trapDefenseConditionStepSpawnMonsterT = new ITrapDefenseConditionStepSpawnMonsterT();
			this.UnPackTo(trapDefenseConditionStepSpawnMonsterT);
			return trapDefenseConditionStepSpawnMonsterT;
		}

		// Token: 0x060190F8 RID: 102648 RVA: 0x0039AC2F File Offset: 0x00398E2F
		public void UnPackTo(ITrapDefenseConditionStepSpawnMonsterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060190F9 RID: 102649 RVA: 0x0039AC40 File Offset: 0x00398E40
		public static Offset<ITrapDefenseConditionStepSpawnMonster> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepSpawnMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepSpawnMonster>);
			}
			return ITrapDefenseConditionStepSpawnMonster.CreateITrapDefenseConditionStepSpawnMonster(builder, _o.Type);
		}

		// Token: 0x0400BEB8 RID: 48824
		private Table __p;
	}
}
