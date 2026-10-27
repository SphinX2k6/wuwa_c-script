using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF9 RID: 3833
	public struct PhantomSkill : IFlatbufferObject
	{
		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x0600AA40 RID: 43584 RVA: 0x002B703D File Offset: 0x002B523D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600AA41 RID: 43585 RVA: 0x002B704A File Offset: 0x002B524A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600AA42 RID: 43586 RVA: 0x002B7054 File Offset: 0x002B5254
		public static PhantomSkill GetRootAsPhantomSkill(ByteBuffer _bb)
		{
			return PhantomSkill.GetRootAsPhantomSkill(_bb, default(PhantomSkill));
		}

		// Token: 0x0600AA43 RID: 43587 RVA: 0x002B7070 File Offset: 0x002B5270
		public static PhantomSkill GetRootAsPhantomSkill(ByteBuffer _bb, PhantomSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600AA44 RID: 43588 RVA: 0x002B708D File Offset: 0x002B528D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600AA45 RID: 43589 RVA: 0x002B709C File Offset: 0x002B529C
		public PhantomSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x0600AA46 RID: 43590 RVA: 0x002B70AC File Offset: 0x002B52AC
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

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x0600AA47 RID: 43591 RVA: 0x002B70E8 File Offset: 0x002B52E8
		public int PhantomSkillId
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

		// Token: 0x0600AA48 RID: 43592 RVA: 0x002B7124 File Offset: 0x002B5324
		public long BuffIds(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x0600AA49 RID: 43593 RVA: 0x002B7170 File Offset: 0x002B5370
		public int BuffIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x002B719B File Offset: 0x002B539B
		public Span<long> GetBuffIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x002B71AF File Offset: 0x002B53AF
		public long[] GetBuffIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600AA4C RID: 43596 RVA: 0x002B71EC File Offset: 0x002B53EC
		public long SettleIds(int j)
		{
			int num = this.__p.__offset(10);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x0600AA4D RID: 43597 RVA: 0x002B7238 File Offset: 0x002B5438
		public int SettleIdsLength
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

		// Token: 0x0600AA4E RID: 43598 RVA: 0x002B7264 File Offset: 0x002B5464
		public Span<long> GetSettleIdsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(10, 8));
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x002B7279 File Offset: 0x002B5479
		public long[] GetSettleIdsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(10) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x002B72B8 File Offset: 0x002B54B8
		public long BuffEffects(int j)
		{
			int num = this.__p.__offset(12);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x0600AA51 RID: 43601 RVA: 0x002B7304 File Offset: 0x002B5504
		public int BuffEffectsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600AA52 RID: 43602 RVA: 0x002B7330 File Offset: 0x002B5530
		public Span<long> GetBuffEffectsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(12, 8));
		}

		// Token: 0x0600AA53 RID: 43603 RVA: 0x002B7345 File Offset: 0x002B5545
		public long[] GetBuffEffectsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(12) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x0600AA54 RID: 43604 RVA: 0x002B7384 File Offset: 0x002B5584
		public int ChargeEfficiency
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

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600AA55 RID: 43605 RVA: 0x002B73C4 File Offset: 0x002B55C4
		public int SkillGroupId
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

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x002B7404 File Offset: 0x002B5604
		public float SkillCD
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600AA57 RID: 43607 RVA: 0x002B7448 File Offset: 0x002B5648
		public string DescriptionEx
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

		// Token: 0x0600AA58 RID: 43608 RVA: 0x002B7480 File Offset: 0x002B5680
		public Span<byte> GetDescriptionExBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x002B7490 File Offset: 0x002B5690
		public byte[] GetDescriptionExArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x002B74A8 File Offset: 0x002B56A8
		public string SimplyDescription
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

		// Token: 0x0600AA5B RID: 43611 RVA: 0x002B74E0 File Offset: 0x002B56E0
		public Span<byte> GetSimplyDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600AA5C RID: 43612 RVA: 0x002B74F0 File Offset: 0x002B56F0
		public byte[] GetSimplyDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x0600AA5D RID: 43613 RVA: 0x002B7508 File Offset: 0x002B5708
		public bool IfCounterSkill
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x002B7548 File Offset: 0x002B5748
		public string CurLevelDescriptionEx(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002765 RID: 10085
		// (get) Token: 0x0600AA5F RID: 43615 RVA: 0x002B7584 File Offset: 0x002B5784
		public int CurLevelDescriptionExLength
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

		// Token: 0x0600AA60 RID: 43616 RVA: 0x002B75B0 File Offset: 0x002B57B0
		public StringArray? LevelDescStrArray(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new StringArray?(default(StringArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002766 RID: 10086
		// (get) Token: 0x0600AA61 RID: 43617 RVA: 0x002B7614 File Offset: 0x002B5814
		public int LevelDescStrArrayLength
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

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x002B7640 File Offset: 0x002B5840
		public string BattleViewIcon
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

		// Token: 0x0600AA63 RID: 43619 RVA: 0x002B7678 File Offset: 0x002B5878
		public Span<byte> GetBattleViewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x0600AA64 RID: 43620 RVA: 0x002B7688 File Offset: 0x002B5888
		public byte[] GetBattleViewIconArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x0600AA65 RID: 43621 RVA: 0x002B76A0 File Offset: 0x002B58A0
		public string SpecialBattleViewIcon
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

		// Token: 0x0600AA66 RID: 43622 RVA: 0x002B76D8 File Offset: 0x002B58D8
		public Span<byte> GetSpecialBattleViewIconBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x002B76E8 File Offset: 0x002B58E8
		public byte[] GetSpecialBattleViewIconArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x002B7700 File Offset: 0x002B5900
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffEffectsIter()或GetBuffEffectsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffEffects()
		{
			PhantomSkill phantomSkill = this;
			return phantomSkill.GetBuffEffectsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x002B7724 File Offset: 0x002B5924
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffEffectsIter()
		{
			PhantomSkill.<BuffEffectsIter>d__58 <BuffEffectsIter>d__ = new PhantomSkill.<BuffEffectsIter>d__58(-2);
			<BuffEffectsIter>d__.<>3__<>4__this = this;
			return <BuffEffectsIter>d__;
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x002B773C File Offset: 0x002B593C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用BuffIdsIter()或GetBuffIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] BuffIds()
		{
			PhantomSkill phantomSkill = this;
			return phantomSkill.GetBuffIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x002B7760 File Offset: 0x002B5960
		[NullableContext(1)]
		public readonly IEnumerable<long> BuffIdsIter()
		{
			PhantomSkill.<BuffIdsIter>d__60 <BuffIdsIter>d__ = new PhantomSkill.<BuffIdsIter>d__60(-2);
			<BuffIdsIter>d__.<>3__<>4__this = this;
			return <BuffIdsIter>d__;
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x002B7775 File Offset: 0x002B5975
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CurLevelDescriptionExIter()或GetCurLevelDescriptionExBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] CurLevelDescriptionEx()
		{
			return this.CurLevelDescriptionExIter().ToArray<string>();
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x002B7782 File Offset: 0x002B5982
		[NullableContext(1)]
		public readonly IEnumerable<string> CurLevelDescriptionExIter()
		{
			PhantomSkill.<CurLevelDescriptionExIter>d__62 <CurLevelDescriptionExIter>d__ = new PhantomSkill.<CurLevelDescriptionExIter>d__62(-2);
			<CurLevelDescriptionExIter>d__.<>3__<>4__this = this;
			return <CurLevelDescriptionExIter>d__;
		}

		// Token: 0x0600AA6E RID: 43630 RVA: 0x002B7797 File Offset: 0x002B5997
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LevelDescStrArrayIter()或GetLevelDescStrArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly StringArray[] LevelDescStrArray()
		{
			return this.LevelDescStrArrayIter().ToArray<StringArray>();
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x002B77A4 File Offset: 0x002B59A4
		[NullableContext(1)]
		public readonly IEnumerable<StringArray> LevelDescStrArrayIter()
		{
			PhantomSkill.<LevelDescStrArrayIter>d__64 <LevelDescStrArrayIter>d__ = new PhantomSkill.<LevelDescStrArrayIter>d__64(-2);
			<LevelDescStrArrayIter>d__.<>3__<>4__this = this;
			return <LevelDescStrArrayIter>d__;
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x002B77BC File Offset: 0x002B59BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SettleIdsIter()或GetSettleIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] SettleIds()
		{
			PhantomSkill phantomSkill = this;
			return phantomSkill.GetSettleIdsArray() ?? Array.Empty<long>();
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x002B77E0 File Offset: 0x002B59E0
		[NullableContext(1)]
		public readonly IEnumerable<long> SettleIdsIter()
		{
			PhantomSkill.<SettleIdsIter>d__66 <SettleIdsIter>d__ = new PhantomSkill.<SettleIdsIter>d__66(-2);
			<SettleIdsIter>d__.<>3__<>4__this = this;
			return <SettleIdsIter>d__;
		}

		// Token: 0x04004FC0 RID: 20416
		private Table __p;
	}
}
