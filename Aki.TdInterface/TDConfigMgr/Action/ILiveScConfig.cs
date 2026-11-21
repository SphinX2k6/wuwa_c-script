using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D69 RID: 7529
	public class ILiveScConfig
	{
		// Token: 0x06009FE1 RID: 40929 RVA: 0x0016EF08 File Offset: 0x0016D108
		private ILiveScConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILiveScConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILiveScConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILiveScConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x0016EF40 File Offset: 0x0016D140
		public static ILiveScConfig Create([Nullable(2)] ILiveScConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILiveScConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x0016EF53 File Offset: 0x0016D153
		public static ILiveScConfig CreateFromSetValue([Nullable(2)] ILiveScConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILiveScConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x0016EF66 File Offset: 0x0016D166
		public ILiveScConfig_SetValue ToSetValue()
		{
			return new ILiveScConfig_SetValue
			{
				ScId = this.ScId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x06009FE5 RID: 40933 RVA: 0x0016EF85 File Offset: 0x0016D185
		// (set) Token: 0x06009FE6 RID: 40934 RVA: 0x0016EFB0 File Offset: 0x0016D1B0
		public virtual int ScId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ScId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ScId;
			}
			set
			{
				this.GetOrCreatePoco().ScId = value;
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x06009FE7 RID: 40935 RVA: 0x0016EFBE File Offset: 0x0016D1BE
		// (set) Token: 0x06009FE8 RID: 40936 RVA: 0x0016EFED File Offset: 0x0016D1ED
		public virtual float DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x04006140 RID: 24896
		[Nullable(2)]
		protected ILiveScConfig FbInstance;

		// Token: 0x04006141 RID: 24897
		[Nullable(2)]
		protected ILiveScConfig_SetValue PocoInterface;
	}
}
