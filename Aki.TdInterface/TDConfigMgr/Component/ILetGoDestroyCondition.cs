using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004AE RID: 1198
	[NullableContext(1)]
	[Nullable(0)]
	public class ILetGoDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x06001834 RID: 6196 RVA: 0x00048A6C File Offset: 0x00046C6C
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

		// Token: 0x06001835 RID: 6197 RVA: 0x00048AA4 File Offset: 0x00046CA4
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

		// Token: 0x06001836 RID: 6198 RVA: 0x00048AB7 File Offset: 0x00046CB7
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

		// Token: 0x06001837 RID: 6199 RVA: 0x00048ACA File Offset: 0x00046CCA
		public new ILetGoDestroyCondition_SetValue ToSetValue()
		{
			return new ILetGoDestroyCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001838 RID: 6200 RVA: 0x00048ADD File Offset: 0x00046CDD
		// (set) Token: 0x06001839 RID: 6201 RVA: 0x00048B08 File Offset: 0x00046D08
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

		// Token: 0x04001200 RID: 4608
		[Nullable(2)]
		protected new ILetGoDestroyCondition FbInstance;

		// Token: 0x04001201 RID: 4609
		[Nullable(2)]
		protected new ILetGoDestroyCondition_SetValue PocoInterface;
	}
}
