using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002154 RID: 8532
	[NullableContext(1)]
	[Nullable(0)]
	public class RemoveTrialCharacter : ActionParams
	{
		// Token: 0x0600BBC2 RID: 48066 RVA: 0x001B14F4 File Offset: 0x001AF6F4
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

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x001B152C File Offset: 0x001AF72C
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

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x001B153F File Offset: 0x001AF73F
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

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x001B1554 File Offset: 0x001AF754
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

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600BBC6 RID: 48070 RVA: 0x001B15A2 File Offset: 0x001AF7A2
		// (set) Token: 0x0600BBC7 RID: 48071 RVA: 0x001B15CD File Offset: 0x001AF7CD
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

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600BBC8 RID: 48072 RVA: 0x001B15DB File Offset: 0x001AF7DB
		// (set) Token: 0x0600BBC9 RID: 48073 RVA: 0x001B1602 File Offset: 0x001AF802
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

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x001B1610 File Offset: 0x001AF810
		// (set) Token: 0x0600BBCB RID: 48075 RVA: 0x001B164A File Offset: 0x001AF84A
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

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600BBCC RID: 48076 RVA: 0x001B1658 File Offset: 0x001AF858
		// (set) Token: 0x0600BBCD RID: 48077 RVA: 0x001B1692 File Offset: 0x001AF892
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

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x001B16A0 File Offset: 0x001AF8A0
		// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x001B16DA File Offset: 0x001AF8DA
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

		// Token: 0x0400703A RID: 28730
		[Nullable(2)]
		protected new RemoveTrialCharacter FbInstance;

		// Token: 0x0400703B RID: 28731
		[Nullable(2)]
		protected RemoveTrialCharacter_SetValue PocoInterface;
	}
}
