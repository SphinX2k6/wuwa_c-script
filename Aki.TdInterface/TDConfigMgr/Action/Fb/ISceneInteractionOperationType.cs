using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C2F RID: 11311
	public class ISceneInteractionOperationType
	{
		// Token: 0x0600F8E5 RID: 63717 RVA: 0x00242C4E File Offset: 0x00240E4E
		public static ISceneInteractionOperationType Create(ISceneInteractionOperationType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneInteractionOperationType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x0600F8E6 RID: 63718 RVA: 0x00242C6D File Offset: 0x00240E6D
		public virtual ESceneInteractionOperationType Type
		{
			get
			{
				return (ESceneInteractionOperationType)this.Instance.Type;
			}
		}

		// Token: 0x04008819 RID: 34841
		private ISceneInteractionOperationType Instance;
	}
}
