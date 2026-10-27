using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EEE RID: 3822
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckMonsterBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x06005456 RID: 21590 RVA: 0x000CF1DC File Offset: 0x000CD3DC
		private ICheckMonsterBattleAttribute_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckMonsterBattleAttribute 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckMonsterBattleAttribute_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckMonsterBattleAttribute_SetValue());
			}
			return result;
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x000CF214 File Offset: 0x000CD414
		public static ICheckMonsterBattleAttribute Create([Nullable(2)] ICheckMonsterBattleAttribute instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckMonsterBattleAttribute
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x000CF227 File Offset: 0x000CD427
		public static ICheckMonsterBattleAttribute CreateFromSetValue([Nullable(2)] ICheckMonsterBattleAttribute_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckMonsterBattleAttribute
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x000CF23A File Offset: 0x000CD43A
		public new ICheckMonsterBattleAttribute_SetValue ToSetValue()
		{
			return new ICheckMonsterBattleAttribute_SetValue
			{
				Type = this.Type,
				Option = this.Option,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600545A RID: 21594 RVA: 0x000CF265 File Offset: 0x000CD465
		// (set) Token: 0x0600545B RID: 21595 RVA: 0x000CF290 File Offset: 0x000CD490
		public override ETargetBattleAttribute Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetBattleAttribute.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x0600545C RID: 21596 RVA: 0x000CF2A0 File Offset: 0x000CD4A0
		// (set) Token: 0x0600545D RID: 21597 RVA: 0x000CF301 File Offset: 0x000CD501
		public virtual IHealthAttributeToTarget Option
		{
			get
			{
				if (this._OptionInited)
				{
					return this._OptionCache;
				}
				this._OptionInited = true;
				if (this.FbInstance != null)
				{
					this._OptionCache = IHealthAttributeToTarget.Create(this.FbInstance.Option);
				}
				else
				{
					ICheckMonsterBattleAttribute_SetValue pocoInterface = this.PocoInterface;
					this._OptionCache = ((pocoInterface != null) ? pocoInterface.Option : null);
				}
				return this._OptionCache;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
				this._OptionInited = false;
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x0600545E RID: 21598 RVA: 0x000CF316 File Offset: 0x000CD516
		// (set) Token: 0x0600545F RID: 21599 RVA: 0x000CF33D File Offset: 0x000CD53D
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				ICheckMonsterBattleAttribute_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x04003318 RID: 13080
		[Nullable(2)]
		protected new ICheckMonsterBattleAttribute FbInstance;

		// Token: 0x04003319 RID: 13081
		[Nullable(2)]
		protected new ICheckMonsterBattleAttribute_SetValue PocoInterface;

		// Token: 0x0400331A RID: 13082
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x0400331B RID: 13083
		private bool _OptionInited;
	}
}
