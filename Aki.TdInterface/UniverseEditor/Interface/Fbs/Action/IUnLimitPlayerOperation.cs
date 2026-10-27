using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074BD RID: 29885
	public struct IUnLimitPlayerOperation : IFlatbufferObject
	{
		// Token: 0x1700E2D9 RID: 58073
		// (get) Token: 0x06036556 RID: 222550 RVA: 0x0076248C File Offset: 0x0076068C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036557 RID: 222551 RVA: 0x00762499 File Offset: 0x00760699
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036558 RID: 222552 RVA: 0x007624A0 File Offset: 0x007606A0
		public static IUnLimitPlayerOperation GetRootAsIUnLimitPlayerOperation(ByteBuffer _bb)
		{
			return IUnLimitPlayerOperation.GetRootAsIUnLimitPlayerOperation(_bb, default(IUnLimitPlayerOperation));
		}

		// Token: 0x06036559 RID: 222553 RVA: 0x007624BC File Offset: 0x007606BC
		public static IUnLimitPlayerOperation GetRootAsIUnLimitPlayerOperation(ByteBuffer _bb, IUnLimitPlayerOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603655A RID: 222554 RVA: 0x007624D9 File Offset: 0x007606D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603655B RID: 222555 RVA: 0x007624E8 File Offset: 0x007606E8
		public IUnLimitPlayerOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0603655C RID: 222556 RVA: 0x007624F8 File Offset: 0x007606F8
		public static void StartIUnLimitPlayerOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0603655D RID: 222557 RVA: 0x00762501 File Offset: 0x00760701
		public static Offset<IUnLimitPlayerOperation> EndIUnLimitPlayerOperation(FlatBufferBuilder builder)
		{
			return new Offset<IUnLimitPlayerOperation>(builder.EndTable());
		}

		// Token: 0x0603655E RID: 222558 RVA: 0x00762510 File Offset: 0x00760710
		public IUnLimitPlayerOperationT UnPack()
		{
			IUnLimitPlayerOperationT unLimitPlayerOperationT = new IUnLimitPlayerOperationT();
			this.UnPackTo(unLimitPlayerOperationT);
			return unLimitPlayerOperationT;
		}

		// Token: 0x0603655F RID: 222559 RVA: 0x0076252B File Offset: 0x0076072B
		public void UnPackTo(IUnLimitPlayerOperationT _o)
		{
		}

		// Token: 0x06036560 RID: 222560 RVA: 0x00762530 File Offset: 0x00760730
		public static Offset<IUnLimitPlayerOperation> Pack(FlatBufferBuilder builder, IUnLimitPlayerOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUnLimitPlayerOperation>);
			}
			IUnLimitPlayerOperation.StartIUnLimitPlayerOperation(builder);
			return IUnLimitPlayerOperation.EndIUnLimitPlayerOperation(builder);
		}

		// Token: 0x04012387 RID: 74631
		private Table __p;
	}
}
