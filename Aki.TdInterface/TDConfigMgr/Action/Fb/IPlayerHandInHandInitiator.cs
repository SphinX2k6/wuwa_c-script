using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A57 RID: 10839
	public class IPlayerHandInHandInitiator : IHandInHandInitiatorType
	{
		// Token: 0x0600EE77 RID: 61047 RVA: 0x0022B5D2 File Offset: 0x002297D2
		[NullableContext(1)]
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

		// Token: 0x17004B8B RID: 19339
		// (get) Token: 0x0600EE78 RID: 61048 RVA: 0x0022B5F1 File Offset: 0x002297F1
		public override EHandInHandInitiatorType Type
		{
			get
			{
				return (EHandInHandInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x04008333 RID: 33587
		private IPlayerHandInHandInitiator Instance;
	}
}
