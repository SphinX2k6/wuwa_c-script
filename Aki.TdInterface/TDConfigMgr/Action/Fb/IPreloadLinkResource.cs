using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E3 RID: 10723
	public class IPreloadLinkResource : IPreloadCharacterType
	{
		// Token: 0x0600ECDA RID: 60634 RVA: 0x00229214 File Offset: 0x00227414
		[NullableContext(1)]
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

		// Token: 0x17004AD6 RID: 19158
		// (get) Token: 0x0600ECDB RID: 60635 RVA: 0x00229233 File Offset: 0x00227433
		public override EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x17004AD7 RID: 19159
		// (get) Token: 0x0600ECDC RID: 60636 RVA: 0x00229240 File Offset: 0x00227440
		public virtual int LinkResourceId
		{
			get
			{
				return this.Instance.LinkResourceId;
			}
		}

		// Token: 0x04008271 RID: 33393
		private IPreloadLinkResource Instance;
	}
}
