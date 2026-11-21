using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D4A RID: 11594
	public class IPlayerInitiator : INpcGroupPerformInitiatorType
	{
		// Token: 0x0600FD25 RID: 64805 RVA: 0x0024913B File Offset: 0x0024733B
		public static IPlayerInitiator Create(IPlayerInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x0600FD26 RID: 64806 RVA: 0x0024915A File Offset: 0x0024735A
		public override ENpcGroupPerformInitiatorType Type
		{
			get
			{
				return (ENpcGroupPerformInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x04008A30 RID: 35376
		private IPlayerInitiator Instance;
	}
}
