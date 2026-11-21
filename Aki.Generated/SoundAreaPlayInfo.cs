using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200120E RID: 4622
	public struct SoundAreaPlayInfo : IFlatbufferObject
	{
		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x0034849D File Offset: 0x0034669D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x003484AA File Offset: 0x003466AA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x003484B4 File Offset: 0x003466B4
		public static SoundAreaPlayInfo GetRootAsSoundAreaPlayInfo(ByteBuffer _bb)
		{
			return SoundAreaPlayInfo.GetRootAsSoundAreaPlayInfo(_bb, default(SoundAreaPlayInfo));
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x003484D0 File Offset: 0x003466D0
		public static SoundAreaPlayInfo GetRootAsSoundAreaPlayInfo(ByteBuffer _bb, SoundAreaPlayInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x003484ED File Offset: 0x003466ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4B1 RID: 58545 RVA: 0x003484FC File Offset: 0x003466FC
		public SoundAreaPlayInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0600E4B2 RID: 58546 RVA: 0x0034850C File Offset: 0x0034670C
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

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0600E4B3 RID: 58547 RVA: 0x00348548 File Offset: 0x00346748
		public string BuffTitle
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

		// Token: 0x0600E4B4 RID: 58548 RVA: 0x0034857F File Offset: 0x0034677F
		public Span<byte> GetBuffTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E4B5 RID: 58549 RVA: 0x0034858E File Offset: 0x0034678E
		public byte[] GetBuffTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x003485A8 File Offset: 0x003467A8
		public int MaxCountType
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

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x003485E4 File Offset: 0x003467E4
		public string BuffDescription
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

		// Token: 0x0600E4B8 RID: 58552 RVA: 0x0034861C File Offset: 0x0034681C
		public Span<byte> GetBuffDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E4B9 RID: 58553 RVA: 0x0034862C File Offset: 0x0034682C
		public byte[] GetBuffDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x00348644 File Offset: 0x00346844
		public bool ShowTitle
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x00348684 File Offset: 0x00346884
		public int Time
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 3;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0600E4BC RID: 58556 RVA: 0x003486C4 File Offset: 0x003468C4
		public int MaxCount
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

		// Token: 0x0400584E RID: 22606
		private Table __p;
	}
}
