using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A71 RID: 27249
	public struct IMapConfig : IFlatbufferObject
	{
		// Token: 0x1700CA28 RID: 51752
		// (get) Token: 0x0602FB96 RID: 195478 RVA: 0x0067E891 File Offset: 0x0067CA91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FB97 RID: 195479 RVA: 0x0067E89E File Offset: 0x0067CA9E
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Struct(_i, _bb);
		}

		// Token: 0x0602FB98 RID: 195480 RVA: 0x0067E8AD File Offset: 0x0067CAAD
		public IMapConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA29 RID: 51753
		// (get) Token: 0x0602FB99 RID: 195481 RVA: 0x0067E8BD File Offset: 0x0067CABD
		public bool ExpandAreaTerminal
		{
			get
			{
				return this.__p.bb.Get(this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FB9A RID: 195482 RVA: 0x0067E8DD File Offset: 0x0067CADD
		public static Offset<IMapConfig> CreateIMapConfig(FlatBufferBuilder builder, bool ExpandAreaTerminal)
		{
			builder.Prep(1, 1);
			builder.PutBool(ExpandAreaTerminal);
			return new Offset<IMapConfig>(builder.Offset);
		}

		// Token: 0x0602FB9B RID: 195483 RVA: 0x0067E8FC File Offset: 0x0067CAFC
		public IMapConfigT UnPack()
		{
			IMapConfigT mapConfigT = new IMapConfigT();
			this.UnPackTo(mapConfigT);
			return mapConfigT;
		}

		// Token: 0x0602FB9C RID: 195484 RVA: 0x0067E917 File Offset: 0x0067CB17
		public void UnPackTo(IMapConfigT _o)
		{
			_o.ExpandAreaTerminal = this.ExpandAreaTerminal;
		}

		// Token: 0x0602FB9D RID: 195485 RVA: 0x0067E928 File Offset: 0x0067CB28
		public static Offset<IMapConfig> Pack(FlatBufferBuilder builder, IMapConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMapConfig>);
			}
			return IMapConfig.CreateIMapConfig(builder, _o.ExpandAreaTerminal);
		}

		// Token: 0x04011295 RID: 70293
		private Struct __p;
	}
}
