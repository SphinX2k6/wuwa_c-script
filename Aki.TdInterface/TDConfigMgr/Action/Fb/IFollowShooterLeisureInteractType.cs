using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C7B RID: 11387
	public class IFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA22 RID: 64034 RVA: 0x00244CBF File Offset: 0x00242EBF
		public static IFollowShooterLeisureInteractType Create(IFollowShooterLeisureInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterLeisureInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DDA RID: 19930
		// (get) Token: 0x0600FA23 RID: 64035 RVA: 0x00244CDE File Offset: 0x00242EDE
		public virtual EFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x040088AB RID: 34987
		private IFollowShooterLeisureInteractType Instance;
	}
}
