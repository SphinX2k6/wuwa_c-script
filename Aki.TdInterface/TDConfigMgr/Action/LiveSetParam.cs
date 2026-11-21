using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002324 RID: 8996
	public class LiveSetParam : ActionParams
	{
		// Token: 0x0600C3EA RID: 50154 RVA: 0x001C1BFC File Offset: 0x001BFDFC
		private LiveSetParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LiveSetParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LiveSetParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LiveSetParam_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3EB RID: 50155 RVA: 0x001C1C34 File Offset: 0x001BFE34
		public static LiveSetParam Create([Nullable(2)] LiveSetParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LiveSetParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3EC RID: 50156 RVA: 0x001C1C47 File Offset: 0x001BFE47
		public static LiveSetParam CreateFromSetValue([Nullable(2)] LiveSetParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LiveSetParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x001C1C5A File Offset: 0x001BFE5A
		public LiveSetParam_SetValue ToSetValue()
		{
			return new LiveSetParam_SetValue
			{
				Param = this.Param
			};
		}

		// Token: 0x17003B4F RID: 15183
		// (get) Token: 0x0600C3EE RID: 50158 RVA: 0x001C1C6D File Offset: 0x001BFE6D
		// (set) Token: 0x0600C3EF RID: 50159 RVA: 0x001C1C94 File Offset: 0x001BFE94
		public virtual ILiveParamConfig Param
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Param;
				}
				LiveSetParam_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Param;
			}
			set
			{
				this.GetOrCreatePoco().Param = value;
			}
		}

		// Token: 0x040074B6 RID: 29878
		[Nullable(2)]
		protected new LiveSetParam FbInstance;

		// Token: 0x040074B7 RID: 29879
		[Nullable(2)]
		protected LiveSetParam_SetValue PocoInterface;
	}
}
