using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552D RID: 21805
	public struct IMechascoutDragLongPress : IFlatbufferObject
	{
		// Token: 0x1700A104 RID: 41220
		// (get) Token: 0x06024073 RID: 147571 RVA: 0x004FA6AD File Offset: 0x004F88AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024074 RID: 147572 RVA: 0x004FA6BA File Offset: 0x004F88BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024075 RID: 147573 RVA: 0x004FA6C4 File Offset: 0x004F88C4
		public static IMechascoutDragLongPress GetRootAsIMechascoutDragLongPress(ByteBuffer _bb)
		{
			return IMechascoutDragLongPress.GetRootAsIMechascoutDragLongPress(_bb, default(IMechascoutDragLongPress));
		}

		// Token: 0x06024076 RID: 147574 RVA: 0x004FA6E0 File Offset: 0x004F88E0
		public static IMechascoutDragLongPress GetRootAsIMechascoutDragLongPress(ByteBuffer _bb, IMechascoutDragLongPress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024077 RID: 147575 RVA: 0x004FA6FD File Offset: 0x004F88FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024078 RID: 147576 RVA: 0x004FA70C File Offset: 0x004F890C
		public IMechascoutDragLongPress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A105 RID: 41221
		// (get) Token: 0x06024079 RID: 147577 RVA: 0x004FA71C File Offset: 0x004F891C
		public EMechascoutDragType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMechascoutDragType.Instant;
				}
				return (EMechascoutDragType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A106 RID: 41222
		// (get) Token: 0x0602407A RID: 147578 RVA: 0x004FA758 File Offset: 0x004F8958
		public float LongPressDuration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602407B RID: 147579 RVA: 0x004FA798 File Offset: 0x004F8998
		public static Offset<IMechascoutDragLongPress> CreateIMechascoutDragLongPress(FlatBufferBuilder builder, EMechascoutDragType Type = EMechascoutDragType.Instant, float LongPressDuration = 0f)
		{
			builder.StartTable(2);
			IMechascoutDragLongPress.AddLongPressDuration(builder, LongPressDuration);
			IMechascoutDragLongPress.AddType(builder, Type);
			return IMechascoutDragLongPress.EndIMechascoutDragLongPress(builder);
		}

		// Token: 0x0602407C RID: 147580 RVA: 0x004FA7B5 File Offset: 0x004F89B5
		public static void StartIMechascoutDragLongPress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602407D RID: 147581 RVA: 0x004FA7BE File Offset: 0x004F89BE
		public static void AddType(FlatBufferBuilder builder, EMechascoutDragType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602407E RID: 147582 RVA: 0x004FA7C9 File Offset: 0x004F89C9
		public static void AddLongPressDuration(FlatBufferBuilder builder, float longPressDuration)
		{
			builder.AddFloat(1, longPressDuration, 0.0);
		}

		// Token: 0x0602407F RID: 147583 RVA: 0x004FA7DC File Offset: 0x004F89DC
		public static Offset<IMechascoutDragLongPress> EndIMechascoutDragLongPress(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutDragLongPress>(builder.EndTable());
		}

		// Token: 0x06024080 RID: 147584 RVA: 0x004FA7EC File Offset: 0x004F89EC
		public IMechascoutDragLongPressT UnPack()
		{
			IMechascoutDragLongPressT mechascoutDragLongPressT = new IMechascoutDragLongPressT();
			this.UnPackTo(mechascoutDragLongPressT);
			return mechascoutDragLongPressT;
		}

		// Token: 0x06024081 RID: 147585 RVA: 0x004FA807 File Offset: 0x004F8A07
		public void UnPackTo(IMechascoutDragLongPressT _o)
		{
			_o.Type = this.Type;
			_o.LongPressDuration = this.LongPressDuration;
		}

		// Token: 0x06024082 RID: 147586 RVA: 0x004FA824 File Offset: 0x004F8A24
		public static Offset<IMechascoutDragLongPress> Pack(FlatBufferBuilder builder, IMechascoutDragLongPressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutDragLongPress>);
			}
			return IMechascoutDragLongPress.CreateIMechascoutDragLongPress(builder, _o.Type, _o.LongPressDuration);
		}

		// Token: 0x0400E82A RID: 59434
		private Table __p;
	}
}
