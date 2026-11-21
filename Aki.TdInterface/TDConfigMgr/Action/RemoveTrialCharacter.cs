using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B5 RID: 9141
	public class RemoveTrialCharacter : ActionParams
	{
		// Token: 0x0600C750 RID: 51024 RVA: 0x001C86A8 File Offset: 0x001C68A8
		private RemoveTrialCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RemoveTrialCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RemoveTrialCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RemoveTrialCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x0600C751 RID: 51025 RVA: 0x001C86E0 File Offset: 0x001C68E0
		public static RemoveTrialCharacter Create([Nullable(2)] RemoveTrialCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RemoveTrialCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C752 RID: 51026 RVA: 0x001C86F3 File Offset: 0x001C68F3
		public static RemoveTrialCharacter CreateFromSetValue([Nullable(2)] RemoveTrialCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RemoveTrialCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C753 RID: 51027 RVA: 0x001C8708 File Offset: 0x001C6908
		public RemoveTrialCharacter_SetValue ToSetValue()
		{
			return new RemoveTrialCharacter_SetValue
			{
				CharacterId = this.CharacterId,
				CharacterGroup = this.CharacterGroup,
				IsRemoveTips = this.IsRemoveTips,
				EnableSeamlessTeamSwitch = this.EnableSeamlessTeamSwitch,
				OnlyLowMemoryDeviceExecute = this.OnlyLowMemoryDeviceExecute
			};
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600C754 RID: 51028 RVA: 0x001C8756 File Offset: 0x001C6956
		// (set) Token: 0x0600C755 RID: 51029 RVA: 0x001C8781 File Offset: 0x001C6981
		public virtual int CharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CharacterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CharacterId;
			}
			set
			{
				this.GetOrCreatePoco().CharacterId = value;
			}
		}

		// Token: 0x17003C2E RID: 15406
		// (get) Token: 0x0600C756 RID: 51030 RVA: 0x001C878F File Offset: 0x001C698F
		// (set) Token: 0x0600C757 RID: 51031 RVA: 0x001C87B6 File Offset: 0x001C69B6
		public virtual List<int> CharacterGroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CharacterGroup;
				}
				RemoveTrialCharacter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CharacterGroup;
			}
			set
			{
				this.GetOrCreatePoco().CharacterGroup = value;
			}
		}

		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600C758 RID: 51032 RVA: 0x001C87C4 File Offset: 0x001C69C4
		// (set) Token: 0x0600C759 RID: 51033 RVA: 0x001C87FE File Offset: 0x001C69FE
		public virtual bool? IsRemoveTips
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsRemoveTips;
				}
				RemoveTrialCharacter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsRemoveTips;
			}
			set
			{
				this.GetOrCreatePoco().IsRemoveTips = value;
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600C75A RID: 51034 RVA: 0x001C880C File Offset: 0x001C6A0C
		// (set) Token: 0x0600C75B RID: 51035 RVA: 0x001C8846 File Offset: 0x001C6A46
		public virtual bool? EnableSeamlessTeamSwitch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EnableSeamlessTeamSwitch;
				}
				RemoveTrialCharacter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EnableSeamlessTeamSwitch;
			}
			set
			{
				this.GetOrCreatePoco().EnableSeamlessTeamSwitch = value;
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600C75C RID: 51036 RVA: 0x001C8854 File Offset: 0x001C6A54
		// (set) Token: 0x0600C75D RID: 51037 RVA: 0x001C888E File Offset: 0x001C6A8E
		public virtual bool? OnlyLowMemoryDeviceExecute
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyLowMemoryDeviceExecute;
				}
				RemoveTrialCharacter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyLowMemoryDeviceExecute;
			}
			set
			{
				this.GetOrCreatePoco().OnlyLowMemoryDeviceExecute = value;
			}
		}

		// Token: 0x0400766F RID: 30319
		[Nullable(2)]
		protected new RemoveTrialCharacter FbInstance;

		// Token: 0x04007670 RID: 30320
		[Nullable(2)]
		protected RemoveTrialCharacter_SetValue PocoInterface;
	}
}
