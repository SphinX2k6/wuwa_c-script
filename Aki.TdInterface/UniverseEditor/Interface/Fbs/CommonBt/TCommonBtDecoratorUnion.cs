using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x0200651C RID: 25884
	public class TCommonBtDecoratorUnion
	{
		// Token: 0x1700BF0B RID: 48907
		// (get) Token: 0x0602C202 RID: 180738 RVA: 0x00602C39 File Offset: 0x00600E39
		// (set) Token: 0x0602C203 RID: 180739 RVA: 0x00602C41 File Offset: 0x00600E41
		public TCommonBtDecorator Type { get; set; }

		// Token: 0x1700BF0C RID: 48908
		// (get) Token: 0x0602C204 RID: 180740 RVA: 0x00602C4A File Offset: 0x00600E4A
		// (set) Token: 0x0602C205 RID: 180741 RVA: 0x00602C52 File Offset: 0x00600E52
		public object Value { get; set; }

		// Token: 0x0602C206 RID: 180742 RVA: 0x00602C5B File Offset: 0x00600E5B
		public TCommonBtDecoratorUnion()
		{
			this.Type = TCommonBtDecorator.NONE;
			this.Value = null;
		}

		// Token: 0x0602C207 RID: 180743 RVA: 0x00602C71 File Offset: 0x00600E71
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C208 RID: 180744 RVA: 0x00602C83 File Offset: 0x00600E83
		public ICommonBtAlwaysFalseDecoratorT AsICommonBtAlwaysFalseDecorator()
		{
			return this.As<ICommonBtAlwaysFalseDecoratorT>();
		}

		// Token: 0x0602C209 RID: 180745 RVA: 0x00602C8B File Offset: 0x00600E8B
		public static TCommonBtDecoratorUnion FromICommonBtAlwaysFalseDecorator(ICommonBtAlwaysFalseDecoratorT _icommonbtalwaysfalsedecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtAlwaysFalseDecorator,
				Value = _icommonbtalwaysfalsedecorator
			};
		}

		// Token: 0x0602C20A RID: 180746 RVA: 0x00602CA0 File Offset: 0x00600EA0
		public ICommonBtAlwaysTrueDecoratorT AsICommonBtAlwaysTrueDecorator()
		{
			return this.As<ICommonBtAlwaysTrueDecoratorT>();
		}

		// Token: 0x0602C20B RID: 180747 RVA: 0x00602CA8 File Offset: 0x00600EA8
		public static TCommonBtDecoratorUnion FromICommonBtAlwaysTrueDecorator(ICommonBtAlwaysTrueDecoratorT _icommonbtalwaystruedecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtAlwaysTrueDecorator,
				Value = _icommonbtalwaystruedecorator
			};
		}

		// Token: 0x0602C20C RID: 180748 RVA: 0x00602CBD File Offset: 0x00600EBD
		public ICommonBtConditionDecoratorT AsICommonBtConditionDecorator()
		{
			return this.As<ICommonBtConditionDecoratorT>();
		}

		// Token: 0x0602C20D RID: 180749 RVA: 0x00602CC5 File Offset: 0x00600EC5
		public static TCommonBtDecoratorUnion FromICommonBtConditionDecorator(ICommonBtConditionDecoratorT _icommonbtconditiondecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtConditionDecorator,
				Value = _icommonbtconditiondecorator
			};
		}

		// Token: 0x0602C20E RID: 180750 RVA: 0x00602CDA File Offset: 0x00600EDA
		public ICommonBtCoolDownDecoratorT AsICommonBtCoolDownDecorator()
		{
			return this.As<ICommonBtCoolDownDecoratorT>();
		}

		// Token: 0x0602C20F RID: 180751 RVA: 0x00602CE2 File Offset: 0x00600EE2
		public static TCommonBtDecoratorUnion FromICommonBtCoolDownDecorator(ICommonBtCoolDownDecoratorT _icommonbtcooldowndecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtCoolDownDecorator,
				Value = _icommonbtcooldowndecorator
			};
		}

		// Token: 0x0602C210 RID: 180752 RVA: 0x00602CF7 File Offset: 0x00600EF7
		public ICommonBtDoOnceDecoratorT AsICommonBtDoOnceDecorator()
		{
			return this.As<ICommonBtDoOnceDecoratorT>();
		}

		// Token: 0x0602C211 RID: 180753 RVA: 0x00602CFF File Offset: 0x00600EFF
		public static TCommonBtDecoratorUnion FromICommonBtDoOnceDecorator(ICommonBtDoOnceDecoratorT _icommonbtdooncedecorator)
		{
			return new TCommonBtDecoratorUnion
			{
				Type = TCommonBtDecorator.ICommonBtDoOnceDecorator,
				Value = _icommonbtdooncedecorator
			};
		}

		// Token: 0x0602C212 RID: 180754 RVA: 0x00602D14 File Offset: 0x00600F14
		public static int Pack(FlatBufferBuilder builder, TCommonBtDecoratorUnion _o)
		{
			switch (_o.Type)
			{
			case TCommonBtDecorator.ICommonBtAlwaysFalseDecorator:
				return ICommonBtAlwaysFalseDecorator.Pack(builder, _o.AsICommonBtAlwaysFalseDecorator()).Value;
			case TCommonBtDecorator.ICommonBtAlwaysTrueDecorator:
				return ICommonBtAlwaysTrueDecorator.Pack(builder, _o.AsICommonBtAlwaysTrueDecorator()).Value;
			case TCommonBtDecorator.ICommonBtConditionDecorator:
				return ICommonBtConditionDecorator.Pack(builder, _o.AsICommonBtConditionDecorator()).Value;
			case TCommonBtDecorator.ICommonBtCoolDownDecorator:
				return ICommonBtCoolDownDecorator.Pack(builder, _o.AsICommonBtCoolDownDecorator()).Value;
			case TCommonBtDecorator.ICommonBtDoOnceDecorator:
				return ICommonBtDoOnceDecorator.Pack(builder, _o.AsICommonBtDoOnceDecorator()).Value;
			default:
				return 0;
			}
		}
	}
}
