using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005242 RID: 21058
	public class TElementalBoxStateTargetUnion
	{
		// Token: 0x17009682 RID: 38530
		// (get) Token: 0x0602129B RID: 135835 RVA: 0x00494086 File Offset: 0x00492286
		// (set) Token: 0x0602129C RID: 135836 RVA: 0x0049408E File Offset: 0x0049228E
		public TElementalBoxStateTarget Type { get; set; }

		// Token: 0x17009683 RID: 38531
		// (get) Token: 0x0602129D RID: 135837 RVA: 0x00494097 File Offset: 0x00492297
		// (set) Token: 0x0602129E RID: 135838 RVA: 0x0049409F File Offset: 0x0049229F
		public object Value { get; set; }

		// Token: 0x0602129F RID: 135839 RVA: 0x004940A8 File Offset: 0x004922A8
		public TElementalBoxStateTargetUnion()
		{
			this.Type = TElementalBoxStateTarget.NONE;
			this.Value = null;
		}

		// Token: 0x060212A0 RID: 135840 RVA: 0x004940BE File Offset: 0x004922BE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212A1 RID: 135841 RVA: 0x004940D0 File Offset: 0x004922D0
		public IElementalBoxStateFoundationSelfTargetT AsIElementalBoxStateFoundationSelfTarget()
		{
			return this.As<IElementalBoxStateFoundationSelfTargetT>();
		}

		// Token: 0x060212A2 RID: 135842 RVA: 0x004940D8 File Offset: 0x004922D8
		public static TElementalBoxStateTargetUnion FromIElementalBoxStateFoundationSelfTarget(IElementalBoxStateFoundationSelfTargetT _ielementalboxstatefoundationselftarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStateFoundationSelfTarget,
				Value = _ielementalboxstatefoundationselftarget
			};
		}

		// Token: 0x060212A3 RID: 135843 RVA: 0x004940ED File Offset: 0x004922ED
		public IElementalBoxStateFoundationTargetT AsIElementalBoxStateFoundationTarget()
		{
			return this.As<IElementalBoxStateFoundationTargetT>();
		}

		// Token: 0x060212A4 RID: 135844 RVA: 0x004940F5 File Offset: 0x004922F5
		public static TElementalBoxStateTargetUnion FromIElementalBoxStateFoundationTarget(IElementalBoxStateFoundationTargetT _ielementalboxstatefoundationtarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStateFoundationTarget,
				Value = _ielementalboxstatefoundationtarget
			};
		}

		// Token: 0x060212A5 RID: 135845 RVA: 0x0049410A File Offset: 0x0049230A
		public IElementalBoxStatePlayerTargetT AsIElementalBoxStatePlayerTarget()
		{
			return this.As<IElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x060212A6 RID: 135846 RVA: 0x00494112 File Offset: 0x00492312
		public static TElementalBoxStateTargetUnion FromIElementalBoxStatePlayerTarget(IElementalBoxStatePlayerTargetT _ielementalboxstateplayertarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStatePlayerTarget,
				Value = _ielementalboxstateplayertarget
			};
		}

		// Token: 0x060212A7 RID: 135847 RVA: 0x00494127 File Offset: 0x00492327
		public IElementalBoxStateSpecifiedTargetT AsIElementalBoxStateSpecifiedTarget()
		{
			return this.As<IElementalBoxStateSpecifiedTargetT>();
		}

		// Token: 0x060212A8 RID: 135848 RVA: 0x0049412F File Offset: 0x0049232F
		public static TElementalBoxStateTargetUnion FromIElementalBoxStateSpecifiedTarget(IElementalBoxStateSpecifiedTargetT _ielementalboxstatespecifiedtarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStateSpecifiedTarget,
				Value = _ielementalboxstatespecifiedtarget
			};
		}

		// Token: 0x060212A9 RID: 135849 RVA: 0x00494144 File Offset: 0x00492344
		public static int Pack(FlatBufferBuilder builder, TElementalBoxStateTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TElementalBoxStateTarget.IElementalBoxStateFoundationSelfTarget:
				return IElementalBoxStateFoundationSelfTarget.Pack(builder, _o.AsIElementalBoxStateFoundationSelfTarget()).Value;
			case TElementalBoxStateTarget.IElementalBoxStateFoundationTarget:
				return IElementalBoxStateFoundationTarget.Pack(builder, _o.AsIElementalBoxStateFoundationTarget()).Value;
			case TElementalBoxStateTarget.IElementalBoxStatePlayerTarget:
				return IElementalBoxStatePlayerTarget.Pack(builder, _o.AsIElementalBoxStatePlayerTarget()).Value;
			case TElementalBoxStateTarget.IElementalBoxStateSpecifiedTarget:
				return IElementalBoxStateSpecifiedTarget.Pack(builder, _o.AsIElementalBoxStateSpecifiedTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
