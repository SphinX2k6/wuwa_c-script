using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F3 RID: 10483
	public class ISlideConfig : ISportConfig
	{
		// Token: 0x0600E8DE RID: 59614 RVA: 0x00222A25 File Offset: 0x00220C25
		[NullableContext(1)]
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

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x0600E8DF RID: 59615 RVA: 0x00222A44 File Offset: 0x00220C44
		public override ESportStateType Type
		{
			get
			{
				return (ESportStateType)this.Instance.Type;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x00222A51 File Offset: 0x00220C51
		public virtual int SlideId
		{
			get
			{
				return this.Instance.SlideId;
			}
		}

		// Token: 0x0400808F RID: 32911
		private ISlideConfig Instance;
	}
}
