using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007166 RID: 29030
	public struct ILongPressInteractStyleConfigDefault : IFlatbufferObject
	{
		// Token: 0x1700D483 RID: 54403
		// (get) Token: 0x06032740 RID: 206656 RVA: 0x006D1E6D File Offset: 0x006D006D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032741 RID: 206657 RVA: 0x006D1E7A File Offset: 0x006D007A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032742 RID: 206658 RVA: 0x006D1E84 File Offset: 0x006D0084
		public static ILongPressInteractStyleConfigDefault GetRootAsILongPressInteractStyleConfigDefault(ByteBuffer _bb)
		{
			return ILongPressInteractStyleConfigDefault.GetRootAsILongPressInteractStyleConfigDefault(_bb, default(ILongPressInteractStyleConfigDefault));
		}

		// Token: 0x06032743 RID: 206659 RVA: 0x006D1EA0 File Offset: 0x006D00A0
		public static ILongPressInteractStyleConfigDefault GetRootAsILongPressInteractStyleConfigDefault(ByteBuffer _bb, ILongPressInteractStyleConfigDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032744 RID: 206660 RVA: 0x006D1EBD File Offset: 0x006D00BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032745 RID: 206661 RVA: 0x006D1ECC File Offset: 0x006D00CC
		public ILongPressInteractStyleConfigDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D484 RID: 54404
		// (get) Token: 0x06032746 RID: 206662 RVA: 0x006D1EDC File Offset: 0x006D00DC
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

		// Token: 0x06032747 RID: 206663 RVA: 0x006D1F18 File Offset: 0x006D0118
		public static Offset<ILongPressInteractStyleConfigDefault> CreateILongPressInteractStyleConfigDefault(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleConfigDefault.AddType(builder, Type);
			return ILongPressInteractStyleConfigDefault.EndILongPressInteractStyleConfigDefault(builder);
		}

		// Token: 0x06032748 RID: 206664 RVA: 0x006D1F2E File Offset: 0x006D012E
		public static void StartILongPressInteractStyleConfigDefault(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06032749 RID: 206665 RVA: 0x006D1F37 File Offset: 0x006D0137
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603274A RID: 206666 RVA: 0x006D1F42 File Offset: 0x006D0142
		public static Offset<ILongPressInteractStyleConfigDefault> EndILongPressInteractStyleConfigDefault(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleConfigDefault>(builder.EndTable());
		}

		// Token: 0x0603274B RID: 206667 RVA: 0x006D1F50 File Offset: 0x006D0150
		public ILongPressInteractStyleConfigDefaultT UnPack()
		{
			ILongPressInteractStyleConfigDefaultT longPressInteractStyleConfigDefaultT = new ILongPressInteractStyleConfigDefaultT();
			this.UnPackTo(longPressInteractStyleConfigDefaultT);
			return longPressInteractStyleConfigDefaultT;
		}

		// Token: 0x0603274C RID: 206668 RVA: 0x006D1F6B File Offset: 0x006D016B
		public void UnPackTo(ILongPressInteractStyleConfigDefaultT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603274D RID: 206669 RVA: 0x006D1F7C File Offset: 0x006D017C
		public static Offset<ILongPressInteractStyleConfigDefault> Pack(FlatBufferBuilder builder, ILongPressInteractStyleConfigDefaultT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleConfigDefault>);
			}
			return ILongPressInteractStyleConfigDefault.CreateILongPressInteractStyleConfigDefault(builder, _o.Type);
		}

		// Token: 0x04012156 RID: 74070
		private Table __p;
	}
}
