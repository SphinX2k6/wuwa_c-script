using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D6 RID: 1238
	public class IInteractEntityPartModelOptionPoint
	{
		// Token: 0x060018BA RID: 6330 RVA: 0x0004A4B0 File Offset: 0x000486B0
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

		// Token: 0x060018BB RID: 6331 RVA: 0x0004A4E8 File Offset: 0x000486E8
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

		// Token: 0x060018BC RID: 6332 RVA: 0x0004A4FB File Offset: 0x000486FB
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

		// Token: 0x060018BD RID: 6333 RVA: 0x0004A50E File Offset: 0x0004870E
		public IInteractEntityPartModelOptionPoint_SetValue ToSetValue()
		{
			return new IInteractEntityPartModelOptionPoint_SetValue
			{
				UiStyle = this.UiStyle,
				BindName = this.BindName
			};
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0004A52D File Offset: 0x0004872D
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x0004A558 File Offset: 0x00048758
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

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x0004A566 File Offset: 0x00048766
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0004A591 File Offset: 0x00048791
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

		// Token: 0x0400128E RID: 4750
		[Nullable(2)]
		protected IInteractEntityPartModelOptionPoint FbInstance;

		// Token: 0x0400128F RID: 4751
		[Nullable(2)]
		protected IInteractEntityPartModelOptionPoint_SetValue PocoInterface;
	}
}
