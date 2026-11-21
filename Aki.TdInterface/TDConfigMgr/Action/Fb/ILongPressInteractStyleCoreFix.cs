using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028D6 RID: 10454
	public class ILongPressInteractStyleCoreFix : ILongPressInteractStyleConfig
	{
		// Token: 0x0600E8AB RID: 59563 RVA: 0x00226001 File Offset: 0x00224201
		public static ILongPressInteractStyleCoreFix Create(ILongPressInteractStyleCoreFix? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleCoreFix
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x0600E8AC RID: 59564 RVA: 0x00226020 File Offset: 0x00224220
		public override ELongPressInteractStyle Type
		{
			get
			{
				return (ELongPressInteractStyle)this.Instance.Type;
			}
		}

		// Token: 0x04008026 RID: 32806
		private ILongPressInteractStyleCoreFix Instance;
	}
}
