using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237E RID: 9086
	public class PlayRegisteredMontage : ActionParams
	{
		// Token: 0x0600C628 RID: 50728 RVA: 0x001C64B8 File Offset: 0x001C46B8
		private PlayRegisteredMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayRegisteredMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayRegisteredMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayRegisteredMontage_SetValue());
			}
			return result;
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x001C64F0 File Offset: 0x001C46F0
		public static PlayRegisteredMontage Create([Nullable(2)] PlayRegisteredMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayRegisteredMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C62A RID: 50730 RVA: 0x001C6503 File Offset: 0x001C4703
		public static PlayRegisteredMontage CreateFromSetValue([Nullable(2)] PlayRegisteredMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayRegisteredMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C62B RID: 50731 RVA: 0x001C6518 File Offset: 0x001C4718
		public PlayRegisteredMontage_SetValue ToSetValue()
		{
			return new PlayRegisteredMontage_SetValue
			{
				EntityId = this.EntityId,
				MontageId = this.MontageId,
				IsOverlayMontage = this.IsOverlayMontage,
				IsAbpMontage = this.IsAbpMontage,
				FaceExpressionId = this.FaceExpressionId,
				LoopDuration = this.LoopDuration,
				RepeatTimes = this.RepeatTimes,
				KeepMontageWhenEnd = this.KeepMontageWhenEnd,
				KeepMontageAfterFlow = this.KeepMontageAfterFlow
			};
		}

		// Token: 0x17003BE8 RID: 15336
		// (get) Token: 0x0600C62C RID: 50732 RVA: 0x001C6596 File Offset: 0x001C4796
		// (set) Token: 0x0600C62D RID: 50733 RVA: 0x001C65C1 File Offset: 0x001C47C1
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

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600C62E RID: 50734 RVA: 0x001C65CF File Offset: 0x001C47CF
		// (set) Token: 0x0600C62F RID: 50735 RVA: 0x001C65FA File Offset: 0x001C47FA
		public virtual int MontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontageId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MontageId;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
			}
		}

		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600C630 RID: 50736 RVA: 0x001C6608 File Offset: 0x001C4808
		// (set) Token: 0x0600C631 RID: 50737 RVA: 0x001C6642 File Offset: 0x001C4842
		public virtual bool? IsOverlayMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOverlayMontage;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOverlayMontage;
			}
			set
			{
				this.GetOrCreatePoco().IsOverlayMontage = value;
			}
		}

		// Token: 0x17003BEB RID: 15339
		// (get) Token: 0x0600C632 RID: 50738 RVA: 0x001C6650 File Offset: 0x001C4850
		// (set) Token: 0x0600C633 RID: 50739 RVA: 0x001C668A File Offset: 0x001C488A
		public virtual bool? IsAbpMontage
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAbpMontage;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsAbpMontage;
			}
			set
			{
				this.GetOrCreatePoco().IsAbpMontage = value;
			}
		}

		// Token: 0x17003BEC RID: 15340
		// (get) Token: 0x0600C634 RID: 50740 RVA: 0x001C6698 File Offset: 0x001C4898
		// (set) Token: 0x0600C635 RID: 50741 RVA: 0x001C66D2 File Offset: 0x001C48D2
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x17003BED RID: 15341
		// (get) Token: 0x0600C636 RID: 50742 RVA: 0x001C66E0 File Offset: 0x001C48E0
		// (set) Token: 0x0600C637 RID: 50743 RVA: 0x001C671A File Offset: 0x001C491A
		public virtual float? LoopDuration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LoopDuration;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0600C638 RID: 50744 RVA: 0x001C6728 File Offset: 0x001C4928
		// (set) Token: 0x0600C639 RID: 50745 RVA: 0x001C6762 File Offset: 0x001C4962
		public virtual int? RepeatTimes
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RepeatTimes;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0600C63A RID: 50746 RVA: 0x001C6770 File Offset: 0x001C4970
		// (set) Token: 0x0600C63B RID: 50747 RVA: 0x001C67AA File Offset: 0x001C49AA
		public virtual bool? KeepMontageWhenEnd
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepMontageWhenEnd;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepMontageWhenEnd;
			}
			set
			{
				this.GetOrCreatePoco().KeepMontageWhenEnd = value;
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0600C63C RID: 50748 RVA: 0x001C67B8 File Offset: 0x001C49B8
		// (set) Token: 0x0600C63D RID: 50749 RVA: 0x001C67F2 File Offset: 0x001C49F2
		public virtual bool? KeepMontageAfterFlow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepMontageAfterFlow;
				}
				PlayRegisteredMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepMontageAfterFlow;
			}
			set
			{
				this.GetOrCreatePoco().KeepMontageAfterFlow = value;
			}
		}

		// Token: 0x040075E9 RID: 30185
		[Nullable(2)]
		protected new PlayRegisteredMontage FbInstance;

		// Token: 0x040075EA RID: 30186
		[Nullable(2)]
		protected PlayRegisteredMontage_SetValue PocoInterface;
	}
}
