using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B06 RID: 11014
	public class ChangeLiftTarget : ActionParams
	{
		// Token: 0x0600F255 RID: 62037 RVA: 0x00236718 File Offset: 0x00234918
		public static ChangeLiftTarget Create(IChangeLiftTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeLiftTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048F7 RID: 18679
		// (get) Token: 0x0600F256 RID: 62038 RVA: 0x00236737 File Offset: 0x00234937
		public virtual bool IsSelf
		{
			get
			{
				return this.Instance.IsSelf;
			}
		}

		// Token: 0x170048F8 RID: 18680
		// (get) Token: 0x0600F257 RID: 62039 RVA: 0x00236744 File Offset: 0x00234944
		public virtual ILiftMoveType MoveType
		{
			get
			{
				if (this._MoveTypeInited)
				{
					return this._MoveTypeCache;
				}
				this._MoveTypeInited = true;
				this._MoveTypeCache = ActionReadHelper.ReadChangeLiftTarget_MoveType(this.Instance);
				return this._MoveTypeCache;
			}
		}

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x0600F258 RID: 62040 RVA: 0x00236774 File Offset: 0x00234974
		public virtual int? EntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EntityId);
			}
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x0600F259 RID: 62041 RVA: 0x002367AA File Offset: 0x002349AA
		public virtual int Location
		{
			get
			{
				return this.Instance.Location;
			}
		}

		// Token: 0x040084FE RID: 34046
		private IChangeLiftTarget Instance;

		// Token: 0x040084FF RID: 34047
		private ILiftMoveType _MoveTypeCache;

		// Token: 0x04008500 RID: 34048
		private bool _MoveTypeInited;
	}
}
