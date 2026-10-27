using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AE5 RID: 2789
	public class ITrampleTipType
	{
		// Token: 0x06004034 RID: 16436 RVA: 0x000A3E8D File Offset: 0x000A208D
		[NullableContext(1)]
		public static ITrampleTipType Create(ITrampleTipType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrampleTipType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06004035 RID: 16437 RVA: 0x000A3EAC File Offset: 0x000A20AC
		public virtual ETrampleTipType Type
		{
			get
			{
				return (ETrampleTipType)this.Instance.Type;
			}
		}

		// Token: 0x040023B8 RID: 9144
		private ITrampleTipType Instance;
	}
}
