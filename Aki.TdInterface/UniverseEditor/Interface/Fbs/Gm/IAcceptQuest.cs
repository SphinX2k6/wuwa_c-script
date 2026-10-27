using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004627 RID: 17959
	public struct IAcceptQuest : IFlatbufferObject
	{
		// Token: 0x17007F77 RID: 32631
		// (get) Token: 0x0601B325 RID: 111397 RVA: 0x003DF806 File Offset: 0x003DDA06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B326 RID: 111398 RVA: 0x003DF813 File Offset: 0x003DDA13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B327 RID: 111399 RVA: 0x003DF81C File Offset: 0x003DDA1C
		public static IAcceptQuest GetRootAsIAcceptQuest(ByteBuffer _bb)
		{
			return IAcceptQuest.GetRootAsIAcceptQuest(_bb, default(IAcceptQuest));
		}

		// Token: 0x0601B328 RID: 111400 RVA: 0x003DF838 File Offset: 0x003DDA38
		public static IAcceptQuest GetRootAsIAcceptQuest(ByteBuffer _bb, IAcceptQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B329 RID: 111401 RVA: 0x003DF855 File Offset: 0x003DDA55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B32A RID: 111402 RVA: 0x003DF864 File Offset: 0x003DDA64
		public IAcceptQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F78 RID: 32632
		// (get) Token: 0x0601B32B RID: 111403 RVA: 0x003DF874 File Offset: 0x003DDA74
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F79 RID: 32633
		// (get) Token: 0x0601B32C RID: 111404 RVA: 0x003DF8B0 File Offset: 0x003DDAB0
		public int QuestId
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

		// Token: 0x0601B32D RID: 111405 RVA: 0x003DF8EC File Offset: 0x003DDAEC
		public static Offset<IAcceptQuest> CreateIAcceptQuest(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int QuestId = 0)
		{
			builder.StartTable(2);
			IAcceptQuest.AddQuestId(builder, QuestId);
			IAcceptQuest.AddType(builder, Type);
			return IAcceptQuest.EndIAcceptQuest(builder);
		}

		// Token: 0x0601B32E RID: 111406 RVA: 0x003DF909 File Offset: 0x003DDB09
		public static void StartIAcceptQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B32F RID: 111407 RVA: 0x003DF912 File Offset: 0x003DDB12
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B330 RID: 111408 RVA: 0x003DF91D File Offset: 0x003DDB1D
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601B331 RID: 111409 RVA: 0x003DF928 File Offset: 0x003DDB28
		public static Offset<IAcceptQuest> EndIAcceptQuest(FlatBufferBuilder builder)
		{
			return new Offset<IAcceptQuest>(builder.EndTable());
		}

		// Token: 0x0601B332 RID: 111410 RVA: 0x003DF938 File Offset: 0x003DDB38
		public IAcceptQuestT UnPack()
		{
			IAcceptQuestT acceptQuestT = new IAcceptQuestT();
			this.UnPackTo(acceptQuestT);
			return acceptQuestT;
		}

		// Token: 0x0601B333 RID: 111411 RVA: 0x003DF953 File Offset: 0x003DDB53
		public void UnPackTo(IAcceptQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0601B334 RID: 111412 RVA: 0x003DF970 File Offset: 0x003DDB70
		public static Offset<IAcceptQuest> Pack(FlatBufferBuilder builder, IAcceptQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcceptQuest>);
			}
			return IAcceptQuest.CreateIAcceptQuest(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x0400C7A0 RID: 51104
		private Table __p;
	}
}
