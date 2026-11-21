using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A59 RID: 6745
	public class IClientSetSeasonStateConfig
	{
		// Token: 0x06008F5B RID: 36699 RVA: 0x00151D28 File Offset: 0x0014FF28
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

		// Token: 0x06008F5C RID: 36700 RVA: 0x00151D60 File Offset: 0x0014FF60
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

		// Token: 0x06008F5D RID: 36701 RVA: 0x00151D73 File Offset: 0x0014FF73
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

		// Token: 0x06008F5E RID: 36702 RVA: 0x00151D86 File Offset: 0x0014FF86
		public IClientSetSeasonStateConfig_SetValue ToSetValue()
		{
			return new IClientSetSeasonStateConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x06008F5F RID: 36703 RVA: 0x00151D99 File Offset: 0x0014FF99
		// (set) Token: 0x06008F60 RID: 36704 RVA: 0x00151DC4 File Offset: 0x0014FFC4
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

		// Token: 0x040059DD RID: 23005
		[Nullable(2)]
		protected IClientSetSeasonStateConfig FbInstance;

		// Token: 0x040059DE RID: 23006
		[Nullable(2)]
		protected IClientSetSeasonStateConfig_SetValue PocoInterface;
	}
}
