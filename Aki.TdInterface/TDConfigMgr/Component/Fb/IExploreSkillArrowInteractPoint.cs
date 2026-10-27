using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CBA RID: 3258
	public class IExploreSkillArrowInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004A81 RID: 19073 RVA: 0x000BA6DE File Offset: 0x000B88DE
		[NullableContext(1)]
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

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06004A82 RID: 19074 RVA: 0x000BA6FD File Offset: 0x000B88FD
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x000BA70A File Offset: 0x000B890A
		public virtual float MinDistance
		{
			get
			{
				return this.Instance.MinDistance;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06004A84 RID: 19076 RVA: 0x000BA717 File Offset: 0x000B8917
		public virtual float InteractWaitTime
		{
			get
			{
				return this.Instance.InteractWaitTime;
			}
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x000BA724 File Offset: 0x000B8924
		public virtual float ShootWaitTime
		{
			get
			{
				return this.Instance.ShootWaitTime;
			}
		}

		// Token: 0x04002A85 RID: 10885
		private IExploreSkillArrowInteractPoint Instance;
	}
}
