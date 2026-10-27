using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200532D RID: 21293
	public struct IGridObjectComponent : IFlatbufferObject
	{
		// Token: 0x17009C68 RID: 40040
		// (get) Token: 0x06022CF4 RID: 142580 RVA: 0x004D2C68 File Offset: 0x004D0E68
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022CF5 RID: 142581 RVA: 0x004D2C75 File Offset: 0x004D0E75
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022CF6 RID: 142582 RVA: 0x004D2C7C File Offset: 0x004D0E7C
		public static IGridObjectComponent GetRootAsIGridObjectComponent(ByteBuffer _bb)
		{
			return IGridObjectComponent.GetRootAsIGridObjectComponent(_bb, default(IGridObjectComponent));
		}

		// Token: 0x06022CF7 RID: 142583 RVA: 0x004D2C98 File Offset: 0x004D0E98
		public static IGridObjectComponent GetRootAsIGridObjectComponent(ByteBuffer _bb, IGridObjectComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022CF8 RID: 142584 RVA: 0x004D2CB5 File Offset: 0x004D0EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022CF9 RID: 142585 RVA: 0x004D2CC4 File Offset: 0x004D0EC4
		public IGridObjectComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C69 RID: 40041
		// (get) Token: 0x06022CFA RID: 142586 RVA: 0x004D2CD4 File Offset: 0x004D0ED4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009C6A RID: 40042
		// (get) Token: 0x06022CFB RID: 142587 RVA: 0x004D2D14 File Offset: 0x004D0F14
		public IVector2? CellSize
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009C6B RID: 40043
		// (get) Token: 0x06022CFC RID: 142588 RVA: 0x004D2D74 File Offset: 0x004D0F74
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

		// Token: 0x06022CFD RID: 142589 RVA: 0x004D2DB0 File Offset: 0x004D0FB0
		public static Offset<IGridObjectComponent> CreateIGridObjectComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IVector2> CellSizeOffset = default(Offset<IVector2>), byte NullMask = 0)
		{
			builder.StartTable(3);
			IGridObjectComponent.AddCellSize(builder, CellSizeOffset);
			IGridObjectComponent.AddNullMask(builder, NullMask);
			IGridObjectComponent.AddDisabled(builder, Disabled);
			return IGridObjectComponent.EndIGridObjectComponent(builder);
		}

		// Token: 0x06022CFE RID: 142590 RVA: 0x004D2DD4 File Offset: 0x004D0FD4
		public static void StartIGridObjectComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022CFF RID: 142591 RVA: 0x004D2DDD File Offset: 0x004D0FDD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022D00 RID: 142592 RVA: 0x004D2DE8 File Offset: 0x004D0FE8
		public static void AddCellSize(FlatBufferBuilder builder, Offset<IVector2> cellSizeOffset)
		{
			builder.AddOffset(1, cellSizeOffset.Value, 0);
		}

		// Token: 0x06022D01 RID: 142593 RVA: 0x004D2DF8 File Offset: 0x004D0FF8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06022D02 RID: 142594 RVA: 0x004D2E03 File Offset: 0x004D1003
		public static Offset<IGridObjectComponent> EndIGridObjectComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGridObjectComponent>(builder.EndTable());
		}

		// Token: 0x06022D03 RID: 142595 RVA: 0x004D2E10 File Offset: 0x004D1010
		public IGridObjectComponentT UnPack()
		{
			IGridObjectComponentT gridObjectComponentT = new IGridObjectComponentT();
			this.UnPackTo(gridObjectComponentT);
			return gridObjectComponentT;
		}

		// Token: 0x06022D04 RID: 142596 RVA: 0x004D2E2C File Offset: 0x004D102C
		public void UnPackTo(IGridObjectComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.CellSize = ((this.CellSize != null) ? this.CellSize.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022D05 RID: 142597 RVA: 0x004D2E80 File Offset: 0x004D1080
		public static Offset<IGridObjectComponent> Pack(FlatBufferBuilder builder, IGridObjectComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGridObjectComponent>);
			}
			Offset<IVector2> cellSizeOffset = (_o.CellSize == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.CellSize);
			return IGridObjectComponent.CreateIGridObjectComponent(builder, _o.Disabled, cellSizeOffset, _o.NullMask);
		}

		// Token: 0x0400E4F0 RID: 58608
		private Table __p;
	}
}
