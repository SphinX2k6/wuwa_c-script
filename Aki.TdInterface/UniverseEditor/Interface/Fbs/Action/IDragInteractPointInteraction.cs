using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006609 RID: 26121
	public struct IDragInteractPointInteraction : IFlatbufferObject
	{
		// Token: 0x1700C211 RID: 49681
		// (get) Token: 0x0602D5A1 RID: 185761 RVA: 0x006371E6 File Offset: 0x006353E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D5A2 RID: 185762 RVA: 0x006371F3 File Offset: 0x006353F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D5A3 RID: 185763 RVA: 0x006371FC File Offset: 0x006353FC
		public static IDragInteractPointInteraction GetRootAsIDragInteractPointInteraction(ByteBuffer _bb)
		{
			return IDragInteractPointInteraction.GetRootAsIDragInteractPointInteraction(_bb, default(IDragInteractPointInteraction));
		}

		// Token: 0x0602D5A4 RID: 185764 RVA: 0x00637218 File Offset: 0x00635418
		public static IDragInteractPointInteraction GetRootAsIDragInteractPointInteraction(ByteBuffer _bb, IDragInteractPointInteraction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D5A5 RID: 185765 RVA: 0x00637235 File Offset: 0x00635435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D5A6 RID: 185766 RVA: 0x00637244 File Offset: 0x00635444
		public IDragInteractPointInteraction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C212 RID: 49682
		// (get) Token: 0x0602D5A7 RID: 185767 RVA: 0x00637254 File Offset: 0x00635454
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

		// Token: 0x1700C213 RID: 49683
		// (get) Token: 0x0602D5A8 RID: 185768 RVA: 0x00637290 File Offset: 0x00635490
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

		// Token: 0x1700C214 RID: 49684
		// (get) Token: 0x0602D5A9 RID: 185769 RVA: 0x006372CC File Offset: 0x006354CC
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

		// Token: 0x1700C215 RID: 49685
		// (get) Token: 0x0602D5AA RID: 185770 RVA: 0x0063730C File Offset: 0x0063550C
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

		// Token: 0x0602D5AB RID: 185771 RVA: 0x00637349 File Offset: 0x00635549
		public static Offset<IDragInteractPointInteraction> CreateIDragInteractPointInteraction(FlatBufferBuilder builder, EInteractPointInteractionType Type = EInteractPointInteractionType.Drag, int DragItemTag = 0, float CheckDistance = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			IDragInteractPointInteraction.AddCheckDistance(builder, CheckDistance);
			IDragInteractPointInteraction.AddDragItemTag(builder, DragItemTag);
			IDragInteractPointInteraction.AddNullMask(builder, NullMask);
			IDragInteractPointInteraction.AddType(builder, Type);
			return IDragInteractPointInteraction.EndIDragInteractPointInteraction(builder);
		}

		// Token: 0x0602D5AC RID: 185772 RVA: 0x00637375 File Offset: 0x00635575
		public static void StartIDragInteractPointInteraction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602D5AD RID: 185773 RVA: 0x0063737E File Offset: 0x0063557E
		public static void AddType(FlatBufferBuilder builder, EInteractPointInteractionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D5AE RID: 185774 RVA: 0x00637389 File Offset: 0x00635589
		public static void AddDragItemTag(FlatBufferBuilder builder, int dragItemTag)
		{
			builder.AddInt(1, dragItemTag, 0);
		}

		// Token: 0x0602D5AF RID: 185775 RVA: 0x00637394 File Offset: 0x00635594
		public static void AddCheckDistance(FlatBufferBuilder builder, float checkDistance)
		{
			builder.AddFloat(2, checkDistance, 0.0);
		}

		// Token: 0x0602D5B0 RID: 185776 RVA: 0x006373A7 File Offset: 0x006355A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602D5B1 RID: 185777 RVA: 0x006373B2 File Offset: 0x006355B2
		public static Offset<IDragInteractPointInteraction> EndIDragInteractPointInteraction(FlatBufferBuilder builder)
		{
			return new Offset<IDragInteractPointInteraction>(builder.EndTable());
		}

		// Token: 0x0602D5B2 RID: 185778 RVA: 0x006373C0 File Offset: 0x006355C0
		public IDragInteractPointInteractionT UnPack()
		{
			IDragInteractPointInteractionT dragInteractPointInteractionT = new IDragInteractPointInteractionT();
			this.UnPackTo(dragInteractPointInteractionT);
			return dragInteractPointInteractionT;
		}

		// Token: 0x0602D5B3 RID: 185779 RVA: 0x006373DB File Offset: 0x006355DB
		public void UnPackTo(IDragInteractPointInteractionT _o)
		{
			_o.Type = this.Type;
			_o.DragItemTag = this.DragItemTag;
			_o.CheckDistance = this.CheckDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D5B4 RID: 185780 RVA: 0x00637410 File Offset: 0x00635610
		public static Offset<IDragInteractPointInteraction> Pack(FlatBufferBuilder builder, IDragInteractPointInteractionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragInteractPointInteraction>);
			}
			return IDragInteractPointInteraction.CreateIDragInteractPointInteraction(builder, _o.Type, _o.DragItemTag, _o.CheckDistance, _o.NullMask);
		}

		// Token: 0x04010C8D RID: 68749
		private Table __p;
	}
}
