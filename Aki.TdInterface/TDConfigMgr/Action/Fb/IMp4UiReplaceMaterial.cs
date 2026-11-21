using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002899 RID: 10393
	public class IMp4UiReplaceMaterial : IProgramSpecialConfigBase
	{
		// Token: 0x0600E799 RID: 59289 RVA: 0x002241DF File Offset: 0x002223DF
		public static IMp4UiReplaceMaterial Create(IMp4UiReplaceMaterial? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4UiReplaceMaterial
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004315 RID: 17173
		// (get) Token: 0x0600E79A RID: 59290 RVA: 0x002241FE File Offset: 0x002223FE
		public override EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				return (EPlayMovieProgramSpecialConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004316 RID: 17174
		// (get) Token: 0x0600E79B RID: 59291 RVA: 0x0022420B File Offset: 0x0022240B
		public virtual string Mp4UiReplaceMaterial
		{
			get
			{
				return this.Instance.Mp4UiReplaceMaterial;
			}
		}

		// Token: 0x04007F8D RID: 32653
		private IMp4UiReplaceMaterial Instance;
	}
}
