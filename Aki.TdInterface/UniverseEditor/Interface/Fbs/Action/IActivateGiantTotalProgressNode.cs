using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200608F RID: 24719
	public struct IActivateGiantTotalProgressNode : IFlatbufferObject
	{
		// Token: 0x1700B62D RID: 46637
		// (get) Token: 0x0602A319 RID: 172825 RVA: 0x005D172D File Offset: 0x005CF92D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A31A RID: 172826 RVA: 0x005D173A File Offset: 0x005CF93A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A31B RID: 172827 RVA: 0x005D1744 File Offset: 0x005CF944
		public static IActivateGiantTotalProgressNode GetRootAsIActivateGiantTotalProgressNode(ByteBuffer _bb)
		{
			return IActivateGiantTotalProgressNode.GetRootAsIActivateGiantTotalProgressNode(_bb, default(IActivateGiantTotalProgressNode));
		}

		// Token: 0x0602A31C RID: 172828 RVA: 0x005D1760 File Offset: 0x005CF960
		public static IActivateGiantTotalProgressNode GetRootAsIActivateGiantTotalProgressNode(ByteBuffer _bb, IActivateGiantTotalProgressNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A31D RID: 172829 RVA: 0x005D177D File Offset: 0x005CF97D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A31E RID: 172830 RVA: 0x005D178C File Offset: 0x005CF98C
		public IActivateGiantTotalProgressNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602A31F RID: 172831 RVA: 0x005D179C File Offset: 0x005CF99C
		public static void StartIActivateGiantTotalProgressNode(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602A320 RID: 172832 RVA: 0x005D17A5 File Offset: 0x005CF9A5
		public static Offset<IActivateGiantTotalProgressNode> EndIActivateGiantTotalProgressNode(FlatBufferBuilder builder)
		{
			return new Offset<IActivateGiantTotalProgressNode>(builder.EndTable());
		}

		// Token: 0x0602A321 RID: 172833 RVA: 0x005D17B4 File Offset: 0x005CF9B4
		public IActivateGiantTotalProgressNodeT UnPack()
		{
			IActivateGiantTotalProgressNodeT activateGiantTotalProgressNodeT = new IActivateGiantTotalProgressNodeT();
			this.UnPackTo(activateGiantTotalProgressNodeT);
			return activateGiantTotalProgressNodeT;
		}

		// Token: 0x0602A322 RID: 172834 RVA: 0x005D17CF File Offset: 0x005CF9CF
		public void UnPackTo(IActivateGiantTotalProgressNodeT _o)
		{
		}

		// Token: 0x0602A323 RID: 172835 RVA: 0x005D17D4 File Offset: 0x005CF9D4
		public static Offset<IActivateGiantTotalProgressNode> Pack(FlatBufferBuilder builder, IActivateGiantTotalProgressNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateGiantTotalProgressNode>);
			}
			IActivateGiantTotalProgressNode.StartIActivateGiantTotalProgressNode(builder);
			return IActivateGiantTotalProgressNode.EndIActivateGiantTotalProgressNode(builder);
		}

		// Token: 0x04010428 RID: 66600
		private Table __p;
	}
}
