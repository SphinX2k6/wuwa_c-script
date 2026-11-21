using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000364 RID: 868
	public class IEntityGroupFailureCondition
	{
		// Token: 0x060010DC RID: 4316 RVA: 0x0003A37C File Offset: 0x0003857C
		private IEntityGroupFailureCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityGroupFailureCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityGroupFailureCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityGroupFailureCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0003A3B4 File Offset: 0x000385B4
		public static IEntityGroupFailureCondition Create([Nullable(2)] IEntityGroupFailureCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityGroupFailureCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0003A3C7 File Offset: 0x000385C7
		public static IEntityGroupFailureCondition CreateFromSetValue([Nullable(2)] IEntityGroupFailureCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityGroupFailureCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003A3DA File Offset: 0x000385DA
		public IEntityGroupFailureCondition_SetValue ToSetValue()
		{
			return new IEntityGroupFailureCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x0003A3ED File Offset: 0x000385ED
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x0003A418 File Offset: 0x00038618
		public virtual EEntityGroupFailureCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEntityGroupFailureCondition.SequentialState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000E4A RID: 3658
		[Nullable(2)]
		protected IEntityGroupFailureCondition FbInstance;

		// Token: 0x04000E4B RID: 3659
		[Nullable(2)]
		protected IEntityGroupFailureCondition_SetValue PocoInterface;
	}
}
