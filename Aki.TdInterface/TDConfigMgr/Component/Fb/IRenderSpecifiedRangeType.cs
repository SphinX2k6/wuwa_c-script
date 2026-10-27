using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D69 RID: 3433
	public class IRenderSpecifiedRangeType
	{
		// Token: 0x06004E23 RID: 20003 RVA: 0x000C205E File Offset: 0x000C025E
		[NullableContext(1)]
		public static IRenderSpecifiedRangeType Create(IRenderSpecifiedRangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderSpecifiedRangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x000C207D File Offset: 0x000C027D
		public virtual ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x04002CC8 RID: 11464
		private IRenderSpecifiedRangeType Instance;
	}
}
