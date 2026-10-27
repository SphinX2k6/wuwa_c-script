using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002612 RID: 9746
	public class ILongPressInteractStyleConfig
	{
		// Token: 0x0600DACF RID: 56015 RVA: 0x00209795 File Offset: 0x00207995
		[NullableContext(1)]
		public static ILongPressInteractStyleConfig Create(ILongPressInteractStyleConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700406D RID: 16493
		// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x002097B4 File Offset: 0x002079B4
		public virtual ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007988 RID: 31112
		private ILongPressInteractStyleConfig Instance;
	}
}
