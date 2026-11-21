using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A28 RID: 10792
	public class IFlipperTip : ICommonTipType
	{
		// Token: 0x0600EE7E RID: 61054 RVA: 0x0022FC79 File Offset: 0x0022DE79
		public static IFlipperTip Create(IFlipperTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046DC RID: 18140
		// (get) Token: 0x0600EE7F RID: 61055 RVA: 0x0022FC98 File Offset: 0x0022DE98
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046DD RID: 18141
		// (get) Token: 0x0600EE80 RID: 61056 RVA: 0x0022FCA5 File Offset: 0x0022DEA5
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x0600EE81 RID: 61057 RVA: 0x0022FCB2 File Offset: 0x0022DEB2
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x0600EE82 RID: 61058 RVA: 0x0022FCBF File Offset: 0x0022DEBF
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170046E0 RID: 18144
		// (get) Token: 0x0600EE83 RID: 61059 RVA: 0x0022FCC2 File Offset: 0x0022DEC2
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008308 RID: 33544
		private IFlipperTip Instance;
	}
}
