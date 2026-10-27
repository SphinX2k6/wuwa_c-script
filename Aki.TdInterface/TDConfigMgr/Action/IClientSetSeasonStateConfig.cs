using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018C8 RID: 6344
	[NullableContext(1)]
	[Nullable(0)]
	public class IClientSetSeasonStateConfig
	{
		// Token: 0x06008813 RID: 34835 RVA: 0x001421B0 File Offset: 0x001403B0
		private IClientSetSeasonStateConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientSetSeasonStateConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientSetSeasonStateConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientSetSeasonStateConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008814 RID: 34836 RVA: 0x001421E8 File Offset: 0x001403E8
		public static IClientSetSeasonStateConfig Create([Nullable(2)] IClientSetSeasonStateConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientSetSeasonStateConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008815 RID: 34837 RVA: 0x001421FB File Offset: 0x001403FB
		public static IClientSetSeasonStateConfig CreateFromSetValue([Nullable(2)] IClientSetSeasonStateConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientSetSeasonStateConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008816 RID: 34838 RVA: 0x0014220E File Offset: 0x0014040E
		public IClientSetSeasonStateConfig_SetValue ToSetValue()
		{
			return new IClientSetSeasonStateConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x06008817 RID: 34839 RVA: 0x00142221 File Offset: 0x00140421
		// (set) Token: 0x06008818 RID: 34840 RVA: 0x0014224C File Offset: 0x0014044C
		public virtual EClientSetSeasonStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EClientSetSeasonStateType.SwitchSeason;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005583 RID: 21891
		[Nullable(2)]
		protected IClientSetSeasonStateConfig FbInstance;

		// Token: 0x04005584 RID: 21892
		[Nullable(2)]
		protected IClientSetSeasonStateConfig_SetValue PocoInterface;
	}
}
