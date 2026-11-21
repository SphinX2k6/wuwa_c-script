using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D67 RID: 11623
	public class ICheckFlowLookAtPlayer : ICheckFlowLookAtTarget
	{
		// Token: 0x0600FDA5 RID: 64933 RVA: 0x00249EB6 File Offset: 0x002480B6
		public static ICheckFlowLookAtPlayer Create(ICheckFlowLookAtPlayer? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtPlayer
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x0600FDA6 RID: 64934 RVA: 0x00249ED5 File Offset: 0x002480D5
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				return (ECheckFlowLookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04008A73 RID: 35443
		private ICheckFlowLookAtPlayer Instance;
	}
}
