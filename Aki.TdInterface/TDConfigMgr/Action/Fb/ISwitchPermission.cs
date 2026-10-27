using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002892 RID: 10386
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchPermission : SwitchSubLevels
	{
		// Token: 0x0600E604 RID: 58884 RVA: 0x0021CEA8 File Offset: 0x0021B0A8
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

		// Token: 0x170046A2 RID: 18082
		// (get) Token: 0x0600E605 RID: 58885 RVA: 0x0021CEC7 File Offset: 0x0021B0C7
		public override ESwitchSubLevelsType Type
		{
			get
			{
				return (ESwitchSubLevelsType)this.Instance.Type;
			}
		}

		// Token: 0x170046A3 RID: 18083
		// (get) Token: 0x0600E606 RID: 58886 RVA: 0x0021CED4 File Offset: 0x0021B0D4
		public virtual bool IsAllowClientSwitch
		{
			get
			{
				return this.Instance.IsAllowClientSwitch;
			}
		}

		// Token: 0x170046A4 RID: 18084
		// (get) Token: 0x0600E607 RID: 58887 RVA: 0x0021CEE4 File Offset: 0x0021B0E4
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

		// Token: 0x04007F2A RID: 32554
		private ISwitchPermission Instance;

		// Token: 0x04007F2B RID: 32555
		private List<string> _LevelsCache;

		// Token: 0x04007F2C RID: 32556
		private bool _LevelsInited;
	}
}
