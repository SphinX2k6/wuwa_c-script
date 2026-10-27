using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BA5 RID: 15269
	public class IShowTimelineActionOptionBase_UnionUnion
	{
		// Token: 0x170068AD RID: 26797
		// (get) Token: 0x06014ED9 RID: 85721 RVA: 0x00309299 File Offset: 0x00307499
		// (set) Token: 0x06014EDA RID: 85722 RVA: 0x003092A1 File Offset: 0x003074A1
		public IShowTimelineActionOptionBase_Union Type { get; set; }

		// Token: 0x170068AE RID: 26798
		// (get) Token: 0x06014EDB RID: 85723 RVA: 0x003092AA File Offset: 0x003074AA
		// (set) Token: 0x06014EDC RID: 85724 RVA: 0x003092B2 File Offset: 0x003074B2
		public object Value { get; set; }

		// Token: 0x06014EDD RID: 85725 RVA: 0x003092BB File Offset: 0x003074BB
		public IShowTimelineActionOptionBase_UnionUnion()
		{
			this.Type = IShowTimelineActionOptionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06014EDE RID: 85726 RVA: 0x003092D1 File Offset: 0x003074D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014EDF RID: 85727 RVA: 0x003092E3 File Offset: 0x003074E3
		public IShowTimelineActionOptionBaseT AsIShowTimelineActionOptionBase()
		{
			return this.As<IShowTimelineActionOptionBaseT>();
		}

		// Token: 0x06014EE0 RID: 85728 RVA: 0x003092EB File Offset: 0x003074EB
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineActionOptionBase(IShowTimelineActionOptionBaseT _ishowtimelineactionoptionbase)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineActionOptionBase,
				Value = _ishowtimelineactionoptionbase
			};
		}

		// Token: 0x06014EE1 RID: 85729 RVA: 0x00309300 File Offset: 0x00307500
		public IShowTimelineCastSkillT AsIShowTimelineCastSkill()
		{
			return this.As<IShowTimelineCastSkillT>();
		}

		// Token: 0x06014EE2 RID: 85730 RVA: 0x00309308 File Offset: 0x00307508
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineCastSkill(IShowTimelineCastSkillT _ishowtimelinecastskill)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineCastSkill,
				Value = _ishowtimelinecastskill
			};
		}

		// Token: 0x06014EE3 RID: 85731 RVA: 0x0030931D File Offset: 0x0030751D
		public IShowTimelineJumpT AsIShowTimelineJump()
		{
			return this.As<IShowTimelineJumpT>();
		}

		// Token: 0x06014EE4 RID: 85732 RVA: 0x00309325 File Offset: 0x00307525
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineJump(IShowTimelineJumpT _ishowtimelinejump)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineJump,
				Value = _ishowtimelinejump
			};
		}

		// Token: 0x06014EE5 RID: 85733 RVA: 0x0030933A File Offset: 0x0030753A
		public IShowTimelineSwitchRoleT AsIShowTimelineSwitchRole()
		{
			return this.As<IShowTimelineSwitchRoleT>();
		}

		// Token: 0x06014EE6 RID: 85734 RVA: 0x00309342 File Offset: 0x00307542
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineSwitchRole(IShowTimelineSwitchRoleT _ishowtimelineswitchrole)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineSwitchRole,
				Value = _ishowtimelineswitchrole
			};
		}

		// Token: 0x06014EE7 RID: 85735 RVA: 0x00309358 File Offset: 0x00307558
		public static int Pack(FlatBufferBuilder builder, IShowTimelineActionOptionBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IShowTimelineActionOptionBase_Union.IShowTimelineActionOptionBase:
				return IShowTimelineActionOptionBase.Pack(builder, _o.AsIShowTimelineActionOptionBase()).Value;
			case IShowTimelineActionOptionBase_Union.IShowTimelineCastSkill:
				return IShowTimelineCastSkill.Pack(builder, _o.AsIShowTimelineCastSkill()).Value;
			case IShowTimelineActionOptionBase_Union.IShowTimelineJump:
				return IShowTimelineJump.Pack(builder, _o.AsIShowTimelineJump()).Value;
			case IShowTimelineActionOptionBase_Union.IShowTimelineSwitchRole:
				return IShowTimelineSwitchRole.Pack(builder, _o.AsIShowTimelineSwitchRole()).Value;
			default:
				return 0;
			}
		}
	}
}
