using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014FC RID: 5372
	public class ITakePhotoPosCondition
	{
		// Token: 0x060079B0 RID: 31152 RVA: 0x00122C1D File Offset: 0x00120E1D
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

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x060079B1 RID: 31153 RVA: 0x00122C3C File Offset: 0x00120E3C
		public virtual int RangeEntity
		{
			get
			{
				return this.Instance.RangeEntity;
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x00122C49 File Offset: 0x00120E49
		public virtual string TidDescription
		{
			get
			{
				return this.Instance.TidDescription;
			}
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x060079B3 RID: 31155 RVA: 0x00122C56 File Offset: 0x00120E56
		[Nullable(2)]
		public virtual string EdTidDescription
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04004604 RID: 17924
		private ITakePhotoPosCondition Instance;
	}
}
