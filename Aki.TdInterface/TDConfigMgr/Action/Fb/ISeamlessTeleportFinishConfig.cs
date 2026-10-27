using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026A3 RID: 9891
	public class ISeamlessTeleportFinishConfig
	{
		// Token: 0x0600DD5C RID: 56668 RVA: 0x0020E29E File Offset: 0x0020C49E
		[NullableContext(1)]
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

		// Token: 0x170041D8 RID: 16856
		// (get) Token: 0x0600DD5D RID: 56669 RVA: 0x0020E2C0 File Offset: 0x0020C4C0
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

		// Token: 0x170041D9 RID: 16857
		// (get) Token: 0x0600DD5E RID: 56670 RVA: 0x0020E2F8 File Offset: 0x0020C4F8
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

		// Token: 0x04007AF3 RID: 31475
		private ISeamlessTeleportFinishConfig Instance;
	}
}
