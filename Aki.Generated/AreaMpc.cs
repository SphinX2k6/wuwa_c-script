using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B05 RID: 2821
	public struct AreaMpc : IFlatbufferObject
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060048AB RID: 18603 RVA: 0x001D7FF1 File Offset: 0x001D61F1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x001D7FFE File Offset: 0x001D61FE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x001D8008 File Offset: 0x001D6208
		public static AreaMpc GetRootAsAreaMpc(ByteBuffer _bb)
		{
			return AreaMpc.GetRootAsAreaMpc(_bb, default(AreaMpc));
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x001D8024 File Offset: 0x001D6224
		public static AreaMpc GetRootAsAreaMpc(ByteBuffer _bb, AreaMpc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x001D8041 File Offset: 0x001D6241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x001D8050 File Offset: 0x001D6250
		public AreaMpc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x001D8060 File Offset: 0x001D6260
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060048B2 RID: 18610 RVA: 0x001D809C File Offset: 0x001D629C
		public int RegionId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060048B3 RID: 18611 RVA: 0x001D80D8 File Offset: 0x001D62D8
		public string MpcData
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x001D810F File Offset: 0x001D630F
		public Span<byte> GetMpcDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x001D811E File Offset: 0x001D631E
		public byte[] GetMpcDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004AEA RID: 19178
		private Table __p;
	}
}
