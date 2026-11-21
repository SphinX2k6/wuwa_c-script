using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004908 RID: 18696
	public struct IDynamicSpawnMonsterGroup : IFlatbufferObject
	{
		// Token: 0x17008237 RID: 33335
		// (get) Token: 0x0601BB6F RID: 113519 RVA: 0x003EB674 File Offset: 0x003E9874
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BB70 RID: 113520 RVA: 0x003EB681 File Offset: 0x003E9881
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BB71 RID: 113521 RVA: 0x003EB688 File Offset: 0x003E9888
		public static IDynamicSpawnMonsterGroup GetRootAsIDynamicSpawnMonsterGroup(ByteBuffer _bb)
		{
			return IDynamicSpawnMonsterGroup.GetRootAsIDynamicSpawnMonsterGroup(_bb, default(IDynamicSpawnMonsterGroup));
		}

		// Token: 0x0601BB72 RID: 113522 RVA: 0x003EB6A4 File Offset: 0x003E98A4
		public static IDynamicSpawnMonsterGroup GetRootAsIDynamicSpawnMonsterGroup(ByteBuffer _bb, IDynamicSpawnMonsterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BB73 RID: 113523 RVA: 0x003EB6C1 File Offset: 0x003E98C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BB74 RID: 113524 RVA: 0x003EB6D0 File Offset: 0x003E98D0
		public IDynamicSpawnMonsterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008238 RID: 33336
		// (get) Token: 0x0601BB75 RID: 113525 RVA: 0x003EB6E0 File Offset: 0x003E98E0
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

		// Token: 0x17008239 RID: 33337
		// (get) Token: 0x0601BB76 RID: 113526 RVA: 0x003EB71C File Offset: 0x003E991C
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

		// Token: 0x0601BB77 RID: 113527 RVA: 0x003EB758 File Offset: 0x003E9958
		public static Offset<IDynamicSpawnMonsterGroup> CreateIDynamicSpawnMonsterGroup(FlatBufferBuilder builder, int Id = 0, int Weight = 0)
		{
			builder.StartTable(2);
			IDynamicSpawnMonsterGroup.AddWeight(builder, Weight);
			IDynamicSpawnMonsterGroup.AddId(builder, Id);
			return IDynamicSpawnMonsterGroup.EndIDynamicSpawnMonsterGroup(builder);
		}

		// Token: 0x0601BB78 RID: 113528 RVA: 0x003EB775 File Offset: 0x003E9975
		public static void StartIDynamicSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BB79 RID: 113529 RVA: 0x003EB77E File Offset: 0x003E997E
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BB7A RID: 113530 RVA: 0x003EB789 File Offset: 0x003E9989
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(1, weight, 0);
		}

		// Token: 0x0601BB7B RID: 113531 RVA: 0x003EB794 File Offset: 0x003E9994
		public static Offset<IDynamicSpawnMonsterGroup> EndIDynamicSpawnMonsterGroup(FlatBufferBuilder builder)
		{
			return new Offset<IDynamicSpawnMonsterGroup>(builder.EndTable());
		}

		// Token: 0x0601BB7C RID: 113532 RVA: 0x003EB7A4 File Offset: 0x003E99A4
		public IDynamicSpawnMonsterGroupT UnPack()
		{
			IDynamicSpawnMonsterGroupT dynamicSpawnMonsterGroupT = new IDynamicSpawnMonsterGroupT();
			this.UnPackTo(dynamicSpawnMonsterGroupT);
			return dynamicSpawnMonsterGroupT;
		}

		// Token: 0x0601BB7D RID: 113533 RVA: 0x003EB7BF File Offset: 0x003E99BF
		public void UnPackTo(IDynamicSpawnMonsterGroupT _o)
		{
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x0601BB7E RID: 113534 RVA: 0x003EB7DC File Offset: 0x003E99DC
		public static Offset<IDynamicSpawnMonsterGroup> Pack(FlatBufferBuilder builder, IDynamicSpawnMonsterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDynamicSpawnMonsterGroup>);
			}
			return IDynamicSpawnMonsterGroup.CreateIDynamicSpawnMonsterGroup(builder, _o.Id, _o.Weight);
		}

		// Token: 0x0400CED7 RID: 52951
		private Table __p;
	}
}
