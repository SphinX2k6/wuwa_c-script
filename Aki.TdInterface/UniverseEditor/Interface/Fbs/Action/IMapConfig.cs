using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007193 RID: 29075
	public struct IMapConfig : IFlatbufferObject
	{
		// Token: 0x1700D4D3 RID: 54483
		// (get) Token: 0x060328BC RID: 207036 RVA: 0x006D4951 File Offset: 0x006D2B51
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060328BD RID: 207037 RVA: 0x006D495E File Offset: 0x006D2B5E
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x060328BE RID: 207038 RVA: 0x006D496D File Offset: 0x006D2B6D
		public IMapConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4D4 RID: 54484
		// (get) Token: 0x060328BF RID: 207039 RVA: 0x006D497D File Offset: 0x006D2B7D
		public bool ExpandAreaTerminal
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060328C0 RID: 207040 RVA: 0x006D499D File Offset: 0x006D2B9D
		public static Offset<IMapConfig> CreateIMapConfig(FlatBufferBuilder builder, bool ExpandAreaTerminal)
		{
			builder.Prep(1, 1);
			builder.PutBool(ExpandAreaTerminal);
			return new Offset<IMapConfig>(builder.Offset);
		}

		// Token: 0x060328C1 RID: 207041 RVA: 0x006D49BC File Offset: 0x006D2BBC
		public IMapConfigT UnPack()
		{
			IMapConfigT mapConfigT = new IMapConfigT();
			this.UnPackTo(mapConfigT);
			return mapConfigT;
		}

		// Token: 0x060328C2 RID: 207042 RVA: 0x006D49D7 File Offset: 0x006D2BD7
		public void UnPackTo(IMapConfigT _o)
		{
			_o.ExpandAreaTerminal = this.ExpandAreaTerminal;
		}

		// Token: 0x060328C3 RID: 207043 RVA: 0x006D49E8 File Offset: 0x006D2BE8
		public static Offset<IMapConfig> Pack(FlatBufferBuilder builder, IMapConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMapConfig>);
			}
			return IMapConfig.CreateIMapConfig(builder, _o.ExpandAreaTerminal);
		}

		// Token: 0x0401218D RID: 74125
		private Struct __p;
	}
}
