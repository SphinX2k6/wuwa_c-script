using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001224 RID: 4644
	public class IRogueAbilitySelect : IShowUi
	{
		// Token: 0x06006835 RID: 26677 RVA: 0x000F9D3C File Offset: 0x000F7F3C
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

		// Token: 0x06006836 RID: 26678 RVA: 0x000F9D74 File Offset: 0x000F7F74
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

		// Token: 0x06006837 RID: 26679 RVA: 0x000F9D87 File Offset: 0x000F7F87
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

		// Token: 0x06006838 RID: 26680 RVA: 0x000F9D9A File Offset: 0x000F7F9A
		public new IRogueAbilitySelect_SetValue ToSetValue()
		{
			return new IRogueAbilitySelect_SetValue
			{
				Type = this.Type,
				AbilityType = this.AbilityType,
				BindId = this.BindId
			};
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06006839 RID: 26681 RVA: 0x000F9DC5 File Offset: 0x000F7FC5
		// (set) Token: 0x0600683A RID: 26682 RVA: 0x000F9DF0 File Offset: 0x000F7FF0
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

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x0600683B RID: 26683 RVA: 0x000F9DFE File Offset: 0x000F7FFE
		// (set) Token: 0x0600683C RID: 26684 RVA: 0x000F9E29 File Offset: 0x000F8029
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

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600683D RID: 26685 RVA: 0x000F9E37 File Offset: 0x000F8037
		// (set) Token: 0x0600683E RID: 26686 RVA: 0x000F9E62 File Offset: 0x000F8062
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

		// Token: 0x04003E55 RID: 15957
		[Nullable(2)]
		protected new IRogueAbilitySelect FbInstance;

		// Token: 0x04003E56 RID: 15958
		[Nullable(2)]
		protected new IRogueAbilitySelect_SetValue PocoInterface;
	}
}
