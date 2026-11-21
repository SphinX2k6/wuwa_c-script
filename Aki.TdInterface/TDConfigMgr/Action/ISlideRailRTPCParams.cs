using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020C0 RID: 8384
	public class ISlideRailRTPCParams
	{
		// Token: 0x0600B200 RID: 45568 RVA: 0x0018FF54 File Offset: 0x0018E154
		private ISlideRailRTPCParams_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlideRailRTPCParams 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlideRailRTPCParams_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlideRailRTPCParams_SetValue());
			}
			return result;
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x0018FF8C File Offset: 0x0018E18C
		public static ISlideRailRTPCParams Create([Nullable(2)] ISlideRailRTPCParams instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlideRailRTPCParams
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x0018FF9F File Offset: 0x0018E19F
		public static ISlideRailRTPCParams CreateFromSetValue([Nullable(2)] ISlideRailRTPCParams_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlideRailRTPCParams
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x0018FFB2 File Offset: 0x0018E1B2
		public ISlideRailRTPCParams_SetValue ToSetValue()
		{
			return new ISlideRailRTPCParams_SetValue
			{
				RTPCName = this.RTPCName
			};
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600B204 RID: 45572 RVA: 0x0018FFC5 File Offset: 0x0018E1C5
		// (set) Token: 0x0600B205 RID: 45573 RVA: 0x0018FFF0 File Offset: 0x0018E1F0
		public virtual string RTPCName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RTPCName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.RTPCName;
			}
			set
			{
				this.GetOrCreatePoco().RTPCName = value;
			}
		}

		// Token: 0x040069B2 RID: 27058
		[Nullable(2)]
		protected ISlideRailRTPCParams FbInstance;

		// Token: 0x040069B3 RID: 27059
		[Nullable(2)]
		protected ISlideRailRTPCParams_SetValue PocoInterface;
	}
}
