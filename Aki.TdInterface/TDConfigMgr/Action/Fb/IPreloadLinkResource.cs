using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD0 RID: 11472
	public class IPreloadLinkResource : IPreloadCharacterType
	{
		// Token: 0x0600FB71 RID: 64369 RVA: 0x00246B98 File Offset: 0x00244D98
		public static IPreloadLinkResource Create(IPreloadLinkResource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadLinkResource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x0600FB72 RID: 64370 RVA: 0x00246BB7 File Offset: 0x00244DB7
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x0600FB73 RID: 64371 RVA: 0x00246BC4 File Offset: 0x00244DC4
		public virtual int LinkResourceId
		{
			get
			{
				return this.Instance.LinkResourceId;
			}
		}

		// Token: 0x04008962 RID: 35170
		private IPreloadLinkResource Instance;
	}
}
