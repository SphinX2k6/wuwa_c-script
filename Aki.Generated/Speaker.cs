using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001210 RID: 4624
	public struct Speaker : IFlatbufferObject
	{
		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x003489FE File Offset: 0x00346BFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x00348A0B File Offset: 0x00346C0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x00348A14 File Offset: 0x00346C14
		public static Speaker GetRootAsSpeaker(ByteBuffer _bb)
		{
			return Speaker.GetRootAsSpeaker(_bb, default(Speaker));
		}

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x00348A30 File Offset: 0x00346C30
		public static Speaker GetRootAsSpeaker(ByteBuffer _bb, Speaker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x00348A4D File Offset: 0x00346C4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E4DA RID: 58586 RVA: 0x00348A5C File Offset: 0x00346C5C
		public Speaker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x00348A6C File Offset: 0x00346C6C
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

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x00348AA8 File Offset: 0x00346CA8
		public int NameStringKey
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

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600E4DD RID: 58589 RVA: 0x00348AE4 File Offset: 0x00346CE4
		public int TitleStringKey
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

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600E4DE RID: 58590 RVA: 0x00348B20 File Offset: 0x00346D20
		public int Name
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

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x00348B60 File Offset: 0x00346D60
		public string CameraBindTag
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

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x00348B98 File Offset: 0x00346D98
		public Span<byte> GetCameraBindTagBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E4E1 RID: 58593 RVA: 0x00348BA8 File Offset: 0x00346DA8
		public byte[] GetCameraBindTagArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x0600E4E2 RID: 58594 RVA: 0x00348BC0 File Offset: 0x00346DC0
		public string HeadIconAsset
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

		// Token: 0x0600E4E3 RID: 58595 RVA: 0x00348BF8 File Offset: 0x00346DF8
		public Span<byte> GetHeadIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E4E4 RID: 58596 RVA: 0x00348C08 File Offset: 0x00346E08
		public byte[] GetHeadIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x0600E4E5 RID: 58597 RVA: 0x00348C20 File Offset: 0x00346E20
		public string HeadRoundIconAsset
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

		// Token: 0x0600E4E6 RID: 58598 RVA: 0x00348C58 File Offset: 0x00346E58
		public Span<byte> GetHeadRoundIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600E4E7 RID: 58599 RVA: 0x00348C68 File Offset: 0x00346E68
		public byte[] GetHeadRoundIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x0600E4E8 RID: 58600 RVA: 0x00348C80 File Offset: 0x00346E80
		public string HeadRoundIconAssetMaleVariant
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E4E9 RID: 58601 RVA: 0x00348CB8 File Offset: 0x00346EB8
		public Span<byte> GetHeadRoundIconAssetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600E4EA RID: 58602 RVA: 0x00348CC8 File Offset: 0x00346EC8
		public byte[] GetHeadRoundIconAssetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x0600E4EB RID: 58603 RVA: 0x00348CE0 File Offset: 0x00346EE0
		public string RolePileIconAsset
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

		// Token: 0x0600E4EC RID: 58604 RVA: 0x00348D18 File Offset: 0x00346F18
		public Span<byte> GetRolePileIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x00348D28 File Offset: 0x00346F28
		public byte[] GetRolePileIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x0600E4EE RID: 58606 RVA: 0x00348D40 File Offset: 0x00346F40
		public int Title
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

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x0600E4EF RID: 58607 RVA: 0x00348D80 File Offset: 0x00346F80
		public int TimberId
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

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600E4F0 RID: 58608 RVA: 0x00348DC0 File Offset: 0x00346FC0
		public int AvgTalkerConfig
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

		// Token: 0x04005850 RID: 22608
		private Table __p;
	}
}
