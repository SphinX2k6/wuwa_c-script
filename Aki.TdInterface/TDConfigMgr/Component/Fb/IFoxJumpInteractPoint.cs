using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CC1 RID: 3265
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoxJumpInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004AAA RID: 19114 RVA: 0x000BAD0E File Offset: 0x000B8F0E
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

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06004AAB RID: 19115 RVA: 0x000BAD2D File Offset: 0x000B8F2D
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x000BAD3A File Offset: 0x000B8F3A
		public virtual int LockConfigId
		{
			get
			{
				return this.Instance.LockConfigId;
			}
		}

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x06004AAD RID: 19117 RVA: 0x000BAD48 File Offset: 0x000B8F48
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x000BADB1 File Offset: 0x000B8FB1
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

		// Token: 0x04002AAC RID: 10924
		private IFoxJumpInteractPoint Instance;

		// Token: 0x04002AAD RID: 10925
		private List<ActionInfo> _ActionsCache;

		// Token: 0x04002AAE RID: 10926
		private bool _ActionsInited;

		// Token: 0x04002AAF RID: 10927
		private IFoxJumpInteractPointRelationType _PositionConfigCache;

		// Token: 0x04002AB0 RID: 10928
		private bool _PositionConfigInited;
	}
}
