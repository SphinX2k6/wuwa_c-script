using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CD8 RID: 11480
	public class IRemovePreloadLinkResource : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600FB8E RID: 64398 RVA: 0x00246E41 File Offset: 0x00245041
		public static IRemovePreloadLinkResource Create(IRemovePreloadLinkResource? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadLinkResource
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x0600FB8F RID: 64399 RVA: 0x00246E60 File Offset: 0x00245060
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x0600FB90 RID: 64400 RVA: 0x00246E6D File Offset: 0x0024506D
		public virtual int LinkResourceId
		{
			get
			{
				return this.Instance.LinkResourceId;
			}
		}

		// Token: 0x04008972 RID: 35186
		private IRemovePreloadLinkResource Instance;
	}
}
