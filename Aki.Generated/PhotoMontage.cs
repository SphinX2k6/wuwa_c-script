using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F14 RID: 3860
	public struct PhotoMontage : IFlatbufferObject
	{
		// Token: 0x1700285E RID: 10334
		// (get) Token: 0x0600ACD6 RID: 44246 RVA: 0x002BCD19 File Offset: 0x002BAF19
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x002BCD26 File Offset: 0x002BAF26
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x002BCD30 File Offset: 0x002BAF30
		public static PhotoMontage GetRootAsPhotoMontage(ByteBuffer _bb)
		{
			return PhotoMontage.GetRootAsPhotoMontage(_bb, default(PhotoMontage));
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x002BCD4C File Offset: 0x002BAF4C
		public static PhotoMontage GetRootAsPhotoMontage(ByteBuffer _bb, PhotoMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x002BCD69 File Offset: 0x002BAF69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x002BCD78 File Offset: 0x002BAF78
		public PhotoMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700285F RID: 10335
		// (get) Token: 0x0600ACDC RID: 44252 RVA: 0x002BCD88 File Offset: 0x002BAF88
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

		// Token: 0x17002860 RID: 10336
		// (get) Token: 0x0600ACDD RID: 44253 RVA: 0x002BCDC4 File Offset: 0x002BAFC4
		public int RoleId
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

		// Token: 0x17002861 RID: 10337
		// (get) Token: 0x0600ACDE RID: 44254 RVA: 0x002BCE00 File Offset: 0x002BB000
		public int SkinId
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

		// Token: 0x17002862 RID: 10338
		// (get) Token: 0x0600ACDF RID: 44255 RVA: 0x002BCE3C File Offset: 0x002BB03C
		public int Sort
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

		// Token: 0x17002863 RID: 10339
		// (get) Token: 0x0600ACE0 RID: 44256 RVA: 0x002BCE7C File Offset: 0x002BB07C
		public int Morph
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

		// Token: 0x17002864 RID: 10340
		// (get) Token: 0x0600ACE1 RID: 44257 RVA: 0x002BCEBC File Offset: 0x002BB0BC
		public int MainAnimInstanceType
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

		// Token: 0x17002865 RID: 10341
		// (get) Token: 0x0600ACE2 RID: 44258 RVA: 0x002BCEFC File Offset: 0x002BB0FC
		public string Name
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x002BCF34 File Offset: 0x002BB134
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x002BCF44 File Offset: 0x002BB144
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17002866 RID: 10342
		// (get) Token: 0x0600ACE5 RID: 44261 RVA: 0x002BCF5C File Offset: 0x002BB15C
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002867 RID: 10343
		// (get) Token: 0x0600ACE6 RID: 44262 RVA: 0x002BCF9C File Offset: 0x002BB19C
		public string MontagePath
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x002BCFD4 File Offset: 0x002BB1D4
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x002BCFE4 File Offset: 0x002BB1E4
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002868 RID: 10344
		// (get) Token: 0x0600ACE9 RID: 44265 RVA: 0x002BCFFC File Offset: 0x002BB1FC
		public int IconType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002869 RID: 10345
		// (get) Token: 0x0600ACEA RID: 44266 RVA: 0x002BD03C File Offset: 0x002BB23C
		public int MotionType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700286A RID: 10346
		// (get) Token: 0x0600ACEB RID: 44267 RVA: 0x002BD07C File Offset: 0x002BB27C
		public int UnLockConditionGroup
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700286B RID: 10347
		// (get) Token: 0x0600ACEC RID: 44268 RVA: 0x002BD0BC File Offset: 0x002BB2BC
		public string ConditionTipsId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x002BD0F4 File Offset: 0x002BB2F4
		public Span<byte> GetConditionTipsIdBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x002BD104 File Offset: 0x002BB304
		public byte[] GetConditionTipsIdArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x04004FDC RID: 20444
		private Table __p;
	}
}
