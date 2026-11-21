using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002142 RID: 8514
	public class ISwitchSubLevelsDirectly : SwitchSubLevels
	{
		// Token: 0x0600B4B8 RID: 46264 RVA: 0x00194CB8 File Offset: 0x00192EB8
		private ISwitchSubLevelsDirectly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchSubLevelsDirectly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchSubLevelsDirectly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchSubLevelsDirectly_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x00194CF0 File Offset: 0x00192EF0
		public static ISwitchSubLevelsDirectly Create([Nullable(2)] ISwitchSubLevelsDirectly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchSubLevelsDirectly
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x00194D03 File Offset: 0x00192F03
		public static ISwitchSubLevelsDirectly CreateFromSetValue([Nullable(2)] ISwitchSubLevelsDirectly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchSubLevelsDirectly
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x00194D18 File Offset: 0x00192F18
		public new ISwitchSubLevelsDirectly_SetValue ToSetValue()
		{
			return new ISwitchSubLevelsDirectly_SetValue
			{
				Type = this.Type,
				LoadLevels = this.LoadLevels,
				UnloadLevels = this.UnloadLevels,
				TeleportEntityId = this.TeleportEntityId,
				IsWaitForSwitchComplete = this.IsWaitForSwitchComplete
			};
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600B4BC RID: 46268 RVA: 0x00194D66 File Offset: 0x00192F66
		// (set) Token: 0x0600B4BD RID: 46269 RVA: 0x00194D91 File Offset: 0x00192F91
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

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600B4BE RID: 46270 RVA: 0x00194D9F File Offset: 0x00192F9F
		// (set) Token: 0x0600B4BF RID: 46271 RVA: 0x00194DC6 File Offset: 0x00192FC6
		public virtual List<string> LoadLevels
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoadLevels;
				}
				ISwitchSubLevelsDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoadLevels;
			}
			set
			{
				this.GetOrCreatePoco().LoadLevels = value;
			}
		}

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600B4C0 RID: 46272 RVA: 0x00194DD4 File Offset: 0x00192FD4
		// (set) Token: 0x0600B4C1 RID: 46273 RVA: 0x00194DFB File Offset: 0x00192FFB
		public virtual List<string> UnloadLevels
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UnloadLevels;
				}
				ISwitchSubLevelsDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UnloadLevels;
			}
			set
			{
				this.GetOrCreatePoco().UnloadLevels = value;
			}
		}

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600B4C2 RID: 46274 RVA: 0x00194E0C File Offset: 0x0019300C
		// (set) Token: 0x0600B4C3 RID: 46275 RVA: 0x00194E46 File Offset: 0x00193046
		public virtual int? TeleportEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleportEntityId;
				}
				ISwitchSubLevelsDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TeleportEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TeleportEntityId = value;
			}
		}

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600B4C4 RID: 46276 RVA: 0x00194E54 File Offset: 0x00193054
		// (set) Token: 0x0600B4C5 RID: 46277 RVA: 0x00194E8E File Offset: 0x0019308E
		public virtual bool? IsWaitForSwitchComplete
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsWaitForSwitchComplete;
				}
				ISwitchSubLevelsDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsWaitForSwitchComplete;
			}
			set
			{
				this.GetOrCreatePoco().IsWaitForSwitchComplete = value;
			}
		}

		// Token: 0x04006AED RID: 27373
		[Nullable(2)]
		protected new ISwitchSubLevelsDirectly FbInstance;

		// Token: 0x04006AEE RID: 27374
		[Nullable(2)]
		protected new ISwitchSubLevelsDirectly_SetValue PocoInterface;
	}
}
