using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029E9 RID: 10729
	public class IDelayRemoveAfterSkillFinish : IDelayRemoveType
	{
		// Token: 0x0600ECEF RID: 60655 RVA: 0x00229414 File Offset: 0x00227614
		[NullableContext(1)]
		public static IDelayRemoveAfterSkillFinish Create(IDelayRemoveAfterSkillFinish? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDelayRemoveAfterSkillFinish
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x0600ECF0 RID: 60656 RVA: 0x00229433 File Offset: 0x00227633
		public override EDelayRemoveType Type
		{
			get
			{
				return (EDelayRemoveType)this.Instance.Type;
			}
		}

		// Token: 0x0400827D RID: 33405
		private IDelayRemoveAfterSkillFinish Instance;
	}
}
