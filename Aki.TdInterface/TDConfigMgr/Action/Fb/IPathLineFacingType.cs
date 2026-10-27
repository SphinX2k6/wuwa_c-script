using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D7 RID: 10455
	public class IPathLineFacingType
	{
		// Token: 0x0600E82F RID: 59439 RVA: 0x00221407 File Offset: 0x0021F607
		[NullableContext(1)]
		public static IPathLineFacingType Create(IPathLineFacingType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x0600E830 RID: 59440 RVA: 0x00221426 File Offset: 0x0021F626
		public virtual EPathLineFacingType Type
		{
			get
			{
				return (EPathLineFacingType)this.Instance.Type;
			}
		}

		// Token: 0x04008055 RID: 32853
		private IPathLineFacingType Instance;
	}
}
