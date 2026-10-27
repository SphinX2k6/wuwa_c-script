using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200142A RID: 5162
	public class IWarningPreformFadeInScreen : IWarningPreformType
	{
		// Token: 0x0600756C RID: 30060 RVA: 0x001187BE File Offset: 0x001169BE
		[NullableContext(1)]
		public static IWarningPreformFadeInScreen Create(IWarningPreformFadeInScreen? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformFadeInScreen
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600756D RID: 30061 RVA: 0x001187DD File Offset: 0x001169DD
		public override EWarningPreformType Type
		{
			get
			{
				return (EWarningPreformType)this.Instance.Type;
			}
		}

		// Token: 0x04004404 RID: 17412
		private IWarningPreformFadeInScreen Instance;
	}
}
