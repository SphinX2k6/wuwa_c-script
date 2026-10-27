using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200119C RID: 4508
	public struct WeaponSkin : IFlatbufferObject
	{
		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600E841 RID: 59457 RVA: 0x003436FD File Offset: 0x003418FD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600E842 RID: 59458 RVA: 0x0034370A File Offset: 0x0034190A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600E843 RID: 59459 RVA: 0x00343714 File Offset: 0x00341914
		public static WeaponSkin GetRootAsWeaponSkin(ByteBuffer _bb)
		{
			return WeaponSkin.GetRootAsWeaponSkin(_bb, default(WeaponSkin));
		}

		// Token: 0x0600E844 RID: 59460 RVA: 0x00343730 File Offset: 0x00341930
		public static WeaponSkin GetRootAsWeaponSkin(ByteBuffer _bb, WeaponSkin obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600E845 RID: 59461 RVA: 0x0034374D File Offset: 0x0034194D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600E846 RID: 59462 RVA: 0x0034375C File Offset: 0x0034195C
		public WeaponSkin __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600E847 RID: 59463 RVA: 0x0034376C File Offset: 0x0034196C
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

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600E848 RID: 59464 RVA: 0x003437A8 File Offset: 0x003419A8
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600E849 RID: 59465 RVA: 0x003437E8 File Offset: 0x003419E8
		public int WeaponSkinType
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

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600E84A RID: 59466 RVA: 0x00343824 File Offset: 0x00341A24
		public string Name
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

		// Token: 0x0600E84B RID: 59467 RVA: 0x0034385C File Offset: 0x00341A5C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600E84C RID: 59468 RVA: 0x0034386C File Offset: 0x00341A6C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600E84D RID: 59469 RVA: 0x00343884 File Offset: 0x00341A84
		public bool HideInSkinView
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600E84E RID: 59470 RVA: 0x003438C4 File Offset: 0x00341AC4
		public int QualityId
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

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0600E84F RID: 59471 RVA: 0x00343904 File Offset: 0x00341B04
		public int ModelId
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

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600E850 RID: 59472 RVA: 0x00343944 File Offset: 0x00341B44
		public int TransformId
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

		// Token: 0x0600E851 RID: 59473 RVA: 0x00343984 File Offset: 0x00341B84
		public int Models(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600E852 RID: 59474 RVA: 0x003439C4 File Offset: 0x00341BC4
		public int ModelsLength
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

		// Token: 0x0600E853 RID: 59475 RVA: 0x003439F0 File Offset: 0x00341BF0
		public Span<int> GetModelsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600E854 RID: 59476 RVA: 0x00343A00 File Offset: 0x00341C00
		public int[] GetModelsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600E855 RID: 59477 RVA: 0x00343A18 File Offset: 0x00341C18
		public int ModelsIndex(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600E856 RID: 59478 RVA: 0x00343A58 File Offset: 0x00341C58
		public int ModelsIndexLength
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

		// Token: 0x0600E857 RID: 59479 RVA: 0x00343A84 File Offset: 0x00341C84
		public Span<int> GetModelsIndexBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600E858 RID: 59480 RVA: 0x00343A94 File Offset: 0x00341C94
		public int[] GetModelsIndexArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600E859 RID: 59481 RVA: 0x00343AAC File Offset: 0x00341CAC
		public long Effect(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600E85A RID: 59482 RVA: 0x00343AF8 File Offset: 0x00341CF8
		public int EffectLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E85B RID: 59483 RVA: 0x00343B24 File Offset: 0x00341D24
		public Span<long> GetEffectBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x0600E85C RID: 59484 RVA: 0x00343B39 File Offset: 0x00341D39
		public long[] GetEffectArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600E85D RID: 59485 RVA: 0x00343B78 File Offset: 0x00341D78
		public string StandAnim(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600E85E RID: 59486 RVA: 0x00343BB4 File Offset: 0x00341DB4
		public int StandAnimLength
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

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600E85F RID: 59487 RVA: 0x00343BE0 File Offset: 0x00341DE0
		public string TypeDescription
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E860 RID: 59488 RVA: 0x00343C18 File Offset: 0x00341E18
		public Span<byte> GetTypeDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600E861 RID: 59489 RVA: 0x00343C28 File Offset: 0x00341E28
		public byte[] GetTypeDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600E862 RID: 59490 RVA: 0x00343C40 File Offset: 0x00341E40
		public string AttributesDescription
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E863 RID: 59491 RVA: 0x00343C78 File Offset: 0x00341E78
		public Span<byte> GetAttributesDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600E864 RID: 59492 RVA: 0x00343C88 File Offset: 0x00341E88
		public byte[] GetAttributesDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0600E865 RID: 59493 RVA: 0x00343CA0 File Offset: 0x00341EA0
		public string BgDescription
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E866 RID: 59494 RVA: 0x00343CD8 File Offset: 0x00341ED8
		public Span<byte> GetBgDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600E867 RID: 59495 RVA: 0x00343CE8 File Offset: 0x00341EE8
		public byte[] GetBgDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0600E868 RID: 59496 RVA: 0x00343D00 File Offset: 0x00341F00
		public string CardIconPath
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x00343D38 File Offset: 0x00341F38
		public Span<byte> GetCardIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x00343D48 File Offset: 0x00341F48
		public byte[] GetCardIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0600E86B RID: 59499 RVA: 0x00343D60 File Offset: 0x00341F60
		public string Icon
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

		// Token: 0x0600E86C RID: 59500 RVA: 0x00343D98 File Offset: 0x00341F98
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600E86D RID: 59501 RVA: 0x00343DA8 File Offset: 0x00341FA8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0600E86E RID: 59502 RVA: 0x00343DC0 File Offset: 0x00341FC0
		public string IconMiddle
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E86F RID: 59503 RVA: 0x00343DF8 File Offset: 0x00341FF8
		public Span<byte> GetIconMiddleBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600E870 RID: 59504 RVA: 0x00343E08 File Offset: 0x00342008
		public byte[] GetIconMiddleArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0600E871 RID: 59505 RVA: 0x00343E20 File Offset: 0x00342020
		public string IconSmall
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

		// Token: 0x0600E872 RID: 59506 RVA: 0x00343E58 File Offset: 0x00342058
		public Span<byte> GetIconSmallBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600E873 RID: 59507 RVA: 0x00343E68 File Offset: 0x00342068
		public byte[] GetIconSmallArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0600E874 RID: 59508 RVA: 0x00343E80 File Offset: 0x00342080
		public string Mesh
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

		// Token: 0x0600E875 RID: 59509 RVA: 0x00343EB8 File Offset: 0x003420B8
		public Span<byte> GetMeshBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x0600E876 RID: 59510 RVA: 0x00343EC8 File Offset: 0x003420C8
		public byte[] GetMeshArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x0600E877 RID: 59511 RVA: 0x00343EE0 File Offset: 0x003420E0
		public int MaxCapcity
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 99;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E878 RID: 59512 RVA: 0x00343F20 File Offset: 0x00342120
		public int ItemAccess(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x0600E879 RID: 59513 RVA: 0x00343F60 File Offset: 0x00342160
		public int ItemAccessLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600E87A RID: 59514 RVA: 0x00343F8C File Offset: 0x0034218C
		public Span<int> GetItemAccessBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x0600E87B RID: 59515 RVA: 0x00343F9C File Offset: 0x0034219C
		public int[] GetItemAccessArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x0600E87C RID: 59516 RVA: 0x00343FB4 File Offset: 0x003421B4
		public int ObtainedShow
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

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x0600E87D RID: 59517 RVA: 0x00343FF4 File Offset: 0x003421F4
		public string ObtainedShowDescription
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E87E RID: 59518 RVA: 0x0034402C File Offset: 0x0034222C
		public Span<byte> GetObtainedShowDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x0600E87F RID: 59519 RVA: 0x0034403C File Offset: 0x0034223C
		public byte[] GetObtainedShowDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x00344054 File Offset: 0x00342254
		public int NumLimit
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

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0600E881 RID: 59521 RVA: 0x00344094 File Offset: 0x00342294
		public bool ShowInBag
		{
			get
			{
				int num = this.__p.__offset(54);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0600E882 RID: 59522 RVA: 0x003440D4 File Offset: 0x003422D4
		public int SortIndex
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

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600E883 RID: 59523 RVA: 0x00344114 File Offset: 0x00342314
		public float HiddenTime
		{
			get
			{
				int num = this.__p.__offset(58);
				if (num == 0)
				{
					return 10f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x0600E884 RID: 59524 RVA: 0x00344158 File Offset: 0x00342358
		public bool Destructible
		{
			get
			{
				int num = this.__p.__offset(60);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x0600E885 RID: 59525 RVA: 0x00344198 File Offset: 0x00342398
		public int RedDotDisableRule
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

		// Token: 0x17003E34 RID: 15924
		// (get) Token: 0x0600E886 RID: 59526 RVA: 0x003441D8 File Offset: 0x003423D8
		public int HandBookTrialId
		{
			get
			{
				int num = this.__p.__offset(64);
				if (num == 0)
				{
					return 21110501;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600E887 RID: 59527 RVA: 0x0034421C File Offset: 0x0034241C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectIter()或GetEffectBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] Effect()
		{
			WeaponSkin weaponSkin = this;
			return weaponSkin.GetEffectArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600E888 RID: 59528 RVA: 0x00344240 File Offset: 0x00342440
		[NullableContext(1)]
		public readonly IEnumerable<long> EffectIter()
		{
			WeaponSkin.<EffectIter>d__104 <EffectIter>d__ = new WeaponSkin.<EffectIter>d__104(-2);
			<EffectIter>d__.<>3__<>4__this = this;
			return <EffectIter>d__;
		}

		// Token: 0x0600E889 RID: 59529 RVA: 0x00344258 File Offset: 0x00342458
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ItemAccessIter()或GetItemAccessBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ItemAccess()
		{
			WeaponSkin weaponSkin = this;
			return weaponSkin.GetItemAccessArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E88A RID: 59530 RVA: 0x0034427C File Offset: 0x0034247C
		[NullableContext(1)]
		public readonly IEnumerable<int> ItemAccessIter()
		{
			WeaponSkin.<ItemAccessIter>d__106 <ItemAccessIter>d__ = new WeaponSkin.<ItemAccessIter>d__106(-2);
			<ItemAccessIter>d__.<>3__<>4__this = this;
			return <ItemAccessIter>d__;
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x00344294 File Offset: 0x00342494
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ModelsIter()或GetModelsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Models()
		{
			WeaponSkin weaponSkin = this;
			return weaponSkin.GetModelsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E88C RID: 59532 RVA: 0x003442B8 File Offset: 0x003424B8
		[NullableContext(1)]
		public readonly IEnumerable<int> ModelsIter()
		{
			WeaponSkin.<ModelsIter>d__108 <ModelsIter>d__ = new WeaponSkin.<ModelsIter>d__108(-2);
			<ModelsIter>d__.<>3__<>4__this = this;
			return <ModelsIter>d__;
		}

		// Token: 0x0600E88D RID: 59533 RVA: 0x003442D0 File Offset: 0x003424D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ModelsIndexIter()或GetModelsIndexBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ModelsIndex()
		{
			WeaponSkin weaponSkin = this;
			return weaponSkin.GetModelsIndexArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600E88E RID: 59534 RVA: 0x003442F4 File Offset: 0x003424F4
		[NullableContext(1)]
		public readonly IEnumerable<int> ModelsIndexIter()
		{
			WeaponSkin.<ModelsIndexIter>d__110 <ModelsIndexIter>d__ = new WeaponSkin.<ModelsIndexIter>d__110(-2);
			<ModelsIndexIter>d__.<>3__<>4__this = this;
			return <ModelsIndexIter>d__;
		}

		// Token: 0x0600E88F RID: 59535 RVA: 0x00344309 File Offset: 0x00342509
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StandAnimIter()或GetStandAnimBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] StandAnim()
		{
			return this.StandAnimIter().ToArray<string>();
		}

		// Token: 0x0600E890 RID: 59536 RVA: 0x00344316 File Offset: 0x00342516
		[NullableContext(1)]
		public readonly IEnumerable<string> StandAnimIter()
		{
			WeaponSkin.<StandAnimIter>d__112 <StandAnimIter>d__ = new WeaponSkin.<StandAnimIter>d__112(-2);
			<StandAnimIter>d__.<>3__<>4__this = this;
			return <StandAnimIter>d__;
		}

		// Token: 0x040052E7 RID: 21223
		private Table __p;
	}
}
