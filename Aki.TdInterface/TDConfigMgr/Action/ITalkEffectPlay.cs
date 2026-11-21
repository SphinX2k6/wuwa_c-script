using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215F RID: 8543
	public class ITalkEffectPlay : ITalkEffectActionType
	{
		// Token: 0x0600B54E RID: 46414 RVA: 0x00195D68 File Offset: 0x00193F68
		private ITalkEffectPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectPlay_SetValue());
			}
			return result;
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x00195DA0 File Offset: 0x00193FA0
		public static ITalkEffectPlay Create([Nullable(2)] ITalkEffectPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B550 RID: 46416 RVA: 0x00195DB3 File Offset: 0x00193FB3
		public static ITalkEffectPlay CreateFromSetValue([Nullable(2)] ITalkEffectPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x00195DC8 File Offset: 0x00193FC8
		public new ITalkEffectPlay_SetValue ToSetValue()
		{
			return new ITalkEffectPlay_SetValue
			{
				Type = this.Type,
				Effect = this.Effect,
				KeepPlay = this.KeepPlay,
				EffectKey = this.EffectKey,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600B552 RID: 46418 RVA: 0x00195E16 File Offset: 0x00194016
		// (set) Token: 0x0600B553 RID: 46419 RVA: 0x00195E41 File Offset: 0x00194041
		public override ETalkEffectActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectActionType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600B554 RID: 46420 RVA: 0x00195E50 File Offset: 0x00194050
		// (set) Token: 0x0600B555 RID: 46421 RVA: 0x00195EB1 File Offset: 0x001940B1
		public virtual ITalkCommonEffect Effect
		{
			get
			{
				if (this._EffectInited)
				{
					return this._EffectCache;
				}
				this._EffectInited = true;
				if (this.FbInstance != null)
				{
					this._EffectCache = ITalkCommonEffect.Create(this.FbInstance.Effect);
				}
				else
				{
					ITalkEffectPlay_SetValue pocoInterface = this.PocoInterface;
					this._EffectCache = ((pocoInterface != null) ? pocoInterface.Effect : null);
				}
				return this._EffectCache;
			}
			set
			{
				this.GetOrCreatePoco().Effect = value;
				this._EffectInited = false;
			}
		}

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600B556 RID: 46422 RVA: 0x00195EC8 File Offset: 0x001940C8
		// (set) Token: 0x0600B557 RID: 46423 RVA: 0x00195F02 File Offset: 0x00194102
		public virtual bool? KeepPlay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepPlay;
				}
				ITalkEffectPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepPlay;
			}
			set
			{
				this.GetOrCreatePoco().KeepPlay = value;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600B558 RID: 46424 RVA: 0x00195F10 File Offset: 0x00194110
		// (set) Token: 0x0600B559 RID: 46425 RVA: 0x00195F37 File Offset: 0x00194137
		[Nullable(2)]
		public virtual string EffectKey
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectKey;
				}
				ITalkEffectPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectKey;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EffectKey = value;
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600B55A RID: 46426 RVA: 0x00195F48 File Offset: 0x00194148
		// (set) Token: 0x0600B55B RID: 46427 RVA: 0x00195F82 File Offset: 0x00194182
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ITalkEffectPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x04006B30 RID: 27440
		[Nullable(2)]
		protected new ITalkEffectPlay FbInstance;

		// Token: 0x04006B31 RID: 27441
		[Nullable(2)]
		protected new ITalkEffectPlay_SetValue PocoInterface;

		// Token: 0x04006B32 RID: 27442
		private ITalkCommonEffect _EffectCache;

		// Token: 0x04006B33 RID: 27443
		private bool _EffectInited;
	}
}
