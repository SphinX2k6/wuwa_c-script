using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002951 RID: 10577
	public class IMp4BackgroundColor
	{
		// Token: 0x0600EAD4 RID: 60116 RVA: 0x0022A145 File Offset: 0x00228345
		public static IMp4BackgroundColor Create(IMp4BackgroundColor? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMp4BackgroundColor
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170044E0 RID: 17632
		// (get) Token: 0x0600EAD5 RID: 60117 RVA: 0x0022A164 File Offset: 0x00228364
		public virtual EMp4BackgroundColor FadeIn
		{
			get
			{
				return (EMp4BackgroundColor)this.Instance.FadeIn;
			}
		}

		// Token: 0x170044E1 RID: 17633
		// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x0022A171 File Offset: 0x00228371
		public virtual EMp4BackgroundColor FadeOut
		{
			get
			{
				return (EMp4BackgroundColor)this.Instance.FadeOut;
			}
		}

		// Token: 0x04008161 RID: 33121
		private IMp4BackgroundColor Instance;
	}
}
