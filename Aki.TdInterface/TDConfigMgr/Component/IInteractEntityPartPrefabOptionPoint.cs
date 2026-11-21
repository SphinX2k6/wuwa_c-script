using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004DA RID: 1242
	public class IInteractEntityPartPrefabOptionPoint
	{
		// Token: 0x060018CE RID: 6350 RVA: 0x0004A720 File Offset: 0x00048920
		private IInteractEntityPartPrefabOptionPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEntityPartPrefabOptionPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEntityPartPrefabOptionPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEntityPartPrefabOptionPoint_SetValue());
			}
			return result;
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0004A758 File Offset: 0x00048958
		public static IInteractEntityPartPrefabOptionPoint Create([Nullable(2)] IInteractEntityPartPrefabOptionPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabOptionPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0004A76B File Offset: 0x0004896B
		public static IInteractEntityPartPrefabOptionPoint CreateFromSetValue([Nullable(2)] IInteractEntityPartPrefabOptionPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEntityPartPrefabOptionPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0004A77E File Offset: 0x0004897E
		public IInteractEntityPartPrefabOptionPoint_SetValue ToSetValue()
		{
			return new IInteractEntityPartPrefabOptionPoint_SetValue
			{
				UiStyle = this.UiStyle,
				BindName = this.BindName
			};
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x0004A79D File Offset: 0x0004899D
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0004A7C8 File Offset: 0x000489C8
		public virtual string UiStyle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiStyle;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.UiStyle;
			}
			set
			{
				this.GetOrCreatePoco().UiStyle = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0004A7D6 File Offset: 0x000489D6
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x0004A801 File Offset: 0x00048A01
		public virtual string BindName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BindName;
			}
			set
			{
				this.GetOrCreatePoco().BindName = value;
			}
		}

		// Token: 0x04001298 RID: 4760
		[Nullable(2)]
		protected IInteractEntityPartPrefabOptionPoint FbInstance;

		// Token: 0x04001299 RID: 4761
		[Nullable(2)]
		protected IInteractEntityPartPrefabOptionPoint_SetValue PocoInterface;
	}
}
