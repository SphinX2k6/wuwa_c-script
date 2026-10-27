using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200294E RID: 10574
	public class IEnableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x0600EA7D RID: 60029 RVA: 0x002256A2 File Offset: 0x002238A2
		[NullableContext(1)]
		public static IEnableSceneInteractionOperation Create(IEnableSceneInteractionOperation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSceneInteractionOperation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x0600EA7E RID: 60030 RVA: 0x002256C1 File Offset: 0x002238C1
		public override ESceneInteractionOperationType Type
		{
			get
			{
				return (ESceneInteractionOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400813E RID: 33086
		private IEnableSceneInteractionOperation Instance;
	}
}
