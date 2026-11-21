using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003DF RID: 991
	public class IFixedFill : IFillType
	{
		// Token: 0x06001383 RID: 4995 RVA: 0x0003F920 File Offset: 0x0003DB20
		private IFixedFill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFixedFill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFixedFill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFixedFill_SetValue());
			}
			return result;
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x0003F958 File Offset: 0x0003DB58
		public static IFixedFill Create([Nullable(2)] IFixedFill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedFill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0003F96B File Offset: 0x0003DB6B
		public static IFixedFill CreateFromSetValue([Nullable(2)] IFixedFill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFixedFill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0003F97E File Offset: 0x0003DB7E
		public new IFixedFill_SetValue ToSetValue()
		{
			return new IFixedFill_SetValue
			{
				Type = this.Type,
				ModelId = this.ModelId,
				Centre = this.Centre,
				Config = this.Config
			};
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x0003F9B5 File Offset: 0x0003DBB5
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0003F9E0 File Offset: 0x0003DBE0
		public override EFillType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFillType.Fixed;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003F9F0 File Offset: 0x0003DBF0
		// (set) Token: 0x0600138A RID: 5002 RVA: 0x0003FA2A File Offset: 0x0003DC2A
		public virtual int? ModelId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ModelId;
				}
				IFixedFill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ModelId;
			}
			set
			{
				this.GetOrCreatePoco().ModelId = value;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x0003FA38 File Offset: 0x0003DC38
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x0003FA99 File Offset: 0x0003DC99
		public virtual IPieceIndex Centre
		{
			get
			{
				if (this._CentreInited)
				{
					return this._CentreCache;
				}
				this._CentreInited = true;
				if (this.FbInstance != null)
				{
					this._CentreCache = IPieceIndex.Create(this.FbInstance.Centre);
				}
				else
				{
					IFixedFill_SetValue pocoInterface = this.PocoInterface;
					this._CentreCache = ((pocoInterface != null) ? pocoInterface.Centre : null);
				}
				return this._CentreCache;
			}
			set
			{
				this.GetOrCreatePoco().Centre = value;
				this._CentreInited = false;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x0003FAB0 File Offset: 0x0003DCB0
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x0003FB11 File Offset: 0x0003DD11
		public virtual IJigsawConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IJigsawConfig.Create(this.FbInstance.Config);
				}
				else
				{
					IFixedFill_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x04000FAE RID: 4014
		[Nullable(2)]
		protected new IFixedFill FbInstance;

		// Token: 0x04000FAF RID: 4015
		[Nullable(2)]
		protected new IFixedFill_SetValue PocoInterface;

		// Token: 0x04000FB0 RID: 4016
		private IPieceIndex _CentreCache;

		// Token: 0x04000FB1 RID: 4017
		private bool _CentreInited;

		// Token: 0x04000FB2 RID: 4018
		private IJigsawConfig _ConfigCache;

		// Token: 0x04000FB3 RID: 4019
		private bool _ConfigInited;
	}
}
