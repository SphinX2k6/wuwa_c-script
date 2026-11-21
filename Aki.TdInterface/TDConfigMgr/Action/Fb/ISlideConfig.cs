using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BCB RID: 11211
	public class ISlideConfig : ISportConfig
	{
		// Token: 0x0600F71F RID: 63263 RVA: 0x0023FBDD File Offset: 0x0023DDDD
		public static ISlideConfig Create(ISlideConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C37 RID: 19511
		// (get) Token: 0x0600F720 RID: 63264 RVA: 0x0023FBFC File Offset: 0x0023DDFC
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x17004C38 RID: 19512
		// (get) Token: 0x0600F721 RID: 63265 RVA: 0x0023FC09 File Offset: 0x0023DE09
		public virtual int SlideId
		{
			get
			{
				return this.Instance.SlideId;
			}
		}

		// Token: 0x04008753 RID: 34643
		private ISlideConfig Instance;
	}
}
