using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050FB RID: 20731
	public class IElementalBoxStateTarget_UnionUnion
	{
		// Token: 0x1700948F RID: 38031
		// (get) Token: 0x0602093B RID: 133435 RVA: 0x004849FD File Offset: 0x00482BFD
		// (set) Token: 0x0602093C RID: 133436 RVA: 0x00484A05 File Offset: 0x00482C05
		public IElementalBoxStateTarget_Union Type { get; set; }

		// Token: 0x17009490 RID: 38032
		// (get) Token: 0x0602093D RID: 133437 RVA: 0x00484A0E File Offset: 0x00482C0E
		// (set) Token: 0x0602093E RID: 133438 RVA: 0x00484A16 File Offset: 0x00482C16
		public object Value { get; set; }

		// Token: 0x0602093F RID: 133439 RVA: 0x00484A1F File Offset: 0x00482C1F
		public IElementalBoxStateTarget_UnionUnion()
		{
			this.Type = IElementalBoxStateTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020940 RID: 133440 RVA: 0x00484A35 File Offset: 0x00482C35
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020941 RID: 133441 RVA: 0x00484A47 File Offset: 0x00482C47
		public IElementalBoxStateTargetT AsIElementalBoxStateTarget()
		{
			return this.As<IElementalBoxStateTargetT>();
		}

		// Token: 0x06020942 RID: 133442 RVA: 0x00484A4F File Offset: 0x00482C4F
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateTarget(IElementalBoxStateTargetT _ielementalboxstatetarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateTarget,
				Value = _ielementalboxstatetarget
			};
		}

		// Token: 0x06020943 RID: 133443 RVA: 0x00484A64 File Offset: 0x00482C64
		public IElementalBoxStatePlayerTargetT AsIElementalBoxStatePlayerTarget()
		{
			return this.As<IElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x06020944 RID: 133444 RVA: 0x00484A6C File Offset: 0x00482C6C
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStatePlayerTarget(IElementalBoxStatePlayerTargetT _ielementalboxstateplayertarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStatePlayerTarget,
				Value = _ielementalboxstateplayertarget
			};
		}

		// Token: 0x06020945 RID: 133445 RVA: 0x00484A81 File Offset: 0x00482C81
		public IElementalBoxStateFoundationTargetT AsIElementalBoxStateFoundationTarget()
		{
			return this.As<IElementalBoxStateFoundationTargetT>();
		}

		// Token: 0x06020946 RID: 133446 RVA: 0x00484A89 File Offset: 0x00482C89
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateFoundationTarget(IElementalBoxStateFoundationTargetT _ielementalboxstatefoundationtarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateFoundationTarget,
				Value = _ielementalboxstatefoundationtarget
			};
		}

		// Token: 0x06020947 RID: 133447 RVA: 0x00484A9E File Offset: 0x00482C9E
		public IElementalBoxStateFoundationSelfTargetT AsIElementalBoxStateFoundationSelfTarget()
		{
			return this.As<IElementalBoxStateFoundationSelfTargetT>();
		}

		// Token: 0x06020948 RID: 133448 RVA: 0x00484AA6 File Offset: 0x00482CA6
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateFoundationSelfTarget(IElementalBoxStateFoundationSelfTargetT _ielementalboxstatefoundationselftarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateFoundationSelfTarget,
				Value = _ielementalboxstatefoundationselftarget
			};
		}

		// Token: 0x06020949 RID: 133449 RVA: 0x00484ABB File Offset: 0x00482CBB
		public IElementalBoxStateSpecifiedTargetT AsIElementalBoxStateSpecifiedTarget()
		{
			return this.As<IElementalBoxStateSpecifiedTargetT>();
		}

		// Token: 0x0602094A RID: 133450 RVA: 0x00484AC3 File Offset: 0x00482CC3
		public static IElementalBoxStateTarget_UnionUnion FromIElementalBoxStateSpecifiedTarget(IElementalBoxStateSpecifiedTargetT _ielementalboxstatespecifiedtarget)
		{
			return new IElementalBoxStateTarget_UnionUnion
			{
				Type = IElementalBoxStateTarget_Union.IElementalBoxStateSpecifiedTarget,
				Value = _ielementalboxstatespecifiedtarget
			};
		}

		// Token: 0x0602094B RID: 133451 RVA: 0x00484AD8 File Offset: 0x00482CD8
		public static int Pack(FlatBufferBuilder builder, IElementalBoxStateTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IElementalBoxStateTarget_Union.IElementalBoxStateTarget:
				return IElementalBoxStateTarget.Pack(builder, _o.AsIElementalBoxStateTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStatePlayerTarget:
				return IElementalBoxStatePlayerTarget.Pack(builder, _o.AsIElementalBoxStatePlayerTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStateFoundationTarget:
				return IElementalBoxStateFoundationTarget.Pack(builder, _o.AsIElementalBoxStateFoundationTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStateFoundationSelfTarget:
				return IElementalBoxStateFoundationSelfTarget.Pack(builder, _o.AsIElementalBoxStateFoundationSelfTarget()).Value;
			case IElementalBoxStateTarget_Union.IElementalBoxStateSpecifiedTarget:
				return IElementalBoxStateSpecifiedTarget.Pack(builder, _o.AsIElementalBoxStateSpecifiedTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
