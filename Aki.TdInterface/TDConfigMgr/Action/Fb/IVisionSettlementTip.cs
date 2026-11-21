using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A26 RID: 10790
	public class IVisionSettlementTip : ICommonTipType
	{
		// Token: 0x0600EE70 RID: 61040 RVA: 0x0022FBD1 File Offset: 0x0022DDD1
		public static IVisionSettlementTip Create(IVisionSettlementTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSettlementTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x0600EE71 RID: 61041 RVA: 0x0022FBF0 File Offset: 0x0022DDF0
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x0600EE72 RID: 61042 RVA: 0x0022FBFD File Offset: 0x0022DDFD
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x0600EE73 RID: 61043 RVA: 0x0022FC0A File Offset: 0x0022DE0A
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x0600EE74 RID: 61044 RVA: 0x0022FC17 File Offset: 0x0022DE17
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x0600EE75 RID: 61045 RVA: 0x0022FC1A File Offset: 0x0022DE1A
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04008306 RID: 33542
		private IVisionSettlementTip Instance;
	}
}
