using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001004 RID: 4100
	public class ICheckMonsterBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x060059D2 RID: 22994 RVA: 0x000DB384 File Offset: 0x000D9584
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

		// Token: 0x060059D3 RID: 22995 RVA: 0x000DB3BC File Offset: 0x000D95BC
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

		// Token: 0x060059D4 RID: 22996 RVA: 0x000DB3CF File Offset: 0x000D95CF
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

		// Token: 0x060059D5 RID: 22997 RVA: 0x000DB3E2 File Offset: 0x000D95E2
		public new ICheckMonsterBattleAttribute_SetValue ToSetValue()
		{
			return new ICheckMonsterBattleAttribute_SetValue
			{
				Type = this.Type,
				Option = this.Option,
				EntityIds = this.EntityIds
			};
		}

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x000DB40D File Offset: 0x000D960D
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x000DB438 File Offset: 0x000D9638
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

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x000DB448 File Offset: 0x000D9648
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x000DB4A9 File Offset: 0x000D96A9
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

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x000DB4BE File Offset: 0x000D96BE
		// (set) Token: 0x060059DB RID: 23003 RVA: 0x000DB4E5 File Offset: 0x000D96E5
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

		// Token: 0x04003625 RID: 13861
		[Nullable(2)]
		protected new ICheckMonsterBattleAttribute FbInstance;

		// Token: 0x04003626 RID: 13862
		[Nullable(2)]
		protected new ICheckMonsterBattleAttribute_SetValue PocoInterface;

		// Token: 0x04003627 RID: 13863
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x04003628 RID: 13864
		private bool _OptionInited;
	}
}
