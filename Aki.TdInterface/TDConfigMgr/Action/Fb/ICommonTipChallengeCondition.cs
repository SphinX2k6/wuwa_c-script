using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002741 RID: 10049
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeCondition : ICommonTipType
	{
		// Token: 0x0600DFEE RID: 57326 RVA: 0x00212919 File Offset: 0x00210B19
		public static ICommonTipChallengeCondition Create(ICommonTipChallengeCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipChallengeCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x0600DFEF RID: 57327 RVA: 0x00212938 File Offset: 0x00210B38
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x0600DFF0 RID: 57328 RVA: 0x00212945 File Offset: 0x00210B45
		public virtual string TidMainText
		{
			get
			{
				return this.Instance.TidMainText;
			}
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x0600DFF1 RID: 57329 RVA: 0x00212952 File Offset: 0x00210B52
		public virtual string TidSubText
		{
			get
			{
				return this.Instance.TidSubText;
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x0600DFF2 RID: 57330 RVA: 0x0021295F File Offset: 0x00210B5F
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x0600DFF3 RID: 57331 RVA: 0x00212962 File Offset: 0x00210B62
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04007C3F RID: 31807
		private ICommonTipChallengeCondition Instance;
	}
}
