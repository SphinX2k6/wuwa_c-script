using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000396 RID: 918
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedFill : IFillType
	{
		// Token: 0x0600123F RID: 4671 RVA: 0x0003C63C File Offset: 0x0003A83C
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

		// Token: 0x06001240 RID: 4672 RVA: 0x0003C674 File Offset: 0x0003A874
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

		// Token: 0x06001241 RID: 4673 RVA: 0x0003C687 File Offset: 0x0003A887
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

		// Token: 0x06001242 RID: 4674 RVA: 0x0003C69A File Offset: 0x0003A89A
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

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x0003C6D1 File Offset: 0x0003A8D1
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x0003C6FC File Offset: 0x0003A8FC
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

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x0003C70C File Offset: 0x0003A90C
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x0003C746 File Offset: 0x0003A946
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

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0003C754 File Offset: 0x0003A954
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x0003C7B5 File Offset: 0x0003A9B5
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

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0003C7CC File Offset: 0x0003A9CC
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x0003C82D File Offset: 0x0003AA2D
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

		// Token: 0x04000EB7 RID: 3767
		[Nullable(2)]
		protected new IFixedFill FbInstance;

		// Token: 0x04000EB8 RID: 3768
		[Nullable(2)]
		protected new IFixedFill_SetValue PocoInterface;

		// Token: 0x04000EB9 RID: 3769
		private IPieceIndex _CentreCache;

		// Token: 0x04000EBA RID: 3770
		private bool _CentreInited;

		// Token: 0x04000EBB RID: 3771
		private IJigsawConfig _ConfigCache;

		// Token: 0x04000EBC RID: 3772
		private bool _ConfigInited;
	}
}
