using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000439 RID: 1081
	public class IGraph3dEffectBase
	{
		// Token: 0x0600158D RID: 5517 RVA: 0x00044114 File Offset: 0x00042314
		private IGraph3dEffectBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGraph3dEffectBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGraph3dEffectBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGraph3dEffectBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0004414C File Offset: 0x0004234C
		public static IGraph3dEffectBase Create([Nullable(2)] IGraph3dEffectBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGraph3dEffectBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0004415F File Offset: 0x0004235F
		public static IGraph3dEffectBase CreateFromSetValue([Nullable(2)] IGraph3dEffectBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGraph3dEffectBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00044172 File Offset: 0x00042372
		public IGraph3dEffectBase_SetValue ToSetValue()
		{
			return new IGraph3dEffectBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00044185 File Offset: 0x00042385
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x000441B0 File Offset: 0x000423B0
		public virtual EGraph3dEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGraph3dEffectType.FireBoxFish;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040010EA RID: 4330
		[Nullable(2)]
		protected IGraph3dEffectBase FbInstance;

		// Token: 0x040010EB RID: 4331
		[Nullable(2)]
		protected IGraph3dEffectBase_SetValue PocoInterface;
	}
}
