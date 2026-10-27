using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D8B RID: 15755
	public struct IChildQuestConfig : IFlatbufferObject
	{
		// Token: 0x17006C53 RID: 27731
		// (get) Token: 0x06015DF2 RID: 89586 RVA: 0x00328BF3 File Offset: 0x00326DF3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015DF3 RID: 89587 RVA: 0x00328C00 File Offset: 0x00326E00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015DF4 RID: 89588 RVA: 0x00328C08 File Offset: 0x00326E08
		public static IChildQuestConfig GetRootAsIChildQuestConfig(ByteBuffer _bb)
		{
			return IChildQuestConfig.GetRootAsIChildQuestConfig(_bb, default(IChildQuestConfig));
		}

		// Token: 0x06015DF5 RID: 89589 RVA: 0x00328C24 File Offset: 0x00326E24
		public static IChildQuestConfig GetRootAsIChildQuestConfig(ByteBuffer _bb, IChildQuestConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015DF6 RID: 89590 RVA: 0x00328C41 File Offset: 0x00326E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015DF7 RID: 89591 RVA: 0x00328C50 File Offset: 0x00326E50
		public IChildQuestConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C54 RID: 27732
		// (get) Token: 0x06015DF8 RID: 89592 RVA: 0x00328C60 File Offset: 0x00326E60
		public EOnlineParticipateRule OnlineParticipateRule
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOnlineParticipateRule.AnyPlayer;
				}
				return (EOnlineParticipateRule)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006C55 RID: 27733
		// (get) Token: 0x06015DF9 RID: 89593 RVA: 0x00328C9C File Offset: 0x00326E9C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015DFA RID: 89594 RVA: 0x00328CD8 File Offset: 0x00326ED8
		public static Offset<IChildQuestConfig> CreateIChildQuestConfig(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, byte NullMask = 0)
		{
			builder.StartTable(2);
			IChildQuestConfig.AddNullMask(builder, NullMask);
			IChildQuestConfig.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IChildQuestConfig.EndIChildQuestConfig(builder);
		}

		// Token: 0x06015DFB RID: 89595 RVA: 0x00328CF5 File Offset: 0x00326EF5
		public static void StartIChildQuestConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015DFC RID: 89596 RVA: 0x00328CFE File Offset: 0x00326EFE
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x06015DFD RID: 89597 RVA: 0x00328D09 File Offset: 0x00326F09
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06015DFE RID: 89598 RVA: 0x00328D14 File Offset: 0x00326F14
		public static Offset<IChildQuestConfig> EndIChildQuestConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChildQuestConfig>(builder.EndTable());
		}

		// Token: 0x06015DFF RID: 89599 RVA: 0x00328D24 File Offset: 0x00326F24
		public IChildQuestConfigT UnPack()
		{
			IChildQuestConfigT childQuestConfigT = new IChildQuestConfigT();
			this.UnPackTo(childQuestConfigT);
			return childQuestConfigT;
		}

		// Token: 0x06015E00 RID: 89600 RVA: 0x00328D3F File Offset: 0x00326F3F
		public void UnPackTo(IChildQuestConfigT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06015E01 RID: 89601 RVA: 0x00328D5C File Offset: 0x00326F5C
		public static Offset<IChildQuestConfig> Pack(FlatBufferBuilder builder, IChildQuestConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildQuestConfig>);
			}
			return IChildQuestConfig.CreateIChildQuestConfig(builder, _o.OnlineParticipateRule, _o.NullMask);
		}

		// Token: 0x0400B692 RID: 46738
		private Table __p;
	}
}
