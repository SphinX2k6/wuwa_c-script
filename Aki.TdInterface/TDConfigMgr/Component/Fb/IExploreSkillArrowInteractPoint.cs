using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9C RID: 3484
	public class IExploreSkillArrowInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004F2F RID: 20271 RVA: 0x000C50EE File Offset: 0x000C32EE
		public static IExploreSkillArrowInteractPoint Create(IExploreSkillArrowInteractPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillArrowInteractPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004F30 RID: 20272 RVA: 0x000C510D File Offset: 0x000C330D
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004F31 RID: 20273 RVA: 0x000C511A File Offset: 0x000C331A
		public virtual float MinDistance
		{
			get
			{
				return this.Instance.MinDistance;
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06004F32 RID: 20274 RVA: 0x000C5127 File Offset: 0x000C3327
		public virtual float InteractWaitTime
		{
			get
			{
				return this.Instance.InteractWaitTime;
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x000C5134 File Offset: 0x000C3334
		public virtual float ShootWaitTime
		{
			get
			{
				return this.Instance.ShootWaitTime;
			}
		}

		// Token: 0x04002CFF RID: 11519
		private IExploreSkillArrowInteractPoint Instance;
	}
}
