using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027AA RID: 10154
	public class IHeadStyleVoiceOnly : IHeadStyle
	{
		// Token: 0x0600E0D3 RID: 57555 RVA: 0x00211275 File Offset: 0x0020F475
		public static IHeadStyleVoiceOnly Create(IHeadStyleVoiceOnly? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleVoiceOnly
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x00211294 File Offset: 0x0020F494
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x0600E0D5 RID: 57557 RVA: 0x002112A1 File Offset: 0x0020F4A1
		public virtual int WhoId
		{
			get
			{
				return this.Instance.WhoId;
			}
		}

		// Token: 0x04007A40 RID: 31296
		private IHeadStyleVoiceOnly Instance;
	}
}
