using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078AE RID: 30894
	public struct IShowMapMark : IFlatbufferObject
	{
		// Token: 0x1700E2A0 RID: 58016
		// (get) Token: 0x060365CB RID: 222667 RVA: 0x0074743C File Offset: 0x0074563C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060365CC RID: 222668 RVA: 0x00747449 File Offset: 0x00745649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060365CD RID: 222669 RVA: 0x00747450 File Offset: 0x00745650
		public static IShowMapMark GetRootAsIShowMapMark(ByteBuffer _bb)
		{
			return IShowMapMark.GetRootAsIShowMapMark(_bb, default(IShowMapMark));
		}

		// Token: 0x060365CE RID: 222670 RVA: 0x0074746C File Offset: 0x0074566C
		public static IShowMapMark GetRootAsIShowMapMark(ByteBuffer _bb, IShowMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060365CF RID: 222671 RVA: 0x00747489 File Offset: 0x00745689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060365D0 RID: 222672 RVA: 0x00747498 File Offset: 0x00745698
		public IShowMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2A1 RID: 58017
		// (get) Token: 0x060365D1 RID: 222673 RVA: 0x007474A8 File Offset: 0x007456A8
		public EMapMarkState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkState.Show;
				}
				return (EMapMarkState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E2A2 RID: 58018
		// (get) Token: 0x060365D2 RID: 222674 RVA: 0x007474E4 File Offset: 0x007456E4
		public int MarkId
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

		// Token: 0x1700E2A3 RID: 58019
		// (get) Token: 0x060365D3 RID: 222675 RVA: 0x00747520 File Offset: 0x00745720
		public bool IsFocusOnFirstShow
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E2A4 RID: 58020
		// (get) Token: 0x060365D4 RID: 222676 RVA: 0x00747560 File Offset: 0x00745760
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

		// Token: 0x060365D5 RID: 222677 RVA: 0x0074759D File Offset: 0x0074579D
		public static Offset<IShowMapMark> CreateIShowMapMark(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show, int MarkId = 0, bool IsFocusOnFirstShow = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowMapMark.AddMarkId(builder, MarkId);
			IShowMapMark.AddNullMask(builder, NullMask);
			IShowMapMark.AddIsFocusOnFirstShow(builder, IsFocusOnFirstShow);
			IShowMapMark.AddType(builder, Type);
			return IShowMapMark.EndIShowMapMark(builder);
		}

		// Token: 0x060365D6 RID: 222678 RVA: 0x007475C9 File Offset: 0x007457C9
		public static void StartIShowMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060365D7 RID: 222679 RVA: 0x007475D2 File Offset: 0x007457D2
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060365D8 RID: 222680 RVA: 0x007475DD File Offset: 0x007457DD
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x060365D9 RID: 222681 RVA: 0x007475E8 File Offset: 0x007457E8
		public static void AddIsFocusOnFirstShow(FlatBufferBuilder builder, bool isFocusOnFirstShow)
		{
			builder.AddBool(2, isFocusOnFirstShow, false);
		}

		// Token: 0x060365DA RID: 222682 RVA: 0x007475F3 File Offset: 0x007457F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060365DB RID: 222683 RVA: 0x007475FE File Offset: 0x007457FE
		public static Offset<IShowMapMark> EndIShowMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IShowMapMark>(builder.EndTable());
		}

		// Token: 0x060365DC RID: 222684 RVA: 0x0074760C File Offset: 0x0074580C
		public IShowMapMarkT UnPack()
		{
			IShowMapMarkT showMapMarkT = new IShowMapMarkT();
			this.UnPackTo(showMapMarkT);
			return showMapMarkT;
		}

		// Token: 0x060365DD RID: 222685 RVA: 0x00747627 File Offset: 0x00745827
		public void UnPackTo(IShowMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
			_o.IsFocusOnFirstShow = this.IsFocusOnFirstShow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060365DE RID: 222686 RVA: 0x0074765C File Offset: 0x0074585C
		public static Offset<IShowMapMark> Pack(FlatBufferBuilder builder, IShowMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowMapMark>);
			}
			return IShowMapMark.CreateIShowMapMark(builder, _o.Type, _o.MarkId, _o.IsFocusOnFirstShow, _o.NullMask);
		}

		// Token: 0x04012B4B RID: 76619
		private Table __p;
	}
}
