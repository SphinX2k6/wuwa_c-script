using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E60 RID: 3680
	public struct MotorParkour : IFlatbufferObject
	{
		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x06009B1F RID: 39711 RVA: 0x00295281 File Offset: 0x00293481
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x0029528E File Offset: 0x0029348E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x00295298 File Offset: 0x00293498
		public static MotorParkour GetRootAsMotorParkour(ByteBuffer _bb)
		{
			return MotorParkour.GetRootAsMotorParkour(_bb, default(MotorParkour));
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x002952B4 File Offset: 0x002934B4
		public static MotorParkour GetRootAsMotorParkour(ByteBuffer _bb, MotorParkour obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x002952D1 File Offset: 0x002934D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x002952E0 File Offset: 0x002934E0
		public MotorParkour __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x06009B25 RID: 39717 RVA: 0x002952F0 File Offset: 0x002934F0
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

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x0029532C File Offset: 0x0029352C
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

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x00295368 File Offset: 0x00293568
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

		// Token: 0x06009B28 RID: 39720 RVA: 0x002953A4 File Offset: 0x002935A4
		public int RewardIds(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x06009B29 RID: 39721 RVA: 0x002953E4 File Offset: 0x002935E4
		public int RewardIdsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x00295410 File Offset: 0x00293610
		public Span<int> GetRewardIdsBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x00295420 File Offset: 0x00293620
		public int[] GetRewardIdsArray()
		{
			return this.__p.__vector_as_array<int>(10) ?? Array.Empty<int>();
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x00295438 File Offset: 0x00293638
		public string LevelName
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

		// Token: 0x06009B2D RID: 39725 RVA: 0x00295470 File Offset: 0x00293670
		public Span<byte> GetLevelNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x00295480 File Offset: 0x00293680
		public byte[] GetLevelNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x00295498 File Offset: 0x00293698
		public string RouteName
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

		// Token: 0x06009B30 RID: 39728 RVA: 0x002954D0 File Offset: 0x002936D0
		public Span<byte> GetRouteNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x002954E0 File Offset: 0x002936E0
		public byte[] GetRouteNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x002954F8 File Offset: 0x002936F8
		public string SmallBgTexture
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

		// Token: 0x06009B33 RID: 39731 RVA: 0x00295530 File Offset: 0x00293730
		public Span<byte> GetSmallBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x00295540 File Offset: 0x00293740
		public byte[] GetSmallBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x06009B35 RID: 39733 RVA: 0x00295558 File Offset: 0x00293758
		public string SelectedSmallBgTexture
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

		// Token: 0x06009B36 RID: 39734 RVA: 0x00295590 File Offset: 0x00293790
		public Span<byte> GetSelectedSmallBgTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x002955A0 File Offset: 0x002937A0
		public byte[] GetSelectedSmallBgTextureArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x06009B38 RID: 39736 RVA: 0x002955B8 File Offset: 0x002937B8
		public string RaceTrackTexture
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

		// Token: 0x06009B39 RID: 39737 RVA: 0x002955F0 File Offset: 0x002937F0
		public Span<byte> GetRaceTrackTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x00295600 File Offset: 0x00293800
		public byte[] GetRaceTrackTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x00295618 File Offset: 0x00293818
		public string RomanNum
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

		// Token: 0x06009B3C RID: 39740 RVA: 0x00295650 File Offset: 0x00293850
		public Span<byte> GetRomanNumBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x00295660 File Offset: 0x00293860
		public byte[] GetRomanNumArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06009B3E RID: 39742 RVA: 0x00295678 File Offset: 0x00293878
		public string MapTexture
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

		// Token: 0x06009B3F RID: 39743 RVA: 0x002956B0 File Offset: 0x002938B0
		public Span<byte> GetMapTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(24, 1);
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x002956C0 File Offset: 0x002938C0
		public byte[] GetMapTextureArray()
		{
			return this.__p.__vector_as_array<byte>(24) ?? Array.Empty<byte>();
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x002956D8 File Offset: 0x002938D8
		public float CenterOffset(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06009B42 RID: 39746 RVA: 0x0029571C File Offset: 0x0029391C
		public int CenterOffsetLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x00295748 File Offset: 0x00293948
		public Span<float> GetCenterOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(26, 4);
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x00295758 File Offset: 0x00293958
		public float[] GetCenterOffsetArray()
		{
			return this.__p.__vector_as_array<float>(26) ?? Array.Empty<float>();
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x00295770 File Offset: 0x00293970
		public float UiOffset(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06009B46 RID: 39750 RVA: 0x002957B4 File Offset: 0x002939B4
		public int UiOffsetLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x002957E0 File Offset: 0x002939E0
		public Span<float> GetUiOffsetBytes()
		{
			return this.__p.__vector_as_span<float>(28, 4);
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x002957F0 File Offset: 0x002939F0
		public float[] GetUiOffsetArray()
		{
			return this.__p.__vector_as_array<float>(28) ?? Array.Empty<float>();
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06009B49 RID: 39753 RVA: 0x00295808 File Offset: 0x00293A08
		public float MapScale
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06009B4A RID: 39754 RVA: 0x0029584C File Offset: 0x00293A4C
		public int SplineId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x06009B4B RID: 39755 RVA: 0x0029588C File Offset: 0x00293A8C
		public int SplineStartIndex
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x06009B4C RID: 39756 RVA: 0x002958CC File Offset: 0x00293ACC
		public int SplineEndIndex
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

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06009B4D RID: 39757 RVA: 0x0029590C File Offset: 0x00293B0C
		public int RouteTextureRotation
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

		// Token: 0x06009B4E RID: 39758 RVA: 0x0029594C File Offset: 0x00293B4C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CenterOffsetIter()或GetCenterOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] CenterOffset()
		{
			MotorParkour motorParkour = this;
			return motorParkour.GetCenterOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x00295970 File Offset: 0x00293B70
		[NullableContext(1)]
		public readonly IEnumerable<float> CenterOffsetIter()
		{
			MotorParkour.<CenterOffsetIter>d__68 <CenterOffsetIter>d__ = new MotorParkour.<CenterOffsetIter>d__68(-2);
			<CenterOffsetIter>d__.<>3__<>4__this = this;
			return <CenterOffsetIter>d__;
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x00295988 File Offset: 0x00293B88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RewardIdsIter()或GetRewardIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RewardIds()
		{
			MotorParkour motorParkour = this;
			return motorParkour.GetRewardIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x002959AC File Offset: 0x00293BAC
		[NullableContext(1)]
		public readonly IEnumerable<int> RewardIdsIter()
		{
			MotorParkour.<RewardIdsIter>d__70 <RewardIdsIter>d__ = new MotorParkour.<RewardIdsIter>d__70(-2);
			<RewardIdsIter>d__.<>3__<>4__this = this;
			return <RewardIdsIter>d__;
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x002959C4 File Offset: 0x00293BC4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UiOffsetIter()或GetUiOffsetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] UiOffset()
		{
			MotorParkour motorParkour = this;
			return motorParkour.GetUiOffsetArray() ?? Array.Empty<float>();
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x002959E8 File Offset: 0x00293BE8
		[NullableContext(1)]
		public readonly IEnumerable<float> UiOffsetIter()
		{
			MotorParkour.<UiOffsetIter>d__72 <UiOffsetIter>d__ = new MotorParkour.<UiOffsetIter>d__72(-2);
			<UiOffsetIter>d__.<>3__<>4__this = this;
			return <UiOffsetIter>d__;
		}

		// Token: 0x04004F0C RID: 20236
		private Table __p;
	}
}
