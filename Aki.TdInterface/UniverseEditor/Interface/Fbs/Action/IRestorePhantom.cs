using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007639 RID: 30265
	public struct IRestorePhantom : IFlatbufferObject
	{
		// Token: 0x1700DE50 RID: 56912
		// (get) Token: 0x060351B7 RID: 217527 RVA: 0x00721BE4 File Offset: 0x0071FDE4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060351B8 RID: 217528 RVA: 0x00721BF1 File Offset: 0x0071FDF1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060351B9 RID: 217529 RVA: 0x00721BF8 File Offset: 0x0071FDF8
		public static IRestorePhantom GetRootAsIRestorePhantom(ByteBuffer _bb)
		{
			return IRestorePhantom.GetRootAsIRestorePhantom(_bb, default(IRestorePhantom));
		}

		// Token: 0x060351BA RID: 217530 RVA: 0x00721C14 File Offset: 0x0071FE14
		public static IRestorePhantom GetRootAsIRestorePhantom(ByteBuffer _bb, IRestorePhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060351BB RID: 217531 RVA: 0x00721C31 File Offset: 0x0071FE31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060351BC RID: 217532 RVA: 0x00721C40 File Offset: 0x0071FE40
		public IRestorePhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x060351BD RID: 217533 RVA: 0x00721C50 File Offset: 0x0071FE50
		public static void StartIRestorePhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x060351BE RID: 217534 RVA: 0x00721C59 File Offset: 0x0071FE59
		public static Offset<IRestorePhantom> EndIRestorePhantom(FlatBufferBuilder builder)
		{
			return new Offset<IRestorePhantom>(builder.EndTable());
		}

		// Token: 0x060351BF RID: 217535 RVA: 0x00721C68 File Offset: 0x0071FE68
		public IRestorePhantomT UnPack()
		{
			IRestorePhantomT restorePhantomT = new IRestorePhantomT();
			this.UnPackTo(restorePhantomT);
			return restorePhantomT;
		}

		// Token: 0x060351C0 RID: 217536 RVA: 0x00721C83 File Offset: 0x0071FE83
		public void UnPackTo(IRestorePhantomT _o)
		{
		}

		// Token: 0x060351C1 RID: 217537 RVA: 0x00721C88 File Offset: 0x0071FE88
		public static Offset<IRestorePhantom> Pack(FlatBufferBuilder builder, IRestorePhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestorePhantom>);
			}
			IRestorePhantom.StartIRestorePhantom(builder);
			return IRestorePhantom.EndIRestorePhantom(builder);
		}

		// Token: 0x0401282F RID: 75823
		private Table __p;
	}
}
