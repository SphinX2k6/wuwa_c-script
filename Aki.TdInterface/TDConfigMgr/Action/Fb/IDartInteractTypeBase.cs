using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002870 RID: 10352
	public class IDartInteractTypeBase
	{
		// Token: 0x0600E563 RID: 58723 RVA: 0x0021BA36 File Offset: 0x00219C36
		[NullableContext(1)]
		public static IDartInteractTypeBase Create(IDartInteractTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDartInteractTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x0600E564 RID: 58724 RVA: 0x0021BA55 File Offset: 0x00219C55
		public virtual EDartInteractType Type
		{
			get
			{
				return (EDartInteractType)this.Instance.Type;
			}
		}

		// Token: 0x04007ED6 RID: 32470
		private IDartInteractTypeBase Instance;
	}
}
