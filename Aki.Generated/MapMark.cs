using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEE RID: 3566
	public struct MapMark : IFlatbufferObject
	{
		// Token: 0x17001DF6 RID: 7670
		// (get) Token: 0x060090FF RID: 37119 RVA: 0x0027E2C8 File Offset: 0x0027C4C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x0027E2D5 File Offset: 0x0027C4D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x0027E2DC File Offset: 0x0027C4DC
		public static MapMark GetRootAsMapMark(ByteBuffer _bb)
		{
			return MapMark.GetRootAsMapMark(_bb, default(MapMark));
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x0027E2F8 File Offset: 0x0027C4F8
		public static MapMark GetRootAsMapMark(ByteBuffer _bb, MapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x0027E315 File Offset: 0x0027C515
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x0027E324 File Offset: 0x0027C524
		public MapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06009105 RID: 37125 RVA: 0x0027E334 File Offset: 0x0027C534
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

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06009106 RID: 37126 RVA: 0x0027E370 File Offset: 0x0027C570
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

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06009107 RID: 37127 RVA: 0x0027E3AC File Offset: 0x0027C5AC
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

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x06009108 RID: 37128 RVA: 0x0027E3E8 File Offset: 0x0027C5E8
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

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x06009109 RID: 37129 RVA: 0x0027E428 File Offset: 0x0027C628
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

		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600910A RID: 37130 RVA: 0x0027E468 File Offset: 0x0027C668
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

		// Token: 0x17001DFD RID: 7677
		// (get) Token: 0x0600910B RID: 37131 RVA: 0x0027E4A8 File Offset: 0x0027C6A8
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

		// Token: 0x17001DFE RID: 7678
		// (get) Token: 0x0600910C RID: 37132 RVA: 0x0027E4E8 File Offset: 0x0027C6E8
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

		// Token: 0x17001DFF RID: 7679
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x0027E528 File Offset: 0x0027C728
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

		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x0027E568 File Offset: 0x0027C768
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

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x0600910F RID: 37135 RVA: 0x0027E5A8 File Offset: 0x0027C7A8
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

		// Token: 0x06009110 RID: 37136 RVA: 0x0027E5E8 File Offset: 0x0027C7E8
		public int ShowRange(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E02 RID: 7682
		// (get) Token: 0x06009111 RID: 37137 RVA: 0x0027E628 File Offset: 0x0027C828
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

		// Token: 0x06009112 RID: 37138 RVA: 0x0027E654 File Offset: 0x0027C854
		public Span<int> GetShowRangeBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x0027E664 File Offset: 0x0027C864
		public int[] GetShowRangeArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001E03 RID: 7683
		// (get) Token: 0x06009114 RID: 37140 RVA: 0x0027E67C File Offset: 0x0027C87C
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

		// Token: 0x17001E04 RID: 7684
		// (get) Token: 0x06009115 RID: 37141 RVA: 0x0027E6BC File Offset: 0x0027C8BC
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

		// Token: 0x17001E05 RID: 7685
		// (get) Token: 0x06009116 RID: 37142 RVA: 0x0027E6FC File Offset: 0x0027C8FC
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

		// Token: 0x17001E06 RID: 7686
		// (get) Token: 0x06009117 RID: 37143 RVA: 0x0027E73C File Offset: 0x0027C93C
		public bool IsDisableGameplayFinishIcon
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06009118 RID: 37144 RVA: 0x0027E77C File Offset: 0x0027C97C
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

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06009119 RID: 37145 RVA: 0x0027E7BC File Offset: 0x0027C9BC
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

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x0600911A RID: 37146 RVA: 0x0027E7FC File Offset: 0x0027C9FC
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

		// Token: 0x0600911B RID: 37147 RVA: 0x0027E834 File Offset: 0x0027CA34
		public Span<byte> GetMarkTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x0027E844 File Offset: 0x0027CA44
		public byte[] GetMarkTitleArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x0600911D RID: 37149 RVA: 0x0027E85C File Offset: 0x0027CA5C
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

		// Token: 0x0600911E RID: 37150 RVA: 0x0027E894 File Offset: 0x0027CA94
		public Span<byte> GetMarkDescBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x0027E8A4 File Offset: 0x0027CAA4
		public byte[] GetMarkDescArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x0027E8BC File Offset: 0x0027CABC
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

		// Token: 0x06009121 RID: 37153 RVA: 0x0027E8F4 File Offset: 0x0027CAF4
		public Span<byte> GetLockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x0027E904 File Offset: 0x0027CB04
		public byte[] GetLockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x06009123 RID: 37155 RVA: 0x0027E91C File Offset: 0x0027CB1C
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

		// Token: 0x06009124 RID: 37156 RVA: 0x0027E954 File Offset: 0x0027CB54
		public Span<byte> GetUnlockMarkPicBytes()
		{
			return this.__p.__vector_as_span<byte>(46, 1);
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x0027E964 File Offset: 0x0027CB64
		public byte[] GetUnlockMarkPicArray()
		{
			return this.__p.__vector_as_array<byte>(46) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x06009126 RID: 37158 RVA: 0x0027E97C File Offset: 0x0027CB7C
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

		// Token: 0x06009127 RID: 37159 RVA: 0x0027E9B4 File Offset: 0x0027CBB4
		public Span<byte> GetGameplayLockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x0027E9C4 File Offset: 0x0027CBC4
		public byte[] GetGameplayLockTextArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x06009129 RID: 37161 RVA: 0x0027E9DC File Offset: 0x0027CBDC
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

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x0600912A RID: 37162 RVA: 0x0027EA1C File Offset: 0x0027CC1C
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

		// Token: 0x0600912B RID: 37163 RVA: 0x0027EA5C File Offset: 0x0027CC5C
		public int ConnetMultiMapFloorId(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x0600912C RID: 37164 RVA: 0x0027EA9C File Offset: 0x0027CC9C
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

		// Token: 0x0600912D RID: 37165 RVA: 0x0027EAC8 File Offset: 0x0027CCC8
		public Span<int> GetConnetMultiMapFloorIdBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600912E RID: 37166 RVA: 0x0027EAD8 File Offset: 0x0027CCD8
		public int[] GetConnetMultiMapFloorIdArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x0027EAF0 File Offset: 0x0027CCF0
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

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x0027EB30 File Offset: 0x0027CD30
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

		// Token: 0x17001E13 RID: 7699
		// (get) Token: 0x06009131 RID: 37169 RVA: 0x0027EB90 File Offset: 0x0027CD90
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

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06009132 RID: 37170 RVA: 0x0027EBD0 File Offset: 0x0027CDD0
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

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x06009133 RID: 37171 RVA: 0x0027EC10 File Offset: 0x0027CE10
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

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x06009134 RID: 37172 RVA: 0x0027EC54 File Offset: 0x0027CE54
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

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x06009135 RID: 37173 RVA: 0x0027EC98 File Offset: 0x0027CE98
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

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x0027ECD8 File Offset: 0x0027CED8
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

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x06009137 RID: 37175 RVA: 0x0027ED18 File Offset: 0x0027CF18
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

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x06009138 RID: 37176 RVA: 0x0027ED58 File Offset: 0x0027CF58
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

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06009139 RID: 37177 RVA: 0x0027ED9C File Offset: 0x0027CF9C
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

		// Token: 0x0600913A RID: 37178 RVA: 0x0027EDDC File Offset: 0x0027CFDC
		public int AssociatedGameplayMarks(int j)
		{
			int num = this.__p.__offset(78);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600913B RID: 37179 RVA: 0x0027EE1C File Offset: 0x0027D01C
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

		// Token: 0x0600913C RID: 37180 RVA: 0x0027EE48 File Offset: 0x0027D048
		public Span<int> GetAssociatedGameplayMarksBytes()
		{
			return this.__p.__vector_as_span<int>(78, 4);
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0027EE58 File Offset: 0x0027D058
		public int[] GetAssociatedGameplayMarksArray()
		{
			return this.__p.__vector_as_array<int>(78) ?? Array.Empty<int>();
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x0027EE70 File Offset: 0x0027D070
		public string AreaShowText(int j)
		{
			int num = this.__p.__offset(80);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x0600913F RID: 37183 RVA: 0x0027EEAC File Offset: 0x0027D0AC
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

		// Token: 0x06009140 RID: 37184 RVA: 0x0027EED8 File Offset: 0x0027D0D8
		public DicIntInt? DeliveryProp(int j)
		{
			int num = this.__p.__offset(82);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06009141 RID: 37185 RVA: 0x0027EF3C File Offset: 0x0027D13C
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

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06009142 RID: 37186 RVA: 0x0027EF68 File Offset: 0x0027D168
		public bool IsDisableBtnGoto
		{
			get
			{
				int num = this.__p.__offset(84);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06009143 RID: 37187 RVA: 0x0027EFA8 File Offset: 0x0027D1A8
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

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x0027EFE8 File Offset: 0x0027D1E8
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

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06009145 RID: 37189 RVA: 0x0027F028 File Offset: 0x0027D228
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

		// Token: 0x06009146 RID: 37190 RVA: 0x0027F068 File Offset: 0x0027D268
		public int TreasureChestCountTarget(int j)
		{
			int num = this.__p.__offset(92);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06009147 RID: 37191 RVA: 0x0027F0A8 File Offset: 0x0027D2A8
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

		// Token: 0x06009148 RID: 37192 RVA: 0x0027F0D4 File Offset: 0x0027D2D4
		public Span<int> GetTreasureChestCountTargetBytes()
		{
			return this.__p.__vector_as_span<int>(92, 4);
		}

		// Token: 0x06009149 RID: 37193 RVA: 0x0027F0E4 File Offset: 0x0027D2E4
		public int[] GetTreasureChestCountTargetArray()
		{
			return this.__p.__vector_as_array<int>(92) ?? Array.Empty<int>();
		}

		// Token: 0x0600914A RID: 37194 RVA: 0x0027F0FC File Offset: 0x0027D2FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AreaShowTextIter()或GetAreaShowTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] AreaShowText()
		{
			return this.AreaShowTextIter().ToArray<string>();
		}

		// Token: 0x0600914B RID: 37195 RVA: 0x0027F109 File Offset: 0x0027D309
		[NullableContext(1)]
		public readonly IEnumerable<string> AreaShowTextIter()
		{
			MapMark.<AreaShowTextIter>d__123 <AreaShowTextIter>d__ = new MapMark.<AreaShowTextIter>d__123(-2);
			<AreaShowTextIter>d__.<>3__<>4__this = this;
			return <AreaShowTextIter>d__;
		}

		// Token: 0x0600914C RID: 37196 RVA: 0x0027F120 File Offset: 0x0027D320
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AssociatedGameplayMarksIter()或GetAssociatedGameplayMarksBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AssociatedGameplayMarks()
		{
			MapMark mapMark = this;
			return mapMark.GetAssociatedGameplayMarksArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x0027F144 File Offset: 0x0027D344
		[NullableContext(1)]
		public readonly IEnumerable<int> AssociatedGameplayMarksIter()
		{
			MapMark.<AssociatedGameplayMarksIter>d__125 <AssociatedGameplayMarksIter>d__ = new MapMark.<AssociatedGameplayMarksIter>d__125(-2);
			<AssociatedGameplayMarksIter>d__.<>3__<>4__this = this;
			return <AssociatedGameplayMarksIter>d__;
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x0027F15C File Offset: 0x0027D35C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConnetMultiMapFloorIdIter()或GetConnetMultiMapFloorIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConnetMultiMapFloorId()
		{
			MapMark mapMark = this;
			return mapMark.GetConnetMultiMapFloorIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x0027F180 File Offset: 0x0027D380
		[NullableContext(1)]
		public readonly IEnumerable<int> ConnetMultiMapFloorIdIter()
		{
			MapMark.<ConnetMultiMapFloorIdIter>d__127 <ConnetMultiMapFloorIdIter>d__ = new MapMark.<ConnetMultiMapFloorIdIter>d__127(-2);
			<ConnetMultiMapFloorIdIter>d__.<>3__<>4__this = this;
			return <ConnetMultiMapFloorIdIter>d__;
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x0027F198 File Offset: 0x0027D398
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DeliveryPropFrozenDict()缓存字典，遍历请使用DeliveryPropIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DeliveryProp()
		{
			return this.DeliveryPropIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009151 RID: 37201 RVA: 0x0027F1EE File Offset: 0x0027D3EE
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DeliveryPropIter()
		{
			MapMark.<DeliveryPropIter>d__129 <DeliveryPropIter>d__ = new MapMark.<DeliveryPropIter>d__129(-2);
			<DeliveryPropIter>d__.<>3__<>4__this = this;
			return <DeliveryPropIter>d__;
		}

		// Token: 0x06009152 RID: 37202 RVA: 0x0027F204 File Offset: 0x0027D404
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowRangeIter()或GetShowRangeBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowRange()
		{
			MapMark mapMark = this;
			return mapMark.GetShowRangeArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009153 RID: 37203 RVA: 0x0027F228 File Offset: 0x0027D428
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowRangeIter()
		{
			MapMark.<ShowRangeIter>d__131 <ShowRangeIter>d__ = new MapMark.<ShowRangeIter>d__131(-2);
			<ShowRangeIter>d__.<>3__<>4__this = this;
			return <ShowRangeIter>d__;
		}

		// Token: 0x06009154 RID: 37204 RVA: 0x0027F240 File Offset: 0x0027D440
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TreasureChestCountTargetIter()或GetTreasureChestCountTargetBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TreasureChestCountTarget()
		{
			MapMark mapMark = this;
			return mapMark.GetTreasureChestCountTargetArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009155 RID: 37205 RVA: 0x0027F264 File Offset: 0x0027D464
		[NullableContext(1)]
		public readonly IEnumerable<int> TreasureChestCountTargetIter()
		{
			MapMark.<TreasureChestCountTargetIter>d__133 <TreasureChestCountTargetIter>d__ = new MapMark.<TreasureChestCountTargetIter>d__133(-2);
			<TreasureChestCountTargetIter>d__.<>3__<>4__this = this;
			return <TreasureChestCountTargetIter>d__;
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x0027F27C File Offset: 0x0027D47C
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

		// Token: 0x06009157 RID: 37207 RVA: 0x0027F2B0 File Offset: 0x0027D4B0
		private void EnsureDeliveryPropCacheIfNeeded()
		{
			if (this.DeliveryPropCache != null)
			{
				return;
			}
			this.DeliveryPropCache = this.DeliveryPropIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009158 RID: 37208 RVA: 0x0027F316 File Offset: 0x0027D516
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDeliveryPropFrozenDict(int key)
		{
			this.EnsureDeliveryPropCacheIfNeeded();
			return this.DeliveryPropCache;
		}

		// Token: 0x04004E8A RID: 20106
		private Table __p;

		// Token: 0x04004E8B RID: 20107
		[Nullable(2)]
		private FrozenDictionary<int, int> DeliveryPropCache;
	}
}
