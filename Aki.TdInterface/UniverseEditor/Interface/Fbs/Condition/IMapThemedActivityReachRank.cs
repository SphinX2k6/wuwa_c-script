using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C52 RID: 19538
	public struct IMapThemedActivityReachRank : IFlatbufferObject
	{
		// Token: 0x17008DF6 RID: 36342
		// (get) Token: 0x0601EFA9 RID: 126889 RVA: 0x004554E4 File Offset: 0x004536E4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EFAA RID: 126890 RVA: 0x004554F1 File Offset: 0x004536F1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EFAB RID: 126891 RVA: 0x004554F8 File Offset: 0x004536F8
		public static IMapThemedActivityReachRank GetRootAsIMapThemedActivityReachRank(ByteBuffer _bb)
		{
			return IMapThemedActivityReachRank.GetRootAsIMapThemedActivityReachRank(_bb, default(IMapThemedActivityReachRank));
		}

		// Token: 0x0601EFAC RID: 126892 RVA: 0x00455514 File Offset: 0x00453714
		public static IMapThemedActivityReachRank GetRootAsIMapThemedActivityReachRank(ByteBuffer _bb, IMapThemedActivityReachRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EFAD RID: 126893 RVA: 0x00455531 File Offset: 0x00453731
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EFAE RID: 126894 RVA: 0x00455540 File Offset: 0x00453740
		public IMapThemedActivityReachRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DF7 RID: 36343
		// (get) Token: 0x0601EFAF RID: 126895 RVA: 0x00455550 File Offset: 0x00453750
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

		// Token: 0x17008DF8 RID: 36344
		// (get) Token: 0x0601EFB0 RID: 126896 RVA: 0x0045558C File Offset: 0x0045378C
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

		// Token: 0x0601EFB1 RID: 126897 RVA: 0x004555C8 File Offset: 0x004537C8
		public static Offset<IMapThemedActivityReachRank> CreateIMapThemedActivityReachRank(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int TargetRank = 0)
		{
			builder.StartTable(2);
			IMapThemedActivityReachRank.AddTargetRank(builder, TargetRank);
			IMapThemedActivityReachRank.AddType(builder, Type);
			return IMapThemedActivityReachRank.EndIMapThemedActivityReachRank(builder);
		}

		// Token: 0x0601EFB2 RID: 126898 RVA: 0x004555E5 File Offset: 0x004537E5
		public static void StartIMapThemedActivityReachRank(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EFB3 RID: 126899 RVA: 0x004555EE File Offset: 0x004537EE
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EFB4 RID: 126900 RVA: 0x004555F9 File Offset: 0x004537F9
		public static void AddTargetRank(FlatBufferBuilder builder, int targetRank)
		{
			builder.AddInt(1, targetRank, 0);
		}

		// Token: 0x0601EFB5 RID: 126901 RVA: 0x00455604 File Offset: 0x00453804
		public static Offset<IMapThemedActivityReachRank> EndIMapThemedActivityReachRank(FlatBufferBuilder builder)
		{
			return new Offset<IMapThemedActivityReachRank>(builder.EndTable());
		}

		// Token: 0x0601EFB6 RID: 126902 RVA: 0x00455614 File Offset: 0x00453814
		public IMapThemedActivityReachRankT UnPack()
		{
			IMapThemedActivityReachRankT mapThemedActivityReachRankT = new IMapThemedActivityReachRankT();
			this.UnPackTo(mapThemedActivityReachRankT);
			return mapThemedActivityReachRankT;
		}

		// Token: 0x0601EFB7 RID: 126903 RVA: 0x0045562F File Offset: 0x0045382F
		public void UnPackTo(IMapThemedActivityReachRankT _o)
		{
			_o.Type = this.Type;
			_o.TargetRank = this.TargetRank;
		}

		// Token: 0x0601EFB8 RID: 126904 RVA: 0x0045564C File Offset: 0x0045384C
		public static Offset<IMapThemedActivityReachRank> Pack(FlatBufferBuilder builder, IMapThemedActivityReachRankT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMapThemedActivityReachRank>);
			}
			return IMapThemedActivityReachRank.CreateIMapThemedActivityReachRank(builder, _o.Type, _o.TargetRank);
		}

		// Token: 0x0400D5FC RID: 54780
		private Table __p;
	}
}
