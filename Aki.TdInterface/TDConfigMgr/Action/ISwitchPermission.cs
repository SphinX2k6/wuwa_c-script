using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F03 RID: 7939
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchPermission : SwitchSubLevels
	{
		// Token: 0x0600A9C4 RID: 43460 RVA: 0x0017E938 File Offset: 0x0017CB38
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

		// Token: 0x0600A9C5 RID: 43461 RVA: 0x0017E970 File Offset: 0x0017CB70
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

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x0017E983 File Offset: 0x0017CB83
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

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x0017E996 File Offset: 0x0017CB96
		public new ISwitchPermission_SetValue ToSetValue()
		{
			return new ISwitchPermission_SetValue
			{
				Type = this.Type,
				IsAllowClientSwitch = this.IsAllowClientSwitch,
				Levels = this.Levels
			};
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600A9C8 RID: 43464 RVA: 0x0017E9C1 File Offset: 0x0017CBC1
		// (set) Token: 0x0600A9C9 RID: 43465 RVA: 0x0017E9EC File Offset: 0x0017CBEC
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

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600A9CA RID: 43466 RVA: 0x0017E9FA File Offset: 0x0017CBFA
		// (set) Token: 0x0600A9CB RID: 43467 RVA: 0x0017EA25 File Offset: 0x0017CC25
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

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x0017EA33 File Offset: 0x0017CC33
		// (set) Token: 0x0600A9CD RID: 43469 RVA: 0x0017EA5A File Offset: 0x0017CC5A
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

		// Token: 0x040064F0 RID: 25840
		[Nullable(2)]
		protected new ISwitchPermission FbInstance;

		// Token: 0x040064F1 RID: 25841
		[Nullable(2)]
		protected new ISwitchPermission_SetValue PocoInterface;
	}
}
