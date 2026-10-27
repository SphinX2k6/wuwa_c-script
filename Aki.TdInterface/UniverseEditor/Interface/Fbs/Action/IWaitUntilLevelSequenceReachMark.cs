using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007601 RID: 30209
	public struct IWaitUntilLevelSequenceReachMark : IFlatbufferObject
	{
		// Token: 0x1700E57A RID: 58746
		// (get) Token: 0x06037072 RID: 225394 RVA: 0x007773EA File Offset: 0x007755EA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037073 RID: 225395 RVA: 0x007773F7 File Offset: 0x007755F7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037074 RID: 225396 RVA: 0x00777400 File Offset: 0x00775600
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb)
		{
			return IWaitUntilLevelSequenceReachMark.GetRootAsIWaitUntilLevelSequenceReachMark(_bb, default(IWaitUntilLevelSequenceReachMark));
		}

		// Token: 0x06037075 RID: 225397 RVA: 0x0077741C File Offset: 0x0077561C
		public static IWaitUntilLevelSequenceReachMark GetRootAsIWaitUntilLevelSequenceReachMark(ByteBuffer _bb, IWaitUntilLevelSequenceReachMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037076 RID: 225398 RVA: 0x00777439 File Offset: 0x00775639
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037077 RID: 225399 RVA: 0x00777448 File Offset: 0x00775648
		public IWaitUntilLevelSequenceReachMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E57B RID: 58747
		// (get) Token: 0x06037078 RID: 225400 RVA: 0x00777458 File Offset: 0x00775658
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E57C RID: 58748
		// (get) Token: 0x06037079 RID: 225401 RVA: 0x00777494 File Offset: 0x00775694
		public string Mark
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603707A RID: 225402 RVA: 0x007774CB File Offset: 0x007756CB
		public Span<byte> GetMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603707B RID: 225403 RVA: 0x007774DA File Offset: 0x007756DA
		public byte[] GetMarkArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603707C RID: 225404 RVA: 0x007774E8 File Offset: 0x007756E8
		public static Offset<IWaitUntilLevelSequenceReachMark> CreateIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder, int EntityId = 0, StringOffset MarkOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IWaitUntilLevelSequenceReachMark.AddMark(builder, MarkOffset);
			IWaitUntilLevelSequenceReachMark.AddEntityId(builder, EntityId);
			return IWaitUntilLevelSequenceReachMark.EndIWaitUntilLevelSequenceReachMark(builder);
		}

		// Token: 0x0603707D RID: 225405 RVA: 0x00777505 File Offset: 0x00775705
		public static void StartIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603707E RID: 225406 RVA: 0x0077750E File Offset: 0x0077570E
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x0603707F RID: 225407 RVA: 0x00777519 File Offset: 0x00775719
		public static void AddMark(FlatBufferBuilder builder, StringOffset markOffset)
		{
			builder.AddOffset(1, markOffset.Value, 0);
		}

		// Token: 0x06037080 RID: 225408 RVA: 0x00777529 File Offset: 0x00775729
		public static Offset<IWaitUntilLevelSequenceReachMark> EndIWaitUntilLevelSequenceReachMark(FlatBufferBuilder builder)
		{
			return new Offset<IWaitUntilLevelSequenceReachMark>(builder.EndTable());
		}

		// Token: 0x06037081 RID: 225409 RVA: 0x00777538 File Offset: 0x00775738
		public IWaitUntilLevelSequenceReachMarkT UnPack()
		{
			IWaitUntilLevelSequenceReachMarkT waitUntilLevelSequenceReachMarkT = new IWaitUntilLevelSequenceReachMarkT();
			this.UnPackTo(waitUntilLevelSequenceReachMarkT);
			return waitUntilLevelSequenceReachMarkT;
		}

		// Token: 0x06037082 RID: 225410 RVA: 0x00777553 File Offset: 0x00775753
		public void UnPackTo(IWaitUntilLevelSequenceReachMarkT _o)
		{
			_o.EntityId = this.EntityId;
			_o.Mark = this.Mark;
		}

		// Token: 0x06037083 RID: 225411 RVA: 0x00777570 File Offset: 0x00775770
		public static Offset<IWaitUntilLevelSequenceReachMark> Pack(FlatBufferBuilder builder, IWaitUntilLevelSequenceReachMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaitUntilLevelSequenceReachMark>);
			}
			StringOffset markOffset = (_o.Mark == null) ? default(StringOffset) : builder.CreateString(_o.Mark);
			return IWaitUntilLevelSequenceReachMark.CreateIWaitUntilLevelSequenceReachMark(builder, _o.EntityId, markOffset);
		}

		// Token: 0x04012573 RID: 75123
		private Table __p;
	}
}
