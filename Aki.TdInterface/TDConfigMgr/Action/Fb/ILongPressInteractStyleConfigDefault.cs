using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D3 RID: 10451
	public class ILongPressInteractStyleConfigDefault : ILongPressInteractStyleConfig
	{
		// Token: 0x0600E89F RID: 59551 RVA: 0x00225F1D File Offset: 0x0022411D
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

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x00225F3C File Offset: 0x0022413C
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x04008023 RID: 32803
		private ILongPressInteractStyleConfigDefault Instance;
	}
}
