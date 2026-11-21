using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A1F RID: 18975
	public struct ITrapDefenseMonsterGroup : IFlatbufferObject
	{
		// Token: 0x1700851B RID: 34075
		// (get) Token: 0x0601C7A2 RID: 116642 RVA: 0x00405483 File Offset: 0x00403683
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C7A3 RID: 116643 RVA: 0x00405490 File Offset: 0x00403690
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C7A4 RID: 116644 RVA: 0x00405498 File Offset: 0x00403698
		public static ITrapDefenseMonsterGroup GetRootAsITrapDefenseMonsterGroup(ByteBuffer _bb)
		{
			return ITrapDefenseMonsterGroup.GetRootAsITrapDefenseMonsterGroup(_bb, default(ITrapDefenseMonsterGroup));
		}

		// Token: 0x0601C7A5 RID: 116645 RVA: 0x004054B4 File Offset: 0x004036B4
		public static ITrapDefenseMonsterGroup GetRootAsITrapDefenseMonsterGroup(ByteBuffer _bb, ITrapDefenseMonsterGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C7A6 RID: 116646 RVA: 0x004054D1 File Offset: 0x004036D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C7A7 RID: 116647 RVA: 0x004054E0 File Offset: 0x004036E0
		public ITrapDefenseMonsterGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700851C RID: 34076
		// (get) Token: 0x0601C7A8 RID: 116648 RVA: 0x004054F0 File Offset: 0x004036F0
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

		// Token: 0x0601C7A9 RID: 116649 RVA: 0x0040552C File Offset: 0x0040372C
		public static Offset<ITrapDefenseMonsterGroup> CreateITrapDefenseMonsterGroup(FlatBufferBuilder builder, int Id = 0)
		{
			builder.StartTable(1);
			ITrapDefenseMonsterGroup.AddId(builder, Id);
			return ITrapDefenseMonsterGroup.EndITrapDefenseMonsterGroup(builder);
		}

		// Token: 0x0601C7AA RID: 116650 RVA: 0x00405542 File Offset: 0x00403742
		public static void StartITrapDefenseMonsterGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C7AB RID: 116651 RVA: 0x0040554B File Offset: 0x0040374B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C7AC RID: 116652 RVA: 0x00405556 File Offset: 0x00403756
		public static Offset<ITrapDefenseMonsterGroup> EndITrapDefenseMonsterGroup(FlatBufferBuilder builder)
		{
			return new Offset<ITrapDefenseMonsterGroup>(builder.EndTable());
		}

		// Token: 0x0601C7AD RID: 116653 RVA: 0x00405564 File Offset: 0x00403764
		public ITrapDefenseMonsterGroupT UnPack()
		{
			ITrapDefenseMonsterGroupT trapDefenseMonsterGroupT = new ITrapDefenseMonsterGroupT();
			this.UnPackTo(trapDefenseMonsterGroupT);
			return trapDefenseMonsterGroupT;
		}

		// Token: 0x0601C7AE RID: 116654 RVA: 0x0040557F File Offset: 0x0040377F
		public void UnPackTo(ITrapDefenseMonsterGroupT _o)
		{
			_o.Id = this.Id;
		}

		// Token: 0x0601C7AF RID: 116655 RVA: 0x00405590 File Offset: 0x00403790
		public static Offset<ITrapDefenseMonsterGroup> Pack(FlatBufferBuilder builder, ITrapDefenseMonsterGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITrapDefenseMonsterGroup>);
			}
			return ITrapDefenseMonsterGroup.CreateITrapDefenseMonsterGroup(builder, _o.Id);
		}

		// Token: 0x0400D0B0 RID: 53424
		private Table __p;
	}
}
