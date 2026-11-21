using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002243 RID: 8771
	public class ITriggeredEntity : ITargetEntityType
	{
		// Token: 0x0600BF2A RID: 48938 RVA: 0x001B93F4 File Offset: 0x001B75F4
		private ITriggeredEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITriggeredEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITriggeredEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITriggeredEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600BF2B RID: 48939 RVA: 0x001B942C File Offset: 0x001B762C
		public static ITriggeredEntity Create([Nullable(2)] ITriggeredEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggeredEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x001B943F File Offset: 0x001B763F
		public static ITriggeredEntity CreateFromSetValue([Nullable(2)] ITriggeredEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITriggeredEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x001B9452 File Offset: 0x001B7652
		public new ITriggeredEntity_SetValue ToSetValue()
		{
			return new ITriggeredEntity_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A40 RID: 14912
		// (get) Token: 0x0600BF2E RID: 48942 RVA: 0x001B9465 File Offset: 0x001B7665
		// (set) Token: 0x0600BF2F RID: 48943 RVA: 0x001B9490 File Offset: 0x001B7690
		public override ETargetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETargetEntityType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007293 RID: 29331
		[Nullable(2)]
		protected new ITriggeredEntity FbInstance;

		// Token: 0x04007294 RID: 29332
		[Nullable(2)]
		protected new ITriggeredEntity_SetValue PocoInterface;
	}
}
