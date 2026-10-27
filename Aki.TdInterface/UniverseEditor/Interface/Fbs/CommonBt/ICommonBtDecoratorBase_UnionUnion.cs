using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB8 RID: 24248
	public class ICommonBtDecoratorBase_UnionUnion
	{
		// Token: 0x1700B52C RID: 46380
		// (get) Token: 0x06029939 RID: 170297 RVA: 0x005B40D9 File Offset: 0x005B22D9
		// (set) Token: 0x0602993A RID: 170298 RVA: 0x005B40E1 File Offset: 0x005B22E1
		public ICommonBtDecoratorBase_Union Type { get; set; }

		// Token: 0x1700B52D RID: 46381
		// (get) Token: 0x0602993B RID: 170299 RVA: 0x005B40EA File Offset: 0x005B22EA
		// (set) Token: 0x0602993C RID: 170300 RVA: 0x005B40F2 File Offset: 0x005B22F2
		public object Value { get; set; }

		// Token: 0x0602993D RID: 170301 RVA: 0x005B40FB File Offset: 0x005B22FB
		public ICommonBtDecoratorBase_UnionUnion()
		{
			this.Type = ICommonBtDecoratorBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602993E RID: 170302 RVA: 0x005B4111 File Offset: 0x005B2311
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602993F RID: 170303 RVA: 0x005B4123 File Offset: 0x005B2323
		public ICommonBtDecoratorBaseT AsICommonBtDecoratorBase()
		{
			return this.As<ICommonBtDecoratorBaseT>();
		}

		// Token: 0x06029940 RID: 170304 RVA: 0x005B412B File Offset: 0x005B232B
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtDecoratorBase(ICommonBtDecoratorBaseT _icommonbtdecoratorbase)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtDecoratorBase,
				Value = _icommonbtdecoratorbase
			};
		}

		// Token: 0x06029941 RID: 170305 RVA: 0x005B4140 File Offset: 0x005B2340
		public ICommonBtConditionDecoratorT AsICommonBtConditionDecorator()
		{
			return this.As<ICommonBtConditionDecoratorT>();
		}

		// Token: 0x06029942 RID: 170306 RVA: 0x005B4148 File Offset: 0x005B2348
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtConditionDecorator(ICommonBtConditionDecoratorT _icommonbtconditiondecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtConditionDecorator,
				Value = _icommonbtconditiondecorator
			};
		}

		// Token: 0x06029943 RID: 170307 RVA: 0x005B415D File Offset: 0x005B235D
		public ICommonBtAlwaysFalseDecoratorT AsICommonBtAlwaysFalseDecorator()
		{
			return this.As<ICommonBtAlwaysFalseDecoratorT>();
		}

		// Token: 0x06029944 RID: 170308 RVA: 0x005B4165 File Offset: 0x005B2365
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtAlwaysFalseDecorator(ICommonBtAlwaysFalseDecoratorT _icommonbtalwaysfalsedecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtAlwaysFalseDecorator,
				Value = _icommonbtalwaysfalsedecorator
			};
		}

		// Token: 0x06029945 RID: 170309 RVA: 0x005B417A File Offset: 0x005B237A
		public ICommonBtAlwaysTrueDecoratorT AsICommonBtAlwaysTrueDecorator()
		{
			return this.As<ICommonBtAlwaysTrueDecoratorT>();
		}

		// Token: 0x06029946 RID: 170310 RVA: 0x005B4182 File Offset: 0x005B2382
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtAlwaysTrueDecorator(ICommonBtAlwaysTrueDecoratorT _icommonbtalwaystruedecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtAlwaysTrueDecorator,
				Value = _icommonbtalwaystruedecorator
			};
		}

		// Token: 0x06029947 RID: 170311 RVA: 0x005B4197 File Offset: 0x005B2397
		public ICommonBtDoOnceDecoratorT AsICommonBtDoOnceDecorator()
		{
			return this.As<ICommonBtDoOnceDecoratorT>();
		}

		// Token: 0x06029948 RID: 170312 RVA: 0x005B419F File Offset: 0x005B239F
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtDoOnceDecorator(ICommonBtDoOnceDecoratorT _icommonbtdooncedecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtDoOnceDecorator,
				Value = _icommonbtdooncedecorator
			};
		}

		// Token: 0x06029949 RID: 170313 RVA: 0x005B41B4 File Offset: 0x005B23B4
		public ICommonBtCoolDownDecoratorT AsICommonBtCoolDownDecorator()
		{
			return this.As<ICommonBtCoolDownDecoratorT>();
		}

		// Token: 0x0602994A RID: 170314 RVA: 0x005B41BC File Offset: 0x005B23BC
		public static ICommonBtDecoratorBase_UnionUnion FromICommonBtCoolDownDecorator(ICommonBtCoolDownDecoratorT _icommonbtcooldowndecorator)
		{
			return new ICommonBtDecoratorBase_UnionUnion
			{
				Type = ICommonBtDecoratorBase_Union.ICommonBtCoolDownDecorator,
				Value = _icommonbtcooldowndecorator
			};
		}

		// Token: 0x0602994B RID: 170315 RVA: 0x005B41D4 File Offset: 0x005B23D4
		public static int Pack(FlatBufferBuilder builder, ICommonBtDecoratorBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICommonBtDecoratorBase_Union.ICommonBtDecoratorBase:
				return ICommonBtDecoratorBase.Pack(builder, _o.AsICommonBtDecoratorBase()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtConditionDecorator:
				return ICommonBtConditionDecorator.Pack(builder, _o.AsICommonBtConditionDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtAlwaysFalseDecorator:
				return ICommonBtAlwaysFalseDecorator.Pack(builder, _o.AsICommonBtAlwaysFalseDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtAlwaysTrueDecorator:
				return ICommonBtAlwaysTrueDecorator.Pack(builder, _o.AsICommonBtAlwaysTrueDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtDoOnceDecorator:
				return ICommonBtDoOnceDecorator.Pack(builder, _o.AsICommonBtDoOnceDecorator()).Value;
			case ICommonBtDecoratorBase_Union.ICommonBtCoolDownDecorator:
				return ICommonBtCoolDownDecorator.Pack(builder, _o.AsICommonBtCoolDownDecorator()).Value;
			default:
				return 0;
			}
		}
	}
}
