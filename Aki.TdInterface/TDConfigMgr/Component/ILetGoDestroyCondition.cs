using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000507 RID: 1287
	public class ILetGoDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x060019CE RID: 6606 RVA: 0x0004C7B4 File Offset: 0x0004A9B4
		private ILetGoDestroyCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILetGoDestroyCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILetGoDestroyCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILetGoDestroyCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0004C7EC File Offset: 0x0004A9EC
		public static ILetGoDestroyCondition Create([Nullable(2)] ILetGoDestroyCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILetGoDestroyCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0004C7FF File Offset: 0x0004A9FF
		public static ILetGoDestroyCondition CreateFromSetValue([Nullable(2)] ILetGoDestroyCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILetGoDestroyCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0004C812 File Offset: 0x0004AA12
		public new ILetGoDestroyCondition_SetValue ToSetValue()
		{
			return new ILetGoDestroyCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0004C825 File Offset: 0x0004AA25
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x0004C850 File Offset: 0x0004AA50
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

		// Token: 0x04001322 RID: 4898
		[Nullable(2)]
		protected new ILetGoDestroyCondition FbInstance;

		// Token: 0x04001323 RID: 4899
		[Nullable(2)]
		protected new ILetGoDestroyCondition_SetValue PocoInterface;
	}
}
