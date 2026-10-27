using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002628 RID: 9768
	public class ICharacterLookAtData
	{
		// Token: 0x0600DB42 RID: 56130 RVA: 0x0020A5FE File Offset: 0x002087FE
		[NullableContext(1)]
		public static ICharacterLookAtData Create(ICharacterLookAtData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterLookAtData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040B4 RID: 16564
		// (get) Token: 0x0600DB43 RID: 56131 RVA: 0x0020A61D File Offset: 0x0020881D
		public virtual ECharacterLookAt Type
		{
			get
			{
				return (ECharacterLookAt)this.Instance.Type;
			}
		}

		// Token: 0x040079CE RID: 31182
		private ICharacterLookAtData Instance;
	}
}
