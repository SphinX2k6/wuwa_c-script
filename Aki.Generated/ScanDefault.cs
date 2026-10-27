using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200108C RID: 4236
	public struct ScanDefault : IFlatbufferObject
	{
		// Token: 0x170034E8 RID: 13544
		// (get) Token: 0x0600CF8D RID: 53133 RVA: 0x00309F09 File Offset: 0x00308109
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x00309F16 File Offset: 0x00308116
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x00309F20 File Offset: 0x00308120
		public static ScanDefault GetRootAsScanDefault(ByteBuffer _bb)
		{
			return ScanDefault.GetRootAsScanDefault(_bb, default(ScanDefault));
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x00309F3C File Offset: 0x0030813C
		public static ScanDefault GetRootAsScanDefault(ByteBuffer _bb, ScanDefault obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CF91 RID: 53137 RVA: 0x00309F59 File Offset: 0x00308159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CF92 RID: 53138 RVA: 0x00309F68 File Offset: 0x00308168
		public ScanDefault __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034E9 RID: 13545
		// (get) Token: 0x0600CF93 RID: 53139 RVA: 0x00309F78 File Offset: 0x00308178
		public int UId
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

		// Token: 0x170034EA RID: 13546
		// (get) Token: 0x0600CF94 RID: 53140 RVA: 0x00309FB4 File Offset: 0x003081B4
		public string EntityType
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

		// Token: 0x0600CF95 RID: 53141 RVA: 0x00309FEB File Offset: 0x003081EB
		public Span<byte> GetEntityTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x00309FFA File Offset: 0x003081FA
		public byte[] GetEntityTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170034EB RID: 13547
		// (get) Token: 0x0600CF97 RID: 53143 RVA: 0x0030A014 File Offset: 0x00308214
		public int ScanId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005199 RID: 20889
		private Table __p;
	}
}
