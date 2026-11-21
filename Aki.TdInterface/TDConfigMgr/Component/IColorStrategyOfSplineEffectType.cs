using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000290 RID: 656
	public class IColorStrategyOfSplineEffectType
	{
		// Token: 0x06000BB6 RID: 2998 RVA: 0x0002EAA0 File Offset: 0x0002CCA0
		private IColorStrategyOfSplineEffectType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IColorStrategyOfSplineEffectType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IColorStrategyOfSplineEffectType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IColorStrategyOfSplineEffectType_SetValue());
			}
			return result;
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0002EAD8 File Offset: 0x0002CCD8
		public static IColorStrategyOfSplineEffectType Create([Nullable(2)] IColorStrategyOfSplineEffectType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IColorStrategyOfSplineEffectType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0002EAEB File Offset: 0x0002CCEB
		public static IColorStrategyOfSplineEffectType CreateFromSetValue([Nullable(2)] IColorStrategyOfSplineEffectType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IColorStrategyOfSplineEffectType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0002EAFE File Offset: 0x0002CCFE
		public IColorStrategyOfSplineEffectType_SetValue ToSetValue()
		{
			return new IColorStrategyOfSplineEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BBA RID: 3002 RVA: 0x0002EB11 File Offset: 0x0002CD11
		// (set) Token: 0x06000BBB RID: 3003 RVA: 0x0002EB3C File Offset: 0x0002CD3C
		public virtual EColorChangeStrategyOfSplineEffect Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EColorChangeStrategyOfSplineEffect.RGB;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000B65 RID: 2917
		[Nullable(2)]
		protected IColorStrategyOfSplineEffectType FbInstance;

		// Token: 0x04000B66 RID: 2918
		[Nullable(2)]
		protected IColorStrategyOfSplineEffectType_SetValue PocoInterface;
	}
}
