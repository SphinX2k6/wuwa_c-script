using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C58 RID: 3160
	public struct ExternalSourceSetting : IFlatbufferObject
	{
		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06006C4E RID: 27726 RVA: 0x0022A5B9 File Offset: 0x002287B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006C4F RID: 27727 RVA: 0x0022A5C6 File Offset: 0x002287C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006C50 RID: 27728 RVA: 0x0022A5D0 File Offset: 0x002287D0
		public static ExternalSourceSetting GetRootAsExternalSourceSetting(ByteBuffer _bb)
		{
			return ExternalSourceSetting.GetRootAsExternalSourceSetting(_bb, default(ExternalSourceSetting));
		}

		// Token: 0x06006C51 RID: 27729 RVA: 0x0022A5EC File Offset: 0x002287EC
		public static ExternalSourceSetting GetRootAsExternalSourceSetting(ByteBuffer _bb, ExternalSourceSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006C52 RID: 27730 RVA: 0x0022A609 File Offset: 0x00228809
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006C53 RID: 27731 RVA: 0x0022A618 File Offset: 0x00228818
		public ExternalSourceSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06006C54 RID: 27732 RVA: 0x0022A628 File Offset: 0x00228828
		public string Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x0022A65F File Offset: 0x0022885F
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x0022A66E File Offset: 0x0022886E
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06006C57 RID: 27735 RVA: 0x0022A688 File Offset: 0x00228888
		public string AudioEventPath
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

		// Token: 0x06006C58 RID: 27736 RVA: 0x0022A6BF File Offset: 0x002288BF
		public Span<byte> GetAudioEventPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x0022A6CE File Offset: 0x002288CE
		public byte[] GetAudioEventPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06006C5A RID: 27738 RVA: 0x0022A6E8 File Offset: 0x002288E8
		public string ExternalSrcName
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

		// Token: 0x06006C5B RID: 27739 RVA: 0x0022A71F File Offset: 0x0022891F
		public Span<byte> GetExternalSrcNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x0022A72E File Offset: 0x0022892E
		public byte[] GetExternalSrcNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x06006C5D RID: 27741 RVA: 0x0022A748 File Offset: 0x00228948
		public string SubtitleEvent
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

		// Token: 0x06006C5E RID: 27742 RVA: 0x0022A780 File Offset: 0x00228980
		public Span<byte> GetSubtitleEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x0022A790 File Offset: 0x00228990
		public byte[] GetSubtitleEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x06006C60 RID: 27744 RVA: 0x0022A7A8 File Offset: 0x002289A8
		public string SubtitleSrc
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

		// Token: 0x06006C61 RID: 27745 RVA: 0x0022A7E0 File Offset: 0x002289E0
		public Span<byte> GetSubtitleSrcBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x0022A7F0 File Offset: 0x002289F0
		public byte[] GetSubtitleSrcArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x06006C63 RID: 27747 RVA: 0x0022A808 File Offset: 0x00228A08
		public string BubbleEvent
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

		// Token: 0x06006C64 RID: 27748 RVA: 0x0022A840 File Offset: 0x00228A40
		public Span<byte> GetBubbleEventBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x0022A850 File Offset: 0x00228A50
		public byte[] GetBubbleEventArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06006C66 RID: 27750 RVA: 0x0022A868 File Offset: 0x00228A68
		public string BubbleSrc
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

		// Token: 0x06006C67 RID: 27751 RVA: 0x0022A8A0 File Offset: 0x00228AA0
		public Span<byte> GetBubbleSrcBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x0022A8B0 File Offset: 0x00228AB0
		public byte[] GetBubbleSrcArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CA3 RID: 19619
		private Table __p;
	}
}
