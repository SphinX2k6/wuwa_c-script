using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002146 RID: 8518
	public class ISwordIntentTip : ICommonTipType
	{
		// Token: 0x0600B4D4 RID: 46292 RVA: 0x00194FEC File Offset: 0x001931EC
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

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x00195024 File Offset: 0x00193224
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

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x00195037 File Offset: 0x00193237
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

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x0019504A File Offset: 0x0019324A
		public new ISwordIntentTip_SetValue ToSetValue()
		{
			return new ISwordIntentTip_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600B4D8 RID: 46296 RVA: 0x0019505D File Offset: 0x0019325D
		// (set) Token: 0x0600B4D9 RID: 46297 RVA: 0x00195088 File Offset: 0x00193288
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

		// Token: 0x04006AF9 RID: 27385
		[Nullable(2)]
		protected new ISwordIntentTip FbInstance;

		// Token: 0x04006AFA RID: 27386
		[Nullable(2)]
		protected new ISwordIntentTip_SetValue PocoInterface;
	}
}
