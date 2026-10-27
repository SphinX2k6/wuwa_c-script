using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045B7 RID: 17847
	public struct ITrapDefenseMonsterGroup : IFlatbufferObject
	{
		// Token: 0x17007EDA RID: 32474
		// (get) Token: 0x0601AFCD RID: 110541 RVA: 0x003D91E7 File Offset: 0x003D73E7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AFCE RID: 110542 RVA: 0x003D91F4 File Offset: 0x003D73F4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AFCF RID: 110543 RVA: 0x003D91FC File Offset: 0x003D73FC
		public static ITrapDefenseMonsterGroup GetRootAsITrapDefenseMonsterGroup(ByteBuffer _bb)
		{
			return ITrapDefenseMonsterGroup.GetRootAsITrapDefenseMonsterGroup(_bb, default(ITrapDefenseMonsterGroup));
		}

		// Token: 0x0601AFD0 RID: 110544 RVA: 0x003D9218 File Offset: 0x003D7418
		public static ITrapDefenseMonsterGroup GetRootAsITrapDefenseMonsterGroup(ByteBuffer _bb, ITrapDefenseMonsterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AFD1 RID: 110545 RVA: 0x003D9235 File Offset: 0x003D7435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AFD2 RID: 110546 RVA: 0x003D9244 File Offset: 0x003D7444
		public ITrapDefenseMonsterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007EDB RID: 32475
		// (get) Token: 0x0601AFD3 RID: 110547 RVA: 0x003D9254 File Offset: 0x003D7454
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

		// Token: 0x0601AFD4 RID: 110548 RVA: 0x003D9290 File Offset: 0x003D7490
		public static Offset<ITrapDefenseMonsterGroup> CreateITrapDefenseMonsterGroup(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ITrapDefenseMonsterGroup.AddId(builder, Id);
			return ITrapDefenseMonsterGroup.EndITrapDefenseMonsterGroup(builder);
		}

		// Token: 0x0601AFD5 RID: 110549 RVA: 0x003D92A6 File Offset: 0x003D74A6
		public static void StartITrapDefenseMonsterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AFD6 RID: 110550 RVA: 0x003D92AF File Offset: 0x003D74AF
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601AFD7 RID: 110551 RVA: 0x003D92BA File Offset: 0x003D74BA
		public static Offset<ITrapDefenseMonsterGroup> EndITrapDefenseMonsterGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseMonsterGroup>(builder.EndTable());
		}

		// Token: 0x0601AFD8 RID: 110552 RVA: 0x003D92C8 File Offset: 0x003D74C8
		public ITrapDefenseMonsterGroupT UnPack()
		{
			ITrapDefenseMonsterGroupT trapDefenseMonsterGroupT = new ITrapDefenseMonsterGroupT();
			this.UnPackTo(trapDefenseMonsterGroupT);
			return trapDefenseMonsterGroupT;
		}

		// Token: 0x0601AFD9 RID: 110553 RVA: 0x003D92E3 File Offset: 0x003D74E3
		public void UnPackTo(ITrapDefenseMonsterGroupT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0601AFDA RID: 110554 RVA: 0x003D92F4 File Offset: 0x003D74F4
		public static Offset<ITrapDefenseMonsterGroup> Pack(FlatBufferBuilder builder, ITrapDefenseMonsterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseMonsterGroup>);
			}
			return ITrapDefenseMonsterGroup.CreateITrapDefenseMonsterGroup(builder, _o.Id);
		}

		// Token: 0x0400C681 RID: 50817
		private Table __p;
	}
}
