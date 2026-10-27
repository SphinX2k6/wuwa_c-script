using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002708 RID: 9992
	[NullableContext(1)]
	[Nullable(0)]
	public class IDetectBattleTag : IDetectBattleStateType
	{
		// Token: 0x0600DEFA RID: 57082 RVA: 0x00210E6A File Offset: 0x0020F06A
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

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x0600DEFB RID: 57083 RVA: 0x00210E89 File Offset: 0x0020F089
		public override EDetectBattleConditionType Type
		{
			get
			{
				return (EDetectBattleConditionType)this.Instance.Type;
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x0600DEFC RID: 57084 RVA: 0x00210E96 File Offset: 0x0020F096
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0600DEFD RID: 57085 RVA: 0x00210EA3 File Offset: 0x0020F0A3
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

		// Token: 0x170042AF RID: 17071
		// (get) Token: 0x0600DEFE RID: 57086 RVA: 0x00210ED7 File Offset: 0x0020F0D7
		public virtual float MaxWaitTime
		{
			get
			{
				return this.Instance.MaxWaitTime;
			}
		}

		// Token: 0x04007BBE RID: 31678
		private IDetectBattleTag Instance;

		// Token: 0x04007BBF RID: 31679
		[Nullable(2)]
		private IDetectBattleMonsterOnGround _TagOptionCache;

		// Token: 0x04007BC0 RID: 31680
		private bool _TagOptionInited;
	}
}
