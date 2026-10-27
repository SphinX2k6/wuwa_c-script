using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B5 RID: 5045
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2TargetAnsTagCondition
	{
		// Token: 0x0600732F RID: 29487 RVA: 0x0011493C File Offset: 0x00112B3C
		public static ITakePhoto2TargetAnsTagCondition Create(ITakePhoto2TargetAnsTagCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2TargetAnsTagCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x06007330 RID: 29488 RVA: 0x0011495B File Offset: 0x00112B5B
		public virtual string MontageTag
		{
			get
			{
				return this.Instance.MontageTag;
			}
		}

		// Token: 0x0400429B RID: 17051
		private ITakePhoto2TargetAnsTagCondition Instance;
	}
}
