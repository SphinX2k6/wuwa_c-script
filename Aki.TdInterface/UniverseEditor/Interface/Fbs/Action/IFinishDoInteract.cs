using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A4 RID: 26532
	public struct IFinishDoInteract : IFlatbufferObject
	{
		// Token: 0x1700C4F6 RID: 50422
		// (get) Token: 0x0602E2C5 RID: 189125 RVA: 0x0064E71A File Offset: 0x0064C91A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2C6 RID: 189126 RVA: 0x0064E727 File Offset: 0x0064C927
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2C7 RID: 189127 RVA: 0x0064E730 File Offset: 0x0064C930
		public static IFinishDoInteract GetRootAsIFinishDoInteract(ByteBuffer _bb)
		{
			return IFinishDoInteract.GetRootAsIFinishDoInteract(_bb, default(IFinishDoInteract));
		}

		// Token: 0x0602E2C8 RID: 189128 RVA: 0x0064E74C File Offset: 0x0064C94C
		public static IFinishDoInteract GetRootAsIFinishDoInteract(ByteBuffer _bb, IFinishDoInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2C9 RID: 189129 RVA: 0x0064E769 File Offset: 0x0064C969
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2CA RID: 189130 RVA: 0x0064E778 File Offset: 0x0064C978
		public IFinishDoInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602E2CB RID: 189131 RVA: 0x0064E788 File Offset: 0x0064C988
		public static void StartIFinishDoInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602E2CC RID: 189132 RVA: 0x0064E791 File Offset: 0x0064C991
		public static Offset<IFinishDoInteract> EndIFinishDoInteract(FlatBufferBuilder builder)
		{
			return new Offset<IFinishDoInteract>(builder.EndTable());
		}

		// Token: 0x0602E2CD RID: 189133 RVA: 0x0064E7A0 File Offset: 0x0064C9A0
		public IFinishDoInteractT UnPack()
		{
			IFinishDoInteractT finishDoInteractT = new IFinishDoInteractT();
			this.UnPackTo(finishDoInteractT);
			return finishDoInteractT;
		}

		// Token: 0x0602E2CE RID: 189134 RVA: 0x0064E7BB File Offset: 0x0064C9BB
		public void UnPackTo(IFinishDoInteractT _o)
		{
		}

		// Token: 0x0602E2CF RID: 189135 RVA: 0x0064E7C0 File Offset: 0x0064C9C0
		public static Offset<IFinishDoInteract> Pack(FlatBufferBuilder builder, IFinishDoInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFinishDoInteract>);
			}
			IFinishDoInteract.StartIFinishDoInteract(builder);
			return IFinishDoInteract.EndIFinishDoInteract(builder);
		}

		// Token: 0x04010EB5 RID: 69301
		private Table __p;
	}
}
