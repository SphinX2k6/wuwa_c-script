using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D2 RID: 18130
	public struct IUnlockQuest : IFlatbufferObject
	{
		// Token: 0x170080CF RID: 32975
		// (get) Token: 0x0601B90B RID: 112907 RVA: 0x003E905F File Offset: 0x003E725F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B90C RID: 112908 RVA: 0x003E906C File Offset: 0x003E726C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B90D RID: 112909 RVA: 0x003E9074 File Offset: 0x003E7274
		public static IUnlockQuest GetRootAsIUnlockQuest(ByteBuffer _bb)
		{
			return IUnlockQuest.GetRootAsIUnlockQuest(_bb, default(IUnlockQuest));
		}

		// Token: 0x0601B90E RID: 112910 RVA: 0x003E9090 File Offset: 0x003E7290
		public static IUnlockQuest GetRootAsIUnlockQuest(ByteBuffer _bb, IUnlockQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B90F RID: 112911 RVA: 0x003E90AD File Offset: 0x003E72AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B910 RID: 112912 RVA: 0x003E90BC File Offset: 0x003E72BC
		public IUnlockQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170080D0 RID: 32976
		// (get) Token: 0x0601B911 RID: 112913 RVA: 0x003E90CC File Offset: 0x003E72CC
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

		// Token: 0x170080D1 RID: 32977
		// (get) Token: 0x0601B912 RID: 112914 RVA: 0x003E9108 File Offset: 0x003E7308
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

		// Token: 0x0601B913 RID: 112915 RVA: 0x003E9144 File Offset: 0x003E7344
		public static Offset<IUnlockQuest> CreateIUnlockQuest(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, int QuestId = 0)
		{
			builder.StartTable(2);
			IUnlockQuest.AddQuestId(builder, QuestId);
			IUnlockQuest.AddType(builder, Type);
			return IUnlockQuest.EndIUnlockQuest(builder);
		}

		// Token: 0x0601B914 RID: 112916 RVA: 0x003E9161 File Offset: 0x003E7361
		public static void StartIUnlockQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B915 RID: 112917 RVA: 0x003E916A File Offset: 0x003E736A
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B916 RID: 112918 RVA: 0x003E9175 File Offset: 0x003E7375
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601B917 RID: 112919 RVA: 0x003E9180 File Offset: 0x003E7380
		public static Offset<IUnlockQuest> EndIUnlockQuest(FlatBufferBuilder builder)
		{
			return new Offset<IUnlockQuest>(builder.EndTable());
		}

		// Token: 0x0601B918 RID: 112920 RVA: 0x003E9190 File Offset: 0x003E7390
		public IUnlockQuestT UnPack()
		{
			IUnlockQuestT unlockQuestT = new IUnlockQuestT();
			this.UnPackTo(unlockQuestT);
			return unlockQuestT;
		}

		// Token: 0x0601B919 RID: 112921 RVA: 0x003E91AB File Offset: 0x003E73AB
		public void UnPackTo(IUnlockQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0601B91A RID: 112922 RVA: 0x003E91C8 File Offset: 0x003E73C8
		public static Offset<IUnlockQuest> Pack(FlatBufferBuilder builder, IUnlockQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnlockQuest>);
			}
			return IUnlockQuest.CreateIUnlockQuest(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x0400C8A4 RID: 51364
		private Table __p;
	}
}
