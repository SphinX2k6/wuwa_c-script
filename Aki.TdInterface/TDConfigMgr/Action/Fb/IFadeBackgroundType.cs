using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002771 RID: 10097
	public class IFadeBackgroundType
	{
		// Token: 0x0600E0D7 RID: 57559 RVA: 0x00213943 File Offset: 0x00211B43
		[NullableContext(1)]
		public static IFadeBackgroundType Create(IFadeBackgroundType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFadeBackgroundType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x00213962 File Offset: 0x00211B62
		public virtual EFadeBackgroundType Type
		{
			get
			{
				return (EFadeBackgroundType)this.Instance.Type;
			}
		}

		// Token: 0x04007C7F RID: 31871
		private IFadeBackgroundType Instance;
	}
}
