using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E5E RID: 3678
	public class IInhaledPerResultType
	{
		// Token: 0x06005329 RID: 21289 RVA: 0x000CD565 File Offset: 0x000CB765
		public static IInhaledPerResultType Create(IInhaledPerResultType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInhaledPerResultType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x000CD584 File Offset: 0x000CB784
		public virtual EInhaledPerResultType Type
		{
			get
			{
				return (EInhaledPerResultType)this.Instance.Type;
			}
		}

		// Token: 0x04002F7F RID: 12159
		private IInhaledPerResultType Instance;
	}
}
