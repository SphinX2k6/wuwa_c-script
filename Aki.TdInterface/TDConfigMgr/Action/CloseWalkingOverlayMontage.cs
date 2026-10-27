using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001511 RID: 5393
	[NullableContext(1)]
	[Nullable(0)]
	public class CloseWalkingOverlayMontage : ActionParams
	{
		// Token: 0x06007A8C RID: 31372 RVA: 0x001248B0 File Offset: 0x00122AB0
		private CloseWalkingOverlayMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CloseWalkingOverlayMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CloseWalkingOverlayMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CloseWalkingOverlayMontage_SetValue());
			}
			return result;
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x001248E8 File Offset: 0x00122AE8
		public static CloseWalkingOverlayMontage Create([Nullable(2)] CloseWalkingOverlayMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CloseWalkingOverlayMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x001248FB File Offset: 0x00122AFB
		public static CloseWalkingOverlayMontage CreateFromSetValue([Nullable(2)] CloseWalkingOverlayMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CloseWalkingOverlayMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x0012490E File Offset: 0x00122B0E
		public CloseWalkingOverlayMontage_SetValue ToSetValue()
		{
			return new CloseWalkingOverlayMontage_SetValue
			{
				EntityId = this.EntityId
			};
		}

		// Token: 0x170028E4 RID: 10468
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x00124921 File Offset: 0x00122B21
		// (set) Token: 0x06007A91 RID: 31377 RVA: 0x0012494C File Offset: 0x00122B4C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040046FA RID: 18170
		[Nullable(2)]
		protected new CloseWalkingOverlayMontage FbInstance;

		// Token: 0x040046FB RID: 18171
		[Nullable(2)]
		protected CloseWalkingOverlayMontage_SetValue PocoInterface;
	}
}
