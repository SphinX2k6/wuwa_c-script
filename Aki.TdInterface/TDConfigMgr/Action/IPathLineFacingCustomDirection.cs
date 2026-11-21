using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ECB RID: 7883
	public class IPathLineFacingCustomDirection : IPathLineFacingType
	{
		// Token: 0x0600A7C3 RID: 42947 RVA: 0x0017D7B0 File Offset: 0x0017B9B0
		private IPathLineFacingCustomDirection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPathLineFacingCustomDirection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPathLineFacingCustomDirection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPathLineFacingCustomDirection_SetValue());
			}
			return result;
		}

		// Token: 0x0600A7C4 RID: 42948 RVA: 0x0017D7E8 File Offset: 0x0017B9E8
		public static IPathLineFacingCustomDirection Create([Nullable(2)] IPathLineFacingCustomDirection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPathLineFacingCustomDirection
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A7C5 RID: 42949 RVA: 0x0017D7FB File Offset: 0x0017B9FB
		public static IPathLineFacingCustomDirection CreateFromSetValue([Nullable(2)] IPathLineFacingCustomDirection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPathLineFacingCustomDirection
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x0017D80E File Offset: 0x0017BA0E
		public new IPathLineFacingCustomDirection_SetValue ToSetValue()
		{
			return new IPathLineFacingCustomDirection_SetValue
			{
				Type = this.Type,
				Yaw = this.Yaw
			};
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600A7C7 RID: 42951 RVA: 0x0017D82D File Offset: 0x0017BA2D
		// (set) Token: 0x0600A7C8 RID: 42952 RVA: 0x0017D858 File Offset: 0x0017BA58
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

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x0600A7C9 RID: 42953 RVA: 0x0017D866 File Offset: 0x0017BA66
		// (set) Token: 0x0600A7CA RID: 42954 RVA: 0x0017D895 File Offset: 0x0017BA95
		public virtual float Yaw
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Yaw;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Yaw;
			}
			set
			{
				this.GetOrCreatePoco().Yaw = value;
			}
		}

		// Token: 0x040064F4 RID: 25844
		[Nullable(2)]
		protected new IPathLineFacingCustomDirection FbInstance;

		// Token: 0x040064F5 RID: 25845
		[Nullable(2)]
		protected new IPathLineFacingCustomDirection_SetValue PocoInterface;
	}
}
