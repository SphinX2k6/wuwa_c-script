using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB3 RID: 23219
	public struct IMechascoutDragLongPress : IFlatbufferObject
	{
		// Token: 0x1700A93E RID: 43326
		// (get) Token: 0x0602612D RID: 155949 RVA: 0x005377D1 File Offset: 0x005359D1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602612E RID: 155950 RVA: 0x005377DE File Offset: 0x005359DE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602612F RID: 155951 RVA: 0x005377E8 File Offset: 0x005359E8
		public static IMechascoutDragLongPress GetRootAsIMechascoutDragLongPress(ByteBuffer _bb)
		{
			return IMechascoutDragLongPress.GetRootAsIMechascoutDragLongPress(_bb, default(IMechascoutDragLongPress));
		}

		// Token: 0x06026130 RID: 155952 RVA: 0x00537804 File Offset: 0x00535A04
		public static IMechascoutDragLongPress GetRootAsIMechascoutDragLongPress(ByteBuffer _bb, IMechascoutDragLongPress obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026131 RID: 155953 RVA: 0x00537821 File Offset: 0x00535A21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026132 RID: 155954 RVA: 0x00537830 File Offset: 0x00535A30
		public IMechascoutDragLongPress __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A93F RID: 43327
		// (get) Token: 0x06026133 RID: 155955 RVA: 0x00537840 File Offset: 0x00535A40
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

		// Token: 0x1700A940 RID: 43328
		// (get) Token: 0x06026134 RID: 155956 RVA: 0x0053787C File Offset: 0x00535A7C
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

		// Token: 0x06026135 RID: 155957 RVA: 0x005378BC File Offset: 0x00535ABC
		public static Offset<IMechascoutDragLongPress> CreateIMechascoutDragLongPress(FlatBufferBuilder builder, EMechascoutDragType Type = EMechascoutDragType.Instant, float LongPressDuration = 0f)
		{
			builder.StartTable(2);
			IMechascoutDragLongPress.AddLongPressDuration(builder, LongPressDuration);
			IMechascoutDragLongPress.AddType(builder, Type);
			return IMechascoutDragLongPress.EndIMechascoutDragLongPress(builder);
		}

		// Token: 0x06026136 RID: 155958 RVA: 0x005378D9 File Offset: 0x00535AD9
		public static void StartIMechascoutDragLongPress(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026137 RID: 155959 RVA: 0x005378E2 File Offset: 0x00535AE2
		public static void AddType(FlatBufferBuilder builder, EMechascoutDragType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026138 RID: 155960 RVA: 0x005378ED File Offset: 0x00535AED
		public static void AddLongPressDuration(FlatBufferBuilder builder, float longPressDuration)
		{
			builder.AddFloat(1, longPressDuration, 0.0);
		}

		// Token: 0x06026139 RID: 155961 RVA: 0x00537900 File Offset: 0x00535B00
		public static Offset<IMechascoutDragLongPress> EndIMechascoutDragLongPress(FlatBufferBuilder builder)
		{
			return new Offset<IMechascoutDragLongPress>(builder.EndTable());
		}

		// Token: 0x0602613A RID: 155962 RVA: 0x00537910 File Offset: 0x00535B10
		public IMechascoutDragLongPressT UnPack()
		{
			IMechascoutDragLongPressT mechascoutDragLongPressT = new IMechascoutDragLongPressT();
			this.UnPackTo(mechascoutDragLongPressT);
			return mechascoutDragLongPressT;
		}

		// Token: 0x0602613B RID: 155963 RVA: 0x0053792B File Offset: 0x00535B2B
		public void UnPackTo(IMechascoutDragLongPressT _o)
		{
			_o.Type = this.Type;
			_o.LongPressDuration = this.LongPressDuration;
		}

		// Token: 0x0602613C RID: 155964 RVA: 0x00537948 File Offset: 0x00535B48
		public static Offset<IMechascoutDragLongPress> Pack(FlatBufferBuilder builder, IMechascoutDragLongPressT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechascoutDragLongPress>);
			}
			return IMechascoutDragLongPress.CreateIMechascoutDragLongPress(builder, _o.Type, _o.LongPressDuration);
		}

		// Token: 0x0400F45B RID: 62555
		private Table __p;
	}
}
