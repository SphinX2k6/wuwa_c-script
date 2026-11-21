using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E63 RID: 7779
	public class INpcGroupPerformInitiatorType
	{
		// Token: 0x0600A563 RID: 42339 RVA: 0x00179488 File Offset: 0x00177688
		private INpcGroupPerformInitiatorType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcGroupPerformInitiatorType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcGroupPerformInitiatorType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcGroupPerformInitiatorType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A564 RID: 42340 RVA: 0x001794C0 File Offset: 0x001776C0
		public static INpcGroupPerformInitiatorType Create([Nullable(2)] INpcGroupPerformInitiatorType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcGroupPerformInitiatorType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A565 RID: 42341 RVA: 0x001794D3 File Offset: 0x001776D3
		public static INpcGroupPerformInitiatorType CreateFromSetValue([Nullable(2)] INpcGroupPerformInitiatorType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcGroupPerformInitiatorType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A566 RID: 42342 RVA: 0x001794E6 File Offset: 0x001776E6
		public INpcGroupPerformInitiatorType_SetValue ToSetValue()
		{
			return new INpcGroupPerformInitiatorType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600A567 RID: 42343 RVA: 0x001794F9 File Offset: 0x001776F9
		// (set) Token: 0x0600A568 RID: 42344 RVA: 0x00179524 File Offset: 0x00177724
		public virtual ENpcGroupPerformInitiatorType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformInitiatorType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063E6 RID: 25574
		[Nullable(2)]
		protected INpcGroupPerformInitiatorType FbInstance;

		// Token: 0x040063E7 RID: 25575
		[Nullable(2)]
		protected INpcGroupPerformInitiatorType_SetValue PocoInterface;
	}
}
