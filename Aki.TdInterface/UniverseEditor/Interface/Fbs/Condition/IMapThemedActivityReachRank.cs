using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005145 RID: 20805
	public struct IMapThemedActivityReachRank : IFlatbufferObject
	{
		// Token: 0x1700951F RID: 38175
		// (get) Token: 0x06020BAD RID: 134061 RVA: 0x00488DC0 File Offset: 0x00486FC0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020BAE RID: 134062 RVA: 0x00488DCD File Offset: 0x00486FCD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020BAF RID: 134063 RVA: 0x00488DD4 File Offset: 0x00486FD4
		public static IMapThemedActivityReachRank GetRootAsIMapThemedActivityReachRank(ByteBuffer _bb)
		{
			return IMapThemedActivityReachRank.GetRootAsIMapThemedActivityReachRank(_bb, default(IMapThemedActivityReachRank));
		}

		// Token: 0x06020BB0 RID: 134064 RVA: 0x00488DF0 File Offset: 0x00486FF0
		public static IMapThemedActivityReachRank GetRootAsIMapThemedActivityReachRank(ByteBuffer _bb, IMapThemedActivityReachRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020BB1 RID: 134065 RVA: 0x00488E0D File Offset: 0x0048700D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020BB2 RID: 134066 RVA: 0x00488E1C File Offset: 0x0048701C
		public IMapThemedActivityReachRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009520 RID: 38176
		// (get) Token: 0x06020BB3 RID: 134067 RVA: 0x00488E2C File Offset: 0x0048702C
		public EAccessQuestCondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAccessQuestCondition.ExploreLevel;
				}
				return (EAccessQuestCondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009521 RID: 38177
		// (get) Token: 0x06020BB4 RID: 134068 RVA: 0x00488E68 File Offset: 0x00487068
		public int TargetRank
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

		// Token: 0x06020BB5 RID: 134069 RVA: 0x00488EA4 File Offset: 0x004870A4
		public static Offset<IMapThemedActivityReachRank> CreateIMapThemedActivityReachRank(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int TargetRank = 0)
		{
			builder.StartTable(2);
			IMapThemedActivityReachRank.AddTargetRank(builder, TargetRank);
			IMapThemedActivityReachRank.AddType(builder, Type);
			return IMapThemedActivityReachRank.EndIMapThemedActivityReachRank(builder);
		}

		// Token: 0x06020BB6 RID: 134070 RVA: 0x00488EC1 File Offset: 0x004870C1
		public static void StartIMapThemedActivityReachRank(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020BB7 RID: 134071 RVA: 0x00488ECA File Offset: 0x004870CA
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020BB8 RID: 134072 RVA: 0x00488ED5 File Offset: 0x004870D5
		public static void AddTargetRank(FlatBufferBuilder builder, int targetRank)
		{
			builder.AddInt(1, targetRank, 0);
		}

		// Token: 0x06020BB9 RID: 134073 RVA: 0x00488EE0 File Offset: 0x004870E0
		public static Offset<IMapThemedActivityReachRank> EndIMapThemedActivityReachRank(FlatBufferBuilder builder)
		{
			return new Offset<IMapThemedActivityReachRank>(builder.EndTable());
		}

		// Token: 0x06020BBA RID: 134074 RVA: 0x00488EF0 File Offset: 0x004870F0
		public IMapThemedActivityReachRankT UnPack()
		{
			IMapThemedActivityReachRankT mapThemedActivityReachRankT = new IMapThemedActivityReachRankT();
			this.UnPackTo(mapThemedActivityReachRankT);
			return mapThemedActivityReachRankT;
		}

		// Token: 0x06020BBB RID: 134075 RVA: 0x00488F0B File Offset: 0x0048710B
		public void UnPackTo(IMapThemedActivityReachRankT _o)
		{
			_o.Type = this.Type;
			_o.TargetRank = this.TargetRank;
		}

		// Token: 0x06020BBC RID: 134076 RVA: 0x00488F28 File Offset: 0x00487128
		public static Offset<IMapThemedActivityReachRank> Pack(FlatBufferBuilder builder, IMapThemedActivityReachRankT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMapThemedActivityReachRank>);
			}
			return IMapThemedActivityReachRank.CreateIMapThemedActivityReachRank(builder, _o.Type, _o.TargetRank);
		}

		// Token: 0x0400E11B RID: 57627
		private Table __p;
	}
}
