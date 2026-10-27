using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DA RID: 4314
	public struct Speaker : IFlatbufferObject
	{
		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600D78A RID: 55178 RVA: 0x0031D389 File Offset: 0x0031B589
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D78B RID: 55179 RVA: 0x0031D396 File Offset: 0x0031B596
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D78C RID: 55180 RVA: 0x0031D3A0 File Offset: 0x0031B5A0
		public static Speaker GetRootAsSpeaker(ByteBuffer _bb)
		{
			return Speaker.GetRootAsSpeaker(_bb, default(Speaker));
		}

		// Token: 0x0600D78D RID: 55181 RVA: 0x0031D3BC File Offset: 0x0031B5BC
		public static Speaker GetRootAsSpeaker(ByteBuffer _bb, Speaker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D78E RID: 55182 RVA: 0x0031D3D9 File Offset: 0x0031B5D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D78F RID: 55183 RVA: 0x0031D3E8 File Offset: 0x0031B5E8
		public Speaker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600D790 RID: 55184 RVA: 0x0031D3F8 File Offset: 0x0031B5F8
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600D791 RID: 55185 RVA: 0x0031D434 File Offset: 0x0031B634
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

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600D792 RID: 55186 RVA: 0x0031D470 File Offset: 0x0031B670
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

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600D793 RID: 55187 RVA: 0x0031D4AC File Offset: 0x0031B6AC
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

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600D794 RID: 55188 RVA: 0x0031D4EC File Offset: 0x0031B6EC
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

		// Token: 0x0600D795 RID: 55189 RVA: 0x0031D524 File Offset: 0x0031B724
		public Span<byte> GetCameraBindTagBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D796 RID: 55190 RVA: 0x0031D534 File Offset: 0x0031B734
		public byte[] GetCameraBindTagArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600D797 RID: 55191 RVA: 0x0031D54C File Offset: 0x0031B74C
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

		// Token: 0x0600D798 RID: 55192 RVA: 0x0031D584 File Offset: 0x0031B784
		public Span<byte> GetHeadIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D799 RID: 55193 RVA: 0x0031D594 File Offset: 0x0031B794
		public byte[] GetHeadIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600D79A RID: 55194 RVA: 0x0031D5AC File Offset: 0x0031B7AC
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

		// Token: 0x0600D79B RID: 55195 RVA: 0x0031D5E4 File Offset: 0x0031B7E4
		public Span<byte> GetHeadRoundIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x0031D5F4 File Offset: 0x0031B7F4
		public byte[] GetHeadRoundIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600D79D RID: 55197 RVA: 0x0031D60C File Offset: 0x0031B80C
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

		// Token: 0x0600D79E RID: 55198 RVA: 0x0031D644 File Offset: 0x0031B844
		public Span<byte> GetHeadRoundIconAssetMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D79F RID: 55199 RVA: 0x0031D654 File Offset: 0x0031B854
		public byte[] GetHeadRoundIconAssetMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600D7A0 RID: 55200 RVA: 0x0031D66C File Offset: 0x0031B86C
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

		// Token: 0x0600D7A1 RID: 55201 RVA: 0x0031D6A4 File Offset: 0x0031B8A4
		public Span<byte> GetRolePileIconAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600D7A2 RID: 55202 RVA: 0x0031D6B4 File Offset: 0x0031B8B4
		public byte[] GetRolePileIconAssetArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600D7A3 RID: 55203 RVA: 0x0031D6CC File Offset: 0x0031B8CC
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

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x0031D70C File Offset: 0x0031B90C
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

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x0031D74C File Offset: 0x0031B94C
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

		// Token: 0x0400520D RID: 21005
		private Table __p;
	}
}
