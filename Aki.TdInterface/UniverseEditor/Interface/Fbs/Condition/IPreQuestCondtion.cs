using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005196 RID: 20886
	public struct IPreQuestCondtion : IFlatbufferObject
	{
		// Token: 0x17009596 RID: 38294
		// (get) Token: 0x06020DE7 RID: 134631 RVA: 0x0048C600 File Offset: 0x0048A800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020DE8 RID: 134632 RVA: 0x0048C60D File Offset: 0x0048A80D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020DE9 RID: 134633 RVA: 0x0048C614 File Offset: 0x0048A814
		public static IPreQuestCondtion GetRootAsIPreQuestCondtion(ByteBuffer _bb)
		{
			return IPreQuestCondtion.GetRootAsIPreQuestCondtion(_bb, default(IPreQuestCondtion));
		}

		// Token: 0x06020DEA RID: 134634 RVA: 0x0048C630 File Offset: 0x0048A830
		public static IPreQuestCondtion GetRootAsIPreQuestCondtion(ByteBuffer _bb, IPreQuestCondtion obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020DEB RID: 134635 RVA: 0x0048C64D File Offset: 0x0048A84D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020DEC RID: 134636 RVA: 0x0048C65C File Offset: 0x0048A85C
		public IPreQuestCondtion __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009597 RID: 38295
		// (get) Token: 0x06020DED RID: 134637 RVA: 0x0048C66C File Offset: 0x0048A86C
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

		// Token: 0x17009598 RID: 38296
		// (get) Token: 0x06020DEE RID: 134638 RVA: 0x0048C6A8 File Offset: 0x0048A8A8
		public int PreQuest
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

		// Token: 0x06020DEF RID: 134639 RVA: 0x0048C6E4 File Offset: 0x0048A8E4
		public static Offset<IPreQuestCondtion> CreateIPreQuestCondtion(FlatBufferBuilder builder, EAccessQuestCondition Type = EAccessQuestCondition.ExploreLevel, int PreQuest = 0)
		{
			builder.StartTable(2);
			IPreQuestCondtion.AddPreQuest(builder, PreQuest);
			IPreQuestCondtion.AddType(builder, Type);
			return IPreQuestCondtion.EndIPreQuestCondtion(builder);
		}

		// Token: 0x06020DF0 RID: 134640 RVA: 0x0048C701 File Offset: 0x0048A901
		public static void StartIPreQuestCondtion(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06020DF1 RID: 134641 RVA: 0x0048C70A File Offset: 0x0048A90A
		public static void AddType(FlatBufferBuilder builder, EAccessQuestCondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020DF2 RID: 134642 RVA: 0x0048C715 File Offset: 0x0048A915
		public static void AddPreQuest(FlatBufferBuilder builder, int preQuest)
		{
			builder.AddInt(1, preQuest, 0);
		}

		// Token: 0x06020DF3 RID: 134643 RVA: 0x0048C720 File Offset: 0x0048A920
		public static Offset<IPreQuestCondtion> EndIPreQuestCondtion(FlatBufferBuilder builder)
		{
			return new Offset<IPreQuestCondtion>(builder.EndTable());
		}

		// Token: 0x06020DF4 RID: 134644 RVA: 0x0048C730 File Offset: 0x0048A930
		public IPreQuestCondtionT UnPack()
		{
			IPreQuestCondtionT preQuestCondtionT = new IPreQuestCondtionT();
			this.UnPackTo(preQuestCondtionT);
			return preQuestCondtionT;
		}

		// Token: 0x06020DF5 RID: 134645 RVA: 0x0048C74B File Offset: 0x0048A94B
		public void UnPackTo(IPreQuestCondtionT _o)
		{
			_o.Type = this.Type;
			_o.PreQuest = this.PreQuest;
		}

		// Token: 0x06020DF6 RID: 134646 RVA: 0x0048C768 File Offset: 0x0048A968
		public static Offset<IPreQuestCondtion> Pack(FlatBufferBuilder builder, IPreQuestCondtionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreQuestCondtion>);
			}
			return IPreQuestCondtion.CreateIPreQuestCondtion(builder, _o.Type, _o.PreQuest);
		}

		// Token: 0x0400E17F RID: 57727
		private Table __p;
	}
}
