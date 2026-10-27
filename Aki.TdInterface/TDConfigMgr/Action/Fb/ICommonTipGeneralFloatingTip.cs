using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002748 RID: 10056
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipGeneralFloatingTip : ICommonTipType
	{
		// Token: 0x0600E017 RID: 57367 RVA: 0x00212B2F File Offset: 0x00210D2F
		public static ICommonTipGeneralFloatingTip Create(ICommonTipGeneralFloatingTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipGeneralFloatingTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004349 RID: 17225
		// (get) Token: 0x0600E018 RID: 57368 RVA: 0x00212B4E File Offset: 0x00210D4E
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700434A RID: 17226
		// (get) Token: 0x0600E019 RID: 57369 RVA: 0x00212B5B File Offset: 0x00210D5B
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700434B RID: 17227
		// (get) Token: 0x0600E01A RID: 57370 RVA: 0x00212B68 File Offset: 0x00210D68
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C46 RID: 31814
		private ICommonTipGeneralFloatingTip Instance;
	}
}
