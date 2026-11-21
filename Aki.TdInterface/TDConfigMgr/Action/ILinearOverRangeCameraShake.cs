using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D47 RID: 7495
	public class ILinearOverRangeCameraShake : ICameraShakeConfig
	{
		// Token: 0x06009F25 RID: 40741 RVA: 0x0016DA70 File Offset: 0x0016BC70
		private ILinearOverRangeCameraShake_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILinearOverRangeCameraShake 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILinearOverRangeCameraShake_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILinearOverRangeCameraShake_SetValue());
			}
			return result;
		}

		// Token: 0x06009F26 RID: 40742 RVA: 0x0016DAA8 File Offset: 0x0016BCA8
		public static ILinearOverRangeCameraShake Create([Nullable(2)] ILinearOverRangeCameraShake instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinearOverRangeCameraShake
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F27 RID: 40743 RVA: 0x0016DABB File Offset: 0x0016BCBB
		public static ILinearOverRangeCameraShake CreateFromSetValue([Nullable(2)] ILinearOverRangeCameraShake_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILinearOverRangeCameraShake
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F28 RID: 40744 RVA: 0x0016DACE File Offset: 0x0016BCCE
		public new ILinearOverRangeCameraShake_SetValue ToSetValue()
		{
			return new ILinearOverRangeCameraShake_SetValue
			{
				Type = this.Type,
				CenterEntityId = this.CenterEntityId,
				MinRange = this.MinRange,
				MaxRange = this.MaxRange
			};
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x06009F29 RID: 40745 RVA: 0x0016DB05 File Offset: 0x0016BD05
		// (set) Token: 0x06009F2A RID: 40746 RVA: 0x0016DB30 File Offset: 0x0016BD30
		public override ECameraShakeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECameraShakeType.Constant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x06009F2B RID: 40747 RVA: 0x0016DB3E File Offset: 0x0016BD3E
		// (set) Token: 0x06009F2C RID: 40748 RVA: 0x0016DB69 File Offset: 0x0016BD69
		public virtual int CenterEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CenterEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CenterEntityId;
			}
			set
			{
				this.GetOrCreatePoco().CenterEntityId = value;
			}
		}

		// Token: 0x170031B8 RID: 12728
		// (get) Token: 0x06009F2D RID: 40749 RVA: 0x0016DB77 File Offset: 0x0016BD77
		// (set) Token: 0x06009F2E RID: 40750 RVA: 0x0016DBA2 File Offset: 0x0016BDA2
		public virtual int MinRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MinRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MinRange;
			}
			set
			{
				this.GetOrCreatePoco().MinRange = value;
			}
		}

		// Token: 0x170031B9 RID: 12729
		// (get) Token: 0x06009F2F RID: 40751 RVA: 0x0016DBB0 File Offset: 0x0016BDB0
		// (set) Token: 0x06009F30 RID: 40752 RVA: 0x0016DBDB File Offset: 0x0016BDDB
		public virtual int MaxRange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaxRange;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MaxRange;
			}
			set
			{
				this.GetOrCreatePoco().MaxRange = value;
			}
		}

		// Token: 0x040060EF RID: 24815
		[Nullable(2)]
		protected new ILinearOverRangeCameraShake FbInstance;

		// Token: 0x040060F0 RID: 24816
		[Nullable(2)]
		protected new ILinearOverRangeCameraShake_SetValue PocoInterface;
	}
}
