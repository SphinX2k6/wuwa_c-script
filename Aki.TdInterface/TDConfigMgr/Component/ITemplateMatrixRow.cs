using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000801 RID: 2049
	public class ITemplateMatrixRow
	{
		// Token: 0x06002BF9 RID: 11257 RVA: 0x00073284 File Offset: 0x00071484
		private ITemplateMatrixRow_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITemplateMatrixRow 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITemplateMatrixRow_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITemplateMatrixRow_SetValue());
			}
			return result;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000732BC File Offset: 0x000714BC
		public static ITemplateMatrixRow Create([Nullable(2)] ITemplateMatrixRow instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITemplateMatrixRow
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000732CF File Offset: 0x000714CF
		public static ITemplateMatrixRow CreateFromSetValue([Nullable(2)] ITemplateMatrixRow_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITemplateMatrixRow
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000732E2 File Offset: 0x000714E2
		public ITemplateMatrixRow_SetValue ToSetValue()
		{
			return new ITemplateMatrixRow_SetValue
			{
				Items = this.Items
			};
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000732F8 File Offset: 0x000714F8
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x0007338B File Offset: 0x0007158B
		public virtual List<ISpawnTemplateEntityConfig> Items
		{
			get
			{
				if (this._ItemsInited)
				{
					return this._ItemsCache;
				}
				this._ItemsInited = true;
				if (this.FbInstance != null)
				{
					List<ISpawnTemplateEntityConfig> items = this.FbInstance.Items;
					if (items != null)
					{
						this._ItemsCache = new List<ISpawnTemplateEntityConfig>(items.Count);
						for (int i = 0; i < items.Count; i++)
						{
							this._ItemsCache.Add(ISpawnTemplateEntityConfig.Create(items[i]));
						}
					}
				}
				else
				{
					ITemplateMatrixRow_SetValue pocoInterface = this.PocoInterface;
					this._ItemsCache = ((pocoInterface != null) ? pocoInterface.Items : null);
				}
				return this._ItemsCache;
			}
			set
			{
				this.GetOrCreatePoco().Items = value;
				this._ItemsInited = false;
			}
		}

		// Token: 0x04001D7B RID: 7547
		[Nullable(2)]
		protected ITemplateMatrixRow FbInstance;

		// Token: 0x04001D7C RID: 7548
		[Nullable(2)]
		protected ITemplateMatrixRow_SetValue PocoInterface;

		// Token: 0x04001D7D RID: 7549
		private List<ISpawnTemplateEntityConfig> _ItemsCache;

		// Token: 0x04001D7E RID: 7550
		private bool _ItemsInited;
	}
}
