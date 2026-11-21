using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001006 RID: 4102
	public class ICheckPlayerBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x060059DE RID: 23006 RVA: 0x000DB504 File Offset: 0x000D9704
		private ICheckPlayerBattleAttribute_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckPlayerBattleAttribute 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckPlayerBattleAttribute_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckPlayerBattleAttribute_SetValue());
			}
			return result;
		}

		// Token: 0x060059DF RID: 23007 RVA: 0x000DB53C File Offset: 0x000D973C
		public static ICheckPlayerBattleAttribute Create([Nullable(2)] ICheckPlayerBattleAttribute instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerBattleAttribute
			{
				FbInstance = instance
			};
		}

		// Token: 0x060059E0 RID: 23008 RVA: 0x000DB54F File Offset: 0x000D974F
		public static ICheckPlayerBattleAttribute CreateFromSetValue([Nullable(2)] ICheckPlayerBattleAttribute_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckPlayerBattleAttribute
			{
				PocoInterface = value
			};
		}

		// Token: 0x060059E1 RID: 23009 RVA: 0x000DB562 File Offset: 0x000D9762
		public new ICheckPlayerBattleAttribute_SetValue ToSetValue()
		{
			return new ICheckPlayerBattleAttribute_SetValue
			{
				Type = this.Type,
				Option = this.Option
			};
		}

		// Token: 0x17001DE2 RID: 7650
		// (get) Token: 0x060059E2 RID: 23010 RVA: 0x000DB581 File Offset: 0x000D9781
		// (set) Token: 0x060059E3 RID: 23011 RVA: 0x000DB5AC File Offset: 0x000D97AC
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

		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x060059E4 RID: 23012 RVA: 0x000DB5BC File Offset: 0x000D97BC
		// (set) Token: 0x060059E5 RID: 23013 RVA: 0x000DB61D File Offset: 0x000D981D
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
					ICheckPlayerBattleAttribute_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x0400362C RID: 13868
		[Nullable(2)]
		protected new ICheckPlayerBattleAttribute FbInstance;

		// Token: 0x0400362D RID: 13869
		[Nullable(2)]
		protected new ICheckPlayerBattleAttribute_SetValue PocoInterface;

		// Token: 0x0400362E RID: 13870
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x0400362F RID: 13871
		private bool _OptionInited;
	}
}
