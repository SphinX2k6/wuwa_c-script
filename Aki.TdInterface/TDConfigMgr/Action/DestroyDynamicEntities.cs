using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200155C RID: 5468
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyDynamicEntities : ActionParams
	{
		// Token: 0x06007B89 RID: 31625 RVA: 0x001299D4 File Offset: 0x00127BD4
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

		// Token: 0x06007B8A RID: 31626 RVA: 0x00129A0C File Offset: 0x00127C0C
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

		// Token: 0x06007B8B RID: 31627 RVA: 0x00129A1F File Offset: 0x00127C1F
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

		// Token: 0x06007B8C RID: 31628 RVA: 0x00129A32 File Offset: 0x00127C32
		public DestroyDynamicEntities_SetValue ToSetValue()
		{
			return new DestroyDynamicEntities_SetValue
			{
				DestroyEntitiesConfig = this.DestroyEntitiesConfig
			};
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x00129A48 File Offset: 0x00127C48
		// (set) Token: 0x06007B8E RID: 31630 RVA: 0x00129AA9 File Offset: 0x00127CA9
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

		// Token: 0x04004725 RID: 18213
		[Nullable(2)]
		protected new DestroyDynamicEntities FbInstance;

		// Token: 0x04004726 RID: 18214
		[Nullable(2)]
		protected DestroyDynamicEntities_SetValue PocoInterface;

		// Token: 0x04004727 RID: 18215
		private IDestroyVisionDisplay _DestroyEntitiesConfigCache;

		// Token: 0x04004728 RID: 18216
		private bool _DestroyEntitiesConfigInited;
	}
}
