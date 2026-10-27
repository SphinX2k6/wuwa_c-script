using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000754 RID: 1876
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleControlDestroyCondition
	{
		// Token: 0x06002881 RID: 10369 RVA: 0x0006B3EC File Offset: 0x000695EC
		private ITeleControlDestroyCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleControlDestroyCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleControlDestroyCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleControlDestroyCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x0006B424 File Offset: 0x00069624
		public static ITeleControlDestroyCondition Create([Nullable(2)] ITeleControlDestroyCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlDestroyCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x0006B437 File Offset: 0x00069637
		public static ITeleControlDestroyCondition CreateFromSetValue([Nullable(2)] ITeleControlDestroyCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleControlDestroyCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x0006B44A File Offset: 0x0006964A
		public ITeleControlDestroyCondition_SetValue ToSetValue()
		{
			return new ITeleControlDestroyCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002885 RID: 10373 RVA: 0x0006B45D File Offset: 0x0006965D
		// (set) Token: 0x06002886 RID: 10374 RVA: 0x0006B488 File Offset: 0x00069688
		public virtual ETeleControlDestroyCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleControlDestroyCondition.LetGo;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001B3C RID: 6972
		[Nullable(2)]
		protected ITeleControlDestroyCondition FbInstance;

		// Token: 0x04001B3D RID: 6973
		[Nullable(2)]
		protected ITeleControlDestroyCondition_SetValue PocoInterface;
	}
}
