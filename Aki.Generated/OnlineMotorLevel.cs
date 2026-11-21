using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F88 RID: 3976
	public struct OnlineMotorLevel : IFlatbufferObject
	{
		// Token: 0x17002472 RID: 9330
		// (get) Token: 0x0600A770 RID: 42864 RVA: 0x002BFD4C File Offset: 0x002BDF4C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x002BFD59 File Offset: 0x002BDF59
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x002BFD60 File Offset: 0x002BDF60
		public static OnlineMotorLevel GetRootAsOnlineMotorLevel(ByteBuffer _bb)
		{
			return OnlineMotorLevel.GetRootAsOnlineMotorLevel(_bb, default(OnlineMotorLevel));
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x002BFD7C File Offset: 0x002BDF7C
		public static OnlineMotorLevel GetRootAsOnlineMotorLevel(ByteBuffer _bb, OnlineMotorLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x002BFD99 File Offset: 0x002BDF99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x002BFDA8 File Offset: 0x002BDFA8
		public OnlineMotorLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002473 RID: 9331
		// (get) Token: 0x0600A776 RID: 42870 RVA: 0x002BFDB8 File Offset: 0x002BDFB8
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

		// Token: 0x17002474 RID: 9332
		// (get) Token: 0x0600A777 RID: 42871 RVA: 0x002BFDF4 File Offset: 0x002BDFF4
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

		// Token: 0x17002475 RID: 9333
		// (get) Token: 0x0600A778 RID: 42872 RVA: 0x002BFE30 File Offset: 0x002BE030
		public int InstId
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

		// Token: 0x17002476 RID: 9334
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x002BFE6C File Offset: 0x002BE06C
		public int PreLevel
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

		// Token: 0x17002477 RID: 9335
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x002BFEAC File Offset: 0x002BE0AC
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x002BFEEC File Offset: 0x002BE0EC
		public int LevelTaskIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002478 RID: 9336
		// (get) Token: 0x0600A77C RID: 42876 RVA: 0x002BFF2C File Offset: 0x002BE12C
		public int LevelTaskIdsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x002BFF58 File Offset: 0x002BE158
		public Span<int> GetLevelTaskIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x002BFF68 File Offset: 0x002BE168
		public int[] GetLevelTaskIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x0600A77F RID: 42879 RVA: 0x002BFF80 File Offset: 0x002BE180
		public string LevelTitleSprite
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

		// Token: 0x0600A780 RID: 42880 RVA: 0x002BFFB8 File Offset: 0x002BE1B8
		public Span<byte> GetLevelTitleSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x002BFFC8 File Offset: 0x002BE1C8
		public byte[] GetLevelTitleSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x0600A782 RID: 42882 RVA: 0x002BFFE0 File Offset: 0x002BE1E0
		public string LevelRomanSprite
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

		// Token: 0x0600A783 RID: 42883 RVA: 0x002C0018 File Offset: 0x002BE218
		public Span<byte> GetLevelRomanSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x002C0028 File Offset: 0x002BE228
		public byte[] GetLevelRomanSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700247B RID: 9339
		// (get) Token: 0x0600A785 RID: 42885 RVA: 0x002C0040 File Offset: 0x002BE240
		public string LevelTitleTexture
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

		// Token: 0x0600A786 RID: 42886 RVA: 0x002C0078 File Offset: 0x002BE278
		public Span<byte> GetLevelTitleTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x002C0088 File Offset: 0x002BE288
		public byte[] GetLevelTitleTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x0600A788 RID: 42888 RVA: 0x002C00A0 File Offset: 0x002BE2A0
		public string LevelTitleTextureSelect
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x002C00D8 File Offset: 0x002BE2D8
		public Span<byte> GetLevelTitleTextureSelectBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x002C00E8 File Offset: 0x002BE2E8
		public byte[] GetLevelTitleTextureSelectArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x0600A78B RID: 42891 RVA: 0x002C0100 File Offset: 0x002BE300
		public string Name
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x002C0138 File Offset: 0x002BE338
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x002C0148 File Offset: 0x002BE348
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x0600A78E RID: 42894 RVA: 0x002C0160 File Offset: 0x002BE360
		public string LevelTexture
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x002C0198 File Offset: 0x002BE398
		public Span<byte> GetLevelTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x002C01A8 File Offset: 0x002BE3A8
		public byte[] GetLevelTextureArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x0600A791 RID: 42897 RVA: 0x002C01C0 File Offset: 0x002BE3C0
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x002C0200 File Offset: 0x002BE400
		public float CenterOffset(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x0600A793 RID: 42899 RVA: 0x002C0244 File Offset: 0x002BE444
		public int CenterOffsetLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x002C0270 File Offset: 0x002BE470
		public Span<float> GetCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(30, 4);
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x002C0280 File Offset: 0x002BE480
		public float[] GetCenterOffsetArray()
		{
			return this.__p.__vector_as_array<float>(30) ?? Array.Empty<float>();
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x002C0298 File Offset: 0x002BE498
		public float UiOffset(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600A797 RID: 42903 RVA: 0x002C02DC File Offset: 0x002BE4DC
		public int UiOffsetLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x002C0308 File Offset: 0x002BE508
		public Span<float> GetUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(32, 4);
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x002C0318 File Offset: 0x002BE518
		public float[] GetUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(32) ?? Array.Empty<float>();
		}

		// Token: 0x17002482 RID: 9346
		// (get) Token: 0x0600A79A RID: 42906 RVA: 0x002C0330 File Offset: 0x002BE530
		public float MapScale
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002483 RID: 9347
		// (get) Token: 0x0600A79B RID: 42907 RVA: 0x002C0374 File Offset: 0x002BE574
		public int SplineId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002484 RID: 9348
		// (get) Token: 0x0600A79C RID: 42908 RVA: 0x002C03B4 File Offset: 0x002BE5B4
		public int SplineStartIndex
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002485 RID: 9349
		// (get) Token: 0x0600A79D RID: 42909 RVA: 0x002C03F4 File Offset: 0x002BE5F4
		public int SplineEndIndex
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002486 RID: 9350
		// (get) Token: 0x0600A79E RID: 42910 RVA: 0x002C0434 File Offset: 0x002BE634
		public int RouteTextureRotation
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x002C0471 File Offset: 0x002BE671
		[NullableContext(1)]
		public float[] CenterOffset()
		{
			return this.GetCenterOffsetArray();
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x002C0479 File Offset: 0x002BE679
		[NullableContext(1)]
		public IEnumerable<float> CenterOffsetIter()
		{
			OnlineMotorLevel.<CenterOffsetIter>d__70 <CenterOffsetIter>d__ = new OnlineMotorLevel.<CenterOffsetIter>d__70(-2);
			<CenterOffsetIter>d__.<>3__<>4__this = this;
			return <CenterOffsetIter>d__;
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x002C048E File Offset: 0x002BE68E
		[NullableContext(1)]
		public int[] LevelTaskIds()
		{
			return this.GetLevelTaskIdsArray();
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x002C0496 File Offset: 0x002BE696
		[NullableContext(1)]
		public IEnumerable<int> LevelTaskIdsIter()
		{
			OnlineMotorLevel.<LevelTaskIdsIter>d__72 <LevelTaskIdsIter>d__ = new OnlineMotorLevel.<LevelTaskIdsIter>d__72(-2);
			<LevelTaskIdsIter>d__.<>3__<>4__this = this;
			return <LevelTaskIdsIter>d__;
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x002C04AB File Offset: 0x002BE6AB
		[NullableContext(1)]
		public float[] UiOffset()
		{
			return this.GetUiOffsetArray();
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x002C04B3 File Offset: 0x002BE6B3
		[NullableContext(1)]
		public IEnumerable<float> UiOffsetIter()
		{
			OnlineMotorLevel.<UiOffsetIter>d__74 <UiOffsetIter>d__ = new OnlineMotorLevel.<UiOffsetIter>d__74(-2);
			<UiOffsetIter>d__.<>3__<>4__this = this;
			return <UiOffsetIter>d__;
		}

		// Token: 0x0400553C RID: 21820
		private Table __p;
	}
}
