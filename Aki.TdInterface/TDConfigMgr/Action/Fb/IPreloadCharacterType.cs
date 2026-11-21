using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CCB RID: 11467
	public class IPreloadCharacterType
	{
		// Token: 0x0600FB5E RID: 64350 RVA: 0x00246982 File Offset: 0x00244B82
		public static IPreloadCharacterType Create(IPreloadCharacterType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadCharacterType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E76 RID: 20086
		// (get) Token: 0x0600FB5F RID: 64351 RVA: 0x002469A1 File Offset: 0x00244BA1
		public virtual EPreloadObjectType Type
		{
			get
			{
				return (EPreloadObjectType)this.Instance.Type;
			}
		}

		// Token: 0x04008957 RID: 35159
		private IPreloadCharacterType Instance;
	}
}
