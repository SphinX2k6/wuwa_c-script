using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E71 RID: 3697
	public class ISceneItemAiPatrolByGameTime : ISceneItemAiPatrolType
	{
		// Token: 0x06005389 RID: 21385 RVA: 0x000CE0AF File Offset: 0x000CC2AF
		public static ISceneItemAiPatrolByGameTime Create(ISceneItemAiPatrolByGameTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolByGameTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x0600538A RID: 21386 RVA: 0x000CE0CE File Offset: 0x000CC2CE
		public override ESceneItemAiPatrolType Type
		{
			get
			{
				return (ESceneItemAiPatrolType)this.Instance.Type;
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x0600538B RID: 21387 RVA: 0x000CE0DB File Offset: 0x000CC2DB
		public virtual int Spline
		{
			get
			{
				return this.Instance.Spline;
			}
		}

		// Token: 0x04002FC4 RID: 12228
		private ISceneItemAiPatrolByGameTime Instance;
	}
}
