using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A71 RID: 6769
	public class ICloseSkiConfig : ISkiConfigType
	{
		// Token: 0x06008FD3 RID: 36819 RVA: 0x00152A38 File Offset: 0x00150C38
		private ICloseSkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseSkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseSkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseSkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x00152A70 File Offset: 0x00150C70
		public static ICloseSkiConfig Create([Nullable(2)] ICloseSkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseSkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x00152A83 File Offset: 0x00150C83
		public static ICloseSkiConfig CreateFromSetValue([Nullable(2)] ICloseSkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseSkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x00152A96 File Offset: 0x00150C96
		public new ICloseSkiConfig_SetValue ToSetValue()
		{
			return new ICloseSkiConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target
			};
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x06008FD7 RID: 36823 RVA: 0x00152AB5 File Offset: 0x00150CB5
		// (set) Token: 0x06008FD8 RID: 36824 RVA: 0x00152AE0 File Offset: 0x00150CE0
		public override ESkiConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkiConfig.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x06008FD9 RID: 36825 RVA: 0x00152AEE File Offset: 0x00150CEE
		// (set) Token: 0x06008FDA RID: 36826 RVA: 0x00152B15 File Offset: 0x00150D15
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ICloseSkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x04005A13 RID: 23059
		[Nullable(2)]
		protected new ICloseSkiConfig FbInstance;

		// Token: 0x04005A14 RID: 23060
		[Nullable(2)]
		protected new ICloseSkiConfig_SetValue PocoInterface;
	}
}
