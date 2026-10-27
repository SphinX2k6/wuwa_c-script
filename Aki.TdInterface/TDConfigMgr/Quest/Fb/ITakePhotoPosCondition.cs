using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013AB RID: 5035
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhotoPosCondition
	{
		// Token: 0x06007309 RID: 29449 RVA: 0x00114561 File Offset: 0x00112761
		public static ITakePhotoPosCondition Create(ITakePhotoPosCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhotoPosCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x0600730A RID: 29450 RVA: 0x00114580 File Offset: 0x00112780
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x0600730B RID: 29451 RVA: 0x0011458D File Offset: 0x0011278D
		public virtual string TidDescription
		{
			get
			{
				return this.Instance.TidDescription;
			}
		}

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x0600730C RID: 29452 RVA: 0x0011459A File Offset: 0x0011279A
		[Nullable(2)]
		public virtual string EdTidDescription
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004283 RID: 17027
		private ITakePhotoPosCondition Instance;
	}
}
