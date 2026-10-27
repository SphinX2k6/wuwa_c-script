using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002745 RID: 10053
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipTriggerDelegation : ICommonTipType
	{
		// Token: 0x0600E004 RID: 57348 RVA: 0x00212A39 File Offset: 0x00210C39
		public static ICommonTipTriggerDelegation Create(ICommonTipTriggerDelegation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipTriggerDelegation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700433C RID: 17212
		// (get) Token: 0x0600E005 RID: 57349 RVA: 0x00212A58 File Offset: 0x00210C58
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700433D RID: 17213
		// (get) Token: 0x0600E006 RID: 57350 RVA: 0x00212A65 File Offset: 0x00210C65
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x1700433E RID: 17214
		// (get) Token: 0x0600E007 RID: 57351 RVA: 0x00212A72 File Offset: 0x00210C72
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x0600E008 RID: 57352 RVA: 0x00212A7F File Offset: 0x00210C7F
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004340 RID: 17216
		// (get) Token: 0x0600E009 RID: 57353 RVA: 0x00212A82 File Offset: 0x00210C82
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C43 RID: 31811
		private ICommonTipTriggerDelegation Instance;
	}
}
