using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200274C RID: 10060
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipFirstComplete : ICommonTipType
	{
		// Token: 0x0600E028 RID: 57384 RVA: 0x00212C2C File Offset: 0x00210E2C
		public static ICommonTipFirstComplete Create(ICommonTipFirstComplete? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipFirstComplete
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004352 RID: 17234
		// (get) Token: 0x0600E029 RID: 57385 RVA: 0x00212C4B File Offset: 0x00210E4B
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004353 RID: 17235
		// (get) Token: 0x0600E02A RID: 57386 RVA: 0x00212C58 File Offset: 0x00210E58
		public virtual string TidText
		{
			get
			{
				return this.Instance.TidText;
			}
		}

		// Token: 0x17004354 RID: 17236
		// (get) Token: 0x0600E02B RID: 57387 RVA: 0x00212C65 File Offset: 0x00210E65
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C4A RID: 31818
		private ICommonTipFirstComplete Instance;
	}
}
