using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AFA RID: 11002
	public class IVariableMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600F21A RID: 61978 RVA: 0x00236120 File Offset: 0x00234320
		public static IVariableMotion Create(IVariableMotion? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVariableMotion
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x0600F21B RID: 61979 RVA: 0x0023613F File Offset: 0x0023433F
		public override EMoveMotion Type
		{
			get
			{
				return (EMoveMotion)this.Instance.Type;
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x0600F21C RID: 61980 RVA: 0x0023614C File Offset: 0x0023434C
		public virtual float Acceleration
		{
			get
			{
				return this.Instance.Acceleration;
			}
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x0600F21D RID: 61981 RVA: 0x00236159 File Offset: 0x00234359
		public virtual float MaxSpeed
		{
			get
			{
				return this.Instance.MaxSpeed;
			}
		}

		// Token: 0x040084E0 RID: 34016
		private IVariableMotion Instance;
	}
}
