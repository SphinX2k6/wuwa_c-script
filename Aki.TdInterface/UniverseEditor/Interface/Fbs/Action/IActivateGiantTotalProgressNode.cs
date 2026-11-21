using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066F1 RID: 26353
	public struct IActivateGiantTotalProgressNode : IFlatbufferObject
	{
		// Token: 0x1700BF98 RID: 49048
		// (get) Token: 0x0602C9FA RID: 182778 RVA: 0x0061B6D8 File Offset: 0x006198D8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C9FB RID: 182779 RVA: 0x0061B6E5 File Offset: 0x006198E5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C9FC RID: 182780 RVA: 0x0061B6EC File Offset: 0x006198EC
		public static IActivateGiantTotalProgressNode GetRootAsIActivateGiantTotalProgressNode(ByteBuffer _bb)
		{
			return IActivateGiantTotalProgressNode.GetRootAsIActivateGiantTotalProgressNode(_bb, default(IActivateGiantTotalProgressNode));
		}

		// Token: 0x0602C9FD RID: 182781 RVA: 0x0061B708 File Offset: 0x00619908
		public static IActivateGiantTotalProgressNode GetRootAsIActivateGiantTotalProgressNode(ByteBuffer _bb, IActivateGiantTotalProgressNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C9FE RID: 182782 RVA: 0x0061B725 File Offset: 0x00619925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C9FF RID: 182783 RVA: 0x0061B734 File Offset: 0x00619934
		public IActivateGiantTotalProgressNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602CA00 RID: 182784 RVA: 0x0061B744 File Offset: 0x00619944
		public static void StartIActivateGiantTotalProgressNode(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602CA01 RID: 182785 RVA: 0x0061B74D File Offset: 0x0061994D
		public static Offset<IActivateGiantTotalProgressNode> EndIActivateGiantTotalProgressNode(FlatBufferBuilder builder)
		{
			return new Offset<IActivateGiantTotalProgressNode>(builder.EndTable());
		}

		// Token: 0x0602CA02 RID: 182786 RVA: 0x0061B75C File Offset: 0x0061995C
		public IActivateGiantTotalProgressNodeT UnPack()
		{
			IActivateGiantTotalProgressNodeT activateGiantTotalProgressNodeT = new IActivateGiantTotalProgressNodeT();
			this.UnPackTo(activateGiantTotalProgressNodeT);
			return activateGiantTotalProgressNodeT;
		}

		// Token: 0x0602CA03 RID: 182787 RVA: 0x0061B777 File Offset: 0x00619977
		public void UnPackTo(IActivateGiantTotalProgressNodeT _o)
		{
		}

		// Token: 0x0602CA04 RID: 182788 RVA: 0x0061B77C File Offset: 0x0061997C
		public static Offset<IActivateGiantTotalProgressNode> Pack(FlatBufferBuilder builder, IActivateGiantTotalProgressNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActivateGiantTotalProgressNode>);
			}
			IActivateGiantTotalProgressNode.StartIActivateGiantTotalProgressNode(builder);
			return IActivateGiantTotalProgressNode.EndIActivateGiantTotalProgressNode(builder);
		}

		// Token: 0x0401122C RID: 70188
		private Table __p;
	}
}
