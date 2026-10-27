using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002505 RID: 9477
	public class IHeadStyleWeakSignal : IHeadStyle
	{
		// Token: 0x0600D37B RID: 54139 RVA: 0x001F58BE File Offset: 0x001F3ABE
		[NullableContext(1)]
		public static IHeadStyleWeakSignal Create(IHeadStyleWeakSignal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWeakSignal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600D37C RID: 54140 RVA: 0x001F58DD File Offset: 0x001F3ADD
		public override EHeadStyle Type
		{
			get
			{
				return (EHeadStyle)this.Instance.Type;
			}
		}

		// Token: 0x040073EF RID: 29679
		private IHeadStyleWeakSignal Instance;
	}
}
