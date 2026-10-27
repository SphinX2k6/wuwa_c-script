using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BD5 RID: 15317
	public class TShowTimelineActionOptionUnion
	{
		// Token: 0x17006919 RID: 26905
		// (get) Token: 0x060150EB RID: 86251 RVA: 0x0030D678 File Offset: 0x0030B878
		// (set) Token: 0x060150EC RID: 86252 RVA: 0x0030D680 File Offset: 0x0030B880
		public TShowTimelineActionOption Type { get; set; }

		// Token: 0x1700691A RID: 26906
		// (get) Token: 0x060150ED RID: 86253 RVA: 0x0030D689 File Offset: 0x0030B889
		// (set) Token: 0x060150EE RID: 86254 RVA: 0x0030D691 File Offset: 0x0030B891
		public object Value { get; set; }

		// Token: 0x060150EF RID: 86255 RVA: 0x0030D69A File Offset: 0x0030B89A
		public TShowTimelineActionOptionUnion()
		{
			this.Type = TShowTimelineActionOption.NONE;
			this.Value = null;
		}

		// Token: 0x060150F0 RID: 86256 RVA: 0x0030D6B0 File Offset: 0x0030B8B0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060150F1 RID: 86257 RVA: 0x0030D6C2 File Offset: 0x0030B8C2
		public IShowTimelineCastSkillT AsIShowTimelineCastSkill()
		{
			return this.As<IShowTimelineCastSkillT>();
		}

		// Token: 0x060150F2 RID: 86258 RVA: 0x0030D6CA File Offset: 0x0030B8CA
		public static TShowTimelineActionOptionUnion FromIShowTimelineCastSkill(IShowTimelineCastSkillT _ishowtimelinecastskill)
		{
			return new TShowTimelineActionOptionUnion
			{
				Type = TShowTimelineActionOption.IShowTimelineCastSkill,
				Value = _ishowtimelinecastskill
			};
		}

		// Token: 0x060150F3 RID: 86259 RVA: 0x0030D6DF File Offset: 0x0030B8DF
		public IShowTimelineJumpT AsIShowTimelineJump()
		{
			return this.As<IShowTimelineJumpT>();
		}

		// Token: 0x060150F4 RID: 86260 RVA: 0x0030D6E7 File Offset: 0x0030B8E7
		public static TShowTimelineActionOptionUnion FromIShowTimelineJump(IShowTimelineJumpT _ishowtimelinejump)
		{
			return new TShowTimelineActionOptionUnion
			{
				Type = TShowTimelineActionOption.IShowTimelineJump,
				Value = _ishowtimelinejump
			};
		}

		// Token: 0x060150F5 RID: 86261 RVA: 0x0030D6FC File Offset: 0x0030B8FC
		public IShowTimelineSwitchRoleT AsIShowTimelineSwitchRole()
		{
			return this.As<IShowTimelineSwitchRoleT>();
		}

		// Token: 0x060150F6 RID: 86262 RVA: 0x0030D704 File Offset: 0x0030B904
		public static TShowTimelineActionOptionUnion FromIShowTimelineSwitchRole(IShowTimelineSwitchRoleT _ishowtimelineswitchrole)
		{
			return new TShowTimelineActionOptionUnion
			{
				Type = TShowTimelineActionOption.IShowTimelineSwitchRole,
				Value = _ishowtimelineswitchrole
			};
		}

		// Token: 0x060150F7 RID: 86263 RVA: 0x0030D71C File Offset: 0x0030B91C
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
