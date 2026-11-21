using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002832 RID: 10290
	public class IVisualNovelTransitionLocation : IVisualNovelTransitionConfigBase
	{
		// Token: 0x0600E50A RID: 58634 RVA: 0x0021D7E6 File Offset: 0x0021B9E6
		public static IVisualNovelTransitionLocation Create(IVisualNovelTransitionLocation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelTransitionLocation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x0600E50B RID: 58635 RVA: 0x0021D805 File Offset: 0x0021BA05
		public override EVisualNovelTransitionType Type
		{
			get
			{
				return (EVisualNovelTransitionType)this.Instance.Type;
			}
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x0600E50C RID: 58636 RVA: 0x0021D812 File Offset: 0x0021BA12
		public virtual int LocationId
		{
			get
			{
				return this.Instance.LocationId;
			}
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x0600E50D RID: 58637 RVA: 0x0021D820 File Offset: 0x0021BA20
		public virtual int? TransitionBackgroundId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TransitionBackgroundId);
			}
		}

		// Token: 0x04007DAE RID: 32174
		private IVisualNovelTransitionLocation Instance;
	}
}
