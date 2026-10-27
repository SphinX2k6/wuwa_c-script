using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C85 RID: 3205
	public class IReboundType
	{
		// Token: 0x0600495C RID: 18780 RVA: 0x000B7F65 File Offset: 0x000B6165
		[NullableContext(1)]
		public static IReboundType Create(IReboundType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReboundType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600495D RID: 18781 RVA: 0x000B7F84 File Offset: 0x000B6184
		public virtual EReboundOptionType Type
		{
			get
			{
				return (EReboundOptionType)this.Instance.Type;
			}
		}

		// Token: 0x040029D8 RID: 10712
		private IReboundType Instance;
	}
}
