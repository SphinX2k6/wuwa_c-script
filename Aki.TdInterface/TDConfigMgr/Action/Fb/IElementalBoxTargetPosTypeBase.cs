using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B07 RID: 11015
	public class IElementalBoxTargetPosTypeBase
	{
		// Token: 0x0600F135 RID: 61749 RVA: 0x0022FC1F File Offset: 0x0022DE1F
		[NullableContext(1)]
		public static IElementalBoxTargetPosTypeBase Create(IElementalBoxTargetPosTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalBoxTargetPosTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CE9 RID: 19689
		// (get) Token: 0x0600F136 RID: 61750 RVA: 0x0022FC3E File Offset: 0x0022DE3E
		public virtual EElementalBoxTargetPosType Type
		{
			get
			{
				return (EElementalBoxTargetPosType)this.Instance.Type;
			}
		}

		// Token: 0x040084A7 RID: 33959
		private IElementalBoxTargetPosTypeBase Instance;
	}
}
