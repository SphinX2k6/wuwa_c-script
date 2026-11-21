using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007172 RID: 29042
	public struct ILongPressInteractStyleSwordRider : IFlatbufferObject
	{
		// Token: 0x1700D494 RID: 54420
		// (get) Token: 0x06032796 RID: 206742 RVA: 0x006D2685 File Offset: 0x006D0885
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032797 RID: 206743 RVA: 0x006D2692 File Offset: 0x006D0892
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032798 RID: 206744 RVA: 0x006D269C File Offset: 0x006D089C
		public static ILongPressInteractStyleSwordRider GetRootAsILongPressInteractStyleSwordRider(ByteBuffer _bb)
		{
			return ILongPressInteractStyleSwordRider.GetRootAsILongPressInteractStyleSwordRider(_bb, default(ILongPressInteractStyleSwordRider));
		}

		// Token: 0x06032799 RID: 206745 RVA: 0x006D26B8 File Offset: 0x006D08B8
		public static ILongPressInteractStyleSwordRider GetRootAsILongPressInteractStyleSwordRider(ByteBuffer _bb, ILongPressInteractStyleSwordRider obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603279A RID: 206746 RVA: 0x006D26D5 File Offset: 0x006D08D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603279B RID: 206747 RVA: 0x006D26E4 File Offset: 0x006D08E4
		public ILongPressInteractStyleSwordRider __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D495 RID: 54421
		// (get) Token: 0x0603279C RID: 206748 RVA: 0x006D26F4 File Offset: 0x006D08F4
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

		// Token: 0x0603279D RID: 206749 RVA: 0x006D2730 File Offset: 0x006D0930
		public static Offset<ILongPressInteractStyleSwordRider> CreateILongPressInteractStyleSwordRider(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleSwordRider.AddType(builder, Type);
			return ILongPressInteractStyleSwordRider.EndILongPressInteractStyleSwordRider(builder);
		}

		// Token: 0x0603279E RID: 206750 RVA: 0x006D2746 File Offset: 0x006D0946
		public static void StartILongPressInteractStyleSwordRider(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603279F RID: 206751 RVA: 0x006D274F File Offset: 0x006D094F
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060327A0 RID: 206752 RVA: 0x006D275A File Offset: 0x006D095A
		public static Offset<ILongPressInteractStyleSwordRider> EndILongPressInteractStyleSwordRider(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleSwordRider>(builder.EndTable());
		}

		// Token: 0x060327A1 RID: 206753 RVA: 0x006D2768 File Offset: 0x006D0968
		public ILongPressInteractStyleSwordRiderT UnPack()
		{
			ILongPressInteractStyleSwordRiderT longPressInteractStyleSwordRiderT = new ILongPressInteractStyleSwordRiderT();
			this.UnPackTo(longPressInteractStyleSwordRiderT);
			return longPressInteractStyleSwordRiderT;
		}

		// Token: 0x060327A2 RID: 206754 RVA: 0x006D2783 File Offset: 0x006D0983
		public void UnPackTo(ILongPressInteractStyleSwordRiderT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060327A3 RID: 206755 RVA: 0x006D2794 File Offset: 0x006D0994
		public static Offset<ILongPressInteractStyleSwordRider> Pack(FlatBufferBuilder builder, ILongPressInteractStyleSwordRiderT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleSwordRider>);
			}
			return ILongPressInteractStyleSwordRider.CreateILongPressInteractStyleSwordRider(builder, _o.Type);
		}

		// Token: 0x04012168 RID: 74088
		private Table __p;
	}
}
