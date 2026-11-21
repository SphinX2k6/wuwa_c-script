using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C2E RID: 19502
	public struct IEntityOwnerQuest : IFlatbufferObject
	{
		// Token: 0x17008A38 RID: 35384
		// (get) Token: 0x0601DDC2 RID: 122306 RVA: 0x0042FE9A File Offset: 0x0042E09A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DDC3 RID: 122307 RVA: 0x0042FEA7 File Offset: 0x0042E0A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DDC4 RID: 122308 RVA: 0x0042FEB0 File Offset: 0x0042E0B0
		public static IEntityOwnerQuest GetRootAsIEntityOwnerQuest(ByteBuffer _bb)
		{
			return IEntityOwnerQuest.GetRootAsIEntityOwnerQuest(_bb, default(IEntityOwnerQuest));
		}

		// Token: 0x0601DDC5 RID: 122309 RVA: 0x0042FECC File Offset: 0x0042E0CC
		public static IEntityOwnerQuest GetRootAsIEntityOwnerQuest(ByteBuffer _bb, IEntityOwnerQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DDC6 RID: 122310 RVA: 0x0042FEE9 File Offset: 0x0042E0E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DDC7 RID: 122311 RVA: 0x0042FEF8 File Offset: 0x0042E0F8
		public IEntityOwnerQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008A39 RID: 35385
		// (get) Token: 0x0601DDC8 RID: 122312 RVA: 0x0042FF08 File Offset: 0x0042E108
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

		// Token: 0x17008A3A RID: 35386
		// (get) Token: 0x0601DDC9 RID: 122313 RVA: 0x0042FF44 File Offset: 0x0042E144
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

		// Token: 0x0601DDCA RID: 122314 RVA: 0x0042FF80 File Offset: 0x0042E180
		public static Offset<IEntityOwnerQuest> CreateIEntityOwnerQuest(FlatBufferBuilder builder, EEntityOwnerType Type = EEntityOwnerType.Quest, int QuestId = 0)
		{
			builder.StartTable(2);
			IEntityOwnerQuest.AddQuestId(builder, QuestId);
			IEntityOwnerQuest.AddType(builder, Type);
			return IEntityOwnerQuest.EndIEntityOwnerQuest(builder);
		}

		// Token: 0x0601DDCB RID: 122315 RVA: 0x0042FF9D File Offset: 0x0042E19D
		public static void StartIEntityOwnerQuest(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DDCC RID: 122316 RVA: 0x0042FFA6 File Offset: 0x0042E1A6
		public static void AddType(FlatBufferBuilder builder, EEntityOwnerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DDCD RID: 122317 RVA: 0x0042FFB1 File Offset: 0x0042E1B1
		public static void AddQuestId(FlatBufferBuilder builder, int questId)
		{
			builder.AddInt(1, questId, 0);
		}

		// Token: 0x0601DDCE RID: 122318 RVA: 0x0042FFBC File Offset: 0x0042E1BC
		public static Offset<IEntityOwnerQuest> EndIEntityOwnerQuest(FlatBufferBuilder builder)
		{
			return new Offset<IEntityOwnerQuest>(builder.EndTable());
		}

		// Token: 0x0601DDCF RID: 122319 RVA: 0x0042FFCC File Offset: 0x0042E1CC
		public IEntityOwnerQuestT UnPack()
		{
			IEntityOwnerQuestT entityOwnerQuestT = new IEntityOwnerQuestT();
			this.UnPackTo(entityOwnerQuestT);
			return entityOwnerQuestT;
		}

		// Token: 0x0601DDD0 RID: 122320 RVA: 0x0042FFE7 File Offset: 0x0042E1E7
		public void UnPackTo(IEntityOwnerQuestT _o)
		{
			_o.Type = this.Type;
			_o.QuestId = this.QuestId;
		}

		// Token: 0x0601DDD1 RID: 122321 RVA: 0x00430004 File Offset: 0x0042E204
		public static Offset<IEntityOwnerQuest> Pack(FlatBufferBuilder builder, IEntityOwnerQuestT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityOwnerQuest>);
			}
			return IEntityOwnerQuest.CreateIEntityOwnerQuest(builder, _o.Type, _o.QuestId);
		}

		// Token: 0x0400D685 RID: 54917
		private Table __p;
	}
}
