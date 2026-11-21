using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D5 RID: 10453
	public class ILongPressInteractStyleSwordRider : ILongPressInteractStyleConfig
	{
		// Token: 0x0600E8A8 RID: 59560 RVA: 0x00225FCD File Offset: 0x002241CD
		public static ILongPressInteractStyleSwordRider Create(ILongPressInteractStyleSwordRider? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleSwordRider
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x0600E8A9 RID: 59561 RVA: 0x00225FEC File Offset: 0x002241EC
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x04008025 RID: 32805
		private ILongPressInteractStyleSwordRider Instance;
	}
}
