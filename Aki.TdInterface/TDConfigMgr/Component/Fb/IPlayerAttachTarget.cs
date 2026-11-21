using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D5E RID: 3422
	public class IPlayerAttachTarget : IAttachTarget
	{
		// Token: 0x06004DE2 RID: 19938 RVA: 0x000C24DF File Offset: 0x000C06DF
		public static IPlayerAttachTarget Create(IPlayerAttachTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerAttachTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x000C24FE File Offset: 0x000C06FE
		public override EAttachType Type
		{
			get
			{
				return (EAttachType)this.Instance.Type;
			}
		}

		// Token: 0x04002C39 RID: 11321
		private IPlayerAttachTarget Instance;
	}
}
