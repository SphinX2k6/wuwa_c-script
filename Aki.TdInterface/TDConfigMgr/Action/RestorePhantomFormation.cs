using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002169 RID: 8553
	[NullableContext(1)]
	[Nullable(0)]
	public class RestorePhantomFormation : ActionParams
	{
		// Token: 0x0600BC26 RID: 48166 RVA: 0x001B1FA4 File Offset: 0x001B01A4
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

		// Token: 0x0600BC27 RID: 48167 RVA: 0x001B1FDC File Offset: 0x001B01DC
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

		// Token: 0x0600BC28 RID: 48168 RVA: 0x001B1FEF File Offset: 0x001B01EF
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

		// Token: 0x0600BC29 RID: 48169 RVA: 0x001B2002 File Offset: 0x001B0202
		public RestorePhantomFormation_SetValue ToSetValue()
		{
			return new RestorePhantomFormation_SetValue
			{
				TeleportEntityId = this.TeleportEntityId,
				RetainPhantom = this.RetainPhantom
			};
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600BC2A RID: 48170 RVA: 0x001B2024 File Offset: 0x001B0224
		// (set) Token: 0x0600BC2B RID: 48171 RVA: 0x001B205E File Offset: 0x001B025E
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

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x001B206C File Offset: 0x001B026C
		// (set) Token: 0x0600BC2D RID: 48173 RVA: 0x001B20A6 File Offset: 0x001B02A6
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

		// Token: 0x04007066 RID: 28774
		[Nullable(2)]
		protected new RestorePhantomFormation FbInstance;

		// Token: 0x04007067 RID: 28775
		[Nullable(2)]
		protected RestorePhantomFormation_SetValue PocoInterface;
	}
}
