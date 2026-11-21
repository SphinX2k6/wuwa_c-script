using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE4 RID: 27620
	public struct IDestroy : IFlatbufferObject
	{
		// Token: 0x1700CA90 RID: 51856
		// (get) Token: 0x0602F898 RID: 194712 RVA: 0x0067B0AE File Offset: 0x006792AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F899 RID: 194713 RVA: 0x0067B0BB File Offset: 0x006792BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F89A RID: 194714 RVA: 0x0067B0C4 File Offset: 0x006792C4
		public static IDestroy GetRootAsIDestroy(ByteBuffer _bb)
		{
			return IDestroy.GetRootAsIDestroy(_bb, default(IDestroy));
		}

		// Token: 0x0602F89B RID: 194715 RVA: 0x0067B0E0 File Offset: 0x006792E0
		public static IDestroy GetRootAsIDestroy(ByteBuffer _bb, IDestroy obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F89C RID: 194716 RVA: 0x0067B0FD File Offset: 0x006792FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F89D RID: 194717 RVA: 0x0067B10C File Offset: 0x0067930C
		public IDestroy __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA91 RID: 51857
		// (get) Token: 0x0602F89E RID: 194718 RVA: 0x0067B11C File Offset: 0x0067931C
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CA92 RID: 51858
		// (get) Token: 0x0602F89F RID: 194719 RVA: 0x0067B15C File Offset: 0x0067935C
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

		// Token: 0x0602F8A0 RID: 194720 RVA: 0x0067B198 File Offset: 0x00679398
		public static Offset<IDestroy> CreateIDestroy(FlatBufferBuilder builder, bool DelayDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDestroy.AddNullMask(builder, NullMask);
			IDestroy.AddDelayDestroy(builder, DelayDestroy);
			return IDestroy.EndIDestroy(builder);
		}

		// Token: 0x0602F8A1 RID: 194721 RVA: 0x0067B1B5 File Offset: 0x006793B5
		public static void StartIDestroy(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F8A2 RID: 194722 RVA: 0x0067B1BE File Offset: 0x006793BE
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(0, delayDestroy, false);
		}

		// Token: 0x0602F8A3 RID: 194723 RVA: 0x0067B1C9 File Offset: 0x006793C9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602F8A4 RID: 194724 RVA: 0x0067B1D4 File Offset: 0x006793D4
		public static Offset<IDestroy> EndIDestroy(FlatBufferBuilder builder)
		{
			return new Offset<IDestroy>(builder.EndTable());
		}

		// Token: 0x0602F8A5 RID: 194725 RVA: 0x0067B1E4 File Offset: 0x006793E4
		public IDestroyT UnPack()
		{
			IDestroyT destroyT = new IDestroyT();
			this.UnPackTo(destroyT);
			return destroyT;
		}

		// Token: 0x0602F8A6 RID: 194726 RVA: 0x0067B1FF File Offset: 0x006793FF
		public void UnPackTo(IDestroyT _o)
		{
			_o.DelayDestroy = this.DelayDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F8A7 RID: 194727 RVA: 0x0067B21C File Offset: 0x0067941C
		public static Offset<IDestroy> Pack(FlatBufferBuilder builder, IDestroyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroy>);
			}
			return IDestroy.CreateIDestroy(builder, _o.DelayDestroy, _o.NullMask);
		}

		// Token: 0x040119E8 RID: 72168
		private Table __p;
	}
}
