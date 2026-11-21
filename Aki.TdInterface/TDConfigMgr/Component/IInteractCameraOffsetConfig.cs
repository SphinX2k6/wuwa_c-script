using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004CF RID: 1231
	public class IInteractCameraOffsetConfig
	{
		// Token: 0x0600189D RID: 6301 RVA: 0x0004A10C File Offset: 0x0004830C
		private IInteractCameraOffsetConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractCameraOffsetConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractCameraOffsetConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractCameraOffsetConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0004A144 File Offset: 0x00048344
		public static IInteractCameraOffsetConfig Create([Nullable(2)] IInteractCameraOffsetConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractCameraOffsetConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0004A157 File Offset: 0x00048357
		public static IInteractCameraOffsetConfig CreateFromSetValue([Nullable(2)] IInteractCameraOffsetConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractCameraOffsetConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0004A16A File Offset: 0x0004836A
		public IInteractCameraOffsetConfig_SetValue ToSetValue()
		{
			return new IInteractCameraOffsetConfig_SetValue
			{
				CenterOffsetPercent = this.CenterOffsetPercent,
				OffsetZ = this.OffsetZ
			};
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0004A18C File Offset: 0x0004838C
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0004A1C6 File Offset: 0x000483C6
		public virtual int? CenterOffsetPercent
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterOffsetPercent;
				}
				IInteractCameraOffsetConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CenterOffsetPercent;
			}
			set
			{
				this.GetOrCreatePoco().CenterOffsetPercent = value;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0004A1D4 File Offset: 0x000483D4
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x0004A20E File Offset: 0x0004840E
		public virtual float? OffsetZ
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OffsetZ;
				}
				IInteractCameraOffsetConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OffsetZ;
			}
			set
			{
				this.GetOrCreatePoco().OffsetZ = value;
			}
		}

		// Token: 0x04001281 RID: 4737
		[Nullable(2)]
		protected IInteractCameraOffsetConfig FbInstance;

		// Token: 0x04001282 RID: 4738
		[Nullable(2)]
		protected IInteractCameraOffsetConfig_SetValue PocoInterface;
	}
}
