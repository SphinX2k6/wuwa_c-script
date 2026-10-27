using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E77 RID: 7799
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkiConfig : ISportConfig
	{
		// Token: 0x0600A6EA RID: 42730 RVA: 0x001798EC File Offset: 0x00177AEC
		private ISkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x00179924 File Offset: 0x00177B24
		public static ISkiConfig Create([Nullable(2)] ISkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x00179937 File Offset: 0x00177B37
		public static ISkiConfig CreateFromSetValue([Nullable(2)] ISkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x0017994A File Offset: 0x00177B4A
		public new ISkiConfig_SetValue ToSetValue()
		{
			return new ISkiConfig_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600A6EE RID: 42734 RVA: 0x00179969 File Offset: 0x00177B69
		// (set) Token: 0x0600A6EF RID: 42735 RVA: 0x00179994 File Offset: 0x00177B94
		public override ESportStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESportStateType.Slide;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600A6F0 RID: 42736 RVA: 0x001799A2 File Offset: 0x00177BA2
		// (set) Token: 0x0600A6F1 RID: 42737 RVA: 0x001799C9 File Offset: 0x00177BC9
		public virtual ISkiConfigType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ISkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x040063A7 RID: 25511
		[Nullable(2)]
		protected new ISkiConfig FbInstance;

		// Token: 0x040063A8 RID: 25512
		[Nullable(2)]
		protected new ISkiConfig_SetValue PocoInterface;
	}
}
