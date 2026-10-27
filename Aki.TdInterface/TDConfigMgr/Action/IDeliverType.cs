using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001988 RID: 6536
	[NullableContext(1)]
	[Nullable(0)]
	public class IDeliverType
	{
		// Token: 0x06008BF1 RID: 35825 RVA: 0x00148B28 File Offset: 0x00146D28
		private IDeliverType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDeliverType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDeliverType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDeliverType_SetValue());
			}
			return result;
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00148B60 File Offset: 0x00146D60
		public static IDeliverType Create([Nullable(2)] IDeliverType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDeliverType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x00148B73 File Offset: 0x00146D73
		public static IDeliverType CreateFromSetValue([Nullable(2)] IDeliverType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDeliverType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x00148B86 File Offset: 0x00146D86
		public IDeliverType_SetValue ToSetValue()
		{
			return new IDeliverType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x06008BF5 RID: 35829 RVA: 0x00148B99 File Offset: 0x00146D99
		// (set) Token: 0x06008BF6 RID: 35830 RVA: 0x00148BC4 File Offset: 0x00146DC4
		public virtual EDeliverType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDeliverType.ItemIdCellIndependent;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005736 RID: 22326
		[Nullable(2)]
		protected IDeliverType FbInstance;

		// Token: 0x04005737 RID: 22327
		[Nullable(2)]
		protected IDeliverType_SetValue PocoInterface;
	}
}
