using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A17 RID: 6679
	public class IChargeSlashScanEffect : ISpecificScanEffect
	{
		// Token: 0x06008E1D RID: 36381 RVA: 0x0014FBC4 File Offset: 0x0014DDC4
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

		// Token: 0x06008E1E RID: 36382 RVA: 0x0014FBFC File Offset: 0x0014DDFC
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

		// Token: 0x06008E1F RID: 36383 RVA: 0x0014FC0F File Offset: 0x0014DE0F
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

		// Token: 0x06008E20 RID: 36384 RVA: 0x0014FC22 File Offset: 0x0014DE22
		public new IChargeSlashScanEffect_SetValue ToSetValue()
		{
			return new IChargeSlashScanEffect_SetValue
			{
				Type = this.Type,
				TriggerPosEntityId = this.TriggerPosEntityId
			};
		}

		// Token: 0x17002DF8 RID: 11768
		// (get) Token: 0x06008E21 RID: 36385 RVA: 0x0014FC41 File Offset: 0x0014DE41
		// (set) Token: 0x06008E22 RID: 36386 RVA: 0x0014FC6C File Offset: 0x0014DE6C
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

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x06008E23 RID: 36387 RVA: 0x0014FC7A File Offset: 0x0014DE7A
		// (set) Token: 0x06008E24 RID: 36388 RVA: 0x0014FCA5 File Offset: 0x0014DEA5
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

		// Token: 0x04005951 RID: 22865
		[Nullable(2)]
		protected new IChargeSlashScanEffect FbInstance;

		// Token: 0x04005952 RID: 22866
		[Nullable(2)]
		protected new IChargeSlashScanEffect_SetValue PocoInterface;
	}
}
