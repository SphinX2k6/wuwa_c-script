using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EAF RID: 3759
	public struct LineCrossChallenge : IFlatbufferObject
	{
		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06009431 RID: 37937 RVA: 0x00296064 File Offset: 0x00294264
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x00296071 File Offset: 0x00294271
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x00296078 File Offset: 0x00294278
		public static LineCrossChallenge GetRootAsLineCrossChallenge(ByteBuffer _bb)
		{
			return LineCrossChallenge.GetRootAsLineCrossChallenge(_bb, default(LineCrossChallenge));
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x00296094 File Offset: 0x00294294
		public static LineCrossChallenge GetRootAsLineCrossChallenge(ByteBuffer _bb, LineCrossChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x002960B1 File Offset: 0x002942B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x002960C0 File Offset: 0x002942C0
		public LineCrossChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06009437 RID: 37943 RVA: 0x002960D0 File Offset: 0x002942D0
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

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x0029610C File Offset: 0x0029430C
		public int GroupId
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

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06009439 RID: 37945 RVA: 0x00296148 File Offset: 0x00294348
		public int Difficulty
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

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x0600943A RID: 37946 RVA: 0x00296184 File Offset: 0x00294384
		public string SubTitle
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

		// Token: 0x0600943B RID: 37947 RVA: 0x002961BC File Offset: 0x002943BC
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x002961CC File Offset: 0x002943CC
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x0600943D RID: 37949 RVA: 0x002961E4 File Offset: 0x002943E4
		public string DifficultTexture
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

		// Token: 0x0600943E RID: 37950 RVA: 0x0029621C File Offset: 0x0029441C
		public Span<byte> GetDifficultTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600943F RID: 37951 RVA: 0x0029622C File Offset: 0x0029442C
		public byte[] GetDifficultTextureArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x00296244 File Offset: 0x00294444
		public int ActivityId
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

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06009441 RID: 37953 RVA: 0x00296284 File Offset: 0x00294484
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x002962C4 File Offset: 0x002944C4
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06009443 RID: 37955 RVA: 0x00296304 File Offset: 0x00294504
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06009444 RID: 37956 RVA: 0x00296344 File Offset: 0x00294544
		public string Name
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x0029637C File Offset: 0x0029457C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x0029638C File Offset: 0x0029458C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06009447 RID: 37959 RVA: 0x002963A4 File Offset: 0x002945A4
		public string DifficultDesc
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x002963DC File Offset: 0x002945DC
		public Span<byte> GetDifficultDescBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x002963EC File Offset: 0x002945EC
		public byte[] GetDifficultDescArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x0600944A RID: 37962 RVA: 0x00296404 File Offset: 0x00294604
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x0029643C File Offset: 0x0029463C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x0029644C File Offset: 0x0029464C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x04005445 RID: 21573
		private Table __p;
	}
}
