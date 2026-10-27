using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B73 RID: 2931
	public class VisionCaptureComponent : IComponentBase
	{
		// Token: 0x06004387 RID: 17287 RVA: 0x000AC207 File Offset: 0x000AA407
		[NullableContext(1)]
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

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x000AC228 File Offset: 0x000AA428
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

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x06004389 RID: 17289 RVA: 0x000AC260 File Offset: 0x000AA460
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x000AC276 File Offset: 0x000AA476
		public virtual int VisionCaptureId
		{
			get
			{
				return this.Instance.VisionCaptureId;
			}
		}

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600438B RID: 17291 RVA: 0x000AC284 File Offset: 0x000AA484
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

		// Token: 0x0400261A RID: 9754
		private IVisionCaptureComponent Instance;
	}
}
