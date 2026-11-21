using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A2E RID: 18990
	public struct ITrapDefenseSpawnMonsterConditionCompleted : IFlatbufferObject
	{
		// Token: 0x17008535 RID: 34101
		// (get) Token: 0x0601C816 RID: 116758 RVA: 0x004060CE File Offset: 0x004042CE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C817 RID: 116759 RVA: 0x004060DB File Offset: 0x004042DB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C818 RID: 116760 RVA: 0x004060E4 File Offset: 0x004042E4
		public static ITrapDefenseSpawnMonsterConditionCompleted GetRootAsITrapDefenseSpawnMonsterConditionCompleted(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionCompleted.GetRootAsITrapDefenseSpawnMonsterConditionCompleted(_bb, default(ITrapDefenseSpawnMonsterConditionCompleted));
		}

		// Token: 0x0601C819 RID: 116761 RVA: 0x00406100 File Offset: 0x00404300
		public static ITrapDefenseSpawnMonsterConditionCompleted GetRootAsITrapDefenseSpawnMonsterConditionCompleted(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C81A RID: 116762 RVA: 0x0040611D File Offset: 0x0040431D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C81B RID: 116763 RVA: 0x0040612C File Offset: 0x0040432C
		public ITrapDefenseSpawnMonsterConditionCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008536 RID: 34102
		// (get) Token: 0x0601C81C RID: 116764 RVA: 0x0040613C File Offset: 0x0040433C
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

		// Token: 0x17008537 RID: 34103
		// (get) Token: 0x0601C81D RID: 116765 RVA: 0x00406178 File Offset: 0x00404378
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

		// Token: 0x0601C81E RID: 116766 RVA: 0x004061B4 File Offset: 0x004043B4
		public static Offset<ITrapDefenseSpawnMonsterConditionCompleted> CreateITrapDefenseSpawnMonsterConditionCompleted(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed, int Id = 0)
		{
			builder.StartTable(2);
			ITrapDefenseSpawnMonsterConditionCompleted.AddId(builder, Id);
			ITrapDefenseSpawnMonsterConditionCompleted.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionCompleted.EndITrapDefenseSpawnMonsterConditionCompleted(builder);
		}

		// Token: 0x0601C81F RID: 116767 RVA: 0x004061D1 File Offset: 0x004043D1
		public static void StartITrapDefenseSpawnMonsterConditionCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C820 RID: 116768 RVA: 0x004061DA File Offset: 0x004043DA
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C821 RID: 116769 RVA: 0x004061E5 File Offset: 0x004043E5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601C822 RID: 116770 RVA: 0x004061F0 File Offset: 0x004043F0
		public static Offset<ITrapDefenseSpawnMonsterConditionCompleted> EndITrapDefenseSpawnMonsterConditionCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionCompleted>(builder.EndTable());
		}

		// Token: 0x0601C823 RID: 116771 RVA: 0x00406200 File Offset: 0x00404400
		public ITrapDefenseSpawnMonsterConditionCompletedT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionCompletedT trapDefenseSpawnMonsterConditionCompletedT = new ITrapDefenseSpawnMonsterConditionCompletedT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionCompletedT);
			return trapDefenseSpawnMonsterConditionCompletedT;
		}

		// Token: 0x0601C824 RID: 116772 RVA: 0x0040621B File Offset: 0x0040441B
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionCompletedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601C825 RID: 116773 RVA: 0x00406238 File Offset: 0x00404438
		public static Offset<ITrapDefenseSpawnMonsterConditionCompleted> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionCompleted>);
			}
			return ITrapDefenseSpawnMonsterConditionCompleted.CreateITrapDefenseSpawnMonsterConditionCompleted(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400D0C6 RID: 53446
		private Table __p;
	}
}
