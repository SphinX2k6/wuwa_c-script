using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004286 RID: 17030
	public struct IWaitUntilLevelSequenceReachMark : IFlatbufferObject
	{
		// Token: 0x170078E9 RID: 30953
		// (get) Token: 0x06019386 RID: 103302 RVA: 0x0039F927 File Offset: 0x0039DB27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019387 RID: 103303 RVA: 0x0039F934 File Offset: 0x0039DB34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019388 RID: 103304 RVA: 0x0039F93C File Offset: 0x0039DB3C
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb)
		{
			return IWaitUntilLevelSequenceReachMark.GetRootAsIWaitUntilLevelSequenceReachMark(_bb, default(IWaitUntilLevelSequenceReachMark));
		}

		// Token: 0x06019389 RID: 103305 RVA: 0x0039F958 File Offset: 0x0039DB58
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb, IWaitUntilLevelSequenceReachMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601938A RID: 103306 RVA: 0x0039F975 File Offset: 0x0039DB75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601938B RID: 103307 RVA: 0x0039F984 File Offset: 0x0039DB84
		public IWaitUntilLevelSequenceReachMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170078EA RID: 30954
		// (get) Token: 0x0601938C RID: 103308 RVA: 0x0039F994 File Offset: 0x0039DB94
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

		// Token: 0x170078EB RID: 30955
		// (get) Token: 0x0601938D RID: 103309 RVA: 0x0039F9D0 File Offset: 0x0039DBD0
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

		// Token: 0x170078EC RID: 30956
		// (get) Token: 0x0601938E RID: 103310 RVA: 0x0039FA30 File Offset: 0x0039DC30
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

		// Token: 0x170078ED RID: 30957
		// (get) Token: 0x0601938F RID: 103311 RVA: 0x0039FA6C File Offset: 0x0039DC6C
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

		// Token: 0x06019390 RID: 103312 RVA: 0x0039FAA4 File Offset: 0x0039DCA4
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06019391 RID: 103313 RVA: 0x0039FAB4 File Offset: 0x0039DCB4
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x06019392 RID: 103314 RVA: 0x0039FAC3 File Offset: 0x0039DCC3
		public static Offset<IWaitUntilLevelSequenceReachMark> CreateIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int EntityId = 0, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IWaitUntilLevelSequenceReachMark.AddMark(builder, MarkOffset);
			IWaitUntilLevelSequenceReachMark.AddEntityId(builder, EntityId);
			IWaitUntilLevelSequenceReachMark.AddPreConditions(builder, PreConditionsOffset);
			IWaitUntilLevelSequenceReachMark.AddType(builder, Type);
			return IWaitUntilLevelSequenceReachMark.EndIWaitUntilLevelSequenceReachMark(builder);
		}

		// Token: 0x06019393 RID: 103315 RVA: 0x0039FAEF File Offset: 0x0039DCEF
		public static void StartIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06019394 RID: 103316 RVA: 0x0039FAF8 File Offset: 0x0039DCF8
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06019395 RID: 103317 RVA: 0x0039FB03 File Offset: 0x0039DD03
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06019396 RID: 103318 RVA: 0x0039FB13 File Offset: 0x0039DD13
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(2, entityId, 0);
		}

		// Token: 0x06019397 RID: 103319 RVA: 0x0039FB1E File Offset: 0x0039DD1E
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(3, markOffset.Value, 0);
		}

		// Token: 0x06019398 RID: 103320 RVA: 0x0039FB2E File Offset: 0x0039DD2E
		public static Offset<IWaitUntilLevelSequenceReachMark> EndIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			return new Offset<IWaitUntilLevelSequenceReachMark>(builder.EndTable());
		}

		// Token: 0x06019399 RID: 103321 RVA: 0x0039FB3C File Offset: 0x0039DD3C
		public IWaitUntilLevelSequenceReachMarkT UnPack()
		{
			IWaitUntilLevelSequenceReachMarkT waitUntilLevelSequenceReachMarkT = new IWaitUntilLevelSequenceReachMarkT();
			this.UnPackTo(waitUntilLevelSequenceReachMarkT);
			return waitUntilLevelSequenceReachMarkT;
		}

		// Token: 0x0601939A RID: 103322 RVA: 0x0039FB58 File Offset: 0x0039DD58
		public void UnPackTo(IWaitUntilLevelSequenceReachMarkT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.Mark = this.Mark;
		}

		// Token: 0x0601939B RID: 103323 RVA: 0x0039FBB8 File Offset: 0x0039DDB8
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

		// Token: 0x0400BF22 RID: 48930
		private Table __p;
	}
}
