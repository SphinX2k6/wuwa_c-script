using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ADD RID: 10973
	public class IMechStuntConfigType
	{
		// Token: 0x0600F19A RID: 61850 RVA: 0x002354B6 File Offset: 0x002336B6
		public static IMechStuntConfigType Create(IMechStuntConfigType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntConfigType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700488E RID: 18574
		// (get) Token: 0x0600F19B RID: 61851 RVA: 0x002354D5 File Offset: 0x002336D5
		public virtual EMechStuntType Type
		{
			get
			{
				return (EMechStuntType)this.Instance.Type;
			}
		}

		// Token: 0x040084AD RID: 33965
		private IMechStuntConfigType Instance;
	}
}
