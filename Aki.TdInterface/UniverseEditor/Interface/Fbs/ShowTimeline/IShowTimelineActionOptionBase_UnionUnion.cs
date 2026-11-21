using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FAD RID: 16301
	public class IShowTimelineActionOptionBase_UnionUnion
	{
		// Token: 0x17006E4C RID: 28236
		// (get) Token: 0x060163A3 RID: 91043 RVA: 0x0032F831 File Offset: 0x0032DA31
		// (set) Token: 0x060163A4 RID: 91044 RVA: 0x0032F839 File Offset: 0x0032DA39
		public IShowTimelineActionOptionBase_Union Type { get; set; }

		// Token: 0x17006E4D RID: 28237
		// (get) Token: 0x060163A5 RID: 91045 RVA: 0x0032F842 File Offset: 0x0032DA42
		// (set) Token: 0x060163A6 RID: 91046 RVA: 0x0032F84A File Offset: 0x0032DA4A
		public object Value { get; set; }

		// Token: 0x060163A7 RID: 91047 RVA: 0x0032F853 File Offset: 0x0032DA53
		public IShowTimelineActionOptionBase_UnionUnion()
		{
			this.Type = IShowTimelineActionOptionBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060163A8 RID: 91048 RVA: 0x0032F869 File Offset: 0x0032DA69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060163A9 RID: 91049 RVA: 0x0032F87B File Offset: 0x0032DA7B
		public IShowTimelineActionOptionBaseT AsIShowTimelineActionOptionBase()
		{
			return this.As<IShowTimelineActionOptionBaseT>();
		}

		// Token: 0x060163AA RID: 91050 RVA: 0x0032F883 File Offset: 0x0032DA83
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineActionOptionBase(IShowTimelineActionOptionBaseT _ishowtimelineactionoptionbase)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineActionOptionBase,
				Value = _ishowtimelineactionoptionbase
			};
		}

		// Token: 0x060163AB RID: 91051 RVA: 0x0032F898 File Offset: 0x0032DA98
		public IShowTimelineCastSkillT AsIShowTimelineCastSkill()
		{
			return this.As<IShowTimelineCastSkillT>();
		}

		// Token: 0x060163AC RID: 91052 RVA: 0x0032F8A0 File Offset: 0x0032DAA0
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineCastSkill(IShowTimelineCastSkillT _ishowtimelinecastskill)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineCastSkill,
				Value = _ishowtimelinecastskill
			};
		}

		// Token: 0x060163AD RID: 91053 RVA: 0x0032F8B5 File Offset: 0x0032DAB5
		public IShowTimelineJumpT AsIShowTimelineJump()
		{
			return this.As<IShowTimelineJumpT>();
		}

		// Token: 0x060163AE RID: 91054 RVA: 0x0032F8BD File Offset: 0x0032DABD
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineJump(IShowTimelineJumpT _ishowtimelinejump)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineJump,
				Value = _ishowtimelinejump
			};
		}

		// Token: 0x060163AF RID: 91055 RVA: 0x0032F8D2 File Offset: 0x0032DAD2
		public IShowTimelineSwitchRoleT AsIShowTimelineSwitchRole()
		{
			return this.As<IShowTimelineSwitchRoleT>();
		}

		// Token: 0x060163B0 RID: 91056 RVA: 0x0032F8DA File Offset: 0x0032DADA
		public static IShowTimelineActionOptionBase_UnionUnion FromIShowTimelineSwitchRole(IShowTimelineSwitchRoleT _ishowtimelineswitchrole)
		{
			return new IShowTimelineActionOptionBase_UnionUnion
			{
				Type = IShowTimelineActionOptionBase_Union.IShowTimelineSwitchRole,
				Value = _ishowtimelineswitchrole
			};
		}

		// Token: 0x060163B1 RID: 91057 RVA: 0x0032F8F0 File Offset: 0x0032DAF0
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
