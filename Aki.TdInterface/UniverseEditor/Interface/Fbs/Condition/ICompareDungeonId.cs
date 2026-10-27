using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B92 RID: 19346
	public struct ICompareDungeonId : IFlatbufferObject
	{
		// Token: 0x17008C61 RID: 35937
		// (get) Token: 0x0601E7E2 RID: 124898 RVA: 0x00444A6E File Offset: 0x00442C6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7E3 RID: 124899 RVA: 0x00444A7B File Offset: 0x00442C7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7E4 RID: 124900 RVA: 0x00444A84 File Offset: 0x00442C84
		public static ICompareDungeonId GetRootAsICompareDungeonId(ByteBuffer _bb)
		{
			return ICompareDungeonId.GetRootAsICompareDungeonId(_bb, default(ICompareDungeonId));
		}

		// Token: 0x0601E7E5 RID: 124901 RVA: 0x00444AA0 File Offset: 0x00442CA0
		public static ICompareDungeonId GetRootAsICompareDungeonId(ByteBuffer _bb, ICompareDungeonId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E7E6 RID: 124902 RVA: 0x00444ABD File Offset: 0x00442CBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E7E7 RID: 124903 RVA: 0x00444ACC File Offset: 0x00442CCC
		public ICompareDungeonId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C62 RID: 35938
		// (get) Token: 0x0601E7E8 RID: 124904 RVA: 0x00444ADC File Offset: 0x00442CDC
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C63 RID: 35939
		// (get) Token: 0x0601E7E9 RID: 124905 RVA: 0x00444B18 File Offset: 0x00442D18
		public int DungeonId
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

		// Token: 0x17008C64 RID: 35940
		// (get) Token: 0x0601E7EA RID: 124906 RVA: 0x00444B54 File Offset: 0x00442D54
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E7EB RID: 124907 RVA: 0x00444B90 File Offset: 0x00442D90
		public static Offset<ICompareDungeonId> CreateICompareDungeonId(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int DungeonId = 0, ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(3);
			ICompareDungeonId.AddDungeonId(builder, DungeonId);
			ICompareDungeonId.AddCompare(builder, Compare);
			ICompareDungeonId.AddType(builder, Type);
			return ICompareDungeonId.EndICompareDungeonId(builder);
		}

		// Token: 0x0601E7EC RID: 124908 RVA: 0x00444BB4 File Offset: 0x00442DB4
		public static void StartICompareDungeonId(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E7ED RID: 124909 RVA: 0x00444BBD File Offset: 0x00442DBD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E7EE RID: 124910 RVA: 0x00444BC8 File Offset: 0x00442DC8
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601E7EF RID: 124911 RVA: 0x00444BD3 File Offset: 0x00442DD3
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E7F0 RID: 124912 RVA: 0x00444BDE File Offset: 0x00442DDE
		public static Offset<ICompareDungeonId> EndICompareDungeonId(FlatBufferBuilder builder)
		{
			return new Offset<ICompareDungeonId>(builder.EndTable());
		}

		// Token: 0x0601E7F1 RID: 124913 RVA: 0x00444BEC File Offset: 0x00442DEC
		public ICompareDungeonIdT UnPack()
		{
			ICompareDungeonIdT compareDungeonIdT = new ICompareDungeonIdT();
			this.UnPackTo(compareDungeonIdT);
			return compareDungeonIdT;
		}

		// Token: 0x0601E7F2 RID: 124914 RVA: 0x00444C07 File Offset: 0x00442E07
		public void UnPackTo(ICompareDungeonIdT _o)
		{
			_o.Type = this.Type;
			_o.DungeonId = this.DungeonId;
			_o.Compare = this.Compare;
		}

		// Token: 0x0601E7F3 RID: 124915 RVA: 0x00444C30 File Offset: 0x00442E30
		public static Offset<ICompareDungeonId> Pack(FlatBufferBuilder builder, ICompareDungeonIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareDungeonId>);
			}
			return ICompareDungeonId.CreateICompareDungeonId(builder, _o.Type, _o.DungeonId, _o.Compare);
		}

		// Token: 0x0400D469 RID: 54377
		private Table __p;
	}
}
