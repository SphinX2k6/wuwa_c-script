using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C56 RID: 31830
	public struct ITrapDefensePlayerOperationSpawnMonster : IFlatbufferObject
	{
		// Token: 0x1700EE48 RID: 61000
		// (get) Token: 0x060395FF RID: 235007 RVA: 0x007BF10D File Offset: 0x007BD30D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039600 RID: 235008 RVA: 0x007BF11A File Offset: 0x007BD31A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039601 RID: 235009 RVA: 0x007BF124 File Offset: 0x007BD324
		public static ITrapDefensePlayerOperationSpawnMonster GetRootAsITrapDefensePlayerOperationSpawnMonster(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationSpawnMonster.GetRootAsITrapDefensePlayerOperationSpawnMonster(_bb, default(ITrapDefensePlayerOperationSpawnMonster));
		}

		// Token: 0x06039602 RID: 235010 RVA: 0x007BF140 File Offset: 0x007BD340
		public static ITrapDefensePlayerOperationSpawnMonster GetRootAsITrapDefensePlayerOperationSpawnMonster(ByteBuffer _bb, ITrapDefensePlayerOperationSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039603 RID: 235011 RVA: 0x007BF15D File Offset: 0x007BD35D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039604 RID: 235012 RVA: 0x007BF16C File Offset: 0x007BD36C
		public ITrapDefensePlayerOperationSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE49 RID: 61001
		// (get) Token: 0x06039605 RID: 235013 RVA: 0x007BF17C File Offset: 0x007BD37C
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

		// Token: 0x06039606 RID: 235014 RVA: 0x007BF1B8 File Offset: 0x007BD3B8
		public static Offset<ITrapDefensePlayerOperationSpawnMonster> CreateITrapDefensePlayerOperationSpawnMonster(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationSpawnMonster.AddType(builder, Type);
			return ITrapDefensePlayerOperationSpawnMonster.EndITrapDefensePlayerOperationSpawnMonster(builder);
		}

		// Token: 0x06039607 RID: 235015 RVA: 0x007BF1CE File Offset: 0x007BD3CE
		public static void StartITrapDefensePlayerOperationSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039608 RID: 235016 RVA: 0x007BF1D7 File Offset: 0x007BD3D7
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039609 RID: 235017 RVA: 0x007BF1E2 File Offset: 0x007BD3E2
		public static Offset<ITrapDefensePlayerOperationSpawnMonster> EndITrapDefensePlayerOperationSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationSpawnMonster>(builder.EndTable());
		}

		// Token: 0x0603960A RID: 235018 RVA: 0x007BF1F0 File Offset: 0x007BD3F0
		public ITrapDefensePlayerOperationSpawnMonsterT UnPack()
		{
			ITrapDefensePlayerOperationSpawnMonsterT trapDefensePlayerOperationSpawnMonsterT = new ITrapDefensePlayerOperationSpawnMonsterT();
			this.UnPackTo(trapDefensePlayerOperationSpawnMonsterT);
			return trapDefensePlayerOperationSpawnMonsterT;
		}

		// Token: 0x0603960B RID: 235019 RVA: 0x007BF20B File Offset: 0x007BD40B
		public void UnPackTo(ITrapDefensePlayerOperationSpawnMonsterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603960C RID: 235020 RVA: 0x007BF21C File Offset: 0x007BD41C
		public static Offset<ITrapDefensePlayerOperationSpawnMonster> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationSpawnMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationSpawnMonster>);
			}
			return ITrapDefensePlayerOperationSpawnMonster.CreateITrapDefensePlayerOperationSpawnMonster(builder, _o.Type);
		}

		// Token: 0x04013312 RID: 78610
		private Table __p;
	}
}
