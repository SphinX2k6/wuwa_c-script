using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F9 RID: 761
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectSplineWholeLineMode : IEffectSplineCreationMode
	{
		// Token: 0x06000EAF RID: 3759 RVA: 0x00034CB8 File Offset: 0x00032EB8
		private IEffectSplineWholeLineMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEffectSplineWholeLineMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEffectSplineWholeLineMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEffectSplineWholeLineMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00034CF0 File Offset: 0x00032EF0
		public static IEffectSplineWholeLineMode Create([Nullable(2)] IEffectSplineWholeLineMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEffectSplineWholeLineMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00034D03 File Offset: 0x00032F03
		public static IEffectSplineWholeLineMode CreateFromSetValue([Nullable(2)] IEffectSplineWholeLineMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEffectSplineWholeLineMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00034D16 File Offset: 0x00032F16
		public new IEffectSplineWholeLineMode_SetValue ToSetValue()
		{
			return new IEffectSplineWholeLineMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x00034D29 File Offset: 0x00032F29
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x00034D54 File Offset: 0x00032F54
		public override EEffectSplineCreateMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectSplineCreateMode.WholeLine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000CE6 RID: 3302
		[Nullable(2)]
		protected new IEffectSplineWholeLineMode FbInstance;

		// Token: 0x04000CE7 RID: 3303
		[Nullable(2)]
		protected new IEffectSplineWholeLineMode_SetValue PocoInterface;
	}
}
