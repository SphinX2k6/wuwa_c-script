using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C31 RID: 11313
	public class IDisableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x0600F8EB RID: 63723 RVA: 0x00242CB6 File Offset: 0x00240EB6
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

		// Token: 0x17004D37 RID: 19767
		// (get) Token: 0x0600F8EC RID: 63724 RVA: 0x00242CD5 File Offset: 0x00240ED5
		public override ESceneInteractionOperationType Type
		{
			get
			{
				return (ESceneInteractionOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400881B RID: 34843
		private IDisableSceneInteractionOperation Instance;
	}
}
