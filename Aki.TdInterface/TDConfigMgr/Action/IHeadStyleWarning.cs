using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AF5 RID: 6901
	[NullableContext(1)]
	[Nullable(0)]
	public class IHeadStyleWarning : IHeadStyle
	{
		// Token: 0x060093D2 RID: 37842 RVA: 0x00156C10 File Offset: 0x00154E10
		private IHeadStyleWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleWarning_SetValue());
			}
			return result;
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x00156C48 File Offset: 0x00154E48
		public static IHeadStyleWarning Create([Nullable(2)] IHeadStyleWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x00156C5B File Offset: 0x00154E5B
		public static IHeadStyleWarning CreateFromSetValue([Nullable(2)] IHeadStyleWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x00156C6E File Offset: 0x00154E6E
		public new IHeadStyleWarning_SetValue ToSetValue()
		{
			return new IHeadStyleWarning_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002ECF RID: 11983
		// (get) Token: 0x060093D6 RID: 37846 RVA: 0x00156C81 File Offset: 0x00154E81
		// (set) Token: 0x060093D7 RID: 37847 RVA: 0x00156CAC File Offset: 0x00154EAC
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005AC2 RID: 23234
		[Nullable(2)]
		protected new IHeadStyleWarning FbInstance;

		// Token: 0x04005AC3 RID: 23235
		[Nullable(2)]
		protected new IHeadStyleWarning_SetValue PocoInterface;
	}
}
