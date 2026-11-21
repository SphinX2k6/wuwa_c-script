using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EAD RID: 7853
	public class IOpenQteConfig
	{
		// Token: 0x0600A715 RID: 42773 RVA: 0x0017C4A4 File Offset: 0x0017A6A4
		private IOpenQteConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenQteConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenQteConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenQteConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x0017C4DC File Offset: 0x0017A6DC
		public static IOpenQteConfig Create([Nullable(2)] IOpenQteConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenQteConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x0017C4EF File Offset: 0x0017A6EF
		public static IOpenQteConfig CreateFromSetValue([Nullable(2)] IOpenQteConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenQteConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x0017C502 File Offset: 0x0017A702
		public IOpenQteConfig_SetValue ToSetValue()
		{
			return new IOpenQteConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600A719 RID: 42777 RVA: 0x0017C515 File Offset: 0x0017A715
		// (set) Token: 0x0600A71A RID: 42778 RVA: 0x0017C540 File Offset: 0x0017A740
		public virtual EOpenQteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOpenQteType.PanelQte;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064A6 RID: 25766
		[Nullable(2)]
		protected IOpenQteConfig FbInstance;

		// Token: 0x040064A7 RID: 25767
		[Nullable(2)]
		protected IOpenQteConfig_SetValue PocoInterface;
	}
}
