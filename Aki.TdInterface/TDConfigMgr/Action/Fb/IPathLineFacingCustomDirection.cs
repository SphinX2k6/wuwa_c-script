using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D9 RID: 10457
	public class IPathLineFacingCustomDirection : IPathLineFacingType
	{
		// Token: 0x0600E836 RID: 59446 RVA: 0x002214A6 File Offset: 0x0021F6A6
		[NullableContext(1)]
		public static IPathLineFacingCustomDirection Create(IPathLineFacingCustomDirection? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCustomDirection
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x0600E837 RID: 59447 RVA: 0x002214C5 File Offset: 0x0021F6C5
		public override EPathLineFacingType Type
		{
			get
			{
				return (EPathLineFacingType)this.Instance.Type;
			}
		}

		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x0600E838 RID: 59448 RVA: 0x002214D2 File Offset: 0x0021F6D2
		public virtual float Yaw
		{
			get
			{
				return this.Instance.Yaw;
			}
		}

		// Token: 0x04008057 RID: 32855
		private IPathLineFacingCustomDirection Instance;
	}
}
