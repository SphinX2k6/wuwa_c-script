using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AAF RID: 6831
	[NullableContext(1)]
	[Nullable(0)]
	public class IFocusOnMapMark
	{
		// Token: 0x06009282 RID: 37506 RVA: 0x00154950 File Offset: 0x00152B50
		private IFocusOnMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusOnMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusOnMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusOnMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x06009283 RID: 37507 RVA: 0x00154988 File Offset: 0x00152B88
		public static IFocusOnMapMark Create([Nullable(2)] IFocusOnMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009284 RID: 37508 RVA: 0x0015499B File Offset: 0x00152B9B
		public static IFocusOnMapMark CreateFromSetValue([Nullable(2)] IFocusOnMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusOnMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009285 RID: 37509 RVA: 0x001549AE File Offset: 0x00152BAE
		public IFocusOnMapMark_SetValue ToSetValue()
		{
			return new IFocusOnMapMark_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x06009286 RID: 37510 RVA: 0x001549C1 File Offset: 0x00152BC1
		// (set) Token: 0x06009287 RID: 37511 RVA: 0x001549EC File Offset: 0x00152BEC
		public virtual EMapMarkType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkType.Custom;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005A35 RID: 23093
		[Nullable(2)]
		protected IFocusOnMapMark FbInstance;

		// Token: 0x04005A36 RID: 23094
		[Nullable(2)]
		protected IFocusOnMapMark_SetValue PocoInterface;
	}
}
