using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C3F RID: 11327
	public class IClientModifySelfTarget : IClientModifyTarget
	{
		// Token: 0x0600F930 RID: 63792 RVA: 0x002434F8 File Offset: 0x002416F8
		public static IClientModifySelfTarget Create(IClientModifySelfTarget? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientModifySelfTarget
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x0600F931 RID: 63793 RVA: 0x00243517 File Offset: 0x00241717
		public override EClientModifyTargetType Type
		{
			get
			{
				return (EClientModifyTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008839 RID: 34873
		private IClientModifySelfTarget Instance;
	}
}
