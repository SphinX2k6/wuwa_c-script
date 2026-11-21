using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004691 RID: 18065
	public struct ITrapDefenseConditionStepSpawnMonster : IFlatbufferObject
	{
		// Token: 0x17007E89 RID: 32393
		// (get) Token: 0x0601A858 RID: 108632 RVA: 0x003C6209 File Offset: 0x003C4409
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A859 RID: 108633 RVA: 0x003C6216 File Offset: 0x003C4416
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A85A RID: 108634 RVA: 0x003C6220 File Offset: 0x003C4420
		public static ITrapDefenseConditionStepSpawnMonster GetRootAsITrapDefenseConditionStepSpawnMonster(ByteBuffer _bb)
		{
			return ITrapDefenseConditionStepSpawnMonster.GetRootAsITrapDefenseConditionStepSpawnMonster(_bb, default(ITrapDefenseConditionStepSpawnMonster));
		}

		// Token: 0x0601A85B RID: 108635 RVA: 0x003C623C File Offset: 0x003C443C
		public static ITrapDefenseConditionStepSpawnMonster GetRootAsITrapDefenseConditionStepSpawnMonster(ByteBuffer _bb, ITrapDefenseConditionStepSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A85C RID: 108636 RVA: 0x003C6259 File Offset: 0x003C4459
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A85D RID: 108637 RVA: 0x003C6268 File Offset: 0x003C4468
		public ITrapDefenseConditionStepSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007E8A RID: 32394
		// (get) Token: 0x0601A85E RID: 108638 RVA: 0x003C6278 File Offset: 0x003C4478
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

		// Token: 0x0601A85F RID: 108639 RVA: 0x003C62B4 File Offset: 0x003C44B4
		public static Offset<ITrapDefenseConditionStepSpawnMonster> CreateITrapDefenseConditionStepSpawnMonster(FlatBufferBuilder builder, ETrapDefenseConditionStep Type = ETrapDefenseConditionStep.Reward)
		{
			builder.StartTable(1);
			ITrapDefenseConditionStepSpawnMonster.AddType(builder, Type);
			return ITrapDefenseConditionStepSpawnMonster.EndITrapDefenseConditionStepSpawnMonster(builder);
		}

		// Token: 0x0601A860 RID: 108640 RVA: 0x003C62CA File Offset: 0x003C44CA
		public static void StartITrapDefenseConditionStepSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A861 RID: 108641 RVA: 0x003C62D3 File Offset: 0x003C44D3
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A862 RID: 108642 RVA: 0x003C62DE File Offset: 0x003C44DE
		public static Offset<ITrapDefenseConditionStepSpawnMonster> EndITrapDefenseConditionStepSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseConditionStepSpawnMonster>(builder.EndTable());
		}

		// Token: 0x0601A863 RID: 108643 RVA: 0x003C62EC File Offset: 0x003C44EC
		public ITrapDefenseConditionStepSpawnMonsterT UnPack()
		{
			ITrapDefenseConditionStepSpawnMonsterT trapDefenseConditionStepSpawnMonsterT = new ITrapDefenseConditionStepSpawnMonsterT();
			this.UnPackTo(trapDefenseConditionStepSpawnMonsterT);
			return trapDefenseConditionStepSpawnMonsterT;
		}

		// Token: 0x0601A864 RID: 108644 RVA: 0x003C6307 File Offset: 0x003C4507
		public void UnPackTo(ITrapDefenseConditionStepSpawnMonsterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A865 RID: 108645 RVA: 0x003C6318 File Offset: 0x003C4518
		public static Offset<ITrapDefenseConditionStepSpawnMonster> Pack(FlatBufferBuilder builder, ITrapDefenseConditionStepSpawnMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseConditionStepSpawnMonster>);
			}
			return ITrapDefenseConditionStepSpawnMonster.CreateITrapDefenseConditionStepSpawnMonster(builder, _o.Type);
		}

		// Token: 0x0400C8C5 RID: 51397
		private Table __p;
	}
}
