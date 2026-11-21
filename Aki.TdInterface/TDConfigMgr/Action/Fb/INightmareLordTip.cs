using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A21 RID: 10785
	public class INightmareLordTip : ICommonTipType
	{
		// Token: 0x0600EE54 RID: 61012 RVA: 0x0022FA4C File Offset: 0x0022DC4C
		public static INightmareLordTip Create(INightmareLordTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareLordTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046C0 RID: 18112
		// (get) Token: 0x0600EE55 RID: 61013 RVA: 0x0022FA6B File Offset: 0x0022DC6B
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046C1 RID: 18113
		// (get) Token: 0x0600EE56 RID: 61014 RVA: 0x0022FA78 File Offset: 0x0022DC78
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046C2 RID: 18114
		// (get) Token: 0x0600EE57 RID: 61015 RVA: 0x0022FA85 File Offset: 0x0022DC85
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x170046C3 RID: 18115
		// (get) Token: 0x0600EE58 RID: 61016 RVA: 0x0022FA92 File Offset: 0x0022DC92
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170046C4 RID: 18116
		// (get) Token: 0x0600EE59 RID: 61017 RVA: 0x0022FA95 File Offset: 0x0022DC95
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008301 RID: 33537
		private INightmareLordTip Instance;
	}
}
