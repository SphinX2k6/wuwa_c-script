using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002966 RID: 10598
	public class ISeamlessTeleportFinishConfig
	{
		// Token: 0x0600EB33 RID: 60211 RVA: 0x0022AA3E File Offset: 0x00228C3E
		public static ISeamlessTeleportFinishConfig Create(ISeamlessTeleportFinishConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISeamlessTeleportFinishConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004515 RID: 17685
		// (get) Token: 0x0600EB34 RID: 60212 RVA: 0x0022AA60 File Offset: 0x00228C60
		public virtual bool? IsNotStopScreenEffect
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNotStopScreenEffect);
			}
		}

		// Token: 0x17004516 RID: 17686
		// (get) Token: 0x0600EB35 RID: 60213 RVA: 0x0022AA98 File Offset: 0x00228C98
		public virtual int? EffectExtraState
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.EffectExtraState);
			}
		}

		// Token: 0x04008190 RID: 33168
		private ISeamlessTeleportFinishConfig Instance;
	}
}
