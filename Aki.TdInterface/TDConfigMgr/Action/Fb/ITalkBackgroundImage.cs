using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027C8 RID: 10184
	public class ITalkBackgroundImage : ITalkBackground
	{
		// Token: 0x0600E15A RID: 57690 RVA: 0x002120D6 File Offset: 0x002102D6
		public static ITalkBackgroundImage Create(ITalkBackgroundImage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0600E15B RID: 57691 RVA: 0x002120F5 File Offset: 0x002102F5
		public override ETalkBackgroundType Type
		{
			get
			{
				return (ETalkBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x00212102 File Offset: 0x00210302
		public virtual string ImageAsset
		{
			get
			{
				return this.Instance.ImageAsset;
			}
		}

		// Token: 0x04007A7C RID: 31356
		private ITalkBackgroundImage Instance;
	}
}
