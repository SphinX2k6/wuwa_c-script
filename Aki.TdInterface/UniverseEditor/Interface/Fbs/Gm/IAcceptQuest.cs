using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A8F RID: 19087
	public struct IAcceptQuest : IFlatbufferObject
	{
		// Token: 0x170085B8 RID: 34232
		// (get) Token: 0x0601CAFA RID: 117498 RVA: 0x0040BAA2 File Offset: 0x00409CA2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CAFB RID: 117499 RVA: 0x0040BAAF File Offset: 0x00409CAF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CAFC RID: 117500 RVA: 0x0040BAB8 File Offset: 0x00409CB8
		public static IAcceptQuest GetRootAsIAcceptQuest(ByteBuffer _bb)
		{
			return IAcceptQuest.GetRootAsIAcceptQuest(_bb, default(IAcceptQuest));
		}

		// Token: 0x0601CAFD RID: 117501 RVA: 0x0040BAD4 File Offset: 0x00409CD4
		public static IAcceptQuest GetRootAsIAcceptQuest(ByteBuffer _bb, IAcceptQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CAFE RID: 117502 RVA: 0x0040BAF1 File Offset: 0x00409CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CAFF RID: 117503 RVA: 0x0040BB00 File Offset: 0x00409D00
		public IAcceptQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170085B9 RID: 34233
		// (get) Token: 0x0601CB00 RID: 117504 RVA: 0x0040BB10 File Offset: 0x00409D10
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

		// Token: 0x170085BA RID: 34234
		// (get) Token: 0x0601CB01 RID: 117505 RVA: 0x0040BB4C File Offset: 0x00409D4C
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

		// Token: 0x0601CB02 RID: 117506 RVA: 0x0040BB88 File Offset: 0x00409D88
		public static Offset<IAcceptQuest> CreateIAcceptQuest(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int QuestId = 0)
		{
			builder.StartTable(2);
			IAcceptQuest.AddQuestId(builder, QuestId);
			IAcceptQuest.AddType(builder, Type);
			return IAcceptQuest.EndIAcceptQuest(builder);
		}

		// Token: 0x0601CB03 RID: 117507 RVA: 0x0040BBA5 File Offset: 0x00409DA5
		public static void StartIAcceptQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CB04 RID: 117508 RVA: 0x0040BBAE File Offset: 0x00409DAE
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CB05 RID: 117509 RVA: 0x0040BBB9 File Offset: 0x00409DB9
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601CB06 RID: 117510 RVA: 0x0040BBC4 File Offset: 0x00409DC4
		public static Offset<IAcceptQuest> EndIAcceptQuest(FlatBufferBuilder builder)
		{
			return new Offset<IAcceptQuest>(builder.EndTable());
		}

		// Token: 0x0601CB07 RID: 117511 RVA: 0x0040BBD4 File Offset: 0x00409DD4
		public IAcceptQuestT UnPack()
		{
			IAcceptQuestT acceptQuestT = new IAcceptQuestT();
			this.UnPackTo(acceptQuestT);
			return acceptQuestT;
		}

		// Token: 0x0601CB08 RID: 117512 RVA: 0x0040BBEF File Offset: 0x00409DEF
		public void UnPackTo(IAcceptQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0601CB09 RID: 117513 RVA: 0x0040BC0C File Offset: 0x00409E0C
		public static Offset<IAcceptQuest> Pack(FlatBufferBuilder builder, IAcceptQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAcceptQuest>);
			}
			return IAcceptQuest.CreateIAcceptQuest(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x0400D1CF RID: 53711
		private Table __p;
	}
}
