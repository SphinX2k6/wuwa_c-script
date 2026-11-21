using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B69 RID: 7017
	public class IEnableAlertUi : IAlertSystemOption
	{
		// Token: 0x0600950B RID: 38155 RVA: 0x0015BAF4 File Offset: 0x00159CF4
		private IEnableAlertUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableAlertUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableAlertUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableAlertUi_SetValue());
			}
			return result;
		}

		// Token: 0x0600950C RID: 38156 RVA: 0x0015BB2C File Offset: 0x00159D2C
		public static IEnableAlertUi Create([Nullable(2)] IEnableAlertUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableAlertUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600950D RID: 38157 RVA: 0x0015BB3F File Offset: 0x00159D3F
		public static IEnableAlertUi CreateFromSetValue([Nullable(2)] IEnableAlertUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableAlertUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600950E RID: 38158 RVA: 0x0015BB52 File Offset: 0x00159D52
		public new IEnableAlertUi_SetValue ToSetValue()
		{
			return new IEnableAlertUi_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId,
				IsEnable = this.IsEnable
			};
		}

		// Token: 0x17002F74 RID: 12148
		// (get) Token: 0x0600950F RID: 38159 RVA: 0x0015BB7D File Offset: 0x00159D7D
		// (set) Token: 0x06009510 RID: 38160 RVA: 0x0015BBA8 File Offset: 0x00159DA8
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

		// Token: 0x17002F75 RID: 12149
		// (get) Token: 0x06009511 RID: 38161 RVA: 0x0015BBB6 File Offset: 0x00159DB6
		// (set) Token: 0x06009512 RID: 38162 RVA: 0x0015BBE1 File Offset: 0x00159DE1
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

		// Token: 0x17002F76 RID: 12150
		// (get) Token: 0x06009513 RID: 38163 RVA: 0x0015BBEF File Offset: 0x00159DEF
		// (set) Token: 0x06009514 RID: 38164 RVA: 0x0015BC1A File Offset: 0x00159E1A
		public virtual bool IsEnable
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsEnable;
				}
				return this.PocoInterface != null && this.PocoInterface.IsEnable;
			}
			set
			{
				this.GetOrCreatePoco().IsEnable = value;
			}
		}

		// Token: 0x04005C5B RID: 23643
		[Nullable(2)]
		protected new IEnableAlertUi FbInstance;

		// Token: 0x04005C5C RID: 23644
		[Nullable(2)]
		protected new IEnableAlertUi_SetValue PocoInterface;
	}
}
