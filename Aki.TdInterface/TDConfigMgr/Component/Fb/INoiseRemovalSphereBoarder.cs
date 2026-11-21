using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000F46 RID: 3910
	public class INoiseRemovalSphereBoarder : INoiseRemovalBoarderBase
	{
		// Token: 0x060057C1 RID: 22465 RVA: 0x000D6CFF File Offset: 0x000D4EFF
		public static INoiseRemovalSphereBoarder Create(INoiseRemovalSphereBoarder? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INoiseRemovalSphereBoarder
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x060057C2 RID: 22466 RVA: 0x000D6D1E File Offset: 0x000D4F1E
		public override ENoiseRemovalBoarderShape Type
		{
			get
			{
				return (ENoiseRemovalBoarderShape)this.Instance.Type;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060057C3 RID: 22467 RVA: 0x000D6D2B File Offset: 0x000D4F2B
		public virtual float Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x04003265 RID: 12901
		private INoiseRemovalSphereBoarder Instance;
	}
}
