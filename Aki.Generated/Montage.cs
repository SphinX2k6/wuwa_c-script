using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E1E RID: 3614
	public struct Montage : IFlatbufferObject
	{
		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06009599 RID: 38297 RVA: 0x00288AF1 File Offset: 0x00286CF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00288AFE File Offset: 0x00286CFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x00288B08 File Offset: 0x00286D08
		public static Montage GetRootAsMontage(ByteBuffer _bb)
		{
			return Montage.GetRootAsMontage(_bb, default(Montage));
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x00288B24 File Offset: 0x00286D24
		public static Montage GetRootAsMontage(ByteBuffer _bb, Montage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x00288B41 File Offset: 0x00286D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x00288B50 File Offset: 0x00286D50
		public Montage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001FA3 RID: 8099
		// (get) Token: 0x0600959F RID: 38303 RVA: 0x00288B60 File Offset: 0x00286D60
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

		// Token: 0x17001FA4 RID: 8100
		// (get) Token: 0x060095A0 RID: 38304 RVA: 0x00288B9C File Offset: 0x00286D9C
		public int MontageId
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

		// Token: 0x17001FA5 RID: 8101
		// (get) Token: 0x060095A1 RID: 38305 RVA: 0x00288BD8 File Offset: 0x00286DD8
		public int StartTime
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

		// Token: 0x17001FA6 RID: 8102
		// (get) Token: 0x060095A2 RID: 38306 RVA: 0x00288C14 File Offset: 0x00286E14
		public int EndTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FA7 RID: 8103
		// (get) Token: 0x060095A3 RID: 38307 RVA: 0x00288C54 File Offset: 0x00286E54
		public int Type
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001FA8 RID: 8104
		// (get) Token: 0x060095A4 RID: 38308 RVA: 0x00288C94 File Offset: 0x00286E94
		public string Params
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x00288CCC File Offset: 0x00286ECC
		public Span<byte> GetParamsBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x00288CDC File Offset: 0x00286EDC
		public byte[] GetParamsArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EC3 RID: 20163
		private Table __p;
	}
}
