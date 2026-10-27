using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFF RID: 7935
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchEffectState : PlayEffect2
	{
		// Token: 0x0600A9AE RID: 43438 RVA: 0x0017E6F4 File Offset: 0x0017C8F4
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

		// Token: 0x0600A9AF RID: 43439 RVA: 0x0017E72C File Offset: 0x0017C92C
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

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x0017E73F File Offset: 0x0017C93F
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

		// Token: 0x0600A9B1 RID: 43441 RVA: 0x0017E752 File Offset: 0x0017C952
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

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600A9B2 RID: 43442 RVA: 0x0017E789 File Offset: 0x0017C989
		// (set) Token: 0x0600A9B3 RID: 43443 RVA: 0x0017E7B4 File Offset: 0x0017C9B4
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

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600A9B4 RID: 43444 RVA: 0x0017E7C2 File Offset: 0x0017C9C2
		// (set) Token: 0x0600A9B5 RID: 43445 RVA: 0x0017E7ED File Offset: 0x0017C9ED
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

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600A9B6 RID: 43446 RVA: 0x0017E7FB File Offset: 0x0017C9FB
		// (set) Token: 0x0600A9B7 RID: 43447 RVA: 0x0017E822 File Offset: 0x0017CA22
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

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600A9B8 RID: 43448 RVA: 0x0017E830 File Offset: 0x0017CA30
		// (set) Token: 0x0600A9B9 RID: 43449 RVA: 0x0017E85B File Offset: 0x0017CA5B
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

		// Token: 0x040064E7 RID: 25831
		[Nullable(2)]
		protected new ISwitchEffectState FbInstance;

		// Token: 0x040064E8 RID: 25832
		[Nullable(2)]
		protected new ISwitchEffectState_SetValue PocoInterface;
	}
}
