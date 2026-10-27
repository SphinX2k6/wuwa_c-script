using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D32 RID: 7474
	[NullableContext(1)]
	[Nullable(0)]
	public class IPositionDrivenMoveDriveMode : ISplineMoveDriveMode
	{
		// Token: 0x0600A05F RID: 41055 RVA: 0x0016DE24 File Offset: 0x0016C024
		private IPositionDrivenMoveDriveMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPositionDrivenMoveDriveMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPositionDrivenMoveDriveMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPositionDrivenMoveDriveMode_SetValue());
			}
			return result;
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x0016DE5C File Offset: 0x0016C05C
		public static IPositionDrivenMoveDriveMode Create([Nullable(2)] IPositionDrivenMoveDriveMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPositionDrivenMoveDriveMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x0016DE6F File Offset: 0x0016C06F
		public static IPositionDrivenMoveDriveMode CreateFromSetValue([Nullable(2)] IPositionDrivenMoveDriveMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPositionDrivenMoveDriveMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x0016DE82 File Offset: 0x0016C082
		public new IPositionDrivenMoveDriveMode_SetValue ToSetValue()
		{
			return new IPositionDrivenMoveDriveMode_SetValue
			{
				Type = this.Type,
				IsFixedPitch = this.IsFixedPitch
			};
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x0016DEA1 File Offset: 0x0016C0A1
		// (set) Token: 0x0600A064 RID: 41060 RVA: 0x0016DECC File Offset: 0x0016C0CC
		public override ESplineMoveDriveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveDriveMode.InputDriven;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x0600A065 RID: 41061 RVA: 0x0016DEDC File Offset: 0x0016C0DC
		// (set) Token: 0x0600A066 RID: 41062 RVA: 0x0016DF16 File Offset: 0x0016C116
		public virtual bool? IsFixedPitch
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFixedPitch;
				}
				IPositionDrivenMoveDriveMode_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFixedPitch;
			}
			set
			{
				this.GetOrCreatePoco().IsFixedPitch = value;
			}
		}

		// Token: 0x040060A8 RID: 24744
		[Nullable(2)]
		protected new IPositionDrivenMoveDriveMode FbInstance;

		// Token: 0x040060A9 RID: 24745
		[Nullable(2)]
		protected new IPositionDrivenMoveDriveMode_SetValue PocoInterface;
	}
}
