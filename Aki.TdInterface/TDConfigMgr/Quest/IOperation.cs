using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200102F RID: 4143
	[NullableContext(1)]
	[Nullable(0)]
	public class IOperation
	{
		// Token: 0x06005C68 RID: 23656 RVA: 0x000DFCC0 File Offset: 0x000DDEC0
		private IOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06005C69 RID: 23657 RVA: 0x000DFCF8 File Offset: 0x000DDEF8
		public static IOperation Create([Nullable(2)] IOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C6A RID: 23658 RVA: 0x000DFD0B File Offset: 0x000DDF0B
		public static IOperation CreateFromSetValue([Nullable(2)] IOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C6B RID: 23659 RVA: 0x000DFD1E File Offset: 0x000DDF1E
		public IOperation_SetValue ToSetValue()
		{
			return new IOperation_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x06005C6C RID: 23660 RVA: 0x000DFD31 File Offset: 0x000DDF31
		// (set) Token: 0x06005C6D RID: 23661 RVA: 0x000DFD5C File Offset: 0x000DDF5C
		public virtual EOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOperation.DisableHLOD;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04003794 RID: 14228
		[Nullable(2)]
		protected IOperation FbInstance;

		// Token: 0x04003795 RID: 14229
		[Nullable(2)]
		protected IOperation_SetValue PocoInterface;
	}
}
