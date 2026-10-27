using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003BC RID: 956
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxJumpInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06001315 RID: 4885 RVA: 0x0003E4F0 File Offset: 0x0003C6F0
		private IFoxJumpInteractPoint_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxJumpInteractPoint 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxJumpInteractPoint_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxJumpInteractPoint_SetValue());
			}
			return result;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0003E528 File Offset: 0x0003C728
		public static IFoxJumpInteractPoint Create([Nullable(2)] IFoxJumpInteractPoint instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxJumpInteractPoint
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0003E53B File Offset: 0x0003C73B
		public static IFoxJumpInteractPoint CreateFromSetValue([Nullable(2)] IFoxJumpInteractPoint_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxJumpInteractPoint
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0003E54E File Offset: 0x0003C74E
		public new IFoxJumpInteractPoint_SetValue ToSetValue()
		{
			return new IFoxJumpInteractPoint_SetValue
			{
				Type = this.Type,
				LockConfigId = this.LockConfigId,
				Actions = this.Actions,
				PositionConfig = this.PositionConfig
			};
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0003E585 File Offset: 0x0003C785
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0003E5B0 File Offset: 0x0003C7B0
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

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x0003E5BE File Offset: 0x0003C7BE
		// (set) Token: 0x0600131C RID: 4892 RVA: 0x0003E5E9 File Offset: 0x0003C7E9
		public virtual int LockConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LockConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LockConfigId;
			}
			set
			{
				this.GetOrCreatePoco().LockConfigId = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0003E5F8 File Offset: 0x0003C7F8
		// (set) Token: 0x0600131E RID: 4894 RVA: 0x0003E68B File Offset: 0x0003C88B
		public virtual List<Aki.TDConfigMgr.Action.ActionInfo> Actions
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
					IFoxJumpInteractPoint_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0003E6A0 File Offset: 0x0003C8A0
		// (set) Token: 0x06001320 RID: 4896 RVA: 0x0003E6C7 File Offset: 0x0003C8C7
		public virtual IFoxJumpInteractPointRelationType PositionConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionConfig;
				}
				IFoxJumpInteractPoint_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PositionConfig;
			}
			set
			{
				this.GetOrCreatePoco().PositionConfig = value;
			}
		}

		// Token: 0x04000F3D RID: 3901
		[Nullable(2)]
		protected new IFoxJumpInteractPoint FbInstance;

		// Token: 0x04000F3E RID: 3902
		[Nullable(2)]
		protected new IFoxJumpInteractPoint_SetValue PocoInterface;

		// Token: 0x04000F3F RID: 3903
		private List<Aki.TDConfigMgr.Action.ActionInfo> _ActionsCache;

		// Token: 0x04000F40 RID: 3904
		private bool _ActionsInited;
	}
}
