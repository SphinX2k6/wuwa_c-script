using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000502 RID: 1282
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterCommunicationGroupConfig
	{
		// Token: 0x06001A12 RID: 6674 RVA: 0x0004C6F0 File Offset: 0x0004A8F0
		private IMonsterCommunicationGroupConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterCommunicationGroupConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterCommunicationGroupConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterCommunicationGroupConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0004C728 File Offset: 0x0004A928
		public static IMonsterCommunicationGroupConfig Create([Nullable(2)] IMonsterCommunicationGroupConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterCommunicationGroupConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0004C73B File Offset: 0x0004A93B
		public static IMonsterCommunicationGroupConfig CreateFromSetValue([Nullable(2)] IMonsterCommunicationGroupConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterCommunicationGroupConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0004C74E File Offset: 0x0004A94E
		public IMonsterCommunicationGroupConfig_SetValue ToSetValue()
		{
			return new IMonsterCommunicationGroupConfig_SetValue
			{
				GroupId = this.GroupId
			};
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x0004C761 File Offset: 0x0004A961
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0004C78C File Offset: 0x0004A98C
		public virtual int GroupId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GroupId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.GroupId;
			}
			set
			{
				this.GetOrCreatePoco().GroupId = value;
			}
		}

		// Token: 0x040012FD RID: 4861
		[Nullable(2)]
		protected IMonsterCommunicationGroupConfig FbInstance;

		// Token: 0x040012FE RID: 4862
		[Nullable(2)]
		protected IMonsterCommunicationGroupConfig_SetValue PocoInterface;
	}
}
