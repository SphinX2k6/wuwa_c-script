using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0A RID: 3594
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoPressureTrigger : IWuWaGoEntityBase
	{
		// Token: 0x0600515A RID: 20826 RVA: 0x000C8B51 File Offset: 0x000C6D51
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

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x000C8B70 File Offset: 0x000C6D70
		public override EWuWaGoEntityType Type
		{
			get
			{
				return (EWuWaGoEntityType)this.Instance.Type;
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600515C RID: 20828 RVA: 0x000C8B7D File Offset: 0x000C6D7D
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600515D RID: 20829 RVA: 0x000C8BB4 File Offset: 0x000C6DB4
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600515E RID: 20830 RVA: 0x000C8C20 File Offset: 0x000C6E20
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

		// Token: 0x04002ED5 RID: 11989
		private IWuWaGoPressureTrigger Instance;

		// Token: 0x04002ED6 RID: 11990
		[Nullable(2)]
		private IWuWaGoGridLinkData _LinkDataCache;

		// Token: 0x04002ED7 RID: 11991
		private bool _LinkDataInited;

		// Token: 0x04002ED8 RID: 11992
		private List<ActionInfo> _EnterActionListCache;

		// Token: 0x04002ED9 RID: 11993
		private bool _EnterActionListInited;

		// Token: 0x04002EDA RID: 11994
		private List<ActionInfo> _ExitActionListCache;

		// Token: 0x04002EDB RID: 11995
		private bool _ExitActionListInited;
	}
}
