using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002382 RID: 9090
	public class PlayWalkingOverlayMontage : ActionParams
	{
		// Token: 0x0600C654 RID: 50772 RVA: 0x001C6B60 File Offset: 0x001C4D60
		private PlayWalkingOverlayMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayWalkingOverlayMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayWalkingOverlayMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayWalkingOverlayMontage_SetValue());
			}
			return result;
		}

		// Token: 0x0600C655 RID: 50773 RVA: 0x001C6B98 File Offset: 0x001C4D98
		public static PlayWalkingOverlayMontage Create([Nullable(2)] PlayWalkingOverlayMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayWalkingOverlayMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x001C6BAB File Offset: 0x001C4DAB
		public static PlayWalkingOverlayMontage CreateFromSetValue([Nullable(2)] PlayWalkingOverlayMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayWalkingOverlayMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x001C6BBE File Offset: 0x001C4DBE
		public PlayWalkingOverlayMontage_SetValue ToSetValue()
		{
			return new PlayWalkingOverlayMontage_SetValue
			{
				EntityId = this.EntityId,
				OverlapMontageId = this.OverlapMontageId,
				LoopDuration = this.LoopDuration,
				RepeatTimes = this.RepeatTimes
			};
		}

		// Token: 0x17003BF8 RID: 15352
		// (get) Token: 0x0600C658 RID: 50776 RVA: 0x001C6BF5 File Offset: 0x001C4DF5
		// (set) Token: 0x0600C659 RID: 50777 RVA: 0x001C6C20 File Offset: 0x001C4E20
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

		// Token: 0x17003BF9 RID: 15353
		// (get) Token: 0x0600C65A RID: 50778 RVA: 0x001C6C2E File Offset: 0x001C4E2E
		// (set) Token: 0x0600C65B RID: 50779 RVA: 0x001C6C59 File Offset: 0x001C4E59
		public virtual int OverlapMontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverlapMontageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.OverlapMontageId;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageId = value;
			}
		}

		// Token: 0x17003BFA RID: 15354
		// (get) Token: 0x0600C65C RID: 50780 RVA: 0x001C6C68 File Offset: 0x001C4E68
		// (set) Token: 0x0600C65D RID: 50781 RVA: 0x001C6CA2 File Offset: 0x001C4EA2
		public virtual float? LoopDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopDuration;
				}
				PlayWalkingOverlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LoopDuration;
			}
			set
			{
				this.GetOrCreatePoco().LoopDuration = value;
			}
		}

		// Token: 0x17003BFB RID: 15355
		// (get) Token: 0x0600C65E RID: 50782 RVA: 0x001C6CB0 File Offset: 0x001C4EB0
		// (set) Token: 0x0600C65F RID: 50783 RVA: 0x001C6CEA File Offset: 0x001C4EEA
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				PlayWalkingOverlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RepeatTimes;
			}
			set
			{
				this.GetOrCreatePoco().RepeatTimes = value;
			}
		}

		// Token: 0x04007601 RID: 30209
		[Nullable(2)]
		protected new PlayWalkingOverlayMontage FbInstance;

		// Token: 0x04007602 RID: 30210
		[Nullable(2)]
		protected PlayWalkingOverlayMontage_SetValue PocoInterface;
	}
}
