using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E5F RID: 3679
	public class IInhaledDestroySelf : IInhaledPerResultType
	{
		// Token: 0x0600532C RID: 21292 RVA: 0x000CD599 File Offset: 0x000CB799
		public static IInhaledDestroySelf Create(IInhaledDestroySelf? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledDestroySelf
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600532D RID: 21293 RVA: 0x000CD5B8 File Offset: 0x000CB7B8
		public override EInhaledPerResultType Type
		{
			get
			{
				return (EInhaledPerResultType)this.Instance.Type;
			}
		}

		// Token: 0x04002F80 RID: 12160
		private IInhaledDestroySelf Instance;
	}
}
