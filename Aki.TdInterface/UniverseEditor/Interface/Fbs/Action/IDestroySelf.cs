using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200659D RID: 26013
	public struct IDestroySelf : IFlatbufferObject
	{
		// Token: 0x1700C12F RID: 49455
		// (get) Token: 0x0602D1FD RID: 184829 RVA: 0x006306AC File Offset: 0x0062E8AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D1FE RID: 184830 RVA: 0x006306B9 File Offset: 0x0062E8B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D1FF RID: 184831 RVA: 0x006306C0 File Offset: 0x0062E8C0
		public static IDestroySelf GetRootAsIDestroySelf(ByteBuffer _bb)
		{
			return IDestroySelf.GetRootAsIDestroySelf(_bb, default(IDestroySelf));
		}

		// Token: 0x0602D200 RID: 184832 RVA: 0x006306DC File Offset: 0x0062E8DC
		public static IDestroySelf GetRootAsIDestroySelf(ByteBuffer _bb, IDestroySelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D201 RID: 184833 RVA: 0x006306F9 File Offset: 0x0062E8F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D202 RID: 184834 RVA: 0x00630708 File Offset: 0x0062E908
		public IDestroySelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C130 RID: 49456
		// (get) Token: 0x0602D203 RID: 184835 RVA: 0x00630718 File Offset: 0x0062E918
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C131 RID: 49457
		// (get) Token: 0x0602D204 RID: 184836 RVA: 0x00630758 File Offset: 0x0062E958
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602D205 RID: 184837 RVA: 0x00630794 File Offset: 0x0062E994
		public static Offset<IDestroySelf> CreateIDestroySelf(FlatBufferBuilder builder, bool DelayDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDestroySelf.AddNullMask(builder, NullMask);
			IDestroySelf.AddDelayDestroy(builder, DelayDestroy);
			return IDestroySelf.EndIDestroySelf(builder);
		}

		// Token: 0x0602D206 RID: 184838 RVA: 0x006307B1 File Offset: 0x0062E9B1
		public static void StartIDestroySelf(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D207 RID: 184839 RVA: 0x006307BA File Offset: 0x0062E9BA
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(0, delayDestroy, false);
		}

		// Token: 0x0602D208 RID: 184840 RVA: 0x006307C5 File Offset: 0x0062E9C5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602D209 RID: 184841 RVA: 0x006307D0 File Offset: 0x0062E9D0
		public static Offset<IDestroySelf> EndIDestroySelf(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySelf>(builder.EndTable());
		}

		// Token: 0x0602D20A RID: 184842 RVA: 0x006307E0 File Offset: 0x0062E9E0
		public IDestroySelfT UnPack()
		{
			IDestroySelfT destroySelfT = new IDestroySelfT();
			this.UnPackTo(destroySelfT);
			return destroySelfT;
		}

		// Token: 0x0602D20B RID: 184843 RVA: 0x006307FB File Offset: 0x0062E9FB
		public void UnPackTo(IDestroySelfT _o)
		{
			_o.DelayDestroy = this.DelayDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602D20C RID: 184844 RVA: 0x00630818 File Offset: 0x0062EA18
		public static Offset<IDestroySelf> Pack(FlatBufferBuilder builder, IDestroySelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySelf>);
			}
			return IDestroySelf.CreateIDestroySelf(builder, _o.DelayDestroy, _o.NullMask);
		}

		// Token: 0x04010BF7 RID: 68599
		private Table __p;
	}
}
