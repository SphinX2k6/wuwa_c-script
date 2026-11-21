using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011F5 RID: 4597
	public struct SolarSchoolPopup : IFlatbufferObject
	{
		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0600E28E RID: 57998 RVA: 0x00343771 File Offset: 0x00341971
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E28F RID: 57999 RVA: 0x0034377E File Offset: 0x0034197E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E290 RID: 58000 RVA: 0x00343788 File Offset: 0x00341988
		public static SolarSchoolPopup GetRootAsSolarSchoolPopup(ByteBuffer _bb)
		{
			return SolarSchoolPopup.GetRootAsSolarSchoolPopup(_bb, default(SolarSchoolPopup));
		}

		// Token: 0x0600E291 RID: 58001 RVA: 0x003437A4 File Offset: 0x003419A4
		public static SolarSchoolPopup GetRootAsSolarSchoolPopup(ByteBuffer _bb, SolarSchoolPopup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E292 RID: 58002 RVA: 0x003437C1 File Offset: 0x003419C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E293 RID: 58003 RVA: 0x003437D0 File Offset: 0x003419D0
		public SolarSchoolPopup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x0600E294 RID: 58004 RVA: 0x003437E0 File Offset: 0x003419E0
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

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0600E295 RID: 58005 RVA: 0x0034381C File Offset: 0x00341A1C
		public string Title
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

		// Token: 0x0600E296 RID: 58006 RVA: 0x00343853 File Offset: 0x00341A53
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x00343862 File Offset: 0x00341A62
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0600E298 RID: 58008 RVA: 0x0034387C File Offset: 0x00341A7C
		public string SubTitle
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

		// Token: 0x0600E299 RID: 58009 RVA: 0x003438B3 File Offset: 0x00341AB3
		public Span<byte> GetSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E29A RID: 58010 RVA: 0x003438C2 File Offset: 0x00341AC2
		public byte[] GetSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600E29B RID: 58011 RVA: 0x003438DC File Offset: 0x00341ADC
		public int AnimStyle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005833 RID: 22579
		private Table __p;
	}
}
