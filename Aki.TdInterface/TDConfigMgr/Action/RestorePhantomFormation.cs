using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023CA RID: 9162
	public class RestorePhantomFormation : ActionParams
	{
		// Token: 0x0600C7B4 RID: 51124 RVA: 0x001C9158 File Offset: 0x001C7358
		private RestorePhantomFormation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RestorePhantomFormation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RestorePhantomFormation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RestorePhantomFormation_SetValue());
			}
			return result;
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x001C9190 File Offset: 0x001C7390
		public static RestorePhantomFormation Create([Nullable(2)] RestorePhantomFormation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RestorePhantomFormation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x001C91A3 File Offset: 0x001C73A3
		public static RestorePhantomFormation CreateFromSetValue([Nullable(2)] RestorePhantomFormation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RestorePhantomFormation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x001C91B6 File Offset: 0x001C73B6
		public RestorePhantomFormation_SetValue ToSetValue()
		{
			return new RestorePhantomFormation_SetValue
			{
				TeleportEntityId = this.TeleportEntityId,
				RetainPhantom = this.RetainPhantom
			};
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x0600C7B8 RID: 51128 RVA: 0x001C91D8 File Offset: 0x001C73D8
		// (set) Token: 0x0600C7B9 RID: 51129 RVA: 0x001C9212 File Offset: 0x001C7412
		public virtual int? TeleportEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TeleportEntityId;
				}
				RestorePhantomFormation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x0600C7BA RID: 51130 RVA: 0x001C9220 File Offset: 0x001C7420
		// (set) Token: 0x0600C7BB RID: 51131 RVA: 0x001C925A File Offset: 0x001C745A
		public virtual bool? RetainPhantom
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RetainPhantom;
				}
				RestorePhantomFormation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RetainPhantom;
			}
			set
			{
				this.GetOrCreatePoco().RetainPhantom = value;
			}
		}

		// Token: 0x0400769B RID: 30363
		[Nullable(2)]
		protected new RestorePhantomFormation FbInstance;

		// Token: 0x0400769C RID: 30364
		[Nullable(2)]
		protected RestorePhantomFormation_SetValue PocoInterface;
	}
}
