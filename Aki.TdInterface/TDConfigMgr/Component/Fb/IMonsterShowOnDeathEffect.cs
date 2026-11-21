using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE7 RID: 3303
	public class IMonsterShowOnDeathEffect : IMonsterShowOnDeathConfig
	{
		// Token: 0x06004B63 RID: 19299 RVA: 0x000BD104 File Offset: 0x000BB304
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

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x000BD123 File Offset: 0x000BB323
		public override EMonsterShowOnDeathType Type
		{
			get
			{
				return (EMonsterShowOnDeathType)this.Instance.Type;
			}
		}

		// Token: 0x17001591 RID: 5521
		// (get) Token: 0x06004B65 RID: 19301 RVA: 0x000BD130 File Offset: 0x000BB330
		public virtual int EffectId
		{
			get
			{
				return this.Instance.EffectId;
			}
		}

		// Token: 0x04002A9C RID: 10908
		private IMonsterShowOnDeathEffect Instance;
	}
}
