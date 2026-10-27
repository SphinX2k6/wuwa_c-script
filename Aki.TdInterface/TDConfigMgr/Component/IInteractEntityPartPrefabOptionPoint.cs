using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000481 RID: 1153
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartPrefabOptionPoint
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x000469D8 File Offset: 0x00044BD8
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

		// Token: 0x06001735 RID: 5941 RVA: 0x00046A10 File Offset: 0x00044C10
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

		// Token: 0x06001736 RID: 5942 RVA: 0x00046A23 File Offset: 0x00044C23
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

		// Token: 0x06001737 RID: 5943 RVA: 0x00046A36 File Offset: 0x00044C36
		public IInteractEntityPartPrefabOptionPoint_SetValue ToSetValue()
		{
			return new IInteractEntityPartPrefabOptionPoint_SetValue
			{
				UiStyle = this.UiStyle,
				BindName = this.BindName
			};
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00046A55 File Offset: 0x00044C55
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00046A80 File Offset: 0x00044C80
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

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00046A8E File Offset: 0x00044C8E
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00046AB9 File Offset: 0x00044CB9
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

		// Token: 0x04001176 RID: 4470
		[Nullable(2)]
		protected IInteractEntityPartPrefabOptionPoint FbInstance;

		// Token: 0x04001177 RID: 4471
		[Nullable(2)]
		protected IInteractEntityPartPrefabOptionPoint_SetValue PocoInterface;
	}
}
