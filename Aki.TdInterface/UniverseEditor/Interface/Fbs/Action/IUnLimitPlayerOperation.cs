using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CB3 RID: 31923
	public struct IUnLimitPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700EF03 RID: 61187
		// (get) Token: 0x0603996B RID: 235883 RVA: 0x007C56DC File Offset: 0x007C38DC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603996C RID: 235884 RVA: 0x007C56E9 File Offset: 0x007C38E9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603996D RID: 235885 RVA: 0x007C56F0 File Offset: 0x007C38F0
		public static IUnLimitPlayerOperation GetRootAsIUnLimitPlayerOperation(ByteBuffer _bb)
		{
			return IUnLimitPlayerOperation.GetRootAsIUnLimitPlayerOperation(_bb, default(IUnLimitPlayerOperation));
		}

		// Token: 0x0603996E RID: 235886 RVA: 0x007C570C File Offset: 0x007C390C
		public static IUnLimitPlayerOperation GetRootAsIUnLimitPlayerOperation(ByteBuffer _bb, IUnLimitPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603996F RID: 235887 RVA: 0x007C5729 File Offset: 0x007C3929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039970 RID: 235888 RVA: 0x007C5738 File Offset: 0x007C3938
		public IUnLimitPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06039971 RID: 235889 RVA: 0x007C5748 File Offset: 0x007C3948
		public static void StartIUnLimitPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x06039972 RID: 235890 RVA: 0x007C5751 File Offset: 0x007C3951
		public static Offset<IUnLimitPlayerOperation> EndIUnLimitPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IUnLimitPlayerOperation>(builder.EndTable());
		}

		// Token: 0x06039973 RID: 235891 RVA: 0x007C5760 File Offset: 0x007C3960
		public IUnLimitPlayerOperationT UnPack()
		{
			IUnLimitPlayerOperationT unLimitPlayerOperationT = new IUnLimitPlayerOperationT();
			this.UnPackTo(unLimitPlayerOperationT);
			return unLimitPlayerOperationT;
		}

		// Token: 0x06039974 RID: 235892 RVA: 0x007C577B File Offset: 0x007C397B
		public void UnPackTo(IUnLimitPlayerOperationT _o)
		{
		}

		// Token: 0x06039975 RID: 235893 RVA: 0x007C5780 File Offset: 0x007C3980
		public static Offset<IUnLimitPlayerOperation> Pack(FlatBufferBuilder builder, IUnLimitPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnLimitPlayerOperation>);
			}
			IUnLimitPlayerOperation.StartIUnLimitPlayerOperation(builder);
			return IUnLimitPlayerOperation.EndIUnLimitPlayerOperation(builder);
		}

		// Token: 0x040133B8 RID: 78776
		private Table __p;
	}
}
