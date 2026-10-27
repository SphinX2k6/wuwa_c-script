using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AAE RID: 2734
	public class IDynamicEntityRewardType
	{
		// Token: 0x06003F0F RID: 16143 RVA: 0x000A14D9 File Offset: 0x0009F6D9
		[NullableContext(1)]
		public static IDynamicEntityRewardType Create(IDynamicEntityRewardType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDynamicEntityRewardType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x000A14F8 File Offset: 0x0009F6F8
		public virtual EDynamicEntityRewardType Type
		{
			get
			{
				return (EDynamicEntityRewardType)this.Instance.Type;
			}
		}

		// Token: 0x04002307 RID: 8967
		private IDynamicEntityRewardType Instance;
	}
}
