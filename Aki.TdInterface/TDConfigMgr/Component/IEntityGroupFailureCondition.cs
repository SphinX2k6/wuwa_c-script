using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200031D RID: 797
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityGroupFailureCondition
	{
		// Token: 0x06000FAA RID: 4010 RVA: 0x000373B0 File Offset: 0x000355B0
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

		// Token: 0x06000FAB RID: 4011 RVA: 0x000373E8 File Offset: 0x000355E8
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

		// Token: 0x06000FAC RID: 4012 RVA: 0x000373FB File Offset: 0x000355FB
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

		// Token: 0x06000FAD RID: 4013 RVA: 0x0003740E File Offset: 0x0003560E
		public IEntityGroupFailureCondition_SetValue ToSetValue()
		{
			return new IEntityGroupFailureCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00037421 File Offset: 0x00035621
		// (set) Token: 0x06000FAF RID: 4015 RVA: 0x0003744C File Offset: 0x0003564C
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

		// Token: 0x04000D5F RID: 3423
		[Nullable(2)]
		protected IEntityGroupFailureCondition FbInstance;

		// Token: 0x04000D60 RID: 3424
		[Nullable(2)]
		protected IEntityGroupFailureCondition_SetValue PocoInterface;
	}
}
