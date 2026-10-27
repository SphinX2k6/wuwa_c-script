using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C68 RID: 7272
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcFollowConfig
	{
		// Token: 0x06009BF9 RID: 39929 RVA: 0x00165F0C File Offset: 0x0016410C
		private INpcFollowConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcFollowConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcFollowConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcFollowConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009BFA RID: 39930 RVA: 0x00165F44 File Offset: 0x00164144
		public static INpcFollowConfig Create([Nullable(2)] INpcFollowConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcFollowConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BFB RID: 39931 RVA: 0x00165F57 File Offset: 0x00164157
		public static INpcFollowConfig CreateFromSetValue([Nullable(2)] INpcFollowConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcFollowConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BFC RID: 39932 RVA: 0x00165F6A File Offset: 0x0016416A
		public INpcFollowConfig_SetValue ToSetValue()
		{
			return new INpcFollowConfig_SetValue
			{
				PerformerWhenEnter = this.PerformerWhenEnter,
				PerformerWhenExit = this.PerformerWhenExit
			};
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x06009BFD RID: 39933 RVA: 0x00165F8C File Offset: 0x0016418C
		// (set) Token: 0x06009BFE RID: 39934 RVA: 0x00165FED File Offset: 0x001641ED
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenEnter
		{
			get
			{
				if (this._PerformerWhenEnterInited)
				{
					return this._PerformerWhenEnterCache;
				}
				this._PerformerWhenEnterInited = true;
				if (this.FbInstance != null)
				{
					this._PerformerWhenEnterCache = IPerformerRangeBoundaryActionTrigger.Create(this.FbInstance.PerformerWhenEnter);
				}
				else
				{
					INpcFollowConfig_SetValue pocoInterface = this.PocoInterface;
					this._PerformerWhenEnterCache = ((pocoInterface != null) ? pocoInterface.PerformerWhenEnter : null);
				}
				return this._PerformerWhenEnterCache;
			}
			set
			{
				this.GetOrCreatePoco().PerformerWhenEnter = value;
				this._PerformerWhenEnterInited = false;
			}
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x06009BFF RID: 39935 RVA: 0x00166004 File Offset: 0x00164204
		// (set) Token: 0x06009C00 RID: 39936 RVA: 0x00166065 File Offset: 0x00164265
		public virtual IPerformerRangeBoundaryActionTrigger PerformerWhenExit
		{
			get
			{
				if (this._PerformerWhenExitInited)
				{
					return this._PerformerWhenExitCache;
				}
				this._PerformerWhenExitInited = true;
				if (this.FbInstance != null)
				{
					this._PerformerWhenExitCache = IPerformerRangeBoundaryActionTrigger.Create(this.FbInstance.PerformerWhenExit);
				}
				else
				{
					INpcFollowConfig_SetValue pocoInterface = this.PocoInterface;
					this._PerformerWhenExitCache = ((pocoInterface != null) ? pocoInterface.PerformerWhenExit : null);
				}
				return this._PerformerWhenExitCache;
			}
			set
			{
				this.GetOrCreatePoco().PerformerWhenExit = value;
				this._PerformerWhenExitInited = false;
			}
		}

		// Token: 0x04005EA4 RID: 24228
		[Nullable(2)]
		protected INpcFollowConfig FbInstance;

		// Token: 0x04005EA5 RID: 24229
		[Nullable(2)]
		protected INpcFollowConfig_SetValue PocoInterface;

		// Token: 0x04005EA6 RID: 24230
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenEnterCache;

		// Token: 0x04005EA7 RID: 24231
		private bool _PerformerWhenEnterInited;

		// Token: 0x04005EA8 RID: 24232
		private IPerformerRangeBoundaryActionTrigger _PerformerWhenExitCache;

		// Token: 0x04005EA9 RID: 24233
		private bool _PerformerWhenExitInited;
	}
}
