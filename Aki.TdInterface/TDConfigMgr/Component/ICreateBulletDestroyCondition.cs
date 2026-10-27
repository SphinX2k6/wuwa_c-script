using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000291 RID: 657
	[NullableContext(1)]
	[Nullable(0)]
	public class ICreateBulletDestroyCondition : ITeleControlDestroyCondition
	{
		// Token: 0x06000C43 RID: 3139 RVA: 0x0002FD88 File Offset: 0x0002DF88
		private ICreateBulletDestroyCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICreateBulletDestroyCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICreateBulletDestroyCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICreateBulletDestroyCondition_SetValue());
			}
			return result;
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
		public static ICreateBulletDestroyCondition Create([Nullable(2)] ICreateBulletDestroyCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreateBulletDestroyCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0002FDD3 File Offset: 0x0002DFD3
		public static ICreateBulletDestroyCondition CreateFromSetValue([Nullable(2)] ICreateBulletDestroyCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICreateBulletDestroyCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0002FDE6 File Offset: 0x0002DFE6
		public new ICreateBulletDestroyCondition_SetValue ToSetValue()
		{
			return new ICreateBulletDestroyCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0002FDF9 File Offset: 0x0002DFF9
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x0002FE24 File Offset: 0x0002E024
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

		// Token: 0x04000B96 RID: 2966
		[Nullable(2)]
		protected new ICreateBulletDestroyCondition FbInstance;

		// Token: 0x04000B97 RID: 2967
		[Nullable(2)]
		protected new ICreateBulletDestroyCondition_SetValue PocoInterface;
	}
}
