using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211D RID: 8477
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayRegisteredMontage : ActionParams
	{
		// Token: 0x0600BA9A RID: 47770 RVA: 0x001AF304 File Offset: 0x001AD504
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

		// Token: 0x0600BA9B RID: 47771 RVA: 0x001AF33C File Offset: 0x001AD53C
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

		// Token: 0x0600BA9C RID: 47772 RVA: 0x001AF34F File Offset: 0x001AD54F
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

		// Token: 0x0600BA9D RID: 47773 RVA: 0x001AF364 File Offset: 0x001AD564
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

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0600BA9E RID: 47774 RVA: 0x001AF3E2 File Offset: 0x001AD5E2
		// (set) Token: 0x0600BA9F RID: 47775 RVA: 0x001AF40D File Offset: 0x001AD60D
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

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0600BAA0 RID: 47776 RVA: 0x001AF41B File Offset: 0x001AD61B
		// (set) Token: 0x0600BAA1 RID: 47777 RVA: 0x001AF446 File Offset: 0x001AD646
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

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0600BAA2 RID: 47778 RVA: 0x001AF454 File Offset: 0x001AD654
		// (set) Token: 0x0600BAA3 RID: 47779 RVA: 0x001AF48E File Offset: 0x001AD68E
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

		// Token: 0x170038FE RID: 14590
		// (get) Token: 0x0600BAA4 RID: 47780 RVA: 0x001AF49C File Offset: 0x001AD69C
		// (set) Token: 0x0600BAA5 RID: 47781 RVA: 0x001AF4D6 File Offset: 0x001AD6D6
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

		// Token: 0x170038FF RID: 14591
		// (get) Token: 0x0600BAA6 RID: 47782 RVA: 0x001AF4E4 File Offset: 0x001AD6E4
		// (set) Token: 0x0600BAA7 RID: 47783 RVA: 0x001AF51E File Offset: 0x001AD71E
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

		// Token: 0x17003900 RID: 14592
		// (get) Token: 0x0600BAA8 RID: 47784 RVA: 0x001AF52C File Offset: 0x001AD72C
		// (set) Token: 0x0600BAA9 RID: 47785 RVA: 0x001AF566 File Offset: 0x001AD766
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

		// Token: 0x17003901 RID: 14593
		// (get) Token: 0x0600BAAA RID: 47786 RVA: 0x001AF574 File Offset: 0x001AD774
		// (set) Token: 0x0600BAAB RID: 47787 RVA: 0x001AF5AE File Offset: 0x001AD7AE
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

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600BAAC RID: 47788 RVA: 0x001AF5BC File Offset: 0x001AD7BC
		// (set) Token: 0x0600BAAD RID: 47789 RVA: 0x001AF5F6 File Offset: 0x001AD7F6
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

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600BAAE RID: 47790 RVA: 0x001AF604 File Offset: 0x001AD804
		// (set) Token: 0x0600BAAF RID: 47791 RVA: 0x001AF63E File Offset: 0x001AD83E
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

		// Token: 0x04006FB4 RID: 28596
		[Nullable(2)]
		protected new PlayRegisteredMontage FbInstance;

		// Token: 0x04006FB5 RID: 28597
		[Nullable(2)]
		protected PlayRegisteredMontage_SetValue PocoInterface;
	}
}
