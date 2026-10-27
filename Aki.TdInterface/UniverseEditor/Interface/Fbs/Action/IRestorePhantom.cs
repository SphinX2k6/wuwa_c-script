using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB5 RID: 28341
	public struct IRestorePhantom : IFlatbufferObject
	{
		// Token: 0x1700D2F9 RID: 54009
		// (get) Token: 0x06032177 RID: 205175 RVA: 0x006C5EB0 File Offset: 0x006C40B0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032178 RID: 205176 RVA: 0x006C5EBD File Offset: 0x006C40BD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032179 RID: 205177 RVA: 0x006C5EC4 File Offset: 0x006C40C4
		public static IRestorePhantom GetRootAsIRestorePhantom(ByteBuffer _bb)
		{
			return IRestorePhantom.GetRootAsIRestorePhantom(_bb, default(IRestorePhantom));
		}

		// Token: 0x0603217A RID: 205178 RVA: 0x006C5EE0 File Offset: 0x006C40E0
		public static IRestorePhantom GetRootAsIRestorePhantom(ByteBuffer _bb, IRestorePhantom obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603217B RID: 205179 RVA: 0x006C5EFD File Offset: 0x006C40FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603217C RID: 205180 RVA: 0x006C5F0C File Offset: 0x006C410C
		public IRestorePhantom __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603217D RID: 205181 RVA: 0x006C5F1C File Offset: 0x006C411C
		public static void StartIRestorePhantom(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603217E RID: 205182 RVA: 0x006C5F25 File Offset: 0x006C4125
		public static Offset<IRestorePhantom> EndIRestorePhantom(FlatBufferBuilder builder)
		{
			return new Offset<IRestorePhantom>(builder.EndTable());
		}

		// Token: 0x0603217F RID: 205183 RVA: 0x006C5F34 File Offset: 0x006C4134
		public IRestorePhantomT UnPack()
		{
			IRestorePhantomT restorePhantomT = new IRestorePhantomT();
			this.UnPackTo(restorePhantomT);
			return restorePhantomT;
		}

		// Token: 0x06032180 RID: 205184 RVA: 0x006C5F4F File Offset: 0x006C414F
		public void UnPackTo(IRestorePhantomT _o)
		{
		}

		// Token: 0x06032181 RID: 205185 RVA: 0x006C5F54 File Offset: 0x006C4154
		public static Offset<IRestorePhantom> Pack(FlatBufferBuilder builder, IRestorePhantomT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestorePhantom>);
			}
			IRestorePhantom.StartIRestorePhantom(builder);
			return IRestorePhantom.EndIRestorePhantom(builder);
		}

		// Token: 0x040118AA RID: 71850
		private Table __p;
	}
}
