using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B0C RID: 2828
	public class IMotorAutoEjectNextHookConfig : IMotorAutoEjectConfigBase
	{
		// Token: 0x06004153 RID: 16723 RVA: 0x000A7C7E File Offset: 0x000A5E7E
		[NullableContext(1)]
		public static IMotorAutoEjectNextHookConfig Create(IMotorAutoEjectNextHookConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorAutoEjectNextHookConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x000A7C9D File Offset: 0x000A5E9D
		public override EMotorAutoEjectType Type
		{
			get
			{
				return (EMotorAutoEjectType)this.Instance.Type;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06004155 RID: 16725 RVA: 0x000A7CAA File Offset: 0x000A5EAA
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x040024CD RID: 9421
		private IMotorAutoEjectNextHookConfig Instance;
	}
}
