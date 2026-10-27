using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F43 RID: 3907
	public struct PlatformIcon : IFlatbufferObject
	{
		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x0600B14B RID: 45387 RVA: 0x002C72B8 File Offset: 0x002C54B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B14C RID: 45388 RVA: 0x002C72C5 File Offset: 0x002C54C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B14D RID: 45389 RVA: 0x002C72CC File Offset: 0x002C54CC
		public static PlatformIcon GetRootAsPlatformIcon(ByteBuffer _bb)
		{
			return PlatformIcon.GetRootAsPlatformIcon(_bb, default(PlatformIcon));
		}

		// Token: 0x0600B14E RID: 45390 RVA: 0x002C72E8 File Offset: 0x002C54E8
		public static PlatformIcon GetRootAsPlatformIcon(ByteBuffer _bb, PlatformIcon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B14F RID: 45391 RVA: 0x002C7305 File Offset: 0x002C5505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B150 RID: 45392 RVA: 0x002C7314 File Offset: 0x002C5514
		public PlatformIcon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x0600B151 RID: 45393 RVA: 0x002C7324 File Offset: 0x002C5524
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

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x0600B152 RID: 45394 RVA: 0x002C7360 File Offset: 0x002C5560
		public string IconName
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

		// Token: 0x0600B153 RID: 45395 RVA: 0x002C7397 File Offset: 0x002C5597
		public Span<byte> GetIconNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B154 RID: 45396 RVA: 0x002C73A6 File Offset: 0x002C55A6
		public byte[] GetIconNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x0600B155 RID: 45397 RVA: 0x002C73C0 File Offset: 0x002C55C0
		public string IconPath
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

		// Token: 0x0600B156 RID: 45398 RVA: 0x002C73F7 File Offset: 0x002C55F7
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x002C7406 File Offset: 0x002C5606
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x0600B158 RID: 45400 RVA: 0x002C7420 File Offset: 0x002C5620
		public string MobileIconPath
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

		// Token: 0x0600B159 RID: 45401 RVA: 0x002C7458 File Offset: 0x002C5658
		public Span<byte> GetMobileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B15A RID: 45402 RVA: 0x002C7468 File Offset: 0x002C5668
		public byte[] GetMobileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005010 RID: 20496
		private Table __p;
	}
}
