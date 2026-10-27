using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A8F RID: 2703
	public class IInitStateDigital : IInitState
	{
		// Token: 0x06003E34 RID: 15924 RVA: 0x0009F55A File Offset: 0x0009D75A
		[NullableContext(1)]
		public static IInitStateDigital Create(IInitStateDigital? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateDigital
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06003E35 RID: 15925 RVA: 0x0009F579 File Offset: 0x0009D779
		public override EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040022A8 RID: 8872
		private IInitStateDigital Instance;
	}
}
