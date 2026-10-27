using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010F6 RID: 4342
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueAbilitySelect : IShowUi
	{
		// Token: 0x0600623A RID: 25146 RVA: 0x000ECBC8 File Offset: 0x000EADC8
		private IRogueAbilitySelect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueAbilitySelect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueAbilitySelect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueAbilitySelect_SetValue());
			}
			return result;
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x000ECC00 File Offset: 0x000EAE00
		public static IRogueAbilitySelect Create([Nullable(2)] IRogueAbilitySelect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueAbilitySelect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x000ECC13 File Offset: 0x000EAE13
		public static IRogueAbilitySelect CreateFromSetValue([Nullable(2)] IRogueAbilitySelect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueAbilitySelect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x000ECC26 File Offset: 0x000EAE26
		public new IRogueAbilitySelect_SetValue ToSetValue()
		{
			return new IRogueAbilitySelect_SetValue
			{
				Type = this.Type,
				AbilityType = this.AbilityType,
				BindId = this.BindId
			};
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600623E RID: 25150 RVA: 0x000ECC51 File Offset: 0x000EAE51
		// (set) Token: 0x0600623F RID: 25151 RVA: 0x000ECC7C File Offset: 0x000EAE7C
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06006240 RID: 25152 RVA: 0x000ECC8A File Offset: 0x000EAE8A
		// (set) Token: 0x06006241 RID: 25153 RVA: 0x000ECCB5 File Offset: 0x000EAEB5
		public virtual ERogueAbilityType AbilityType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AbilityType;
				}
				if (this.PocoInterface == null)
				{
					return (ERogueAbilityType)0;
				}
				return this.PocoInterface.AbilityType;
			}
			set
			{
				this.GetOrCreatePoco().AbilityType = value;
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06006242 RID: 25154 RVA: 0x000ECCC3 File Offset: 0x000EAEC3
		// (set) Token: 0x06006243 RID: 25155 RVA: 0x000ECCEE File Offset: 0x000EAEEE
		public virtual int BindId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BindId;
			}
			set
			{
				this.GetOrCreatePoco().BindId = value;
			}
		}

		// Token: 0x04003B07 RID: 15111
		[Nullable(2)]
		protected new IRogueAbilitySelect FbInstance;

		// Token: 0x04003B08 RID: 15112
		[Nullable(2)]
		protected new IRogueAbilitySelect_SetValue PocoInterface;
	}
}
