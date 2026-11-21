using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028DD RID: 10461
	[NullableContext(2)]
	[Nullable(0)]
	public class ChangeInteractOptionText : ActionParams
	{
		// Token: 0x0600E8DF RID: 59615 RVA: 0x002268DC File Offset: 0x00224ADC
		[NullableContext(0)]
		public static ChangeInteractOptionText Create(IChangeInteractOptionText? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeInteractOptionText
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x002268FB File Offset: 0x00224AFB
		public virtual string TidContent
		{
			get
			{
				return this.Instance.TidContent;
			}
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x0600E8E1 RID: 59617 RVA: 0x00226908 File Offset: 0x00224B08
		public virtual string EdTidContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x04008053 RID: 32851
		private IChangeInteractOptionText Instance;
	}
}
