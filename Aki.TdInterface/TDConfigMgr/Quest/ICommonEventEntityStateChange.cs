using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200102A RID: 4138
	public class ICommonEventEntityStateChange : IEventTypeConfig
	{
		// Token: 0x06005AD6 RID: 23254 RVA: 0x000DD56C File Offset: 0x000DB76C
		private ICommonEventEntityStateChange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonEventEntityStateChange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonEventEntityStateChange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonEventEntityStateChange_SetValue());
			}
			return result;
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x000DD5A4 File Offset: 0x000DB7A4
		public static ICommonEventEntityStateChange Create([Nullable(2)] ICommonEventEntityStateChange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonEventEntityStateChange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x000DD5B7 File Offset: 0x000DB7B7
		public static ICommonEventEntityStateChange CreateFromSetValue([Nullable(2)] ICommonEventEntityStateChange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonEventEntityStateChange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x000DD5CA File Offset: 0x000DB7CA
		public new ICommonEventEntityStateChange_SetValue ToSetValue()
		{
			return new ICommonEventEntityStateChange_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x000DD5E9 File Offset: 0x000DB7E9
		// (set) Token: 0x06005ADB RID: 23259 RVA: 0x000DD614 File Offset: 0x000DB814
		public override ECommonEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonEventType.VarValueChange;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x000DD622 File Offset: 0x000DB822
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x000DD64D File Offset: 0x000DB84D
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040036B4 RID: 14004
		[Nullable(2)]
		protected new ICommonEventEntityStateChange FbInstance;

		// Token: 0x040036B5 RID: 14005
		[Nullable(2)]
		protected new ICommonEventEntityStateChange_SetValue PocoInterface;
	}
}
