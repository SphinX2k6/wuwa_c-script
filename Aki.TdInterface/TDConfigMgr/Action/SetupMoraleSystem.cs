using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021E9 RID: 8681
	[NullableContext(1)]
	[Nullable(0)]
	public class SetupMoraleSystem : ActionParams
	{
		// Token: 0x0600BEAF RID: 48815 RVA: 0x001B6DA8 File Offset: 0x001B4FA8
		private SetupMoraleSystem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetupMoraleSystem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetupMoraleSystem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetupMoraleSystem_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEB0 RID: 48816 RVA: 0x001B6DE0 File Offset: 0x001B4FE0
		public static SetupMoraleSystem Create([Nullable(2)] SetupMoraleSystem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetupMoraleSystem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEB1 RID: 48817 RVA: 0x001B6DF3 File Offset: 0x001B4FF3
		public static SetupMoraleSystem CreateFromSetValue([Nullable(2)] SetupMoraleSystem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetupMoraleSystem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEB2 RID: 48818 RVA: 0x001B6E06 File Offset: 0x001B5006
		public SetupMoraleSystem_SetValue ToSetValue()
		{
			return new SetupMoraleSystem_SetValue
			{
				MoralePlayId = this.MoralePlayId,
				IsOn = this.IsOn
			};
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600BEB3 RID: 48819 RVA: 0x001B6E25 File Offset: 0x001B5025
		// (set) Token: 0x0600BEB4 RID: 48820 RVA: 0x001B6E50 File Offset: 0x001B5050
		public virtual int MoralePlayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoralePlayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MoralePlayId;
			}
			set
			{
				this.GetOrCreatePoco().MoralePlayId = value;
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600BEB5 RID: 48821 RVA: 0x001B6E5E File Offset: 0x001B505E
		// (set) Token: 0x0600BEB6 RID: 48822 RVA: 0x001B6E89 File Offset: 0x001B5089
		public virtual bool IsOn
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOn;
				}
				return this.PocoInterface != null && this.PocoInterface.IsOn;
			}
			set
			{
				this.GetOrCreatePoco().IsOn = value;
			}
		}

		// Token: 0x040071C3 RID: 29123
		[Nullable(2)]
		protected new SetupMoraleSystem FbInstance;

		// Token: 0x040071C4 RID: 29124
		[Nullable(2)]
		protected SetupMoraleSystem_SetValue PocoInterface;
	}
}
