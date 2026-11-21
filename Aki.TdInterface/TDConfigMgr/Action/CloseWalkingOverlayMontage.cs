using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200166A RID: 5738
	public class CloseWalkingOverlayMontage : ActionParams
	{
		// Token: 0x06008157 RID: 33111 RVA: 0x001334D8 File Offset: 0x001316D8
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

		// Token: 0x06008158 RID: 33112 RVA: 0x00133510 File Offset: 0x00131710
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

		// Token: 0x06008159 RID: 33113 RVA: 0x00133523 File Offset: 0x00131723
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

		// Token: 0x0600815A RID: 33114 RVA: 0x00133536 File Offset: 0x00131736
		public CloseWalkingOverlayMontage_SetValue ToSetValue()
		{
			return new CloseWalkingOverlayMontage_SetValue
			{
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002ACD RID: 10957
		// (get) Token: 0x0600815B RID: 33115 RVA: 0x00133549 File Offset: 0x00131749
		// (set) Token: 0x0600815C RID: 33116 RVA: 0x00133574 File Offset: 0x00131774
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

		// Token: 0x04004A96 RID: 19094
		[Nullable(2)]
		protected new CloseWalkingOverlayMontage FbInstance;

		// Token: 0x04004A97 RID: 19095
		[Nullable(2)]
		protected CloseWalkingOverlayMontage_SetValue PocoInterface;
	}
}
