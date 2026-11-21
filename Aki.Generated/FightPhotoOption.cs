using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D4E RID: 3406
	public struct FightPhotoOption : IFlatbufferObject
	{
		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060073F2 RID: 29682 RVA: 0x0024CF24 File Offset: 0x0024B124
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x0024CF31 File Offset: 0x0024B131
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x0024CF38 File Offset: 0x0024B138
		public static FightPhotoOption GetRootAsFightPhotoOption(ByteBuffer _bb)
		{
			return FightPhotoOption.GetRootAsFightPhotoOption(_bb, default(FightPhotoOption));
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x0024CF54 File Offset: 0x0024B154
		public static FightPhotoOption GetRootAsFightPhotoOption(ByteBuffer _bb, FightPhotoOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x0024CF71 File Offset: 0x0024B171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x0024CF80 File Offset: 0x0024B180
		public FightPhotoOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060073F8 RID: 29688 RVA: 0x0024CF90 File Offset: 0x0024B190
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

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x060073F9 RID: 29689 RVA: 0x0024CFCC File Offset: 0x0024B1CC
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

		// Token: 0x060073FA RID: 29690 RVA: 0x0024D003 File Offset: 0x0024B203
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060073FB RID: 29691 RVA: 0x0024D012 File Offset: 0x0024B212
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x060073FC RID: 29692 RVA: 0x0024D02C File Offset: 0x0024B22C
		public string Picture
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

		// Token: 0x060073FD RID: 29693 RVA: 0x0024D063 File Offset: 0x0024B263
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060073FE RID: 29694 RVA: 0x0024D072 File Offset: 0x0024B272
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x060073FF RID: 29695 RVA: 0x0024D08C File Offset: 0x0024B28C
		public int FilterIndex
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

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06007400 RID: 29696 RVA: 0x0024D0CC File Offset: 0x0024B2CC
		public float FilterParamX
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x0024D110 File Offset: 0x0024B310
		public float FilterParamY
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x0024D154 File Offset: 0x0024B354
		public float FilterIntensity
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06007403 RID: 29699 RVA: 0x0024D198 File Offset: 0x0024B398
		public int DtTableId
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

		// Token: 0x04005299 RID: 21145
		private Table __p;
	}
}
