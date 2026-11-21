using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EE RID: 9198
	public class SendBattleTag : ActionParams
	{
		// Token: 0x0600C844 RID: 51268 RVA: 0x001CA050 File Offset: 0x001C8250
		private SendBattleTag_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SendBattleTag 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SendBattleTag_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SendBattleTag_SetValue());
			}
			return result;
		}

		// Token: 0x0600C845 RID: 51269 RVA: 0x001CA088 File Offset: 0x001C8288
		public static SendBattleTag Create([Nullable(2)] SendBattleTag instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SendBattleTag
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C846 RID: 51270 RVA: 0x001CA09B File Offset: 0x001C829B
		public static SendBattleTag CreateFromSetValue([Nullable(2)] SendBattleTag_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SendBattleTag
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C847 RID: 51271 RVA: 0x001CA0AE File Offset: 0x001C82AE
		public SendBattleTag_SetValue ToSetValue()
		{
			return new SendBattleTag_SetValue
			{
				TagConfigId = this.TagConfigId
			};
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600C848 RID: 51272 RVA: 0x001CA0C1 File Offset: 0x001C82C1
		// (set) Token: 0x0600C849 RID: 51273 RVA: 0x001CA0EC File Offset: 0x001C82EC
		public virtual int TagConfigId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TagConfigId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TagConfigId;
			}
			set
			{
				this.GetOrCreatePoco().TagConfigId = value;
			}
		}

		// Token: 0x040076DE RID: 30430
		[Nullable(2)]
		protected new SendBattleTag FbInstance;

		// Token: 0x040076DF RID: 30431
		[Nullable(2)]
		protected SendBattleTag_SetValue PocoInterface;
	}
}
