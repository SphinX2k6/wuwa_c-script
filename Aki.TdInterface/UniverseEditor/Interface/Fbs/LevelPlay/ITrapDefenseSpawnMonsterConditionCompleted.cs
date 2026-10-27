using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045C6 RID: 17862
	public struct ITrapDefenseSpawnMonsterConditionCompleted : IFlatbufferObject
	{
		// Token: 0x17007EF4 RID: 32500
		// (get) Token: 0x0601B041 RID: 110657 RVA: 0x003D9E32 File Offset: 0x003D8032
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B042 RID: 110658 RVA: 0x003D9E3F File Offset: 0x003D803F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B043 RID: 110659 RVA: 0x003D9E48 File Offset: 0x003D8048
		public static ITrapDefenseSpawnMonsterConditionCompleted GetRootAsITrapDefenseSpawnMonsterConditionCompleted(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionCompleted.GetRootAsITrapDefenseSpawnMonsterConditionCompleted(_bb, default(ITrapDefenseSpawnMonsterConditionCompleted));
		}

		// Token: 0x0601B044 RID: 110660 RVA: 0x003D9E64 File Offset: 0x003D8064
		public static ITrapDefenseSpawnMonsterConditionCompleted GetRootAsITrapDefenseSpawnMonsterConditionCompleted(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B045 RID: 110661 RVA: 0x003D9E81 File Offset: 0x003D8081
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B046 RID: 110662 RVA: 0x003D9E90 File Offset: 0x003D8090
		public ITrapDefenseSpawnMonsterConditionCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EF5 RID: 32501
		// (get) Token: 0x0601B047 RID: 110663 RVA: 0x003D9EA0 File Offset: 0x003D80A0
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

		// Token: 0x17007EF6 RID: 32502
		// (get) Token: 0x0601B048 RID: 110664 RVA: 0x003D9EDC File Offset: 0x003D80DC
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

		// Token: 0x0601B049 RID: 110665 RVA: 0x003D9F18 File Offset: 0x003D8118
		public static Offset<ITrapDefenseSpawnMonsterConditionCompleted> CreateITrapDefenseSpawnMonsterConditionCompleted(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed, int Id = 0)
		{
			builder.StartTable(2);
			ITrapDefenseSpawnMonsterConditionCompleted.AddId(builder, Id);
			ITrapDefenseSpawnMonsterConditionCompleted.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionCompleted.EndITrapDefenseSpawnMonsterConditionCompleted(builder);
		}

		// Token: 0x0601B04A RID: 110666 RVA: 0x003D9F35 File Offset: 0x003D8135
		public static void StartITrapDefenseSpawnMonsterConditionCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B04B RID: 110667 RVA: 0x003D9F3E File Offset: 0x003D813E
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B04C RID: 110668 RVA: 0x003D9F49 File Offset: 0x003D8149
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601B04D RID: 110669 RVA: 0x003D9F54 File Offset: 0x003D8154
		public static Offset<ITrapDefenseSpawnMonsterConditionCompleted> EndITrapDefenseSpawnMonsterConditionCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionCompleted>(builder.EndTable());
		}

		// Token: 0x0601B04E RID: 110670 RVA: 0x003D9F64 File Offset: 0x003D8164
		public ITrapDefenseSpawnMonsterConditionCompletedT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionCompletedT trapDefenseSpawnMonsterConditionCompletedT = new ITrapDefenseSpawnMonsterConditionCompletedT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionCompletedT);
			return trapDefenseSpawnMonsterConditionCompletedT;
		}

		// Token: 0x0601B04F RID: 110671 RVA: 0x003D9F7F File Offset: 0x003D817F
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionCompletedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601B050 RID: 110672 RVA: 0x003D9F9C File Offset: 0x003D819C
		public static Offset<ITrapDefenseSpawnMonsterConditionCompleted> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionCompleted>);
			}
			return ITrapDefenseSpawnMonsterConditionCompleted.CreateITrapDefenseSpawnMonsterConditionCompleted(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400C697 RID: 50839
		private Table __p;
	}
}
