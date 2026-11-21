using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007720 RID: 30496
	public struct ISendAiEvent : IFlatbufferObject
	{
		// Token: 0x1700DF9A RID: 57242
		// (get) Token: 0x0603580D RID: 219149 RVA: 0x0072C31D File Offset: 0x0072A51D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603580E RID: 219150 RVA: 0x0072C32A File Offset: 0x0072A52A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603580F RID: 219151 RVA: 0x0072C334 File Offset: 0x0072A534
		public static ISendAiEvent GetRootAsISendAiEvent(ByteBuffer _bb)
		{
			return ISendAiEvent.GetRootAsISendAiEvent(_bb, default(ISendAiEvent));
		}

		// Token: 0x06035810 RID: 219152 RVA: 0x0072C350 File Offset: 0x0072A550
		public static ISendAiEvent GetRootAsISendAiEvent(ByteBuffer _bb, ISendAiEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035811 RID: 219153 RVA: 0x0072C36D File Offset: 0x0072A56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035812 RID: 219154 RVA: 0x0072C37C File Offset: 0x0072A57C
		public ISendAiEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF9B RID: 57243
		// (get) Token: 0x06035813 RID: 219155 RVA: 0x0072C38C File Offset: 0x0072A58C
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

		// Token: 0x1700DF9C RID: 57244
		// (get) Token: 0x06035814 RID: 219156 RVA: 0x0072C3C8 File Offset: 0x0072A5C8
		public EAiEventType EventType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EAiEventType.CatAndDogPlayFlow;
				}
				return (EAiEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DF9D RID: 57245
		// (get) Token: 0x06035815 RID: 219157 RVA: 0x0072C404 File Offset: 0x0072A604
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

		// Token: 0x06035816 RID: 219158 RVA: 0x0072C440 File Offset: 0x0072A640
		public static Offset<ISendAiEvent> CreateISendAiEvent(FlatBufferBuilder builder, int EntityId = 0, EAiEventType EventType = EAiEventType.CatAndDogPlayFlow, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISendAiEvent.AddEntityId(builder, EntityId);
			ISendAiEvent.AddNullMask(builder, NullMask);
			ISendAiEvent.AddEventType(builder, EventType);
			return ISendAiEvent.EndISendAiEvent(builder);
		}

		// Token: 0x06035817 RID: 219159 RVA: 0x0072C464 File Offset: 0x0072A664
		public static void StartISendAiEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035818 RID: 219160 RVA: 0x0072C46D File Offset: 0x0072A66D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06035819 RID: 219161 RVA: 0x0072C478 File Offset: 0x0072A678
		public static void AddEventType(FlatBufferBuilder builder, EAiEventType eventType)
		{
			builder.AddByte(1, (byte)eventType, 0);
		}

		// Token: 0x0603581A RID: 219162 RVA: 0x0072C483 File Offset: 0x0072A683
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0603581B RID: 219163 RVA: 0x0072C48E File Offset: 0x0072A68E
		public static Offset<ISendAiEvent> EndISendAiEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISendAiEvent>(builder.EndTable());
		}

		// Token: 0x0603581C RID: 219164 RVA: 0x0072C49C File Offset: 0x0072A69C
		public ISendAiEventT UnPack()
		{
			ISendAiEventT sendAiEventT = new ISendAiEventT();
			this.UnPackTo(sendAiEventT);
			return sendAiEventT;
		}

		// Token: 0x0603581D RID: 219165 RVA: 0x0072C4B7 File Offset: 0x0072A6B7
		public void UnPackTo(ISendAiEventT _o)
		{
			_o.EntityId = this.EntityId;
			_o.EventType = this.EventType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603581E RID: 219166 RVA: 0x0072C4E0 File Offset: 0x0072A6E0
		public static Offset<ISendAiEvent> Pack(FlatBufferBuilder builder, ISendAiEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendAiEvent>);
			}
			return ISendAiEvent.CreateISendAiEvent(builder, _o.EntityId, _o.EventType, _o.NullMask);
		}

		// Token: 0x04012935 RID: 76085
		private Table __p;
	}
}
