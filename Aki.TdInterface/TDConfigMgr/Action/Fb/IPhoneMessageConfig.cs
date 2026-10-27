using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025C7 RID: 9671
	public class IPhoneMessageConfig
	{
		// Token: 0x0600D96B RID: 55659 RVA: 0x00206D08 File Offset: 0x00204F08
		[NullableContext(1)]
		public static IPhoneMessageConfig Create(IPhoneMessageConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhoneMessageConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x0600D96C RID: 55660 RVA: 0x00206D28 File Offset: 0x00204F28
		public virtual bool? IsJumpToFirstOption
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsJumpToFirstOption);
			}
		}

		// Token: 0x040078BF RID: 30911
		private IPhoneMessageConfig Instance;
	}
}
