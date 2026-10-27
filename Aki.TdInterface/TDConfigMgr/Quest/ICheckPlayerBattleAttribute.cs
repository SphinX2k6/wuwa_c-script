using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EF0 RID: 3824
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckPlayerBattleAttribute : ITargetBattleAttribute
	{
		// Token: 0x06005462 RID: 21602 RVA: 0x000CF35C File Offset: 0x000CD55C
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

		// Token: 0x06005463 RID: 21603 RVA: 0x000CF394 File Offset: 0x000CD594
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

		// Token: 0x06005464 RID: 21604 RVA: 0x000CF3A7 File Offset: 0x000CD5A7
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

		// Token: 0x06005465 RID: 21605 RVA: 0x000CF3BA File Offset: 0x000CD5BA
		public new ICheckPlayerBattleAttribute_SetValue ToSetValue()
		{
			return new ICheckPlayerBattleAttribute_SetValue
			{
				Type = this.Type,
				Option = this.Option
			};
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06005466 RID: 21606 RVA: 0x000CF3D9 File Offset: 0x000CD5D9
		// (set) Token: 0x06005467 RID: 21607 RVA: 0x000CF404 File Offset: 0x000CD604
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

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06005468 RID: 21608 RVA: 0x000CF414 File Offset: 0x000CD614
		// (set) Token: 0x06005469 RID: 21609 RVA: 0x000CF475 File Offset: 0x000CD675
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

		// Token: 0x0400331F RID: 13087
		[Nullable(2)]
		protected new ICheckPlayerBattleAttribute FbInstance;

		// Token: 0x04003320 RID: 13088
		[Nullable(2)]
		protected new ICheckPlayerBattleAttribute_SetValue PocoInterface;

		// Token: 0x04003321 RID: 13089
		private IHealthAttributeToTarget _OptionCache;

		// Token: 0x04003322 RID: 13090
		private bool _OptionInited;
	}
}
