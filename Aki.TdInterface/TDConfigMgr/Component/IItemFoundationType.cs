using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200049E RID: 1182
	[NullableContext(1)]
	[Nullable(0)]
	public class IItemFoundationType
	{
		// Token: 0x060017D2 RID: 6098 RVA: 0x00047BF8 File Offset: 0x00045DF8
		private IItemFoundationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IItemFoundationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IItemFoundationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IItemFoundationType_SetValue());
			}
			return result;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00047C30 File Offset: 0x00045E30
		public static IItemFoundationType Create([Nullable(2)] IItemFoundationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IItemFoundationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00047C43 File Offset: 0x00045E43
		public static IItemFoundationType CreateFromSetValue([Nullable(2)] IItemFoundationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IItemFoundationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00047C56 File Offset: 0x00045E56
		public IItemFoundationType_SetValue ToSetValue()
		{
			return new IItemFoundationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x00047C69 File Offset: 0x00045E69
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00047C94 File Offset: 0x00045E94
		public virtual EItemFoundation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EItemFoundation.CategoryMatching;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040011C3 RID: 4547
		[Nullable(2)]
		protected IItemFoundationType FbInstance;

		// Token: 0x040011C4 RID: 4548
		[Nullable(2)]
		protected IItemFoundationType_SetValue PocoInterface;
	}
}
