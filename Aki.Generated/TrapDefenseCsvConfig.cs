using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001295 RID: 4757
	public struct TrapDefenseCsvConfig : IFlatbufferObject
	{
		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x0600F0BF RID: 61631 RVA: 0x003631B1 File Offset: 0x003613B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F0C0 RID: 61632 RVA: 0x003631BE File Offset: 0x003613BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F0C1 RID: 61633 RVA: 0x003631C8 File Offset: 0x003613C8
		public static TrapDefenseCsvConfig GetRootAsTrapDefenseCsvConfig(ByteBuffer _bb)
		{
			return TrapDefenseCsvConfig.GetRootAsTrapDefenseCsvConfig(_bb, default(TrapDefenseCsvConfig));
		}

		// Token: 0x0600F0C2 RID: 61634 RVA: 0x003631E4 File Offset: 0x003613E4
		public static TrapDefenseCsvConfig GetRootAsTrapDefenseCsvConfig(ByteBuffer _bb, TrapDefenseCsvConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F0C3 RID: 61635 RVA: 0x00363201 File Offset: 0x00361401
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F0C4 RID: 61636 RVA: 0x00363210 File Offset: 0x00361410
		public TrapDefenseCsvConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x0600F0C5 RID: 61637 RVA: 0x00363220 File Offset: 0x00361420
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

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x0600F0C6 RID: 61638 RVA: 0x0036325C File Offset: 0x0036145C
		public string Batches
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600F0C7 RID: 61639 RVA: 0x00363293 File Offset: 0x00361493
		public Span<byte> GetBatchesBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F0C8 RID: 61640 RVA: 0x003632A2 File Offset: 0x003614A2
		public byte[] GetBatchesArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x040058E7 RID: 22759
		private Table __p;
	}
}
