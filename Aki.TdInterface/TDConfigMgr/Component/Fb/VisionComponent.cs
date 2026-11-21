using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C40 RID: 3136
	public class VisionComponent : IComponentBase
	{
		// Token: 0x060047DB RID: 18395 RVA: 0x000B6247 File Offset: 0x000B4447
		public static VisionComponent Create(IVisionComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001356 RID: 4950
		// (get) Token: 0x060047DC RID: 18396 RVA: 0x000B6268 File Offset: 0x000B4468
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001357 RID: 4951
		// (get) Token: 0x060047DD RID: 18397 RVA: 0x000B62A0 File Offset: 0x000B44A0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001358 RID: 4952
		// (get) Token: 0x060047DE RID: 18398 RVA: 0x000B62B6 File Offset: 0x000B44B6
		public virtual int VisionId
		{
			get
			{
				return this.Instance.VisionId;
			}
		}

		// Token: 0x04002861 RID: 10337
		private IVisionComponent Instance;
	}
}
