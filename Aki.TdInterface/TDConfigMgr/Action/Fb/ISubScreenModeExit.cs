using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A77 RID: 10871
	public class ISubScreenModeExit : ISubScreenModeConfig
	{
		// Token: 0x0600EFEE RID: 61422 RVA: 0x002329C5 File Offset: 0x00230BC5
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

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x0600EFEF RID: 61423 RVA: 0x002329E4 File Offset: 0x00230BE4
		public override ESubScreenOperationType Type
		{
			get
			{
				return (ESubScreenOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x0600EFF0 RID: 61424 RVA: 0x002329F4 File Offset: 0x00230BF4
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

		// Token: 0x040083EF RID: 33775
		private ISubScreenModeExit Instance;

		// Token: 0x040083F0 RID: 33776
		private List<ISetSubScreenData> _ExitConfigsCache;

		// Token: 0x040083F1 RID: 33777
		private bool _ExitConfigsInited;
	}
}
