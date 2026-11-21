using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051BA RID: 20922
	public struct ISelfClientEvent : IFlatbufferObject
	{
		// Token: 0x170095DC RID: 38364
		// (get) Token: 0x06020F07 RID: 134919 RVA: 0x0048E438 File Offset: 0x0048C638
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020F08 RID: 134920 RVA: 0x0048E445 File Offset: 0x0048C645
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020F09 RID: 134921 RVA: 0x0048E44C File Offset: 0x0048C64C
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb)
		{
			return ISelfClientEvent.GetRootAsISelfClientEvent(_bb, default(ISelfClientEvent));
		}

		// Token: 0x06020F0A RID: 134922 RVA: 0x0048E468 File Offset: 0x0048C668
		public static ISelfClientEvent GetRootAsISelfClientEvent(ByteBuffer _bb, ISelfClientEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020F0B RID: 134923 RVA: 0x0048E485 File Offset: 0x0048C685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020F0C RID: 134924 RVA: 0x0048E494 File Offset: 0x0048C694
		public ISelfClientEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170095DD RID: 38365
		// (get) Token: 0x06020F0D RID: 134925 RVA: 0x0048E4A4 File Offset: 0x0048C6A4
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

		// Token: 0x06020F0E RID: 134926 RVA: 0x0048E4E0 File Offset: 0x0048C6E0
		public static Offset<ISelfClientEvent> CreateISelfClientEvent(FlatBufferBuilder builder, EClientEventTarget Type = EClientEventTarget.Self)
		{
			builder.StartTable(1);
			ISelfClientEvent.AddType(builder, Type);
			return ISelfClientEvent.EndISelfClientEvent(builder);
		}

		// Token: 0x06020F0F RID: 134927 RVA: 0x0048E4F6 File Offset: 0x0048C6F6
		public static void StartISelfClientEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06020F10 RID: 134928 RVA: 0x0048E4FF File Offset: 0x0048C6FF
		public static void AddType(FlatBufferBuilder builder, EClientEventTarget type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020F11 RID: 134929 RVA: 0x0048E50A File Offset: 0x0048C70A
		public static Offset<ISelfClientEvent> EndISelfClientEvent(FlatBufferBuilder builder)
		{
			return new Offset<ISelfClientEvent>(builder.EndTable());
		}

		// Token: 0x06020F12 RID: 134930 RVA: 0x0048E518 File Offset: 0x0048C718
		public ISelfClientEventT UnPack()
		{
			ISelfClientEventT selfClientEventT = new ISelfClientEventT();
			this.UnPackTo(selfClientEventT);
			return selfClientEventT;
		}

		// Token: 0x06020F13 RID: 134931 RVA: 0x0048E533 File Offset: 0x0048C733
		public void UnPackTo(ISelfClientEventT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06020F14 RID: 134932 RVA: 0x0048E544 File Offset: 0x0048C744
		public static Offset<ISelfClientEvent> Pack(FlatBufferBuilder builder, ISelfClientEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISelfClientEvent>);
			}
			return ISelfClientEvent.CreateISelfClientEvent(builder, _o.Type);
		}

		// Token: 0x0400E1B1 RID: 57777
		private Table __p;
	}
}
