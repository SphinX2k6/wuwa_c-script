using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200047D RID: 1149
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractEntityPartModelOptionPoint
	{
		// Token: 0x06001720 RID: 5920 RVA: 0x00046768 File Offset: 0x00044968
		private IInteractEntityPartModelOptionPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractEntityPartModelOptionPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractEntityPartModelOptionPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractEntityPartModelOptionPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000467A0 File Offset: 0x000449A0
		public static IInteractEntityPartModelOptionPoint Create([Nullable(2)] IInteractEntityPartModelOptionPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractEntityPartModelOptionPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000467B3 File Offset: 0x000449B3
		public static IInteractEntityPartModelOptionPoint CreateFromSetValue([Nullable(2)] IInteractEntityPartModelOptionPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractEntityPartModelOptionPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x000467C6 File Offset: 0x000449C6
		public IInteractEntityPartModelOptionPoint_SetValue ToSetValue()
		{
			return new IInteractEntityPartModelOptionPoint_SetValue
			{
				UiStyle = this.UiStyle,
				BindName = this.BindName
			};
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x000467E5 File Offset: 0x000449E5
		// (set) Token: 0x06001725 RID: 5925 RVA: 0x00046810 File Offset: 0x00044A10
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

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x0004681E File Offset: 0x00044A1E
		// (set) Token: 0x06001727 RID: 5927 RVA: 0x00046849 File Offset: 0x00044A49
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

		// Token: 0x0400116C RID: 4460
		[Nullable(2)]
		protected IInteractEntityPartModelOptionPoint FbInstance;

		// Token: 0x0400116D RID: 4461
		[Nullable(2)]
		protected IInteractEntityPartModelOptionPoint_SetValue PocoInterface;
	}
}
