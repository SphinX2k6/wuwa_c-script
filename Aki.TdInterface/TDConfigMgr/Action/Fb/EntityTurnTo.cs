using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002630 RID: 9776
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityTurnTo : ActionParams
	{
		// Token: 0x0600DB5D RID: 56157 RVA: 0x0020A830 File Offset: 0x00208A30
		public static EntityTurnTo Create(IEntityTurnTo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EntityTurnTo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040BF RID: 16575
		// (get) Token: 0x0600DB5E RID: 56158 RVA: 0x0020A84F File Offset: 0x00208A4F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170040C0 RID: 16576
		// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x0020A85C File Offset: 0x00208A5C
		public virtual IActorTurnToData Target
		{
			get
			{
				if (this._TargetInited)
				{
					return this._TargetCache;
				}
				this._TargetInited = true;
				this._TargetCache = ActionReadHelper.ReadEntityTurnTo_Target(this.Instance);
				return this._TargetCache;
			}
		}

		// Token: 0x170040C1 RID: 16577
		// (get) Token: 0x0600DB60 RID: 56160 RVA: 0x0020A88C File Offset: 0x00208A8C
		public virtual bool? UseLookAtForSmallAngle
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.UseLookAtForSmallAngle);
			}
		}

		// Token: 0x040079DC RID: 31196
		private IEntityTurnTo Instance;

		// Token: 0x040079DD RID: 31197
		private IActorTurnToData _TargetCache;

		// Token: 0x040079DE RID: 31198
		private bool _TargetInited;
	}
}
