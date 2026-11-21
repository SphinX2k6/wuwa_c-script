using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B27 RID: 31527
	public struct ITalkOptionRogueRandomEvent : IFlatbufferObject
	{
		// Token: 0x1700EC1C RID: 60444
		// (get) Token: 0x06038C3F RID: 232511 RVA: 0x007AD419 File Offset: 0x007AB619
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038C40 RID: 232512 RVA: 0x007AD426 File Offset: 0x007AB626
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038C41 RID: 232513 RVA: 0x007AD430 File Offset: 0x007AB630
		public static ITalkOptionRogueRandomEvent GetRootAsITalkOptionRogueRandomEvent(ByteBuffer _bb)
		{
			return ITalkOptionRogueRandomEvent.GetRootAsITalkOptionRogueRandomEvent(_bb, default(ITalkOptionRogueRandomEvent));
		}

		// Token: 0x06038C42 RID: 232514 RVA: 0x007AD44C File Offset: 0x007AB64C
		public static ITalkOptionRogueRandomEvent GetRootAsITalkOptionRogueRandomEvent(ByteBuffer _bb, ITalkOptionRogueRandomEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038C43 RID: 232515 RVA: 0x007AD469 File Offset: 0x007AB669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038C44 RID: 232516 RVA: 0x007AD478 File Offset: 0x007AB678
		public ITalkOptionRogueRandomEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC1D RID: 60445
		// (get) Token: 0x06038C45 RID: 232517 RVA: 0x007AD488 File Offset: 0x007AB688
		public ETalkOptionParamType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETalkOptionParamType.QteSucceed;
				}
				return (ETalkOptionParamType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EC1E RID: 60446
		// (get) Token: 0x06038C46 RID: 232518 RVA: 0x007AD4C4 File Offset: 0x007AB6C4
		public int OptionId
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

		// Token: 0x1700EC1F RID: 60447
		// (get) Token: 0x06038C47 RID: 232519 RVA: 0x007AD500 File Offset: 0x007AB700
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038C48 RID: 232520 RVA: 0x007AD53C File Offset: 0x007AB73C
		public static Offset<ITalkOptionRogueRandomEvent> CreateITalkOptionRogueRandomEvent(FlatBufferBuilder builder, ETalkOptionParamType Type = ETalkOptionParamType.QteSucceed, int OptionId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITalkOptionRogueRandomEvent.AddOptionId(builder, OptionId);
			ITalkOptionRogueRandomEvent.AddNullMask(builder, NullMask);
			ITalkOptionRogueRandomEvent.AddType(builder, Type);
			return ITalkOptionRogueRandomEvent.EndITalkOptionRogueRandomEvent(builder);
		}

		// Token: 0x06038C49 RID: 232521 RVA: 0x007AD560 File Offset: 0x007AB760
		public static void StartITalkOptionRogueRandomEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06038C4A RID: 232522 RVA: 0x007AD569 File Offset: 0x007AB769
		public static void AddType(FlatBufferBuilder builder, ETalkOptionParamType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038C4B RID: 232523 RVA: 0x007AD574 File Offset: 0x007AB774
		public static void AddOptionId(FlatBufferBuilder builder, int optionId)
		{
			builder.AddInt(1, optionId, 0);
		}

		// Token: 0x06038C4C RID: 232524 RVA: 0x007AD57F File Offset: 0x007AB77F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06038C4D RID: 232525 RVA: 0x007AD58A File Offset: 0x007AB78A
		public static Offset<ITalkOptionRogueRandomEvent> EndITalkOptionRogueRandomEvent(FlatBufferBuilder builder)
		{
			return new Offset<ITalkOptionRogueRandomEvent>(builder.EndTable());
		}

		// Token: 0x06038C4E RID: 232526 RVA: 0x007AD598 File Offset: 0x007AB798
		public ITalkOptionRogueRandomEventT UnPack()
		{
			ITalkOptionRogueRandomEventT talkOptionRogueRandomEventT = new ITalkOptionRogueRandomEventT();
			this.UnPackTo(talkOptionRogueRandomEventT);
			return talkOptionRogueRandomEventT;
		}

		// Token: 0x06038C4F RID: 232527 RVA: 0x007AD5B3 File Offset: 0x007AB7B3
		public void UnPackTo(ITalkOptionRogueRandomEventT _o)
		{
			_o.Type = this.Type;
			_o.OptionId = this.OptionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06038C50 RID: 232528 RVA: 0x007AD5DC File Offset: 0x007AB7DC
		public static Offset<ITalkOptionRogueRandomEvent> Pack(FlatBufferBuilder builder, ITalkOptionRogueRandomEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITalkOptionRogueRandomEvent>);
			}
			return ITalkOptionRogueRandomEvent.CreateITalkOptionRogueRandomEvent(builder, _o.Type, _o.OptionId, _o.NullMask);
		}

		// Token: 0x0401314C RID: 78156
		private Table __p;
	}
}
