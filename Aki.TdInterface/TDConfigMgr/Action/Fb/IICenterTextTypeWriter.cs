using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002993 RID: 10643
	public class IICenterTextTypeWriter : ICenterTextShowType
	{
		// Token: 0x0600EBF5 RID: 60405 RVA: 0x0022BE5C File Offset: 0x0022A05C
		public static IICenterTextTypeWriter Create(IICenterTextTypeWriter? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextTypeWriter
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x0600EBF6 RID: 60406 RVA: 0x0022BE7B File Offset: 0x0022A07B
		public override ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x0600EBF7 RID: 60407 RVA: 0x0022BE88 File Offset: 0x0022A088
		public virtual int TextCountPerSecond
		{
			get
			{
				return this.Instance.TextCountPerSecond;
			}
		}

		// Token: 0x040081ED RID: 33261
		private IICenterTextTypeWriter Instance;
	}
}
