using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F14 RID: 3860
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonEventEntityStateChange : IEventTypeConfig
	{
		// Token: 0x0600555A RID: 21850 RVA: 0x000D13C4 File Offset: 0x000CF5C4
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

		// Token: 0x0600555B RID: 21851 RVA: 0x000D13FC File Offset: 0x000CF5FC
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

		// Token: 0x0600555C RID: 21852 RVA: 0x000D140F File Offset: 0x000CF60F
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

		// Token: 0x0600555D RID: 21853 RVA: 0x000D1422 File Offset: 0x000CF622
		public new ICommonEventEntityStateChange_SetValue ToSetValue()
		{
			return new ICommonEventEntityStateChange_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x0600555E RID: 21854 RVA: 0x000D1441 File Offset: 0x000CF641
		// (set) Token: 0x0600555F RID: 21855 RVA: 0x000D146C File Offset: 0x000CF66C
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

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06005560 RID: 21856 RVA: 0x000D147A File Offset: 0x000CF67A
		// (set) Token: 0x06005561 RID: 21857 RVA: 0x000D14A5 File Offset: 0x000CF6A5
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

		// Token: 0x040033A7 RID: 13223
		[Nullable(2)]
		protected new ICommonEventEntityStateChange FbInstance;

		// Token: 0x040033A8 RID: 13224
		[Nullable(2)]
		protected new ICommonEventEntityStateChange_SetValue PocoInterface;
	}
}
