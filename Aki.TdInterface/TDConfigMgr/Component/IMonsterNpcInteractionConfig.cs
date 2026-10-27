using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000508 RID: 1288
	[NullableContext(1)]
	[Nullable(0)]
	public class IMonsterNpcInteractionConfig
	{
		// Token: 0x06001A2A RID: 6698 RVA: 0x0004C960 File Offset: 0x0004AB60
		private IMonsterNpcInteractionConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMonsterNpcInteractionConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMonsterNpcInteractionConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMonsterNpcInteractionConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0004C998 File Offset: 0x0004AB98
		public static IMonsterNpcInteractionConfig Create([Nullable(2)] IMonsterNpcInteractionConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0004C9AB File Offset: 0x0004ABAB
		public static IMonsterNpcInteractionConfig CreateFromSetValue([Nullable(2)] IMonsterNpcInteractionConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMonsterNpcInteractionConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0004C9BE File Offset: 0x0004ABBE
		public IMonsterNpcInteractionConfig_SetValue ToSetValue()
		{
			return new IMonsterNpcInteractionConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x0004C9D1 File Offset: 0x0004ABD1
		// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0004C9FC File Offset: 0x0004ABFC
		public virtual EMonsterNpcInteractionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMonsterNpcInteractionType.WallRun;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001308 RID: 4872
		[Nullable(2)]
		protected IMonsterNpcInteractionConfig FbInstance;

		// Token: 0x04001309 RID: 4873
		[Nullable(2)]
		protected IMonsterNpcInteractionConfig_SetValue PocoInterface;
	}
}
