using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E24 RID: 20004
	public struct IBaseAccessQuestCondition : IFlatbufferObject
	{
		// Token: 0x17008E86 RID: 36486
		// (get) Token: 0x0601EEDD RID: 126685 RVA: 0x00452386 File Offset: 0x00450586
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EEDE RID: 126686 RVA: 0x00452393 File Offset: 0x00450593
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EEDF RID: 126687 RVA: 0x0045239C File Offset: 0x0045059C
		public static IBaseAccessQuestCondition GetRootAsIBaseAccessQuestCondition(ByteBuffer _bb)
		{
			return IBaseAccessQuestCondition.GetRootAsIBaseAccessQuestCondition(_bb, default(IBaseAccessQuestCondition));
		}

		// Token: 0x0601EEE0 RID: 126688 RVA: 0x004523B8 File Offset: 0x004505B8
		public static IBaseAccessQuestCondition GetRootAsIBaseAccessQuestCondition(ByteBuffer _bb, IBaseAccessQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EEE1 RID: 126689 RVA: 0x004523D5 File Offset: 0x004505D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EEE2 RID: 126690 RVA: 0x004523E4 File Offset: 0x004505E4
		public IBaseAccessQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E87 RID: 36487
		// (get) Token: 0x0601EEE3 RID: 126691 RVA: 0x004523F4 File Offset: 0x004505F4
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

		// Token: 0x0601EEE4 RID: 126692 RVA: 0x00452430 File Offset: 0x00450630
		public static Offset<IBaseAccessQuestCondition> CreateIBaseAccessQuestCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel)
		{
			builder.StartTable(1);
			IBaseAccessQuestCondition.AddType(builder, Type);
			return IBaseAccessQuestCondition.EndIBaseAccessQuestCondition(builder);
		}

		// Token: 0x0601EEE5 RID: 126693 RVA: 0x00452446 File Offset: 0x00450646
		public static void StartIBaseAccessQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EEE6 RID: 126694 RVA: 0x0045244F File Offset: 0x0045064F
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EEE7 RID: 126695 RVA: 0x0045245A File Offset: 0x0045065A
		public static Offset<IBaseAccessQuestCondition> EndIBaseAccessQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBaseAccessQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601EEE8 RID: 126696 RVA: 0x00452468 File Offset: 0x00450668
		public IBaseAccessQuestConditionT UnPack()
		{
			IBaseAccessQuestConditionT baseAccessQuestConditionT = new IBaseAccessQuestConditionT();
			this.UnPackTo(baseAccessQuestConditionT);
			return baseAccessQuestConditionT;
		}

		// Token: 0x0601EEE9 RID: 126697 RVA: 0x00452483 File Offset: 0x00450683
		public void UnPackTo(IBaseAccessQuestConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EEEA RID: 126698 RVA: 0x00452494 File Offset: 0x00450694
		public static Offset<IBaseAccessQuestCondition> Pack(FlatBufferBuilder builder, IBaseAccessQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseAccessQuestCondition>);
			}
			return IBaseAccessQuestCondition.CreateIBaseAccessQuestCondition(builder, _o.Type);
		}

		// Token: 0x0400DC2D RID: 56365
		private Table __p;
	}
}
