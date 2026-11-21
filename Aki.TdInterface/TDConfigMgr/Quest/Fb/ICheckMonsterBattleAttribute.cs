using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014E2 RID: 5346
	public class ICheckMonsterBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x06007932 RID: 31026 RVA: 0x00121CAA File Offset: 0x0011FEAA
		public static ICheckMonsterBattleAttribute Create(ICheckMonsterBattleAttribute? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckMonsterBattleAttribute
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x06007933 RID: 31027 RVA: 0x00121CC9 File Offset: 0x0011FEC9
		public override ETargetBattleAttribute Type
		{
			get
			{
				return (ETargetBattleAttribute)this.Instance.Type;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x06007934 RID: 31028 RVA: 0x00121CD6 File Offset: 0x0011FED6
		public virtual IHealthAttributeToTarget Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				this._OptionCache = IHealthAttributeToTarget.Create(this.Instance.Option);
				return this._OptionCache;
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x06007935 RID: 31029 RVA: 0x00121D0C File Offset: 0x0011FF0C
		public virtual List<int> EntityIds
		{
			get
			{
				if (this._EntityIdsInited)
				{
					return this._EntityIdsCache;
				}
				this._EntityIdsInited = true;
				int entityIdsLength = this.Instance.EntityIdsLength;
				this._EntityIdsCache = new List<int>(entityIdsLength);
				for (int i = 0; i < entityIdsLength; i++)
				{
					this._EntityIdsCache.Add(this.Instance.EntityIds(i));
				}
				return this._EntityIdsCache;
			}
		}

		// Token: 0x040045B2 RID: 17842
		private ICheckMonsterBattleAttribute Instance;

		// Token: 0x040045B3 RID: 17843
		[Nullable(2)]
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x040045B4 RID: 17844
		private bool _OptionInited;

		// Token: 0x040045B5 RID: 17845
		private List<int> _EntityIdsCache;

		// Token: 0x040045B6 RID: 17846
		private bool _EntityIdsInited;
	}
}
