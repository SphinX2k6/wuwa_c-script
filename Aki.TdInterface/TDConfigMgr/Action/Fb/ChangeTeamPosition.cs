using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200293F RID: 10559
	public class ChangeTeamPosition : ActionParams
	{
		// Token: 0x0600EA97 RID: 60055 RVA: 0x00229BDD File Offset: 0x00227DDD
		public static ChangeTeamPosition Create(IChangeTeamPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeTeamPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044C7 RID: 17607
		// (get) Token: 0x0600EA98 RID: 60056 RVA: 0x00229BFC File Offset: 0x00227DFC
		public virtual int PositionId
		{
			get
			{
				return this.Instance.PositionId;
			}
		}

		// Token: 0x170044C8 RID: 17608
		// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x00229C09 File Offset: 0x00227E09
		public virtual ITeamType TeamType
		{
			get
			{
				if (this._TeamTypeInited)
				{
					return this._TeamTypeCache;
				}
				this._TeamTypeInited = true;
				this._TeamTypeCache = ActionReadHelper.ReadChangeTeamPosition_TeamType(this.Instance);
				return this._TeamTypeCache;
			}
		}

		// Token: 0x04008147 RID: 33095
		private IChangeTeamPosition Instance;

		// Token: 0x04008148 RID: 33096
		private ITeamType _TeamTypeCache;

		// Token: 0x04008149 RID: 33097
		private bool _TeamTypeInited;
	}
}
