using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200496D RID: 18797
	public struct IBaseAccessQuestCondition : IFlatbufferObject
	{
		// Token: 0x170087CB RID: 34763
		// (get) Token: 0x0601D4B8 RID: 119992 RVA: 0x00421ED2 File Offset: 0x004200D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D4B9 RID: 119993 RVA: 0x00421EDF File Offset: 0x004200DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D4BA RID: 119994 RVA: 0x00421EE8 File Offset: 0x004200E8
		public static IBaseAccessQuestCondition GetRootAsIBaseAccessQuestCondition(ByteBuffer _bb)
		{
			return IBaseAccessQuestCondition.GetRootAsIBaseAccessQuestCondition(_bb, default(IBaseAccessQuestCondition));
		}

		// Token: 0x0601D4BB RID: 119995 RVA: 0x00421F04 File Offset: 0x00420104
		public static IBaseAccessQuestCondition GetRootAsIBaseAccessQuestCondition(ByteBuffer _bb, IBaseAccessQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D4BC RID: 119996 RVA: 0x00421F21 File Offset: 0x00420121
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D4BD RID: 119997 RVA: 0x00421F30 File Offset: 0x00420130
		public IBaseAccessQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170087CC RID: 34764
		// (get) Token: 0x0601D4BE RID: 119998 RVA: 0x00421F40 File Offset: 0x00420140
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

		// Token: 0x0601D4BF RID: 119999 RVA: 0x00421F7C File Offset: 0x0042017C
		public static Offset<IBaseAccessQuestCondition> CreateIBaseAccessQuestCondition(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel)
		{
			builder.StartTable(1);
			IBaseAccessQuestCondition.AddType(builder, Type);
			return IBaseAccessQuestCondition.EndIBaseAccessQuestCondition(builder);
		}

		// Token: 0x0601D4C0 RID: 120000 RVA: 0x00421F92 File Offset: 0x00420192
		public static void StartIBaseAccessQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D4C1 RID: 120001 RVA: 0x00421F9B File Offset: 0x0042019B
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D4C2 RID: 120002 RVA: 0x00421FA6 File Offset: 0x004201A6
		public static Offset<IBaseAccessQuestCondition> EndIBaseAccessQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IBaseAccessQuestCondition>(builder.EndTable());
		}

		// Token: 0x0601D4C3 RID: 120003 RVA: 0x00421FB4 File Offset: 0x004201B4
		public IBaseAccessQuestConditionT UnPack()
		{
			IBaseAccessQuestConditionT baseAccessQuestConditionT = new IBaseAccessQuestConditionT();
			this.UnPackTo(baseAccessQuestConditionT);
			return baseAccessQuestConditionT;
		}

		// Token: 0x0601D4C4 RID: 120004 RVA: 0x00421FCF File Offset: 0x004201CF
		public void UnPackTo(IBaseAccessQuestConditionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D4C5 RID: 120005 RVA: 0x00421FE0 File Offset: 0x004201E0
		public static Offset<IBaseAccessQuestCondition> Pack(FlatBufferBuilder builder, IBaseAccessQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBaseAccessQuestCondition>);
			}
			return IBaseAccessQuestCondition.CreateIBaseAccessQuestCondition(builder, _o.Type);
		}

		// Token: 0x0400D165 RID: 53605
		private Table __p;
	}
}
