using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000766 RID: 1894
	[NullableContext(1)]
	[Nullable(0)]
	public class IThrowDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x060028ED RID: 10477 RVA: 0x0006C37C File Offset: 0x0006A57C
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

		// Token: 0x060028EE RID: 10478 RVA: 0x0006C3B4 File Offset: 0x0006A5B4
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

		// Token: 0x060028EF RID: 10479 RVA: 0x0006C3C7 File Offset: 0x0006A5C7
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

		// Token: 0x060028F0 RID: 10480 RVA: 0x0006C3DA File Offset: 0x0006A5DA
		public new IThrowDestroyCondition_SetValue ToSetValue()
		{
			return new IThrowDestroyCondition_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x0006C3F9 File Offset: 0x0006A5F9
		// (set) Token: 0x060028F2 RID: 10482 RVA: 0x0006C424 File Offset: 0x0006A624
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

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060028F3 RID: 10483 RVA: 0x0006C432 File Offset: 0x0006A632
		// (set) Token: 0x060028F4 RID: 10484 RVA: 0x0006C461 File Offset: 0x0006A661
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

		// Token: 0x04001B81 RID: 7041
		[Nullable(2)]
		protected new IThrowDestroyCondition FbInstance;

		// Token: 0x04001B82 RID: 7042
		[Nullable(2)]
		protected new IThrowDestroyCondition_SetValue PocoInterface;
	}
}
