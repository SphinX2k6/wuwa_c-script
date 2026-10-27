using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021B3 RID: 8627
	[NullableContext(1)]
	[Nullable(0)]
	public class SetEntityVisible : ActionParams
	{
		// Token: 0x0600BD6E RID: 48494 RVA: 0x001B431C File Offset: 0x001B251C
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

		// Token: 0x0600BD6F RID: 48495 RVA: 0x001B4354 File Offset: 0x001B2554
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

		// Token: 0x0600BD70 RID: 48496 RVA: 0x001B4367 File Offset: 0x001B2567
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

		// Token: 0x0600BD71 RID: 48497 RVA: 0x001B437A File Offset: 0x001B257A
		public SetEntityVisible_SetValue ToSetValue()
		{
			return new SetEntityVisible_SetValue
			{
				EntityIds = this.EntityIds,
				Visible = this.Visible,
				PerformDestroy = this.PerformDestroy
			};
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x001B43A5 File Offset: 0x001B25A5
		// (set) Token: 0x0600BD73 RID: 48499 RVA: 0x001B43CC File Offset: 0x001B25CC
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

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600BD74 RID: 48500 RVA: 0x001B43DA File Offset: 0x001B25DA
		// (set) Token: 0x0600BD75 RID: 48501 RVA: 0x001B4405 File Offset: 0x001B2605
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

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600BD76 RID: 48502 RVA: 0x001B4414 File Offset: 0x001B2614
		// (set) Token: 0x0600BD77 RID: 48503 RVA: 0x001B444E File Offset: 0x001B264E
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

		// Token: 0x04007104 RID: 28932
		[Nullable(2)]
		protected new SetEntityVisible FbInstance;

		// Token: 0x04007105 RID: 28933
		[Nullable(2)]
		protected SetEntityVisible_SetValue PocoInterface;
	}
}
