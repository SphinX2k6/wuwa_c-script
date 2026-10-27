using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000476 RID: 1142
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractCameraOffsetConfig
	{
		// Token: 0x06001703 RID: 5891 RVA: 0x000463C4 File Offset: 0x000445C4
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

		// Token: 0x06001704 RID: 5892 RVA: 0x000463FC File Offset: 0x000445FC
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

		// Token: 0x06001705 RID: 5893 RVA: 0x0004640F File Offset: 0x0004460F
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

		// Token: 0x06001706 RID: 5894 RVA: 0x00046422 File Offset: 0x00044622
		public IInteractCameraOffsetConfig_SetValue ToSetValue()
		{
			return new IInteractCameraOffsetConfig_SetValue
			{
				CenterOffsetPercent = this.CenterOffsetPercent,
				OffsetZ = this.OffsetZ
			};
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x00046444 File Offset: 0x00044644
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0004647E File Offset: 0x0004467E
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

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0004648C File Offset: 0x0004468C
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x000464C6 File Offset: 0x000446C6
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

		// Token: 0x0400115F RID: 4447
		[Nullable(2)]
		protected IInteractCameraOffsetConfig FbInstance;

		// Token: 0x04001160 RID: 4448
		[Nullable(2)]
		protected IInteractCameraOffsetConfig_SetValue PocoInterface;
	}
}
