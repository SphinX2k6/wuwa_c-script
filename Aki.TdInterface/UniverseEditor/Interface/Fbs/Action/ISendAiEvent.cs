using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F5D RID: 28509
	public struct ISendAiEvent : IFlatbufferObject
	{
		// Token: 0x1700D3CE RID: 54222
		// (get) Token: 0x060325CF RID: 206287 RVA: 0x006CCADD File Offset: 0x006CACDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060325D0 RID: 206288 RVA: 0x006CCAEA File Offset: 0x006CACEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060325D1 RID: 206289 RVA: 0x006CCAF4 File Offset: 0x006CACF4
		public static ISendAiEvent GetRootAsISendAiEvent(ByteBuffer _bb)
		{
			return ISendAiEvent.GetRootAsISendAiEvent(_bb, default(ISendAiEvent));
		}

		// Token: 0x060325D2 RID: 206290 RVA: 0x006CCB10 File Offset: 0x006CAD10
		public static ISendAiEvent GetRootAsISendAiEvent(ByteBuffer _bb, ISendAiEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060325D3 RID: 206291 RVA: 0x006CCB2D File Offset: 0x006CAD2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060325D4 RID: 206292 RVA: 0x006CCB3C File Offset: 0x006CAD3C
		public ISendAiEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3CF RID: 54223
		// (get) Token: 0x060325D5 RID: 206293 RVA: 0x006CCB4C File Offset: 0x006CAD4C
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

		// Token: 0x1700D3D0 RID: 54224
		// (get) Token: 0x060325D6 RID: 206294 RVA: 0x006CCB88 File Offset: 0x006CAD88
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

		// Token: 0x1700D3D1 RID: 54225
		// (get) Token: 0x060325D7 RID: 206295 RVA: 0x006CCBC4 File Offset: 0x006CADC4
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

		// Token: 0x060325D8 RID: 206296 RVA: 0x006CCC00 File Offset: 0x006CAE00
		public static Offset<ISendAiEvent> CreateISendAiEvent(FlatBufferBuilder builder, int EntityId = 0, EAiEventType EventType = EAiEventType.CatAndDogPlayFlow, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISendAiEvent.AddEntityId(builder, EntityId);
			ISendAiEvent.AddNullMask(builder, NullMask);
			ISendAiEvent.AddEventType(builder, EventType);
			return ISendAiEvent.EndISendAiEvent(builder);
		}

		// Token: 0x060325D9 RID: 206297 RVA: 0x006CCC24 File Offset: 0x006CAE24
		public static void StartISendAiEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060325DA RID: 206298 RVA: 0x006CCC2D File Offset: 0x006CAE2D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x060325DB RID: 206299 RVA: 0x006CCC38 File Offset: 0x006CAE38
		public static void AddEventType(FlatBufferBuilder builder, EAiEventType eventType)
		{
			builder.AddByte(1, (byte)eventType, 0);
		}

		// Token: 0x060325DC RID: 206300 RVA: 0x006CCC43 File Offset: 0x006CAE43
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060325DD RID: 206301 RVA: 0x006CCC4E File Offset: 0x006CAE4E
		public static Offset<ISendAiEvent> EndISendAiEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISendAiEvent>(builder.EndTable());
		}

		// Token: 0x060325DE RID: 206302 RVA: 0x006CCC5C File Offset: 0x006CAE5C
		public ISendAiEventT UnPack()
		{
			ISendAiEventT sendAiEventT = new ISendAiEventT();
			this.UnPackTo(sendAiEventT);
			return sendAiEventT;
		}

		// Token: 0x060325DF RID: 206303 RVA: 0x006CCC77 File Offset: 0x006CAE77
		public void UnPackTo(ISendAiEventT _o)
		{
			_o.EntityId = this.EntityId;
			_o.EventType = this.EventType;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060325E0 RID: 206304 RVA: 0x006CCCA0 File Offset: 0x006CAEA0
		public static Offset<ISendAiEvent> Pack(FlatBufferBuilder builder, ISendAiEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISendAiEvent>);
			}
			return ISendAiEvent.CreateISendAiEvent(builder, _o.EntityId, _o.EventType, _o.NullMask);
		}

		// Token: 0x04011955 RID: 72021
		private Table __p;
	}
}
