using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002956 RID: 10582
	public class ITeleportTransitionInDigitalScreen : ITeleportTransitionType
	{
		// Token: 0x0600EAEC RID: 60140 RVA: 0x0022A3B6 File Offset: 0x002285B6
		public static ITeleportTransitionInDigitalScreen Create(ITeleportTransitionInDigitalScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionInDigitalScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044EE RID: 17646
		// (get) Token: 0x0600EAED RID: 60141 RVA: 0x0022A3D5 File Offset: 0x002285D5
		public override ETeleportTransitionType Type
		{
			get
			{
				return (ETeleportTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x170044EF RID: 17647
		// (get) Token: 0x0600EAEE RID: 60142 RVA: 0x0022A3E2 File Offset: 0x002285E2
		public virtual int ConfigId
		{
			get
			{
				return this.Instance.ConfigId;
			}
		}

		// Token: 0x0400816A RID: 33130
		private ITeleportTransitionInDigitalScreen Instance;
	}
}
