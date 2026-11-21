using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016BA RID: 5818
	public class DestroyDynamicEntities : ActionParams
	{
		// Token: 0x06008267 RID: 33383 RVA: 0x00138A80 File Offset: 0x00136C80
		private DestroyDynamicEntities_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroyDynamicEntities 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroyDynamicEntities_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroyDynamicEntities_SetValue());
			}
			return result;
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x00138AB8 File Offset: 0x00136CB8
		public static DestroyDynamicEntities Create([Nullable(2)] DestroyDynamicEntities instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyDynamicEntities
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x00138ACB File Offset: 0x00136CCB
		public static DestroyDynamicEntities CreateFromSetValue([Nullable(2)] DestroyDynamicEntities_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroyDynamicEntities
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x00138ADE File Offset: 0x00136CDE
		public DestroyDynamicEntities_SetValue ToSetValue()
		{
			return new DestroyDynamicEntities_SetValue
			{
				DestroyEntitiesConfig = this.DestroyEntitiesConfig
			};
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600826B RID: 33387 RVA: 0x00138AF4 File Offset: 0x00136CF4
		// (set) Token: 0x0600826C RID: 33388 RVA: 0x00138B55 File Offset: 0x00136D55
		public virtual IDestroyVisionDisplay DestroyEntitiesConfig
		{
			get
			{
				if (this._DestroyEntitiesConfigInited)
				{
					return this._DestroyEntitiesConfigCache;
				}
				this._DestroyEntitiesConfigInited = true;
				if (this.FbInstance != null)
				{
					this._DestroyEntitiesConfigCache = IDestroyVisionDisplay.Create(this.FbInstance.DestroyEntitiesConfig);
				}
				else
				{
					DestroyDynamicEntities_SetValue pocoInterface = this.PocoInterface;
					this._DestroyEntitiesConfigCache = ((pocoInterface != null) ? pocoInterface.DestroyEntitiesConfig : null);
				}
				return this._DestroyEntitiesConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().DestroyEntitiesConfig = value;
				this._DestroyEntitiesConfigInited = false;
			}
		}

		// Token: 0x04004AC5 RID: 19141
		[Nullable(2)]
		protected new DestroyDynamicEntities FbInstance;

		// Token: 0x04004AC6 RID: 19142
		[Nullable(2)]
		protected DestroyDynamicEntities_SetValue PocoInterface;

		// Token: 0x04004AC7 RID: 19143
		private IDestroyVisionDisplay _DestroyEntitiesConfigCache;

		// Token: 0x04004AC8 RID: 19144
		private bool _DestroyEntitiesConfigInited;
	}
}
