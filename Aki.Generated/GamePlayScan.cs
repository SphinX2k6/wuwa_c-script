using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DD1 RID: 3537
	public struct GamePlayScan : IFlatbufferObject
	{
		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06007F5F RID: 32607 RVA: 0x002674AD File Offset: 0x002656AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x002674BA File Offset: 0x002656BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x002674C4 File Offset: 0x002656C4
		public static GamePlayScan GetRootAsGamePlayScan(ByteBuffer _bb)
		{
			return GamePlayScan.GetRootAsGamePlayScan(_bb, default(GamePlayScan));
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x002674E0 File Offset: 0x002656E0
		public static GamePlayScan GetRootAsGamePlayScan(ByteBuffer _bb, GamePlayScan obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x002674FD File Offset: 0x002656FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x0026750C File Offset: 0x0026570C
		public GamePlayScan __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x0026751C File Offset: 0x0026571C
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

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06007F66 RID: 32614 RVA: 0x00267558 File Offset: 0x00265758
		public string IconPath
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

		// Token: 0x06007F67 RID: 32615 RVA: 0x0026758F File Offset: 0x0026578F
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x0026759E File Offset: 0x0026579E
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x002675B8 File Offset: 0x002657B8
		public float Interval
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06007F6A RID: 32618 RVA: 0x002675F8 File Offset: 0x002657F8
		public Vector? Offset
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new Vector?(default(Vector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06007F6B RID: 32619 RVA: 0x00267658 File Offset: 0x00265858
		public string ResourcePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x00267690 File Offset: 0x00265890
		public Span<byte> GetResourcePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x002676A0 File Offset: 0x002658A0
		public byte[] GetResourcePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x002676B8 File Offset: 0x002658B8
		public int Color
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005342 RID: 21314
		private Table __p;
	}
}
