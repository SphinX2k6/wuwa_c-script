using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AC1 RID: 6849
	[NullableContext(1)]
	[Nullable(0)]
	public class IFunction
	{
		// Token: 0x060092E4 RID: 37604 RVA: 0x001553E0 File Offset: 0x001535E0
		private IFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFunction_SetValue());
			}
			return result;
		}

		// Token: 0x060092E5 RID: 37605 RVA: 0x00155418 File Offset: 0x00153618
		public static IFunction Create([Nullable(2)] IFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092E6 RID: 37606 RVA: 0x0015542B File Offset: 0x0015362B
		public static IFunction CreateFromSetValue([Nullable(2)] IFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092E7 RID: 37607 RVA: 0x0015543E File Offset: 0x0015363E
		public IFunction_SetValue ToSetValue()
		{
			return new IFunction_SetValue
			{
				Name = this.Name,
				Actions = this.Actions
			};
		}

		// Token: 0x17002EA6 RID: 11942
		// (get) Token: 0x060092E8 RID: 37608 RVA: 0x0015545D File Offset: 0x0015365D
		// (set) Token: 0x060092E9 RID: 37609 RVA: 0x00155488 File Offset: 0x00153688
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x17002EA7 RID: 11943
		// (get) Token: 0x060092EA RID: 37610 RVA: 0x00155498 File Offset: 0x00153698
		// (set) Token: 0x060092EB RID: 37611 RVA: 0x0015552B File Offset: 0x0015372B
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IFunction_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04005A5F RID: 23135
		[Nullable(2)]
		protected IFunction FbInstance;

		// Token: 0x04005A60 RID: 23136
		[Nullable(2)]
		protected IFunction_SetValue PocoInterface;

		// Token: 0x04005A61 RID: 23137
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04005A62 RID: 23138
		private bool _ActionsInited;
	}
}
