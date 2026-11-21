using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7A RID: 27770
	public struct IDragInteractPointInteraction : IFlatbufferObject
	{
		// Token: 0x1700CBAF RID: 52143
		// (get) Token: 0x0602FD72 RID: 195954 RVA: 0x00683D4E File Offset: 0x00681F4E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FD73 RID: 195955 RVA: 0x00683D5B File Offset: 0x00681F5B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FD74 RID: 195956 RVA: 0x00683D64 File Offset: 0x00681F64
		public static IDragInteractPointInteraction GetRootAsIDragInteractPointInteraction(ByteBuffer _bb)
		{
			return IDragInteractPointInteraction.GetRootAsIDragInteractPointInteraction(_bb, default(IDragInteractPointInteraction));
		}

		// Token: 0x0602FD75 RID: 195957 RVA: 0x00683D80 File Offset: 0x00681F80
		public static IDragInteractPointInteraction GetRootAsIDragInteractPointInteraction(ByteBuffer _bb, IDragInteractPointInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FD76 RID: 195958 RVA: 0x00683D9D File Offset: 0x00681F9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FD77 RID: 195959 RVA: 0x00683DAC File Offset: 0x00681FAC
		public IDragInteractPointInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBB0 RID: 52144
		// (get) Token: 0x0602FD78 RID: 195960 RVA: 0x00683DBC File Offset: 0x00681FBC
		public EInteractPointInteractionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractPointInteractionType.Drag;
				}
				return (EInteractPointInteractionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBB1 RID: 52145
		// (get) Token: 0x0602FD79 RID: 195961 RVA: 0x00683DF8 File Offset: 0x00681FF8
		public int DragItemTag
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

		// Token: 0x1700CBB2 RID: 52146
		// (get) Token: 0x0602FD7A RID: 195962 RVA: 0x00683E34 File Offset: 0x00682034
		public float CheckDistance
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CBB3 RID: 52147
		// (get) Token: 0x0602FD7B RID: 195963 RVA: 0x00683E74 File Offset: 0x00682074
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FD7C RID: 195964 RVA: 0x00683EB1 File Offset: 0x006820B1
		public static Offset<IDragInteractPointInteraction> CreateIDragInteractPointInteraction(FlatBufferBuilder builder, EInteractPointInteractionType Type = EInteractPointInteractionType.Drag, int DragItemTag = 0, float CheckDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDragInteractPointInteraction.AddCheckDistance(builder, CheckDistance);
			IDragInteractPointInteraction.AddDragItemTag(builder, DragItemTag);
			IDragInteractPointInteraction.AddNullMask(builder, NullMask);
			IDragInteractPointInteraction.AddType(builder, Type);
			return IDragInteractPointInteraction.EndIDragInteractPointInteraction(builder);
		}

		// Token: 0x0602FD7D RID: 195965 RVA: 0x00683EDD File Offset: 0x006820DD
		public static void StartIDragInteractPointInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602FD7E RID: 195966 RVA: 0x00683EE6 File Offset: 0x006820E6
		public static void AddType(FlatBufferBuilder builder, EInteractPointInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FD7F RID: 195967 RVA: 0x00683EF1 File Offset: 0x006820F1
		public static void AddDragItemTag(FlatBufferBuilder builder, int dragItemTag)
		{
			builder.AddInt(1, dragItemTag, 0);
		}

		// Token: 0x0602FD80 RID: 195968 RVA: 0x00683EFC File Offset: 0x006820FC
		public static void AddCheckDistance(FlatBufferBuilder builder, float checkDistance)
		{
			builder.AddFloat(2, checkDistance, 0.0);
		}

		// Token: 0x0602FD81 RID: 195969 RVA: 0x00683F0F File Offset: 0x0068210F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602FD82 RID: 195970 RVA: 0x00683F1A File Offset: 0x0068211A
		public static Offset<IDragInteractPointInteraction> EndIDragInteractPointInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IDragInteractPointInteraction>(builder.EndTable());
		}

		// Token: 0x0602FD83 RID: 195971 RVA: 0x00683F28 File Offset: 0x00682128
		public IDragInteractPointInteractionT UnPack()
		{
			IDragInteractPointInteractionT dragInteractPointInteractionT = new IDragInteractPointInteractionT();
			this.UnPackTo(dragInteractPointInteractionT);
			return dragInteractPointInteractionT;
		}

		// Token: 0x0602FD84 RID: 195972 RVA: 0x00683F43 File Offset: 0x00682143
		public void UnPackTo(IDragInteractPointInteractionT _o)
		{
			_o.Type = this.Type;
			_o.DragItemTag = this.DragItemTag;
			_o.CheckDistance = this.CheckDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FD85 RID: 195973 RVA: 0x00683F78 File Offset: 0x00682178
		public static Offset<IDragInteractPointInteraction> Pack(FlatBufferBuilder builder, IDragInteractPointInteractionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragInteractPointInteraction>);
			}
			return IDragInteractPointInteraction.CreateIDragInteractPointInteraction(builder, _o.Type, _o.DragItemTag, _o.CheckDistance, _o.NullMask);
		}

		// Token: 0x04011AA8 RID: 72360
		private Table __p;
	}
}
