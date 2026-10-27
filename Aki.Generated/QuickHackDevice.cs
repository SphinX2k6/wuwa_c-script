using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F81 RID: 3969
	public struct QuickHackDevice : IFlatbufferObject
	{
		// Token: 0x17002C54 RID: 11348
		// (get) Token: 0x0600B758 RID: 46936 RVA: 0x002D37A1 File Offset: 0x002D19A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B759 RID: 46937 RVA: 0x002D37AE File Offset: 0x002D19AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B75A RID: 46938 RVA: 0x002D37B8 File Offset: 0x002D19B8
		public static QuickHackDevice GetRootAsQuickHackDevice(ByteBuffer _bb)
		{
			return QuickHackDevice.GetRootAsQuickHackDevice(_bb, default(QuickHackDevice));
		}

		// Token: 0x0600B75B RID: 46939 RVA: 0x002D37D4 File Offset: 0x002D19D4
		public static QuickHackDevice GetRootAsQuickHackDevice(ByteBuffer _bb, QuickHackDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B75C RID: 46940 RVA: 0x002D37F1 File Offset: 0x002D19F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B75D RID: 46941 RVA: 0x002D3800 File Offset: 0x002D1A00
		public QuickHackDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C55 RID: 11349
		// (get) Token: 0x0600B75E RID: 46942 RVA: 0x002D3810 File Offset: 0x002D1A10
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

		// Token: 0x0600B75F RID: 46943 RVA: 0x002D384C File Offset: 0x002D1A4C
		public int SkillIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C56 RID: 11350
		// (get) Token: 0x0600B760 RID: 46944 RVA: 0x002D388C File Offset: 0x002D1A8C
		public int SkillIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B761 RID: 46945 RVA: 0x002D38B7 File Offset: 0x002D1AB7
		public Span<int> GetSkillIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600B762 RID: 46946 RVA: 0x002D38C6 File Offset: 0x002D1AC6
		public int[] GetSkillIdsArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17002C57 RID: 11351
		// (get) Token: 0x0600B763 RID: 46947 RVA: 0x002D38E0 File Offset: 0x002D1AE0
		public bool RefreshSkillListByTarget
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C58 RID: 11352
		// (get) Token: 0x0600B764 RID: 46948 RVA: 0x002D3920 File Offset: 0x002D1B20
		public int TargetSelectType
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

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x0600B765 RID: 46949 RVA: 0x002D3960 File Offset: 0x002D1B60
		public int TargetSelectMaxDistance
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 2000;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C5A RID: 11354
		// (get) Token: 0x0600B766 RID: 46950 RVA: 0x002D39A4 File Offset: 0x002D1BA4
		public int TargetScreenRadius
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B767 RID: 46951 RVA: 0x002D39E4 File Offset: 0x002D1BE4
		public long OnScreenTargetGameplayCueIds(int j)
		{
			int num = this.__p.__offset(16);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002C5B RID: 11355
		// (get) Token: 0x0600B768 RID: 46952 RVA: 0x002D3A30 File Offset: 0x002D1C30
		public int OnScreenTargetGameplayCueIdsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B769 RID: 46953 RVA: 0x002D3A5C File Offset: 0x002D1C5C
		public Span<long> GetOnScreenTargetGameplayCueIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(16, 8));
		}

		// Token: 0x0600B76A RID: 46954 RVA: 0x002D3A71 File Offset: 0x002D1C71
		public long[] GetOnScreenTargetGameplayCueIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(16) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x002D3AB0 File Offset: 0x002D1CB0
		public long TargetGameplayCueIds(int j)
		{
			int num = this.__p.__offset(18);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002C5C RID: 11356
		// (get) Token: 0x0600B76C RID: 46956 RVA: 0x002D3AFC File Offset: 0x002D1CFC
		public int TargetGameplayCueIdsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x002D3B28 File Offset: 0x002D1D28
		public Span<long> GetTargetGameplayCueIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(18, 8));
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x002D3B3D File Offset: 0x002D1D3D
		public long[] GetTargetGameplayCueIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(18) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0600B76F RID: 46959 RVA: 0x002D3B7C File Offset: 0x002D1D7C
		public string OnScreenTargetTag
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

		// Token: 0x0600B770 RID: 46960 RVA: 0x002D3BB4 File Offset: 0x002D1DB4
		public Span<byte> GetOnScreenTargetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x002D3BC4 File Offset: 0x002D1DC4
		public byte[] GetOnScreenTargetTagArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x002D3BDC File Offset: 0x002D1DDC
		public string SelectTargetTag
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

		// Token: 0x0600B773 RID: 46963 RVA: 0x002D3C14 File Offset: 0x002D1E14
		public Span<byte> GetSelectTargetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B774 RID: 46964 RVA: 0x002D3C24 File Offset: 0x002D1E24
		public byte[] GetSelectTargetTagArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x0600B775 RID: 46965 RVA: 0x002D3C3C File Offset: 0x002D1E3C
		public int RamResourceType
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

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x0600B776 RID: 46966 RVA: 0x002D3C7C File Offset: 0x002D1E7C
		public int RamResourceParam
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

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x0600B777 RID: 46967 RVA: 0x002D3CBC File Offset: 0x002D1EBC
		public int TimeScaleMode
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

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x0600B778 RID: 46968 RVA: 0x002D3CFC File Offset: 0x002D1EFC
		public int TimeScaleDuration
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0600B779 RID: 46969 RVA: 0x002D3D3C File Offset: 0x002D1F3C
		public float TimeDilation
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 1f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0600B77A RID: 46970 RVA: 0x002D3D80 File Offset: 0x002D1F80
		public bool FirstPersonCamera
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C65 RID: 11365
		// (get) Token: 0x0600B77B RID: 46971 RVA: 0x002D3DC0 File Offset: 0x002D1FC0
		public int DurationLimit
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

		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x0600B77C RID: 46972 RVA: 0x002D3E00 File Offset: 0x002D2000
		public int UiType
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

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x0600B77D RID: 46973 RVA: 0x002D3E40 File Offset: 0x002D2040
		public int SkillEffectiveTargetSize
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x0600B77E RID: 46974 RVA: 0x002D3E80 File Offset: 0x002D2080
		public bool UseTargetHighlightCondition
		{
			get
			{
				int num = this.__p.__offset(42);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x0600B77F RID: 46975 RVA: 0x002D3EC0 File Offset: 0x002D20C0
		public bool OpenMonsterHackMark
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B780 RID: 46976 RVA: 0x002D3F00 File Offset: 0x002D2100
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OnScreenTargetGameplayCueIdsIter()或GetOnScreenTargetGameplayCueIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] OnScreenTargetGameplayCueIds()
		{
			QuickHackDevice quickHackDevice = this;
			return quickHackDevice.GetOnScreenTargetGameplayCueIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600B781 RID: 46977 RVA: 0x002D3F24 File Offset: 0x002D2124
		[NullableContext(1)]
		public readonly IEnumerable<long> OnScreenTargetGameplayCueIdsIter()
		{
			QuickHackDevice.<OnScreenTargetGameplayCueIdsIter>d__64 <OnScreenTargetGameplayCueIdsIter>d__ = new QuickHackDevice.<OnScreenTargetGameplayCueIdsIter>d__64(-2);
			<OnScreenTargetGameplayCueIdsIter>d__.<>3__<>4__this = this;
			return <OnScreenTargetGameplayCueIdsIter>d__;
		}

		// Token: 0x0600B782 RID: 46978 RVA: 0x002D3F3C File Offset: 0x002D213C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIdsIter()或GetSkillIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIds()
		{
			QuickHackDevice quickHackDevice = this;
			return quickHackDevice.GetSkillIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B783 RID: 46979 RVA: 0x002D3F60 File Offset: 0x002D2160
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIdsIter()
		{
			QuickHackDevice.<SkillIdsIter>d__66 <SkillIdsIter>d__ = new QuickHackDevice.<SkillIdsIter>d__66(-2);
			<SkillIdsIter>d__.<>3__<>4__this = this;
			return <SkillIdsIter>d__;
		}

		// Token: 0x0600B784 RID: 46980 RVA: 0x002D3F78 File Offset: 0x002D2178
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetGameplayCueIdsIter()或GetTargetGameplayCueIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] TargetGameplayCueIds()
		{
			QuickHackDevice quickHackDevice = this;
			return quickHackDevice.GetTargetGameplayCueIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600B785 RID: 46981 RVA: 0x002D3F9C File Offset: 0x002D219C
		[NullableContext(1)]
		public readonly IEnumerable<long> TargetGameplayCueIdsIter()
		{
			QuickHackDevice.<TargetGameplayCueIdsIter>d__68 <TargetGameplayCueIdsIter>d__ = new QuickHackDevice.<TargetGameplayCueIdsIter>d__68(-2);
			<TargetGameplayCueIdsIter>d__.<>3__<>4__this = this;
			return <TargetGameplayCueIdsIter>d__;
		}

		// Token: 0x0400504F RID: 20559
		private Table __p;
	}
}
