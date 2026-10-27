using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000470 RID: 1136
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitStateWuYinQu : IInitState
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x000460DC File Offset: 0x000442DC
		private IInitStateWuYinQu_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateWuYinQu 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateWuYinQu_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateWuYinQu_SetValue());
			}
			return result;
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00046114 File Offset: 0x00044314
		public static IInitStateWuYinQu Create([Nullable(2)] IInitStateWuYinQu instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateWuYinQu
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00046127 File Offset: 0x00044327
		public static IInitStateWuYinQu CreateFromSetValue([Nullable(2)] IInitStateWuYinQu_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateWuYinQu
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0004613A File Offset: 0x0004433A
		public new IInitStateWuYinQu_SetValue ToSetValue()
		{
			return new IInitStateWuYinQu_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x0004614D File Offset: 0x0004434D
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00046178 File Offset: 0x00044378
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001153 RID: 4435
		[Nullable(2)]
		protected new IInitStateWuYinQu FbInstance;

		// Token: 0x04001154 RID: 4436
		[Nullable(2)]
		protected new IInitStateWuYinQu_SetValue PocoInterface;
	}
}
