using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E42 RID: 20034
	public struct ICheckBvbActivityRank : IFlatbufferObject
	{
		// Token: 0x17008EB8 RID: 36536
		// (get) Token: 0x0601EFD1 RID: 126929 RVA: 0x00453D74 File Offset: 0x00451F74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFD2 RID: 126930 RVA: 0x00453D81 File Offset: 0x00451F81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFD3 RID: 126931 RVA: 0x00453D88 File Offset: 0x00451F88
		public static ICheckBvbActivityRank GetRootAsICheckBvbActivityRank(ByteBuffer _bb)
		{
			return ICheckBvbActivityRank.GetRootAsICheckBvbActivityRank(_bb, default(ICheckBvbActivityRank));
		}

		// Token: 0x0601EFD4 RID: 126932 RVA: 0x00453DA4 File Offset: 0x00451FA4
		public static ICheckBvbActivityRank GetRootAsICheckBvbActivityRank(ByteBuffer _bb, ICheckBvbActivityRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFD5 RID: 126933 RVA: 0x00453DC1 File Offset: 0x00451FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFD6 RID: 126934 RVA: 0x00453DD0 File Offset: 0x00451FD0
		public ICheckBvbActivityRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008EB9 RID: 36537
		// (get) Token: 0x0601EFD7 RID: 126935 RVA: 0x00453DE0 File Offset: 0x00451FE0
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

		// Token: 0x17008EBA RID: 36538
		// (get) Token: 0x0601EFD8 RID: 126936 RVA: 0x00453E1C File Offset: 0x0045201C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008EBB RID: 36539
		// (get) Token: 0x0601EFD9 RID: 126937 RVA: 0x00453E58 File Offset: 0x00452058
		public int Rank
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EFDA RID: 126938 RVA: 0x00453E94 File Offset: 0x00452094
		public static Offset<ICheckBvbActivityRank> CreateICheckBvbActivityRank(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int Rank = 0)
		{
			builder.StartTable(3);
			ICheckBvbActivityRank.AddRank(builder, Rank);
			ICheckBvbActivityRank.AddCompare(builder, Compare);
			ICheckBvbActivityRank.AddType(builder, Type);
			return ICheckBvbActivityRank.EndICheckBvbActivityRank(builder);
		}

		// Token: 0x0601EFDB RID: 126939 RVA: 0x00453EB8 File Offset: 0x004520B8
		public static void StartICheckBvbActivityRank(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EFDC RID: 126940 RVA: 0x00453EC1 File Offset: 0x004520C1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFDD RID: 126941 RVA: 0x00453ECC File Offset: 0x004520CC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601EFDE RID: 126942 RVA: 0x00453ED7 File Offset: 0x004520D7
		public static void AddRank(FlatBufferBuilder builder, int rank)
		{
			builder.AddInt(2, rank, 0);
		}

		// Token: 0x0601EFDF RID: 126943 RVA: 0x00453EE2 File Offset: 0x004520E2
		public static Offset<ICheckBvbActivityRank> EndICheckBvbActivityRank(FlatBufferBuilder builder)
		{
			return new Offset<ICheckBvbActivityRank>(builder.EndTable());
		}

		// Token: 0x0601EFE0 RID: 126944 RVA: 0x00453EF0 File Offset: 0x004520F0
		public ICheckBvbActivityRankT UnPack()
		{
			ICheckBvbActivityRankT checkBvbActivityRankT = new ICheckBvbActivityRankT();
			this.UnPackTo(checkBvbActivityRankT);
			return checkBvbActivityRankT;
		}

		// Token: 0x0601EFE1 RID: 126945 RVA: 0x00453F0B File Offset: 0x0045210B
		public void UnPackTo(ICheckBvbActivityRankT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.Rank = this.Rank;
		}

		// Token: 0x0601EFE2 RID: 126946 RVA: 0x00453F34 File Offset: 0x00452134
		public static Offset<ICheckBvbActivityRank> Pack(FlatBufferBuilder builder, ICheckBvbActivityRankT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckBvbActivityRank>);
			}
			return ICheckBvbActivityRank.CreateICheckBvbActivityRank(builder, _o.Type, _o.Compare, _o.Rank);
		}

		// Token: 0x0400DC61 RID: 56417
		private Table __p;
	}
}
