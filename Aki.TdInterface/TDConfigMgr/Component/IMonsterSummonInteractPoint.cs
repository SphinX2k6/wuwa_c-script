using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200051A RID: 1306
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterSummonInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06001A74 RID: 6772 RVA: 0x0004D07C File Offset: 0x0004B27C
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

		// Token: 0x06001A75 RID: 6773 RVA: 0x0004D0B4 File Offset: 0x0004B2B4
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

		// Token: 0x06001A76 RID: 6774 RVA: 0x0004D0C7 File Offset: 0x0004B2C7
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

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004D0DA File Offset: 0x0004B2DA
		public new IMonsterSummonInteractPoint_SetValue ToSetValue()
		{
			return new IMonsterSummonInteractPoint_SetValue
			{
				Type = this.Type,
				Range = this.Range,
				Actions = this.Actions
			};
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0004D105 File Offset: 0x0004B305
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0004D130 File Offset: 0x0004B330
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

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0004D13E File Offset: 0x0004B33E
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0004D16D File Offset: 0x0004B36D
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

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0004D17C File Offset: 0x0004B37C
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0004D20F File Offset: 0x0004B40F
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().Actions = value;
				this._ActionsInited = false;
			}
		}

		// Token: 0x04001326 RID: 4902
		[Nullable(2)]
		protected new IMonsterSummonInteractPoint FbInstance;

		// Token: 0x04001327 RID: 4903
		[Nullable(2)]
		protected new IMonsterSummonInteractPoint_SetValue PocoInterface;

		// Token: 0x04001328 RID: 4904
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04001329 RID: 4905
		private bool _ActionsInited;
	}
}
