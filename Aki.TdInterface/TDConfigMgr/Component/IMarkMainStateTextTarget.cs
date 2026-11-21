using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000531 RID: 1329
	[NullableContext(2)]
	[Nullable(0)]
	public class IMarkMainStateTextTarget
	{
		// Token: 0x06001AC0 RID: 6848 RVA: 0x0004E648 File Offset: 0x0004C848
		[NullableContext(0)]
		private IMarkMainStateTextTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMarkMainStateTextTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMarkMainStateTextTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMarkMainStateTextTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x0004E680 File Offset: 0x0004C880
		[NullableContext(0)]
		public static IMarkMainStateTextTarget Create([Nullable(2)] IMarkMainStateTextTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMarkMainStateTextTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x0004E693 File Offset: 0x0004C893
		[NullableContext(0)]
		public static IMarkMainStateTextTarget CreateFromSetValue([Nullable(2)] IMarkMainStateTextTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMarkMainStateTextTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x0004E6A6 File Offset: 0x0004C8A6
		[NullableContext(0)]
		public IMarkMainStateTextTarget_SetValue ToSetValue()
		{
			return new IMarkMainStateTextTarget_SetValue
			{
				TidTargetName = this.TidTargetName,
				EdTidTargetName = this.EdTidTargetName
			};
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0004E6C5 File Offset: 0x0004C8C5
		// (set) Token: 0x06001AC5 RID: 6853 RVA: 0x0004E6EC File Offset: 0x0004C8EC
		public virtual string TidTargetName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidTargetName;
				}
				IMarkMainStateTextTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidTargetName;
			}
			set
			{
				this.GetOrCreatePoco().TidTargetName = value;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0004E6FA File Offset: 0x0004C8FA
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0004E711 File Offset: 0x0004C911
		public virtual string EdTidTargetName
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidTargetName;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdTidTargetName = value;
			}
		}

		// Token: 0x040013A2 RID: 5026
		protected IMarkMainStateTextTarget FbInstance;

		// Token: 0x040013A3 RID: 5027
		protected IMarkMainStateTextTarget_SetValue PocoInterface;
	}
}
