using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000680 RID: 1664
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderSpecifiedRangeType
	{
		// Token: 0x060023A2 RID: 9122 RVA: 0x000612E0 File Offset: 0x0005F4E0
		private IRenderSpecifiedRangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenderSpecifiedRangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenderSpecifiedRangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenderSpecifiedRangeType_SetValue());
			}
			return result;
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00061318 File Offset: 0x0005F518
		public static IRenderSpecifiedRangeType Create([Nullable(2)] IRenderSpecifiedRangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderSpecifiedRangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0006132B File Offset: 0x0005F52B
		public static IRenderSpecifiedRangeType CreateFromSetValue([Nullable(2)] IRenderSpecifiedRangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenderSpecifiedRangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0006133E File Offset: 0x0005F53E
		public IRenderSpecifiedRangeType_SetValue ToSetValue()
		{
			return new IRenderSpecifiedRangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x00061351 File Offset: 0x0005F551
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x0006137C File Offset: 0x0005F57C
		public virtual ERenderSpecifiedRangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERenderSpecifiedRangeType.FlowerBridge;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400189A RID: 6298
		[Nullable(2)]
		protected IRenderSpecifiedRangeType FbInstance;

		// Token: 0x0400189B RID: 6299
		[Nullable(2)]
		protected IRenderSpecifiedRangeType_SetValue PocoInterface;
	}
}
