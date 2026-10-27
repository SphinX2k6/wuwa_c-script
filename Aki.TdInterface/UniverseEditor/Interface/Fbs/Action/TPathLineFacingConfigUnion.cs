using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007747 RID: 30535
	public class TPathLineFacingConfigUnion
	{
		// Token: 0x1700E673 RID: 58995
		// (get) Token: 0x060377A4 RID: 227236 RVA: 0x0078288C File Offset: 0x00780A8C
		// (set) Token: 0x060377A5 RID: 227237 RVA: 0x00782894 File Offset: 0x00780A94
		public TPathLineFacingConfig Type { get; set; }

		// Token: 0x1700E674 RID: 58996
		// (get) Token: 0x060377A6 RID: 227238 RVA: 0x0078289D File Offset: 0x00780A9D
		// (set) Token: 0x060377A7 RID: 227239 RVA: 0x007828A5 File Offset: 0x00780AA5
		public object Value { get; set; }

		// Token: 0x060377A8 RID: 227240 RVA: 0x007828AE File Offset: 0x00780AAE
		public TPathLineFacingConfigUnion()
		{
			this.Type = TPathLineFacingConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060377A9 RID: 227241 RVA: 0x007828C4 File Offset: 0x00780AC4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060377AA RID: 227242 RVA: 0x007828D6 File Offset: 0x00780AD6
		public IPathLineFacingCurrentDirectionT AsIPathLineFacingCurrentDirection()
		{
			return this.As<IPathLineFacingCurrentDirectionT>();
		}

		// Token: 0x060377AB RID: 227243 RVA: 0x007828DE File Offset: 0x00780ADE
		public static TPathLineFacingConfigUnion FromIPathLineFacingCurrentDirection(IPathLineFacingCurrentDirectionT _ipathlinefacingcurrentdirection)
		{
			return new TPathLineFacingConfigUnion
			{
				Type = TPathLineFacingConfig.IPathLineFacingCurrentDirection,
				Value = _ipathlinefacingcurrentdirection
			};
		}

		// Token: 0x060377AC RID: 227244 RVA: 0x007828F3 File Offset: 0x00780AF3
		public IPathLineFacingCustomDirectionT AsIPathLineFacingCustomDirection()
		{
			return this.As<IPathLineFacingCustomDirectionT>();
		}

		// Token: 0x060377AD RID: 227245 RVA: 0x007828FB File Offset: 0x00780AFB
		public static TPathLineFacingConfigUnion FromIPathLineFacingCustomDirection(IPathLineFacingCustomDirectionT _ipathlinefacingcustomdirection)
		{
			return new TPathLineFacingConfigUnion
			{
				Type = TPathLineFacingConfig.IPathLineFacingCustomDirection,
				Value = _ipathlinefacingcustomdirection
			};
		}

		// Token: 0x060377AE RID: 227246 RVA: 0x00782910 File Offset: 0x00780B10
		public static int Pack(FlatBufferBuilder builder, TPathLineFacingConfigUnion _o)
		{
			TPathLineFacingConfig type = _o.Type;
			if (type == TPathLineFacingConfig.IPathLineFacingCurrentDirection)
			{
				return IPathLineFacingCurrentDirection.Pack(builder, _o.AsIPathLineFacingCurrentDirection()).Value;
			}
			if (type != TPathLineFacingConfig.IPathLineFacingCustomDirection)
			{
				return 0;
			}
			return IPathLineFacingCustomDirection.Pack(builder, _o.AsIPathLineFacingCustomDirection()).Value;
		}
	}
}
