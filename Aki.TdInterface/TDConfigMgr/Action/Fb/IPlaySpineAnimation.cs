using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029FF RID: 10751
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlaySpineAnimation : ISetSpineAnimationType
	{
		// Token: 0x0600ED45 RID: 60741 RVA: 0x00229A61 File Offset: 0x00227C61
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

		// Token: 0x17004B09 RID: 19209
		// (get) Token: 0x0600ED46 RID: 60742 RVA: 0x00229A80 File Offset: 0x00227C80
		public override ESetSpineAnimation Type
		{
			get
			{
				return (ESetSpineAnimation)this.Instance.Type;
			}
		}

		// Token: 0x17004B0A RID: 19210
		// (get) Token: 0x0600ED47 RID: 60743 RVA: 0x00229A8D File Offset: 0x00227C8D
		public virtual string Name
		{
			get
			{
				return this.Instance.Name;
			}
		}

		// Token: 0x17004B0B RID: 19211
		// (get) Token: 0x0600ED48 RID: 60744 RVA: 0x00229A9A File Offset: 0x00227C9A
		public virtual bool IsLoop
		{
			get
			{
				return this.Instance.IsLoop;
			}
		}

		// Token: 0x0400829F RID: 33439
		private IPlaySpineAnimation Instance;
	}
}
