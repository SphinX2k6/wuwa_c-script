using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000807 RID: 2055
	public class IThrowDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x06002C11 RID: 11281 RVA: 0x00073524 File Offset: 0x00071724
		private IThrowDestroyCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IThrowDestroyCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IThrowDestroyCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IThrowDestroyCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x0007355C File Offset: 0x0007175C
		public static IThrowDestroyCondition Create([Nullable(2)] IThrowDestroyCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IThrowDestroyCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x0007356F File Offset: 0x0007176F
		public static IThrowDestroyCondition CreateFromSetValue([Nullable(2)] IThrowDestroyCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IThrowDestroyCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x00073582 File Offset: 0x00071782
		public new IThrowDestroyCondition_SetValue ToSetValue()
		{
			return new IThrowDestroyCondition_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000735A1 File Offset: 0x000717A1
		// (set) Token: 0x06002C16 RID: 11286 RVA: 0x000735CC File Offset: 0x000717CC
		public override ETeleControlDestroyCondition Type
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

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000735DA File Offset: 0x000717DA
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x00073609 File Offset: 0x00071809
		public virtual float DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x04001D86 RID: 7558
		[Nullable(2)]
		protected new IThrowDestroyCondition FbInstance;

		// Token: 0x04001D87 RID: 7559
		[Nullable(2)]
		protected new IThrowDestroyCondition_SetValue PocoInterface;
	}
}
