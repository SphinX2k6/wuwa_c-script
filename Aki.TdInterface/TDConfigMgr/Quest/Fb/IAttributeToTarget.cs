using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014DE RID: 5342
	public class IAttributeToTarget
	{
		// Token: 0x06007922 RID: 31010 RVA: 0x00121B55 File Offset: 0x0011FD55
		public static IAttributeToTarget Create(IAttributeToTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttributeToTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x06007923 RID: 31011 RVA: 0x00121B74 File Offset: 0x0011FD74
		public virtual EAttributeToTarget Type
		{
			get
			{
				return (EAttributeToTarget)this.Instance.Type;
			}
		}

		// Token: 0x040045AC RID: 17836
		private IAttributeToTarget Instance;
	}
}
