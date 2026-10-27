using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE9 RID: 16361
	public struct IQuestFailedConfig : IFlatbufferObject
	{
		// Token: 0x170072CE RID: 29390
		// (get) Token: 0x060178C9 RID: 96457 RVA: 0x0036562E File Offset: 0x0036382E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060178CA RID: 96458 RVA: 0x0036563B File Offset: 0x0036383B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060178CB RID: 96459 RVA: 0x00365644 File Offset: 0x00363844
		public static IQuestFailedConfig GetRootAsIQuestFailedConfig(ByteBuffer _bb)
		{
			return IQuestFailedConfig.GetRootAsIQuestFailedConfig(_bb, default(IQuestFailedConfig));
		}

		// Token: 0x060178CC RID: 96460 RVA: 0x00365660 File Offset: 0x00363860
		public static IQuestFailedConfig GetRootAsIQuestFailedConfig(ByteBuffer _bb, IQuestFailedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060178CD RID: 96461 RVA: 0x0036567D File Offset: 0x0036387D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060178CE RID: 96462 RVA: 0x0036568C File Offset: 0x0036388C
		public IQuestFailedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170072CF RID: 29391
		// (get) Token: 0x060178CF RID: 96463 RVA: 0x0036569C File Offset: 0x0036389C
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

		// Token: 0x170072D0 RID: 29392
		// (get) Token: 0x060178D0 RID: 96464 RVA: 0x003656D8 File Offset: 0x003638D8
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

		// Token: 0x060178D1 RID: 96465 RVA: 0x00365714 File Offset: 0x00363914
		public static Offset<IQuestFailedConfig> CreateIQuestFailedConfig(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, byte NullMask = 0)
		{
			builder.StartTable(2);
			IQuestFailedConfig.AddNullMask(builder, NullMask);
			IQuestFailedConfig.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IQuestFailedConfig.EndIQuestFailedConfig(builder);
		}

		// Token: 0x060178D2 RID: 96466 RVA: 0x00365731 File Offset: 0x00363931
		public static void StartIQuestFailedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060178D3 RID: 96467 RVA: 0x0036573A File Offset: 0x0036393A
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x060178D4 RID: 96468 RVA: 0x00365745 File Offset: 0x00363945
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060178D5 RID: 96469 RVA: 0x00365750 File Offset: 0x00363950
		public static Offset<IQuestFailedConfig> EndIQuestFailedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConfig>(builder.EndTable());
		}

		// Token: 0x060178D6 RID: 96470 RVA: 0x00365760 File Offset: 0x00363960
		public IQuestFailedConfigT UnPack()
		{
			IQuestFailedConfigT questFailedConfigT = new IQuestFailedConfigT();
			this.UnPackTo(questFailedConfigT);
			return questFailedConfigT;
		}

		// Token: 0x060178D7 RID: 96471 RVA: 0x0036577B File Offset: 0x0036397B
		public void UnPackTo(IQuestFailedConfigT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060178D8 RID: 96472 RVA: 0x00365798 File Offset: 0x00363998
		public static Offset<IQuestFailedConfig> Pack(FlatBufferBuilder builder, IQuestFailedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConfig>);
			}
			return IQuestFailedConfig.CreateIQuestFailedConfig(builder, _o.OnlineParticipateRule, _o.NullMask);
		}

		// Token: 0x0400BAE8 RID: 47848
		private Table __p;
	}
}
