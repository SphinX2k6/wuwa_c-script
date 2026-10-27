using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CA1 RID: 3233
	public struct FloroRanchBuff : IFlatbufferObject
	{
		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06007272 RID: 29298 RVA: 0x00238E10 File Offset: 0x00237010
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x00238E1D File Offset: 0x0023701D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x00238E24 File Offset: 0x00237024
		public static FloroRanchBuff GetRootAsFloroRanchBuff(ByteBuffer _bb)
		{
			return FloroRanchBuff.GetRootAsFloroRanchBuff(_bb, default(FloroRanchBuff));
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x00238E40 File Offset: 0x00237040
		public static FloroRanchBuff GetRootAsFloroRanchBuff(ByteBuffer _bb, FloroRanchBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x00238E5D File Offset: 0x0023705D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007277 RID: 29303 RVA: 0x00238E6C File Offset: 0x0023706C
		public FloroRanchBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06007278 RID: 29304 RVA: 0x00238E7C File Offset: 0x0023707C
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

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06007279 RID: 29305 RVA: 0x00238EB8 File Offset: 0x002370B8
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

		// Token: 0x0600727A RID: 29306 RVA: 0x00238EEF File Offset: 0x002370EF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x00238EFE File Offset: 0x002370FE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600727C RID: 29308 RVA: 0x00238F18 File Offset: 0x00237118
		public int Time
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x0600727D RID: 29309 RVA: 0x00238F54 File Offset: 0x00237154
		public int Superposition
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

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600727E RID: 29310 RVA: 0x00238F94 File Offset: 0x00237194
		public bool RefreshTime
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x00238FD4 File Offset: 0x002371D4
		public bool FollowRemove
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x06007280 RID: 29312 RVA: 0x00239014 File Offset: 0x00237214
		public bool Caculagraph
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x00239054 File Offset: 0x00237254
		public bool IsShowOnTip
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x06007282 RID: 29314 RVA: 0x00239094 File Offset: 0x00237294
		public bool IsShowEffect
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x04004CFF RID: 19711
		private Table __p;
	}
}
