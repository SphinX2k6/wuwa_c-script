using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002613 RID: 9747
	public class ILongPressInteractStyleConfigDefault : ILongPressInteractStyleConfig
	{
		// Token: 0x0600DAD2 RID: 56018 RVA: 0x002097C9 File Offset: 0x002079C9
		[NullableContext(1)]
		public static ILongPressInteractStyleConfigDefault Create(ILongPressInteractStyleConfigDefault? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleConfigDefault
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700406E RID: 16494
		// (get) Token: 0x0600DAD3 RID: 56019 RVA: 0x002097E8 File Offset: 0x002079E8
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007989 RID: 31113
		private ILongPressInteractStyleConfigDefault Instance;
	}
}
