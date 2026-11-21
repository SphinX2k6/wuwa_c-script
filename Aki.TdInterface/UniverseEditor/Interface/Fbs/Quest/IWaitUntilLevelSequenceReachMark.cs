using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E2 RID: 18146
	public struct IWaitUntilLevelSequenceReachMark : IFlatbufferObject
	{
		// Token: 0x17007F1A RID: 32538
		// (get) Token: 0x0601AAF2 RID: 109298 RVA: 0x003CAFFF File Offset: 0x003C91FF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AAF3 RID: 109299 RVA: 0x003CB00C File Offset: 0x003C920C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AAF4 RID: 109300 RVA: 0x003CB014 File Offset: 0x003C9214
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb)
		{
			return IWaitUntilLevelSequenceReachMark.GetRootAsIWaitUntilLevelSequenceReachMark(_bb, default(IWaitUntilLevelSequenceReachMark));
		}

		// Token: 0x0601AAF5 RID: 109301 RVA: 0x003CB030 File Offset: 0x003C9230
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb, IWaitUntilLevelSequenceReachMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AAF6 RID: 109302 RVA: 0x003CB04D File Offset: 0x003C924D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AAF7 RID: 109303 RVA: 0x003CB05C File Offset: 0x003C925C
		public IWaitUntilLevelSequenceReachMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F1B RID: 32539
		// (get) Token: 0x0601AAF8 RID: 109304 RVA: 0x003CB06C File Offset: 0x003C926C
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F1C RID: 32540
		// (get) Token: 0x0601AAF9 RID: 109305 RVA: 0x003CB0A8 File Offset: 0x003C92A8
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007F1D RID: 32541
		// (get) Token: 0x0601AAFA RID: 109306 RVA: 0x003CB108 File Offset: 0x003C9308
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007F1E RID: 32542
		// (get) Token: 0x0601AAFB RID: 109307 RVA: 0x003CB144 File Offset: 0x003C9344
		public string Mark
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AAFC RID: 109308 RVA: 0x003CB17C File Offset: 0x003C937C
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601AAFD RID: 109309 RVA: 0x003CB18C File Offset: 0x003C938C
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601AAFE RID: 109310 RVA: 0x003CB19B File Offset: 0x003C939B
		public static Offset<IWaitUntilLevelSequenceReachMark> CreateIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int EntityId = 0, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IWaitUntilLevelSequenceReachMark.AddMark(builder, MarkOffset);
			IWaitUntilLevelSequenceReachMark.AddEntityId(builder, EntityId);
			IWaitUntilLevelSequenceReachMark.AddPreConditions(builder, PreConditionsOffset);
			IWaitUntilLevelSequenceReachMark.AddType(builder, Type);
			return IWaitUntilLevelSequenceReachMark.EndIWaitUntilLevelSequenceReachMark(builder);
		}

		// Token: 0x0601AAFF RID: 109311 RVA: 0x003CB1C7 File Offset: 0x003C93C7
		public static void StartIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601AB00 RID: 109312 RVA: 0x003CB1D0 File Offset: 0x003C93D0
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AB01 RID: 109313 RVA: 0x003CB1DB File Offset: 0x003C93DB
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x0601AB02 RID: 109314 RVA: 0x003CB1EB File Offset: 0x003C93EB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x0601AB03 RID: 109315 RVA: 0x003CB1F6 File Offset: 0x003C93F6
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(3, markOffset.Value, 0);
		}

		// Token: 0x0601AB04 RID: 109316 RVA: 0x003CB206 File Offset: 0x003C9406
		public static Offset<IWaitUntilLevelSequenceReachMark> EndIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			return new Offset<IWaitUntilLevelSequenceReachMark>(builder.EndTable());
		}

		// Token: 0x0601AB05 RID: 109317 RVA: 0x003CB214 File Offset: 0x003C9414
		public IWaitUntilLevelSequenceReachMarkT UnPack()
		{
			IWaitUntilLevelSequenceReachMarkT waitUntilLevelSequenceReachMarkT = new IWaitUntilLevelSequenceReachMarkT();
			this.UnPackTo(waitUntilLevelSequenceReachMarkT);
			return waitUntilLevelSequenceReachMarkT;
		}

		// Token: 0x0601AB06 RID: 109318 RVA: 0x003CB230 File Offset: 0x003C9430
		public void UnPackTo(IWaitUntilLevelSequenceReachMarkT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.Mark = this.Mark;
		}

		// Token: 0x0601AB07 RID: 109319 RVA: 0x003CB290 File Offset: 0x003C9490
		public static Offset<IWaitUntilLevelSequenceReachMark> Pack(FlatBufferBuilder builder, IWaitUntilLevelSequenceReachMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitUntilLevelSequenceReachMark>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return IWaitUntilLevelSequenceReachMark.CreateIWaitUntilLevelSequenceReachMark(builder, _o.Type, preConditionsOffset, _o.EntityId, markOffset);
		}

		// Token: 0x0400C92F RID: 51503
		private Table __p;
	}
}
