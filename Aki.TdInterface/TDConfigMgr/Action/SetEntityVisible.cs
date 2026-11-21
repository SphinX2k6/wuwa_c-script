using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241E RID: 9246
	public class SetEntityVisible : ActionParams
	{
		// Token: 0x0600C928 RID: 51496 RVA: 0x001CB954 File Offset: 0x001C9B54
		private SetEntityVisible_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetEntityVisible 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetEntityVisible_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetEntityVisible_SetValue());
			}
			return result;
		}

		// Token: 0x0600C929 RID: 51497 RVA: 0x001CB98C File Offset: 0x001C9B8C
		public static SetEntityVisible Create([Nullable(2)] SetEntityVisible instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetEntityVisible
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C92A RID: 51498 RVA: 0x001CB99F File Offset: 0x001C9B9F
		public static SetEntityVisible CreateFromSetValue([Nullable(2)] SetEntityVisible_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetEntityVisible
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C92B RID: 51499 RVA: 0x001CB9B2 File Offset: 0x001C9BB2
		public SetEntityVisible_SetValue ToSetValue()
		{
			return new SetEntityVisible_SetValue
			{
				EntityIds = this.EntityIds,
				Visible = this.Visible,
				PerformDestroy = this.PerformDestroy
			};
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x0600C92C RID: 51500 RVA: 0x001CB9DD File Offset: 0x001C9BDD
		// (set) Token: 0x0600C92D RID: 51501 RVA: 0x001CBA04 File Offset: 0x001C9C04
		public virtual List<int> EntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityIds;
				}
				SetEntityVisible_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityIds;
			}
			set
			{
				this.GetOrCreatePoco().EntityIds = value;
			}
		}

		// Token: 0x17003C80 RID: 15488
		// (get) Token: 0x0600C92E RID: 51502 RVA: 0x001CBA12 File Offset: 0x001C9C12
		// (set) Token: 0x0600C92F RID: 51503 RVA: 0x001CBA3D File Offset: 0x001C9C3D
		public virtual bool Visible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Visible;
				}
				return this.PocoInterface != null && this.PocoInterface.Visible;
			}
			set
			{
				this.GetOrCreatePoco().Visible = value;
			}
		}

		// Token: 0x17003C81 RID: 15489
		// (get) Token: 0x0600C930 RID: 51504 RVA: 0x001CBA4C File Offset: 0x001C9C4C
		// (set) Token: 0x0600C931 RID: 51505 RVA: 0x001CBA86 File Offset: 0x001C9C86
		public virtual bool? PerformDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformDestroy;
				}
				SetEntityVisible_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PerformDestroy;
			}
			set
			{
				this.GetOrCreatePoco().PerformDestroy = value;
			}
		}

		// Token: 0x0400774C RID: 30540
		[Nullable(2)]
		protected new SetEntityVisible FbInstance;

		// Token: 0x0400774D RID: 30541
		[Nullable(2)]
		protected SetEntityVisible_SetValue PocoInterface;
	}
}
