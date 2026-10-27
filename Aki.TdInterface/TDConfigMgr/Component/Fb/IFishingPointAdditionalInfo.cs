using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000A77 RID: 2679
	public class IFishingPointAdditionalInfo : IInteractAdditionalInfo
	{
		// Token: 0x06003DB3 RID: 15795 RVA: 0x0009E3B1 File Offset: 0x0009C5B1
		[NullableContext(1)]
		public static IFishingPointAdditionalInfo Create(IFishingPointAdditionalInfo? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFishingPointAdditionalInfo
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x0009E3D0 File Offset: 0x0009C5D0
		public override EInteractAdditionalInfoType Type
		{
			get
			{
				return (EInteractAdditionalInfoType)this.Instance.Type;
			}
		}

		// Token: 0x0400225C RID: 8796
		private IFishingPointAdditionalInfo Instance;
	}
}
