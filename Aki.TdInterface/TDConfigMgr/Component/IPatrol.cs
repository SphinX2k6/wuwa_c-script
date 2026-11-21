using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000671 RID: 1649
	public class IPatrol : IComponentBase
	{
		// Token: 0x060022A4 RID: 8868 RVA: 0x0005F67C File Offset: 0x0005D87C
		private IPatrol_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrol 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrol_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrol_SetValue());
			}
			return result;
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		public static IPatrol Create([Nullable(2)] IPatrol instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrol
			{
				FbInstance = instance
			};
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0005F6C7 File Offset: 0x0005D8C7
		public static IPatrol CreateFromSetValue([Nullable(2)] IPatrol_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrol
			{
				PocoInterface = value
			};
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0005F6DC File Offset: 0x0005D8DC
		public new IPatrol_SetValue ToSetValue()
		{
			return new IPatrol_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				SplineEntityId = this.SplineEntityId,
				SplineEntityIds = this.SplineEntityIds,
				IsCircle = this.IsCircle,
				Actions = this.Actions
			};
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0005F738 File Offset: 0x0005D938
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0005F772 File Offset: 0x0005D972
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				IPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0005F780 File Offset: 0x0005D980
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x0005F7AA File Offset: 0x0005D9AA
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0005F7B8 File Offset: 0x0005D9B8
		// (set) Token: 0x060022AD RID: 8877 RVA: 0x0005F7E3 File Offset: 0x0005D9E3
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x060022AE RID: 8878 RVA: 0x0005F7F1 File Offset: 0x0005D9F1
		// (set) Token: 0x060022AF RID: 8879 RVA: 0x0005F818 File Offset: 0x0005DA18
		[Nullable(2)]
		public virtual List<int> SplineEntityIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityIds;
				}
				IPatrol_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SplineEntityIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SplineEntityIds = value;
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x0005F826 File Offset: 0x0005DA26
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x0005F851 File Offset: 0x0005DA51
		public virtual bool IsCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCircle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsCircle = value;
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0005F860 File Offset: 0x0005DA60
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0005F8F3 File Offset: 0x0005DAF3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IPatrolAction> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				if (this.FbInstance != null)
				{
					List<IPatrolAction> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<IPatrolAction>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(IPatrolAction.Create(actions[i]));
						}
					}
				}
				else
				{
					IPatrol_SetValue pocoInterface = this.PocoInterface;
					this._ActionsCache = ((pocoInterface != null) ? pocoInterface.Actions : null);
				}
				return this._ActionsCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001840 RID: 6208
		[Nullable(2)]
		protected new IPatrol FbInstance;

		// Token: 0x04001841 RID: 6209
		[Nullable(2)]
		protected new IPatrol_SetValue PocoInterface;

		// Token: 0x04001842 RID: 6210
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IPatrolAction> _ActionsCache;

		// Token: 0x04001843 RID: 6211
		private bool _ActionsInited;
	}
}
