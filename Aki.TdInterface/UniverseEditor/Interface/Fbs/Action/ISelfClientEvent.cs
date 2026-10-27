using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F54 RID: 28500
	public struct ISelfClientEvent : IFlatbufferObject
	{
		// Token: 0x1700D3C5 RID: 54213
		// (get) Token: 0x06032599 RID: 206233 RVA: 0x006CC676 File Offset: 0x006CA876
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603259A RID: 206234 RVA: 0x006CC683 File Offset: 0x006CA883
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603259B RID: 206235 RVA: 0x006CC68C File Offset: 0x006CA88C
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb)
		{
			return ISelfClientEvent.GetRootAsISelfClientEvent(_bb, default(ISelfClientEvent));
		}

		// Token: 0x0603259C RID: 206236 RVA: 0x006CC6A8 File Offset: 0x006CA8A8
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb, ISelfClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603259D RID: 206237 RVA: 0x006CC6C5 File Offset: 0x006CA8C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603259E RID: 206238 RVA: 0x006CC6D4 File Offset: 0x006CA8D4
		public ISelfClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D3C6 RID: 54214
		// (get) Token: 0x0603259F RID: 206239 RVA: 0x006CC6E4 File Offset: 0x006CA8E4
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

		// Token: 0x060325A0 RID: 206240 RVA: 0x006CC720 File Offset: 0x006CA920
		public static Offset<ISelfClientEvent> CreateISelfClientEvent(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			ISelfClientEvent.AddType(builder, Type);
			return ISelfClientEvent.EndISelfClientEvent(builder);
		}

		// Token: 0x060325A1 RID: 206241 RVA: 0x006CC736 File Offset: 0x006CA936
		public static void StartISelfClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060325A2 RID: 206242 RVA: 0x006CC73F File Offset: 0x006CA93F
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060325A3 RID: 206243 RVA: 0x006CC74A File Offset: 0x006CA94A
		public static Offset<ISelfClientEvent> EndISelfClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISelfClientEvent>(builder.EndTable());
		}

		// Token: 0x060325A4 RID: 206244 RVA: 0x006CC758 File Offset: 0x006CA958
		public ISelfClientEventT UnPack()
		{
			ISelfClientEventT selfClientEventT = new ISelfClientEventT();
			this.UnPackTo(selfClientEventT);
			return selfClientEventT;
		}

		// Token: 0x060325A5 RID: 206245 RVA: 0x006CC773 File Offset: 0x006CA973
		public void UnPackTo(ISelfClientEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060325A6 RID: 206246 RVA: 0x006CC784 File Offset: 0x006CA984
		public static Offset<ISelfClientEvent> Pack(FlatBufferBuilder builder, ISelfClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfClientEvent>);
			}
			return ISelfClientEvent.CreateISelfClientEvent(builder, _o.Type);
		}

		// Token: 0x0401194F RID: 72015
		private Table __p;
	}
}
