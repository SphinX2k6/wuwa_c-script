using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000581 RID: 1409
	public class IMonsterSummonInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06001C70 RID: 7280 RVA: 0x00051E38 File Offset: 0x00050038
		private IMonsterSummonInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterSummonInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterSummonInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterSummonInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x00051E70 File Offset: 0x00050070
		public static IMonsterSummonInteractPoint Create([Nullable(2)] IMonsterSummonInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterSummonInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00051E83 File Offset: 0x00050083
		public static IMonsterSummonInteractPoint CreateFromSetValue([Nullable(2)] IMonsterSummonInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterSummonInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00051E96 File Offset: 0x00050096
		public new IMonsterSummonInteractPoint_SetValue ToSetValue()
		{
			return new IMonsterSummonInteractPoint_SetValue
			{
				Type = this.Type,
				Range = this.Range,
				Actions = this.Actions
			};
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00051EC1 File Offset: 0x000500C1
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x00051EEC File Offset: 0x000500EC
		public override EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00051EFA File Offset: 0x000500FA
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00051F29 File Offset: 0x00050129
		public virtual float Range
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Range;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Range;
			}
			set
			{
				this.GetOrCreatePoco().Range = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00051F38 File Offset: 0x00050138
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x00051FCB File Offset: 0x000501CB
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
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
					List<Aki.TDConfigMgr.Action.Fb.ActionInfo> actions = this.FbInstance.Actions;
					if (actions != null)
					{
						this._ActionsCache = new List<Aki.TDConfigMgr.Action.ActionInfo>(actions.Count);
						for (int i = 0; i < actions.Count; i++)
						{
							this._ActionsCache.Add(Aki.TDConfigMgr.Action.ActionInfo.Create(actions[i]));
						}
					}
				}
				else
				{
					IMonsterSummonInteractPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04001490 RID: 5264
		[Nullable(2)]
		protected new IMonsterSummonInteractPoint FbInstance;

		// Token: 0x04001491 RID: 5265
		[Nullable(2)]
		protected new IMonsterSummonInteractPoint_SetValue PocoInterface;

		// Token: 0x04001492 RID: 5266
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001493 RID: 5267
		private bool _ActionsInited;
	}
}
