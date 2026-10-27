using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AAB RID: 2731
	public class IRefreshOnHostInteract : IRefreshConditionBase
	{
		// Token: 0x06003EFE RID: 16126 RVA: 0x000A1276 File Offset: 0x0009F476
		[NullableContext(1)]
		public static IRefreshOnHostInteract Create(IRefreshOnHostInteract? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRefreshOnHostInteract
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003EFF RID: 16127 RVA: 0x000A1295 File Offset: 0x0009F495
		public override ERewardDropType Type
		{
			get
			{
				return (ERewardDropType)this.Instance.Type;
			}
		}

		// Token: 0x040022FC RID: 8956
		private IRefreshOnHostInteract Instance;
	}
}
