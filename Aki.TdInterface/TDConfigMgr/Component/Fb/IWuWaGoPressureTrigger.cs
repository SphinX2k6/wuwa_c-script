using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F06 RID: 3846
	public class IWuWaGoPressureTrigger : IWuWaGoEntityBase
	{
		// Token: 0x06005681 RID: 22145 RVA: 0x000D4419 File Offset: 0x000D2619
		public static IWuWaGoPressureTrigger Create(IWuWaGoPressureTrigger? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoPressureTrigger
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x000D4438 File Offset: 0x000D2638
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x000D4445 File Offset: 0x000D2645
		public virtual IWuWaGoGridLinkData LinkData
		{
			get
			{
				if (this._LinkDataInited)
				{
					return this._LinkDataCache;
				}
				this._LinkDataInited = true;
				this._LinkDataCache = IWuWaGoGridLinkData.Create(this.Instance.LinkData);
				return this._LinkDataCache;
			}
		}

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x000D447C File Offset: 0x000D267C
		public virtual List<ActionInfo> EnterActionList
		{
			get
			{
				if (this._EnterActionListInited)
				{
					return this._EnterActionListCache;
				}
				this._EnterActionListInited = true;
				int enterActionListLength = this.Instance.EnterActionListLength;
				this._EnterActionListCache = new List<ActionInfo>(enterActionListLength);
				for (int i = 0; i < enterActionListLength; i++)
				{
					this._EnterActionListCache.Add(ActionInfo.Create(this.Instance.EnterActionList(i)));
				}
				return this._EnterActionListCache;
			}
		}

		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x06005685 RID: 22149 RVA: 0x000D44E8 File Offset: 0x000D26E8
		public virtual List<ActionInfo> ExitActionList
		{
			get
			{
				if (this._ExitActionListInited)
				{
					return this._ExitActionListCache;
				}
				this._ExitActionListInited = true;
				int exitActionListLength = this.Instance.ExitActionListLength;
				this._ExitActionListCache = new List<ActionInfo>(exitActionListLength);
				for (int i = 0; i < exitActionListLength; i++)
				{
					this._ExitActionListCache.Add(ActionInfo.Create(this.Instance.ExitActionList(i)));
				}
				return this._ExitActionListCache;
			}
		}

		// Token: 0x0400319D RID: 12701
		private IWuWaGoPressureTrigger Instance;

		// Token: 0x0400319E RID: 12702
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x0400319F RID: 12703
		private bool _LinkDataInited;

		// Token: 0x040031A0 RID: 12704
		private List<ActionInfo> _EnterActionListCache;

		// Token: 0x040031A1 RID: 12705
		private bool _EnterActionListInited;

		// Token: 0x040031A2 RID: 12706
		private List<ActionInfo> _ExitActionListCache;

		// Token: 0x040031A3 RID: 12707
		private bool _ExitActionListInited;
	}
}
