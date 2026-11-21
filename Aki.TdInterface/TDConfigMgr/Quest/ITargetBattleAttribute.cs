using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012C6 RID: 4806
	public class ITargetBattleAttribute
	{
		// Token: 0x06006C41 RID: 27713 RVA: 0x001022FC File Offset: 0x001004FC
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

		// Token: 0x06006C42 RID: 27714 RVA: 0x00102334 File Offset: 0x00100534
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

		// Token: 0x06006C43 RID: 27715 RVA: 0x00102347 File Offset: 0x00100547
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

		// Token: 0x06006C44 RID: 27716 RVA: 0x0010235A File Offset: 0x0010055A
		public ITargetBattleAttribute_SetValue ToSetValue()
		{
			return new ITargetBattleAttribute_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06006C45 RID: 27717 RVA: 0x0010236D File Offset: 0x0010056D
		// (set) Token: 0x06006C46 RID: 27718 RVA: 0x00102398 File Offset: 0x00100598
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

		// Token: 0x040040A7 RID: 16551
		[Nullable(2)]
		protected ITargetBattleAttribute FbInstance;

		// Token: 0x040040A8 RID: 16552
		[Nullable(2)]
		protected ITargetBattleAttribute_SetValue PocoInterface;
	}
}
