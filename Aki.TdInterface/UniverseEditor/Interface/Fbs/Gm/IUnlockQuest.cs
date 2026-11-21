using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B3A RID: 19258
	public struct IUnlockQuest : IFlatbufferObject
	{
		// Token: 0x17008710 RID: 34576
		// (get) Token: 0x0601D0E0 RID: 119008 RVA: 0x004152FB File Offset: 0x004134FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D0E1 RID: 119009 RVA: 0x00415308 File Offset: 0x00413508
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D0E2 RID: 119010 RVA: 0x00415310 File Offset: 0x00413510
		public static IUnlockQuest GetRootAsIUnlockQuest(ByteBuffer _bb)
		{
			return IUnlockQuest.GetRootAsIUnlockQuest(_bb, default(IUnlockQuest));
		}

		// Token: 0x0601D0E3 RID: 119011 RVA: 0x0041532C File Offset: 0x0041352C
		public static IUnlockQuest GetRootAsIUnlockQuest(ByteBuffer _bb, IUnlockQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D0E4 RID: 119012 RVA: 0x00415349 File Offset: 0x00413549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D0E5 RID: 119013 RVA: 0x00415358 File Offset: 0x00413558
		public IUnlockQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008711 RID: 34577
		// (get) Token: 0x0601D0E6 RID: 119014 RVA: 0x00415368 File Offset: 0x00413568
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

		// Token: 0x17008712 RID: 34578
		// (get) Token: 0x0601D0E7 RID: 119015 RVA: 0x004153A4 File Offset: 0x004135A4
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

		// Token: 0x0601D0E8 RID: 119016 RVA: 0x004153E0 File Offset: 0x004135E0
		public static Offset<IUnlockQuest> CreateIUnlockQuest(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int QuestId = 0)
		{
			builder.StartTable(2);
			IUnlockQuest.AddQuestId(builder, QuestId);
			IUnlockQuest.AddType(builder, Type);
			return IUnlockQuest.EndIUnlockQuest(builder);
		}

		// Token: 0x0601D0E9 RID: 119017 RVA: 0x004153FD File Offset: 0x004135FD
		public static void StartIUnlockQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D0EA RID: 119018 RVA: 0x00415406 File Offset: 0x00413606
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D0EB RID: 119019 RVA: 0x00415411 File Offset: 0x00413611
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601D0EC RID: 119020 RVA: 0x0041541C File Offset: 0x0041361C
		public static Offset<IUnlockQuest> EndIUnlockQuest(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockQuest>(builder.EndTable());
		}

		// Token: 0x0601D0ED RID: 119021 RVA: 0x0041542C File Offset: 0x0041362C
		public IUnlockQuestT UnPack()
		{
			IUnlockQuestT unlockQuestT = new IUnlockQuestT();
			this.UnPackTo(unlockQuestT);
			return unlockQuestT;
		}

		// Token: 0x0601D0EE RID: 119022 RVA: 0x00415447 File Offset: 0x00413647
		public void UnPackTo(IUnlockQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0601D0EF RID: 119023 RVA: 0x00415464 File Offset: 0x00413664
		public static Offset<IUnlockQuest> Pack(FlatBufferBuilder builder, IUnlockQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockQuest>);
			}
			return IUnlockQuest.CreateIUnlockQuest(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x0400D2D3 RID: 53971
		private Table __p;
	}
}
