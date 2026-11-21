using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF9 RID: 4089
	public struct PhotoMontage : IFlatbufferObject
	{
		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600B2F7 RID: 45815 RVA: 0x002D9933 File Offset: 0x002D7B33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x002D9940 File Offset: 0x002D7B40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x002D9948 File Offset: 0x002D7B48
		public static PhotoMontage GetRootAsPhotoMontage(ByteBuffer _bb)
		{
			return PhotoMontage.GetRootAsPhotoMontage(_bb, default(PhotoMontage));
		}

		// Token: 0x0600B2FA RID: 45818 RVA: 0x002D9964 File Offset: 0x002D7B64
		public static PhotoMontage GetRootAsPhotoMontage(ByteBuffer _bb, PhotoMontage obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x002D9981 File Offset: 0x002D7B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x002D9990 File Offset: 0x002D7B90
		public PhotoMontage __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600B2FD RID: 45821 RVA: 0x002D99A0 File Offset: 0x002D7BA0
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

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x002D99DC File Offset: 0x002D7BDC
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

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x0600B2FF RID: 45823 RVA: 0x002D9A18 File Offset: 0x002D7C18
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

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x002D9A54 File Offset: 0x002D7C54
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

		// Token: 0x170028C9 RID: 10441
		// (get) Token: 0x0600B301 RID: 45825 RVA: 0x002D9A94 File Offset: 0x002D7C94
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

		// Token: 0x170028CA RID: 10442
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x002D9AD4 File Offset: 0x002D7CD4
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

		// Token: 0x170028CB RID: 10443
		// (get) Token: 0x0600B303 RID: 45827 RVA: 0x002D9B14 File Offset: 0x002D7D14
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

		// Token: 0x0600B304 RID: 45828 RVA: 0x002D9B4C File Offset: 0x002D7D4C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x002D9B5C File Offset: 0x002D7D5C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170028CC RID: 10444
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x002D9B74 File Offset: 0x002D7D74
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(18);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x002D9BB4 File Offset: 0x002D7DB4
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

		// Token: 0x0600B308 RID: 45832 RVA: 0x002D9BEC File Offset: 0x002D7DEC
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x002D9BFC File Offset: 0x002D7DFC
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170028CE RID: 10446
		// (get) Token: 0x0600B30A RID: 45834 RVA: 0x002D9C14 File Offset: 0x002D7E14
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

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x0600B30B RID: 45835 RVA: 0x002D9C54 File Offset: 0x002D7E54
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

		// Token: 0x170028D0 RID: 10448
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x002D9C94 File Offset: 0x002D7E94
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

		// Token: 0x170028D1 RID: 10449
		// (get) Token: 0x0600B30D RID: 45837 RVA: 0x002D9CD4 File Offset: 0x002D7ED4
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

		// Token: 0x0600B30E RID: 45838 RVA: 0x002D9D0C File Offset: 0x002D7F0C
		public Span<byte> GetConditionTipsIdBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x002D9D1C File Offset: 0x002D7F1C
		public byte[] GetConditionTipsIdArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x040055C1 RID: 21953
		private Table __p;
	}
}
