using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C3E RID: 11326
	public class IClientModifyTarget
	{
		// Token: 0x0600F92D RID: 63789 RVA: 0x002434C4 File Offset: 0x002416C4
		public static IClientModifyTarget Create(IClientModifyTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifyTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x0600F92E RID: 63790 RVA: 0x002434E3 File Offset: 0x002416E3
		public virtual EClientModifyTargetType Type
		{
			get
			{
				return (EClientModifyTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008838 RID: 34872
		private IClientModifyTarget Instance;
	}
}
