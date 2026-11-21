using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D44 RID: 11588
	public class IPlayerHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x0600FD0F RID: 64783 RVA: 0x00248F86 File Offset: 0x00247186
		public static IPlayerHandInHandInitiator Create(IPlayerHandInHandInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerHandInHandInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x0600FD10 RID: 64784 RVA: 0x00248FA5 File Offset: 0x002471A5
		public override EHandInHandInitiatorType Type
		{
			get
			{
				return (EHandInHandInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x04008A26 RID: 35366
		private IPlayerHandInHandInitiator Instance;
	}
}
