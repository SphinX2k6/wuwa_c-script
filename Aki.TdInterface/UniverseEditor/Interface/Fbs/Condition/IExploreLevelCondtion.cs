using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C1F RID: 19487
	public struct IExploreLevelCondtion : IFlatbufferObject
	{
		// Token: 0x17008D8E RID: 36238
		// (get) Token: 0x0601EDEF RID: 126447 RVA: 0x004523C5 File Offset: 0x004505C5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EDF0 RID: 126448 RVA: 0x004523D2 File Offset: 0x004505D2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EDF1 RID: 126449 RVA: 0x004523DC File Offset: 0x004505DC
		public static IExploreLevelCondtion GetRootAsIExploreLevelCondtion(ByteBuffer _bb)
		{
			return IExploreLevelCondtion.GetRootAsIExploreLevelCondtion(_bb, default(IExploreLevelCondtion));
		}

		// Token: 0x0601EDF2 RID: 126450 RVA: 0x004523F8 File Offset: 0x004505F8
		public static IExploreLevelCondtion GetRootAsIExploreLevelCondtion(ByteBuffer _bb, IExploreLevelCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EDF3 RID: 126451 RVA: 0x00452415 File Offset: 0x00450615
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EDF4 RID: 126452 RVA: 0x00452424 File Offset: 0x00450624
		public IExploreLevelCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D8F RID: 36239
		// (get) Token: 0x0601EDF5 RID: 126453 RVA: 0x00452434 File Offset: 0x00450634
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

		// Token: 0x17008D90 RID: 36240
		// (get) Token: 0x0601EDF6 RID: 126454 RVA: 0x00452470 File Offset: 0x00450670
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

		// Token: 0x0601EDF7 RID: 126455 RVA: 0x004524AC File Offset: 0x004506AC
		public static Offset<IExploreLevelCondtion> CreateIExploreLevelCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int ExploreLevel = 0)
		{
			builder.StartTable(2);
			IExploreLevelCondtion.AddExploreLevel(builder, ExploreLevel);
			IExploreLevelCondtion.AddType(builder, Type);
			return IExploreLevelCondtion.EndIExploreLevelCondtion(builder);
		}

		// Token: 0x0601EDF8 RID: 126456 RVA: 0x004524C9 File Offset: 0x004506C9
		public static void StartIExploreLevelCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EDF9 RID: 126457 RVA: 0x004524D2 File Offset: 0x004506D2
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EDFA RID: 126458 RVA: 0x004524DD File Offset: 0x004506DD
		public static void AddExploreLevel(FlatBufferBuilder builder, int exploreLevel)
		{
			builder.AddInt(1, exploreLevel, 0);
		}

		// Token: 0x0601EDFB RID: 126459 RVA: 0x004524E8 File Offset: 0x004506E8
		public static Offset<IExploreLevelCondtion> EndIExploreLevelCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IExploreLevelCondtion>(builder.EndTable());
		}

		// Token: 0x0601EDFC RID: 126460 RVA: 0x004524F8 File Offset: 0x004506F8
		public IExploreLevelCondtionT UnPack()
		{
			IExploreLevelCondtionT exploreLevelCondtionT = new IExploreLevelCondtionT();
			this.UnPackTo(exploreLevelCondtionT);
			return exploreLevelCondtionT;
		}

		// Token: 0x0601EDFD RID: 126461 RVA: 0x00452513 File Offset: 0x00450713
		public void UnPackTo(IExploreLevelCondtionT _o)
		{
			_o.Type = this.Type;
			_o.ExploreLevel = this.ExploreLevel;
		}

		// Token: 0x0601EDFE RID: 126462 RVA: 0x00452530 File Offset: 0x00450730
		public static Offset<IExploreLevelCondtion> Pack(FlatBufferBuilder builder, IExploreLevelCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExploreLevelCondtion>);
			}
			return IExploreLevelCondtion.CreateIExploreLevelCondtion(builder, _o.Type, _o.ExploreLevel);
		}

		// Token: 0x0400D5B7 RID: 54711
		private Table __p;
	}
}
