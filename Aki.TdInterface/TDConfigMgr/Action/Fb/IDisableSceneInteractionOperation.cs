using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294F RID: 10575
	public class IDisableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x0600EA80 RID: 60032 RVA: 0x002256D6 File Offset: 0x002238D6
		[NullableContext(1)]
		public static IDisableSceneInteractionOperation Create(IDisableSceneInteractionOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableSceneInteractionOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x002256F5 File Offset: 0x002238F5
		public override ESceneInteractionOperationType Type
		{
			get
			{
				return (ESceneInteractionOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400813F RID: 33087
		private IDisableSceneInteractionOperation Instance;
	}
}
