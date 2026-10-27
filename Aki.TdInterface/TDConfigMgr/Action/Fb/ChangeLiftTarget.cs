using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002833 RID: 10291
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeLiftTarget : ActionParams
	{
		// Token: 0x0600E430 RID: 58416 RVA: 0x002198B4 File Offset: 0x00217AB4
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

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x0600E431 RID: 58417 RVA: 0x002198D3 File Offset: 0x00217AD3
		public virtual bool IsSelf
		{
			get
			{
				return this.Instance.IsSelf;
			}
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x0600E432 RID: 58418 RVA: 0x002198E0 File Offset: 0x00217AE0
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

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x0600E433 RID: 58419 RVA: 0x00219910 File Offset: 0x00217B10
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

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x0600E434 RID: 58420 RVA: 0x00219946 File Offset: 0x00217B46
		public virtual int Location
		{
			get
			{
				return this.Instance.Location;
			}
		}

		// Token: 0x04007E41 RID: 32321
		private IChangeLiftTarget Instance;

		// Token: 0x04007E42 RID: 32322
		private ILiftMoveType _MoveTypeCache;

		// Token: 0x04007E43 RID: 32323
		private bool _MoveTypeInited;
	}
}
