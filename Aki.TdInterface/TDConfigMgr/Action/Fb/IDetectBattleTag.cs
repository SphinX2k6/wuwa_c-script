using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CF RID: 10703
	public class IDetectBattleTag : IDetectBattleStateType
	{
		// Token: 0x0600ECE6 RID: 60646 RVA: 0x0022D813 File Offset: 0x0022BA13
		public static IDetectBattleTag Create(IDetectBattleTag? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleTag
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045F6 RID: 17910
		// (get) Token: 0x0600ECE7 RID: 60647 RVA: 0x0022D832 File Offset: 0x0022BA32
		public override EDetectBattleConditionType Type
		{
			get
			{
				return (EDetectBattleConditionType)this.Instance.Type;
			}
		}

		// Token: 0x170045F7 RID: 17911
		// (get) Token: 0x0600ECE8 RID: 60648 RVA: 0x0022D83F File Offset: 0x0022BA3F
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170045F8 RID: 17912
		// (get) Token: 0x0600ECE9 RID: 60649 RVA: 0x0022D84C File Offset: 0x0022BA4C
		public virtual IDetectBattleMonsterOnGround TagOption
		{
			get
			{
				if (this._TagOptionInited)
				{
					return this._TagOptionCache;
				}
				this._TagOptionInited = true;
				this._TagOptionCache = IDetectBattleMonsterOnGround.Create(this.Instance.TagOption);
				return this._TagOptionCache;
			}
		}

		// Token: 0x170045F9 RID: 17913
		// (get) Token: 0x0600ECEA RID: 60650 RVA: 0x0022D880 File Offset: 0x0022BA80
		public virtual float MaxWaitTime
		{
			get
			{
				return this.Instance.MaxWaitTime;
			}
		}

		// Token: 0x04008263 RID: 33379
		private IDetectBattleTag Instance;

		// Token: 0x04008264 RID: 33380
		[Nullable(2)]
		private IDetectBattleMonsterOnGround _TagOptionCache;

		// Token: 0x04008265 RID: 33381
		private bool _TagOptionInited;
	}
}
