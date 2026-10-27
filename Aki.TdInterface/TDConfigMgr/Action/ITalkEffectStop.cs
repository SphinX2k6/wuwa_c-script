using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F28 RID: 7976
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkEffectStop : ITalkEffectActionType
	{
		// Token: 0x0600AA8C RID: 43660 RVA: 0x0017FFA8 File Offset: 0x0017E1A8
		private ITalkEffectStop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectStop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectStop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectStop_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA8D RID: 43661 RVA: 0x0017FFE0 File Offset: 0x0017E1E0
		public static ITalkEffectStop Create([Nullable(2)] ITalkEffectStop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectStop
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA8E RID: 43662 RVA: 0x0017FFF3 File Offset: 0x0017E1F3
		public static ITalkEffectStop CreateFromSetValue([Nullable(2)] ITalkEffectStop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectStop
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA8F RID: 43663 RVA: 0x00180006 File Offset: 0x0017E206
		public new ITalkEffectStop_SetValue ToSetValue()
		{
			return new ITalkEffectStop_SetValue
			{
				Type = this.Type,
				EffectKeys = this.EffectKeys,
				DelayTime = this.DelayTime,
				ImmediatelyDestroy = this.ImmediatelyDestroy
			};
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600AA90 RID: 43664 RVA: 0x0018003D File Offset: 0x0017E23D
		// (set) Token: 0x0600AA91 RID: 43665 RVA: 0x00180068 File Offset: 0x0017E268
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

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600AA92 RID: 43666 RVA: 0x00180076 File Offset: 0x0017E276
		// (set) Token: 0x0600AA93 RID: 43667 RVA: 0x0018009D File Offset: 0x0017E29D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<string> EffectKeys
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EffectKeys;
				}
				ITalkEffectStop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EffectKeys;
			}
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
				this.GetOrCreatePoco().EffectKeys = value;
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x001800AC File Offset: 0x0017E2AC
		// (set) Token: 0x0600AA95 RID: 43669 RVA: 0x001800E6 File Offset: 0x0017E2E6
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				ITalkEffectStop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600AA96 RID: 43670 RVA: 0x001800F4 File Offset: 0x0017E2F4
		// (set) Token: 0x0600AA97 RID: 43671 RVA: 0x0018012E File Offset: 0x0017E32E
		public virtual bool? ImmediatelyDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImmediatelyDestroy;
				}
				ITalkEffectStop_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ImmediatelyDestroy;
			}
			set
			{
				this.GetOrCreatePoco().ImmediatelyDestroy = value;
			}
		}

		// Token: 0x0400654A RID: 25930
		[Nullable(2)]
		protected new ITalkEffectStop FbInstance;

		// Token: 0x0400654B RID: 25931
		[Nullable(2)]
		protected new ITalkEffectStop_SetValue PocoInterface;
	}
}
