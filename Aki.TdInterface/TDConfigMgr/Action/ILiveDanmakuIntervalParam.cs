using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4B RID: 7499
	public class ILiveDanmakuIntervalParam : ILiveParamConfig
	{
		// Token: 0x06009F3B RID: 40763 RVA: 0x0016DCB8 File Offset: 0x0016BEB8
		private ILiveDanmakuIntervalParam_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveDanmakuIntervalParam 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveDanmakuIntervalParam_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveDanmakuIntervalParam_SetValue());
			}
			return result;
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x0016DCF0 File Offset: 0x0016BEF0
		public static ILiveDanmakuIntervalParam Create([Nullable(2)] ILiveDanmakuIntervalParam instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveDanmakuIntervalParam
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x0016DD03 File Offset: 0x0016BF03
		public static ILiveDanmakuIntervalParam CreateFromSetValue([Nullable(2)] ILiveDanmakuIntervalParam_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveDanmakuIntervalParam
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x0016DD16 File Offset: 0x0016BF16
		public new ILiveDanmakuIntervalParam_SetValue ToSetValue()
		{
			return new ILiveDanmakuIntervalParam_SetValue
			{
				Type = this.Type,
				SendInterval = this.SendInterval
			};
		}

		// Token: 0x170031BB RID: 12731
		// (get) Token: 0x06009F3F RID: 40767 RVA: 0x0016DD35 File Offset: 0x0016BF35
		// (set) Token: 0x06009F40 RID: 40768 RVA: 0x0016DD60 File Offset: 0x0016BF60
		public override ELiveParamType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELiveParamType.Heat;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031BC RID: 12732
		// (get) Token: 0x06009F41 RID: 40769 RVA: 0x0016DD6E File Offset: 0x0016BF6E
		// (set) Token: 0x06009F42 RID: 40770 RVA: 0x0016DD9D File Offset: 0x0016BF9D
		public virtual float SendInterval
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SendInterval;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.SendInterval;
			}
			set
			{
				this.GetOrCreatePoco().SendInterval = value;
			}
		}

		// Token: 0x040060F8 RID: 24824
		[Nullable(2)]
		protected new ILiveDanmakuIntervalParam FbInstance;

		// Token: 0x040060F9 RID: 24825
		[Nullable(2)]
		protected new ILiveDanmakuIntervalParam_SetValue PocoInterface;
	}
}
