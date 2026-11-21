using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CC RID: 22476
	public struct IFixedAngleItem : IFlatbufferObject
	{
		// Token: 0x1700A274 RID: 41588
		// (get) Token: 0x0602448B RID: 148619 RVA: 0x004FC5C1 File Offset: 0x004FA7C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602448C RID: 148620 RVA: 0x004FC5CE File Offset: 0x004FA7CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602448D RID: 148621 RVA: 0x004FC5D8 File Offset: 0x004FA7D8
		public static IFixedAngleItem GetRootAsIFixedAngleItem(ByteBuffer _bb)
		{
			return IFixedAngleItem.GetRootAsIFixedAngleItem(_bb, default(IFixedAngleItem));
		}

		// Token: 0x0602448E RID: 148622 RVA: 0x004FC5F4 File Offset: 0x004FA7F4
		public static IFixedAngleItem GetRootAsIFixedAngleItem(ByteBuffer _bb, IFixedAngleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602448F RID: 148623 RVA: 0x004FC611 File Offset: 0x004FA811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024490 RID: 148624 RVA: 0x004FC620 File Offset: 0x004FA820
		public IFixedAngleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A275 RID: 41589
		// (get) Token: 0x06024491 RID: 148625 RVA: 0x004FC630 File Offset: 0x004FA830
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

		// Token: 0x1700A276 RID: 41590
		// (get) Token: 0x06024492 RID: 148626 RVA: 0x004FC66C File Offset: 0x004FA86C
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

		// Token: 0x1700A277 RID: 41591
		// (get) Token: 0x06024493 RID: 148627 RVA: 0x004FC6A8 File Offset: 0x004FA8A8
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

		// Token: 0x06024494 RID: 148628 RVA: 0x004FC6E4 File Offset: 0x004FA8E4
		public static Offset<IFixedAngleItem> CreateIFixedAngleItem(FlatBufferBuilder builder, int InitAngle = 0, int TargetAngle = 0, int RotateAngle = 0)
		{
			builder.StartTable(3);
			IFixedAngleItem.AddRotateAngle(builder, RotateAngle);
			IFixedAngleItem.AddTargetAngle(builder, TargetAngle);
			IFixedAngleItem.AddInitAngle(builder, InitAngle);
			return IFixedAngleItem.EndIFixedAngleItem(builder);
		}

		// Token: 0x06024495 RID: 148629 RVA: 0x004FC708 File Offset: 0x004FA908
		public static void StartIFixedAngleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06024496 RID: 148630 RVA: 0x004FC711 File Offset: 0x004FA911
		public static void AddInitAngle(FlatBufferBuilder builder, int initAngle)
		{
			builder.AddInt(0, initAngle, 0);
		}

		// Token: 0x06024497 RID: 148631 RVA: 0x004FC71C File Offset: 0x004FA91C
		public static void AddTargetAngle(FlatBufferBuilder builder, int targetAngle)
		{
			builder.AddInt(1, targetAngle, 0);
		}

		// Token: 0x06024498 RID: 148632 RVA: 0x004FC727 File Offset: 0x004FA927
		public static void AddRotateAngle(FlatBufferBuilder builder, int rotateAngle)
		{
			builder.AddInt(2, rotateAngle, 0);
		}

		// Token: 0x06024499 RID: 148633 RVA: 0x004FC732 File Offset: 0x004FA932
		public static Offset<IFixedAngleItem> EndIFixedAngleItem(FlatBufferBuilder builder)
		{
			return new Offset<IFixedAngleItem>(builder.EndTable());
		}

		// Token: 0x0602449A RID: 148634 RVA: 0x004FC740 File Offset: 0x004FA940
		public IFixedAngleItemT UnPack()
		{
			IFixedAngleItemT fixedAngleItemT = new IFixedAngleItemT();
			this.UnPackTo(fixedAngleItemT);
			return fixedAngleItemT;
		}

		// Token: 0x0602449B RID: 148635 RVA: 0x004FC75B File Offset: 0x004FA95B
		public void UnPackTo(IFixedAngleItemT _o)
		{
			_o.InitAngle = this.InitAngle;
			_o.TargetAngle = this.TargetAngle;
			_o.RotateAngle = this.RotateAngle;
		}

		// Token: 0x0602449C RID: 148636 RVA: 0x004FC784 File Offset: 0x004FA984
		public static Offset<IFixedAngleItem> Pack(FlatBufferBuilder builder, IFixedAngleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedAngleItem>);
			}
			return IFixedAngleItem.CreateIFixedAngleItem(builder, _o.InitAngle, _o.TargetAngle, _o.RotateAngle);
		}

		// Token: 0x0400EFBA RID: 61370
		private Table __p;
	}
}
