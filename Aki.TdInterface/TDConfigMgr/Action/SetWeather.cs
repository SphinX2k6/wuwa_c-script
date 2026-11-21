using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245A RID: 9306
	public class SetWeather : ActionParams
	{
		// Token: 0x0600CA89 RID: 51849 RVA: 0x001CE728 File Offset: 0x001CC928
		private SetWeather_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetWeather 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetWeather_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetWeather_SetValue());
			}
			return result;
		}

		// Token: 0x0600CA8A RID: 51850 RVA: 0x001CE760 File Offset: 0x001CC960
		public static SetWeather Create([Nullable(2)] SetWeather instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetWeather
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x001CE773 File Offset: 0x001CC973
		public static SetWeather CreateFromSetValue([Nullable(2)] SetWeather_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetWeather
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x001CE786 File Offset: 0x001CC986
		public SetWeather_SetValue ToSetValue()
		{
			return new SetWeather_SetValue
			{
				WeatherId = this.WeatherId,
				AreaIds = this.AreaIds
			};
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600CA8D RID: 51853 RVA: 0x001CE7A5 File Offset: 0x001CC9A5
		// (set) Token: 0x0600CA8E RID: 51854 RVA: 0x001CE7D0 File Offset: 0x001CC9D0
		public virtual int WeatherId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WeatherId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.WeatherId;
			}
			set
			{
				this.GetOrCreatePoco().WeatherId = value;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600CA8F RID: 51855 RVA: 0x001CE7DE File Offset: 0x001CC9DE
		// (set) Token: 0x0600CA90 RID: 51856 RVA: 0x001CE805 File Offset: 0x001CCA05
		[Nullable(2)]
		public virtual List<int> AreaIds
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaIds;
				}
				SetWeather_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AreaIds;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AreaIds = value;
			}
		}

		// Token: 0x04007818 RID: 30744
		[Nullable(2)]
		protected new SetWeather FbInstance;

		// Token: 0x04007819 RID: 30745
		[Nullable(2)]
		protected SetWeather_SetValue PocoInterface;
	}
}
