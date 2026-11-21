using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007169 RID: 29033
	public struct ILongPressInteractStyleConfigTimeBackInteract : IFlatbufferObject
	{
		// Token: 0x1700D486 RID: 54406
		// (get) Token: 0x06032752 RID: 206674 RVA: 0x006D1FE5 File Offset: 0x006D01E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032753 RID: 206675 RVA: 0x006D1FF2 File Offset: 0x006D01F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032754 RID: 206676 RVA: 0x006D1FFC File Offset: 0x006D01FC
		public static ILongPressInteractStyleConfigTimeBackInteract GetRootAsILongPressInteractStyleConfigTimeBackInteract(ByteBuffer _bb)
		{
			return ILongPressInteractStyleConfigTimeBackInteract.GetRootAsILongPressInteractStyleConfigTimeBackInteract(_bb, default(ILongPressInteractStyleConfigTimeBackInteract));
		}

		// Token: 0x06032755 RID: 206677 RVA: 0x006D2018 File Offset: 0x006D0218
		public static ILongPressInteractStyleConfigTimeBackInteract GetRootAsILongPressInteractStyleConfigTimeBackInteract(ByteBuffer _bb, ILongPressInteractStyleConfigTimeBackInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032756 RID: 206678 RVA: 0x006D2035 File Offset: 0x006D0235
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032757 RID: 206679 RVA: 0x006D2044 File Offset: 0x006D0244
		public ILongPressInteractStyleConfigTimeBackInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D487 RID: 54407
		// (get) Token: 0x06032758 RID: 206680 RVA: 0x006D2054 File Offset: 0x006D0254
		public ELongPressInteractStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELongPressInteractStyle.Default;
				}
				return (ELongPressInteractStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D488 RID: 54408
		// (get) Token: 0x06032759 RID: 206681 RVA: 0x006D2090 File Offset: 0x006D0290
		public string TidContent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603275A RID: 206682 RVA: 0x006D20C7 File Offset: 0x006D02C7
		public Span<byte> GetTidContentBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603275B RID: 206683 RVA: 0x006D20D6 File Offset: 0x006D02D6
		public byte[] GetTidContentArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D489 RID: 54409
		// (get) Token: 0x0603275C RID: 206684 RVA: 0x006D20E4 File Offset: 0x006D02E4
		public float StartProgress
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

		// Token: 0x1700D48A RID: 54410
		// (get) Token: 0x0603275D RID: 206685 RVA: 0x006D2124 File Offset: 0x006D0324
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

		// Token: 0x0603275E RID: 206686 RVA: 0x006D2161 File Offset: 0x006D0361
		public static Offset<ILongPressInteractStyleConfigTimeBackInteract> CreateILongPressInteractStyleConfigTimeBackInteract(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default, StringOffset TidContentOffset = default(StringOffset), float StartProgress = 0f, byte NullMask = 0)
		{
			builder.StartTable(4);
			ILongPressInteractStyleConfigTimeBackInteract.AddStartProgress(builder, StartProgress);
			ILongPressInteractStyleConfigTimeBackInteract.AddTidContent(builder, TidContentOffset);
			ILongPressInteractStyleConfigTimeBackInteract.AddNullMask(builder, NullMask);
			ILongPressInteractStyleConfigTimeBackInteract.AddType(builder, Type);
			return ILongPressInteractStyleConfigTimeBackInteract.EndILongPressInteractStyleConfigTimeBackInteract(builder);
		}

		// Token: 0x0603275F RID: 206687 RVA: 0x006D218D File Offset: 0x006D038D
		public static void StartILongPressInteractStyleConfigTimeBackInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06032760 RID: 206688 RVA: 0x006D2196 File Offset: 0x006D0396
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032761 RID: 206689 RVA: 0x006D21A1 File Offset: 0x006D03A1
		public static void AddTidContent(FlatBufferBuilder builder, StringOffset tidContentOffset)
		{
			builder.AddOffset(1, tidContentOffset.Value, 0);
		}

		// Token: 0x06032762 RID: 206690 RVA: 0x006D21B1 File Offset: 0x006D03B1
		public static void AddStartProgress(FlatBufferBuilder builder, float startProgress)
		{
			builder.AddFloat(2, startProgress, 0.0);
		}

		// Token: 0x06032763 RID: 206691 RVA: 0x006D21C4 File Offset: 0x006D03C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06032764 RID: 206692 RVA: 0x006D21CF File Offset: 0x006D03CF
		public static Offset<ILongPressInteractStyleConfigTimeBackInteract> EndILongPressInteractStyleConfigTimeBackInteract(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleConfigTimeBackInteract>(builder.EndTable());
		}

		// Token: 0x06032765 RID: 206693 RVA: 0x006D21DC File Offset: 0x006D03DC
		public ILongPressInteractStyleConfigTimeBackInteractT UnPack()
		{
			ILongPressInteractStyleConfigTimeBackInteractT longPressInteractStyleConfigTimeBackInteractT = new ILongPressInteractStyleConfigTimeBackInteractT();
			this.UnPackTo(longPressInteractStyleConfigTimeBackInteractT);
			return longPressInteractStyleConfigTimeBackInteractT;
		}

		// Token: 0x06032766 RID: 206694 RVA: 0x006D21F7 File Offset: 0x006D03F7
		public void UnPackTo(ILongPressInteractStyleConfigTimeBackInteractT _o)
		{
			_o.Type = this.Type;
			_o.TidContent = this.TidContent;
			_o.StartProgress = this.StartProgress;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032767 RID: 206695 RVA: 0x006D222C File Offset: 0x006D042C
		public static Offset<ILongPressInteractStyleConfigTimeBackInteract> Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfigTimeBackInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleConfigTimeBackInteract>);
			}
			StringOffset tidContentOffset = (_o.TidContent == null) ? default(StringOffset) : builder.CreateString(_o.TidContent);
			return ILongPressInteractStyleConfigTimeBackInteract.CreateILongPressInteractStyleConfigTimeBackInteract(builder, _o.Type, tidContentOffset, _o.StartProgress, _o.NullMask);
		}

		// Token: 0x04012158 RID: 74072
		private Table __p;
	}
}
