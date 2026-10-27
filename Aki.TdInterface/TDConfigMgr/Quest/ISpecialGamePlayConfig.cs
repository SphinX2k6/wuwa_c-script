using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001144 RID: 4420
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpecialGamePlayConfig
	{
		// Token: 0x0600645A RID: 25690 RVA: 0x000F14E8 File Offset: 0x000EF6E8
		private ISpecialGamePlayConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialGamePlayConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialGamePlayConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialGamePlayConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x000F1520 File Offset: 0x000EF720
		public static ISpecialGamePlayConfig Create([Nullable(2)] ISpecialGamePlayConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialGamePlayConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x000F1533 File Offset: 0x000EF733
		public static ISpecialGamePlayConfig CreateFromSetValue([Nullable(2)] ISpecialGamePlayConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialGamePlayConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x000F1546 File Offset: 0x000EF746
		public ISpecialGamePlayConfig_SetValue ToSetValue()
		{
			return new ISpecialGamePlayConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x0600645E RID: 25694 RVA: 0x000F1559 File Offset: 0x000EF759
		// (set) Token: 0x0600645F RID: 25695 RVA: 0x000F1584 File Offset: 0x000EF784
		public virtual ESpecialGamePlayConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialGamePlayConfigType.Stalking;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003C4D RID: 15437
		[Nullable(2)]
		protected ISpecialGamePlayConfig FbInstance;

		// Token: 0x04003C4E RID: 15438
		[Nullable(2)]
		protected ISpecialGamePlayConfig_SetValue PocoInterface;
	}
}
