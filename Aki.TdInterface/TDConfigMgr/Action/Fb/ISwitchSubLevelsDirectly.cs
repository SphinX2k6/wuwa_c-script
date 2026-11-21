using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B65 RID: 11109
	public class ISwitchSubLevelsDirectly : SwitchSubLevels
	{
		// Token: 0x0600F428 RID: 62504 RVA: 0x00239C23 File Offset: 0x00237E23
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

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x0600F429 RID: 62505 RVA: 0x00239C42 File Offset: 0x00237E42
		public override ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x0600F42A RID: 62506 RVA: 0x00239C50 File Offset: 0x00237E50
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

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x0600F42B RID: 62507 RVA: 0x00239CB4 File Offset: 0x00237EB4
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

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x0600F42C RID: 62508 RVA: 0x00239D18 File Offset: 0x00237F18
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

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x0600F42D RID: 62509 RVA: 0x00239D50 File Offset: 0x00237F50
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

		// Token: 0x040085E1 RID: 34273
		private ISwitchSubLevelsDirectly Instance;

		// Token: 0x040085E2 RID: 34274
		private List<string> _LoadLevelsCache;

		// Token: 0x040085E3 RID: 34275
		private bool _LoadLevelsInited;

		// Token: 0x040085E4 RID: 34276
		private List<string> _UnloadLevelsCache;

		// Token: 0x040085E5 RID: 34277
		private bool _UnloadLevelsInited;
	}
}
