using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A34 RID: 18996
	public struct ITrapDefenseSpawnMonsterConditionOpen : IFlatbufferObject
	{
		// Token: 0x17008540 RID: 34112
		// (get) Token: 0x0601C852 RID: 116818 RVA: 0x004068CF File Offset: 0x00404ACF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C853 RID: 116819 RVA: 0x004068DC File Offset: 0x00404ADC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C854 RID: 116820 RVA: 0x004068E4 File Offset: 0x00404AE4
		public static ITrapDefenseSpawnMonsterConditionOpen GetRootAsITrapDefenseSpawnMonsterConditionOpen(ByteBuffer _bb)
		{
			return ITrapDefenseSpawnMonsterConditionOpen.GetRootAsITrapDefenseSpawnMonsterConditionOpen(_bb, default(ITrapDefenseSpawnMonsterConditionOpen));
		}

		// Token: 0x0601C855 RID: 116821 RVA: 0x00406900 File Offset: 0x00404B00
		public static ITrapDefenseSpawnMonsterConditionOpen GetRootAsITrapDefenseSpawnMonsterConditionOpen(ByteBuffer _bb, ITrapDefenseSpawnMonsterConditionOpen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C856 RID: 116822 RVA: 0x0040691D File Offset: 0x00404B1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C857 RID: 116823 RVA: 0x0040692C File Offset: 0x00404B2C
		public ITrapDefenseSpawnMonsterConditionOpen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008541 RID: 34113
		// (get) Token: 0x0601C858 RID: 116824 RVA: 0x0040693C File Offset: 0x00404B3C
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

		// Token: 0x17008542 RID: 34114
		// (get) Token: 0x0601C859 RID: 116825 RVA: 0x00406978 File Offset: 0x00404B78
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

		// Token: 0x0601C85A RID: 116826 RVA: 0x004069B4 File Offset: 0x00404BB4
		public static Offset<ITrapDefenseSpawnMonsterConditionOpen> CreateITrapDefenseSpawnMonsterConditionOpen(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition Type = ETrapDefenseSpawnMonsterCondition.Completed, int Id = 0)
		{
			builder.StartTable(2);
			ITrapDefenseSpawnMonsterConditionOpen.AddId(builder, Id);
			ITrapDefenseSpawnMonsterConditionOpen.AddType(builder, Type);
			return ITrapDefenseSpawnMonsterConditionOpen.EndITrapDefenseSpawnMonsterConditionOpen(builder);
		}

		// Token: 0x0601C85B RID: 116827 RVA: 0x004069D1 File Offset: 0x00404BD1
		public static void StartITrapDefenseSpawnMonsterConditionOpen(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C85C RID: 116828 RVA: 0x004069DA File Offset: 0x00404BDA
		public static void AddType(FlatBufferBuilder builder, ETrapDefenseSpawnMonsterCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C85D RID: 116829 RVA: 0x004069E5 File Offset: 0x00404BE5
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0601C85E RID: 116830 RVA: 0x004069F0 File Offset: 0x00404BF0
		public static Offset<ITrapDefenseSpawnMonsterConditionOpen> EndITrapDefenseSpawnMonsterConditionOpen(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseSpawnMonsterConditionOpen>(builder.EndTable());
		}

		// Token: 0x0601C85F RID: 116831 RVA: 0x00406A00 File Offset: 0x00404C00
		public ITrapDefenseSpawnMonsterConditionOpenT UnPack()
		{
			ITrapDefenseSpawnMonsterConditionOpenT trapDefenseSpawnMonsterConditionOpenT = new ITrapDefenseSpawnMonsterConditionOpenT();
			this.UnPackTo(trapDefenseSpawnMonsterConditionOpenT);
			return trapDefenseSpawnMonsterConditionOpenT;
		}

		// Token: 0x0601C860 RID: 116832 RVA: 0x00406A1B File Offset: 0x00404C1B
		public void UnPackTo(ITrapDefenseSpawnMonsterConditionOpenT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0601C861 RID: 116833 RVA: 0x00406A38 File Offset: 0x00404C38
		public static Offset<ITrapDefenseSpawnMonsterConditionOpen> Pack(FlatBufferBuilder builder, ITrapDefenseSpawnMonsterConditionOpenT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseSpawnMonsterConditionOpen>);
			}
			return ITrapDefenseSpawnMonsterConditionOpen.CreateITrapDefenseSpawnMonsterConditionOpen(builder, _o.Type, _o.Id);
		}

		// Token: 0x0400D0CC RID: 53452
		private Table __p;
	}
}
