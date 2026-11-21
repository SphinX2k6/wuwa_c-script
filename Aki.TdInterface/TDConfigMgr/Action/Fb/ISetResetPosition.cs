using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C9E RID: 11422
	public class ISetResetPosition : ISetTeleControlConfig
	{
		// Token: 0x0600FAB4 RID: 64180 RVA: 0x002458A6 File Offset: 0x00243AA6
		public static ISetResetPosition Create(ISetResetPosition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetResetPosition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E26 RID: 20006
		// (get) Token: 0x0600FAB5 RID: 64181 RVA: 0x002458C5 File Offset: 0x00243AC5
		public override ESetTeleControlType Type
		{
			get
			{
				return (ESetTeleControlType)this.Instance.Type;
			}
		}

		// Token: 0x17004E27 RID: 20007
		// (get) Token: 0x0600FAB6 RID: 64182 RVA: 0x002458D2 File Offset: 0x00243AD2
		public override int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004E28 RID: 20008
		// (get) Token: 0x0600FAB7 RID: 64183 RVA: 0x002458DF File Offset: 0x00243ADF
		public virtual int PositionEntityId
		{
			get
			{
				return this.Instance.PositionEntityId;
			}
		}

		// Token: 0x040088F4 RID: 35060
		private ISetResetPosition Instance;
	}
}
