using System;
using System.Collections.Generic;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DA3 RID: 3491
	public class IFoxJumpInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004F58 RID: 20312 RVA: 0x000C571E File Offset: 0x000C391E
		public static IFoxJumpInteractPoint Create(IFoxJumpInteractPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxJumpInteractPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004F59 RID: 20313 RVA: 0x000C573D File Offset: 0x000C393D
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06004F5A RID: 20314 RVA: 0x000C574A File Offset: 0x000C394A
		public virtual int LockConfigId
		{
			get
			{
				return this.Instance.LockConfigId;
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x000C5758 File Offset: 0x000C3958
		public virtual List<ActionInfo> Actions
		{
			get
			{
				if (this._ActionsInited)
				{
					return this._ActionsCache;
				}
				this._ActionsInited = true;
				int actionsLength = this.Instance.ActionsLength;
				this._ActionsCache = new List<ActionInfo>(actionsLength);
				for (int i = 0; i < actionsLength; i++)
				{
					this._ActionsCache.Add(ActionInfo.Create(this.Instance.Actions(i)));
				}
				return this._ActionsCache;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06004F5C RID: 20316 RVA: 0x000C57C1 File Offset: 0x000C39C1
		public virtual IFoxJumpInteractPointRelationType PositionConfig
		{
			get
			{
				if (this._PositionConfigInited)
				{
					return this._PositionConfigCache;
				}
				this._PositionConfigInited = true;
				this._PositionConfigCache = ComponentReadHelper.ReadIFoxJumpInteractPoint_PositionConfig(this.Instance);
				return this._PositionConfigCache;
			}
		}

		// Token: 0x04002D26 RID: 11558
		private IFoxJumpInteractPoint Instance;

		// Token: 0x04002D27 RID: 11559
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002D28 RID: 11560
		private bool _ActionsInited;

		// Token: 0x04002D29 RID: 11561
		private IFoxJumpInteractPointRelationType _PositionConfigCache;

		// Token: 0x04002D2A RID: 11562
		private bool _PositionConfigInited;
	}
}
