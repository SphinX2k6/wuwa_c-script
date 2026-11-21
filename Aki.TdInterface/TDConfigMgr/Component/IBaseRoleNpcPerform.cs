using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200020E RID: 526
	public class IBaseRoleNpcPerform : ISpecialNpcPerformType
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x000273A0 File Offset: 0x000255A0
		private IBaseRoleNpcPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBaseRoleNpcPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBaseRoleNpcPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBaseRoleNpcPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x000273D8 File Offset: 0x000255D8
		public static IBaseRoleNpcPerform Create([Nullable(2)] IBaseRoleNpcPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBaseRoleNpcPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000273EB File Offset: 0x000255EB
		public static IBaseRoleNpcPerform CreateFromSetValue([Nullable(2)] IBaseRoleNpcPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBaseRoleNpcPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000273FE File Offset: 0x000255FE
		public new IBaseRoleNpcPerform_SetValue ToSetValue()
		{
			return new IBaseRoleNpcPerform_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00027411 File Offset: 0x00025611
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x0002743C File Offset: 0x0002563C
		public override ESpecialNpcType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialNpcType.BaseRoleNpc;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000964 RID: 2404
		[Nullable(2)]
		protected new IBaseRoleNpcPerform FbInstance;

		// Token: 0x04000965 RID: 2405
		[Nullable(2)]
		protected new IBaseRoleNpcPerform_SetValue PocoInterface;
	}
}
