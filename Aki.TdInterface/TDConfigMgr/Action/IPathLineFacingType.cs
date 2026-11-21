using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ECD RID: 7885
	public class IPathLineFacingType
	{
		// Token: 0x0600A7CD RID: 42957 RVA: 0x0017D8B4 File Offset: 0x0017BAB4
		private IPathLineFacingType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineFacingType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineFacingType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineFacingType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7CE RID: 42958 RVA: 0x0017D8EC File Offset: 0x0017BAEC
		public static IPathLineFacingType Create([Nullable(2)] IPathLineFacingType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7CF RID: 42959 RVA: 0x0017D8FF File Offset: 0x0017BAFF
		public static IPathLineFacingType CreateFromSetValue([Nullable(2)] IPathLineFacingType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineFacingType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7D0 RID: 42960 RVA: 0x0017D912 File Offset: 0x0017BB12
		public IPathLineFacingType_SetValue ToSetValue()
		{
			return new IPathLineFacingType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x0600A7D1 RID: 42961 RVA: 0x0017D925 File Offset: 0x0017BB25
		// (set) Token: 0x0600A7D2 RID: 42962 RVA: 0x0017D950 File Offset: 0x0017BB50
		public virtual EPathLineFacingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPathLineFacingType.Current;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064F8 RID: 25848
		[Nullable(2)]
		protected IPathLineFacingType FbInstance;

		// Token: 0x040064F9 RID: 25849
		[Nullable(2)]
		protected IPathLineFacingType_SetValue PocoInterface;
	}
}
