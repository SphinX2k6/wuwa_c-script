using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019DC RID: 6620
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableAlertUi : IAlertSystemOption
	{
		// Token: 0x06008DC9 RID: 36297 RVA: 0x0014BFE8 File Offset: 0x0014A1E8
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

		// Token: 0x06008DCA RID: 36298 RVA: 0x0014C020 File Offset: 0x0014A220
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

		// Token: 0x06008DCB RID: 36299 RVA: 0x0014C033 File Offset: 0x0014A233
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

		// Token: 0x06008DCC RID: 36300 RVA: 0x0014C046 File Offset: 0x0014A246
		public new IEnableAlertUi_SetValue ToSetValue()
		{
			return new IEnableAlertUi_SetValue
			{
				Type = this.Type,
				AreaId = this.AreaId,
				IsEnable = this.IsEnable
			};
		}

		// Token: 0x17002D6F RID: 11631
		// (get) Token: 0x06008DCD RID: 36301 RVA: 0x0014C071 File Offset: 0x0014A271
		// (set) Token: 0x06008DCE RID: 36302 RVA: 0x0014C09C File Offset: 0x0014A29C
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

		// Token: 0x17002D70 RID: 11632
		// (get) Token: 0x06008DCF RID: 36303 RVA: 0x0014C0AA File Offset: 0x0014A2AA
		// (set) Token: 0x06008DD0 RID: 36304 RVA: 0x0014C0D5 File Offset: 0x0014A2D5
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

		// Token: 0x17002D71 RID: 11633
		// (get) Token: 0x06008DD1 RID: 36305 RVA: 0x0014C0E3 File Offset: 0x0014A2E3
		// (set) Token: 0x06008DD2 RID: 36306 RVA: 0x0014C10E File Offset: 0x0014A30E
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

		// Token: 0x04005806 RID: 22534
		[Nullable(2)]
		protected new IEnableAlertUi FbInstance;

		// Token: 0x04005807 RID: 22535
		[Nullable(2)]
		protected new IEnableAlertUi_SetValue PocoInterface;
	}
}
