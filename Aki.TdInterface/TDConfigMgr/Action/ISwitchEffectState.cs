using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002138 RID: 8504
	public class ISwitchEffectState : PlayEffect2
	{
		// Token: 0x0600B480 RID: 46208 RVA: 0x001946EC File Offset: 0x001928EC
		private ISwitchEffectState_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchEffectState 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchEffectState_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchEffectState_SetValue());
			}
			return result;
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x00194724 File Offset: 0x00192924
		public static ISwitchEffectState Create([Nullable(2)] ISwitchEffectState instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchEffectState
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x00194737 File Offset: 0x00192937
		public static ISwitchEffectState CreateFromSetValue([Nullable(2)] ISwitchEffectState_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchEffectState
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x0019474A File Offset: 0x0019294A
		public new ISwitchEffectState_SetValue ToSetValue()
		{
			return new ISwitchEffectState_SetValue
			{
				Type = this.Type,
				Path = this.Path,
				EffectType = this.EffectType,
				TargetStateIndex = this.TargetStateIndex
			};
		}

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600B484 RID: 46212 RVA: 0x00194781 File Offset: 0x00192981
		// (set) Token: 0x0600B485 RID: 46213 RVA: 0x001947AC File Offset: 0x001929AC
		public override EEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600B486 RID: 46214 RVA: 0x001947BA File Offset: 0x001929BA
		// (set) Token: 0x0600B487 RID: 46215 RVA: 0x001947E5 File Offset: 0x001929E5
		public override string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600B488 RID: 46216 RVA: 0x001947F3 File Offset: 0x001929F3
		// (set) Token: 0x0600B489 RID: 46217 RVA: 0x0019481A File Offset: 0x00192A1A
		public virtual ISwitchEffectStateEffectBase EffectType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectType;
				}
				ISwitchEffectState_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectType;
			}
			set
			{
				this.GetOrCreatePoco().EffectType = value;
			}
		}

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600B48A RID: 46218 RVA: 0x00194828 File Offset: 0x00192A28
		// (set) Token: 0x0600B48B RID: 46219 RVA: 0x00194853 File Offset: 0x00192A53
		public virtual int TargetStateIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetStateIndex;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetStateIndex;
			}
			set
			{
				this.GetOrCreatePoco().TargetStateIndex = value;
			}
		}

		// Token: 0x04006AD6 RID: 27350
		[Nullable(2)]
		protected new ISwitchEffectState FbInstance;

		// Token: 0x04006AD7 RID: 27351
		[Nullable(2)]
		protected new ISwitchEffectState_SetValue PocoInterface;
	}
}
