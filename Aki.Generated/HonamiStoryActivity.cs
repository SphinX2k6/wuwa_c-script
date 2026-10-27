using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D2D RID: 3373
	public struct HonamiStoryActivity : IFlatbufferObject
	{
		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06007EA1 RID: 32417 RVA: 0x0025447D File Offset: 0x0025267D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x0025448A File Offset: 0x0025268A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x00254494 File Offset: 0x00252694
		public static HonamiStoryActivity GetRootAsHonamiStoryActivity(ByteBuffer _bb)
		{
			return HonamiStoryActivity.GetRootAsHonamiStoryActivity(_bb, default(HonamiStoryActivity));
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x002544B0 File Offset: 0x002526B0
		public static HonamiStoryActivity GetRootAsHonamiStoryActivity(ByteBuffer _bb, HonamiStoryActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x002544CD File Offset: 0x002526CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x002544DC File Offset: 0x002526DC
		public HonamiStoryActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06007EA7 RID: 32423 RVA: 0x002544EC File Offset: 0x002526EC
		public int ActivityId
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

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06007EA8 RID: 32424 RVA: 0x00254528 File Offset: 0x00252728
		public int LimitTime
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

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06007EA9 RID: 32425 RVA: 0x00254564 File Offset: 0x00252764
		public int LimitShopItemId
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

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x002545A0 File Offset: 0x002527A0
		public int LimitShopItemMax
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

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06007EAB RID: 32427 RVA: 0x002545E0 File Offset: 0x002527E0
		public int ScoreItemId
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

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06007EAC RID: 32428 RVA: 0x00254620 File Offset: 0x00252820
		public int OutCoinItemId
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

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06007EAD RID: 32429 RVA: 0x00254660 File Offset: 0x00252860
		public int InnerItemId
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

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06007EAE RID: 32430 RVA: 0x002546A0 File Offset: 0x002528A0
		public int FailLeaveCoinRatio
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

		// Token: 0x06007EAF RID: 32431 RVA: 0x002546E0 File Offset: 0x002528E0
		public int MainLineInstId(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06007EB0 RID: 32432 RVA: 0x00254720 File Offset: 0x00252920
		public int MainLineInstIdLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x0025474C File Offset: 0x0025294C
		public Span<int> GetMainLineInstIdBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x0025475C File Offset: 0x0025295C
		public int[] GetMainLineInstIdArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x00254774 File Offset: 0x00252974
		public DicIntInt? MainLineInstIdUnlock(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06007EB4 RID: 32436 RVA: 0x002547D8 File Offset: 0x002529D8
		public int MainLineInstIdUnlockLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06007EB5 RID: 32437 RVA: 0x00254804 File Offset: 0x00252A04
		public int AreaInstId
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

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x00254844 File Offset: 0x00252A44
		public int OriAreaDangerLevel
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

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06007EB7 RID: 32439 RVA: 0x00254884 File Offset: 0x00252A84
		public int MaxAreaDangerLevel
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

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x06007EB8 RID: 32440 RVA: 0x002548C4 File Offset: 0x00252AC4
		public int TopTowerInstId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x00254904 File Offset: 0x00252B04
		public int OriTopTowerDangerLevel
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

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06007EBA RID: 32442 RVA: 0x00254944 File Offset: 0x00252B44
		public int MaxTopTowerDangerLevel
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

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06007EBB RID: 32443 RVA: 0x00254984 File Offset: 0x00252B84
		public string TopTowerVarName
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x002549BC File Offset: 0x00252BBC
		public Span<byte> GetTopTowerVarNameBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x06007EBD RID: 32445 RVA: 0x002549CC File Offset: 0x00252BCC
		public byte[] GetTopTowerVarNameArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06007EBE RID: 32446 RVA: 0x002549E4 File Offset: 0x00252BE4
		public int LimitShopId
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

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06007EBF RID: 32447 RVA: 0x00254A24 File Offset: 0x00252C24
		public int ShopId
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

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x00254A64 File Offset: 0x00252C64
		public int BottomWeaponLevel
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

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06007EC1 RID: 32449 RVA: 0x00254AA4 File Offset: 0x00252CA4
		public int BottomRoleLevel
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06007EC2 RID: 32450 RVA: 0x00254AE4 File Offset: 0x00252CE4
		public int BottomSkillLevel
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x00254B24 File Offset: 0x00252D24
		public int TalentFuncId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x06007EC4 RID: 32452 RVA: 0x00254B64 File Offset: 0x00252D64
		public int MascotFuncId
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

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x06007EC5 RID: 32453 RVA: 0x00254BA4 File Offset: 0x00252DA4
		public int ItemCollectionFuncId
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

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x00254BE4 File Offset: 0x00252DE4
		public int SafeLeaveBuyFuncId
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x06007EC7 RID: 32455 RVA: 0x00254C24 File Offset: 0x00252E24
		public int LifeSupportFuncId
		{
			get
			{
				int num = this.__p.__offset(56);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x06007EC8 RID: 32456 RVA: 0x00254C64 File Offset: 0x00252E64
		public int LifeSupportUpFuncId
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x06007EC9 RID: 32457 RVA: 0x00254CA4 File Offset: 0x00252EA4
		public int EnhanceLevelFuncId
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

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06007ECA RID: 32458 RVA: 0x00254CE4 File Offset: 0x00252EE4
		public int AreaTaskFuncId
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

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06007ECB RID: 32459 RVA: 0x00254D24 File Offset: 0x00252F24
		public int EquipRoleFuncId
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06007ECC RID: 32460 RVA: 0x00254D64 File Offset: 0x00252F64
		public int EquipWeaponFuncId
		{
			get
			{
				int num = this.__p.__offset(66);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x06007ECD RID: 32461 RVA: 0x00254DA4 File Offset: 0x00252FA4
		public int PreparationFuncId
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

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x06007ECE RID: 32462 RVA: 0x00254DE4 File Offset: 0x00252FE4
		public int PollutionFuncId
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

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x06007ECF RID: 32463 RVA: 0x00254E24 File Offset: 0x00253024
		public int ChangeDangerFuncId
		{
			get
			{
				int num = this.__p.__offset(72);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06007ED0 RID: 32464 RVA: 0x00254E64 File Offset: 0x00253064
		public int LvSelectOpenFuncId
		{
			get
			{
				int num = this.__p.__offset(74);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06007ED1 RID: 32465 RVA: 0x00254EA4 File Offset: 0x002530A4
		public int TowerOpenFuncId
		{
			get
			{
				int num = this.__p.__offset(76);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x00254EE4 File Offset: 0x002530E4
		public string TowerName
		{
			get
			{
				int num = this.__p.__offset(78);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007ED3 RID: 32467 RVA: 0x00254F1C File Offset: 0x0025311C
		public Span<byte> GetTowerNameBytes()
		{
			return this.__p.__vector_as_span<byte>(78, 1);
		}

		// Token: 0x06007ED4 RID: 32468 RVA: 0x00254F2C File Offset: 0x0025312C
		public byte[] GetTowerNameArray()
		{
			return this.__p.__vector_as_array<byte>(78) ?? Array.Empty<byte>();
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06007ED5 RID: 32469 RVA: 0x00254F44 File Offset: 0x00253144
		public int ShopFuncId
		{
			get
			{
				int num = this.__p.__offset(80);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06007ED6 RID: 32470 RVA: 0x00254F84 File Offset: 0x00253184
		public int HelpId
		{
			get
			{
				int num = this.__p.__offset(82);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06007ED7 RID: 32471 RVA: 0x00254FC4 File Offset: 0x002531C4
		public int MarkId
		{
			get
			{
				int num = this.__p.__offset(84);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06007ED8 RID: 32472 RVA: 0x00255004 File Offset: 0x00253204
		public int MainQuestId
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

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06007ED9 RID: 32473 RVA: 0x00255044 File Offset: 0x00253244
		public int MainDropQuality
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

		// Token: 0x06007EDA RID: 32474 RVA: 0x00255084 File Offset: 0x00253284
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用MainLineInstIdIter()或GetMainLineInstIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] MainLineInstId()
		{
			HonamiStoryActivity honamiStoryActivity = this;
			return honamiStoryActivity.GetMainLineInstIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007EDB RID: 32475 RVA: 0x002550A8 File Offset: 0x002532A8
		[NullableContext(1)]
		public readonly IEnumerable<int> MainLineInstIdIter()
		{
			HonamiStoryActivity.<MainLineInstIdIter>d__103 <MainLineInstIdIter>d__ = new HonamiStoryActivity.<MainLineInstIdIter>d__103(-2);
			<MainLineInstIdIter>d__.<>3__<>4__this = this;
			return <MainLineInstIdIter>d__;
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x002550C0 File Offset: 0x002532C0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用MainLineInstIdUnlockFrozenDict()缓存字典，遍历请使用MainLineInstIdUnlockIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> MainLineInstIdUnlock()
		{
			return this.MainLineInstIdUnlockIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x00255116 File Offset: 0x00253316
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> MainLineInstIdUnlockIter()
		{
			HonamiStoryActivity.<MainLineInstIdUnlockIter>d__105 <MainLineInstIdUnlockIter>d__ = new HonamiStoryActivity.<MainLineInstIdUnlockIter>d__105(-2);
			<MainLineInstIdUnlockIter>d__.<>3__<>4__this = this;
			return <MainLineInstIdUnlockIter>d__;
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x0025512C File Offset: 0x0025332C
		public int? GetMainLineInstIdUnlock(int key)
		{
			this.EnsureMainLineInstIdUnlockCacheIfNeeded();
			int value;
			if (!this.MainLineInstIdUnlockCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x00255160 File Offset: 0x00253360
		private void EnsureMainLineInstIdUnlockCacheIfNeeded()
		{
			if (this.MainLineInstIdUnlockCache != null)
			{
				return;
			}
			this.MainLineInstIdUnlockCache = this.MainLineInstIdUnlockIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x002551C6 File Offset: 0x002533C6
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetMainLineInstIdUnlockFrozenDict(int key)
		{
			this.EnsureMainLineInstIdUnlockCacheIfNeeded();
			return this.MainLineInstIdUnlockCache;
		}

		// Token: 0x04004DA5 RID: 19877
		private Table __p;

		// Token: 0x04004DA6 RID: 19878
		[Nullable(2)]
		private FrozenDictionary<int, int> MainLineInstIdUnlockCache;
	}
}
