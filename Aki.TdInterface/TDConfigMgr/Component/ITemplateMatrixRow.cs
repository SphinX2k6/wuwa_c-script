using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000760 RID: 1888
	[NullableContext(1)]
	[Nullable(0)]
	public class ITemplateMatrixRow
	{
		// Token: 0x060028D5 RID: 10453 RVA: 0x0006C0DC File Offset: 0x0006A2DC
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

		// Token: 0x060028D6 RID: 10454 RVA: 0x0006C114 File Offset: 0x0006A314
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

		// Token: 0x060028D7 RID: 10455 RVA: 0x0006C127 File Offset: 0x0006A327
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

		// Token: 0x060028D8 RID: 10456 RVA: 0x0006C13A File Offset: 0x0006A33A
		public ITemplateMatrixRow_SetValue ToSetValue()
		{
			return new ITemplateMatrixRow_SetValue
			{
				Items = this.Items
			};
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0006C150 File Offset: 0x0006A350
		// (set) Token: 0x060028DA RID: 10458 RVA: 0x0006C1E3 File Offset: 0x0006A3E3
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

		// Token: 0x04001B76 RID: 7030
		[Nullable(2)]
		protected ITemplateMatrixRow FbInstance;

		// Token: 0x04001B77 RID: 7031
		[Nullable(2)]
		protected ITemplateMatrixRow_SetValue PocoInterface;

		// Token: 0x04001B78 RID: 7032
		private List<ISpawnTemplateEntityConfig> _ItemsCache;

		// Token: 0x04001B79 RID: 7033
		private bool _ItemsInited;
	}
}
