using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F0D RID: 7949
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwordIntentTip : ICommonTipType
	{
		// Token: 0x0600AA02 RID: 43522 RVA: 0x0017EFF4 File Offset: 0x0017D1F4
		private ISwordIntentTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwordIntentTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwordIntentTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwordIntentTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x0017F02C File Offset: 0x0017D22C
		public static ISwordIntentTip Create([Nullable(2)] ISwordIntentTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwordIntentTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x0017F03F File Offset: 0x0017D23F
		public static ISwordIntentTip CreateFromSetValue([Nullable(2)] ISwordIntentTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwordIntentTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x0017F052 File Offset: 0x0017D252
		public new ISwordIntentTip_SetValue ToSetValue()
		{
			return new ISwordIntentTip_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600AA06 RID: 43526 RVA: 0x0017F065 File Offset: 0x0017D265
		// (set) Token: 0x0600AA07 RID: 43527 RVA: 0x0017F090 File Offset: 0x0017D290
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400650A RID: 25866
		[Nullable(2)]
		protected new ISwordIntentTip FbInstance;

		// Token: 0x0400650B RID: 25867
		[Nullable(2)]
		protected new ISwordIntentTip_SetValue PocoInterface;
	}
}
