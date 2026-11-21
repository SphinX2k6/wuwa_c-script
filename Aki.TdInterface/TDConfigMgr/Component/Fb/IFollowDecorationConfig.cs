using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E09 RID: 3593
	public class IFollowDecorationConfig
	{
		// Token: 0x0600516B RID: 20843 RVA: 0x000C9A4A File Offset: 0x000C7C4A
		public static IFollowDecorationConfig Create(IFollowDecorationConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowDecorationConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x0600516C RID: 20844 RVA: 0x000C9A69 File Offset: 0x000C7C69
		public virtual EFollowDecorationType Type
		{
			get
			{
				return (EFollowDecorationType)this.Instance.Type;
			}
		}

		// Token: 0x04002E72 RID: 11890
		private IFollowDecorationConfig Instance;
	}
}
