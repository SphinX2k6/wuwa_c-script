using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CEF RID: 3311
	public class IBeamLayoutConfig
	{
		// Token: 0x06004BA0 RID: 19360 RVA: 0x000BCC82 File Offset: 0x000BAE82
		[NullableContext(1)]
		public static IBeamLayoutConfig Create(IBeamLayoutConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06004BA1 RID: 19361 RVA: 0x000BCCA1 File Offset: 0x000BAEA1
		public virtual EBeamLayoutType Type
		{
			get
			{
				return (EBeamLayoutType)this.Instance.Type;
			}
		}

		// Token: 0x04002B3A RID: 11066
		private IBeamLayoutConfig Instance;
	}
}
