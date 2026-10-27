using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019A4 RID: 6564
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableAllPlayerOperationConverter))]
	public class IDisableAllPlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x06008C73 RID: 35955 RVA: 0x00149818 File Offset: 0x00147A18
		private IDisableAllPlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableAllPlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableAllPlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableAllPlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x00149850 File Offset: 0x00147A50
		public static IDisableAllPlayerOperation Create([Nullable(2)] IDisableAllPlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAllPlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x00149863 File Offset: 0x00147A63
		public static IDisableAllPlayerOperation CreateFromSetValue([Nullable(2)] IDisableAllPlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableAllPlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C76 RID: 35958 RVA: 0x00149876 File Offset: 0x00147A76
		public new IDisableAllPlayerOperation_SetValue ToSetValue()
		{
			return new IDisableAllPlayerOperation_SetValue
			{
				Type = this.Type,
				DisplayMode = this.DisplayMode,
				IsUiFadeEffect = this.IsUiFadeEffect
			};
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x001498A1 File Offset: 0x00147AA1
		// (set) Token: 0x06008C78 RID: 35960 RVA: 0x001498CC File Offset: 0x00147ACC
		public override EPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x06008C79 RID: 35961 RVA: 0x001498DC File Offset: 0x00147ADC
		// (set) Token: 0x06008C7A RID: 35962 RVA: 0x00149916 File Offset: 0x00147B16
		public virtual EDisplayModeInPlayerOp? DisplayMode
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DisplayMode;
				}
				IDisableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x00149924 File Offset: 0x00147B24
		// (set) Token: 0x06008C7C RID: 35964 RVA: 0x0014995E File Offset: 0x00147B5E
		public virtual bool? IsUiFadeEffect
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUiFadeEffect;
				}
				IDisableAllPlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsUiFadeEffect;
			}
			set
			{
				this.GetOrCreatePoco().IsUiFadeEffect = value;
			}
		}

		// Token: 0x0400576B RID: 22379
		[Nullable(2)]
		protected new IDisableAllPlayerOperation FbInstance;

		// Token: 0x0400576C RID: 22380
		[Nullable(2)]
		protected new IDisableAllPlayerOperation_SetValue PocoInterface;
	}
}
