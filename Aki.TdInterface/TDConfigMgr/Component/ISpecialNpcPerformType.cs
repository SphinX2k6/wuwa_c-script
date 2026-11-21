using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000797 RID: 1943
	public class ISpecialNpcPerformType
	{
		// Token: 0x06002980 RID: 10624 RVA: 0x0006DBD8 File Offset: 0x0006BDD8
		private ISpecialNpcPerformType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISpecialNpcPerformType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISpecialNpcPerformType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISpecialNpcPerformType_SetValue());
			}
			return result;
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0006DC10 File Offset: 0x0006BE10
		public static ISpecialNpcPerformType Create([Nullable(2)] ISpecialNpcPerformType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISpecialNpcPerformType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0006DC23 File Offset: 0x0006BE23
		public static ISpecialNpcPerformType CreateFromSetValue([Nullable(2)] ISpecialNpcPerformType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISpecialNpcPerformType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x0006DC36 File Offset: 0x0006BE36
		public ISpecialNpcPerformType_SetValue ToSetValue()
		{
			return new ISpecialNpcPerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002984 RID: 10628 RVA: 0x0006DC49 File Offset: 0x0006BE49
		// (set) Token: 0x06002985 RID: 10629 RVA: 0x0006DC74 File Offset: 0x0006BE74
		public virtual ESpecialNpcType Type
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

		// Token: 0x04001C0D RID: 7181
		[Nullable(2)]
		protected ISpecialNpcPerformType FbInstance;

		// Token: 0x04001C0E RID: 7182
		[Nullable(2)]
		protected ISpecialNpcPerformType_SetValue PocoInterface;
	}
}
