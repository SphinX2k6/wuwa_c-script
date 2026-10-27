using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026AD RID: 9901
	public class SetReviveRegion : ActionParams
	{
		// Token: 0x0600DD8C RID: 56716 RVA: 0x0020E816 File Offset: 0x0020CA16
		[NullableContext(1)]
		public static SetReviveRegion Create(ISetReviveRegion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetReviveRegion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170041F4 RID: 16884
		// (get) Token: 0x0600DD8D RID: 56717 RVA: 0x0020E835 File Offset: 0x0020CA35
		public virtual ESetReviveType SetReviveType
		{
			get
			{
				return (ESetReviveType)this.Instance.SetReviveType;
			}
		}

		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x0020E842 File Offset: 0x0020CA42
		public virtual int ReviveId
		{
			get
			{
				return this.Instance.ReviveId;
			}
		}

		// Token: 0x04007B05 RID: 31493
		private ISetReviveRegion Instance;
	}
}
