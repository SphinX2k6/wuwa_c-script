using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200657F RID: 25983
	public struct IDestroyAllChild : IFlatbufferObject
	{
		// Token: 0x1700C106 RID: 49414
		// (get) Token: 0x0602D12A RID: 184618 RVA: 0x0062F0EE File Offset: 0x0062D2EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D12B RID: 184619 RVA: 0x0062F0FB File Offset: 0x0062D2FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D12C RID: 184620 RVA: 0x0062F104 File Offset: 0x0062D304
		public static IDestroyAllChild GetRootAsIDestroyAllChild(ByteBuffer _bb)
		{
			return IDestroyAllChild.GetRootAsIDestroyAllChild(_bb, default(IDestroyAllChild));
		}

		// Token: 0x0602D12D RID: 184621 RVA: 0x0062F120 File Offset: 0x0062D320
		public static IDestroyAllChild GetRootAsIDestroyAllChild(ByteBuffer _bb, IDestroyAllChild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D12E RID: 184622 RVA: 0x0062F13D File Offset: 0x0062D33D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D12F RID: 184623 RVA: 0x0062F14C File Offset: 0x0062D34C
		public IDestroyAllChild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602D130 RID: 184624 RVA: 0x0062F15C File Offset: 0x0062D35C
		public static void StartIDestroyAllChild(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602D131 RID: 184625 RVA: 0x0062F165 File Offset: 0x0062D365
		public static Offset<IDestroyAllChild> EndIDestroyAllChild(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyAllChild>(builder.EndTable());
		}

		// Token: 0x0602D132 RID: 184626 RVA: 0x0062F174 File Offset: 0x0062D374
		public IDestroyAllChildT UnPack()
		{
			IDestroyAllChildT destroyAllChildT = new IDestroyAllChildT();
			this.UnPackTo(destroyAllChildT);
			return destroyAllChildT;
		}

		// Token: 0x0602D133 RID: 184627 RVA: 0x0062F18F File Offset: 0x0062D38F
		public void UnPackTo(IDestroyAllChildT _o)
		{
		}

		// Token: 0x0602D134 RID: 184628 RVA: 0x0062F194 File Offset: 0x0062D394
		public static Offset<IDestroyAllChild> Pack(FlatBufferBuilder builder, IDestroyAllChildT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyAllChild>);
			}
			IDestroyAllChild.StartIDestroyAllChild(builder);
			return IDestroyAllChild.EndIDestroyAllChild(builder);
		}

		// Token: 0x04010BD9 RID: 68569
		private Table __p;
	}
}
