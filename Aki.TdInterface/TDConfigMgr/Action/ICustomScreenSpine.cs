using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001952 RID: 6482
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomScreenSpine : ICustomScreenTypeBase
	{
		// Token: 0x06008ADF RID: 35551 RVA: 0x00146D08 File Offset: 0x00144F08
		private ICustomScreenSpine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenSpine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenSpine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenSpine_SetValue());
			}
			return result;
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x00146D40 File Offset: 0x00144F40
		public static ICustomScreenSpine Create([Nullable(2)] ICustomScreenSpine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenSpine
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x00146D53 File Offset: 0x00144F53
		public static ICustomScreenSpine CreateFromSetValue([Nullable(2)] ICustomScreenSpine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenSpine
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x00146D66 File Offset: 0x00144F66
		public new ICustomScreenSpine_SetValue ToSetValue()
		{
			return new ICustomScreenSpine_SetValue
			{
				Type = this.Type,
				SpineId = this.SpineId
			};
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x06008AE3 RID: 35555 RVA: 0x00146D85 File Offset: 0x00144F85
		// (set) Token: 0x06008AE4 RID: 35556 RVA: 0x00146DB0 File Offset: 0x00144FB0
		public override ECustomScreenType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenType.Spine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x06008AE5 RID: 35557 RVA: 0x00146DBE File Offset: 0x00144FBE
		// (set) Token: 0x06008AE6 RID: 35558 RVA: 0x00146DE9 File Offset: 0x00144FE9
		public virtual int SpineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpineId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SpineId;
			}
			set
			{
				this.GetOrCreatePoco().SpineId = value;
			}
		}

		// Token: 0x040056B8 RID: 22200
		[Nullable(2)]
		protected new ICustomScreenSpine FbInstance;

		// Token: 0x040056B9 RID: 22201
		[Nullable(2)]
		protected new ICustomScreenSpine_SetValue PocoInterface;
	}
}
