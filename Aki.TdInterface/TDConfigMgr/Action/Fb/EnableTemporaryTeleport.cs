using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002967 RID: 10599
	public class EnableTemporaryTeleport : ActionParams
	{
		// Token: 0x0600EAEE RID: 60142 RVA: 0x00226360 File Offset: 0x00224560
		[NullableContext(1)]
		public static EnableTemporaryTeleport Create(IEnableTemporaryTeleport? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new EnableTemporaryTeleport
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049E2 RID: 18914
		// (get) Token: 0x0600EAEF RID: 60143 RVA: 0x0022637F File Offset: 0x0022457F
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x170049E3 RID: 18915
		// (get) Token: 0x0600EAF0 RID: 60144 RVA: 0x0022638C File Offset: 0x0022458C
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x04008171 RID: 33137
		private IEnableTemporaryTeleport Instance;
	}
}
