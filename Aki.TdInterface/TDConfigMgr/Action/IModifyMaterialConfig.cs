using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD7 RID: 7639
	public class IModifyMaterialConfig
	{
		// Token: 0x0600A22F RID: 41519 RVA: 0x0017347C File Offset: 0x0017167C
		private IModifyMaterialConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyMaterialConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyMaterialConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyMaterialConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x001734B4 File Offset: 0x001716B4
		public static IModifyMaterialConfig Create([Nullable(2)] IModifyMaterialConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMaterialConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x001734C7 File Offset: 0x001716C7
		public static IModifyMaterialConfig CreateFromSetValue([Nullable(2)] IModifyMaterialConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyMaterialConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x001734DA File Offset: 0x001716DA
		public IModifyMaterialConfig_SetValue ToSetValue()
		{
			return new IModifyMaterialConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600A233 RID: 41523 RVA: 0x001734ED File Offset: 0x001716ED
		// (set) Token: 0x0600A234 RID: 41524 RVA: 0x00173518 File Offset: 0x00171718
		public virtual EModifyActorMaterialType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006260 RID: 25184
		[Nullable(2)]
		protected IModifyMaterialConfig FbInstance;

		// Token: 0x04006261 RID: 25185
		[Nullable(2)]
		protected IModifyMaterialConfig_SetValue PocoInterface;
	}
}
