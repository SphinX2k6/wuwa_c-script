using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200284E RID: 10318
	public class IActorLookAtEntityData : IActorLookAtLockable
	{
		// Token: 0x0600E63B RID: 58939 RVA: 0x002217DE File Offset: 0x0021F9DE
		public static IActorLookAtEntityData Create(IActorLookAtEntityData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorLookAtEntityData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x0600E63C RID: 58940 RVA: 0x002217FD File Offset: 0x0021F9FD
		public override EActorLookAtMode Type
		{
			get
			{
				return (EActorLookAtMode)this.Instance.Type;
			}
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x0600E63D RID: 58941 RVA: 0x0022180C File Offset: 0x0021FA0C
		public override bool? Lock
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Lock);
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x0600E63E RID: 58942 RVA: 0x00221842 File Offset: 0x0021FA42
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x04007EDC RID: 32476
		private IActorLookAtEntityData Instance;
	}
}
