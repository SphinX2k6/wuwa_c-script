using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026CD RID: 9933
	public class IICenterTextShowAll : ICenterTextShowType
	{
		// Token: 0x0600DE11 RID: 56849 RVA: 0x0020F59A File Offset: 0x0020D79A
		[NullableContext(1)]
		public static IICenterTextShowAll Create(IICenterTextShowAll? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextShowAll
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x0600DE12 RID: 56850 RVA: 0x0020F5B9 File Offset: 0x0020D7B9
		public override ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x04007B4B RID: 31563
		private IICenterTextShowAll Instance;
	}
}
