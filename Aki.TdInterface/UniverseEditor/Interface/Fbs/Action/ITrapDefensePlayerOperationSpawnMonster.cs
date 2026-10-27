using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007463 RID: 29795
	public struct ITrapDefensePlayerOperationSpawnMonster : IFlatbufferObject
	{
		// Token: 0x1700E22B RID: 57899
		// (get) Token: 0x06036216 RID: 221718 RVA: 0x0075C3E1 File Offset: 0x0075A5E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036217 RID: 221719 RVA: 0x0075C3EE File Offset: 0x0075A5EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036218 RID: 221720 RVA: 0x0075C3F8 File Offset: 0x0075A5F8
		public static ITrapDefensePlayerOperationSpawnMonster GetRootAsITrapDefensePlayerOperationSpawnMonster(ByteBuffer _bb)
		{
			return ITrapDefensePlayerOperationSpawnMonster.GetRootAsITrapDefensePlayerOperationSpawnMonster(_bb, default(ITrapDefensePlayerOperationSpawnMonster));
		}

		// Token: 0x06036219 RID: 221721 RVA: 0x0075C414 File Offset: 0x0075A614
		public static ITrapDefensePlayerOperationSpawnMonster GetRootAsITrapDefensePlayerOperationSpawnMonster(ByteBuffer _bb, ITrapDefensePlayerOperationSpawnMonster obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603621A RID: 221722 RVA: 0x0075C431 File Offset: 0x0075A631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603621B RID: 221723 RVA: 0x0075C440 File Offset: 0x0075A640
		public ITrapDefensePlayerOperationSpawnMonster __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E22C RID: 57900
		// (get) Token: 0x0603621C RID: 221724 RVA: 0x0075C450 File Offset: 0x0075A650
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

		// Token: 0x0603621D RID: 221725 RVA: 0x0075C48C File Offset: 0x0075A68C
		public static Offset<ITrapDefensePlayerOperationSpawnMonster> CreateITrapDefensePlayerOperationSpawnMonster(FlatBufferBuilder builder, ETrapDefensePlayerOperationType Type = ETrapDefensePlayerOperationType.SpawnMonster)
		{
			builder.StartTable(1);
			ITrapDefensePlayerOperationSpawnMonster.AddType(builder, Type);
			return ITrapDefensePlayerOperationSpawnMonster.EndITrapDefensePlayerOperationSpawnMonster(builder);
		}

		// Token: 0x0603621E RID: 221726 RVA: 0x0075C4A2 File Offset: 0x0075A6A2
		public static void StartITrapDefensePlayerOperationSpawnMonster(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603621F RID: 221727 RVA: 0x0075C4AB File Offset: 0x0075A6AB
		public static void AddType(FlatBufferBuilder builder, ETrapDefensePlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036220 RID: 221728 RVA: 0x0075C4B6 File Offset: 0x0075A6B6
		public static Offset<ITrapDefensePlayerOperationSpawnMonster> EndITrapDefensePlayerOperationSpawnMonster(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefensePlayerOperationSpawnMonster>(builder.EndTable());
		}

		// Token: 0x06036221 RID: 221729 RVA: 0x0075C4C4 File Offset: 0x0075A6C4
		public ITrapDefensePlayerOperationSpawnMonsterT UnPack()
		{
			ITrapDefensePlayerOperationSpawnMonsterT trapDefensePlayerOperationSpawnMonsterT = new ITrapDefensePlayerOperationSpawnMonsterT();
			this.UnPackTo(trapDefensePlayerOperationSpawnMonsterT);
			return trapDefensePlayerOperationSpawnMonsterT;
		}

		// Token: 0x06036222 RID: 221730 RVA: 0x0075C4DF File Offset: 0x0075A6DF
		public void UnPackTo(ITrapDefensePlayerOperationSpawnMonsterT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036223 RID: 221731 RVA: 0x0075C4F0 File Offset: 0x0075A6F0
		public static Offset<ITrapDefensePlayerOperationSpawnMonster> Pack(FlatBufferBuilder builder, ITrapDefensePlayerOperationSpawnMonsterT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefensePlayerOperationSpawnMonster>);
			}
			return ITrapDefensePlayerOperationSpawnMonster.CreateITrapDefensePlayerOperationSpawnMonster(builder, _o.Type);
		}

		// Token: 0x040122EB RID: 74475
		private Table __p;
	}
}
