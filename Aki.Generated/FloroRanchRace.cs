using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CAC RID: 3244
	public struct FloroRanchRace : IFlatbufferObject
	{
		// Token: 0x170012FD RID: 4861
		// (get) Token: 0x06007381 RID: 29569 RVA: 0x0023B739 File Offset: 0x00239939
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x0023B746 File Offset: 0x00239946
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x0023B750 File Offset: 0x00239950
		public static FloroRanchRace GetRootAsFloroRanchRace(ByteBuffer _bb)
		{
			return FloroRanchRace.GetRootAsFloroRanchRace(_bb, default(FloroRanchRace));
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x0023B76C File Offset: 0x0023996C
		public static FloroRanchRace GetRootAsFloroRanchRace(ByteBuffer _bb, FloroRanchRace obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0023B789 File Offset: 0x00239989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x0023B798 File Offset: 0x00239998
		public FloroRanchRace __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x06007387 RID: 29575 RVA: 0x0023B7A8 File Offset: 0x002399A8
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06007388 RID: 29576 RVA: 0x0023B7E4 File Offset: 0x002399E4
		public string Name
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

		// Token: 0x06007389 RID: 29577 RVA: 0x0023B81B File Offset: 0x00239A1B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x0023B82A File Offset: 0x00239A2A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x0600738B RID: 29579 RVA: 0x0023B844 File Offset: 0x00239A44
		public string Icon
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

		// Token: 0x0600738C RID: 29580 RVA: 0x0023B87B File Offset: 0x00239A7B
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x0023B88A File Offset: 0x00239A8A
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x0600738E RID: 29582 RVA: 0x0023B8A4 File Offset: 0x00239AA4
		public string Description
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x0023B8DC File Offset: 0x00239ADC
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x0023B8EC File Offset: 0x00239AEC
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06007391 RID: 29585 RVA: 0x0023B904 File Offset: 0x00239B04
		public bool IsCommon
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06007392 RID: 29586 RVA: 0x0023B944 File Offset: 0x00239B44
		public string SmallIcon
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

		// Token: 0x06007393 RID: 29587 RVA: 0x0023B97C File Offset: 0x00239B7C
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x0023B98C File Offset: 0x00239B8C
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D10 RID: 19728
		private Table __p;
	}
}
