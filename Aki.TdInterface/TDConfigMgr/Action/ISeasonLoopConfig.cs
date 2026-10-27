using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DEE RID: 7662
	[NullableContext(1)]
	[Nullable(0)]
	public class ISeasonLoopConfig
	{
		// Token: 0x0600A3FD RID: 41981 RVA: 0x0017418C File Offset: 0x0017238C
		private ISeasonLoopConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISeasonLoopConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISeasonLoopConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISeasonLoopConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x001741C4 File Offset: 0x001723C4
		public static ISeasonLoopConfig Create([Nullable(2)] ISeasonLoopConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISeasonLoopConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x001741D7 File Offset: 0x001723D7
		public static ISeasonLoopConfig CreateFromSetValue([Nullable(2)] ISeasonLoopConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISeasonLoopConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x001741EA File Offset: 0x001723EA
		public ISeasonLoopConfig_SetValue ToSetValue()
		{
			return new ISeasonLoopConfig_SetValue
			{
				HoldTime = this.HoldTime,
				SwitchTime = this.SwitchTime
			};
		}

		// Token: 0x17003270 RID: 12912
		// (get) Token: 0x0600A401 RID: 41985 RVA: 0x00174209 File Offset: 0x00172409
		// (set) Token: 0x0600A402 RID: 41986 RVA: 0x00174238 File Offset: 0x00172438
		public virtual float HoldTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HoldTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.HoldTime;
			}
			set
			{
				this.GetOrCreatePoco().HoldTime = value;
			}
		}

		// Token: 0x17003271 RID: 12913
		// (get) Token: 0x0600A403 RID: 41987 RVA: 0x00174246 File Offset: 0x00172446
		// (set) Token: 0x0600A404 RID: 41988 RVA: 0x00174275 File Offset: 0x00172475
		public virtual float SwitchTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwitchTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.SwitchTime;
			}
			set
			{
				this.GetOrCreatePoco().SwitchTime = value;
			}
		}

		// Token: 0x0400623F RID: 25151
		[Nullable(2)]
		protected ISeasonLoopConfig FbInstance;

		// Token: 0x04006240 RID: 25152
		[Nullable(2)]
		protected ISeasonLoopConfig_SetValue PocoInterface;
	}
}
