using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A76 RID: 2678
	public class IInteractAdditionalInfo
	{
		// Token: 0x06003DB0 RID: 15792 RVA: 0x0009E37D File Offset: 0x0009C57D
		[NullableContext(1)]
		public static IInteractAdditionalInfo Create(IInteractAdditionalInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractAdditionalInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x06003DB1 RID: 15793 RVA: 0x0009E39C File Offset: 0x0009C59C
		public virtual EInteractAdditionalInfoType Type
		{
			get
			{
				return (EInteractAdditionalInfoType)this.Instance.Type;
			}
		}

		// Token: 0x0400225B RID: 8795
		private IInteractAdditionalInfo Instance;
	}
}
