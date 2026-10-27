using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027A5 RID: 10149
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubScreenModeExit : ISubScreenModeConfig
	{
		// Token: 0x0600E1D0 RID: 57808 RVA: 0x00215C31 File Offset: 0x00213E31
		public static ISubScreenModeExit Create(ISubScreenModeExit? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenModeExit
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x0600E1D1 RID: 57809 RVA: 0x00215C50 File Offset: 0x00213E50
		public override ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x0600E1D2 RID: 57810 RVA: 0x00215C60 File Offset: 0x00213E60
		public virtual List<ISetSubScreenData> ExitConfigs
		{
			get
			{
				if (this._ExitConfigsInited)
				{
					return this._ExitConfigsCache;
				}
				this._ExitConfigsInited = true;
				int exitConfigsLength = this.Instance.ExitConfigsLength;
				this._ExitConfigsCache = new List<ISetSubScreenData>(exitConfigsLength);
				for (int i = 0; i < exitConfigsLength; i++)
				{
					this._ExitConfigsCache.Add(ISetSubScreenData.Create(this.Instance.ExitConfigs(i)));
				}
				return this._ExitConfigsCache;
			}
		}

		// Token: 0x04007D39 RID: 32057
		private ISubScreenModeExit Instance;

		// Token: 0x04007D3A RID: 32058
		private List<ISetSubScreenData> _ExitConfigsCache;

		// Token: 0x04007D3B RID: 32059
		private bool _ExitConfigsInited;
	}
}
