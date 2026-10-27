using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002746 RID: 10054
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipMissionComplete : ICommonTipType
	{
		// Token: 0x0600E00B RID: 57355 RVA: 0x00212A8D File Offset: 0x00210C8D
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

		// Token: 0x17004341 RID: 17217
		// (get) Token: 0x0600E00C RID: 57356 RVA: 0x00212AAC File Offset: 0x00210CAC
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x17004342 RID: 17218
		// (get) Token: 0x0600E00D RID: 57357 RVA: 0x00212AB9 File Offset: 0x00210CB9
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004343 RID: 17219
		// (get) Token: 0x0600E00E RID: 57358 RVA: 0x00212AC6 File Offset: 0x00210CC6
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004344 RID: 17220
		// (get) Token: 0x0600E00F RID: 57359 RVA: 0x00212AD3 File Offset: 0x00210CD3
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004345 RID: 17221
		// (get) Token: 0x0600E010 RID: 57360 RVA: 0x00212AD6 File Offset: 0x00210CD6
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C44 RID: 31812
		private ICommonTipMissionComplete Instance;
	}
}
