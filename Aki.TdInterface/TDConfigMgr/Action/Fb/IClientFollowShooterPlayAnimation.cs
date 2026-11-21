using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C81 RID: 11393
	public class IClientFollowShooterPlayAnimation : IClientFollowShooterLeisureInteractType
	{
		// Token: 0x0600FA35 RID: 64053 RVA: 0x00244E26 File Offset: 0x00243026
		public static IClientFollowShooterPlayAnimation Create(IClientFollowShooterPlayAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientFollowShooterPlayAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DE1 RID: 19937
		// (get) Token: 0x0600FA36 RID: 64054 RVA: 0x00244E45 File Offset: 0x00243045
		public override EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				return (EClientFollowShooterLeisureInteractType)this.Instance.Type;
			}
		}

		// Token: 0x17004DE2 RID: 19938
		// (get) Token: 0x0600FA37 RID: 64055 RVA: 0x00244E52 File Offset: 0x00243052
		public virtual string Montage
		{
			get
			{
				return this.Instance.Montage;
			}
		}

		// Token: 0x040088B3 RID: 34995
		private IClientFollowShooterPlayAnimation Instance;
	}
}
