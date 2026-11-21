using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000569 RID: 1385
	public class IMonsterCommunicationGroupConfig
	{
		// Token: 0x06001C0E RID: 7182 RVA: 0x000514AC File Offset: 0x0004F6AC
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

		// Token: 0x06001C0F RID: 7183 RVA: 0x000514E4 File Offset: 0x0004F6E4
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

		// Token: 0x06001C10 RID: 7184 RVA: 0x000514F7 File Offset: 0x0004F6F7
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

		// Token: 0x06001C11 RID: 7185 RVA: 0x0005150A File Offset: 0x0004F70A
		public IMonsterCommunicationGroupConfig_SetValue ToSetValue()
		{
			return new IMonsterCommunicationGroupConfig_SetValue
			{
				GroupId = this.GroupId
			};
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001C12 RID: 7186 RVA: 0x0005151D File Offset: 0x0004F71D
		// (set) Token: 0x06001C13 RID: 7187 RVA: 0x00051548 File Offset: 0x0004F748
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

		// Token: 0x04001467 RID: 5223
		[Nullable(2)]
		protected IMonsterCommunicationGroupConfig FbInstance;

		// Token: 0x04001468 RID: 5224
		[Nullable(2)]
		protected IMonsterCommunicationGroupConfig_SetValue PocoInterface;
	}
}
