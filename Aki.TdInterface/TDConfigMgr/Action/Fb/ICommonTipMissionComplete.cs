using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A12 RID: 10770
	public class ICommonTipMissionComplete : ICommonTipType
	{
		// Token: 0x0600EE0B RID: 60939 RVA: 0x0022F5C5 File Offset: 0x0022D7C5
		public static ICommonTipMissionComplete Create(ICommonTipMissionComplete? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipMissionComplete
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004695 RID: 18069
		// (get) Token: 0x0600EE0C RID: 60940 RVA: 0x0022F5E4 File Offset: 0x0022D7E4
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004696 RID: 18070
		// (get) Token: 0x0600EE0D RID: 60941 RVA: 0x0022F5F1 File Offset: 0x0022D7F1
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004697 RID: 18071
		// (get) Token: 0x0600EE0E RID: 60942 RVA: 0x0022F5FE File Offset: 0x0022D7FE
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004698 RID: 18072
		// (get) Token: 0x0600EE0F RID: 60943 RVA: 0x0022F60B File Offset: 0x0022D80B
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004699 RID: 18073
		// (get) Token: 0x0600EE10 RID: 60944 RVA: 0x0022F60E File Offset: 0x0022D80E
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x040082F2 RID: 33522
		private ICommonTipMissionComplete Instance;
	}
}
