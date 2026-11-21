using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B67 RID: 11111
	public class ISwitchPermission : SwitchSubLevels
	{
		// Token: 0x0600F433 RID: 62515 RVA: 0x00239E28 File Offset: 0x00238028
		public static ISwitchPermission Create(ISwitchPermission? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchPermission
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x0600F434 RID: 62516 RVA: 0x00239E47 File Offset: 0x00238047
		public override ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x0600F435 RID: 62517 RVA: 0x00239E54 File Offset: 0x00238054
		public virtual bool IsAllowClientSwitch
		{
			get
			{
				return this.Instance.IsAllowClientSwitch;
			}
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x0600F436 RID: 62518 RVA: 0x00239E64 File Offset: 0x00238064
		public virtual List<string> Levels
		{
			get
			{
				if (this._LevelsInited)
				{
					return this._LevelsCache;
				}
				this._LevelsInited = true;
				int levelsLength = this.Instance.LevelsLength;
				this._LevelsCache = new List<string>(levelsLength);
				for (int i = 0; i < levelsLength; i++)
				{
					this._LevelsCache.Add(this.Instance.Levels(i));
				}
				return this._LevelsCache;
			}
		}

		// Token: 0x040085E9 RID: 34281
		private ISwitchPermission Instance;

		// Token: 0x040085EA RID: 34282
		private List<string> _LevelsCache;

		// Token: 0x040085EB RID: 34283
		private bool _LevelsInited;
	}
}
