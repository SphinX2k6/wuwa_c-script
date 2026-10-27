using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002890 RID: 10384
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchSubLevelsDirectly : SwitchSubLevels
	{
		// Token: 0x0600E5F9 RID: 58873 RVA: 0x0021CCA3 File Offset: 0x0021AEA3
		public static ISwitchSubLevelsDirectly Create(ISwitchSubLevelsDirectly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchSubLevelsDirectly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x0600E5FA RID: 58874 RVA: 0x0021CCC2 File Offset: 0x0021AEC2
		public override ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x0021CCD0 File Offset: 0x0021AED0
		public virtual List<string> LoadLevels
		{
			get
			{
				if (this._LoadLevelsInited)
				{
					return this._LoadLevelsCache;
				}
				this._LoadLevelsInited = true;
				int loadLevelsLength = this.Instance.LoadLevelsLength;
				this._LoadLevelsCache = new List<string>(loadLevelsLength);
				for (int i = 0; i < loadLevelsLength; i++)
				{
					this._LoadLevelsCache.Add(this.Instance.LoadLevels(i));
				}
				return this._LoadLevelsCache;
			}
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x0600E5FC RID: 58876 RVA: 0x0021CD34 File Offset: 0x0021AF34
		public virtual List<string> UnloadLevels
		{
			get
			{
				if (this._UnloadLevelsInited)
				{
					return this._UnloadLevelsCache;
				}
				this._UnloadLevelsInited = true;
				int unloadLevelsLength = this.Instance.UnloadLevelsLength;
				this._UnloadLevelsCache = new List<string>(unloadLevelsLength);
				for (int i = 0; i < unloadLevelsLength; i++)
				{
					this._UnloadLevelsCache.Add(this.Instance.UnloadLevels(i));
				}
				return this._UnloadLevelsCache;
			}
		}

		// Token: 0x1700469E RID: 18078
		// (get) Token: 0x0600E5FD RID: 58877 RVA: 0x0021CD98 File Offset: 0x0021AF98
		public virtual int? TeleportEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TeleportEntityId);
			}
		}

		// Token: 0x1700469F RID: 18079
		// (get) Token: 0x0600E5FE RID: 58878 RVA: 0x0021CDD0 File Offset: 0x0021AFD0
		public virtual bool? IsWaitForSwitchComplete
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsWaitForSwitchComplete);
			}
		}

		// Token: 0x04007F22 RID: 32546
		private ISwitchSubLevelsDirectly Instance;

		// Token: 0x04007F23 RID: 32547
		private List<string> _LoadLevelsCache;

		// Token: 0x04007F24 RID: 32548
		private bool _LoadLevelsInited;

		// Token: 0x04007F25 RID: 32549
		private List<string> _UnloadLevelsCache;

		// Token: 0x04007F26 RID: 32550
		private bool _UnloadLevelsInited;
	}
}
