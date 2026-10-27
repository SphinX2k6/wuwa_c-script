using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028FB RID: 10491
	public class IModifyMaterialConfig
	{
		// Token: 0x0600E8FB RID: 59643 RVA: 0x00222C76 File Offset: 0x00220E76
		[NullableContext(1)]
		public static IModifyMaterialConfig Create(IModifyMaterialConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMaterialConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x0600E8FC RID: 59644 RVA: 0x00222C95 File Offset: 0x00220E95
		public virtual EModifyActorMaterialType Type
		{
			get
			{
				return (EModifyActorMaterialType)this.Instance.Type;
			}
		}

		// Token: 0x0400809D RID: 32925
		private IModifyMaterialConfig Instance;
	}
}
