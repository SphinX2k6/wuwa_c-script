using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B75 RID: 2933
	public struct CiacconaActivityReward : IFlatbufferObject
	{
		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06005505 RID: 21765 RVA: 0x001F4EF9 File Offset: 0x001F30F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x001F4F06 File Offset: 0x001F3106
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x001F4F10 File Offset: 0x001F3110
		public static CiacconaActivityReward GetRootAsCiacconaActivityReward(ByteBuffer _bb)
		{
			return CiacconaActivityReward.GetRootAsCiacconaActivityReward(_bb, default(CiacconaActivityReward));
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x001F4F2C File Offset: 0x001F312C
		public static CiacconaActivityReward GetRootAsCiacconaActivityReward(ByteBuffer _bb, CiacconaActivityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x001F4F49 File Offset: 0x001F3149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x001F4F58 File Offset: 0x001F3158
		public CiacconaActivityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x0600550B RID: 21771 RVA: 0x001F4F68 File Offset: 0x001F3168
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

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x0600550C RID: 21772 RVA: 0x001F4FA4 File Offset: 0x001F31A4
		public int ActivityId
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

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x0600550D RID: 21773 RVA: 0x001F4FE0 File Offset: 0x001F31E0
		public int CondGroupId
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

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600550E RID: 21774 RVA: 0x001F501C File Offset: 0x001F321C
		public int RewardId
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

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x0600550F RID: 21775 RVA: 0x001F505C File Offset: 0x001F325C
		public string Title
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

		// Token: 0x06005510 RID: 21776 RVA: 0x001F5094 File Offset: 0x001F3294
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x001F50A4 File Offset: 0x001F32A4
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06005512 RID: 21778 RVA: 0x001F50BC File Offset: 0x001F32BC
		public string Desc
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

		// Token: 0x06005513 RID: 21779 RVA: 0x001F50F4 File Offset: 0x001F32F4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x001F5104 File Offset: 0x001F3304
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B79 RID: 19321
		private Table __p;
	}
}
