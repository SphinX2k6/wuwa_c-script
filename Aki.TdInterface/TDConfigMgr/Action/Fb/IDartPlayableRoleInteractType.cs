using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B49 RID: 11081
	public class IDartPlayableRoleInteractType : IDartInteractTypeBase
	{
		// Token: 0x0600F39F RID: 62367 RVA: 0x00238A97 File Offset: 0x00236C97
		public static IDartPlayableRoleInteractType Create(IDartPlayableRoleInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartPlayableRoleInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x0600F3A0 RID: 62368 RVA: 0x00238AB6 File Offset: 0x00236CB6
		public override EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x0600F3A1 RID: 62369 RVA: 0x00238AC3 File Offset: 0x00236CC3
		public virtual int CompetitorId
		{
			get
			{
				return this.Instance.CompetitorId;
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x0600F3A2 RID: 62370 RVA: 0x00238AD0 File Offset: 0x00236CD0
		public virtual int? TargetEntityId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TargetEntityId);
			}
		}

		// Token: 0x0400859B RID: 34203
		private IDartPlayableRoleInteractType Instance;
	}
}
