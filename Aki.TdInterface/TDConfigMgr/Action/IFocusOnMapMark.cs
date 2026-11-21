using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C48 RID: 7240
	public class IFocusOnMapMark
	{
		// Token: 0x06009A02 RID: 39426 RVA: 0x00164B3C File Offset: 0x00162D3C
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

		// Token: 0x06009A03 RID: 39427 RVA: 0x00164B74 File Offset: 0x00162D74
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

		// Token: 0x06009A04 RID: 39428 RVA: 0x00164B87 File Offset: 0x00162D87
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

		// Token: 0x06009A05 RID: 39429 RVA: 0x00164B9A File Offset: 0x00162D9A
		public IFocusOnMapMark_SetValue ToSetValue()
		{
			return new IFocusOnMapMark_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A2 RID: 12450
		// (get) Token: 0x06009A06 RID: 39430 RVA: 0x00164BAD File Offset: 0x00162DAD
		// (set) Token: 0x06009A07 RID: 39431 RVA: 0x00164BD8 File Offset: 0x00162DD8
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

		// Token: 0x04005EA5 RID: 24229
		[Nullable(2)]
		protected IFocusOnMapMark FbInstance;

		// Token: 0x04005EA6 RID: 24230
		[Nullable(2)]
		protected IFocusOnMapMark_SetValue PocoInterface;
	}
}
