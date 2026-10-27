using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005264 RID: 21092
	public struct IFixedAngleItem : IFlatbufferObject
	{
		// Token: 0x17009A78 RID: 39544
		// (get) Token: 0x060224F5 RID: 140533 RVA: 0x004C1AFD File Offset: 0x004BFCFD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224F6 RID: 140534 RVA: 0x004C1B0A File Offset: 0x004BFD0A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224F7 RID: 140535 RVA: 0x004C1B14 File Offset: 0x004BFD14
		public static IFixedAngleItem GetRootAsIFixedAngleItem(ByteBuffer _bb)
		{
			return IFixedAngleItem.GetRootAsIFixedAngleItem(_bb, default(IFixedAngleItem));
		}

		// Token: 0x060224F8 RID: 140536 RVA: 0x004C1B30 File Offset: 0x004BFD30
		public static IFixedAngleItem GetRootAsIFixedAngleItem(ByteBuffer _bb, IFixedAngleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224F9 RID: 140537 RVA: 0x004C1B4D File Offset: 0x004BFD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224FA RID: 140538 RVA: 0x004C1B5C File Offset: 0x004BFD5C
		public IFixedAngleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A79 RID: 39545
		// (get) Token: 0x060224FB RID: 140539 RVA: 0x004C1B6C File Offset: 0x004BFD6C
		public int InitAngle
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

		// Token: 0x17009A7A RID: 39546
		// (get) Token: 0x060224FC RID: 140540 RVA: 0x004C1BA8 File Offset: 0x004BFDA8
		public int TargetAngle
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

		// Token: 0x17009A7B RID: 39547
		// (get) Token: 0x060224FD RID: 140541 RVA: 0x004C1BE4 File Offset: 0x004BFDE4
		public int RotateAngle
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060224FE RID: 140542 RVA: 0x004C1C20 File Offset: 0x004BFE20
		public static Offset<IFixedAngleItem> CreateIFixedAngleItem(FlatBufferBuilder builder, int InitAngle = 0, int TargetAngle = 0, int RotateAngle = 0)
		{
			builder.StartTable(3);
			IFixedAngleItem.AddRotateAngle(builder, RotateAngle);
			IFixedAngleItem.AddTargetAngle(builder, TargetAngle);
			IFixedAngleItem.AddInitAngle(builder, InitAngle);
			return IFixedAngleItem.EndIFixedAngleItem(builder);
		}

		// Token: 0x060224FF RID: 140543 RVA: 0x004C1C44 File Offset: 0x004BFE44
		public static void StartIFixedAngleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06022500 RID: 140544 RVA: 0x004C1C4D File Offset: 0x004BFE4D
		public static void AddInitAngle(FlatBufferBuilder builder, int initAngle)
		{
			builder.AddInt(0, initAngle, 0);
		}

		// Token: 0x06022501 RID: 140545 RVA: 0x004C1C58 File Offset: 0x004BFE58
		public static void AddTargetAngle(FlatBufferBuilder builder, int targetAngle)
		{
			builder.AddInt(1, targetAngle, 0);
		}

		// Token: 0x06022502 RID: 140546 RVA: 0x004C1C63 File Offset: 0x004BFE63
		public static void AddRotateAngle(FlatBufferBuilder builder, int rotateAngle)
		{
			builder.AddInt(2, rotateAngle, 0);
		}

		// Token: 0x06022503 RID: 140547 RVA: 0x004C1C6E File Offset: 0x004BFE6E
		public static Offset<IFixedAngleItem> EndIFixedAngleItem(FlatBufferBuilder builder)
		{
			return new Offset<IFixedAngleItem>(builder.EndTable());
		}

		// Token: 0x06022504 RID: 140548 RVA: 0x004C1C7C File Offset: 0x004BFE7C
		public IFixedAngleItemT UnPack()
		{
			IFixedAngleItemT fixedAngleItemT = new IFixedAngleItemT();
			this.UnPackTo(fixedAngleItemT);
			return fixedAngleItemT;
		}

		// Token: 0x06022505 RID: 140549 RVA: 0x004C1C97 File Offset: 0x004BFE97
		public void UnPackTo(IFixedAngleItemT _o)
		{
			_o.InitAngle = this.InitAngle;
			_o.TargetAngle = this.TargetAngle;
			_o.RotateAngle = this.RotateAngle;
		}

		// Token: 0x06022506 RID: 140550 RVA: 0x004C1CC0 File Offset: 0x004BFEC0
		public static Offset<IFixedAngleItem> Pack(FlatBufferBuilder builder, IFixedAngleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedAngleItem>);
			}
			return IFixedAngleItem.CreateIFixedAngleItem(builder, _o.InitAngle, _o.TargetAngle, _o.RotateAngle);
		}

		// Token: 0x0400E3B4 RID: 58292
		private Table __p;
	}
}
