using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000ED3 RID: 3795
	public struct MapMark : IFlatbufferObject
	{
		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x0600971B RID: 38683 RVA: 0x0029C52C File Offset: 0x0029A72C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x0029C539 File Offset: 0x0029A739
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x0029C540 File Offset: 0x0029A740
		public static MapMark GetRootAsMapMark(ByteBuffer _bb)
		{
			return MapMark.GetRootAsMapMark(_bb, default(MapMark));
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x0029C55C File Offset: 0x0029A75C
		public static MapMark GetRootAsMapMark(ByteBuffer _bb, MapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x0029C579 File Offset: 0x0029A779
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x0029C588 File Offset: 0x0029A788
		public MapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06009721 RID: 38689 RVA: 0x0029C598 File Offset: 0x0029A798
		public int MarkId
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

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06009722 RID: 38690 RVA: 0x0029C5D4 File Offset: 0x0029A7D4
		public int InstanceDungeonId
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

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06009723 RID: 38691 RVA: 0x0029C610 File Offset: 0x0029A810
		public int MapId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06009724 RID: 38692 RVA: 0x0029C64C File Offset: 0x0029A84C
		public int RelativeDungeonId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 8;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x06009725 RID: 38693 RVA: 0x0029C68C File Offset: 0x0029A88C
		public int RelativeType
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

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x06009726 RID: 38694 RVA: 0x0029C6CC File Offset: 0x0029A8CC
		public int RelativeSubType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x06009727 RID: 38695 RVA: 0x0029C70C File Offset: 0x0029A90C
		public int RelativeId
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

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x06009728 RID: 38696 RVA: 0x0029C74C File Offset: 0x0029A94C
		public int EntityConfigId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x0029C78C File Offset: 0x0029A98C
		public int FogHide
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x0600972A RID: 38698 RVA: 0x0029C7CC File Offset: 0x0029A9CC
		public int ObjectType
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

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x0600972B RID: 38699 RVA: 0x0029C80C File Offset: 0x0029AA0C
		public int ShowPriority
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

		// Token: 0x0600972C RID: 38700 RVA: 0x0029C84C File Offset: 0x0029AA4C
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600972D RID: 38701 RVA: 0x0029C88C File Offset: 0x0029AA8C
		public int ShowRangeLength
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

		// Token: 0x0600972E RID: 38702 RVA: 0x0029C8B8 File Offset: 0x0029AAB8
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x0029C8C8 File Offset: 0x0029AAC8
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x06009730 RID: 38704 RVA: 0x0029C8E0 File Offset: 0x0029AAE0
		public int ShowCondition
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x06009731 RID: 38705 RVA: 0x0029C920 File Offset: 0x0029AB20
		public int CreateOnStart
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06009732 RID: 38706 RVA: 0x0029C960 File Offset: 0x0029AB60
		public int EnableQuickTransfer
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

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06009733 RID: 38707 RVA: 0x0029C9A0 File Offset: 0x0029ABA0
		public bool IsDisableGameplayFinishIcon
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06009734 RID: 38708 RVA: 0x0029C9E0 File Offset: 0x0029ABE0
		public int FinishIsShow
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

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06009735 RID: 38709 RVA: 0x0029CA20 File Offset: 0x0029AC20
		public int FogShow
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

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06009736 RID: 38710 RVA: 0x0029CA60 File Offset: 0x0029AC60
		public string MarkTitle
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x0029CA98 File Offset: 0x0029AC98
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x0029CAA8 File Offset: 0x0029ACA8
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x06009739 RID: 38713 RVA: 0x0029CAC0 File Offset: 0x0029ACC0
		public string MarkDesc
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x0029CAF8 File Offset: 0x0029ACF8
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x0029CB08 File Offset: 0x0029AD08
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600973C RID: 38716 RVA: 0x0029CB20 File Offset: 0x0029AD20
		public string LockMarkPic
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x0029CB58 File Offset: 0x0029AD58
		public Span<byte> GetLockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x0029CB68 File Offset: 0x0029AD68
		public byte[] GetLockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0029CB80 File Offset: 0x0029AD80
		public string UnlockMarkPic
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x0029CBB8 File Offset: 0x0029ADB8
		public Span<byte> GetUnlockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x0029CBC8 File Offset: 0x0029ADC8
		public byte[] GetUnlockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06009742 RID: 38722 RVA: 0x0029CBE0 File Offset: 0x0029ADE0
		public string GameplayLockText
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009743 RID: 38723 RVA: 0x0029CC18 File Offset: 0x0029AE18
		public Span<byte> GetGameplayLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x0029CC28 File Offset: 0x0029AE28
		public byte[] GetGameplayLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06009745 RID: 38725 RVA: 0x0029CC40 File Offset: 0x0029AE40
		public int GameplayLockJumpId
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06009746 RID: 38726 RVA: 0x0029CC80 File Offset: 0x0029AE80
		public int MultiMapFloorId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0029CCC0 File Offset: 0x0029AEC0
		public int ConnetMultiMapFloorId(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06009748 RID: 38728 RVA: 0x0029CD00 File Offset: 0x0029AF00
		public int ConnetMultiMapFloorIdLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0029CD2C File Offset: 0x0029AF2C
		public Span<int> GetConnetMultiMapFloorIdBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x0029CD3C File Offset: 0x0029AF3C
		public int[] GetConnetMultiMapFloorIdArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x0600974B RID: 38731 RVA: 0x0029CD54 File Offset: 0x0029AF54
		public int MultiFloorShowCondition
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600974C RID: 38732 RVA: 0x0029CD94 File Offset: 0x0029AF94
		public IntVector? MarkVector
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return null;
				}
				return new IntVector?(default(IntVector).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600974D RID: 38733 RVA: 0x0029CDF4 File Offset: 0x0029AFF4
		public int GravityFlip
		{
			get
			{
				int num = this.__p.__offset(60);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600974E RID: 38734 RVA: 0x0029CE34 File Offset: 0x0029B034
		public int MapShow
		{
			get
			{
				int num = this.__p.__offset(62);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x0600974F RID: 38735 RVA: 0x0029CE74 File Offset: 0x0029B074
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06009750 RID: 38736 RVA: 0x0029CEB8 File Offset: 0x0029B0B8
		public float CornerScale
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06009751 RID: 38737 RVA: 0x0029CEFC File Offset: 0x0029B0FC
		public int ToBeDiscovered
		{
			get
			{
				int num = this.__p.__offset(68);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06009752 RID: 38738 RVA: 0x0029CF3C File Offset: 0x0029B13C
		public int IsMonster
		{
			get
			{
				int num = this.__p.__offset(70);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06009753 RID: 38739 RVA: 0x0029CF7C File Offset: 0x0029B17C
		public int TrackHudEnable
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x06009754 RID: 38740 RVA: 0x0029CFBC File Offset: 0x0029B1BC
		public float TrackAutoCancelDistance
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 400f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x06009755 RID: 38741 RVA: 0x0029D000 File Offset: 0x0029B200
		public int HistoryState
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x0029D040 File Offset: 0x0029B240
		public int AssociatedGameplayMarks(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x06009757 RID: 38743 RVA: 0x0029D080 File Offset: 0x0029B280
		public int AssociatedGameplayMarksLength
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009758 RID: 38744 RVA: 0x0029D0AC File Offset: 0x0029B2AC
		public Span<int> GetAssociatedGameplayMarksBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x06009759 RID: 38745 RVA: 0x0029D0BC File Offset: 0x0029B2BC
		public int[] GetAssociatedGameplayMarksArray()
		{
			return this.__p.__vector_as_array<int>(78) ?? Array.Empty<int>();
		}

		// Token: 0x0600975A RID: 38746 RVA: 0x0029D0D4 File Offset: 0x0029B2D4
		public string AreaShowText(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x0600975B RID: 38747 RVA: 0x0029D110 File Offset: 0x0029B310
		public int AreaShowTextLength
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x0029D13C File Offset: 0x0029B33C
		public DicIntInt? DeliveryProp(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x0600975D RID: 38749 RVA: 0x0029D1A0 File Offset: 0x0029B3A0
		public int DeliveryPropLength
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x0600975E RID: 38750 RVA: 0x0029D1CC File Offset: 0x0029B3CC
		public bool IsDisableBtnGoto
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x0600975F RID: 38751 RVA: 0x0029D20C File Offset: 0x0029B40C
		public int FirstReward
		{
			get
			{
				int num = this.__p.__offset(86);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06009760 RID: 38752 RVA: 0x0029D24C File Offset: 0x0029B44C
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(88);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06009761 RID: 38753 RVA: 0x0029D28C File Offset: 0x0029B48C
		public int MarkFuncType
		{
			get
			{
				int num = this.__p.__offset(90);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x0029D2CC File Offset: 0x0029B4CC
		public int TreasureChestCountTarget(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06009763 RID: 38755 RVA: 0x0029D30C File Offset: 0x0029B50C
		public int TreasureChestCountTargetLength
		{
			get
			{
				int num = this.__p.__offset(92);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x0029D338 File Offset: 0x0029B538
		public Span<int> GetTreasureChestCountTargetBytes()
		{
			return this.__p.__vector_as_span<int>(92, 4);
		}

		// Token: 0x06009765 RID: 38757 RVA: 0x0029D348 File Offset: 0x0029B548
		public int[] GetTreasureChestCountTargetArray()
		{
			return this.__p.__vector_as_array<int>(92) ?? Array.Empty<int>();
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x0029D360 File Offset: 0x0029B560
		[NullableContext(1)]
		public string[] AreaShowText()
		{
			return this.AreaShowTextIter().ToArray<string>();
		}

		// Token: 0x06009767 RID: 38759 RVA: 0x0029D36D File Offset: 0x0029B56D
		[NullableContext(1)]
		public IEnumerable<string> AreaShowTextIter()
		{
			MapMark.<AreaShowTextIter>d__123 <AreaShowTextIter>d__ = new MapMark.<AreaShowTextIter>d__123(-2);
			<AreaShowTextIter>d__.<>3__<>4__this = this;
			return <AreaShowTextIter>d__;
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x0029D382 File Offset: 0x0029B582
		[NullableContext(1)]
		public int[] AssociatedGameplayMarks()
		{
			return this.GetAssociatedGameplayMarksArray();
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x0029D38A File Offset: 0x0029B58A
		[NullableContext(1)]
		public IEnumerable<int> AssociatedGameplayMarksIter()
		{
			MapMark.<AssociatedGameplayMarksIter>d__125 <AssociatedGameplayMarksIter>d__ = new MapMark.<AssociatedGameplayMarksIter>d__125(-2);
			<AssociatedGameplayMarksIter>d__.<>3__<>4__this = this;
			return <AssociatedGameplayMarksIter>d__;
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x0029D39F File Offset: 0x0029B59F
		[NullableContext(1)]
		public int[] ConnetMultiMapFloorId()
		{
			return this.GetConnetMultiMapFloorIdArray();
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x0029D3A7 File Offset: 0x0029B5A7
		[NullableContext(1)]
		public IEnumerable<int> ConnetMultiMapFloorIdIter()
		{
			MapMark.<ConnetMultiMapFloorIdIter>d__127 <ConnetMultiMapFloorIdIter>d__ = new MapMark.<ConnetMultiMapFloorIdIter>d__127(-2);
			<ConnetMultiMapFloorIdIter>d__.<>3__<>4__this = this;
			return <ConnetMultiMapFloorIdIter>d__;
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x0029D3BC File Offset: 0x0029B5BC
		[NullableContext(1)]
		public Dictionary<int, int> DeliveryProp()
		{
			return this.DeliveryPropIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x0029D412 File Offset: 0x0029B612
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DeliveryPropIter()
		{
			MapMark.<DeliveryPropIter>d__129 <DeliveryPropIter>d__ = new MapMark.<DeliveryPropIter>d__129(-2);
			<DeliveryPropIter>d__.<>3__<>4__this = this;
			return <DeliveryPropIter>d__;
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x0029D427 File Offset: 0x0029B627
		[NullableContext(1)]
		public int[] ShowRange()
		{
			return this.GetShowRangeArray();
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x0029D42F File Offset: 0x0029B62F
		[NullableContext(1)]
		public IEnumerable<int> ShowRangeIter()
		{
			MapMark.<ShowRangeIter>d__131 <ShowRangeIter>d__ = new MapMark.<ShowRangeIter>d__131(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x0029D444 File Offset: 0x0029B644
		[NullableContext(1)]
		public int[] TreasureChestCountTarget()
		{
			return this.GetTreasureChestCountTargetArray();
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x0029D44C File Offset: 0x0029B64C
		[NullableContext(1)]
		public IEnumerable<int> TreasureChestCountTargetIter()
		{
			MapMark.<TreasureChestCountTargetIter>d__133 <TreasureChestCountTargetIter>d__ = new MapMark.<TreasureChestCountTargetIter>d__133(-2);
			<TreasureChestCountTargetIter>d__.<>3__<>4__this = this;
			return <TreasureChestCountTargetIter>d__;
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x0029D464 File Offset: 0x0029B664
		public int? GetDeliveryProp(int key)
		{
			this.EnsureDeliveryPropCacheIfNeeded();
			int value;
			if (!this.DeliveryPropCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0029D498 File Offset: 0x0029B698
		private void EnsureDeliveryPropCacheIfNeeded()
		{
			if (this.DeliveryPropCache != null)
			{
				return;
			}
			this.DeliveryPropCache = this.DeliveryPropIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0029D4FE File Offset: 0x0029B6FE
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDeliveryPropFrozenDict()
		{
			this.EnsureDeliveryPropCacheIfNeeded();
			return this.DeliveryPropCache;
		}

		// Token: 0x0400546F RID: 21615
		private Table __p;

		// Token: 0x04005470 RID: 21616
		[Nullable(2)]
		private FrozenDictionary<int, int> DeliveryPropCache;
	}
}
