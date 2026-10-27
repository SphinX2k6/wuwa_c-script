using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EB RID: 10731
	public class IRemovePreloadLinkResource : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600ECF7 RID: 60663 RVA: 0x002294BD File Offset: 0x002276BD
		[NullableContext(1)]
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

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x0600ECF8 RID: 60664 RVA: 0x002294DC File Offset: 0x002276DC
		public override ERemovePreloadResourceObjectType Type
		{
			get
			{
				return (ERemovePreloadResourceObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x0600ECF9 RID: 60665 RVA: 0x002294E9 File Offset: 0x002276E9
		public virtual int LinkResourceId
		{
			get
			{
				return this.Instance.LinkResourceId;
			}
		}

		// Token: 0x04008281 RID: 33409
		private IRemovePreloadLinkResource Instance;
	}
}
