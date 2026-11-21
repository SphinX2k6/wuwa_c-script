using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC9 RID: 7881
	public class IPathLineFacingCurrentDirection : IPathLineFacingType
	{
		// Token: 0x0600A7B9 RID: 42937 RVA: 0x0017D6A0 File Offset: 0x0017B8A0
		private IPathLineFacingCurrentDirection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineFacingCurrentDirection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineFacingCurrentDirection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineFacingCurrentDirection_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7BA RID: 42938 RVA: 0x0017D6D8 File Offset: 0x0017B8D8
		public static IPathLineFacingCurrentDirection Create([Nullable(2)] IPathLineFacingCurrentDirection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCurrentDirection
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7BB RID: 42939 RVA: 0x0017D6EB File Offset: 0x0017B8EB
		public static IPathLineFacingCurrentDirection CreateFromSetValue([Nullable(2)] IPathLineFacingCurrentDirection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineFacingCurrentDirection
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7BC RID: 42940 RVA: 0x0017D6FE File Offset: 0x0017B8FE
		public new IPathLineFacingCurrentDirection_SetValue ToSetValue()
		{
			return new IPathLineFacingCurrentDirection_SetValue
			{
				Type = this.Type,
				YawOffset = this.YawOffset
			};
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600A7BD RID: 42941 RVA: 0x0017D71D File Offset: 0x0017B91D
		// (set) Token: 0x0600A7BE RID: 42942 RVA: 0x0017D748 File Offset: 0x0017B948
		public override EPathLineFacingType Type
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

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600A7BF RID: 42943 RVA: 0x0017D758 File Offset: 0x0017B958
		// (set) Token: 0x0600A7C0 RID: 42944 RVA: 0x0017D792 File Offset: 0x0017B992
		public virtual float? YawOffset
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.YawOffset;
				}
				IPathLineFacingCurrentDirection_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.YawOffset;
			}
			set
			{
				this.GetOrCreatePoco().YawOffset = value;
			}
		}

		// Token: 0x040064F0 RID: 25840
		[Nullable(2)]
		protected new IPathLineFacingCurrentDirection FbInstance;

		// Token: 0x040064F1 RID: 25841
		[Nullable(2)]
		protected new IPathLineFacingCurrentDirection_SetValue PocoInterface;
	}
}
