using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E2 RID: 28898
	public struct IShowMapMark : IFlatbufferObject
	{
		// Token: 0x1700D6BD RID: 54973
		// (get) Token: 0x06033329 RID: 209705 RVA: 0x006E6E30 File Offset: 0x006E5030
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603332A RID: 209706 RVA: 0x006E6E3D File Offset: 0x006E503D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603332B RID: 209707 RVA: 0x006E6E44 File Offset: 0x006E5044
		public static IShowMapMark GetRootAsIShowMapMark(ByteBuffer _bb)
		{
			return IShowMapMark.GetRootAsIShowMapMark(_bb, default(IShowMapMark));
		}

		// Token: 0x0603332C RID: 209708 RVA: 0x006E6E60 File Offset: 0x006E5060
		public static IShowMapMark GetRootAsIShowMapMark(ByteBuffer _bb, IShowMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603332D RID: 209709 RVA: 0x006E6E7D File Offset: 0x006E507D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603332E RID: 209710 RVA: 0x006E6E8C File Offset: 0x006E508C
		public IShowMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6BE RID: 54974
		// (get) Token: 0x0603332F RID: 209711 RVA: 0x006E6E9C File Offset: 0x006E509C
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

		// Token: 0x1700D6BF RID: 54975
		// (get) Token: 0x06033330 RID: 209712 RVA: 0x006E6ED8 File Offset: 0x006E50D8
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

		// Token: 0x1700D6C0 RID: 54976
		// (get) Token: 0x06033331 RID: 209713 RVA: 0x006E6F14 File Offset: 0x006E5114
		public bool IsFocusOnFirstShow
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D6C1 RID: 54977
		// (get) Token: 0x06033332 RID: 209714 RVA: 0x006E6F54 File Offset: 0x006E5154
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

		// Token: 0x06033333 RID: 209715 RVA: 0x006E6F91 File Offset: 0x006E5191
		public static Offset<IShowMapMark> CreateIShowMapMark(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show, int MarkId = 0, bool IsFocusOnFirstShow = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IShowMapMark.AddMarkId(builder, MarkId);
			IShowMapMark.AddNullMask(builder, NullMask);
			IShowMapMark.AddIsFocusOnFirstShow(builder, IsFocusOnFirstShow);
			IShowMapMark.AddType(builder, Type);
			return IShowMapMark.EndIShowMapMark(builder);
		}

		// Token: 0x06033334 RID: 209716 RVA: 0x006E6FBD File Offset: 0x006E51BD
		public static void StartIShowMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06033335 RID: 209717 RVA: 0x006E6FC6 File Offset: 0x006E51C6
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033336 RID: 209718 RVA: 0x006E6FD1 File Offset: 0x006E51D1
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x06033337 RID: 209719 RVA: 0x006E6FDC File Offset: 0x006E51DC
		public static void AddIsFocusOnFirstShow(FlatBufferBuilder builder, bool isFocusOnFirstShow)
		{
			builder.AddBool(2, isFocusOnFirstShow, false);
		}

		// Token: 0x06033338 RID: 209720 RVA: 0x006E6FE7 File Offset: 0x006E51E7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06033339 RID: 209721 RVA: 0x006E6FF2 File Offset: 0x006E51F2
		public static Offset<IShowMapMark> EndIShowMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IShowMapMark>(builder.EndTable());
		}

		// Token: 0x0603333A RID: 209722 RVA: 0x006E7000 File Offset: 0x006E5200
		public IShowMapMarkT UnPack()
		{
			IShowMapMarkT showMapMarkT = new IShowMapMarkT();
			this.UnPackTo(showMapMarkT);
			return showMapMarkT;
		}

		// Token: 0x0603333B RID: 209723 RVA: 0x006E701B File Offset: 0x006E521B
		public void UnPackTo(IShowMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
			_o.IsFocusOnFirstShow = this.IsFocusOnFirstShow;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603333C RID: 209724 RVA: 0x006E7050 File Offset: 0x006E5250
		public static Offset<IShowMapMark> Pack(FlatBufferBuilder builder, IShowMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowMapMark>);
			}
			return IShowMapMark.CreateIShowMapMark(builder, _o.Type, _o.MarkId, _o.IsFocusOnFirstShow, _o.NullMask);
		}

		// Token: 0x04011B5D RID: 72541
		private Table __p;
	}
}
