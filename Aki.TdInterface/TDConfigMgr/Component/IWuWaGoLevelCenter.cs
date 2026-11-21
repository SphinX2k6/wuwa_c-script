using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AC RID: 2220
	public class IWuWaGoLevelCenter : IWuWaGoEntityBase
	{
		// Token: 0x06002FD3 RID: 12243 RVA: 0x0007AFEC File Offset: 0x000791EC
		private IWuWaGoLevelCenter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWuWaGoLevelCenter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWuWaGoLevelCenter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWuWaGoLevelCenter_SetValue());
			}
			return result;
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x0007B024 File Offset: 0x00079224
		public static IWuWaGoLevelCenter Create([Nullable(2)] IWuWaGoLevelCenter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWuWaGoLevelCenter
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x0007B037 File Offset: 0x00079237
		public static IWuWaGoLevelCenter CreateFromSetValue([Nullable(2)] IWuWaGoLevelCenter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWuWaGoLevelCenter
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x0007B04A File Offset: 0x0007924A
		public new IWuWaGoLevelCenter_SetValue ToSetValue()
		{
			return new IWuWaGoLevelCenter_SetValue
			{
				Type = this.Type,
				LevelKey = this.LevelKey,
				LevelEntityIds = this.LevelEntityIds,
				EdActorPath = this.EdActorPath
			};
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x0007B081 File Offset: 0x00079281
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x0007B0AC File Offset: 0x000792AC
		public override EWuWaGoEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWuWaGoEntityType.LevelCenter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x0007B0BA File Offset: 0x000792BA
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x0007B0E5 File Offset: 0x000792E5
		public virtual string LevelKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.LevelKey;
			}
			set
			{
				this.GetOrCreatePoco().LevelKey = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x0007B0F3 File Offset: 0x000792F3
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x0007B11A File Offset: 0x0007931A
		public virtual List<int> LevelEntityIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelEntityIds;
				}
				IWuWaGoLevelCenter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LevelEntityIds;
			}
			set
			{
				this.GetOrCreatePoco().LevelEntityIds = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x0007B128 File Offset: 0x00079328
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x0007B13F File Offset: 0x0007933F
		[Nullable(2)]
		public virtual string EdActorPath
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdActorPath;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdActorPath = value;
			}
		}

		// Token: 0x04001F95 RID: 8085
		[Nullable(2)]
		protected new IWuWaGoLevelCenter FbInstance;

		// Token: 0x04001F96 RID: 8086
		[Nullable(2)]
		protected new IWuWaGoLevelCenter_SetValue PocoInterface;
	}
}
