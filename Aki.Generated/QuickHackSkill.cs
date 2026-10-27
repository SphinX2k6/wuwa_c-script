using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F82 RID: 3970
	public struct QuickHackSkill : IFlatbufferObject
	{
		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x0600B786 RID: 46982 RVA: 0x002D3FB1 File Offset: 0x002D21B1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B787 RID: 46983 RVA: 0x002D3FBE File Offset: 0x002D21BE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B788 RID: 46984 RVA: 0x002D3FC8 File Offset: 0x002D21C8
		public static QuickHackSkill GetRootAsQuickHackSkill(ByteBuffer _bb)
		{
			return QuickHackSkill.GetRootAsQuickHackSkill(_bb, default(QuickHackSkill));
		}

		// Token: 0x0600B789 RID: 46985 RVA: 0x002D3FE4 File Offset: 0x002D21E4
		public static QuickHackSkill GetRootAsQuickHackSkill(ByteBuffer _bb, QuickHackSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B78A RID: 46986 RVA: 0x002D4001 File Offset: 0x002D2201
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x002D4010 File Offset: 0x002D2210
		public QuickHackSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x0600B78C RID: 46988 RVA: 0x002D4020 File Offset: 0x002D2220
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

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x0600B78D RID: 46989 RVA: 0x002D405C File Offset: 0x002D225C
		public string SkillName
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

		// Token: 0x0600B78E RID: 46990 RVA: 0x002D4093 File Offset: 0x002D2293
		public Span<byte> GetSkillNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x002D40A2 File Offset: 0x002D22A2
		public byte[] GetSkillNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0600B790 RID: 46992 RVA: 0x002D40BC File Offset: 0x002D22BC
		public string SkillDescribe
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

		// Token: 0x0600B791 RID: 46993 RVA: 0x002D40F3 File Offset: 0x002D22F3
		public Span<byte> GetSkillDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x002D4102 File Offset: 0x002D2302
		public byte[] GetSkillDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0600B793 RID: 46995 RVA: 0x002D411C File Offset: 0x002D231C
		public string SkillTag
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

		// Token: 0x0600B794 RID: 46996 RVA: 0x002D4154 File Offset: 0x002D2354
		public Span<byte> GetSkillTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B795 RID: 46997 RVA: 0x002D4164 File Offset: 0x002D2364
		public byte[] GetSkillTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0600B796 RID: 46998 RVA: 0x002D417C File Offset: 0x002D237C
		public string Icon
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

		// Token: 0x0600B797 RID: 46999 RVA: 0x002D41B4 File Offset: 0x002D23B4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B798 RID: 47000 RVA: 0x002D41C4 File Offset: 0x002D23C4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x0600B799 RID: 47001 RVA: 0x002D41DC File Offset: 0x002D23DC
		public int TargetType
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

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x0600B79A RID: 47002 RVA: 0x002D421C File Offset: 0x002D241C
		public int RamCost
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

		// Token: 0x0600B79B RID: 47003 RVA: 0x002D425C File Offset: 0x002D245C
		public long SelfBuffIds(int j)
		{
			int num = this.__p.__offset(18);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x0600B79C RID: 47004 RVA: 0x002D42A8 File Offset: 0x002D24A8
		public int SelfBuffIdsLength
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

		// Token: 0x0600B79D RID: 47005 RVA: 0x002D42D4 File Offset: 0x002D24D4
		public Span<long> GetSelfBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(18, 8));
		}

		// Token: 0x0600B79E RID: 47006 RVA: 0x002D42E9 File Offset: 0x002D24E9
		public long[] GetSelfBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(18) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600B79F RID: 47007 RVA: 0x002D4328 File Offset: 0x002D2528
		public long TargetBuffIds(int j)
		{
			int num = this.__p.__offset(20);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x0600B7A0 RID: 47008 RVA: 0x002D4374 File Offset: 0x002D2574
		public int TargetBuffIdsLength
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

		// Token: 0x0600B7A1 RID: 47009 RVA: 0x002D43A0 File Offset: 0x002D25A0
		public Span<long> GetTargetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(20, 8));
		}

		// Token: 0x0600B7A2 RID: 47010 RVA: 0x002D43B5 File Offset: 0x002D25B5
		public long[] GetTargetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(20) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x002D43F4 File Offset: 0x002D25F4
		public int UsageCount
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x0600B7A4 RID: 47012 RVA: 0x002D4434 File Offset: 0x002D2634
		public int Duration
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

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x002D4474 File Offset: 0x002D2674
		public int ExtraEffectList(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x0600B7A6 RID: 47014 RVA: 0x002D44B4 File Offset: 0x002D26B4
		public int ExtraEffectListLength
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

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x002D44E0 File Offset: 0x002D26E0
		public Span<int> GetExtraEffectListBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x002D44F0 File Offset: 0x002D26F0
		public int[] GetExtraEffectListArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x002D4508 File Offset: 0x002D2708
		public string ExtraConditionType
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

		// Token: 0x0600B7AA RID: 47018 RVA: 0x002D4540 File Offset: 0x002D2740
		public Span<byte> GetExtraConditionTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x002D4550 File Offset: 0x002D2750
		public byte[] GetExtraConditionTypeArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x002D4568 File Offset: 0x002D2768
		public string ExtraConditionParams(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x002D45A4 File Offset: 0x002D27A4
		public int ExtraConditionParamsLength
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

		// Token: 0x0600B7AE RID: 47022 RVA: 0x002D45D0 File Offset: 0x002D27D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraConditionParamsIter()或GetExtraConditionParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] ExtraConditionParams()
		{
			return this.ExtraConditionParamsIter().ToArray<string>();
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x002D45DD File Offset: 0x002D27DD
		[NullableContext(1)]
		public readonly IEnumerable<string> ExtraConditionParamsIter()
		{
			QuickHackSkill.<ExtraConditionParamsIter>d__57 <ExtraConditionParamsIter>d__ = new QuickHackSkill.<ExtraConditionParamsIter>d__57(-2);
			<ExtraConditionParamsIter>d__.<>3__<>4__this = this;
			return <ExtraConditionParamsIter>d__;
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x002D45F4 File Offset: 0x002D27F4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExtraEffectListIter()或GetExtraEffectListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExtraEffectList()
		{
			QuickHackSkill quickHackSkill = this;
			return quickHackSkill.GetExtraEffectListArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x002D4618 File Offset: 0x002D2818
		[NullableContext(1)]
		public readonly IEnumerable<int> ExtraEffectListIter()
		{
			QuickHackSkill.<ExtraEffectListIter>d__59 <ExtraEffectListIter>d__ = new QuickHackSkill.<ExtraEffectListIter>d__59(-2);
			<ExtraEffectListIter>d__.<>3__<>4__this = this;
			return <ExtraEffectListIter>d__;
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x002D4630 File Offset: 0x002D2830
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SelfBuffIdsIter()或GetSelfBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] SelfBuffIds()
		{
			QuickHackSkill quickHackSkill = this;
			return quickHackSkill.GetSelfBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x002D4654 File Offset: 0x002D2854
		[NullableContext(1)]
		public readonly IEnumerable<long> SelfBuffIdsIter()
		{
			QuickHackSkill.<SelfBuffIdsIter>d__61 <SelfBuffIdsIter>d__ = new QuickHackSkill.<SelfBuffIdsIter>d__61(-2);
			<SelfBuffIdsIter>d__.<>3__<>4__this = this;
			return <SelfBuffIdsIter>d__;
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x002D466C File Offset: 0x002D286C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TargetBuffIdsIter()或GetTargetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] TargetBuffIds()
		{
			QuickHackSkill quickHackSkill = this;
			return quickHackSkill.GetTargetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x002D4690 File Offset: 0x002D2890
		[NullableContext(1)]
		public readonly IEnumerable<long> TargetBuffIdsIter()
		{
			QuickHackSkill.<TargetBuffIdsIter>d__63 <TargetBuffIdsIter>d__ = new QuickHackSkill.<TargetBuffIdsIter>d__63(-2);
			<TargetBuffIdsIter>d__.<>3__<>4__this = this;
			return <TargetBuffIdsIter>d__;
		}

		// Token: 0x04005050 RID: 20560
		private Table __p;
	}
}
