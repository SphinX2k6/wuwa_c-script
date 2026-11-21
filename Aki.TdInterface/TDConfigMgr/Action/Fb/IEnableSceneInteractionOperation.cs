using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C30 RID: 11312
	public class IEnableSceneInteractionOperation : ISceneInteractionOperationType
	{
		// Token: 0x0600F8E8 RID: 63720 RVA: 0x00242C82 File Offset: 0x00240E82
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

		// Token: 0x17004D36 RID: 19766
		// (get) Token: 0x0600F8E9 RID: 63721 RVA: 0x00242CA1 File Offset: 0x00240EA1
		public override ESceneInteractionOperationType Type
		{
			get
			{
				return (ESceneInteractionOperationType)this.Instance.Type;
			}
		}

		// Token: 0x0400881A RID: 34842
		private IEnableSceneInteractionOperation Instance;
	}
}
