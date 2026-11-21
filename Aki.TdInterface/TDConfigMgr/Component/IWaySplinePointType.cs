using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200087A RID: 2170
	public class IWaySplinePointType
	{
		// Token: 0x06002EC5 RID: 11973 RVA: 0x00078DC0 File Offset: 0x00076FC0
		private IWaySplinePointType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWaySplinePointType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWaySplinePointType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWaySplinePointType_SetValue());
			}
			return result;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00078DF8 File Offset: 0x00076FF8
		public static IWaySplinePointType Create([Nullable(2)] IWaySplinePointType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaySplinePointType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00078E0B File Offset: 0x0007700B
		public static IWaySplinePointType CreateFromSetValue([Nullable(2)] IWaySplinePointType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWaySplinePointType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00078E1E File Offset: 0x0007701E
		public IWaySplinePointType_SetValue ToSetValue()
		{
			return new IWaySplinePointType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x00078E31 File Offset: 0x00077031
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x00078E5C File Offset: 0x0007705C
		public virtual EWaySplinePointType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWaySplinePointType.Common;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001EFB RID: 7931
		[Nullable(2)]
		protected IWaySplinePointType FbInstance;

		// Token: 0x04001EFC RID: 7932
		[Nullable(2)]
		protected IWaySplinePointType_SetValue PocoInterface;
	}
}
