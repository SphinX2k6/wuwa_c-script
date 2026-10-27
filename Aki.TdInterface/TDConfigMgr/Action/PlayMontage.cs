using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002119 RID: 8473
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayMontage : ActionParams
	{
		// Token: 0x0600BA76 RID: 47734 RVA: 0x001AED34 File Offset: 0x001ACF34
		private PlayMontage_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PlayMontage 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PlayMontage_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PlayMontage_SetValue());
			}
			return result;
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x001AED6C File Offset: 0x001ACF6C
		public static PlayMontage Create([Nullable(2)] PlayMontage instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PlayMontage
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BA78 RID: 47736 RVA: 0x001AED7F File Offset: 0x001ACF7F
		public static PlayMontage CreateFromSetValue([Nullable(2)] PlayMontage_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PlayMontage
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BA79 RID: 47737 RVA: 0x001AED94 File Offset: 0x001ACF94
		public PlayMontage_SetValue ToSetValue()
		{
			return new PlayMontage_SetValue
			{
				EntityId = this.EntityId,
				ActionMontage = this.ActionMontage,
				ExpressionMontage = this.ExpressionMontage,
				MouthSequence = this.MouthSequence,
				Duration = this.Duration
			};
		}

		// Token: 0x170038EF RID: 14575
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x001AEDE2 File Offset: 0x001ACFE2
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x001AEE0D File Offset: 0x001AD00D
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

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x001AEE1C File Offset: 0x001AD01C
		// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x001AEE7D File Offset: 0x001AD07D
		public virtual IActionMontage ActionMontage
		{
			get
			{
				if (this._ActionMontageInited)
				{
					return this._ActionMontageCache;
				}
				this._ActionMontageInited = true;
				if (this.FbInstance != null)
				{
					this._ActionMontageCache = IActionMontage.Create(this.FbInstance.ActionMontage);
				}
				else
				{
					PlayMontage_SetValue pocoInterface = this.PocoInterface;
					this._ActionMontageCache = ((pocoInterface != null) ? pocoInterface.ActionMontage : null);
				}
				return this._ActionMontageCache;
			}
			set
			{
				this.GetOrCreatePoco().ActionMontage = value;
				this._ActionMontageInited = false;
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x001AEE92 File Offset: 0x001AD092
		// (set) Token: 0x0600BA7F RID: 47743 RVA: 0x001AEEB9 File Offset: 0x001AD0B9
		[Nullable(2)]
		public virtual string ExpressionMontage
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExpressionMontage;
				}
				PlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExpressionMontage;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExpressionMontage = value;
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x001AEEC7 File Offset: 0x001AD0C7
		// (set) Token: 0x0600BA81 RID: 47745 RVA: 0x001AEEEE File Offset: 0x001AD0EE
		[Nullable(2)]
		public virtual string MouthSequence
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MouthSequence;
				}
				PlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MouthSequence;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MouthSequence = value;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x0600BA82 RID: 47746 RVA: 0x001AEEFC File Offset: 0x001AD0FC
		// (set) Token: 0x0600BA83 RID: 47747 RVA: 0x001AEF36 File Offset: 0x001AD136
		public virtual int? Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				PlayMontage_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04006F9A RID: 28570
		[Nullable(2)]
		protected new PlayMontage FbInstance;

		// Token: 0x04006F9B RID: 28571
		[Nullable(2)]
		protected PlayMontage_SetValue PocoInterface;

		// Token: 0x04006F9C RID: 28572
		private IActionMontage _ActionMontageCache;

		// Token: 0x04006F9D RID: 28573
		private bool _ActionMontageInited;
	}
}
