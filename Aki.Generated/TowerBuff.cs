using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200126C RID: 4716
	public struct TowerBuff : IFlatbufferObject
	{
		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600ECD6 RID: 60630 RVA: 0x0035A704 File Offset: 0x00358904
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ECD7 RID: 60631 RVA: 0x0035A711 File Offset: 0x00358911
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ECD8 RID: 60632 RVA: 0x0035A718 File Offset: 0x00358918
		public static TowerBuff GetRootAsTowerBuff(ByteBuffer _bb)
		{
			return TowerBuff.GetRootAsTowerBuff(_bb, default(TowerBuff));
		}

		// Token: 0x0600ECD9 RID: 60633 RVA: 0x0035A734 File Offset: 0x00358934
		public static TowerBuff GetRootAsTowerBuff(ByteBuffer _bb, TowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ECDA RID: 60634 RVA: 0x0035A751 File Offset: 0x00358951
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ECDB RID: 60635 RVA: 0x0035A760 File Offset: 0x00358960
		public TowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x0600ECDC RID: 60636 RVA: 0x0035A770 File Offset: 0x00358970
		public long Id
		{
			get
			{
				int num = this.__p.__offset(4);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600ECDD RID: 60637 RVA: 0x0035A7B8 File Offset: 0x003589B8
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

		// Token: 0x0600ECDE RID: 60638 RVA: 0x0035A7EF File Offset: 0x003589EF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600ECDF RID: 60639 RVA: 0x0035A7FE File Offset: 0x003589FE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600ECE0 RID: 60640 RVA: 0x0035A818 File Offset: 0x00358A18
		public string Desc
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

		// Token: 0x0600ECE1 RID: 60641 RVA: 0x0035A84F File Offset: 0x00358A4F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x0035A85E File Offset: 0x00358A5E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x0600ECE3 RID: 60643 RVA: 0x0035A878 File Offset: 0x00358A78
		public string Icon
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

		// Token: 0x0600ECE4 RID: 60644 RVA: 0x0035A8B0 File Offset: 0x00358AB0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600ECE5 RID: 60645 RVA: 0x0035A8C0 File Offset: 0x00358AC0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x040058BA RID: 22714
		private Table __p;
	}
}
