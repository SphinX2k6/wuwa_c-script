using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200266F RID: 9839
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeEntityStateDirectly : ChangeEntityState
	{
		// Token: 0x0600DC87 RID: 56455 RVA: 0x0020CE03 File Offset: 0x0020B003
		public static IChangeEntityStateDirectly Create(IChangeEntityStateDirectly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateDirectly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x0600DC88 RID: 56456 RVA: 0x0020CE22 File Offset: 0x0020B022
		public override EChangeEntityState Type
		{
			get
			{
				return (EChangeEntityState)this.Instance.Type;
			}
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x0600DC89 RID: 56457 RVA: 0x0020CE2F File Offset: 0x0020B02F
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x1700416D RID: 16749
		// (get) Token: 0x0600DC8A RID: 56458 RVA: 0x0020CE3C File Offset: 0x0020B03C
		public virtual string State
		{
			get
			{
				return this.Instance.State;
			}
		}

		// Token: 0x1700416E RID: 16750
		// (get) Token: 0x0600DC8B RID: 56459 RVA: 0x0020CE4C File Offset: 0x0020B04C
		public virtual bool? DelayChange
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.DelayChange);
			}
		}

		// Token: 0x04007A97 RID: 31383
		private IChangeEntityStateDirectly Instance;
	}
}
