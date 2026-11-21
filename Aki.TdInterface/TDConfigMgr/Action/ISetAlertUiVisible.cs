using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002039 RID: 8249
	public class ISetAlertUiVisible : IAlertSystemOption
	{
		// Token: 0x0600AF19 RID: 44825 RVA: 0x0018A9A0 File Offset: 0x00188BA0
		private ISetAlertUiVisible_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetAlertUiVisible 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetAlertUiVisible_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetAlertUiVisible_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF1A RID: 44826 RVA: 0x0018A9D8 File Offset: 0x00188BD8
		public static ISetAlertUiVisible Create([Nullable(2)] ISetAlertUiVisible instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertUiVisible
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF1B RID: 44827 RVA: 0x0018A9EB File Offset: 0x00188BEB
		public static ISetAlertUiVisible CreateFromSetValue([Nullable(2)] ISetAlertUiVisible_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetAlertUiVisible
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF1C RID: 44828 RVA: 0x0018A9FE File Offset: 0x00188BFE
		public new ISetAlertUiVisible_SetValue ToSetValue()
		{
			return new ISetAlertUiVisible_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x0018AA29 File Offset: 0x00188C29
		// (set) Token: 0x0600AF1E RID: 44830 RVA: 0x0018AA54 File Offset: 0x00188C54
		public override EAlertSystemOption Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAlertSystemOption.EnableAlertArea;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600AF1F RID: 44831 RVA: 0x0018AA62 File Offset: 0x00188C62
		// (set) Token: 0x0600AF20 RID: 44832 RVA: 0x0018AA8D File Offset: 0x00188C8D
		public override int AreaId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AreaId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.AreaId;
			}
			set
			{
				this.GetOrCreatePoco().AreaId = value;
			}
		}

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600AF21 RID: 44833 RVA: 0x0018AA9B File Offset: 0x00188C9B
		// (set) Token: 0x0600AF22 RID: 44834 RVA: 0x0018AAC6 File Offset: 0x00188CC6
		public virtual bool IsVisible
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsVisible;
				}
				return this.PocoInterface != null && this.PocoInterface.IsVisible;
			}
			set
			{
				this.GetOrCreatePoco().IsVisible = value;
			}
		}

		// Token: 0x04006850 RID: 26704
		[Nullable(2)]
		protected new ISetAlertUiVisible FbInstance;

		// Token: 0x04006851 RID: 26705
		[Nullable(2)]
		protected new ISetAlertUiVisible_SetValue PocoInterface;
	}
}
