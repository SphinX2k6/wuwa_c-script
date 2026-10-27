using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E06 RID: 7686
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetAlertUiVisible : IAlertSystemOption
	{
		// Token: 0x0600A471 RID: 42097 RVA: 0x00174F98 File Offset: 0x00173198
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

		// Token: 0x0600A472 RID: 42098 RVA: 0x00174FD0 File Offset: 0x001731D0
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

		// Token: 0x0600A473 RID: 42099 RVA: 0x00174FE3 File Offset: 0x001731E3
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

		// Token: 0x0600A474 RID: 42100 RVA: 0x00174FF6 File Offset: 0x001731F6
		public new ISetAlertUiVisible_SetValue ToSetValue()
		{
			return new ISetAlertUiVisible_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId,
				IsVisible = this.IsVisible
			};
		}

		// Token: 0x17003286 RID: 12934
		// (get) Token: 0x0600A475 RID: 42101 RVA: 0x00175021 File Offset: 0x00173221
		// (set) Token: 0x0600A476 RID: 42102 RVA: 0x0017504C File Offset: 0x0017324C
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

		// Token: 0x17003287 RID: 12935
		// (get) Token: 0x0600A477 RID: 42103 RVA: 0x0017505A File Offset: 0x0017325A
		// (set) Token: 0x0600A478 RID: 42104 RVA: 0x00175085 File Offset: 0x00173285
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

		// Token: 0x17003288 RID: 12936
		// (get) Token: 0x0600A479 RID: 42105 RVA: 0x00175093 File Offset: 0x00173293
		// (set) Token: 0x0600A47A RID: 42106 RVA: 0x001750BE File Offset: 0x001732BE
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

		// Token: 0x04006279 RID: 25209
		[Nullable(2)]
		protected new ISetAlertUiVisible FbInstance;

		// Token: 0x0400627A RID: 25210
		[Nullable(2)]
		protected new ISetAlertUiVisible_SetValue PocoInterface;
	}
}
