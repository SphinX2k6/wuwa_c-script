using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C49 RID: 11337
	public class IFocusOnCustomMapMark : IFocusOnMapMark
	{
		// Token: 0x0600F959 RID: 63833 RVA: 0x00243940 File Offset: 0x00241B40
		public static IFocusOnCustomMapMark Create(IFocusOnCustomMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnCustomMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D75 RID: 19829
		// (get) Token: 0x0600F95A RID: 63834 RVA: 0x0024395F File Offset: 0x00241B5F
		public override EMapMarkType Type
		{
			get
			{
				return (EMapMarkType)this.Instance.Type;
			}
		}

		// Token: 0x17004D76 RID: 19830
		// (get) Token: 0x0600F95B RID: 63835 RVA: 0x0024396C File Offset: 0x00241B6C
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x0400884D RID: 34893
		private IFocusOnCustomMapMark Instance;
	}
}
