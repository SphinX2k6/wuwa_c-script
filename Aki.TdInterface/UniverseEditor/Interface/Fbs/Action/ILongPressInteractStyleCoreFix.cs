using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200716F RID: 29039
	public struct ILongPressInteractStyleCoreFix : IFlatbufferObject
	{
		// Token: 0x1700D491 RID: 54417
		// (get) Token: 0x06032784 RID: 206724 RVA: 0x006D2510 File Offset: 0x006D0710
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032785 RID: 206725 RVA: 0x006D251D File Offset: 0x006D071D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032786 RID: 206726 RVA: 0x006D2524 File Offset: 0x006D0724
		public static ILongPressInteractStyleCoreFix GetRootAsILongPressInteractStyleCoreFix(ByteBuffer _bb)
		{
			return ILongPressInteractStyleCoreFix.GetRootAsILongPressInteractStyleCoreFix(_bb, default(ILongPressInteractStyleCoreFix));
		}

		// Token: 0x06032787 RID: 206727 RVA: 0x006D2540 File Offset: 0x006D0740
		public static ILongPressInteractStyleCoreFix GetRootAsILongPressInteractStyleCoreFix(ByteBuffer _bb, ILongPressInteractStyleCoreFix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032788 RID: 206728 RVA: 0x006D255D File Offset: 0x006D075D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032789 RID: 206729 RVA: 0x006D256C File Offset: 0x006D076C
		public ILongPressInteractStyleCoreFix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D492 RID: 54418
		// (get) Token: 0x0603278A RID: 206730 RVA: 0x006D257C File Offset: 0x006D077C
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

		// Token: 0x0603278B RID: 206731 RVA: 0x006D25B8 File Offset: 0x006D07B8
		public static Offset<ILongPressInteractStyleCoreFix> CreateILongPressInteractStyleCoreFix(FlatBufferBuilder builder, ELongPressInteractStyle Type = ELongPressInteractStyle.Default)
		{
			builder.StartTable(1);
			ILongPressInteractStyleCoreFix.AddType(builder, Type);
			return ILongPressInteractStyleCoreFix.EndILongPressInteractStyleCoreFix(builder);
		}

		// Token: 0x0603278C RID: 206732 RVA: 0x006D25CE File Offset: 0x006D07CE
		public static void StartILongPressInteractStyleCoreFix(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603278D RID: 206733 RVA: 0x006D25D7 File Offset: 0x006D07D7
		public static void AddType(FlatBufferBuilder builder, ELongPressInteractStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603278E RID: 206734 RVA: 0x006D25E2 File Offset: 0x006D07E2
		public static Offset<ILongPressInteractStyleCoreFix> EndILongPressInteractStyleCoreFix(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractStyleCoreFix>(builder.EndTable());
		}

		// Token: 0x0603278F RID: 206735 RVA: 0x006D25F0 File Offset: 0x006D07F0
		public ILongPressInteractStyleCoreFixT UnPack()
		{
			ILongPressInteractStyleCoreFixT longPressInteractStyleCoreFixT = new ILongPressInteractStyleCoreFixT();
			this.UnPackTo(longPressInteractStyleCoreFixT);
			return longPressInteractStyleCoreFixT;
		}

		// Token: 0x06032790 RID: 206736 RVA: 0x006D260B File Offset: 0x006D080B
		public void UnPackTo(ILongPressInteractStyleCoreFixT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06032791 RID: 206737 RVA: 0x006D261C File Offset: 0x006D081C
		public static Offset<ILongPressInteractStyleCoreFix> Pack(FlatBufferBuilder builder, ILongPressInteractStyleCoreFixT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractStyleCoreFix>);
			}
			return ILongPressInteractStyleCoreFix.CreateILongPressInteractStyleCoreFix(builder, _o.Type);
		}

		// Token: 0x04012166 RID: 74086
		private Table __p;
	}
}
