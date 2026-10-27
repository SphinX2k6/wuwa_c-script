using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000809 RID: 2057
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoLevelCenter : IWuWaGoEntityBase
	{
		// Token: 0x06002CA3 RID: 11427 RVA: 0x00073C88 File Offset: 0x00071E88
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

		// Token: 0x06002CA4 RID: 11428 RVA: 0x00073CC0 File Offset: 0x00071EC0
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

		// Token: 0x06002CA5 RID: 11429 RVA: 0x00073CD3 File Offset: 0x00071ED3
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

		// Token: 0x06002CA6 RID: 11430 RVA: 0x00073CE6 File Offset: 0x00071EE6
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

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x00073D1D File Offset: 0x00071F1D
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x00073D48 File Offset: 0x00071F48
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

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x00073D56 File Offset: 0x00071F56
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x00073D81 File Offset: 0x00071F81
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

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x00073D8F File Offset: 0x00071F8F
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x00073DB6 File Offset: 0x00071FB6
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

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x00073DC4 File Offset: 0x00071FC4
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x00073DDB File Offset: 0x00071FDB
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

		// Token: 0x04001D89 RID: 7561
		[Nullable(2)]
		protected new IWuWaGoLevelCenter FbInstance;

		// Token: 0x04001D8A RID: 7562
		[Nullable(2)]
		protected new IWuWaGoLevelCenter_SetValue PocoInterface;
	}
}
