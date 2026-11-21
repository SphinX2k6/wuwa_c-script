using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239C RID: 9116
	public class ReignsChangeBackground : ActionParams
	{
		// Token: 0x0600C6E2 RID: 50914 RVA: 0x001C7BA8 File Offset: 0x001C5DA8
		private ReignsChangeBackground_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ReignsChangeBackground 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ReignsChangeBackground_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ReignsChangeBackground_SetValue());
			}
			return result;
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x001C7BE0 File Offset: 0x001C5DE0
		public static ReignsChangeBackground Create([Nullable(2)] ReignsChangeBackground instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ReignsChangeBackground
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x001C7BF3 File Offset: 0x001C5DF3
		public static ReignsChangeBackground CreateFromSetValue([Nullable(2)] ReignsChangeBackground_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ReignsChangeBackground
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x001C7C06 File Offset: 0x001C5E06
		public ReignsChangeBackground_SetValue ToSetValue()
		{
			return new ReignsChangeBackground_SetValue
			{
				Background = this.Background,
				ChangeMode = this.ChangeMode
			};
		}

		// Token: 0x17003C1B RID: 15387
		// (get) Token: 0x0600C6E6 RID: 50918 RVA: 0x001C7C25 File Offset: 0x001C5E25
		// (set) Token: 0x0600C6E7 RID: 50919 RVA: 0x001C7C50 File Offset: 0x001C5E50
		public virtual string Background
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Background;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Background;
			}
			set
			{
				this.GetOrCreatePoco().Background = value;
			}
		}

		// Token: 0x17003C1C RID: 15388
		// (get) Token: 0x0600C6E8 RID: 50920 RVA: 0x001C7C5E File Offset: 0x001C5E5E
		// (set) Token: 0x0600C6E9 RID: 50921 RVA: 0x001C7C89 File Offset: 0x001C5E89
		public virtual EReignsBackgroundChangeMode ChangeMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ChangeMode;
				}
				if (this.PocoInterface == null)
				{
					return EReignsBackgroundChangeMode.Instant;
				}
				return this.PocoInterface.ChangeMode;
			}
			set
			{
				this.GetOrCreatePoco().ChangeMode = value;
			}
		}

		// Token: 0x04007640 RID: 30272
		[Nullable(2)]
		protected new ReignsChangeBackground FbInstance;

		// Token: 0x04007641 RID: 30273
		[Nullable(2)]
		protected ReignsChangeBackground_SetValue PocoInterface;
	}
}
