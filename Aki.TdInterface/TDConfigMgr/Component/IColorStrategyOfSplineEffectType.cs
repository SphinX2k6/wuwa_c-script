using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024F RID: 591
	[NullableContext(1)]
	[Nullable(0)]
	public class IColorStrategyOfSplineEffectType
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
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

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0002BF28 File Offset: 0x0002A128
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

		// Token: 0x06000AAA RID: 2730 RVA: 0x0002BF3B File Offset: 0x0002A13B
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

		// Token: 0x06000AAB RID: 2731 RVA: 0x0002BF4E File Offset: 0x0002A14E
		public IColorStrategyOfSplineEffectType_SetValue ToSetValue()
		{
			return new IColorStrategyOfSplineEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0002BF61 File Offset: 0x0002A161
		// (set) Token: 0x06000AAD RID: 2733 RVA: 0x0002BF8C File Offset: 0x0002A18C
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

		// Token: 0x04000A89 RID: 2697
		[Nullable(2)]
		protected IColorStrategyOfSplineEffectType FbInstance;

		// Token: 0x04000A8A RID: 2698
		[Nullable(2)]
		protected IColorStrategyOfSplineEffectType_SetValue PocoInterface;
	}
}
