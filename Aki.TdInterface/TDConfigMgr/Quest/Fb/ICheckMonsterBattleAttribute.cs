using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001391 RID: 5009
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckMonsterBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x0600728C RID: 29324 RVA: 0x00113626 File Offset: 0x00111826
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

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x00113645 File Offset: 0x00111845
		public override ETargetBattleAttribute Type
		{
			get
			{
				return (ETargetBattleAttribute)this.Instance.Type;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x00113652 File Offset: 0x00111852
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

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x0600728F RID: 29327 RVA: 0x00113688 File Offset: 0x00111888
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

		// Token: 0x04004231 RID: 16945
		private ICheckMonsterBattleAttribute Instance;

		// Token: 0x04004232 RID: 16946
		[Nullable(2)]
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x04004233 RID: 16947
		private bool _OptionInited;

		// Token: 0x04004234 RID: 16948
		private List<int> _EntityIdsCache;

		// Token: 0x04004235 RID: 16949
		private bool _EntityIdsInited;
	}
}
