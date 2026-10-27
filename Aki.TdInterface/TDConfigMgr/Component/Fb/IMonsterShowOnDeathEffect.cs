using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C17 RID: 3095
	public class IMonsterShowOnDeathEffect : IMonsterShowOnDeathConfig
	{
		// Token: 0x06004700 RID: 18176 RVA: 0x000B2F38 File Offset: 0x000B1138
		[NullableContext(1)]
		public static IMonsterShowOnDeathEffect Create(IMonsterShowOnDeathEffect? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterShowOnDeathEffect
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700148F RID: 5263
		// (get) Token: 0x06004701 RID: 18177 RVA: 0x000B2F57 File Offset: 0x000B1157
		public override EMonsterShowOnDeathType Type
		{
			get
			{
				return (EMonsterShowOnDeathType)this.Instance.Type;
			}
		}

		// Token: 0x17001490 RID: 5264
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x000B2F64 File Offset: 0x000B1164
		public virtual int EffectId
		{
			get
			{
				return this.Instance.EffectId;
			}
		}

		// Token: 0x04002850 RID: 10320
		private IMonsterShowOnDeathEffect Instance;
	}
}
