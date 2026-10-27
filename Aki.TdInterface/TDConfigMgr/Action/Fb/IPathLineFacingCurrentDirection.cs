using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D8 RID: 10456
	public class IPathLineFacingCurrentDirection : IPathLineFacingType
	{
		// Token: 0x0600E832 RID: 59442 RVA: 0x0022143B File Offset: 0x0021F63B
		[NullableContext(1)]
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

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x0600E833 RID: 59443 RVA: 0x0022145A File Offset: 0x0021F65A
		public override EPathLineFacingType Type
		{
			get
			{
				return (EPathLineFacingType)this.Instance.Type;
			}
		}

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x0600E834 RID: 59444 RVA: 0x00221468 File Offset: 0x0021F668
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

		// Token: 0x04008056 RID: 32854
		private IPathLineFacingCurrentDirection Instance;
	}
}
