using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CEC RID: 11500
	public class IPlaySpineAnimation : ISetSpineAnimationType
	{
		// Token: 0x0600FBDC RID: 64476 RVA: 0x002473E5 File Offset: 0x002455E5
		public static IPlaySpineAnimation Create(IPlaySpineAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlaySpineAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EB2 RID: 20146
		// (get) Token: 0x0600FBDD RID: 64477 RVA: 0x00247404 File Offset: 0x00245604
		public override ESetSpineAnimation Type
		{
			get
			{
				return (ESetSpineAnimation)this.Instance.Type;
			}
		}

		// Token: 0x17004EB3 RID: 20147
		// (get) Token: 0x0600FBDE RID: 64478 RVA: 0x00247411 File Offset: 0x00245611
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004EB4 RID: 20148
		// (get) Token: 0x0600FBDF RID: 64479 RVA: 0x0024741E File Offset: 0x0024561E
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x04008990 RID: 35216
		private IPlaySpineAnimation Instance;
	}
}
