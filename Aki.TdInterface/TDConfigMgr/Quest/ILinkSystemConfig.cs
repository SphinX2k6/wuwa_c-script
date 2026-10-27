using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF9 RID: 4089
	[NullableContext(1)]
	[Nullable(0)]
	public class ILinkSystemConfig : IEnableSystemConfig
	{
		// Token: 0x06005AF6 RID: 23286 RVA: 0x000DCB0C File Offset: 0x000DAD0C
		private ILinkSystemConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILinkSystemConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILinkSystemConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILinkSystemConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06005AF7 RID: 23287 RVA: 0x000DCB44 File Offset: 0x000DAD44
		public static ILinkSystemConfig Create([Nullable(2)] ILinkSystemConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILinkSystemConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005AF8 RID: 23288 RVA: 0x000DCB57 File Offset: 0x000DAD57
		public static ILinkSystemConfig CreateFromSetValue([Nullable(2)] ILinkSystemConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILinkSystemConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005AF9 RID: 23289 RVA: 0x000DCB6A File Offset: 0x000DAD6A
		public new ILinkSystemConfig_SetValue ToSetValue()
		{
			return new ILinkSystemConfig_SetValue
			{
				Type = this.Type,
				LinkDataId = this.LinkDataId
			};
		}

		// Token: 0x17001E07 RID: 7687
		// (get) Token: 0x06005AFA RID: 23290 RVA: 0x000DCB89 File Offset: 0x000DAD89
		// (set) Token: 0x06005AFB RID: 23291 RVA: 0x000DCBB4 File Offset: 0x000DADB4
		public override EEnableSystemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSystemType.GradingSystem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E08 RID: 7688
		// (get) Token: 0x06005AFC RID: 23292 RVA: 0x000DCBC2 File Offset: 0x000DADC2
		// (set) Token: 0x06005AFD RID: 23293 RVA: 0x000DCBED File Offset: 0x000DADED
		public virtual int LinkDataId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LinkDataId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.LinkDataId;
			}
			set
			{
				this.GetOrCreatePoco().LinkDataId = value;
			}
		}

		// Token: 0x040036BA RID: 14010
		[Nullable(2)]
		protected new ILinkSystemConfig FbInstance;

		// Token: 0x040036BB RID: 14011
		[Nullable(2)]
		protected new ILinkSystemConfig_SetValue PocoInterface;
	}
}
