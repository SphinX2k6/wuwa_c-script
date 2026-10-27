using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200188C RID: 6284
	[NullableContext(1)]
	[Nullable(0)]
	public class IChargeSlashScanEffect : ISpecificScanEffect
	{
		// Token: 0x060086F5 RID: 34549 RVA: 0x00140390 File Offset: 0x0013E590
		private IChargeSlashScanEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChargeSlashScanEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChargeSlashScanEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChargeSlashScanEffect_SetValue());
			}
			return result;
		}

		// Token: 0x060086F6 RID: 34550 RVA: 0x001403C8 File Offset: 0x0013E5C8
		public static IChargeSlashScanEffect Create([Nullable(2)] IChargeSlashScanEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChargeSlashScanEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086F7 RID: 34551 RVA: 0x001403DB File Offset: 0x0013E5DB
		public static IChargeSlashScanEffect CreateFromSetValue([Nullable(2)] IChargeSlashScanEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChargeSlashScanEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086F8 RID: 34552 RVA: 0x001403EE File Offset: 0x0013E5EE
		public new IChargeSlashScanEffect_SetValue ToSetValue()
		{
			return new IChargeSlashScanEffect_SetValue
			{
				Type = this.Type,
				TriggerPosEntityId = this.TriggerPosEntityId
			};
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x060086F9 RID: 34553 RVA: 0x0014040D File Offset: 0x0013E60D
		// (set) Token: 0x060086FA RID: 34554 RVA: 0x00140438 File Offset: 0x0013E638
		public override ESpecificScanType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return (ESpecificScanType)0;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x060086FB RID: 34555 RVA: 0x00140446 File Offset: 0x0013E646
		// (set) Token: 0x060086FC RID: 34556 RVA: 0x00140471 File Offset: 0x0013E671
		public virtual int TriggerPosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerPosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TriggerPosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().TriggerPosEntityId = value;
			}
		}

		// Token: 0x04005504 RID: 21764
		[Nullable(2)]
		protected new IChargeSlashScanEffect FbInstance;

		// Token: 0x04005505 RID: 21765
		[Nullable(2)]
		protected new IChargeSlashScanEffect_SetValue PocoInterface;
	}
}
