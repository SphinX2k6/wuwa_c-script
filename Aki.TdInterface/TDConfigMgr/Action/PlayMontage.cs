using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237A RID: 9082
	public class PlayMontage : ActionParams
	{
		// Token: 0x0600C602 RID: 50690 RVA: 0x001C5E94 File Offset: 0x001C4094
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

		// Token: 0x0600C603 RID: 50691 RVA: 0x001C5ECC File Offset: 0x001C40CC
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

		// Token: 0x0600C604 RID: 50692 RVA: 0x001C5EDF File Offset: 0x001C40DF
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

		// Token: 0x0600C605 RID: 50693 RVA: 0x001C5EF4 File Offset: 0x001C40F4
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

		// Token: 0x17003BDB RID: 15323
		// (get) Token: 0x0600C606 RID: 50694 RVA: 0x001C5F42 File Offset: 0x001C4142
		// (set) Token: 0x0600C607 RID: 50695 RVA: 0x001C5F6D File Offset: 0x001C416D
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

		// Token: 0x17003BDC RID: 15324
		// (get) Token: 0x0600C608 RID: 50696 RVA: 0x001C5F7C File Offset: 0x001C417C
		// (set) Token: 0x0600C609 RID: 50697 RVA: 0x001C5FDD File Offset: 0x001C41DD
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

		// Token: 0x17003BDD RID: 15325
		// (get) Token: 0x0600C60A RID: 50698 RVA: 0x001C5FF2 File Offset: 0x001C41F2
		// (set) Token: 0x0600C60B RID: 50699 RVA: 0x001C6019 File Offset: 0x001C4219
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

		// Token: 0x17003BDE RID: 15326
		// (get) Token: 0x0600C60C RID: 50700 RVA: 0x001C6027 File Offset: 0x001C4227
		// (set) Token: 0x0600C60D RID: 50701 RVA: 0x001C604E File Offset: 0x001C424E
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

		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600C60E RID: 50702 RVA: 0x001C605C File Offset: 0x001C425C
		// (set) Token: 0x0600C60F RID: 50703 RVA: 0x001C6096 File Offset: 0x001C4296
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

		// Token: 0x040075CE RID: 30158
		[Nullable(2)]
		protected new PlayMontage FbInstance;

		// Token: 0x040075CF RID: 30159
		[Nullable(2)]
		protected PlayMontage_SetValue PocoInterface;

		// Token: 0x040075D0 RID: 30160
		private IActionMontage _ActionMontageCache;

		// Token: 0x040075D1 RID: 30161
		private bool _ActionMontageInited;
	}
}
