using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC6 RID: 28358
	public struct IFocusOnCustomMapMark : IFlatbufferObject
	{
		// Token: 0x1700D007 RID: 53255
		// (get) Token: 0x0603110D RID: 200973 RVA: 0x006A75F8 File Offset: 0x006A57F8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603110E RID: 200974 RVA: 0x006A7605 File Offset: 0x006A5805
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603110F RID: 200975 RVA: 0x006A760C File Offset: 0x006A580C
		public static IFocusOnCustomMapMark GetRootAsIFocusOnCustomMapMark(ByteBuffer _bb)
		{
			return IFocusOnCustomMapMark.GetRootAsIFocusOnCustomMapMark(_bb, default(IFocusOnCustomMapMark));
		}

		// Token: 0x06031110 RID: 200976 RVA: 0x006A7628 File Offset: 0x006A5828
		public static IFocusOnCustomMapMark GetRootAsIFocusOnCustomMapMark(ByteBuffer _bb, IFocusOnCustomMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031111 RID: 200977 RVA: 0x006A7645 File Offset: 0x006A5845
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031112 RID: 200978 RVA: 0x006A7654 File Offset: 0x006A5854
		public IFocusOnCustomMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D008 RID: 53256
		// (get) Token: 0x06031113 RID: 200979 RVA: 0x006A7664 File Offset: 0x006A5864
		public EMapMarkType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkType.Custom;
				}
				return (EMapMarkType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D009 RID: 53257
		// (get) Token: 0x06031114 RID: 200980 RVA: 0x006A76A0 File Offset: 0x006A58A0
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

		// Token: 0x06031115 RID: 200981 RVA: 0x006A76DC File Offset: 0x006A58DC
		public static Offset<IFocusOnCustomMapMark> CreateIFocusOnCustomMapMark(FlatBufferBuilder builder, EMapMarkType Type = EMapMarkType.Custom, int MarkId = 0)
		{
			builder.StartTable(2);
			IFocusOnCustomMapMark.AddMarkId(builder, MarkId);
			IFocusOnCustomMapMark.AddType(builder, Type);
			return IFocusOnCustomMapMark.EndIFocusOnCustomMapMark(builder);
		}

		// Token: 0x06031116 RID: 200982 RVA: 0x006A76F9 File Offset: 0x006A58F9
		public static void StartIFocusOnCustomMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031117 RID: 200983 RVA: 0x006A7702 File Offset: 0x006A5902
		public static void AddType(FlatBufferBuilder builder, EMapMarkType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031118 RID: 200984 RVA: 0x006A770D File Offset: 0x006A590D
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x06031119 RID: 200985 RVA: 0x006A7718 File Offset: 0x006A5918
		public static Offset<IFocusOnCustomMapMark> EndIFocusOnCustomMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IFocusOnCustomMapMark>(builder.EndTable());
		}

		// Token: 0x0603111A RID: 200986 RVA: 0x006A7728 File Offset: 0x006A5928
		public IFocusOnCustomMapMarkT UnPack()
		{
			IFocusOnCustomMapMarkT focusOnCustomMapMarkT = new IFocusOnCustomMapMarkT();
			this.UnPackTo(focusOnCustomMapMarkT);
			return focusOnCustomMapMarkT;
		}

		// Token: 0x0603111B RID: 200987 RVA: 0x006A7743 File Offset: 0x006A5943
		public void UnPackTo(IFocusOnCustomMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
		}

		// Token: 0x0603111C RID: 200988 RVA: 0x006A7760 File Offset: 0x006A5960
		public static Offset<IFocusOnCustomMapMark> Pack(FlatBufferBuilder builder, IFocusOnCustomMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFocusOnCustomMapMark>);
			}
			return IFocusOnCustomMapMark.CreateIFocusOnCustomMapMark(builder, _o.Type, _o.MarkId);
		}

		// Token: 0x04011DC3 RID: 73155
		private Table __p;
	}
}
