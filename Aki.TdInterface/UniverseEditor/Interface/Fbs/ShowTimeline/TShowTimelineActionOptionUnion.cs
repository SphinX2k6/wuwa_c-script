using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FE0 RID: 16352
	public class TShowTimelineActionOptionUnion
	{
		// Token: 0x17006EC1 RID: 28353
		// (get) Token: 0x060165E1 RID: 91617 RVA: 0x00334200 File Offset: 0x00332400
		// (set) Token: 0x060165E2 RID: 91618 RVA: 0x00334208 File Offset: 0x00332408
		public TShowTimelineActionOption Type { get; set; }

		// Token: 0x17006EC2 RID: 28354
		// (get) Token: 0x060165E3 RID: 91619 RVA: 0x00334211 File Offset: 0x00332411
		// (set) Token: 0x060165E4 RID: 91620 RVA: 0x00334219 File Offset: 0x00332419
		public object Value { get; set; }

		// Token: 0x060165E5 RID: 91621 RVA: 0x00334222 File Offset: 0x00332422
		public TShowTimelineActionOptionUnion()
		{
			this.Type = TShowTimelineActionOption.NONE;
			this.Value = null;
		}

		// Token: 0x060165E6 RID: 91622 RVA: 0x00334238 File Offset: 0x00332438
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060165E7 RID: 91623 RVA: 0x0033424A File Offset: 0x0033244A
		public IShowTimelineCastSkillT AsIShowTimelineCastSkill()
		{
			return this.As<IShowTimelineCastSkillT>();
		}

		// Token: 0x060165E8 RID: 91624 RVA: 0x00334252 File Offset: 0x00332452
		public static TShowTimelineActionOptionUnion FromIShowTimelineCastSkill(IShowTimelineCastSkillT _ishowtimelinecastskill)
		{
			return new TShowTimelineActionOptionUnion
			{
				Type = TShowTimelineActionOption.IShowTimelineCastSkill,
				Value = _ishowtimelinecastskill
			};
		}

		// Token: 0x060165E9 RID: 91625 RVA: 0x00334267 File Offset: 0x00332467
		public IShowTimelineJumpT AsIShowTimelineJump()
		{
			return this.As<IShowTimelineJumpT>();
		}

		// Token: 0x060165EA RID: 91626 RVA: 0x0033426F File Offset: 0x0033246F
		public static TShowTimelineActionOptionUnion FromIShowTimelineJump(IShowTimelineJumpT _ishowtimelinejump)
		{
			return new TShowTimelineActionOptionUnion
			{
				Type = TShowTimelineActionOption.IShowTimelineJump,
				Value = _ishowtimelinejump
			};
		}

		// Token: 0x060165EB RID: 91627 RVA: 0x00334284 File Offset: 0x00332484
		public IShowTimelineSwitchRoleT AsIShowTimelineSwitchRole()
		{
			return this.As<IShowTimelineSwitchRoleT>();
		}

		// Token: 0x060165EC RID: 91628 RVA: 0x0033428C File Offset: 0x0033248C
		public static TShowTimelineActionOptionUnion FromIShowTimelineSwitchRole(IShowTimelineSwitchRoleT _ishowtimelineswitchrole)
		{
			return new TShowTimelineActionOptionUnion
			{
				Type = TShowTimelineActionOption.IShowTimelineSwitchRole,
				Value = _ishowtimelineswitchrole
			};
		}

		// Token: 0x060165ED RID: 91629 RVA: 0x003342A4 File Offset: 0x003324A4
		public static int Pack(FlatBufferBuilder builder, TShowTimelineActionOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TShowTimelineActionOption.IShowTimelineCastSkill:
				return IShowTimelineCastSkill.Pack(builder, _o.AsIShowTimelineCastSkill()).Value;
			case TShowTimelineActionOption.IShowTimelineJump:
				return IShowTimelineJump.Pack(builder, _o.AsIShowTimelineJump()).Value;
			case TShowTimelineActionOption.IShowTimelineSwitchRole:
				return IShowTimelineSwitchRole.Pack(builder, _o.AsIShowTimelineSwitchRole()).Value;
			default:
				return 0;
			}
		}
	}
}
