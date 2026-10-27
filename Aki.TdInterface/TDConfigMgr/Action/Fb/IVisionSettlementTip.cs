using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200275A RID: 10074
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSettlementTip : ICommonTipType
	{
		// Token: 0x0600E070 RID: 57456 RVA: 0x00213099 File Offset: 0x00211299
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

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x0600E071 RID: 57457 RVA: 0x002130B8 File Offset: 0x002112B8
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x0600E072 RID: 57458 RVA: 0x002130C5 File Offset: 0x002112C5
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x0600E073 RID: 57459 RVA: 0x002130D2 File Offset: 0x002112D2
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x0600E074 RID: 57460 RVA: 0x002130DF File Offset: 0x002112DF
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x0600E075 RID: 57461 RVA: 0x002130E2 File Offset: 0x002112E2
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C58 RID: 31832
		private IVisionSettlementTip Instance;
	}
}
