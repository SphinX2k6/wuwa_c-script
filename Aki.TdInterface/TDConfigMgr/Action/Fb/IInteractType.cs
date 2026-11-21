using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C7 RID: 10439
	public class IInteractType
	{
		// Token: 0x0600E872 RID: 59506 RVA: 0x00225B01 File Offset: 0x00223D01
		public static IInteractType Create(IInteractType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x0600E873 RID: 59507 RVA: 0x00225B20 File Offset: 0x00223D20
		public virtual EInteractOption Type
		{
			get
			{
				return (EInteractOption)this.Instance.Type;
			}
		}

		// Token: 0x0400800D RID: 32781
		private IInteractType Instance;
	}
}
