using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045CC RID: 17868
	public struct ITrapDefenseSpawnMonsterConditionOpen : IFlatbufferObject
	{
		// Token: 0x17007EFF RID: 32511
		// (get) Token: 0x0601B07D RID: 110717 RVA: 0x003DA633 File Offset: 0x003D8833
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B07E RID: 110718 RVA: 0x003DA640 File Offset: 0x003D8840
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B07F RID: 110719 RVA: 0x003DA648 File Offset: 0x003D8848
		public static ITrapDefenseSpawnMonsterConditionOpen GetRootAsITrapDefenseSpawnMonsterConditionOpen(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionOpen.GetRootAsITrapDefenseSpawnMonsterConditionOpen(_bb, default(ITrapDefenseSpawnMonsterConditionOpen));
		}

		// Token: 0x0601B080 RID: 110720 RVA: 0x003DA664 File Offset: 0x003D8864
		public static ITrapDefenseSpawnMonsterConditionOpen GetRootAsITrapDefenseSpawnMonsterConditionOpen(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionOpen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B081 RID: 110721 RVA: 0x003DA681 File Offset: 0x003D8881
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B082 RID: 110722 RVA: 0x003DA690 File Offset: 0x003D8890
		public ITrapDefenseSpawnMonsterConditionOpen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F00 RID: 32512
		// (get) Token: 0x0601B083 RID: 110723 RVA: 0x003DA6A0 File Offset: 0x003D88A0
		public ETrapDefenseSpawnMonsterCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrapDefenseSpawnMonsterCondition.Completed;
				}
				return (ETrapDefenseSpawnMonsterCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F01 RID: 32513
		// (get) Token: 0x0601B084 RID: 110724 RVA: 0x003DA6DC File Offset: 0x003D88DC
		public int Id
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

		// Token: 0x0601B085 RID: 110725 RVA: 0x003DA718 File Offset: 0x003D8918
		public static Offset<ITrapDefenseSpawnMonsterConditionOpen> CreateITrapDefenseSpawnMonsterConditionOpen(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed, int Id = 0)
		{
			builder.StartTable(2);
			ITrapDefenseSpawnMonsterConditionOpen.AddId(builder, Id);
			ITrapDefenseSpawnMonsterConditionOpen.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionOpen.EndITrapDefenseSpawnMonsterConditionOpen(builder);
		}

		// Token: 0x0601B086 RID: 110726 RVA: 0x003DA735 File Offset: 0x003D8935
		public static void StartITrapDefenseSpawnMonsterConditionOpen(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B087 RID: 110727 RVA: 0x003DA73E File Offset: 0x003D893E
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B088 RID: 110728 RVA: 0x003DA749 File Offset: 0x003D8949
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B089 RID: 110729 RVA: 0x003DA754 File Offset: 0x003D8954
		public static Offset<ITrapDefenseSpawnMonsterConditionOpen> EndITrapDefenseSpawnMonsterConditionOpen(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionOpen>(builder.EndTable());
		}

		// Token: 0x0601B08A RID: 110730 RVA: 0x003DA764 File Offset: 0x003D8964
		public ITrapDefenseSpawnMonsterConditionOpenT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionOpenT trapDefenseSpawnMonsterConditionOpenT = new ITrapDefenseSpawnMonsterConditionOpenT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionOpenT);
			return trapDefenseSpawnMonsterConditionOpenT;
		}

		// Token: 0x0601B08B RID: 110731 RVA: 0x003DA77F File Offset: 0x003D897F
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionOpenT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601B08C RID: 110732 RVA: 0x003DA79C File Offset: 0x003D899C
		public static Offset<ITrapDefenseSpawnMonsterConditionOpen> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionOpenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionOpen>);
			}
			return ITrapDefenseSpawnMonsterConditionOpen.CreateITrapDefenseSpawnMonsterConditionOpen(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400C69D RID: 50845
		private Table __p;
	}
}
