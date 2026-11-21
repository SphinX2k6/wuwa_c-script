using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200028E RID: 654
	public class IColorChangeStrategyOfRGB : IColorStrategyOfSplineEffectType
	{
		// Token: 0x06000BA8 RID: 2984 RVA: 0x0002E914 File Offset: 0x0002CB14
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

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0002E94C File Offset: 0x0002CB4C
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

		// Token: 0x06000BAA RID: 2986 RVA: 0x0002E95F File Offset: 0x0002CB5F
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

		// Token: 0x06000BAB RID: 2987 RVA: 0x0002E972 File Offset: 0x0002CB72
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0002E9A9 File Offset: 0x0002CBA9
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0002E9D4 File Offset: 0x0002CBD4
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

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0002E9E2 File Offset: 0x0002CBE2
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0002EA0D File Offset: 0x0002CC0D
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

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0002EA1B File Offset: 0x0002CC1B
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0002EA46 File Offset: 0x0002CC46
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

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0002EA54 File Offset: 0x0002CC54
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0002EA7F File Offset: 0x0002CC7F
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

		// Token: 0x04000B5F RID: 2911
		[Nullable(2)]
		protected new IColorChangeStrategyOfRGB FbInstance;

		// Token: 0x04000B60 RID: 2912
		[Nullable(2)]
		protected new IColorChangeStrategyOfRGB_SetValue PocoInterface;
	}
}
