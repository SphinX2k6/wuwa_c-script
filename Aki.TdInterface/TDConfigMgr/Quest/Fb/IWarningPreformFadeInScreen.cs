using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001582 RID: 5506
	public class IWarningPreformFadeInScreen : IWarningPreformType
	{
		// Token: 0x06007C31 RID: 31793 RVA: 0x0012720A File Offset: 0x0012540A
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

		// Token: 0x170028CF RID: 10447
		// (get) Token: 0x06007C32 RID: 31794 RVA: 0x00127229 File Offset: 0x00125429
		public override EWarningPreformType Type
		{
			get
			{
				return (EWarningPreformType)this.Instance.Type;
			}
		}

		// Token: 0x04004798 RID: 18328
		private IWarningPreformFadeInScreen Instance;
	}
}
