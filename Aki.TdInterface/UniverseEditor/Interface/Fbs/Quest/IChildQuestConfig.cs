using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A2 RID: 16802
	public struct IChildQuestConfig : IFlatbufferObject
	{
		// Token: 0x1700720D RID: 29197
		// (get) Token: 0x0601732A RID: 95018 RVA: 0x0034FF1F File Offset: 0x0034E11F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601732B RID: 95019 RVA: 0x0034FF2C File Offset: 0x0034E12C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601732C RID: 95020 RVA: 0x0034FF34 File Offset: 0x0034E134
		public static IChildQuestConfig GetRootAsIChildQuestConfig(ByteBuffer _bb)
		{
			return IChildQuestConfig.GetRootAsIChildQuestConfig(_bb, default(IChildQuestConfig));
		}

		// Token: 0x0601732D RID: 95021 RVA: 0x0034FF50 File Offset: 0x0034E150
		public static IChildQuestConfig GetRootAsIChildQuestConfig(ByteBuffer _bb, IChildQuestConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601732E RID: 95022 RVA: 0x0034FF6D File Offset: 0x0034E16D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601732F RID: 95023 RVA: 0x0034FF7C File Offset: 0x0034E17C
		public IChildQuestConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700720E RID: 29198
		// (get) Token: 0x06017330 RID: 95024 RVA: 0x0034FF8C File Offset: 0x0034E18C
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

		// Token: 0x1700720F RID: 29199
		// (get) Token: 0x06017331 RID: 95025 RVA: 0x0034FFC8 File Offset: 0x0034E1C8
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

		// Token: 0x06017332 RID: 95026 RVA: 0x00350004 File Offset: 0x0034E204
		public static Offset<IChildQuestConfig> CreateIChildQuestConfig(FlatBufferBuilder builder, EOnlineParticipateRule OnlineParticipateRule = EOnlineParticipateRule.AnyPlayer, byte NullMask = 0)
		{
			builder.StartTable(2);
			IChildQuestConfig.AddNullMask(builder, NullMask);
			IChildQuestConfig.AddOnlineParticipateRule(builder, OnlineParticipateRule);
			return IChildQuestConfig.EndIChildQuestConfig(builder);
		}

		// Token: 0x06017333 RID: 95027 RVA: 0x00350021 File Offset: 0x0034E221
		public static void StartIChildQuestConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017334 RID: 95028 RVA: 0x0035002A File Offset: 0x0034E22A
		public static void AddOnlineParticipateRule(FlatBufferBuilder builder, EOnlineParticipateRule onlineParticipateRule)
		{
			builder.AddByte(0, (byte)onlineParticipateRule, 0);
		}

		// Token: 0x06017335 RID: 95029 RVA: 0x00350035 File Offset: 0x0034E235
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x06017336 RID: 95030 RVA: 0x00350040 File Offset: 0x0034E240
		public static Offset<IChildQuestConfig> EndIChildQuestConfig(FlatBufferBuilder builder)
		{
			return new Offset<IChildQuestConfig>(builder.EndTable());
		}

		// Token: 0x06017337 RID: 95031 RVA: 0x00350050 File Offset: 0x0034E250
		public IChildQuestConfigT UnPack()
		{
			IChildQuestConfigT childQuestConfigT = new IChildQuestConfigT();
			this.UnPackTo(childQuestConfigT);
			return childQuestConfigT;
		}

		// Token: 0x06017338 RID: 95032 RVA: 0x0035006B File Offset: 0x0034E26B
		public void UnPackTo(IChildQuestConfigT _o)
		{
			_o.OnlineParticipateRule = this.OnlineParticipateRule;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017339 RID: 95033 RVA: 0x00350088 File Offset: 0x0034E288
		public static Offset<IChildQuestConfig> Pack(FlatBufferBuilder builder, IChildQuestConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChildQuestConfig>);
			}
			return IChildQuestConfig.CreateIChildQuestConfig(builder, _o.OnlineParticipateRule, _o.NullMask);
		}

		// Token: 0x0400C03F RID: 49215
		private Table __p;
	}
}
