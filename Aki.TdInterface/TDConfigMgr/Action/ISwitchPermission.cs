using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200213C RID: 8508
	public class ISwitchPermission : SwitchSubLevels
	{
		// Token: 0x0600B496 RID: 46230 RVA: 0x00194930 File Offset: 0x00192B30
		private ISwitchPermission_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchPermission 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchPermission_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchPermission_SetValue());
			}
			return result;
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x00194968 File Offset: 0x00192B68
		public static ISwitchPermission Create([Nullable(2)] ISwitchPermission instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchPermission
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x0019497B File Offset: 0x00192B7B
		public static ISwitchPermission CreateFromSetValue([Nullable(2)] ISwitchPermission_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchPermission
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x0019498E File Offset: 0x00192B8E
		public new ISwitchPermission_SetValue ToSetValue()
		{
			return new ISwitchPermission_SetValue
			{
				Type = this.Type,
				IsAllowClientSwitch = this.IsAllowClientSwitch,
				Levels = this.Levels
			};
		}

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600B49A RID: 46234 RVA: 0x001949B9 File Offset: 0x00192BB9
		// (set) Token: 0x0600B49B RID: 46235 RVA: 0x001949E4 File Offset: 0x00192BE4
		public override ESwitchSubLevelsType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600B49C RID: 46236 RVA: 0x001949F2 File Offset: 0x00192BF2
		// (set) Token: 0x0600B49D RID: 46237 RVA: 0x00194A1D File Offset: 0x00192C1D
		public virtual bool IsAllowClientSwitch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAllowClientSwitch;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAllowClientSwitch;
			}
			set
			{
				this.GetOrCreatePoco().IsAllowClientSwitch = value;
			}
		}

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600B49E RID: 46238 RVA: 0x00194A2B File Offset: 0x00192C2B
		// (set) Token: 0x0600B49F RID: 46239 RVA: 0x00194A52 File Offset: 0x00192C52
		public virtual List<string> Levels
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Levels;
				}
				ISwitchPermission_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Levels;
			}
			set
			{
				this.GetOrCreatePoco().Levels = value;
			}
		}

		// Token: 0x04006ADF RID: 27359
		[Nullable(2)]
		protected new ISwitchPermission FbInstance;

		// Token: 0x04006AE0 RID: 27360
		[Nullable(2)]
		protected new ISwitchPermission_SetValue PocoInterface;
	}
}
