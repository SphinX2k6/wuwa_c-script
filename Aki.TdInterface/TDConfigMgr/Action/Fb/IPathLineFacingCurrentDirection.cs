using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BAD RID: 11181
	public class IPathLineFacingCurrentDirection : IPathLineFacingType
	{
		// Token: 0x0600F661 RID: 63073 RVA: 0x0023E3BB File Offset: 0x0023C5BB
		public static IPathLineFacingCurrentDirection Create(IPathLineFacingCurrentDirection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCurrentDirection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004BB5 RID: 19381
		// (get) Token: 0x0600F662 RID: 63074 RVA: 0x0023E3DA File Offset: 0x0023C5DA
		public override EPathLineFacingType Type
		{
			get
			{
				return (EPathLineFacingType)this.Instance.Type;
			}
		}

		// Token: 0x17004BB6 RID: 19382
		// (get) Token: 0x0600F663 RID: 63075 RVA: 0x0023E3E8 File Offset: 0x0023C5E8
		public virtual float? YawOffset
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new float?(this.Instance.YawOffset);
			}
		}

		// Token: 0x04008715 RID: 34581
		private IPathLineFacingCurrentDirection Instance;
	}
}
