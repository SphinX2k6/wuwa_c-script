using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200510C RID: 20748
	public struct IExploreLevelCondtion : IFlatbufferObject
	{
		// Token: 0x170094B2 RID: 38066
		// (get) Token: 0x060209D5 RID: 133589 RVA: 0x00485A2D File Offset: 0x00483C2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060209D6 RID: 133590 RVA: 0x00485A3A File Offset: 0x00483C3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060209D7 RID: 133591 RVA: 0x00485A44 File Offset: 0x00483C44
		public static IExploreLevelCondtion GetRootAsIExploreLevelCondtion(ByteBuffer _bb)
		{
			return IExploreLevelCondtion.GetRootAsIExploreLevelCondtion(_bb, default(IExploreLevelCondtion));
		}

		// Token: 0x060209D8 RID: 133592 RVA: 0x00485A60 File Offset: 0x00483C60
		public static IExploreLevelCondtion GetRootAsIExploreLevelCondtion(ByteBuffer _bb, IExploreLevelCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060209D9 RID: 133593 RVA: 0x00485A7D File Offset: 0x00483C7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060209DA RID: 133594 RVA: 0x00485A8C File Offset: 0x00483C8C
		public IExploreLevelCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094B3 RID: 38067
		// (get) Token: 0x060209DB RID: 133595 RVA: 0x00485A9C File Offset: 0x00483C9C
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

		// Token: 0x170094B4 RID: 38068
		// (get) Token: 0x060209DC RID: 133596 RVA: 0x00485AD8 File Offset: 0x00483CD8
		public int ExploreLevel
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

		// Token: 0x060209DD RID: 133597 RVA: 0x00485B14 File Offset: 0x00483D14
		public static Offset<IExploreLevelCondtion> CreateIExploreLevelCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int ExploreLevel = 0)
		{
			builder.StartTable(2);
			IExploreLevelCondtion.AddExploreLevel(builder, ExploreLevel);
			IExploreLevelCondtion.AddType(builder, Type);
			return IExploreLevelCondtion.EndIExploreLevelCondtion(builder);
		}

		// Token: 0x060209DE RID: 133598 RVA: 0x00485B31 File Offset: 0x00483D31
		public static void StartIExploreLevelCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060209DF RID: 133599 RVA: 0x00485B3A File Offset: 0x00483D3A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060209E0 RID: 133600 RVA: 0x00485B45 File Offset: 0x00483D45
		public static void AddExploreLevel(FlatBufferBuilder builder, int exploreLevel)
		{
			builder.AddInt(1, exploreLevel, 0);
		}

		// Token: 0x060209E1 RID: 133601 RVA: 0x00485B50 File Offset: 0x00483D50
		public static Offset<IExploreLevelCondtion> EndIExploreLevelCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IExploreLevelCondtion>(builder.EndTable());
		}

		// Token: 0x060209E2 RID: 133602 RVA: 0x00485B60 File Offset: 0x00483D60
		public IExploreLevelCondtionT UnPack()
		{
			IExploreLevelCondtionT exploreLevelCondtionT = new IExploreLevelCondtionT();
			this.UnPackTo(exploreLevelCondtionT);
			return exploreLevelCondtionT;
		}

		// Token: 0x060209E3 RID: 133603 RVA: 0x00485B7B File Offset: 0x00483D7B
		public void UnPackTo(IExploreLevelCondtionT _o)
		{
			_o.Type = this.Type;
			_o.ExploreLevel = this.ExploreLevel;
		}

		// Token: 0x060209E4 RID: 133604 RVA: 0x00485B98 File Offset: 0x00483D98
		public static Offset<IExploreLevelCondtion> Pack(FlatBufferBuilder builder, IExploreLevelCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreLevelCondtion>);
			}
			return IExploreLevelCondtion.CreateIExploreLevelCondtion(builder, _o.Type, _o.ExploreLevel);
		}

		// Token: 0x0400E0CE RID: 57550
		private Table __p;
	}
}
