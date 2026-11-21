using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A11 RID: 10769
	public class ICommonTipTriggerDelegation : ICommonTipType
	{
		// Token: 0x0600EE04 RID: 60932 RVA: 0x0022F571 File Offset: 0x0022D771
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

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x0600EE05 RID: 60933 RVA: 0x0022F590 File Offset: 0x0022D790
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x0600EE06 RID: 60934 RVA: 0x0022F59D File Offset: 0x0022D79D
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x0600EE07 RID: 60935 RVA: 0x0022F5AA File Offset: 0x0022D7AA
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004693 RID: 18067
		// (get) Token: 0x0600EE08 RID: 60936 RVA: 0x0022F5B7 File Offset: 0x0022D7B7
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004694 RID: 18068
		// (get) Token: 0x0600EE09 RID: 60937 RVA: 0x0022F5BA File Offset: 0x0022D7BA
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082F1 RID: 33521
		private ICommonTipTriggerDelegation Instance;
	}
}
