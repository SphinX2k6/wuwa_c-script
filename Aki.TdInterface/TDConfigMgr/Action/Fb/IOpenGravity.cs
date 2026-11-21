using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C9D RID: 11421
	public class IOpenGravity : ISetTeleControlConfig
	{
		// Token: 0x0600FAAF RID: 64175 RVA: 0x0024582D File Offset: 0x00243A2D
		public static IOpenGravity Create(IOpenGravity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGravity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E23 RID: 20003
		// (get) Token: 0x0600FAB0 RID: 64176 RVA: 0x0024584C File Offset: 0x00243A4C
		public override ESetTeleControlType Type
		{
			get
			{
				return (ESetTeleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004E24 RID: 20004
		// (get) Token: 0x0600FAB1 RID: 64177 RVA: 0x00245859 File Offset: 0x00243A59
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004E25 RID: 20005
		// (get) Token: 0x0600FAB2 RID: 64178 RVA: 0x00245868 File Offset: 0x00243A68
		public virtual int? PositionEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.PositionEntityId);
			}
		}

		// Token: 0x040088F3 RID: 35059
		private IOpenGravity Instance;
	}
}
