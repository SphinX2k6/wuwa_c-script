using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E5 RID: 485
	[NullableContext(1)]
	[Nullable(0)]
	public class IBaseRoleNpcPerform : ISpecialNpcPerformType
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x00025A4C File Offset: 0x00023C4C
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

		// Token: 0x060007D7 RID: 2007 RVA: 0x00025A84 File Offset: 0x00023C84
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

		// Token: 0x060007D8 RID: 2008 RVA: 0x00025A97 File Offset: 0x00023C97
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

		// Token: 0x060007D9 RID: 2009 RVA: 0x00025AAA File Offset: 0x00023CAA
		public new IBaseRoleNpcPerform_SetValue ToSetValue()
		{
			return new IBaseRoleNpcPerform_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00025ABD File Offset: 0x00023CBD
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x00025AE8 File Offset: 0x00023CE8
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

		// Token: 0x040008D3 RID: 2259
		[Nullable(2)]
		protected new IBaseRoleNpcPerform FbInstance;

		// Token: 0x040008D4 RID: 2260
		[Nullable(2)]
		protected new IBaseRoleNpcPerform_SetValue PocoInterface;
	}
}
