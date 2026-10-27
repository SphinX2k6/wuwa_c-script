using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200118C RID: 4492
	[NullableContext(1)]
	[Nullable(0)]
	public class ITargetBattleAttribute
	{
		// Token: 0x0600660A RID: 26122 RVA: 0x000F4B30 File Offset: 0x000F2D30
		private ITargetBattleAttribute_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITargetBattleAttribute 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITargetBattleAttribute_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITargetBattleAttribute_SetValue());
			}
			return result;
		}

		// Token: 0x0600660B RID: 26123 RVA: 0x000F4B68 File Offset: 0x000F2D68
		public static ITargetBattleAttribute Create([Nullable(2)] ITargetBattleAttribute instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITargetBattleAttribute
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x000F4B7B File Offset: 0x000F2D7B
		public static ITargetBattleAttribute CreateFromSetValue([Nullable(2)] ITargetBattleAttribute_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITargetBattleAttribute
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600660D RID: 26125 RVA: 0x000F4B8E File Offset: 0x000F2D8E
		public ITargetBattleAttribute_SetValue ToSetValue()
		{
			return new ITargetBattleAttribute_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002138 RID: 8504
		// (get) Token: 0x0600660E RID: 26126 RVA: 0x000F4BA1 File Offset: 0x000F2DA1
		// (set) Token: 0x0600660F RID: 26127 RVA: 0x000F4BCC File Offset: 0x000F2DCC
		public virtual ETargetBattleAttribute Type
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

		// Token: 0x04003D3F RID: 15679
		[Nullable(2)]
		protected ITargetBattleAttribute FbInstance;

		// Token: 0x04003D40 RID: 15680
		[Nullable(2)]
		protected ITargetBattleAttribute_SetValue PocoInterface;
	}
}
