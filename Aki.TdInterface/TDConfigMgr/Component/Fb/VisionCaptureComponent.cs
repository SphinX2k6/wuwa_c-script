using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C41 RID: 3137
	public class VisionCaptureComponent : IComponentBase
	{
		// Token: 0x060047E0 RID: 18400 RVA: 0x000B62CB File Offset: 0x000B44CB
		public static VisionCaptureComponent Create(IVisionCaptureComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new VisionCaptureComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060047E1 RID: 18401 RVA: 0x000B62EC File Offset: 0x000B44EC
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

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060047E2 RID: 18402 RVA: 0x000B6324 File Offset: 0x000B4524
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060047E3 RID: 18403 RVA: 0x000B633A File Offset: 0x000B453A
		public virtual int VisionCaptureId
		{
			get
			{
				return this.Instance.VisionCaptureId;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x060047E4 RID: 18404 RVA: 0x000B6348 File Offset: 0x000B4548
		public virtual int? VisionCaptureProb
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.VisionCaptureProb);
			}
		}

		// Token: 0x04002862 RID: 10338
		private IVisionCaptureComponent Instance;
	}
}
