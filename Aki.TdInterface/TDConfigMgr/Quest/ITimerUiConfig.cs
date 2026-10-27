using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011A6 RID: 4518
	[NullableContext(2)]
	[Nullable(0)]
	public class ITimerUiConfig
	{
		// Token: 0x06006694 RID: 26260 RVA: 0x000F5CAC File Offset: 0x000F3EAC
		[NullableContext(1)]
		private ITimerUiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITimerUiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITimerUiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITimerUiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x000F5CE4 File Offset: 0x000F3EE4
		[NullableContext(1)]
		public static ITimerUiConfig Create([Nullable(2)] ITimerUiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimerUiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x000F5CF7 File Offset: 0x000F3EF7
		[NullableContext(1)]
		public static ITimerUiConfig CreateFromSetValue([Nullable(2)] ITimerUiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITimerUiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x000F5D0A File Offset: 0x000F3F0A
		[NullableContext(1)]
		public ITimerUiConfig_SetValue ToSetValue()
		{
			return new ITimerUiConfig_SetValue
			{
				UiType = this.UiType,
				TidTitle = this.TidTitle,
				EdTidTitle = this.EdTidTitle
			};
		}

		// Token: 0x17002156 RID: 8534
		// (get) Token: 0x06006698 RID: 26264 RVA: 0x000F5D35 File Offset: 0x000F3F35
		// (set) Token: 0x06006699 RID: 26265 RVA: 0x000F5D60 File Offset: 0x000F3F60
		public virtual ETimerUiType UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				if (this.PocoInterface == null)
				{
					return ETimerUiType.Default;
				}
				return this.PocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x17002157 RID: 8535
		// (get) Token: 0x0600669A RID: 26266 RVA: 0x000F5D6E File Offset: 0x000F3F6E
		// (set) Token: 0x0600669B RID: 26267 RVA: 0x000F5D95 File Offset: 0x000F3F95
		public virtual string TidTitle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTitle;
				}
				ITimerUiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTitle;
			}
			set
			{
				this.GetOrCreatePoco().TidTitle = value;
			}
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x0600669C RID: 26268 RVA: 0x000F5DA3 File Offset: 0x000F3FA3
		// (set) Token: 0x0600669D RID: 26269 RVA: 0x000F5DBA File Offset: 0x000F3FBA
		public virtual string EdTidTitle
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTitle;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTitle = value;
			}
		}

		// Token: 0x04003D8D RID: 15757
		protected ITimerUiConfig FbInstance;

		// Token: 0x04003D8E RID: 15758
		protected ITimerUiConfig_SetValue PocoInterface;
	}
}
