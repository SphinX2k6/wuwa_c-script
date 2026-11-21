using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E19 RID: 7705
	public class IMotorRadioUiFunction : EnableFunction
	{
		// Token: 0x0600A3DF RID: 41951 RVA: 0x0017695C File Offset: 0x00174B5C
		private IMotorRadioUiFunction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMotorRadioUiFunction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMotorRadioUiFunction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMotorRadioUiFunction_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x00176994 File Offset: 0x00174B94
		public static IMotorRadioUiFunction Create([Nullable(2)] IMotorRadioUiFunction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMotorRadioUiFunction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3E1 RID: 41953 RVA: 0x001769A7 File Offset: 0x00174BA7
		public static IMotorRadioUiFunction CreateFromSetValue([Nullable(2)] IMotorRadioUiFunction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMotorRadioUiFunction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3E2 RID: 41954 RVA: 0x001769BA File Offset: 0x00174BBA
		public new IMotorRadioUiFunction_SetValue ToSetValue()
		{
			return new IMotorRadioUiFunction_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode
			};
		}

		// Token: 0x170032D8 RID: 13016
		// (get) Token: 0x0600A3E3 RID: 41955 RVA: 0x001769D9 File Offset: 0x00174BD9
		// (set) Token: 0x0600A3E4 RID: 41956 RVA: 0x00176A04 File Offset: 0x00174C04
		public override EEnableFunctionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032D9 RID: 13017
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x00176A12 File Offset: 0x00174C12
		// (set) Token: 0x0600A3E6 RID: 41958 RVA: 0x00176A39 File Offset: 0x00174C39
		public virtual IMotorRadioOperationRestriction DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IMotorRadioUiFunction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DisplayMode;
			}
			set
			{
				this.GetOrCreatePoco().DisplayMode = value;
			}
		}

		// Token: 0x04006331 RID: 25393
		[Nullable(2)]
		protected new IMotorRadioUiFunction FbInstance;

		// Token: 0x04006332 RID: 25394
		[Nullable(2)]
		protected new IMotorRadioUiFunction_SetValue PocoInterface;
	}
}
