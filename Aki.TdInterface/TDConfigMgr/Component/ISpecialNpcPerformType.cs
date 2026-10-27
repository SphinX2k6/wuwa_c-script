using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006F6 RID: 1782
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpecialNpcPerformType
	{
		// Token: 0x06002660 RID: 9824 RVA: 0x00066B68 File Offset: 0x00064D68
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

		// Token: 0x06002661 RID: 9825 RVA: 0x00066BA0 File Offset: 0x00064DA0
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

		// Token: 0x06002662 RID: 9826 RVA: 0x00066BB3 File Offset: 0x00064DB3
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

		// Token: 0x06002663 RID: 9827 RVA: 0x00066BC6 File Offset: 0x00064DC6
		public ISpecialNpcPerformType_SetValue ToSetValue()
		{
			return new ISpecialNpcPerformType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x00066BD9 File Offset: 0x00064DD9
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x00066C04 File Offset: 0x00064E04
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

		// Token: 0x04001A0E RID: 6670
		[Nullable(2)]
		protected ISpecialNpcPerformType FbInstance;

		// Token: 0x04001A0F RID: 6671
		[Nullable(2)]
		protected ISpecialNpcPerformType_SetValue PocoInterface;
	}
}
