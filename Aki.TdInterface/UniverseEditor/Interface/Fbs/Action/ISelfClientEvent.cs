using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007717 RID: 30487
	public struct ISelfClientEvent : IFlatbufferObject
	{
		// Token: 0x1700DF91 RID: 57233
		// (get) Token: 0x060357D7 RID: 219095 RVA: 0x0072BEB5 File Offset: 0x0072A0B5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060357D8 RID: 219096 RVA: 0x0072BEC2 File Offset: 0x0072A0C2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060357D9 RID: 219097 RVA: 0x0072BECC File Offset: 0x0072A0CC
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb)
		{
			return ISelfClientEvent.GetRootAsISelfClientEvent(_bb, default(ISelfClientEvent));
		}

		// Token: 0x060357DA RID: 219098 RVA: 0x0072BEE8 File Offset: 0x0072A0E8
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb, ISelfClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060357DB RID: 219099 RVA: 0x0072BF05 File Offset: 0x0072A105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060357DC RID: 219100 RVA: 0x0072BF14 File Offset: 0x0072A114
		public ISelfClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DF92 RID: 57234
		// (get) Token: 0x060357DD RID: 219101 RVA: 0x0072BF24 File Offset: 0x0072A124
		public EClientEventTarget Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientEventTarget.Self;
				}
				return (EClientEventTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060357DE RID: 219102 RVA: 0x0072BF60 File Offset: 0x0072A160
		public static Offset<ISelfClientEvent> CreateISelfClientEvent(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			ISelfClientEvent.AddType(builder, Type);
			return ISelfClientEvent.EndISelfClientEvent(builder);
		}

		// Token: 0x060357DF RID: 219103 RVA: 0x0072BF76 File Offset: 0x0072A176
		public static void StartISelfClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060357E0 RID: 219104 RVA: 0x0072BF7F File Offset: 0x0072A17F
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060357E1 RID: 219105 RVA: 0x0072BF8A File Offset: 0x0072A18A
		public static Offset<ISelfClientEvent> EndISelfClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISelfClientEvent>(builder.EndTable());
		}

		// Token: 0x060357E2 RID: 219106 RVA: 0x0072BF98 File Offset: 0x0072A198
		public ISelfClientEventT UnPack()
		{
			ISelfClientEventT selfClientEventT = new ISelfClientEventT();
			this.UnPackTo(selfClientEventT);
			return selfClientEventT;
		}

		// Token: 0x060357E3 RID: 219107 RVA: 0x0072BFB3 File Offset: 0x0072A1B3
		public void UnPackTo(ISelfClientEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060357E4 RID: 219108 RVA: 0x0072BFC4 File Offset: 0x0072A1C4
		public static Offset<ISelfClientEvent> Pack(FlatBufferBuilder builder, ISelfClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfClientEvent>);
			}
			return ISelfClientEvent.CreateISelfClientEvent(builder, _o.Type);
		}

		// Token: 0x0401292F RID: 76079
		private Table __p;
	}
}
