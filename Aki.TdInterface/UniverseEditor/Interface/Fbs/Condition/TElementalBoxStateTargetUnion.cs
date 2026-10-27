using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D46 RID: 19782
	public class TElementalBoxStateTargetUnion
	{
		// Token: 0x17008F49 RID: 36681
		// (get) Token: 0x0601F652 RID: 128594 RVA: 0x004600B2 File Offset: 0x0045E2B2
		// (set) Token: 0x0601F653 RID: 128595 RVA: 0x004600BA File Offset: 0x0045E2BA
		public TElementalBoxStateTarget Type { get; set; }

		// Token: 0x17008F4A RID: 36682
		// (get) Token: 0x0601F654 RID: 128596 RVA: 0x004600C3 File Offset: 0x0045E2C3
		// (set) Token: 0x0601F655 RID: 128597 RVA: 0x004600CB File Offset: 0x0045E2CB
		public object Value { get; set; }

		// Token: 0x0601F656 RID: 128598 RVA: 0x004600D4 File Offset: 0x0045E2D4
		public TElementalBoxStateTargetUnion()
		{
			this.Type = TElementalBoxStateTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0601F657 RID: 128599 RVA: 0x004600EA File Offset: 0x0045E2EA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F658 RID: 128600 RVA: 0x004600FC File Offset: 0x0045E2FC
		public IElementalBoxStateFoundationSelfTargetT AsIElementalBoxStateFoundationSelfTarget()
		{
			return this.As<IElementalBoxStateFoundationSelfTargetT>();
		}

		// Token: 0x0601F659 RID: 128601 RVA: 0x00460104 File Offset: 0x0045E304
		public static TElementalBoxStateTargetUnion FromIElementalBoxStateFoundationSelfTarget(IElementalBoxStateFoundationSelfTargetT _ielementalboxstatefoundationselftarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStateFoundationSelfTarget,
				Value = _ielementalboxstatefoundationselftarget
			};
		}

		// Token: 0x0601F65A RID: 128602 RVA: 0x00460119 File Offset: 0x0045E319
		public IElementalBoxStateFoundationTargetT AsIElementalBoxStateFoundationTarget()
		{
			return this.As<IElementalBoxStateFoundationTargetT>();
		}

		// Token: 0x0601F65B RID: 128603 RVA: 0x00460121 File Offset: 0x0045E321
		public static TElementalBoxStateTargetUnion FromIElementalBoxStateFoundationTarget(IElementalBoxStateFoundationTargetT _ielementalboxstatefoundationtarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStateFoundationTarget,
				Value = _ielementalboxstatefoundationtarget
			};
		}

		// Token: 0x0601F65C RID: 128604 RVA: 0x00460136 File Offset: 0x0045E336
		public IElementalBoxStatePlayerTargetT AsIElementalBoxStatePlayerTarget()
		{
			return this.As<IElementalBoxStatePlayerTargetT>();
		}

		// Token: 0x0601F65D RID: 128605 RVA: 0x0046013E File Offset: 0x0045E33E
		public static TElementalBoxStateTargetUnion FromIElementalBoxStatePlayerTarget(IElementalBoxStatePlayerTargetT _ielementalboxstateplayertarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStatePlayerTarget,
				Value = _ielementalboxstateplayertarget
			};
		}

		// Token: 0x0601F65E RID: 128606 RVA: 0x00460153 File Offset: 0x0045E353
		public IElementalBoxStateSpecifiedTargetT AsIElementalBoxStateSpecifiedTarget()
		{
			return this.As<IElementalBoxStateSpecifiedTargetT>();
		}

		// Token: 0x0601F65F RID: 128607 RVA: 0x0046015B File Offset: 0x0045E35B
		public static TElementalBoxStateTargetUnion FromIElementalBoxStateSpecifiedTarget(IElementalBoxStateSpecifiedTargetT _ielementalboxstatespecifiedtarget)
		{
			return new TElementalBoxStateTargetUnion
			{
				Type = TElementalBoxStateTarget.IElementalBoxStateSpecifiedTarget,
				Value = _ielementalboxstatespecifiedtarget
			};
		}

		// Token: 0x0601F660 RID: 128608 RVA: 0x00460170 File Offset: 0x0045E370
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
