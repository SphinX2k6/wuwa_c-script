using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D8B RID: 3467
	public struct FloroRanchCurrency : IFlatbufferObject
	{
		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x00259684 File Offset: 0x00257884
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007922 RID: 31010 RVA: 0x00259691 File Offset: 0x00257891
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x00259698 File Offset: 0x00257898
		public static FloroRanchCurrency GetRootAsFloroRanchCurrency(ByteBuffer _bb)
		{
			return FloroRanchCurrency.GetRootAsFloroRanchCurrency(_bb, default(FloroRanchCurrency));
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x002596B4 File Offset: 0x002578B4
		public static FloroRanchCurrency GetRootAsFloroRanchCurrency(ByteBuffer _bb, FloroRanchCurrency obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007925 RID: 31013 RVA: 0x002596D1 File Offset: 0x002578D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007926 RID: 31014 RVA: 0x002596E0 File Offset: 0x002578E0
		public FloroRanchCurrency __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06007927 RID: 31015 RVA: 0x002596F0 File Offset: 0x002578F0
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

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06007928 RID: 31016 RVA: 0x0025972C File Offset: 0x0025792C
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

		// Token: 0x06007929 RID: 31017 RVA: 0x00259763 File Offset: 0x00257963
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x00259772 File Offset: 0x00257972
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x0600792B RID: 31019 RVA: 0x0025978C File Offset: 0x0025798C
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

		// Token: 0x0600792C RID: 31020 RVA: 0x002597C3 File Offset: 0x002579C3
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x002597D2 File Offset: 0x002579D2
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x002597EC File Offset: 0x002579EC
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

		// Token: 0x0600792F RID: 31023 RVA: 0x00259824 File Offset: 0x00257A24
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x00259834 File Offset: 0x00257A34
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06007931 RID: 31025 RVA: 0x0025984C File Offset: 0x00257A4C
		public int RarityId
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

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06007932 RID: 31026 RVA: 0x0025988C File Offset: 0x00257A8C
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

		// Token: 0x06007933 RID: 31027 RVA: 0x002598C4 File Offset: 0x00257AC4
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x002598D4 File Offset: 0x00257AD4
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040052ED RID: 21229
		private Table __p;
	}
}
