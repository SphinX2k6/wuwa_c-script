using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200442A RID: 17450
	public struct IQuestFailedConfig : IFlatbufferObject
	{
		// Token: 0x170078D0 RID: 30928
		// (get) Token: 0x06018F62 RID: 102242 RVA: 0x0038F422 File Offset: 0x0038D622
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018F63 RID: 102243 RVA: 0x0038F42F File Offset: 0x0038D62F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018F64 RID: 102244 RVA: 0x0038F438 File Offset: 0x0038D638
		public static IQuestFailedConfig GetRootAsIQuestFailedConfig(ByteBuffer _bb)
		{
			return IQuestFailedConfig.GetRootAsIQuestFailedConfig(_bb, default(IQuestFailedConfig));
		}

		// Token: 0x06018F65 RID: 102245 RVA: 0x0038F454 File Offset: 0x0038D654
		public static IQuestFailedConfig GetRootAsIQuestFailedConfig(ByteBuffer _bb, IQuestFailedConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018F66 RID: 102246 RVA: 0x0038F471 File Offset: 0x0038D671
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018F67 RID: 102247 RVA: 0x0038F480 File Offset: 0x0038D680
		public IQuestFailedConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078D1 RID: 30929
		// (get) Token: 0x06018F68 RID: 102248 RVA: 0x0038F490 File Offset: 0x0038D690
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

		// Token: 0x170078D2 RID: 30930
		// (get) Token: 0x06018F69 RID: 102249 RVA: 0x0038F4CC File Offset: 0x0038D6CC
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

		// Token: 0x06018F6A RID: 102250 RVA: 0x0038F508 File Offset: 0x0038D708
		public static Offset<IQuestFailedConfig> CreateIQuestFailedConfig(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, byte NullMask = 0)
		{
			builder.StartTable(2);
			IQuestFailedConfig.AddNullMask(builder, NullMask);
			IQuestFailedConfig.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IQuestFailedConfig.EndIQuestFailedConfig(builder);
		}

		// Token: 0x06018F6B RID: 102251 RVA: 0x0038F525 File Offset: 0x0038D725
		public static void StartIQuestFailedConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018F6C RID: 102252 RVA: 0x0038F52E File Offset: 0x0038D72E
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x06018F6D RID: 102253 RVA: 0x0038F539 File Offset: 0x0038D739
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06018F6E RID: 102254 RVA: 0x0038F544 File Offset: 0x0038D744
		public static Offset<IQuestFailedConfig> EndIQuestFailedConfig(FlatBufferBuilder builder)
		{
			return new Offset<IQuestFailedConfig>(builder.EndTable());
		}

		// Token: 0x06018F6F RID: 102255 RVA: 0x0038F554 File Offset: 0x0038D754
		public IQuestFailedConfigT UnPack()
		{
			IQuestFailedConfigT questFailedConfigT = new IQuestFailedConfigT();
			this.UnPackTo(questFailedConfigT);
			return questFailedConfigT;
		}

		// Token: 0x06018F70 RID: 102256 RVA: 0x0038F56F File Offset: 0x0038D76F
		public void UnPackTo(IQuestFailedConfigT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018F71 RID: 102257 RVA: 0x0038F58C File Offset: 0x0038D78C
		public static Offset<IQuestFailedConfig> Pack(FlatBufferBuilder builder, IQuestFailedConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQuestFailedConfig>);
			}
			return IQuestFailedConfig.CreateIQuestFailedConfig(builder, _o.OnlineParticipateRule, _o.NullMask);
		}

		// Token: 0x0400C4CF RID: 50383
		private Table __p;
	}
}
