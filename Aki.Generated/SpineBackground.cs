using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001218 RID: 4632
	public struct SpineBackground : IFlatbufferObject
	{
		// Token: 0x17003B37 RID: 15159
		// (get) Token: 0x0600E55A RID: 58714 RVA: 0x00349B97 File Offset: 0x00347D97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E55B RID: 58715 RVA: 0x00349BA4 File Offset: 0x00347DA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E55C RID: 58716 RVA: 0x00349BAC File Offset: 0x00347DAC
		public static SpineBackground GetRootAsSpineBackground(ByteBuffer _bb)
		{
			return SpineBackground.GetRootAsSpineBackground(_bb, default(SpineBackground));
		}

		// Token: 0x0600E55D RID: 58717 RVA: 0x00349BC8 File Offset: 0x00347DC8
		public static SpineBackground GetRootAsSpineBackground(ByteBuffer _bb, SpineBackground obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E55E RID: 58718 RVA: 0x00349BE5 File Offset: 0x00347DE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E55F RID: 58719 RVA: 0x00349BF4 File Offset: 0x00347DF4
		public SpineBackground __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003B38 RID: 15160
		// (get) Token: 0x0600E560 RID: 58720 RVA: 0x00349C04 File Offset: 0x00347E04
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

		// Token: 0x17003B39 RID: 15161
		// (get) Token: 0x0600E561 RID: 58721 RVA: 0x00349C40 File Offset: 0x00347E40
		public string Remark
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

		// Token: 0x0600E562 RID: 58722 RVA: 0x00349C77 File Offset: 0x00347E77
		public Span<byte> GetRemarkBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600E563 RID: 58723 RVA: 0x00349C86 File Offset: 0x00347E86
		public byte[] GetRemarkArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600E564 RID: 58724 RVA: 0x00349CA0 File Offset: 0x00347EA0
		public string UiPrefabId
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

		// Token: 0x0600E565 RID: 58725 RVA: 0x00349CD7 File Offset: 0x00347ED7
		public Span<byte> GetUiPrefabIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600E566 RID: 58726 RVA: 0x00349CE6 File Offset: 0x00347EE6
		public byte[] GetUiPrefabIdArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600E567 RID: 58727 RVA: 0x00349D00 File Offset: 0x00347F00
		public string AnimationName
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

		// Token: 0x0600E568 RID: 58728 RVA: 0x00349D38 File Offset: 0x00347F38
		public Span<byte> GetAnimationNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E569 RID: 58729 RVA: 0x00349D48 File Offset: 0x00347F48
		public byte[] GetAnimationNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x0600E56A RID: 58730 RVA: 0x00349D60 File Offset: 0x00347F60
		public string UiPrefabIdMaleVariant
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

		// Token: 0x0600E56B RID: 58731 RVA: 0x00349D98 File Offset: 0x00347F98
		public Span<byte> GetUiPrefabIdMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x00349DA8 File Offset: 0x00347FA8
		public byte[] GetUiPrefabIdMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0600E56D RID: 58733 RVA: 0x00349DC0 File Offset: 0x00347FC0
		public string AnimationNameMaleVariant
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

		// Token: 0x0600E56E RID: 58734 RVA: 0x00349DF8 File Offset: 0x00347FF8
		public Span<byte> GetAnimationNameMaleVariantBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600E56F RID: 58735 RVA: 0x00349E08 File Offset: 0x00348008
		public byte[] GetAnimationNameMaleVariantArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04005858 RID: 22616
		private Table __p;
	}
}
