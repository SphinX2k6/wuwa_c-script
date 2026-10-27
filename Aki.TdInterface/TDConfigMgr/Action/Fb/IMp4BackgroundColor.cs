using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200268E RID: 9870
	public class IMp4BackgroundColor
	{
		// Token: 0x0600DCFD RID: 56573 RVA: 0x0020D9A5 File Offset: 0x0020BBA5
		[NullableContext(1)]
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

		// Token: 0x170041A3 RID: 16803
		// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x0020D9C4 File Offset: 0x0020BBC4
		public virtual EMp4BackgroundColor FadeIn
		{
			get
			{
				return (EMp4BackgroundColor)this.Instance.FadeIn;
			}
		}

		// Token: 0x170041A4 RID: 16804
		// (get) Token: 0x0600DCFF RID: 56575 RVA: 0x0020D9D1 File Offset: 0x0020BBD1
		public virtual EMp4BackgroundColor FadeOut
		{
			get
			{
				return (EMp4BackgroundColor)this.Instance.FadeOut;
			}
		}

		// Token: 0x04007AC4 RID: 31428
		private IMp4BackgroundColor Instance;
	}
}
