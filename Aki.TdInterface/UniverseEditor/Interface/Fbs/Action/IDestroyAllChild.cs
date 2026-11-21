using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE7 RID: 27623
	public struct IDestroyAllChild : IFlatbufferObject
	{
		// Token: 0x1700CA95 RID: 51861
		// (get) Token: 0x0602F8AE RID: 194734 RVA: 0x0067B2B2 File Offset: 0x006794B2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8AF RID: 194735 RVA: 0x0067B2BF File Offset: 0x006794BF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8B0 RID: 194736 RVA: 0x0067B2C8 File Offset: 0x006794C8
		public static IDestroyAllChild GetRootAsIDestroyAllChild(ByteBuffer _bb)
		{
			return IDestroyAllChild.GetRootAsIDestroyAllChild(_bb, default(IDestroyAllChild));
		}

		// Token: 0x0602F8B1 RID: 194737 RVA: 0x0067B2E4 File Offset: 0x006794E4
		public static IDestroyAllChild GetRootAsIDestroyAllChild(ByteBuffer _bb, IDestroyAllChild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8B2 RID: 194738 RVA: 0x0067B301 File Offset: 0x00679501
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8B3 RID: 194739 RVA: 0x0067B310 File Offset: 0x00679510
		public IDestroyAllChild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602F8B4 RID: 194740 RVA: 0x0067B320 File Offset: 0x00679520
		public static void StartIDestroyAllChild(FlatBufferBuilder builder)
		{
			builder.StartTable(0);
		}

		// Token: 0x0602F8B5 RID: 194741 RVA: 0x0067B329 File Offset: 0x00679529
		public static Offset<IDestroyAllChild> EndIDestroyAllChild(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyAllChild>(builder.EndTable());
		}

		// Token: 0x0602F8B6 RID: 194742 RVA: 0x0067B338 File Offset: 0x00679538
		public IDestroyAllChildT UnPack()
		{
			IDestroyAllChildT destroyAllChildT = new IDestroyAllChildT();
			this.UnPackTo(destroyAllChildT);
			return destroyAllChildT;
		}

		// Token: 0x0602F8B7 RID: 194743 RVA: 0x0067B353 File Offset: 0x00679553
		public void UnPackTo(IDestroyAllChildT _o)
		{
		}

		// Token: 0x0602F8B8 RID: 194744 RVA: 0x0067B358 File Offset: 0x00679558
		public static Offset<IDestroyAllChild> Pack(FlatBufferBuilder builder, IDestroyAllChildT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyAllChild>);
			}
			IDestroyAllChild.StartIDestroyAllChild(builder);
			return IDestroyAllChild.EndIDestroyAllChild(builder);
		}

		// Token: 0x040119EB RID: 72171
		private Table __p;
	}
}
