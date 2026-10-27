using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F09 RID: 7945
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchSubLevelsDirectly : SwitchSubLevels
	{
		// Token: 0x0600A9E6 RID: 43494 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
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

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x0017ECF8 File Offset: 0x0017CEF8
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

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x0017ED0B File Offset: 0x0017CF0B
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

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x0017ED20 File Offset: 0x0017CF20
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

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600A9EA RID: 43498 RVA: 0x0017ED6E File Offset: 0x0017CF6E
		// (set) Token: 0x0600A9EB RID: 43499 RVA: 0x0017ED99 File Offset: 0x0017CF99
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

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600A9EC RID: 43500 RVA: 0x0017EDA7 File Offset: 0x0017CFA7
		// (set) Token: 0x0600A9ED RID: 43501 RVA: 0x0017EDCE File Offset: 0x0017CFCE
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

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600A9EE RID: 43502 RVA: 0x0017EDDC File Offset: 0x0017CFDC
		// (set) Token: 0x0600A9EF RID: 43503 RVA: 0x0017EE03 File Offset: 0x0017D003
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

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600A9F0 RID: 43504 RVA: 0x0017EE14 File Offset: 0x0017D014
		// (set) Token: 0x0600A9F1 RID: 43505 RVA: 0x0017EE4E File Offset: 0x0017D04E
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

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600A9F2 RID: 43506 RVA: 0x0017EE5C File Offset: 0x0017D05C
		// (set) Token: 0x0600A9F3 RID: 43507 RVA: 0x0017EE96 File Offset: 0x0017D096
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

		// Token: 0x040064FE RID: 25854
		[Nullable(2)]
		protected new ISwitchSubLevelsDirectly FbInstance;

		// Token: 0x040064FF RID: 25855
		[Nullable(2)]
		protected new ISwitchSubLevelsDirectly_SetValue PocoInterface;
	}
}
