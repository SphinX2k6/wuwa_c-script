using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001070 RID: 4208
	public struct RacingBetsBulletScreen : IFlatbufferObject
	{
		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x0600BE35 RID: 48693 RVA: 0x002F193C File Offset: 0x002EFB3C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BE36 RID: 48694 RVA: 0x002F1949 File Offset: 0x002EFB49
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x002F1950 File Offset: 0x002EFB50
		public static RacingBetsBulletScreen GetRootAsRacingBetsBulletScreen(ByteBuffer _bb)
		{
			return RacingBetsBulletScreen.GetRootAsRacingBetsBulletScreen(_bb, default(RacingBetsBulletScreen));
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x002F196C File Offset: 0x002EFB6C
		public static RacingBetsBulletScreen GetRootAsRacingBetsBulletScreen(ByteBuffer _bb, RacingBetsBulletScreen obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x002F1989 File Offset: 0x002EFB89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x002F1998 File Offset: 0x002EFB98
		public RacingBetsBulletScreen __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x0600BE3B RID: 48699 RVA: 0x002F19A8 File Offset: 0x002EFBA8
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

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x0600BE3C RID: 48700 RVA: 0x002F19E4 File Offset: 0x002EFBE4
		public int SeasonId
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

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x0600BE3D RID: 48701 RVA: 0x002F1A20 File Offset: 0x002EFC20
		public int Type
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

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0600BE3E RID: 48702 RVA: 0x002F1A5C File Offset: 0x002EFC5C
		public int DangoId
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

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0600BE3F RID: 48703 RVA: 0x002F1A9C File Offset: 0x002EFC9C
		public string Icon
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

		// Token: 0x0600BE40 RID: 48704 RVA: 0x002F1AD4 File Offset: 0x002EFCD4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x002F1AE4 File Offset: 0x002EFCE4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600BE42 RID: 48706 RVA: 0x002F1AFC File Offset: 0x002EFCFC
		public string Name
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

		// Token: 0x0600BE43 RID: 48707 RVA: 0x002F1B34 File Offset: 0x002EFD34
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x002F1B44 File Offset: 0x002EFD44
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0400563F RID: 22079
		private Table __p;
	}
}
