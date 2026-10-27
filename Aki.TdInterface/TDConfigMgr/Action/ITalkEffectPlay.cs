using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F26 RID: 7974
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkEffectPlay : ITalkEffectActionType
	{
		// Token: 0x0600AA7C RID: 43644 RVA: 0x0017FD70 File Offset: 0x0017DF70
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

		// Token: 0x0600AA7D RID: 43645 RVA: 0x0017FDA8 File Offset: 0x0017DFA8
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

		// Token: 0x0600AA7E RID: 43646 RVA: 0x0017FDBB File Offset: 0x0017DFBB
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

		// Token: 0x0600AA7F RID: 43647 RVA: 0x0017FDD0 File Offset: 0x0017DFD0
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

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600AA80 RID: 43648 RVA: 0x0017FE1E File Offset: 0x0017E01E
		// (set) Token: 0x0600AA81 RID: 43649 RVA: 0x0017FE49 File Offset: 0x0017E049
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

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600AA82 RID: 43650 RVA: 0x0017FE58 File Offset: 0x0017E058
		// (set) Token: 0x0600AA83 RID: 43651 RVA: 0x0017FEB9 File Offset: 0x0017E0B9
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

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600AA84 RID: 43652 RVA: 0x0017FED0 File Offset: 0x0017E0D0
		// (set) Token: 0x0600AA85 RID: 43653 RVA: 0x0017FF0A File Offset: 0x0017E10A
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

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600AA86 RID: 43654 RVA: 0x0017FF18 File Offset: 0x0017E118
		// (set) Token: 0x0600AA87 RID: 43655 RVA: 0x0017FF3F File Offset: 0x0017E13F
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

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600AA88 RID: 43656 RVA: 0x0017FF50 File Offset: 0x0017E150
		// (set) Token: 0x0600AA89 RID: 43657 RVA: 0x0017FF8A File Offset: 0x0017E18A
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

		// Token: 0x04006541 RID: 25921
		[Nullable(2)]
		protected new ITalkEffectPlay FbInstance;

		// Token: 0x04006542 RID: 25922
		[Nullable(2)]
		protected new ITalkEffectPlay_SetValue PocoInterface;

		// Token: 0x04006543 RID: 25923
		private ITalkCommonEffect _EffectCache;

		// Token: 0x04006544 RID: 25924
		private bool _EffectInited;
	}
}
