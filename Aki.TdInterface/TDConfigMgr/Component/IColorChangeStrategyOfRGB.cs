using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200024D RID: 589
	[NullableContext(1)]
	[Nullable(0)]
	public class IColorChangeStrategyOfRGB : IColorStrategyOfSplineEffectType
	{
		// Token: 0x06000A9A RID: 2714 RVA: 0x0002BD64 File Offset: 0x00029F64
		private IColorChangeStrategyOfRGB_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IColorChangeStrategyOfRGB 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IColorChangeStrategyOfRGB_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IColorChangeStrategyOfRGB_SetValue());
			}
			return result;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0002BD9C File Offset: 0x00029F9C
		public static IColorChangeStrategyOfRGB Create([Nullable(2)] IColorChangeStrategyOfRGB instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IColorChangeStrategyOfRGB
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0002BDAF File Offset: 0x00029FAF
		public static IColorChangeStrategyOfRGB CreateFromSetValue([Nullable(2)] IColorChangeStrategyOfRGB_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IColorChangeStrategyOfRGB
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0002BDC2 File Offset: 0x00029FC2
		public new IColorChangeStrategyOfRGB_SetValue ToSetValue()
		{
			return new IColorChangeStrategyOfRGB_SetValue
			{
				Type = this.Type,
				BlueState = this.BlueState,
				YellowState = this.YellowState,
				RedState = this.RedState
			};
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0002BDF9 File Offset: 0x00029FF9
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0002BE24 File Offset: 0x0002A024
		public override EColorChangeStrategyOfSplineEffect Type
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

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002BE32 File Offset: 0x0002A032
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0002BE5D File Offset: 0x0002A05D
		public virtual string BlueState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlueState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BlueState;
			}
			set
			{
				this.GetOrCreatePoco().BlueState = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002BE6B File Offset: 0x0002A06B
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0002BE96 File Offset: 0x0002A096
		public virtual string YellowState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YellowState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.YellowState;
			}
			set
			{
				this.GetOrCreatePoco().YellowState = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x0002BECF File Offset: 0x0002A0CF
		public virtual string RedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RedState;
			}
			set
			{
				this.GetOrCreatePoco().RedState = value;
			}
		}

		// Token: 0x04000A83 RID: 2691
		[Nullable(2)]
		protected new IColorChangeStrategyOfRGB FbInstance;

		// Token: 0x04000A84 RID: 2692
		[Nullable(2)]
		protected new IColorChangeStrategyOfRGB_SetValue PocoInterface;
	}
}
