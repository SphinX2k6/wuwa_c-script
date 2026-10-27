using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047C6 RID: 18374
	public struct IEntityOwnerQuest : IFlatbufferObject
	{
		// Token: 0x170083F7 RID: 33783
		// (get) Token: 0x0601C5ED RID: 116205 RVA: 0x00403BFE File Offset: 0x00401DFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C5EE RID: 116206 RVA: 0x00403C0B File Offset: 0x00401E0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C5EF RID: 116207 RVA: 0x00403C14 File Offset: 0x00401E14
		public static IEntityOwnerQuest GetRootAsIEntityOwnerQuest(ByteBuffer _bb)
		{
			return IEntityOwnerQuest.GetRootAsIEntityOwnerQuest(_bb, default(IEntityOwnerQuest));
		}

		// Token: 0x0601C5F0 RID: 116208 RVA: 0x00403C30 File Offset: 0x00401E30
		public static IEntityOwnerQuest GetRootAsIEntityOwnerQuest(ByteBuffer _bb, IEntityOwnerQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C5F1 RID: 116209 RVA: 0x00403C4D File Offset: 0x00401E4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C5F2 RID: 116210 RVA: 0x00403C5C File Offset: 0x00401E5C
		public IEntityOwnerQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083F8 RID: 33784
		// (get) Token: 0x0601C5F3 RID: 116211 RVA: 0x00403C6C File Offset: 0x00401E6C
		public EEntityOwnerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityOwnerType.Quest;
				}
				return (EEntityOwnerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170083F9 RID: 33785
		// (get) Token: 0x0601C5F4 RID: 116212 RVA: 0x00403CA8 File Offset: 0x00401EA8
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

		// Token: 0x0601C5F5 RID: 116213 RVA: 0x00403CE4 File Offset: 0x00401EE4
		public static Offset<IEntityOwnerQuest> CreateIEntityOwnerQuest(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest, int QuestId = 0)
		{
			builder.StartTable(2);
			IEntityOwnerQuest.AddQuestId(builder, QuestId);
			IEntityOwnerQuest.AddType(builder, Type);
			return IEntityOwnerQuest.EndIEntityOwnerQuest(builder);
		}

		// Token: 0x0601C5F6 RID: 116214 RVA: 0x00403D01 File Offset: 0x00401F01
		public static void StartIEntityOwnerQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C5F7 RID: 116215 RVA: 0x00403D0A File Offset: 0x00401F0A
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C5F8 RID: 116216 RVA: 0x00403D15 File Offset: 0x00401F15
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601C5F9 RID: 116217 RVA: 0x00403D20 File Offset: 0x00401F20
		public static Offset<IEntityOwnerQuest> EndIEntityOwnerQuest(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerQuest>(builder.EndTable());
		}

		// Token: 0x0601C5FA RID: 116218 RVA: 0x00403D30 File Offset: 0x00401F30
		public IEntityOwnerQuestT UnPack()
		{
			IEntityOwnerQuestT entityOwnerQuestT = new IEntityOwnerQuestT();
			this.UnPackTo(entityOwnerQuestT);
			return entityOwnerQuestT;
		}

		// Token: 0x0601C5FB RID: 116219 RVA: 0x00403D4B File Offset: 0x00401F4B
		public void UnPackTo(IEntityOwnerQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0601C5FC RID: 116220 RVA: 0x00403D68 File Offset: 0x00401F68
		public static Offset<IEntityOwnerQuest> Pack(FlatBufferBuilder builder, IEntityOwnerQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerQuest>);
			}
			return IEntityOwnerQuest.CreateIEntityOwnerQuest(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x0400CC4F RID: 52303
		private Table __p;
	}
}
