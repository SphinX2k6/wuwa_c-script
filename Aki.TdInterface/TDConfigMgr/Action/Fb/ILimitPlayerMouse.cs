using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AA0 RID: 10912
	public class ILimitPlayerMouse : ILimitPlayerOption
	{
		// Token: 0x0600F0AA RID: 61610 RVA: 0x0023412A File Offset: 0x0023232A
		public static ILimitPlayerMouse Create(ILimitPlayerMouse? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMouse
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x0600F0AB RID: 61611 RVA: 0x00234149 File Offset: 0x00232349
		public override ELimitPlayOperation Type
		{
			get
			{
				return (ELimitPlayOperation)this.Instance.Type;
			}
		}

		// Token: 0x04008456 RID: 33878
		private ILimitPlayerMouse Instance;
	}
}
