using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A0 RID: 17568
	public struct IDynamicSpawnMonsterGroup : IFlatbufferObject
	{
		// Token: 0x17007BF8 RID: 31736
		// (get) Token: 0x0601A39E RID: 107422 RVA: 0x003BF468 File Offset: 0x003BD668
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A39F RID: 107423 RVA: 0x003BF475 File Offset: 0x003BD675
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A3A0 RID: 107424 RVA: 0x003BF47C File Offset: 0x003BD67C
		public static IDynamicSpawnMonsterGroup GetRootAsIDynamicSpawnMonsterGroup(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterGroup.GetRootAsIDynamicSpawnMonsterGroup(_bb, default(IDynamicSpawnMonsterGroup));
		}

		// Token: 0x0601A3A1 RID: 107425 RVA: 0x003BF498 File Offset: 0x003BD698
		public static IDynamicSpawnMonsterGroup GetRootAsIDynamicSpawnMonsterGroup(ByteBuffer _bb, IDynamicSpawnMonsterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A3A2 RID: 107426 RVA: 0x003BF4B5 File Offset: 0x003BD6B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A3A3 RID: 107427 RVA: 0x003BF4C4 File Offset: 0x003BD6C4
		public IDynamicSpawnMonsterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BF9 RID: 31737
		// (get) Token: 0x0601A3A4 RID: 107428 RVA: 0x003BF4D4 File Offset: 0x003BD6D4
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007BFA RID: 31738
		// (get) Token: 0x0601A3A5 RID: 107429 RVA: 0x003BF510 File Offset: 0x003BD710
		public int Weight
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

		// Token: 0x0601A3A6 RID: 107430 RVA: 0x003BF54C File Offset: 0x003BD74C
		public static Offset<IDynamicSpawnMonsterGroup> CreateIDynamicSpawnMonsterGroup(FlatBufferBuilder builder, int Id = 0, int Weight = 0)
		{
			builder.StartTable(2);
			IDynamicSpawnMonsterGroup.AddWeight(builder, Weight);
			IDynamicSpawnMonsterGroup.AddId(builder, Id);
			return IDynamicSpawnMonsterGroup.EndIDynamicSpawnMonsterGroup(builder);
		}

		// Token: 0x0601A3A7 RID: 107431 RVA: 0x003BF569 File Offset: 0x003BD769
		public static void StartIDynamicSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A3A8 RID: 107432 RVA: 0x003BF572 File Offset: 0x003BD772
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601A3A9 RID: 107433 RVA: 0x003BF57D File Offset: 0x003BD77D
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x0601A3AA RID: 107434 RVA: 0x003BF588 File Offset: 0x003BD788
		public static Offset<IDynamicSpawnMonsterGroup> EndIDynamicSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterGroup>(builder.EndTable());
		}

		// Token: 0x0601A3AB RID: 107435 RVA: 0x003BF598 File Offset: 0x003BD798
		public IDynamicSpawnMonsterGroupT UnPack()
		{
			IDynamicSpawnMonsterGroupT dynamicSpawnMonsterGroupT = new IDynamicSpawnMonsterGroupT();
			this.UnPackTo(dynamicSpawnMonsterGroupT);
			return dynamicSpawnMonsterGroupT;
		}

		// Token: 0x0601A3AC RID: 107436 RVA: 0x003BF5B3 File Offset: 0x003BD7B3
		public void UnPackTo(IDynamicSpawnMonsterGroupT _o)
		{
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x0601A3AD RID: 107437 RVA: 0x003BF5D0 File Offset: 0x003BD7D0
		public static Offset<IDynamicSpawnMonsterGroup> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterGroup>);
			}
			return IDynamicSpawnMonsterGroup.CreateIDynamicSpawnMonsterGroup(builder, _o.Id, _o.Weight);
		}

		// Token: 0x0400C4A9 RID: 50345
		private Table __p;
	}
}
