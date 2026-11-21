using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C46 RID: 7238
	public class IFocusOnCustomMapMark : IFocusOnMapMark
	{
		// Token: 0x060099F8 RID: 39416 RVA: 0x00164A3C File Offset: 0x00162C3C
		private IFocusOnCustomMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFocusOnCustomMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFocusOnCustomMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFocusOnCustomMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x00164A74 File Offset: 0x00162C74
		public static IFocusOnCustomMapMark Create([Nullable(2)] IFocusOnCustomMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnCustomMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00164A87 File Offset: 0x00162C87
		public static IFocusOnCustomMapMark CreateFromSetValue([Nullable(2)] IFocusOnCustomMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFocusOnCustomMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x060099FB RID: 39419 RVA: 0x00164A9A File Offset: 0x00162C9A
		public new IFocusOnCustomMapMark_SetValue ToSetValue()
		{
			return new IFocusOnCustomMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId
			};
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x060099FC RID: 39420 RVA: 0x00164AB9 File Offset: 0x00162CB9
		// (set) Token: 0x060099FD RID: 39421 RVA: 0x00164AE4 File Offset: 0x00162CE4
		public override EMapMarkType Type
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

		// Token: 0x170030A1 RID: 12449
		// (get) Token: 0x060099FE RID: 39422 RVA: 0x00164AF2 File Offset: 0x00162CF2
		// (set) Token: 0x060099FF RID: 39423 RVA: 0x00164B1D File Offset: 0x00162D1D
		public virtual int MarkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MarkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MarkId;
			}
			set
			{
				this.GetOrCreatePoco().MarkId = value;
			}
		}

		// Token: 0x04005EA1 RID: 24225
		[Nullable(2)]
		protected new IFocusOnCustomMapMark FbInstance;

		// Token: 0x04005EA2 RID: 24226
		[Nullable(2)]
		protected new IFocusOnCustomMapMark_SetValue PocoInterface;
	}
}
